using DevExpress.XtraBars;
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
    public partial class BrowseCustomer : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string customerName;
        public BrowseCustomer()
        {
            InitializeComponent();
        }

        private void BrowseCustomer_Load(object sender, EventArgs e)
        {
            filldata();
        }
        private void filldata()
        {
            using (var context = new SysproCompanyTEntities())
            {
                //  var porLst = context.Logins.ToList();
                var result = from s in context.ArCustomers.ToList() select s;
                arCustomerBindingSource.DataSource = result;
                //listvw_FetchCusSorMaster = listvw_FetchCusSorMaster.Select()
                //vwFetchBCFReportBindingSource.DataSource = listvw_FetchCusSorMaster;
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ArCustomer vw = new ArCustomer();
            int idx = gridView1.FocusedRowHandle;
            vw = (ArCustomer)gridControl1.DefaultView.GetRow(idx);
            customerName = vw.Name;
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}