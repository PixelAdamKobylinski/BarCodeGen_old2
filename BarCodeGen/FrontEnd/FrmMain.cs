using BarCodeGen.Common.Models;
using BarCodeGen.Properties;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCodeGen.FrontEnd
{
    public partial class FrmMain : XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            beFileCSV.Text = Settings.Default.LastFileName;
            LoadDataToGrid();
            PrepareToPrintData(false);
        }

        void PrepareToPrintData(bool showPrintDialog)
        {
            XrepBarCodes xrepBar = new XrepBarCodes();
            xrepBar.BeginUpdate();
            xrepBar.DataSource = warehouseLocations;
            xrepBar.FillDataSource();
            xrepBar.EndUpdate();

            var ps = XrepBarCodes.CreatePrintingSystem();
            documentViewer.Refresh();
            documentViewer.UpdatePageView();
            //DocumentViewer documentViewer = new DocumentViewer();
            //documentViewer.ShowPage(xrepBar.Pages[0]);
            documentViewer.DocumentSource = xrepBar;
            documentViewer.Show();
            documentViewer.Refresh();
            if (showPrintDialog)
            {
                xrepBar.PrintDialog();
            }
            /*
            ReportPrintTool reportPrintTool = new ReportPrintTool(xrepBar);
            reportPrintTool.PrintDialog();
            //xrepBar.
            */
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrepareToPrintData(true);
        }

        List<WarehouseLocation> warehouseLocations = null;
        void LoadDataToGrid()
        {
            bool firstLineIsHeader = chkFirstLineHasHeader.Checked;
            string fileName = beFileCSV.Text;
            if (File.Exists(fileName))
            {
                gcBarCodes.BeginUpdate();
                gcBarCodes.DataSource = null;
                gcBarCodes.RefreshDataSource();
                warehouseLocations = LoadData(fileName, firstLineIsHeader);
                gcBarCodes.DataSource = warehouseLocations;
                gcBarCodes.RefreshDataSource();
                gvBarCodes.RefreshData();
                gcBarCodes.EndUpdate();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
        List<WarehouseLocation> LoadData(string fileName, bool firstLineIsHeader)
        {
            List<WarehouseLocation> data = new List<WarehouseLocation>();
            gvcWarehouseLocalization.Caption = "Dane";
            if (File.Exists(fileName))
            {
                var csvFile = File.ReadAllLines(fileName);
                bool firstLine = true;
                foreach(var line in csvFile)
                {
                    if (firstLineIsHeader && firstLine)
                    {
                        gvcWarehouseLocalization.Caption = line;
                    }
                    else
                    {
                        data.Add(new WarehouseLocation() { LocationName = line });
                    }
                    firstLine = false;
                }
            }
            else
            {
                //demo data
                data.Add(new WarehouseLocation() { LocationName = "EL-A-2-1" });
                data.Add(new WarehouseLocation() { LocationName = "EL-A-2-2" });
                data.Add(new WarehouseLocation() { LocationName = "EL-A-2-3" });
                data.Add(new WarehouseLocation() { LocationName = "CC/A/1-1" });
                data.Add(new WarehouseLocation() { LocationName = "CC/A/1-2" });
                data.Add(new WarehouseLocation() { LocationName = "CC/A/1-3" });
            }
            return data;
        }

        private void beFileCSV_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                if (File.Exists(beFileCSV.Text))
                {
                    xtraOpenFileDialogCsv.FileName = beFileCSV.Text;
                    xtraOpenFileDialogCsv.InitialDirectory = Path.GetDirectoryName(xtraOpenFileDialogCsv.FileName);
                }
                else
                {
                    xtraOpenFileDialogCsv.FileName = "dane.csv";
                }
                if (xtraOpenFileDialogCsv.ShowDialog() == DialogResult.OK)
                {
                    beFileCSV.Text = xtraOpenFileDialogCsv.FileName;
                    Settings.Default.LastFileName = beFileCSV.Text;
                    Settings.Default.Save();
                }
            }
        }
    }
}
