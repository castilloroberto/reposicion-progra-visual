
namespace Reposicion
{
    partial class reportesss
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CAJEROBDDataSet = new Reposicion.CAJEROBDDataSet();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cajerobdDataSet1 = new Reposicion.CAJEROBDDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.CajeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAJEROBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajerobdDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CajeroBindingSource
            // 
            this.CajeroBindingSource.DataMember = "Cajero";
            this.CajeroBindingSource.DataSource = this.CAJEROBDDataSet;
            // 
            // CAJEROBDDataSet
            // 
            this.CAJEROBDDataSet.DataSetName = "CAJEROBDDataSet";
            this.CAJEROBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CajeroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reposicion.CajeroReporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(67, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(645, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Cajero";
            this.bindingSource1.DataSource = this.cajerobdDataSet1;
            // 
            // cajerobdDataSet1
            // 
            this.cajerobdDataSet1.DataSetName = "CAJEROBDDataSet";
            this.cajerobdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportesss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportesss";
            this.Text = "reportesss";
            this.Load += new System.EventHandler(this.reportesss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CajeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAJEROBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajerobdDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CajeroBindingSource;
        private CAJEROBDDataSet CAJEROBDDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CAJEROBDDataSet cajerobdDataSet1;
    }
}