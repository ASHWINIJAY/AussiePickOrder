
namespace POScreen
{
    partial class frmBOReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repWarehouse = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repStart = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repEnd = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.chkShip = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txtCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repBrowse = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.vwFetchBCFReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vwFetchPickOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionCompletion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqShipDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDispatchDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShippingInstruction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberOfParcels = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNoItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWeightKgs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesperson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchBCFReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchPickOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barEditItem1,
            this.barEditItem2,
            this.barEditItem3,
            this.barCheckItem1,
            this.chkShip,
            this.barButtonItem4,
            this.barButtonItem5});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repWarehouse,
            this.repStart,
            this.repEnd,
            this.txtCustomer,
            this.repBrowse});
            this.ribbon.Size = new System.Drawing.Size(1364, 200);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Refresh";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = global::POScreen.Properties.Resources.refreshallpivottable;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = global::POScreen.Properties.Resources.clearheaderandfooter;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Export To Excel";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.SvgImage = global::POScreen.Properties.Resources.export;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Warehouse";
            this.barEditItem1.Edit = this.repWarehouse;
            this.barEditItem1.EditWidth = 120;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repWarehouse
            // 
            this.repWarehouse.AutoHeight = false;
            this.repWarehouse.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repWarehouse.Name = "repWarehouse";
            this.repWarehouse.EditValueChanged += new System.EventHandler(this.repWarehouse_EditValueChanged);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Start  Date ";
            this.barEditItem2.Edit = this.repStart;
            this.barEditItem2.EditWidth = 100;
            this.barEditItem2.Id = 6;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repStart
            // 
            this.repStart.AutoHeight = false;
            this.repStart.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStart.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStart.Name = "repStart";
            this.repStart.EditValueChanged += new System.EventHandler(this.repStart_EditValueChanged);
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "End Date    ";
            this.barEditItem3.Edit = this.repEnd;
            this.barEditItem3.EditWidth = 100;
            this.barEditItem3.Id = 7;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repEnd
            // 
            this.repEnd.AutoHeight = false;
            this.repEnd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEnd.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEnd.Name = "repEnd";
            this.repEnd.EditValueChanged += new System.EventHandler(this.repEnd_EditValueChanged);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Show All Dates";
            this.barCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItem1.Id = 11;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
            // 
            // chkShip
            // 
            this.chkShip.Caption = "Shipped Orders";
            this.chkShip.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.chkShip.Id = 12;
            this.chkShip.Name = "chkShip";
            this.chkShip.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkShip_CheckedChanged);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = ".";
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Sales Order Report";
            this.barButtonItem5.Id = 14;
            this.barButtonItem5.ImageOptions.Image = global::POScreen.Properties.Resources.bosaleitem_16x16;
            this.barButtonItem5.ImageOptions.LargeImage = global::POScreen.Properties.Resources.bosaleitem_32x32;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.chkShip);
            this.ribbonPageGroup3.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Filters";
            // 
            // txtCustomer
            // 
            this.txtCustomer.AutoHeight = false;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.EditValueChanged += new System.EventHandler(this.txtCustomer_EditValueChanged);
            // 
            // repBrowse
            // 
            this.repBrowse.AutoHeight = false;
            editorButtonImageOptions1.Image = global::POScreen.Properties.Resources.find_32x32;
            serializableAppearanceObject1.Options.UseImage = true;
            this.repBrowse.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repBrowse.Name = "repBrowse";
            this.repBrowse.Click += new System.EventHandler(this.repBrowse_Click);
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 680);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1364, 41);
            // 
            // vwFetchBCFReportBindingSource
            // 
            this.vwFetchBCFReportBindingSource.DataSource = typeof(POScreen.DAL.vw_FetchBCFReport);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwFetchPickOrderBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 200);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1364, 480);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwFetchPickOrderBindingSource
            // 
            this.vwFetchPickOrderBindingSource.DataSource = typeof(POScreen.DAL.vw_FetchPickOrder);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesOrder,
            this.colInvoiceNumber,
            this.colProductionCompletion,
            this.colProductionDate,
            this.colReqShipDate,
            this.colDispatchDate,
            this.colWarehouse,
            this.colOrderStatus,
            this.colShippingInstruction,
            this.colProductionStatus,
            this.colCourier,
            this.colConNote,
            this.colPickedBy,
            this.colNumberOfParcels,
            this.colTotalNoItems,
            this.colTotalWeightKgs,
            this.colSalesperson,
            this.colOrderDate,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colSalesOrder
            // 
            this.colSalesOrder.FieldName = "SalesOrder";
            this.colSalesOrder.MinWidth = 30;
            this.colSalesOrder.Name = "colSalesOrder";
            this.colSalesOrder.Visible = true;
            this.colSalesOrder.VisibleIndex = 0;
            this.colSalesOrder.Width = 112;
            // 
            // colInvoiceNumber
            // 
            this.colInvoiceNumber.FieldName = "InvoiceNumber";
            this.colInvoiceNumber.MinWidth = 30;
            this.colInvoiceNumber.Name = "colInvoiceNumber";
            this.colInvoiceNumber.Visible = true;
            this.colInvoiceNumber.VisibleIndex = 7;
            this.colInvoiceNumber.Width = 112;
            // 
            // colProductionCompletion
            // 
            this.colProductionCompletion.FieldName = "ProductionCompletion";
            this.colProductionCompletion.MinWidth = 30;
            this.colProductionCompletion.Name = "colProductionCompletion";
            this.colProductionCompletion.Visible = true;
            this.colProductionCompletion.VisibleIndex = 8;
            this.colProductionCompletion.Width = 112;
            // 
            // colProductionDate
            // 
            this.colProductionDate.FieldName = "ProductionDate";
            this.colProductionDate.MinWidth = 30;
            this.colProductionDate.Name = "colProductionDate";
            this.colProductionDate.Visible = true;
            this.colProductionDate.VisibleIndex = 9;
            this.colProductionDate.Width = 112;
            // 
            // colReqShipDate
            // 
            this.colReqShipDate.FieldName = "ReqShipDate";
            this.colReqShipDate.MinWidth = 30;
            this.colReqShipDate.Name = "colReqShipDate";
            this.colReqShipDate.Visible = true;
            this.colReqShipDate.VisibleIndex = 2;
            this.colReqShipDate.Width = 112;
            // 
            // colDispatchDate
            // 
            this.colDispatchDate.FieldName = "DispatchDate";
            this.colDispatchDate.MinWidth = 30;
            this.colDispatchDate.Name = "colDispatchDate";
            this.colDispatchDate.Visible = true;
            this.colDispatchDate.VisibleIndex = 13;
            this.colDispatchDate.Width = 112;
            // 
            // colWarehouse
            // 
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.MinWidth = 30;
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Visible = true;
            this.colWarehouse.VisibleIndex = 19;
            this.colWarehouse.Width = 112;
            // 
            // colOrderStatus
            // 
            this.colOrderStatus.FieldName = "OrderStatus";
            this.colOrderStatus.MinWidth = 30;
            this.colOrderStatus.Name = "colOrderStatus";
            this.colOrderStatus.Visible = true;
            this.colOrderStatus.VisibleIndex = 6;
            this.colOrderStatus.Width = 112;
            // 
            // colShippingInstruction
            // 
            this.colShippingInstruction.FieldName = "ShippingInstruction";
            this.colShippingInstruction.MinWidth = 30;
            this.colShippingInstruction.Name = "colShippingInstruction";
            this.colShippingInstruction.Visible = true;
            this.colShippingInstruction.VisibleIndex = 18;
            this.colShippingInstruction.Width = 112;
            // 
            // colProductionStatus
            // 
            this.colProductionStatus.FieldName = "ProductionStatus";
            this.colProductionStatus.MinWidth = 30;
            this.colProductionStatus.Name = "colProductionStatus";
            this.colProductionStatus.Visible = true;
            this.colProductionStatus.VisibleIndex = 10;
            this.colProductionStatus.Width = 112;
            // 
            // colCourier
            // 
            this.colCourier.FieldName = "Courier";
            this.colCourier.MinWidth = 30;
            this.colCourier.Name = "colCourier";
            this.colCourier.Visible = true;
            this.colCourier.VisibleIndex = 12;
            this.colCourier.Width = 112;
            // 
            // colConNote
            // 
            this.colConNote.FieldName = "ConNote";
            this.colConNote.MinWidth = 30;
            this.colConNote.Name = "colConNote";
            this.colConNote.Visible = true;
            this.colConNote.VisibleIndex = 11;
            this.colConNote.Width = 112;
            // 
            // colPickedBy
            // 
            this.colPickedBy.FieldName = "PickedBy";
            this.colPickedBy.MinWidth = 30;
            this.colPickedBy.Name = "colPickedBy";
            this.colPickedBy.Visible = true;
            this.colPickedBy.VisibleIndex = 15;
            this.colPickedBy.Width = 112;
            // 
            // colNumberOfParcels
            // 
            this.colNumberOfParcels.FieldName = "NumberOfParcels";
            this.colNumberOfParcels.MinWidth = 30;
            this.colNumberOfParcels.Name = "colNumberOfParcels";
            this.colNumberOfParcels.Visible = true;
            this.colNumberOfParcels.VisibleIndex = 14;
            this.colNumberOfParcels.Width = 112;
            // 
            // colTotalNoItems
            // 
            this.colTotalNoItems.FieldName = "TotalNoItems";
            this.colTotalNoItems.MinWidth = 30;
            this.colTotalNoItems.Name = "colTotalNoItems";
            this.colTotalNoItems.Visible = true;
            this.colTotalNoItems.VisibleIndex = 16;
            this.colTotalNoItems.Width = 112;
            // 
            // colTotalWeightKgs
            // 
            this.colTotalWeightKgs.FieldName = "TotalWeightKgs";
            this.colTotalWeightKgs.MinWidth = 30;
            this.colTotalWeightKgs.Name = "colTotalWeightKgs";
            this.colTotalWeightKgs.Visible = true;
            this.colTotalWeightKgs.VisibleIndex = 17;
            this.colTotalWeightKgs.Width = 112;
            // 
            // colSalesperson
            // 
            this.colSalesperson.FieldName = "Salesperson";
            this.colSalesperson.MinWidth = 30;
            this.colSalesperson.Name = "colSalesperson";
            this.colSalesperson.Visible = true;
            this.colSalesperson.VisibleIndex = 3;
            this.colSalesperson.Width = 112;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 30;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 1;
            this.colOrderDate.Width = 112;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Customer";
            this.gridColumn1.FieldName = "Customer";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CustomerName";
            this.gridColumn2.FieldName = "CustomerName";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 112;
            // 
            // frmBOReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 721);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmBOReport";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Picked/Shipped Order - Company N";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmBOReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchBCFReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchPickOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repWarehouse;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repStart;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repEnd;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCustomer;
        private System.Windows.Forms.BindingSource vwFetchBCFReportBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repBrowse;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource vwFetchPickOrderBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionCompletion;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReqShipDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDispatchDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colShippingInstruction;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCourier;
        private DevExpress.XtraGrid.Columns.GridColumn colConNote;
        private DevExpress.XtraGrid.Columns.GridColumn colPickedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberOfParcels;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNoItems;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWeightKgs;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesperson;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraBars.BarCheckItem chkShip;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}