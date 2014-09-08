namespace PickBeer_User
{
    partial class FormRoulette
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
            System.Windows.Forms.Label drzava_podrijetlaLabel;
            System.Windows.Forms.Label ime_pivaLabel;
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label volumenLabel;
            System.Windows.Forms.Label slikaLabel;
            this.drzava_podrijetlaTextBox = new System.Windows.Forms.TextBox();
            this.random_DrzavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t07_DBDataSet = new PickBeer_User.T07_DBDataSet();
            this.buttonPonovno = new System.Windows.Forms.Button();
            this.tableAdapterManager = new PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager();
            this.random_DrzavaTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.Random_DrzavaTableAdapter();
            this.rouletteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rouletteTableAdapter = new PickBeer_User.T07_DBDataSetTableAdapters.RouletteTableAdapter();
            this.ime_pivaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxRoulette = new System.Windows.Forms.PictureBox();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.volumenTextBox = new System.Windows.Forms.TextBox();
            this.slikaTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            drzava_podrijetlaLabel = new System.Windows.Forms.Label();
            ime_pivaLabel = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            volumenLabel = new System.Windows.Forms.Label();
            slikaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.random_DrzavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rouletteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoulette)).BeginInit();
            this.SuspendLayout();
            // 
            // drzava_podrijetlaLabel
            // 
            drzava_podrijetlaLabel.AutoSize = true;
            drzava_podrijetlaLabel.Location = new System.Drawing.Point(12, 9);
            drzava_podrijetlaLabel.Name = "drzava_podrijetlaLabel";
            drzava_podrijetlaLabel.Size = new System.Drawing.Size(89, 13);
            drzava_podrijetlaLabel.TabIndex = 1;
            drzava_podrijetlaLabel.Text = "Drzava podrijetla:";
            // 
            // drzava_podrijetlaTextBox
            // 
            this.drzava_podrijetlaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.random_DrzavaBindingSource, "Drzava_podrijetla", true));
            this.drzava_podrijetlaTextBox.Location = new System.Drawing.Point(15, 28);
            this.drzava_podrijetlaTextBox.Name = "drzava_podrijetlaTextBox";
            this.drzava_podrijetlaTextBox.Size = new System.Drawing.Size(116, 20);
            this.drzava_podrijetlaTextBox.TabIndex = 2;
            // 
            // random_DrzavaBindingSource
            // 
            this.random_DrzavaBindingSource.DataMember = "Random_Drzava";
            this.random_DrzavaBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // t07_DBDataSet
            // 
            this.t07_DBDataSet.DataSetName = "T07_DBDataSet";
            this.t07_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPonovno
            // 
            this.buttonPonovno.Location = new System.Drawing.Point(15, 122);
            this.buttonPonovno.Name = "buttonPonovno";
            this.buttonPonovno.Size = new System.Drawing.Size(116, 56);
            this.buttonPonovno.TabIndex = 9;
            this.buttonPonovno.Text = "Pokreni";
            this.buttonPonovno.UseVisualStyleBackColor = true;
            this.buttonPonovno.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KosaricaTableAdapter = null;
            this.tableAdapterManager.PivoTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.RouletteTableAdapter = null;
            this.tableAdapterManager.Stavke_kosaricaTableAdapter = null;
            this.tableAdapterManager.Stavke_racunTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PickBeer_User.T07_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // random_DrzavaTableAdapter
            // 
            this.random_DrzavaTableAdapter.ClearBeforeFill = true;
            // 
            // rouletteBindingSource
            // 
            this.rouletteBindingSource.DataMember = "Roulette";
            this.rouletteBindingSource.DataSource = this.t07_DBDataSet;
            // 
            // rouletteTableAdapter
            // 
            this.rouletteTableAdapter.ClearBeforeFill = true;
            // 
            // ime_pivaLabel
            // 
            ime_pivaLabel.AutoSize = true;
            ime_pivaLabel.Location = new System.Drawing.Point(275, 9);
            ime_pivaLabel.Name = "ime_pivaLabel";
            ime_pivaLabel.Size = new System.Drawing.Size(50, 13);
            ime_pivaLabel.TabIndex = 10;
            ime_pivaLabel.Text = "Ime piva:";
            // 
            // ime_pivaTextBox
            // 
            this.ime_pivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rouletteBindingSource, "Ime_piva", true));
            this.ime_pivaTextBox.Location = new System.Drawing.Point(278, 25);
            this.ime_pivaTextBox.Name = "ime_pivaTextBox";
            this.ime_pivaTextBox.Size = new System.Drawing.Size(140, 20);
            this.ime_pivaTextBox.TabIndex = 11;
            // 
            // pictureBoxRoulette
            // 
            this.pictureBoxRoulette.Location = new System.Drawing.Point(435, 9);
            this.pictureBoxRoulette.Name = "pictureBoxRoulette";
            this.pictureBoxRoulette.Size = new System.Drawing.Size(200, 300);
            this.pictureBoxRoulette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRoulette.TabIndex = 12;
            this.pictureBoxRoulette.TabStop = false;
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.Location = new System.Drawing.Point(275, 48);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 12;
            cijenaLabel.Text = "Cijena:";
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rouletteBindingSource, "Cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(278, 64);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(47, 20);
            this.cijenaTextBox.TabIndex = 13;
            // 
            // volumenLabel
            // 
            volumenLabel.AutoSize = true;
            volumenLabel.Location = new System.Drawing.Point(274, 87);
            volumenLabel.Name = "volumenLabel";
            volumenLabel.Size = new System.Drawing.Size(51, 13);
            volumenLabel.TabIndex = 13;
            volumenLabel.Text = "Volumen:";
            // 
            // volumenTextBox
            // 
            this.volumenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rouletteBindingSource, "Volumen", true));
            this.volumenTextBox.Location = new System.Drawing.Point(278, 103);
            this.volumenTextBox.Name = "volumenTextBox";
            this.volumenTextBox.Size = new System.Drawing.Size(47, 20);
            this.volumenTextBox.TabIndex = 14;
            // 
            // slikaLabel
            // 
            slikaLabel.AutoSize = true;
            slikaLabel.Location = new System.Drawing.Point(450, 241);
            slikaLabel.Name = "slikaLabel";
            slikaLabel.Size = new System.Drawing.Size(33, 13);
            slikaLabel.TabIndex = 14;
            slikaLabel.Text = "Slika:";
            // 
            // slikaTextBox
            // 
            this.slikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rouletteBindingSource, "Slika", true));
            this.slikaTextBox.Location = new System.Drawing.Point(489, 238);
            this.slikaTextBox.Name = "slikaTextBox";
            this.slikaTextBox.Size = new System.Drawing.Size(100, 20);
            this.slikaTextBox.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 326);
            this.Controls.Add(this.pictureBoxRoulette);
            this.Controls.Add(slikaLabel);
            this.Controls.Add(this.slikaTextBox);
            this.Controls.Add(volumenLabel);
            this.Controls.Add(this.volumenTextBox);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(ime_pivaLabel);
            this.Controls.Add(this.ime_pivaTextBox);
            this.Controls.Add(this.buttonPonovno);
            this.Controls.Add(drzava_podrijetlaLabel);
            this.Controls.Add(this.drzava_podrijetlaTextBox);
            this.Name = "FormRoulette";
            this.Text = "BeerRoulette";
            this.Load += new System.EventHandler(this.FormRoulette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.random_DrzavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t07_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rouletteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoulette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private T07_DBDataSet t07_DBDataSet;
        private System.Windows.Forms.BindingSource random_DrzavaBindingSource;
        private T07_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox drzava_podrijetlaTextBox;
        private System.Windows.Forms.Button buttonPonovno;
        private T07_DBDataSetTableAdapters.Random_DrzavaTableAdapter random_DrzavaTableAdapter;
        private System.Windows.Forms.BindingSource rouletteBindingSource;
        private T07_DBDataSetTableAdapters.RouletteTableAdapter rouletteTableAdapter;
        private System.Windows.Forms.TextBox ime_pivaTextBox;
        private System.Windows.Forms.PictureBox pictureBoxRoulette;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox volumenTextBox;
        private System.Windows.Forms.TextBox slikaTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}