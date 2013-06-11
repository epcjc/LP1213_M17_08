namespace lp17
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label id_equipamentoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_de_aqusicaoLabel;
            System.Windows.Forms.Label garantia_mesesLabel;
            System.Windows.Forms.Label cPULabel;
            System.Windows.Forms.Label disco_DuroLabel;
            System.Windows.Forms.Label memoria_RAMLabel;
            System.Windows.Forms.Label sistema_OperativoLabel;
            System.Windows.Forms.Label placas_de_redeLabel;
            this.database1DataSet1 = new lp17.Database1DataSet1();
            this.equipamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipamentosTableAdapter = new lp17.Database1DataSet1TableAdapters.EquipamentosTableAdapter();
            this.tableAdapterManager = new lp17.Database1DataSet1TableAdapters.TableAdapterManager();
            this.equipamentosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.equipamentosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_equipamentoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_de_aqusicaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.garantia_mesesTextBox = new System.Windows.Forms.TextBox();
            this.cPUTextBox = new System.Windows.Forms.TextBox();
            this.disco_DuroTextBox = new System.Windows.Forms.TextBox();
            this.memoria_RAMTextBox = new System.Windows.Forms.TextBox();
            this.sistema_OperativoTextBox = new System.Windows.Forms.TextBox();
            this.placas_de_redeTextBox = new System.Windows.Forms.TextBox();
            id_equipamentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_de_aqusicaoLabel = new System.Windows.Forms.Label();
            garantia_mesesLabel = new System.Windows.Forms.Label();
            cPULabel = new System.Windows.Forms.Label();
            disco_DuroLabel = new System.Windows.Forms.Label();
            memoria_RAMLabel = new System.Windows.Forms.Label();
            sistema_OperativoLabel = new System.Windows.Forms.Label();
            placas_de_redeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentosBindingNavigator)).BeginInit();
            this.equipamentosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipamentosBindingSource
            // 
            this.equipamentosBindingSource.DataMember = "Equipamentos";
            this.equipamentosBindingSource.DataSource = this.database1DataSet1;
            // 
            // equipamentosTableAdapter
            // 
            this.equipamentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipamentosTableAdapter = this.equipamentosTableAdapter;
            this.tableAdapterManager.Placa_de_redeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lp17.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // equipamentosBindingNavigator
            // 
            this.equipamentosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.equipamentosBindingNavigator.BindingSource = this.equipamentosBindingSource;
            this.equipamentosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equipamentosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.equipamentosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.equipamentosBindingNavigatorSaveItem});
            this.equipamentosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.equipamentosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equipamentosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equipamentosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equipamentosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equipamentosBindingNavigator.Name = "equipamentosBindingNavigator";
            this.equipamentosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equipamentosBindingNavigator.Size = new System.Drawing.Size(461, 25);
            this.equipamentosBindingNavigator.TabIndex = 0;
            this.equipamentosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // equipamentosBindingNavigatorSaveItem
            // 
            this.equipamentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.equipamentosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("equipamentosBindingNavigatorSaveItem.Image")));
            this.equipamentosBindingNavigatorSaveItem.Name = "equipamentosBindingNavigatorSaveItem";
            this.equipamentosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.equipamentosBindingNavigatorSaveItem.Text = "Save Data";
            this.equipamentosBindingNavigatorSaveItem.Click += new System.EventHandler(this.equipamentosBindingNavigatorSaveItem_Click);
            // 
            // id_equipamentoLabel
            // 
            id_equipamentoLabel.AutoSize = true;
            id_equipamentoLabel.Location = new System.Drawing.Point(139, 64);
            id_equipamentoLabel.Name = "id_equipamentoLabel";
            id_equipamentoLabel.Size = new System.Drawing.Size(82, 13);
            id_equipamentoLabel.TabIndex = 1;
            id_equipamentoLabel.Text = "id equipamento:";
            // 
            // id_equipamentoTextBox
            // 
            this.id_equipamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentosBindingSource, "id_equipamento", true));
            this.id_equipamentoTextBox.Location = new System.Drawing.Point(241, 61);
            this.id_equipamentoTextBox.Name = "id_equipamentoTextBox";
            this.id_equipamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_equipamentoTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(139, 90);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentosBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(241, 87);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // data_de_aqusicaoLabel
            // 
            data_de_aqusicaoLabel.AutoSize = true;
            data_de_aqusicaoLabel.Location = new System.Drawing.Point(139, 117);
            data_de_aqusicaoLabel.Name = "data_de_aqusicaoLabel";
            data_de_aqusicaoLabel.Size = new System.Drawing.Size(92, 13);
            data_de_aqusicaoLabel.TabIndex = 5;
            data_de_aqusicaoLabel.Text = "data de aqusicao:";
            // 
            // data_de_aqusicaoDateTimePicker
            // 
            this.data_de_aqusicaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.equipamentosBindingSource, "data_de_aqusicao", true));
            this.data_de_aqusicaoDateTimePicker.Location = new System.Drawing.Point(241, 113);
            this.data_de_aqusicaoDateTimePicker.Name = "data_de_aqusicaoDateTimePicker";
            this.data_de_aqusicaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_de_aqusicaoDateTimePicker.TabIndex = 6;
            // 
            // garantia_mesesLabel
            // 
            garantia_mesesLabel.AutoSize = true;
            garantia_mesesLabel.Location = new System.Drawing.Point(139, 142);
            garantia_mesesLabel.Name = "garantia_mesesLabel";
            garantia_mesesLabel.Size = new System.Drawing.Size(81, 13);
            garantia_mesesLabel.TabIndex = 7;
            garantia_mesesLabel.Text = "garantia meses:";
            // 
            // garantia_mesesTextBox
            // 
            this.garantia_mesesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentosBindingSource, "garantia_meses", true));
            this.garantia_mesesTextBox.Location = new System.Drawing.Point(241, 139);
            this.garantia_mesesTextBox.Name = "garantia_mesesTextBox";
            this.garantia_mesesTextBox.Size = new System.Drawing.Size(200, 20);
            this.garantia_mesesTextBox.TabIndex = 8;
            // 
            // cPULabel
            // 
            cPULabel.AutoSize = true;
            cPULabel.Location = new System.Drawing.Point(139, 168);
            cPULabel.Name = "cPULabel";
            cPULabel.Size = new System.Drawing.Size(32, 13);
            cPULabel.TabIndex = 9;
            cPULabel.Text = "CPU:";
            // 
            // cPUTextBox
            // 
            this.cPUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentosBindingSource, "CPU", true));
            this.cPUTextBox.Location = new System.Drawing.Point(241, 165);
            this.cPUTextBox.Name = "cPUTextBox";
            this.cPUTextBox.Size = new System.Drawing.Size(200, 20);
            this.cPUTextBox.TabIndex = 10;
            // 
            // disco_DuroLabel
            // 
            disco_DuroLabel.AutoSize = true;
            disco_DuroLabel.Location = new System.Drawing.Point(139, 194);
            disco_DuroLabel.Name = "disco_DuroLabel";
            disco_DuroLabel.Size = new System.Drawing.Size(63, 13);
            disco_DuroLabel.TabIndex = 11;
            disco_DuroLabel.Text = "Disco Duro:";
            // 
            // disco_DuroTextBox
            // 
            this.disco_DuroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentosBindingSource, "Disco_Duro", true));
            this.disco_DuroTextBox.Location = new System.Drawing.Point(241, 191);
            this.disco_DuroTextBox.Name = "disco_DuroTextBox";
            this.disco_DuroTextBox.Size = new System.Drawing.Size(200, 20);
            this.disco_DuroTextBox.TabIndex = 12;
            // 
            // memoria_RAMLabel
            // 
            memoria_RAMLabel.AutoSize = true;
            memoria_RAMLabel.Location = new System.Drawing.Point(139, 220);
            memoria_RAMLabel.Name = "memoria_RAMLabel";
            memoria_RAMLabel.Size = new System.Drawing.Size(77, 13);
            memoria_RAMLabel.TabIndex = 13;
            memoria_RAMLabel.Text = "Memoria RAM:";
            // 
            // memoria_RAMTextBox
            // 
            this.memoria_RAMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentosBindingSource, "Memoria_RAM", true));
            this.memoria_RAMTextBox.Location = new System.Drawing.Point(241, 217);
            this.memoria_RAMTextBox.Name = "memoria_RAMTextBox";
            this.memoria_RAMTextBox.Size = new System.Drawing.Size(200, 20);
            this.memoria_RAMTextBox.TabIndex = 14;
            // 
            // sistema_OperativoLabel
            // 
            sistema_OperativoLabel.AutoSize = true;
            sistema_OperativoLabel.Location = new System.Drawing.Point(139, 246);
            sistema_OperativoLabel.Name = "sistema_OperativoLabel";
            sistema_OperativoLabel.Size = new System.Drawing.Size(96, 13);
            sistema_OperativoLabel.TabIndex = 15;
            sistema_OperativoLabel.Text = "Sistema Operativo:";
            // 
            // sistema_OperativoTextBox
            // 
            this.sistema_OperativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentosBindingSource, "Sistema_Operativo", true));
            this.sistema_OperativoTextBox.Location = new System.Drawing.Point(241, 243);
            this.sistema_OperativoTextBox.Name = "sistema_OperativoTextBox";
            this.sistema_OperativoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sistema_OperativoTextBox.TabIndex = 16;
            // 
            // placas_de_redeLabel
            // 
            placas_de_redeLabel.AutoSize = true;
            placas_de_redeLabel.Location = new System.Drawing.Point(139, 272);
            placas_de_redeLabel.Name = "placas_de_redeLabel";
            placas_de_redeLabel.Size = new System.Drawing.Size(80, 13);
            placas_de_redeLabel.TabIndex = 17;
            placas_de_redeLabel.Text = "placas de rede:";
            // 
            // placas_de_redeTextBox
            // 
            this.placas_de_redeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentosBindingSource, "placas_de_rede", true));
            this.placas_de_redeTextBox.Location = new System.Drawing.Point(241, 269);
            this.placas_de_redeTextBox.Name = "placas_de_redeTextBox";
            this.placas_de_redeTextBox.Size = new System.Drawing.Size(200, 20);
            this.placas_de_redeTextBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 309);
            this.Controls.Add(id_equipamentoLabel);
            this.Controls.Add(this.id_equipamentoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(data_de_aqusicaoLabel);
            this.Controls.Add(this.data_de_aqusicaoDateTimePicker);
            this.Controls.Add(garantia_mesesLabel);
            this.Controls.Add(this.garantia_mesesTextBox);
            this.Controls.Add(cPULabel);
            this.Controls.Add(this.cPUTextBox);
            this.Controls.Add(disco_DuroLabel);
            this.Controls.Add(this.disco_DuroTextBox);
            this.Controls.Add(memoria_RAMLabel);
            this.Controls.Add(this.memoria_RAMTextBox);
            this.Controls.Add(sistema_OperativoLabel);
            this.Controls.Add(this.sistema_OperativoTextBox);
            this.Controls.Add(placas_de_redeLabel);
            this.Controls.Add(this.placas_de_redeTextBox);
            this.Controls.Add(this.equipamentosBindingNavigator);
            this.Name = "Form1";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentosBindingNavigator)).EndInit();
            this.equipamentosBindingNavigator.ResumeLayout(false);
            this.equipamentosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource equipamentosBindingSource;
        private Database1DataSet1TableAdapters.EquipamentosTableAdapter equipamentosTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator equipamentosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton equipamentosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_equipamentoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_de_aqusicaoDateTimePicker;
        private System.Windows.Forms.TextBox garantia_mesesTextBox;
        private System.Windows.Forms.TextBox cPUTextBox;
        private System.Windows.Forms.TextBox disco_DuroTextBox;
        private System.Windows.Forms.TextBox memoria_RAMTextBox;
        private System.Windows.Forms.TextBox sistema_OperativoTextBox;
        private System.Windows.Forms.TextBox placas_de_redeTextBox;





    }
}

