namespace lp17
{
    partial class Le_1
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
            this.database1DataSet = new lp17.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EquipamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EquipamentosTableAdapter = new lp17.Database1DataSetTableAdapters.EquipamentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EquipamentosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lp17.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(393, 277);
            this.reportViewer1.TabIndex = 0;
            // 
            // EquipamentosBindingSource
            // 
            this.EquipamentosBindingSource.DataMember = "Equipamentos";
            this.EquipamentosBindingSource.DataSource = this.database1DataSet;
            // 
            // EquipamentosTableAdapter
            // 
            this.EquipamentosTableAdapter.ClearBeforeFill = true;
            // 
            // Le_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 277);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Le_1";
            this.Text = "Le_1";
            this.Load += new System.EventHandler(this.Le_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipamentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EquipamentosBindingSource;
        private Database1DataSetTableAdapters.EquipamentosTableAdapter EquipamentosTableAdapter;

    }
}