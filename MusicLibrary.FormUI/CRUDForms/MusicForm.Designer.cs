
namespace MusicLibrary.FormUI.CRUDForms
{
    partial class MusicForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxCRUDOperations = new System.Windows.Forms.GroupBox();
            this.gbxSearchMusic = new System.Windows.Forms.GroupBox();
            this.btnDeleteMusic = new System.Windows.Forms.Button();
            this.btnUpdateMusic = new System.Windows.Forms.Button();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.cmbGenresMusic = new System.Windows.Forms.ComboBox();
            this.tbxNameMusic = new System.Windows.Forms.TextBox();
            this.lblGenreIdMusic = new System.Windows.Forms.Label();
            this.lblNameMusic = new System.Windows.Forms.Label();
            this.dgwMusics = new System.Windows.Forms.DataGridView();
            this.dgwGenres = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxGenres = new System.Windows.Forms.GroupBox();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.tbxNameGenre = new System.Windows.Forms.TextBox();
            this.lblNameGenre = new System.Windows.Forms.Label();
            this.gbxSearchGenre = new System.Windows.Forms.GroupBox();
            this.cmbMusicGenreId = new System.Windows.Forms.ComboBox();
            this.tbxMusicNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSearchParameters = new System.Windows.Forms.ComboBox();
            this.btnMusicSearch = new System.Windows.Forms.Button();
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.cmbSearchParametersGenre = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxCRUDOperations.SuspendLayout();
            this.gbxSearchMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenres)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxGenres.SuspendLayout();
            this.gbxSearchGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbxCRUDOperations, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgwMusics, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgwGenres, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1156, 889);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbxCRUDOperations
            // 
            this.gbxCRUDOperations.Controls.Add(this.gbxSearchMusic);
            this.gbxCRUDOperations.Controls.Add(this.btnDeleteMusic);
            this.gbxCRUDOperations.Controls.Add(this.btnUpdateMusic);
            this.gbxCRUDOperations.Controls.Add(this.btnAddMusic);
            this.gbxCRUDOperations.Controls.Add(this.cmbGenresMusic);
            this.gbxCRUDOperations.Controls.Add(this.tbxNameMusic);
            this.gbxCRUDOperations.Controls.Add(this.lblGenreIdMusic);
            this.gbxCRUDOperations.Controls.Add(this.lblNameMusic);
            this.gbxCRUDOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCRUDOperations.Location = new System.Drawing.Point(3, 447);
            this.gbxCRUDOperations.Name = "gbxCRUDOperations";
            this.gbxCRUDOperations.Size = new System.Drawing.Size(572, 439);
            this.gbxCRUDOperations.TabIndex = 2;
            this.gbxCRUDOperations.TabStop = false;
            this.gbxCRUDOperations.Text = "Musics";
            // 
            // gbxSearchMusic
            // 
            this.gbxSearchMusic.Controls.Add(this.btnMusicSearch);
            this.gbxSearchMusic.Controls.Add(this.cmbSearchParameters);
            this.gbxSearchMusic.Controls.Add(this.cmbMusicGenreId);
            this.gbxSearchMusic.Controls.Add(this.tbxMusicNameSearch);
            this.gbxSearchMusic.Controls.Add(this.label1);
            this.gbxSearchMusic.Controls.Add(this.label2);
            this.gbxSearchMusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxSearchMusic.Location = new System.Drawing.Point(3, 282);
            this.gbxSearchMusic.Name = "gbxSearchMusic";
            this.gbxSearchMusic.Size = new System.Drawing.Size(566, 154);
            this.gbxSearchMusic.TabIndex = 7;
            this.gbxSearchMusic.TabStop = false;
            this.gbxSearchMusic.Text = "Search";
            // 
            // btnDeleteMusic
            // 
            this.btnDeleteMusic.Location = new System.Drawing.Point(258, 194);
            this.btnDeleteMusic.Name = "btnDeleteMusic";
            this.btnDeleteMusic.Size = new System.Drawing.Size(90, 42);
            this.btnDeleteMusic.TabIndex = 6;
            this.btnDeleteMusic.Text = "Delete";
            this.btnDeleteMusic.UseVisualStyleBackColor = true;
            this.btnDeleteMusic.Click += new System.EventHandler(this.btnDeleteMusic_Click);
            // 
            // btnUpdateMusic
            // 
            this.btnUpdateMusic.Location = new System.Drawing.Point(144, 194);
            this.btnUpdateMusic.Name = "btnUpdateMusic";
            this.btnUpdateMusic.Size = new System.Drawing.Size(90, 42);
            this.btnUpdateMusic.TabIndex = 5;
            this.btnUpdateMusic.Text = "Update";
            this.btnUpdateMusic.UseVisualStyleBackColor = true;
            this.btnUpdateMusic.Click += new System.EventHandler(this.btnUpdateMusic_Click);
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Location = new System.Drawing.Point(30, 194);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(90, 42);
            this.btnAddMusic.TabIndex = 4;
            this.btnAddMusic.Text = "Add";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // cmbGenresMusic
            // 
            this.cmbGenresMusic.FormattingEnabled = true;
            this.cmbGenresMusic.Location = new System.Drawing.Point(117, 125);
            this.cmbGenresMusic.Name = "cmbGenresMusic";
            this.cmbGenresMusic.Size = new System.Drawing.Size(121, 24);
            this.cmbGenresMusic.TabIndex = 3;
            // 
            // tbxNameMusic
            // 
            this.tbxNameMusic.Location = new System.Drawing.Point(117, 70);
            this.tbxNameMusic.Name = "tbxNameMusic";
            this.tbxNameMusic.Size = new System.Drawing.Size(121, 22);
            this.tbxNameMusic.TabIndex = 2;
            // 
            // lblGenreIdMusic
            // 
            this.lblGenreIdMusic.AutoSize = true;
            this.lblGenreIdMusic.Location = new System.Drawing.Point(27, 128);
            this.lblGenreIdMusic.Name = "lblGenreIdMusic";
            this.lblGenreIdMusic.Size = new System.Drawing.Size(48, 17);
            this.lblGenreIdMusic.TabIndex = 1;
            this.lblGenreIdMusic.Text = "Genre";
            // 
            // lblNameMusic
            // 
            this.lblNameMusic.AutoSize = true;
            this.lblNameMusic.Location = new System.Drawing.Point(27, 73);
            this.lblNameMusic.Name = "lblNameMusic";
            this.lblNameMusic.Size = new System.Drawing.Size(45, 17);
            this.lblNameMusic.TabIndex = 0;
            this.lblNameMusic.Text = "Name";
            // 
            // dgwMusics
            // 
            this.dgwMusics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMusics.Location = new System.Drawing.Point(3, 3);
            this.dgwMusics.Name = "dgwMusics";
            this.dgwMusics.RowHeadersWidth = 51;
            this.dgwMusics.RowTemplate.Height = 24;
            this.dgwMusics.Size = new System.Drawing.Size(572, 438);
            this.dgwMusics.TabIndex = 0;
            this.dgwMusics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusics_CellClick);
            // 
            // dgwGenres
            // 
            this.dgwGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwGenres.Location = new System.Drawing.Point(581, 3);
            this.dgwGenres.Name = "dgwGenres";
            this.dgwGenres.RowHeadersWidth = 51;
            this.dgwGenres.RowTemplate.Height = 24;
            this.dgwGenres.Size = new System.Drawing.Size(572, 438);
            this.dgwGenres.TabIndex = 1;
            this.dgwGenres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGenres_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbxGenres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(581, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 439);
            this.panel1.TabIndex = 3;
            // 
            // gbxGenres
            // 
            this.gbxGenres.Controls.Add(this.gbxSearchGenre);
            this.gbxGenres.Controls.Add(this.btnDeleteGenre);
            this.gbxGenres.Controls.Add(this.btnUpdateGenre);
            this.gbxGenres.Controls.Add(this.btnAddGenre);
            this.gbxGenres.Controls.Add(this.tbxNameGenre);
            this.gbxGenres.Controls.Add(this.lblNameGenre);
            this.gbxGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxGenres.Location = new System.Drawing.Point(0, 0);
            this.gbxGenres.Name = "gbxGenres";
            this.gbxGenres.Size = new System.Drawing.Size(572, 439);
            this.gbxGenres.TabIndex = 2;
            this.gbxGenres.TabStop = false;
            this.gbxGenres.Text = "Genres";
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(258, 194);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(90, 42);
            this.btnDeleteGenre.TabIndex = 6;
            this.btnDeleteGenre.Text = "Delete";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Location = new System.Drawing.Point(144, 194);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(90, 42);
            this.btnUpdateGenre.TabIndex = 5;
            this.btnUpdateGenre.Text = "Update";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(30, 194);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(90, 42);
            this.btnAddGenre.TabIndex = 4;
            this.btnAddGenre.Text = "Add";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // tbxNameGenre
            // 
            this.tbxNameGenre.Location = new System.Drawing.Point(117, 72);
            this.tbxNameGenre.Name = "tbxNameGenre";
            this.tbxNameGenre.Size = new System.Drawing.Size(121, 22);
            this.tbxNameGenre.TabIndex = 2;
            // 
            // lblNameGenre
            // 
            this.lblNameGenre.AutoSize = true;
            this.lblNameGenre.Location = new System.Drawing.Point(27, 75);
            this.lblNameGenre.Name = "lblNameGenre";
            this.lblNameGenre.Size = new System.Drawing.Size(45, 17);
            this.lblNameGenre.TabIndex = 0;
            this.lblNameGenre.Text = "Name";
            // 
            // gbxSearchGenre
            // 
            this.gbxSearchGenre.Controls.Add(this.cmbSearchParametersGenre);
            this.gbxSearchGenre.Controls.Add(this.btnSearchGenre);
            this.gbxSearchGenre.Controls.Add(this.textBox1);
            this.gbxSearchGenre.Controls.Add(this.label3);
            this.gbxSearchGenre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxSearchGenre.Location = new System.Drawing.Point(3, 282);
            this.gbxSearchGenre.Name = "gbxSearchGenre";
            this.gbxSearchGenre.Size = new System.Drawing.Size(566, 154);
            this.gbxSearchGenre.TabIndex = 8;
            this.gbxSearchGenre.TabStop = false;
            this.gbxSearchGenre.Text = "Search";
            // 
            // cmbMusicGenreId
            // 
            this.cmbMusicGenreId.FormattingEnabled = true;
            this.cmbMusicGenreId.Location = new System.Drawing.Point(110, 94);
            this.cmbMusicGenreId.Name = "cmbMusicGenreId";
            this.cmbMusicGenreId.Size = new System.Drawing.Size(121, 24);
            this.cmbMusicGenreId.TabIndex = 7;
            // 
            // tbxMusicNameSearch
            // 
            this.tbxMusicNameSearch.Location = new System.Drawing.Point(110, 39);
            this.tbxMusicNameSearch.Name = "tbxMusicNameSearch";
            this.tbxMusicNameSearch.Size = new System.Drawing.Size(121, 22);
            this.tbxMusicNameSearch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // cmbSearchParameters
            // 
            this.cmbSearchParameters.FormattingEnabled = true;
            this.cmbSearchParameters.Items.AddRange(new object[] {
            "Contains",
            "Starts",
            "Ends"});
            this.cmbSearchParameters.Location = new System.Drawing.Point(309, 39);
            this.cmbSearchParameters.Name = "cmbSearchParameters";
            this.cmbSearchParameters.Size = new System.Drawing.Size(121, 24);
            this.cmbSearchParameters.TabIndex = 8;
            // 
            // btnMusicSearch
            // 
            this.btnMusicSearch.Location = new System.Drawing.Point(398, 97);
            this.btnMusicSearch.Name = "btnMusicSearch";
            this.btnMusicSearch.Size = new System.Drawing.Size(102, 40);
            this.btnMusicSearch.TabIndex = 9;
            this.btnMusicSearch.Text = "Search";
            this.btnMusicSearch.UseVisualStyleBackColor = true;
            this.btnMusicSearch.Click += new System.EventHandler(this.btnMusicSearch_Click);
            // 
            // btnSearchGenre
            // 
            this.btnSearchGenre.Location = new System.Drawing.Point(421, 97);
            this.btnSearchGenre.Name = "btnSearchGenre";
            this.btnSearchGenre.Size = new System.Drawing.Size(102, 40);
            this.btnSearchGenre.TabIndex = 10;
            this.btnSearchGenre.Text = "Search";
            this.btnSearchGenre.UseVisualStyleBackColor = true;
            this.btnSearchGenre.Click += new System.EventHandler(this.btnSearchGenre_Click);
            // 
            // cmbSearchParametersGenre
            // 
            this.cmbSearchParametersGenre.FormattingEnabled = true;
            this.cmbSearchParametersGenre.Items.AddRange(new object[] {
            "Contains",
            "Starts",
            "Ends"});
            this.cmbSearchParametersGenre.Location = new System.Drawing.Point(288, 37);
            this.cmbSearchParametersGenre.Name = "cmbSearchParametersGenre";
            this.cmbSearchParametersGenre.Size = new System.Drawing.Size(121, 24);
            this.cmbSearchParametersGenre.TabIndex = 11;
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 889);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MusicForm";
            this.Text = "Music";
            this.Load += new System.EventHandler(this.MusicForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxCRUDOperations.ResumeLayout(false);
            this.gbxCRUDOperations.PerformLayout();
            this.gbxSearchMusic.ResumeLayout(false);
            this.gbxSearchMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenres)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbxGenres.ResumeLayout(false);
            this.gbxGenres.PerformLayout();
            this.gbxSearchGenre.ResumeLayout(false);
            this.gbxSearchGenre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgwMusics;
        private System.Windows.Forms.DataGridView dgwGenres;
        private System.Windows.Forms.GroupBox gbxCRUDOperations;
        private System.Windows.Forms.Button btnDeleteMusic;
        private System.Windows.Forms.Button btnUpdateMusic;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.ComboBox cmbGenresMusic;
        private System.Windows.Forms.TextBox tbxNameMusic;
        private System.Windows.Forms.Label lblGenreIdMusic;
        private System.Windows.Forms.Label lblNameMusic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxGenres;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.TextBox tbxNameGenre;
        private System.Windows.Forms.Label lblNameGenre;
        private System.Windows.Forms.GroupBox gbxSearchMusic;
        private System.Windows.Forms.GroupBox gbxSearchGenre;
        private System.Windows.Forms.Button btnMusicSearch;
        private System.Windows.Forms.ComboBox cmbSearchParameters;
        private System.Windows.Forms.ComboBox cmbMusicGenreId;
        private System.Windows.Forms.TextBox tbxMusicNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSearchParametersGenre;
    }
}