using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using POScreen.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POScreen
{
    public partial class frmSOReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmSOReport()
        {
            InitializeComponent();
        }

        private void repStart_EditValueChanged(object sender, EventArgs e)
        {
           
            DateEdit rep = (DateEdit)sender;
            if (rep.EditValue != null)
                startdate = (DateTime)rep.EditValue;
            filldata();
        }
        DateTime startdate;
        DateTime enddate;
        private void repEndDate_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit rep = (DateEdit)sender;
            if (rep.EditValue != null)
                enddate = (DateTime)rep.EditValue;
            filldata();
        }

        private void frmSOReport_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            filldata();
        }
        private void filldata()
        {
            if (startdate.Year != 1 && enddate.Year != 1)
            {
                AppUtility.UI.Notification.ShowWaitForm(this, "Please wait");
                List<vw_FetchSO> listvw_FetchCusSorMaster;
                using (var context = new SysproCompanyTEntities())
                {

                    listvw_FetchCusSorMaster = context.vw_FetchSO.Where(c => c.RDate >= startdate && c.RDate <= enddate).ToList();

                    vwFetchSOBindingSource.DataSource = listvw_FetchCusSorMaster;
                }
                AppUtility.UI.Notification.CloseWaitForm();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                
                    gridView1.ExportToXlsx(folderBrowserDialog.SelectedPath + "/SOReport.xlsx");
            }
        }
    }
}