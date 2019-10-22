namespace BarCodeGen.FrontEnd
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gcBarCodes = new DevExpress.XtraGrid.GridControl();
            this.gvBarCodes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvcWarehouseLocalization = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.chkFirstLineHasHeader = new DevExpress.XtraEditors.CheckEdit();
            this.beFileCSV = new DevExpress.XtraEditors.ButtonEdit();
            this.documentViewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraOpenFileDialogCsv = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcBarCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkFirstLineHasHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFileCSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBarCodes
            // 
            this.gcBarCodes.Location = new System.Drawing.Point(12, 62);
            this.gcBarCodes.MainView = this.gvBarCodes;
            this.gcBarCodes.Name = "gcBarCodes";
            this.gcBarCodes.Size = new System.Drawing.Size(245, 667);
            this.gcBarCodes.TabIndex = 0;
            this.gcBarCodes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBarCodes});
            // 
            // gvBarCodes
            // 
            this.gvBarCodes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gvcWarehouseLocalization});
            this.gvBarCodes.GridControl = this.gcBarCodes;
            this.gvBarCodes.Name = "gvBarCodes";
            this.gvBarCodes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvBarCodes.OptionsView.EnableAppearanceOddRow = true;
            this.gvBarCodes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gvcWarehouseLocalization, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gvcWarehouseLocalization
            // 
            this.gvcWarehouseLocalization.Caption = "Lokalizacja";
            this.gvcWarehouseLocalization.FieldName = "LocationName";
            this.gvcWarehouseLocalization.Name = "gvcWarehouseLocalization";
            this.gvcWarehouseLocalization.Visible = true;
            this.gvcWarehouseLocalization.VisibleIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.controlNavigator1);
            this.layoutControl1.Controls.Add(this.chkFirstLineHasHeader);
            this.layoutControl1.Controls.Add(this.beFileCSV);
            this.layoutControl1.Controls.Add(this.documentViewer);
            this.layoutControl1.Controls.Add(this.btnLoadData);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.gcBarCodes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1819, 392, 1003, 562);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1137, 764);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Location = new System.Drawing.Point(12, 733);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.gcBarCodes;
            this.controlNavigator1.Size = new System.Drawing.Size(250, 19);
            this.controlNavigator1.StyleController = this.layoutControl1;
            this.controlNavigator1.TabIndex = 8;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextStringFormat = "Pozycja {0:N0} z {1:N0}";
            // 
            // chkFirstLineHasHeader
            // 
            this.chkFirstLineHasHeader.EditValue = true;
            this.chkFirstLineHasHeader.Location = new System.Drawing.Point(949, 12);
            this.chkFirstLineHasHeader.Name = "chkFirstLineHasHeader";
            this.chkFirstLineHasHeader.Properties.Caption = "Pierwsza linia zawiera nagłówek";
            this.chkFirstLineHasHeader.Size = new System.Drawing.Size(176, 19);
            this.chkFirstLineHasHeader.StyleController = this.layoutControl1;
            this.chkFirstLineHasHeader.TabIndex = 7;
            // 
            // beFileCSV
            // 
            this.beFileCSV.EditValue = "e:\\Dokumenty\\proALPHA\\Miejsca_mag.csv";
            this.beFileCSV.Location = new System.Drawing.Point(106, 12);
            this.beFileCSV.Name = "beFileCSV";
            this.beFileCSV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beFileCSV.Size = new System.Drawing.Size(839, 20);
            this.beFileCSV.StyleController = this.layoutControl1;
            this.beFileCSV.TabIndex = 6;
            this.beFileCSV.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beFileCSV_ButtonClick);
            // 
            // documentViewer
            // 
            this.documentViewer.DocumentSource = typeof(BarCodeGen.FrontEnd.XrepBarCodes);
            this.documentViewer.IsMetric = true;
            this.documentViewer.Location = new System.Drawing.Point(266, 52);
            this.documentViewer.Name = "documentViewer";
            this.documentViewer.Size = new System.Drawing.Size(859, 700);
            this.documentViewer.TabIndex = 5;
            // 
            // btnLoadData
            // 
            this.btnLoadData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadData.ImageOptions.Image")));
            this.btnLoadData.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLoadData.Location = new System.Drawing.Point(12, 36);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(24, 22);
            this.btnLoadData.StyleController = this.layoutControl1;
            this.btnLoadData.TabIndex = 4;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrint.Location = new System.Drawing.Point(40, 36);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(24, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.splitterItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1137, 764);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcBarCodes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(249, 671);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnPrint;
            this.layoutControlItem2.Location = new System.Drawing.Point(28, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(28, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(28, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(28, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(56, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(193, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnLoadData;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(28, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(28, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(28, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.documentViewer;
            this.layoutControlItem4.Location = new System.Drawing.Point(254, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(863, 720);
            this.layoutControlItem4.Text = "Podgląd raportu";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(91, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(249, 24);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 697);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.beFileCSV;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(937, 24);
            this.layoutControlItem5.Text = "Plik CSV do importu";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkFirstLineHasHeader;
            this.layoutControlItem6.Location = new System.Drawing.Point(937, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(180, 23);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(180, 23);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(180, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.controlNavigator1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 721);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(254, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // xtraOpenFileDialogCsv
            // 
            this.xtraOpenFileDialogCsv.DefaultExt = "csv";
            this.xtraOpenFileDialogCsv.FileName = "dane.csv";
            this.xtraOpenFileDialogCsv.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            this.xtraOpenFileDialogCsv.FilterIndex = 0;
            this.xtraOpenFileDialogCsv.RestoreDirectory = true;
            this.xtraOpenFileDialogCsv.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.xtraOpenFileDialogCsv.SupportMultiDottedExtensions = true;
            this.xtraOpenFileDialogCsv.Title = "Wybierz plik do zaimportowania";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 764);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator kodów paskowych";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcBarCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkFirstLineHasHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFileCSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBarCodes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBarCodes;
        private DevExpress.XtraGrid.Columns.GridColumn gvcWarehouseLocalization;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.ButtonEdit beFileCSV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialogCsv;
        private DevExpress.XtraEditors.CheckEdit chkFirstLineHasHeader;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}

