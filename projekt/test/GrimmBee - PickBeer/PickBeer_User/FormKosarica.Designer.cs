﻿namespace PickBeer_User
{
    partial class FormKosarica
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
            System.Windows.Forms.Label iD_kosaricaLabel;
            System.Windows.Forms.Label vrijemeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKosarica));
            this.kosaricaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.kosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t07_DBDataSet = new PickBeer_User.T07_DBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kosaricaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_kosaricaTextBox = new System.Windows.Forms.TextBox();
            this.vrijemeTextBox = new System.Windows.Forms.TextBox();
            this.stavke_kosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNaruci = new System.Windows.Forms.Button();
            this.kosaricaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.KosaricaTableAdapter();
            this.tableAdapterManager = new PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager();
            this.stavke_kosaricaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter();
            this.pivoTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.PivoTableAdapter();
            this.stavke_kosaricaDataGridView = new System.Windows.Forms.DataGridView();
            this.iDpivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imepivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pregled_narudbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregled_narudbeTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.Pregled_narudbeTableAdapter();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.lblUkupno = new System.Windows.Forms.Label();
            iD_kosaricaLabel = new System.Windows.Forms.Label();
            vrijemeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingNavigator)).BeginInit();
            this.kosaricaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_narudbeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_kosaricaLabel
            // 
            iD_kosaricaLabel.AutoSize = true;
            iD_kosaricaLabel.Location = new System.Drawing.Point(12, 38);
            iD_kosaricaLabel.Name = "iD_kosaricaLabel";
            iD_kosaricaLabel.Size = new System.Drawing.Size(64, 13);
            iD_kosaricaLabel.TabIndex = 1;
            iD_kosaricaLabel.Text = "ID kosarica:";
            // 
            // vrijemeLabel
            // 
            vrijemeLabel.AutoSize = true;
            vrijemeLabel.Location = new System.Drawing.Point(188, 38);
            vrijemeLabel.Name = "vrijemeLabel";
            vrijemeLabel.Size = new System.Drawing.Size(44, 13);
            vrijemeLabel.TabIndex = 3;
            vrijemeLabel.Text = "Vrijeme:";
            // 
            // kosaricaBindingNavigator
            // 
            this.kosaricaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kosaricaBindingNavigator.BindingSource = this.kosaricaBindingSource;
            this.kosaricaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kosaricaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kosaricaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kosaricaBindingNavigatorSaveItem});
            this.kosaricaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kosaricaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kosaricaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kosaricaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kosaricaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kosaricaBindingNavigator.Name = "kosaricaBindingNavigator";
            this.kosaricaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kosaricaBindingNavigator.Size = new System.Drawing.Size(603, 25);
            this.kosaricaBindingNavigator.TabIndex = 0;
            this.kosaricaBindingNavigator.Text = "bindingNavigator1";
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
            // kosaricaBindingSource
            // 
            this.kosaricaBindingSource.DataMember = "Kosarica";
            this.kosaricaBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // t07_DBDataSet
            // 
            this.t07_DBDataSet.DataSetName = "T07_DBDataSet";
            this.t07_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // kosaricaBindingNavigatorSaveItem
            // 
            this.kosaricaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kosaricaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kosaricaBindingNavigatorSaveItem.Image")));
            this.kosaricaBindingNavigatorSaveItem.Name = "kosaricaBindingNavigatorSaveItem";
            this.kosaricaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kosaricaBindingNavigatorSaveItem.Text = "Save Data";
            this.kosaricaBindingNavigatorSaveItem.Click += new System.EventHandler(this.kosaricaBindingNavigatorSaveItem_Click);
            // 
            // iD_kosaricaTextBox
            // 
            this.iD_kosaricaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kosaricaBindingSource, "ID_kosarica", true));
            this.iD_kosaricaTextBox.Location = new System.Drawing.Point(82, 35);
            this.iD_kosaricaTextBox.Name = "iD_kosaricaTextBox";
            this.iD_kosaricaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_kosaricaTextBox.TabIndex = 2;
            // 
            // vrijemeTextBox
            // 
            this.vrijemeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kosaricaBindingSource, "Vrijeme", true));
            this.vrijemeTextBox.Location = new System.Drawing.Point(238, 35);
            this.vrijemeTextBox.Name = "vrijemeTextBox";
            this.vrijemeTextBox.Size = new System.Drawing.Size(100, 20);
            this.vrijemeTextBox.TabIndex = 4;
            // 
            // stavke_kosaricaBindingSource
            // 
            this.stavke_kosaricaBindingSource.DataMember = "FK_Stavke_kosarica_Kosarica";
            this.stavke_kosaricaBindingSource.DataSource = this.kosaricaBindingSource;
            // 
            // pivoBindingSource
            // 
            this.pivoBindingSource.DataMember = "Pivo";
            this.pivoBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // buttonNaruci
            // 
            this.buttonNaruci.Location = new System.Drawing.Point(516, 258);
            this.buttonNaruci.Name = "buttonNaruci";
            this.buttonNaruci.Size = new System.Drawing.Size(75, 23);
            this.buttonNaruci.TabIndex = 6;
            this.buttonNaruci.Text = "Naruči";
            this.buttonNaruci.UseVisualStyleBackColor = true;
            this.buttonNaruci.Click += new System.EventHandler(this.buttonNaruci_Click);
            // 
            // kosaricaTableAdapter
            // 
            this.kosaricaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KosaricaTableAdapter = this.kosaricaTableAdapter;
            this.tableAdapterManager.PivoTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavke_kosaricaTableAdapter = this.stavke_kosaricaTableAdapter;
            this.tableAdapterManager.Stavke_racunTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stavke_kosaricaTableAdapter
            // 
            this.stavke_kosaricaTableAdapter.ClearBeforeFill = true;
            // 
            // pivoTableAdapter
            // 
            this.pivoTableAdapter.ClearBeforeFill = true;
            // 
            // stavke_kosaricaDataGridView
            // 
            this.stavke_kosaricaDataGridView.AllowUserToAddRows = false;
            this.stavke_kosaricaDataGridView.AutoGenerateColumns = false;
            this.stavke_kosaricaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavke_kosaricaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpivoDataGridViewTextBoxColumn,
            this.imepivaDataGridViewTextBoxColumn,
            this.Column1,
            this.kolicinaDataGridViewTextBoxColumn,
            this.ukupnoDataGridViewTextBoxColumn});
            this.stavke_kosaricaDataGridView.DataSource = this.pregled_narudbeBindingSource;
            this.stavke_kosaricaDataGridView.Location = new System.Drawing.Point(12, 61);
            this.stavke_kosaricaDataGridView.Name = "stavke_kosaricaDataGridView";
            this.stavke_kosaricaDataGridView.ReadOnly = true;
            this.stavke_kosaricaDataGridView.Size = new System.Drawing.Size(579, 172);
            this.stavke_kosaricaDataGridView.TabIndex = 5;
            this.stavke_kosaricaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stavke_kosaricaDataGridView_CellContentClick);
            // 
            // iDpivoDataGridViewTextBoxColumn
            // 
            this.iDpivoDataGridViewTextBoxColumn.DataPropertyName = "ID_pivo";
            this.iDpivoDataGridViewTextBoxColumn.HeaderText = "Šifra piva";
            this.iDpivoDataGridViewTextBoxColumn.Name = "iDpivoDataGridViewTextBoxColumn";
            this.iDpivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imepivaDataGridViewTextBoxColumn
            // 
            this.imepivaDataGridViewTextBoxColumn.DataPropertyName = "Ime_piva";
            this.imepivaDataGridViewTextBoxColumn.HeaderText = "Naziv piva";
            this.imepivaDataGridViewTextBoxColumn.Name = "imepivaDataGridViewTextBoxColumn";
            this.imepivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_pivo";
            this.Column1.DataSource = this.pivoBindingSource;
            this.Column1.DisplayMember = "Cijena";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Cijena";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.ValueMember = "ID_pivo";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ukupnoDataGridViewTextBoxColumn
            // 
            this.ukupnoDataGridViewTextBoxColumn.DataPropertyName = "Ukupno";
            this.ukupnoDataGridViewTextBoxColumn.HeaderText = "Ukupno";
            this.ukupnoDataGridViewTextBoxColumn.Name = "ukupnoDataGridViewTextBoxColumn";
            this.ukupnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pregled_narudbeBindingSource
            // 
            this.pregled_narudbeBindingSource.DataMember = "Pregled_narudbe";
            this.pregled_narudbeBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // pregled_narudbeTableAdapter
            // 
            this.pregled_narudbeTableAdapter.ClearBeforeFill = true;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(66, 255);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(100, 20);
            this.txtUkupno.TabIndex = 9;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(12, 258);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(48, 13);
            this.lblUkupno.TabIndex = 10;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // FormKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 296);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.buttonNaruci);
            this.Controls.Add(this.stavke_kosaricaDataGridView);
            this.Controls.Add(vrijemeLabel);
            this.Controls.Add(this.vrijemeTextBox);
            this.Controls.Add(iD_kosaricaLabel);
            this.Controls.Add(this.iD_kosaricaTextBox);
            this.Controls.Add(this.kosaricaBindingNavigator);
            this.Name = "FormKosarica";
            this.Text = "Košarica";
            this.Load += new System.EventHandler(this.FormKosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingNavigator)).EndInit();
            this.kosaricaBindingNavigator.ResumeLayout(false);
            this.kosaricaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_narudbeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private T07_DBDataSet t07_DBDataSet;
        private System.Windows.Forms.BindingSource kosaricaBindingSource;
        private T07_DBDataSetTableAdapters.KosaricaTableAdapter kosaricaTableAdapter;
        private T07_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kosaricaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kosaricaBindingNavigatorSaveItem;
        private T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter stavke_kosaricaTableAdapter;
        private System.Windows.Forms.TextBox iD_kosaricaTextBox;
        private System.Windows.Forms.TextBox vrijemeTextBox;
        private System.Windows.Forms.BindingSource stavke_kosaricaBindingSource;
        private System.Windows.Forms.Button buttonNaruci;
        private System.Windows.Forms.BindingSource pivoBindingSource;
        private T07_DBDataSetTableAdapters.PivoTableAdapter pivoTableAdapter;
        private System.Windows.Forms.DataGridView stavke_kosaricaDataGridView;
        private System.Windows.Forms.BindingSource pregled_narudbeBindingSource;
        private T07_DBDataSetTableAdapters.Pregled_narudbeTableAdapter pregled_narudbeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imepivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label lblUkupno;

    }
}