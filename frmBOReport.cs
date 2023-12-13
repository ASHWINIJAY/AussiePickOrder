using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POScreen.DAL;
using DevExpress.XtraEditors;
using System.Globalization;

namespace POScreen
{
    public partial class frmBOReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmBOReport()
        {
            InitializeComponent();
        }

        private void frmBOReport_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            bindWarehouse();
            filldata();
        }
        private void filldata()
        {
            AppUtility.UI.Notification.ShowWaitForm(this, "Please wait");
            List<vw_FetchPickOrder> listvw_FetchCusSorMaster;
            using (var context = new SysproCompanyTEntities())
            {
                //  var porLst = context.Logins.ToList();
                listvw_FetchCusSorMaster = new List<vw_FetchPickOrder>();
                if (!barCheckItem1.Checked)
                {
                    if (startdate.Year != 1 && enddate.Year != 1)
                        listvw_FetchCusSorMaster = context.vw_FetchPickOrder.Where(c => c.Wdate >= startdate && c.Wdate <= enddate).ToList();
                }
                else
                {
                    listvw_FetchCusSorMaster = context.vw_FetchPickOrder.ToList();
                }
                if (warehouse  != "All")
                {
                    listvw_FetchCusSorMaster = listvw_FetchCusSorMaster.Where(c => c.Warehouse == warehouse).ToList();
                    //vwFetchCusSorMasterBindingSource.DataSource = result1;
                }
                if(chkShip.Checked)
                {
                    listvw_FetchCusSorMaster = listvw_FetchCusSorMaster.Where(c => c.ConNote.Trim() != "" && c.PickedBy.Trim() != "").ToList();
                }
                else
                {
                    listvw_FetchCusSorMaster = listvw_FetchCusSorMaster.Where(c => c.ConNote.Trim() == "" && c.PickedBy.Trim() != "").ToList();
                }
                vwFetchPickOrderBindingSource.DataSource = listvw_FetchCusSorMaster;
            }
            AppUtility.UI.Notification.CloseWaitForm();
        }
        private void bindWarehouse()
        {
            using (var context = new SysproCompanyTEntities())
            {
                if (startdate.Year != 1 && enddate.Year != 1)
                {
                    repWarehouse.Items.Clear();
                    var result = context.vw_FetchPickOrder.Where(c => c.ProdDate >= startdate && c.ProdDate <= enddate).Select(c => c.Warehouse).Distinct().ToList();
                    repWarehouse.Items.Add("All");


                    foreach (var item in result)
                    {
                        repWarehouse.Items.Add(item);
                    }
                }
                else
                {
                    var fromdate = DateTime.Now.AddMonths(-1);
                    var toDate = DateTime.Now;
                    repWarehouse.Items.Clear();
                    var result = context.vw_FetchPickOrder.Where(c => c.ProdDate >= fromdate && c.ProdDate <= toDate).Select(c => c.Warehouse).Distinct().ToList();
                    repWarehouse.Items.Add("All");


                    foreach (var item in result)
                    {
                        repWarehouse.Items.Add(item);
                    }
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if(chkShip.Checked)
                gridView1.ExportToXlsx(folderBrowserDialog.SelectedPath + "/PickedOrder.xlsx");
                else
                    gridView1.ExportToXlsx(folderBrowserDialog.SelectedPath + "/ShippedOrder.xlsx");
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            filldata();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        string warehouse = "All";
        string customer = "";
        DateTime startdate;
        DateTime enddate;
        private void repWarehouse_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit rep = (ComboBoxEdit)sender;
            warehouse = rep.EditValue.ToString();
            filldata();
        }

        private void repStart_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit rep = (DateEdit)sender;
            if (rep.EditValue != null)
                startdate = (DateTime)rep.EditValue;
            //bindWarehouse();
            filldata();
        }

        private void repEnd_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit rep = (DateEdit)sender;
            enddate = (DateTime)rep.EditValue;
           // bindWarehouse();
            filldata();
        }

        private void txtCustomer_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit rep = (TextEdit)sender;
            customer = rep.EditValue.ToString();
            filldata();
        }

        private void barEditItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void repBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            filldata();
        }

        private void chkShip_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            filldata();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSOReport frm = new frmSOReport();
            frm.Show();
        }
    }
}