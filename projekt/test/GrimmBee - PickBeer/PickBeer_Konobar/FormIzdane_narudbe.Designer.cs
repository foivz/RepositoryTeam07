﻿namespace PickBeer_Konobar
{
    partial class FormIzdane_narudbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzdane_narudbe));
            this.t07_DBDataSet = new PickBeer_Konobar.T07_DBDataSet();
            this.kosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosaricaTableAdapter = new PickBeer_Konobar.T07_DBDataSetTableAdapters.KosaricaTableAdapter();
            this.tableAdapterManager = new PickBeer_Konobar.T07_DBDataSetTableAdapters.TableAdapterManager();
            this.stavke_kosaricaTableAdapter = new PickBeer_Konobar.T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter();
            this.kosaricaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.kosaricaDataGridView = new System.Windows.Forms.DataGridView();
            this.stavke_kosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_kosaricaDataGridView = new System.Windows.Forms.DataGridView();
            this.izdane_narudžbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdane_narudžbeTableAdapter = new PickBeer_Konobar.T07_DBDataSetTableAdapters.Izdane_narudžbeTableAdapter();
            this.iDkosaricaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t07_DBDataSet1 = new PickBeer_Konobar.T07_DBDataSet();
            this.pivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pivoTableAdapter = new PickBeer_Konobar.T07_DBDataSetTableAdapters.PivoTableAdapter();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.pivoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv_piva = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingNavigator)).BeginInit();
            this.kosaricaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdane_narudžbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // t07_DBDataSet
            // 
            this.t07_DBDataSet.DataSetName = "T07_DBDataSet";
            this.t07_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kosaricaBindingSource
            // 
            this.kosaricaBindingSource.DataMember = "Kosarica";
            this.kosaricaBindingSource.DataSource = this.t07_DBDataSet;
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
            this.tableAdapterManager.Table_testTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PickBeer_Konobar.T07_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stavke_kosaricaTableAdapter
            // 
            this.stavke_kosaricaTableAdapter.ClearBeforeFill = true;
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
            this.kosaricaBindingNavigator.Size = new System.Drawing.Size(637, 25);
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
            // kosaricaDataGridView
            // 
            this.kosaricaDataGridView.AllowUserToAddRows = false;
            this.kosaricaDataGridView.AllowUserToDeleteRows = false;
            this.kosaricaDataGridView.AutoGenerateColumns = false;
            this.kosaricaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kosaricaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkosaricaDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn});
            this.kosaricaDataGridView.DataSource = this.izdane_narudžbeBindingSource;
            this.kosaricaDataGridView.Location = new System.Drawing.Point(12, 28);
            this.kosaricaDataGridView.Name = "kosaricaDataGridView";
            this.kosaricaDataGridView.ReadOnly = true;
            this.kosaricaDataGridView.Size = new System.Drawing.Size(350, 220);
            this.kosaricaDataGridView.TabIndex = 1;
            this.kosaricaDataGridView.SelectionChanged += new System.EventHandler(this.kosaricaDataGridView_SelectionChanged);
            // 
            // stavke_kosaricaBindingSource
            // 
            this.stavke_kosaricaBindingSource.DataMember = "Stavke_kosarica";
            this.stavke_kosaricaBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // stavke_kosaricaDataGridView
            // 
            this.stavke_kosaricaDataGridView.AllowUserToAddRows = false;
            this.stavke_kosaricaDataGridView.AllowUserToDeleteRows = false;
            this.stavke_kosaricaDataGridView.AutoGenerateColumns = false;
            this.stavke_kosaricaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavke_kosaricaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Naziv_piva,
            this.dataGridViewTextBoxColumn5,
            this.Cijena,
            this.Ukupno,
            this.dataGridViewTextBoxColumn4});
            this.stavke_kosaricaDataGridView.DataSource = this.stavke_kosaricaBindingSource;
            this.stavke_kosaricaDataGridView.Location = new System.Drawing.Point(12, 304);
            this.stavke_kosaricaDataGridView.Name = "stavke_kosaricaDataGridView";
            this.stavke_kosaricaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavke_kosaricaDataGridView.Size = new System.Drawing.Size(569, 220);
            this.stavke_kosaricaDataGridView.TabIndex = 2;
            // 
            // izdane_narudžbeBindingSource
            // 
            this.izdane_narudžbeBindingSource.DataMember = "Izdane narudžbe";
            this.izdane_narudžbeBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // izdane_narudžbeTableAdapter
            // 
            this.izdane_narudžbeTableAdapter.ClearBeforeFill = true;
            // 
            // iDkosaricaDataGridViewTextBoxColumn
            // 
            this.iDkosaricaDataGridViewTextBoxColumn.DataPropertyName = "ID_kosarica";
            this.iDkosaricaDataGridViewTextBoxColumn.HeaderText = "Šifra košarice";
            this.iDkosaricaDataGridViewTextBoxColumn.Name = "iDkosaricaDataGridViewTextBoxColumn";
            this.iDkosaricaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "Vrijeme izdavanja";
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            this.vrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijemeDataGridViewTextBoxColumn.Width = 150;
            // 
            // t07_DBDataSet1
            // 
            this.t07_DBDataSet1.DataSetName = "T07_DBDataSet";
            this.t07_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pivoBindingSource
            // 
            this.pivoBindingSource.DataMember = "Pivo";
            this.pivoBindingSource.DataSource = this.t07_DBDataSet1;
            // 
            // pivoTableAdapter
            // 
            this.pivoTableAdapter.ClearBeforeFill = true;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(90, 551);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(111, 20);
            this.txtUkupno.TabIndex = 3;
            // 
            // pivoBindingSource1
            // 
            this.pivoBindingSource1.DataMember = "Pivo";
            this.pivoBindingSource1.DataSource = this.t07_DBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ukupan iznos:";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_pivo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Šifra piva";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Naziv_piva
            // 
            this.Naziv_piva.DataPropertyName = "ID_pivo";
            this.Naziv_piva.DataSource = this.pivoBindingSource;
            this.Naziv_piva.DisplayMember = "Ime_piva";
            this.Naziv_piva.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Naziv_piva.HeaderText = "Naziv piva";
            this.Naziv_piva.Name = "Naziv_piva";
            this.Naziv_piva.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Naziv_piva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Naziv_piva.ValueMember = "ID_pivo";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn5.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "ID_pivo";
            this.Cijena.DataSource = this.pivoBindingSource;
            this.Cijena.DisplayMember = "Cijena";
            this.Cijena.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cijena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cijena.ValueMember = "ID_pivo";
            // 
            // Ukupno
            // 
            this.Ukupno.HeaderText = "Iznos";
            this.Ukupno.Name = "Ukupno";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_kosarica";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_kosarica";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // FormIzdane_narudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.stavke_kosaricaDataGridView);
            this.Controls.Add(this.kosaricaDataGridView);
            this.Controls.Add(this.kosaricaBindingNavigator);
            this.Name = "FormIzdane_narudbe";
            this.Text = "Izdane narudžbe";
            this.Load += new System.EventHandler(this.FormIzdane_narudbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaBindingNavigator)).EndInit();
            this.kosaricaBindingNavigator.ResumeLayout(false);
            this.kosaricaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavke_kosaricaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdane_narudžbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivoBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView kosaricaDataGridView;
        private T07_DBDataSetTableAdapters.Stavke_kosaricaTableAdapter stavke_kosaricaTableAdapter;
        private System.Windows.Forms.BindingSource stavke_kosaricaBindingSource;
        private System.Windows.Forms.DataGridView stavke_kosaricaDataGridView;
        private System.Windows.Forms.BindingSource izdane_narudžbeBindingSource;
        private T07_DBDataSetTableAdapters.Izdane_narudžbeTableAdapter izdane_narudžbeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkosaricaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private T07_DBDataSet t07_DBDataSet1;
        private System.Windows.Forms.BindingSource pivoBindingSource;
        private T07_DBDataSetTableAdapters.PivoTableAdapter pivoTableAdapter;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.BindingSource pivoBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Naziv_piva;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}