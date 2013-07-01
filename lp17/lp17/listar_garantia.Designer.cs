namespace lp17
{
    partial class listar_garantia
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
            this.database1DataSet = new lp17.Database1DataSet();
            this.equipamentos2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipamentos2TableAdapter = new lp17.Database1DataSetTableAdapters.Equipamentos2TableAdapter();
            this.tableAdapterManager = new lp17.Database1DataSetTableAdapters.TableAdapterManager();
            this.equipamentos2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentos2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentos2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipamentos2BindingSource
            // 
            this.equipamentos2BindingSource.DataMember = "Equipamentos2";
            this.equipamentos2BindingSource.DataSource = this.database1DataSet;
            // 
            // equipamentos2TableAdapter
            // 
            this.equipamentos2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Equipamentos2TableAdapter = this.equipamentos2TableAdapter;
            this.tableAdapterManager.EquipamentosTableAdapter = null;
            this.tableAdapterManager.Placa_de_redeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lp17.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // equipamentos2DataGridView
            // 
            this.equipamentos2DataGridView.AutoGenerateColumns = false;
            this.equipamentos2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipamentos2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.equipamentos2DataGridView.DataSource = this.equipamentos2BindingSource;
            this.equipamentos2DataGridView.Location = new System.Drawing.Point(61, 73);
            this.equipamentos2DataGridView.Name = "equipamentos2DataGridView";
            this.equipamentos2DataGridView.Size = new System.Drawing.Size(357, 220);
            this.equipamentos2DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "garantia_meses";
            this.dataGridViewTextBoxColumn2.HeaderText = "garantia_meses";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_equipamento";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_equipamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GARANTIA EXPIRADA (PASSOU 12 MESES)";
            // 
            // listar_garantia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipamentos2DataGridView);
            this.Name = "listar_garantia";
            this.Text = "listar_garantia";
            this.Load += new System.EventHandler(this.listar_garantia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentos2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentos2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource equipamentos2BindingSource;
        private Database1DataSetTableAdapters.Equipamentos2TableAdapter equipamentos2TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView equipamentos2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}