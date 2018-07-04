using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace FileSorterLibrary
{
    public class FileComparer
    {
        public enum Equality
        {
            NotMatching,
            ExactlyMatching,
            PartialMatch,
            PartialMatchHighLevelMatch
        }
        public Equality CompareBinary(FileInfo fi1, FileInfo fi2, Logger log)
        {
            bool compareHigh = false;

            Equality equalityStatus = Equality.NotMatching;

            if (!CompareHighLevel(fi1, fi2))
                    return Equality.NotMatching;
                else
                    compareHigh = true;

            using (Stream stream1 = new FileStream(fi1.FullName, FileMode.Open, FileAccess.ReadWrite),
                 stream2 = new FileStream(fi2.FullName, FileMode.Open, FileAccess.ReadWrite))
            {

                try
                {
                    long difference = 0, i = 0;

                    for (; i < stream1.Length && i < stream2.Length; i++)
                    {
                        int byte1 = stream1.ReadByte();
                        int byte2 = stream2.ReadByte();
                        if (byte1 != byte2)
                        {
                            difference++;
                        }
                    }

                    if (i == stream1.Length && i == stream2.Length)
                    {
                        if (difference == 0)
                            equalityStatus = Equality.ExactlyMatching;
                        else if (difference > 0)
                            equalityStatus = (compareHigh) ? Equality.PartialMatchHighLevelMatch : Equality.PartialMatch;
                    }
                    else if ((i == stream1.Length && i != stream2.Length) || (i >= stream1.Length && i == stream2.Length))
                    {
                        if (i >= (stream1.Length / 2) || (difference < i - (i / 20)))
                        {
                            equalityStatus = (compareHigh) ? Equality.PartialMatchHighLevelMatch : Equality.PartialMatch; ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.OpenLog();
                    log.WriteLog(ex.Message);
                    log.CloseLog();
                }//catch
                finally
                {
                    if (stream1 != null)
                        stream1.Close();

                    if (stream2 != null)
                        stream2.Close();
                }//finally closed
            } //Usings closed




            return equalityStatus;
        }

        bool CompareHighLevel(FileInfo fi1, FileInfo fi2)
        {
            return (fi1.LastWriteTime == fi2.LastWriteTime && fi1.Length == fi1.Length && fi1.Extension == fi2.Extension);
        }

        ////retrieves the datetime WITHOUT loading the whole image
        //public static DateTime GetDateTakenFromImage(string path)
        //{
            

        //    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        //    using (Image myImage = Image.FromStream(fs, false, false))
        //    {
        //        PropertyItem propItem = myImage.GetPropertyItem(36867);
        //        string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
        //        return DateTime.Parse(dateTaken);
        //    }

        //}

    }
    
}
