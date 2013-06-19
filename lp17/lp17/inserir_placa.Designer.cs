namespace lp17
{
    partial class inserir_placa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inserir_placa));
            System.Windows.Forms.Label id_placaLabel;
            System.Windows.Forms.Label endereço_IPLabel;
            System.Windows.Forms.Label endereco_broadcastLabel;
            this.database1DataSet = new lp17.Database1DataSet();
            this.placa_de_redeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placa_de_redeTableAdapter = new lp17.Database1DataSetTableAdapters.Placa_de_redeTableAdapter();
            this.tableAdapterManager = new lp17.Database1DataSetTableAdapters.TableAdapterManager();
            this.placa_de_redeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.placa_de_redeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_placaTextBox = new System.Windows.Forms.TextBox();
            this.endereço_IPTextBox = new System.Windows.Forms.TextBox();
            this.endereco_broadcastTextBox = new System.Windows.Forms.TextBox();
            id_placaLabel = new System.Windows.Forms.Label();
            endereço_IPLabel = new System.Windows.Forms.Label();
            endereco_broadcastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placa_de_redeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placa_de_redeBindingNavigator)).BeginInit();
            this.placa_de_redeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placa_de_redeBindingSource
            // 
            this.placa_de_redeBindingSource.DataMember = "Placa de rede";
            this.placa_de_redeBindingSource.DataSource = this.database1DataSet;
            // 
            // placa_de_redeTableAdapter
            // 
            this.placa_de_redeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipamentosTableAdapter = null;
            this.tableAdapterManager.Placa_de_redeTableAdapter = this.placa_de_redeTableAdapter;
            this.tableAdapterManager.UpdateOrder = lp17.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // placa_de_redeBindingNavigator
            // 
            this.placa_de_redeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.placa_de_redeBindingNavigator.BindingSource = this.placa_de_redeBindingSource;
            this.placa_de_redeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.placa_de_redeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.placa_de_redeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.placa_de_redeBindingNavigatorSaveItem});
            this.placa_de_redeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.placa_de_redeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.placa_de_redeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.placa_de_redeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.placa_de_redeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.placa_de_redeBindingNavigator.Name = "placa_de_redeBindingNavigator";
            this.placa_de_redeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.placa_de_redeBindingNavigator.Size = new System.Drawing.Size(317, 25);
            this.placa_de_redeBindingNavigator.TabIndex = 0;
            this.placa_de_redeBindingNavigator.Text = "bindingNavigator1";
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
            // placa_de_redeBindingNavigatorSaveItem
            // 
            this.placa_de_redeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.placa_de_redeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("placa_de_redeBindingNavigatorSaveItem.Image")));
            this.placa_de_redeBindingNavigatorSaveItem.Name = "placa_de_redeBindingNavigatorSaveItem";
            this.placa_de_redeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.placa_de_redeBindingNavigatorSaveItem.Text = "Save Data";
            this.placa_de_redeBindingNavigatorSaveItem.Click += new System.EventHandler(this.placa_de_redeBindingNavigatorSaveItem_Click);
            // 
            // id_placaLabel
            // 
            id_placaLabel.AutoSize = true;
            id_placaLabel.Location = new System.Drawing.Point(86, 84);
            id_placaLabel.Name = "id_placaLabel";
            id_placaLabel.Size = new System.Drawing.Size(47, 13);
            id_placaLabel.TabIndex = 1;
            id_placaLabel.Text = "id placa:";
            // 
            // id_placaTextBox
            // 
            this.id_placaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placa_de_redeBindingSource, "id_placa", true));
            this.id_placaTextBox.Location = new System.Drawing.Point(197, 81);
            this.id_placaTextBox.Name = "id_placaTextBox";
            this.id_placaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_placaTextBox.TabIndex = 2;
            // 
            // endereço_IPLabel
            // 
            endereço_IPLabel.AutoSize = true;
            endereço_IPLabel.Location = new System.Drawing.Point(86, 110);
            endereço_IPLabel.Name = "endereço_IPLabel";
            endereço_IPLabel.Size = new System.Drawing.Size(68, 13);
            endereço_IPLabel.TabIndex = 3;
            endereço_IPLabel.Text = "endereço IP:";
            // 
            // endereço_IPTextBox
            // 
            this.endereço_IPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placa_de_redeBindingSource, "endereço_IP", true));
            this.endereço_IPTextBox.Location = new System.Drawing.Point(197, 107);
            this.endereço_IPTextBox.Name = "endereço_IPTextBox";
            this.endereço_IPTextBox.Size = new System.Drawing.Size(100, 20);
            this.endereço_IPTextBox.TabIndex = 4;
            // 
            // endereco_broadcastLabel
            // 
            endereco_broadcastLabel.AutoSize = true;
            endereco_broadcastLabel.Location = new System.Drawing.Point(86, 136);
            endereco_broadcastLabel.Name = "endereco_broadcastLabel";
            endereco_broadcastLabel.Size = new System.Drawing.Size(105, 13);
            endereco_broadcastLabel.TabIndex = 5;
            endereco_broadcastLabel.Text = "endereco broadcast:";
            // 
            // endereco_broadcastTextBox
            // 
            this.endereco_broadcastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placa_de_redeBindingSource, "endereco_broadcast", true));
            this.endereco_broadcastTextBox.Location = new System.Drawing.Point(197, 133);
            this.endereco_broadcastTextBox.Name = "endereco_broadcastTextBox";
            this.endereco_broadcastTextBox.Size = new System.Drawing.Size(100, 20);
            this.endereco_broadcastTextBox.TabIndex = 6;
            // 
            // inserir_placa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 262);
            this.Controls.Add(id_placaLabel);
            this.Controls.Add(this.id_placaTextBox);
            this.Controls.Add(endereço_IPLabel);
            this.Controls.Add(this.endereço_IPTextBox);
            this.Controls.Add(endereco_broadcastLabel);
            this.Controls.Add(this.endereco_broadcastTextBox);
            this.Controls.Add(this.placa_de_redeBindingNavigator);
            this.Name = "inserir_placa";
            this.Text = "inserir_placa";
            this.Load += new System.EventHandler(this.inserir_placa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placa_de_redeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placa_de_redeBindingNavigator)).EndInit();
            this.placa_de_redeBindingNavigator.ResumeLayout(false);
            this.placa_de_redeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource placa_de_redeBindingSource;
        private Database1DataSetTableAdapters.Placa_de_redeTableAdapter placa_de_redeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator placa_de_redeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton placa_de_redeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_placaTextBox;
        private System.Windows.Forms.TextBox endereço_IPTextBox;
        private System.Windows.Forms.TextBox endereco_broadcastTextBox;
    }
}