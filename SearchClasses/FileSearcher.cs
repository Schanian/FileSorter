using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
//using Microsoft.VisualBasic.FileIO;
using System.Data;
namespace FileSorterLibrary
{
    public class FileSearcher
    {
       
        bool quitNow = false;
        public bool QuitNow { get { return quitNow; } }

        public delegate SearchData AsyncSearcher(string startPath, string extension, bool includeTempFiles,Logger log);
        static Guid nameSeedGuid;
        public string TempSaveLocation { get { 
                    if(nameSeedGuid == Guid.Empty) 
                            nameSeedGuid = Guid.NewGuid();
                    return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\" + nameSeedGuid + CHANIAN_EXTENSION;
        } }

   
        public void RequestAbort()
        {
                quitNow = true;
        }
        public string DefaultSaveLocation { get { return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\"; } }
        //public Delegate INotify OnNotify;
        
        public FileSearcher()
        {
            //Log = new Logger();
             
        }
        static AsyncCallback CallbackFunc;
        /// <summary>
        /// BeginSearcherAsync will kickoff the async search. 
        /// </summary>
        /// <param name="startPath">Folder Path where we want to start search</param>
        /// <param name="extension">filetype to search</param>
        /// <param name="includeTempFiles">Include Temporary files or not</param>
        /// <param name="Log">Logger to log the issue</param>
        /// <param name="callbackFunc">function to call once done</param>
        /// <returns> return the handle</returns>
        public IAsyncResult BeginSearcherAsync(string startPath, string extension, bool includeTempFiles,Logger Log, AsyncCallback callbackFunc)
        {
            AsyncSearcher searcher = SearchDuplicate;
            quitNow = false;
            IAsyncResult ar = searcher.BeginInvoke(startPath, extension, includeTempFiles, Log, finalCallbackMethod, null);

            CallbackFunc = callbackFunc;
            return ar;
        }

        /// <summary>
        /// BeginSearcherAsync will kickoff the async search. 
        /// </summary>
        /// <param name="startPath">Folder Path where we want to start search</param>
        /// <param name="extension">filetype to search</param>
        /// <param name="includeTempFiles">Include Temporary files or not</param>
        /// <param name="Log">Logger to log the issue</param>
        /// <param name="callbackFunc">function to call once done</param>
        /// <returns> return the handle</returns>
        private IAsyncResult localBeginSearcherAsync(string startPath, string extension, bool includeTempFiles, Logger Log, AsyncCallback callbackFunc)
        {
            AsyncSearcher searcher = SearchDuplicate;
            quitNow = false;
            IAsyncResult ar = searcher.BeginInvoke(startPath, extension, includeTempFiles, Log, localCallbackMethod, null);         
            return ar;
        }

        /// <summary>
        /// This callback will be used to merge data from all the threads
        /// </summary>
        /// <param name="ar"></param>
        private void localCallbackMethod(IAsyncResult ar)
        {

        }

        /// <summary>
        /// This callback will be used to merge data from all the threads
        /// </summary>
        /// <param name="ar"></param>
        private void finalCallbackMethod(IAsyncResult ar)
        {
            if (ar.IsCompleted)
            {
                CallbackFunc(ar);
            }
        }

        private SearchData SearchDuplicate(string startPath, string extension, bool includeTempFiles,Logger Log)
        {
            
            SearchData data = _searchDuplicate(startPath, extension, includeTempFiles,Log);
            Log.CloseLog();
            for (int i = 0; i < data.Documents.Count; i++)
            {
                SearchData.DocumentsRow row = data.Documents[i];
                
                if (data.ExactDuplicate.Any(r => r.ID_NoVersion == row.ID_NoVersion))
                    continue;
                if (data.MultipleVersion.Any(r => r.ID_NoVersion == row.ID_NoVersion))
                    continue;
                //remove row if there are no duplicate for this file
                data.Documents.RemoveDocumentsRow(row);
                i--;
            }
            data.Documents.DefaultView.Sort = "FileName,LastModifiedTime,FilePath";
            data.ExactDuplicate.DefaultView.Sort = "FileName,LastModifiedTime,FilePath";
            data.MultipleVersion.DefaultView.Sort = "FileName,LastModifiedTime,FilePath";
            try
            {
                SaveData(TempSaveLocation);
            }
            catch(Exception ex)
            {
                Log.WriteLog("Exception in SearchDuplicate " + ex.Message);
            }
            return data;
        }
        public SearchData GetData()
        {
            return searchData;
        }

        static SearchData searchData = new SearchData();
        /// <summary>
        /// _searchDuplicate - creates new thread and get the data
        /// </summary>
        /// <param name="startPath"></param>
        /// <param name="extension"></param>
        /// <param name="includeTempFiles"></param>
        /// <returns></returns>
        SearchData _searchDuplicate(string startPath, string extension, bool includeTempFiles, Logger log)
        {
            if (QuitNow) return searchData;
            SendMessage("FileSearcher Starting in "+startPath);

            IEnumerable<string> directories = new List<string>();

            //Enumerate all child directories
            if (Directory.Exists(startPath))
            {
                directories = Directory.EnumerateDirectories(startPath);
                if (directories != null && directories.Count<string>() >= 0)
                {
                    foreach (string directory in directories)
                    {
                        DirectoryInfo di = new DirectoryInfo(directory);
                        if (((di.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                                 || ((di.Attributes & FileAttributes.System) == FileAttributes.System)
                                 || ((di.Attributes & FileAttributes.Temporary) == FileAttributes.Temporary) && includeTempFiles)
                        {
                            continue;
                        }
                        IAsyncResult ar = BeginSearcherAsync(directory, extension, includeTempFiles, log, CallbackMethod);
                        SearchData dataInDir =
                        if (dataInDir != null) searchData.Merge(dataInDir);

                        if (QuitNow) return searchData;
                    }

                }
            }
          
            //Enumerate files in that directory only.
            IEnumerable<string> files = Directory.EnumerateFiles(startPath, extension, SearchOption.TopDirectoryOnly);
            //string[] files = Directory.GetFiles(startPath, extension, SearchOption.AllDirectories);
            SendMessage("Files in " + startPath + " Received.");
            SendMessage(" Processing files in " + startPath);
            foreach(string file in files)
            {
                //Quit with available result if Cancellation requested
                if (QuitNow) return searchData;
                FileInfo fi = new FileInfo(file);

                if (((fi.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        || ((fi.Attributes & FileAttributes.System) == FileAttributes.System)
                        || ((fi.Attributes & FileAttributes.Temporary) == FileAttributes.Temporary) && includeTempFiles)
                {
                    continue;
                }

                //To compare we dont need to use file name. 
                //1 # Possible duplicate - Compare = file length and extension and last update time.
                //2 # Matching different version - Compare = file name and file length and extension  
                //3 # Exact match file name and file length and extension and last update time
                string rowID = fi.Name + fi.Length.ToString() + fi.Extension;
              
                //Search for an exact duplicate
                if (searchData.Documents.FindByID(rowID + fi.LastWriteTimeUtc.Ticks.ToString()) != null)  //log a duplicate file found
                {
                    SearchData.ExactDuplicateRow counterRow = searchData.ExactDuplicate.NewExactDuplicateRow();
                    counterRow.FileName = fi.Name;
                    counterRow.ID = rowID;                        
                    counterRow.ID_NoVersion = rowID;
                    counterRow.FilePath = fi.DirectoryName;
                    counterRow.LastModifiedTime = fi.LastWriteTimeUtc;
                    counterRow.Size = fi.Length / 1024;
                    if (searchData.ExactDuplicate.FindByIDFilePath(counterRow.ID, counterRow.FilePath) == null)
                    {
                        searchData.ExactDuplicate.AddExactDuplicateRow(counterRow);
                    }
                }

                //Search for another version(Not an exact duplicate version)               
                else if (searchData.Documents.FindByID(rowID) != null
                    &&  searchData.Documents.Any(r => r.ID.StartsWith(rowID)))
                {
                        SearchData.MultipleVersionRow multipleVersionRow = searchData.MultipleVersion.NewMultipleVersionRow();
                        multipleVersionRow.FileName = fi.Name;
                        multipleVersionRow.ID_NoVersion = rowID;
                        multipleVersionRow.ID = rowID + fi.LastWriteTimeUtc.Ticks.ToString();
                        multipleVersionRow.FilePath = fi.DirectoryName;
                        multipleVersionRow.LastModifiedTime = fi.LastWriteTimeUtc;
                        multipleVersionRow.Size = fi.Length / 1024;
                        searchData.MultipleVersion.AddMultipleVersionRow(multipleVersionRow);
                }
                else// This file is not yet in the list
                {
                    SearchData.DocumentsRow row = searchData.Documents.NewDocumentsRow();
                    row.LastModifiedTime = fi.LastWriteTimeUtc;
                    row.ID_NoVersion = rowID;
                    row.ID = rowID + fi.LastWriteTimeUtc.Ticks.ToString();
                    row.FileName = fi.Name;
                    row.Size = fi.Length / 1024;
                    row.FilePath = fi.DirectoryName;
                    searchData.Documents.AddDocumentsRow(row);
                }
                

                searchData.AcceptChanges();
  
            }

           
            SendMessage("processing complete " + startPath + "... now saving");
            
            return searchData;
        
        }
        public readonly string CHANIAN_EXTENSION = ".CFS";
        public void SaveData(string fileName)
        {
            if (!fileName.EndsWith(CHANIAN_EXTENSION)) // Chania File Sorter
                fileName = fileName + CHANIAN_EXTENSION;
            searchData.WriteXml(fileName);
        }

        public void ReadData(string fileName)
        {
            searchData = new SearchData();
            searchData.ReadXml(fileName);
        }

        //private static void FileSearcher(string startPath,ref SearchData  data)
        //{
        //    Directory.GetFiles(startPath)
            
        //}

        public delegate void INotify(string message);
        public INotify NotifyHandler ;

        protected virtual void SendMessage(string message)
        {   
           
            if (NotifyHandler != null)
            {
                NotifyHandler(message);
            }
        }


        /// <summary>
        /// PrepareFinalDeleteList processes the final delete list before it can be considered done
        /// </summary>
        /// <param name="dataset"></param>
        /// <returns></returns>
        public static List<SearchData.DocumentsRow> PrepareFinalDeleteList(ref SearchData dataset)
        {
            List<DataRow> _raw_rowsToDelete = new List<DataRow>(dataset.Documents.Where(d => d.Deleted).OrderBy(n => n.FileName));

            _raw_rowsToDelete.AddRange(dataset.ExactDuplicate.Where(d => d.Deleted).OrderBy(n => n.FileName));

            _raw_rowsToDelete.AddRange(dataset.MultipleVersion.Where(d => d.Deleted).OrderBy(n => n.FileName));
            List<SearchData.DocumentsRow> rowsToDelete = new List<SearchData.DocumentsRow>();

            foreach (DataRow r in _raw_rowsToDelete)
            {
                SearchData.DocumentsRow row = dataset.NewDocumentRow();
                row.ID = Convert.ToString(r["ID"]);
                row.ID_NoVersion = Convert.ToString(r["ID_NoVersion"]);
                row.FileName = Convert.ToString(r["FileName"]);
                row.FilePath = Convert.ToString(r["FilePath"]) + @"\" + row.FileName;
                row.Size = Convert.ToInt64(r["Size"]);
                row.Deleted = Convert.ToBoolean(r["Deleted"]);
                row.LastModifiedTime = Convert.ToDateTime(r["LastModifiedTime"]);
                rowsToDelete.Add(row);
                dataset.RejectChanges();
            }
            dataset.RejectChanges();

            return rowsToDelete;
        }

        
        public void ProcessDeletions(List<SearchData.DocumentsRow> rowsToDelete,Logger Log )
        {
            Log.OpenLog();
            //foreach (SearchData.DocumentsRow row in rowsToDelete)
            //{
            //    try
            //    {
            //       byte[] setterbyte = new byte[1];
            //        setterbyte[0] = new byte();
            //        System.IO.File.WriteAllBytes(row.FileName, setterbyte);
            //        Log.WriteLog(row.FileName);
            //    }
            //    catch(Exception ex)
            //    {
            //        SendMessage("Excption :" + ex.Message + " while processing " + row.FileName);
            //    }
            //}

            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Delete_List\";

            foreach (SearchData.DocumentsRow row in rowsToDelete)
            {
                try
                {
                    string newFileName = row.FileName;
                    int i=1;
                    while(File.Exists(path+newFileName))
                    {
                        newFileName = string.Format("{0}_ver_{1:00}", row.FileName, i.ToString());
                        i++;
                    }
                    System.IO.File.Move(row.FilePath,path+newFileName);
                    SendMessage(row.FilePath + " Moved to " + path + newFileName);
                }
                catch (Exception ex)
                {
                    SendMessage("Excption :" + ex.Message + " while deleting " + row.FilePath);
                }
            }
        }

        //public IAsyncResult BeginDeleteAsync(string startPath, string extension, bool includeTempFiles, Logger Log, AsyncCallback callbackFunc)
        //{
        //    AsyncSearcher searcher = SearchDuplicate;
        //    quitNow = false;
        //    IAsyncResult ar = searcher.BeginInvoke(startPath, extension, includeTempFiles, Log, callbackFunc, null);

        //    return ar;
        //}

        
    }
}
