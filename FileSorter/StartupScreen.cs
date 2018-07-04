using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FileSorterLibrary;


namespace FileSorter
{
    public partial class StartupScreen : Form
    {
        FileSorter.CallStatus callStatus = CallStatus.CallNotInitiated;
        FileSorterLibrary.FileSearcher searcher;
        public StartupScreen()
        {
            InitializeComponent();
            searcher = new FileSearcher();
            searcher.NotifyHandler += new FileSearcher.INotify(searcher_NotifyHandler);
        }

        void searcher_NotifyHandler(string e)
        {
            this.dataset = searcher.GetData();
            RefreshDataBind();
        }
        
        private void linkStartPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {     
            this.folderToStart.RootFolder = Environment.SpecialFolder.MyComputer;
   
            if(this.folderToStart.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.linkStartPath.Text = folderToStart.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.linkStartPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Temp";
            folderToStart.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\Temp";
            this.cboFileTypes.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog.DefaultExt = "*"+searcher.CHANIAN_EXTENSION;
            openFileDialog.InitialDirectory = searcher.DefaultSaveLocation;
            if(openFileDialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                searcher.ReadData(openFileDialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "*" + searcher.CHANIAN_EXTENSION;
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = searcher.DefaultSaveLocation;
            if(saveFileDialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                
                searcher.SaveData(saveFileDialog.FileName);
            }
        }
        SearchData dataset = new SearchData();
        Logger Log = new Logger();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(callStatus == CallStatus.CallInProgress)
            {
                DialogResult  dr = MessageBox.Show("Another search is already in progress. Do you want to Cancel and Start Again ?", "Search In Progress", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    searcher.RequestAbort();
                    callStatus = CallStatus.CallAbortRequested;
                }
                return;
            }
            if(callStatus== CallStatus.CallAbortRequested)
            {
                MessageBox.Show("A Search is abort request in progress. Please wait..", "Search In Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            IAsyncResult ar = searcher.BeginSearcherAsync(folderToStart.SelectedPath, cboFileTypes.Text, chkTemporary.Checked, Log, CallbackMethod);
            callStatus = CallStatus.CallInProgress;
            btnSearch.Text = "Search in Processing";
            Application.UseWaitCursor = true;
        }

    
        private void dgMultiple_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                SelectAllMultipleVersions();
                RefreshDataBind();
            }
            else if (e.ColumnIndex == 0)
            {
                string ID = dgMultiple.Rows[e.RowIndex].Cells[1].Value.ToString();
                string path = dgMultiple.Rows[e.RowIndex].Cells[5].Value.ToString();
                SearchData.MultipleVersionRow row = dataset.MultipleVersion.Single(d => d.ID == ID && d.FilePath == path);
                row.BeginEdit();
                if (row.Deleted)
                {
                    dgMultiple.Rows[e.RowIndex].Cells[0].Value = row.Deleted = false;
                }
                else
                {
                    dgMultiple.Rows[e.RowIndex].Cells[0].Value = row.Deleted = true;
                }
                row.EndEdit();
                dataset.MultipleVersion.AcceptChanges();
      
            //  ((SearchData.MultipleVersionRow)dataset.MultipleVersion.Rows[e.RowIndex]).Deleted = !(((SearchData.MultipleVersionRow)dataset.MultipleVersion.Rows[e.RowIndex]).Deleted);
            //  dgMultiple.DataSource = dataset.MultipleVersion;
            }
            UpdateFinalDeleteList();
        }

        private void dgMultiple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            searcher.RequestAbort();
        }

        private void dgFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dont allow to select all files at once.
            if (e.RowIndex < 0) return;
            if (!this.chkAllowMainFiles.Checked)
            {
                string fileName = dgFiles.Rows[e.RowIndex].Cells[2].Value.ToString();
                ApplyFilter(fileName);
            }
            else
            {
                if (e.ColumnIndex == 0)
                {
                    string ID = dgFiles.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string path = dgFiles.Rows[e.RowIndex].Cells[5].Value.ToString();
                    SearchData.DocumentsRow row = dataset.Documents.Single(d => d.ID == ID && d.FilePath == path);
                    row.BeginEdit();
                    if (row.Deleted)
                    {
                        dgFiles.Rows[e.RowIndex].Cells[0].Value.ToString();
                        dgFiles.Rows[e.RowIndex].Cells[0].Value = row.Deleted = false;
                    }
                    else
                    {
                        dgFiles.Rows[e.RowIndex].Cells[0].Value = row.Deleted = true;
                    }
                    row.EndEdit();
                    dataset.Documents.AcceptChanges();
                    UpdateFinalDeleteList();
                }

            }
        }


        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataset.MultipleVersion.DefaultView.RowFilter = string.Empty;
            dataset.ExactDuplicate.DefaultView.RowFilter = string.Empty;
            RefreshDataBind();
        }

        private void dgFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgFiles_SelectionChanged(object sender, EventArgs e)
        {
       
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {

            
        }

        private void dgDuplicate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                SelectAllExactDuplicate();
                RefreshDataBind();
            }
            else if (e.ColumnIndex == 0)
            {
                string ID = dgDuplicate.Rows[e.RowIndex].Cells[1].Value.ToString();
                string path = dgDuplicate.Rows[e.RowIndex].Cells[5].Value.ToString();
                SearchData.ExactDuplicateRow row = dataset.ExactDuplicate.Single(d => d.ID == ID && d.FilePath == path);
                row.BeginEdit();
                if (row.Deleted)
                {
                   dgDuplicate.Rows[e.RowIndex].Cells[0].Value = row.Deleted = false;
                }
                else
                {
                    dgDuplicate.Rows[e.RowIndex].Cells[0].Value = row.Deleted = true;
                }
                row.EndEdit();
                dataset.ExactDuplicate.AcceptChanges();
            }
            UpdateFinalDeleteList();
        }

        private void dgDeleteList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
            if (e.RowIndex < 0) return;
           
            //if(e.ColumnIndex == 0)
            //{
            //    string ID = dgDuplicate.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    string path = dgDuplicate.Rows[e.RowIndex].Cells[5].Value.ToString();
            //    SearchData.ExactDuplicateRow row = dataset.ExactDuplicate.Single(d => d.ID == ID && d.FilePath == path);
            //    row.BeginEdit();
            //    if (row.Deleted)
            //    {
            //       dgDuplicate.Rows[e.RowIndex].Cells[0].Value = row.Deleted = false;
            //    }
            //    else
            //    {
            //        dgDuplicate.Rows[e.RowIndex].Cells[0].Value = row.Deleted = true;
            //    }
            //    row.EndEdit();
            //    dataset.ExactDuplicate.AcceptChanges();
            //}
            //UpdateFinalDeleteList();
        }

        string file1=string.Empty, file2=string.Empty;
        private void dgDeleteList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        //    comboBox1.Show();
        //    comboBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    comboBox1.Hide();
        //    linkFiletype.Text = string.Format("Search '{0}' files.", comboBox1.Text);
        //    linkFiletype.Focus();
        }

        private void btnActualDeletes_Click(object sender, EventArgs e)
        {
            searcher.ProcessDeletions(FileSearcher.PrepareFinalDeleteList(ref dataset),Log);
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
           
        }

        void SelectAllExactDuplicate()
        {
            bool newValue = (!dataset.ExactDuplicate.All(a => a.Deleted));
            foreach (SearchData.ExactDuplicateRow row in dataset.ExactDuplicate)
            {
                row.BeginEdit();
                row.Deleted = newValue;
                row.EndEdit();
            }
            dataset.ExactDuplicate.AcceptChanges();
        }


        void SelectAllMultipleVersions()
        {
            bool newValue = (!dataset.MultipleVersion.All(a => a.Deleted));
            foreach (SearchData.MultipleVersionRow row in dataset.MultipleVersion)
            {
                row.BeginEdit();
                row.Deleted = newValue;
                row.EndEdit();
            }
            dataset.MultipleVersion.AcceptChanges();
            
        }

        private void dgDuplicate_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.ColumnIndex == 0) SelectAllExactDuplicate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SelectAllMultipleVersions();
        }

        private void dgMultiple_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCompareBinary_Click(object sender, EventArgs e)
        {
            if(dgDeleteList.SelectedRows.Count != 2)
            {
                MessageBox.Show("Please select 2 files!");
                return;
            }

            file1 = dgDeleteList.SelectedRows[0].Cells[4].Value.ToString();
            file2 = dgDeleteList.SelectedRows[1].Cells[4].Value.ToString();
            FileComparer compare = new FileComparer();
            FileComparer.Equality equality = compare.CompareBinary(new System.IO.FileInfo(file1), new System.IO.FileInfo(file2),Log);

           // if (equality == FileComparer.Equality.ExactlyMatching)
                if( equality != FileComparer.Equality.ExactlyMatching ) 
                this.txtCompareResult.Text = equality.ToString();
        }
    }
}
