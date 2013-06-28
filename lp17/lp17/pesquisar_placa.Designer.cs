namespace lp17
{
    partial class pesquisar_placa
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
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new lp17.Database1DataSet();
            this.dataTable1TableAdapter = new lp17.Database1DataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new lp17.Database1DataSetTableAdapters.TableAdapterManager();
            this.endereço_IPToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.endereço_IPToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillpesqEndereçoIPToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillpesqEndereçoIPToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.fillpesqEndereçoIPToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(0, 54);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.Size = new System.Drawing.Size(827, 220);
            this.dataTable1DataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data_de_aqusicao";
            this.dataGridViewTextBoxColumn2.HeaderText = "data_de_aqusicao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "garantia_meses";
            this.dataGridViewTextBoxColumn3.HeaderText = "garantia_meses";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CPU(marca)";
            this.dataGridViewTextBoxColumn4.HeaderText = "CPU(marca)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Disco_Duro(gigabites)";
            this.dataGridViewTextBoxColumn5.HeaderText = "Disco_Duro(gigabites)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Memoria_RAM(gibabites)";
            this.dataGridViewTextBoxColumn6.HeaderText = "Memoria_RAM(gibabites)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sistema_Operativo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sistema_Operativo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "endereço_IP";
            this.dataGridViewTextBoxColumn8.HeaderText = "endereço_IP";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EquipamentosTableAdapter = null;
            this.tableAdapterManager.Placa_de_redeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lp17.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // endereço_IPToolStripLabel
            // 
            this.endereço_IPToolStripLabel.Name = "endereço_IPToolStripLabel";
            this.endereço_IPToolStripLabel.Size = new System.Drawing.Size(74, 22);
            this.endereço_IPToolStripLabel.Text = "endereço_IP:";
            // 
            // endereço_IPToolStripTextBox
            // 
            this.endereço_IPToolStripTextBox.Name = "endereço_IPToolStripTextBox";
            this.endereço_IPToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillpesqEndereçoIPToolStripButton
            // 
            this.fillpesqEndereçoIPToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillpesqEndereçoIPToolStripButton.Name = "fillpesqEndereçoIPToolStripButton";
            this.fillpesqEndereçoIPToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.fillpesqEndereçoIPToolStripButton.Text = "PESQUISAR";
            this.fillpesqEndereçoIPToolStripButton.Click += new System.EventHandler(this.fillpesqEndereçoIPToolStripButton_Click);
            // 
            // fillpesqEndereçoIPToolStrip
            // 
            this.fillpesqEndereçoIPToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endereço_IPToolStripLabel,
            this.endereço_IPToolStripTextBox,
            this.fillpesqEndereçoIPToolStripButton});
            this.fillpesqEndereçoIPToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillpesqEndereçoIPToolStrip.Name = "fillpesqEndereçoIPToolStrip";
            this.fillpesqEndereçoIPToolStrip.Size = new System.Drawing.Size(827, 25);
            this.fillpesqEndereçoIPToolStrip.TabIndex = 6;
            this.fillpesqEndereçoIPToolStrip.Text = "fillpesqEndereçoIPToolStrip";
            // 
            // pesquisar_placa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 390);
            this.Controls.Add(this.dataTable1DataGridView);
            this.Controls.Add(this.fillpesqEndereçoIPToolStrip);
            this.Name = "pesquisar_placa";
            this.Text = "pesquisar_placa";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.fillpesqEndereçoIPToolStrip.ResumeLayout(false);
            this.fillpesqEndereçoIPToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Database1DataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripLabel endereço_IPToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox endereço_IPToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillpesqEndereçoIPToolStripButton;
        private System.Windows.Forms.ToolStrip fillpesqEndereçoIPToolStrip;
    }
}