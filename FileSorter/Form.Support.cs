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
    public partial class StartupScreen
    {
         void UpdateFinalDeleteList()
        {
            List<SearchData.DocumentsRow> rowsToDelete = FileSearcher.PrepareFinalDeleteList(ref dataset);
            if(dgDeleteList.InvokeRequired)
            {
                dgDeleteList.Invoke(new MethodInvoker(delegate() { dgDeleteList.DataSource = rowsToDelete; }));
            }
            else
            {
                dgDeleteList.DataSource = rowsToDelete;
            }
        }

         void RefreshDataBind()
         {
             if (dataset == null) return;

             if (dgFiles.InvokeRequired)
             {
                 dgFiles.Invoke(new MethodInvoker(delegate { dgFiles.DataSource = dataset.Documents; dgFiles.Refresh(); }));
             }
             else
             {
                 dgFiles.DataSource = dataset.Documents;
                 dgFiles.Refresh();
             }

             if (dgDuplicate.InvokeRequired)
             {
                 dgDuplicate.Invoke(new MethodInvoker(delegate { dgDuplicate.DataSource = dataset.ExactDuplicate; dgDuplicate.Refresh(); }));

             }
             else
             {
                 dgDuplicate.DataSource = dataset.ExactDuplicate;
                 dgDuplicate.Refresh();
             }

             if (dgMultiple.InvokeRequired)
             {
                 dgMultiple.Invoke(new MethodInvoker(delegate { dgMultiple.DataSource = dataset.MultipleVersion; dgMultiple.Refresh(); }));
             }
             else
             {
                 dgMultiple.DataSource = dataset.MultipleVersion;
                 dgMultiple.Refresh();
             }
         }

         void CallbackMethod(IAsyncResult ar)
         {
             if (ar.IsCompleted)
             {
                 callStatus = CallStatus.CallCompletedSuccessfully;
                 Application.UseWaitCursor = false;
                 this.dataset = searcher.GetData();
                 if (this.btnSearch.InvokeRequired)
                 {
                     this.btnSearch.Invoke(new MethodInvoker(delegate()
                     {
                         if (this.btnSearch.BackColor == Color.LightBlue)
                             this.btnSearch.BackColor = Color.LightYellow;
                         else
                             this.btnSearch.BackColor = Color.LightBlue;
                         this.btnSearch.Text = "Start Search";
                     }));
                 }
                 else
                 {
                     if (this.btnSearch.BackColor == Color.LightBlue)
                         this.btnSearch.BackColor = Color.LightYellow;
                     else
                         this.btnSearch.BackColor = Color.LightBlue;
                     this.Text = "Start Search";
                 }
                 RefreshDataBind();
             }
         }

         void ApplyFilter(string fileName)
         {
             dataset.MultipleVersion.DefaultView.RowFilter = string.Format("FileName = '{0}'", fileName);
             dataset.ExactDuplicate.DefaultView.RowFilter = string.Format("FileName = '{0}'", fileName);
             if (dgMultiple.InvokeRequired)
             {
                 dgMultiple.Invoke(new MethodInvoker(delegate { dgMultiple.DataSource = dataset.MultipleVersion.DefaultView; }));
             }
             else
                 dgMultiple.DataSource = dataset.MultipleVersion.DefaultView;

             if (dgDuplicate.InvokeRequired)
             {
                 dgDuplicate.Invoke(new MethodInvoker(delegate { dgDuplicate.DataSource = dataset.ExactDuplicate.DefaultView; }));
             }
             else
                 dgDuplicate.DataSource = dataset.ExactDuplicate.DefaultView;

         }

    }
}
