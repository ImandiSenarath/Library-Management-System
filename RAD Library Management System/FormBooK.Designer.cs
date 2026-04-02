namespace RAD_Library_Management_System
{
    partial class FormBooK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooK));
            TxtNam = new TextBox();
            PanelEdit = new Panel();
            Txtcono = new TextBox();
            Lblnoof = new Label();
            Btnupdt = new Button();
            Btndel = new Button();
            TxtTitle = new TextBox();
            TxtIsbn = new TextBox();
            TxtPublisher = new TextBox();
            TxtGenre = new TextBox();
            TxtPerMission = new TextBox();
            TxtNocopiew = new TextBox();
            TxtShwlf = new TextBox();
            TxtAuthor = new TextBox();
            label1 = new Label();
            Lblshelf = new Label();
            Lblgenre = new Label();
            Lblpermission = new Label();
            Lbltittle = new Label();
            Lblpubshisher = new Label();
            Lblauthor = new Label();
            LblISBN = new Label();
            GridBook = new DataGridView();
            Lblname = new Label();
            pictureBox1 = new PictureBox();
            BtnRef = new Button();
            CLoseN = new PictureBox();
            MinimizeN = new PictureBox();
            BackN = new PictureBox();
            BtnSearch = new Button();
            PanelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CLoseN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackN).BeginInit();
            SuspendLayout();
            // 
            // TxtNam
            // 
            TxtNam.Location = new Point(312, 181);
            TxtNam.Name = "TxtNam";
            TxtNam.Size = new Size(273, 27);
            TxtNam.TabIndex = 2;
            TxtNam.TextChanged += TxtNam_TextChanged;
            // 
            // PanelEdit
            // 
            PanelEdit.BackColor = SystemColors.ControlDarkDark;
            PanelEdit.Controls.Add(Txtcono);
            PanelEdit.Controls.Add(Lblnoof);
            PanelEdit.Controls.Add(Btnupdt);
            PanelEdit.Controls.Add(Btndel);
            PanelEdit.Controls.Add(TxtTitle);
            PanelEdit.Controls.Add(TxtIsbn);
            PanelEdit.Controls.Add(TxtPublisher);
            PanelEdit.Controls.Add(TxtGenre);
            PanelEdit.Controls.Add(TxtPerMission);
            PanelEdit.Controls.Add(TxtNocopiew);
            PanelEdit.Controls.Add(TxtShwlf);
            PanelEdit.Controls.Add(TxtAuthor);
            PanelEdit.Controls.Add(label1);
            PanelEdit.Controls.Add(Lblshelf);
            PanelEdit.Controls.Add(Lblgenre);
            PanelEdit.Controls.Add(Lblpermission);
            PanelEdit.Controls.Add(Lbltittle);
            PanelEdit.Controls.Add(Lblpubshisher);
            PanelEdit.Controls.Add(Lblauthor);
            PanelEdit.Controls.Add(LblISBN);
            PanelEdit.Location = new Point(30, 472);
            PanelEdit.Name = "PanelEdit";
            PanelEdit.Size = new Size(1046, 269);
            PanelEdit.TabIndex = 3;
            // 
            // Txtcono
            // 
            Txtcono.Location = new Point(569, 208);
            Txtcono.Name = "Txtcono";
            Txtcono.Size = new Size(151, 27);
            Txtcono.TabIndex = 198;
            // 
            // Lblnoof
            // 
            Lblnoof.AutoSize = true;
            Lblnoof.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblnoof.Location = new Point(426, 211);
            Lblnoof.Margin = new Padding(4, 0, 4, 0);
            Lblnoof.Name = "Lblnoof";
            Lblnoof.Size = new Size(77, 24);
            Lblnoof.TabIndex = 197;
            Lblnoof.Text = "Copies :";
            // 
            // Btnupdt
            // 
            Btnupdt.BackColor = Color.Gray;
            Btnupdt.BackgroundImageLayout = ImageLayout.None;
            Btnupdt.FlatStyle = FlatStyle.Popup;
            Btnupdt.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Btnupdt.Location = new Point(785, 49);
            Btnupdt.Margin = new Padding(4);
            Btnupdt.Name = "Btnupdt";
            Btnupdt.Size = new Size(142, 35);
            Btnupdt.TabIndex = 158;
            Btnupdt.Text = "Update";
            Btnupdt.UseVisualStyleBackColor = false;
            Btnupdt.Click += Btnupdt_Click;
            // 
            // Btndel
            // 
            Btndel.BackColor = Color.Gray;
            Btndel.BackgroundImageLayout = ImageLayout.None;
            Btndel.FlatStyle = FlatStyle.Popup;
            Btndel.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Btndel.Location = new Point(785, 120);
            Btndel.Margin = new Padding(4);
            Btndel.Name = "Btndel";
            Btndel.Size = new Size(142, 35);
            Btndel.TabIndex = 157;
            Btndel.Text = "Delete";
            Btndel.UseVisualStyleBackColor = false;
            Btndel.Click += Btndel_Click;
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(182, 146);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(151, 27);
            TxtTitle.TabIndex = 196;
            // 
            // TxtIsbn
            // 
            TxtIsbn.Location = new Point(182, 20);
            TxtIsbn.Name = "TxtIsbn";
            TxtIsbn.Size = new Size(151, 27);
            TxtIsbn.TabIndex = 195;
            // 
            // TxtPublisher
            // 
            TxtPublisher.Location = new Point(182, 212);
            TxtPublisher.Name = "TxtPublisher";
            TxtPublisher.Size = new Size(151, 27);
            TxtPublisher.TabIndex = 194;
            // 
            // TxtGenre
            // 
            TxtGenre.Location = new Point(569, 23);
            TxtGenre.Name = "TxtGenre";
            TxtGenre.Size = new Size(151, 27);
            TxtGenre.TabIndex = 193;
            // 
            // TxtPerMission
            // 
            TxtPerMission.Location = new Point(569, 83);
            TxtPerMission.Name = "TxtPerMission";
            TxtPerMission.Size = new Size(151, 27);
            TxtPerMission.TabIndex = 192;
            // 
            // TxtNocopiew
            // 
            TxtNocopiew.Location = new Point(519, 341);
            TxtNocopiew.Name = "TxtNocopiew";
            TxtNocopiew.Size = new Size(151, 27);
            TxtNocopiew.TabIndex = 191;
            // 
            // TxtShwlf
            // 
            TxtShwlf.Location = new Point(569, 148);
            TxtShwlf.Name = "TxtShwlf";
            TxtShwlf.Size = new Size(151, 27);
            TxtShwlf.TabIndex = 190;
            // 
            // TxtAuthor
            // 
            TxtAuthor.Location = new Point(182, 78);
            TxtAuthor.Name = "TxtAuthor";
            TxtAuthor.Size = new Size(151, 27);
            TxtAuthor.TabIndex = 189;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(377, 344);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 24);
            label1.TabIndex = 188;
            label1.Text = "No of copies :";
            // 
            // Lblshelf
            // 
            Lblshelf.AutoSize = true;
            Lblshelf.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblshelf.Location = new Point(426, 151);
            Lblshelf.Margin = new Padding(4, 0, 4, 0);
            Lblshelf.Name = "Lblshelf";
            Lblshelf.Size = new Size(62, 24);
            Lblshelf.TabIndex = 187;
            Lblshelf.Text = "Shelf :";
            // 
            // Lblgenre
            // 
            Lblgenre.AutoSize = true;
            Lblgenre.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblgenre.Location = new Point(426, 26);
            Lblgenre.Margin = new Padding(4, 0, 4, 0);
            Lblgenre.Name = "Lblgenre";
            Lblgenre.Size = new Size(72, 24);
            Lblgenre.TabIndex = 186;
            Lblgenre.Text = "Genre :";
            // 
            // Lblpermission
            // 
            Lblpermission.AutoSize = true;
            Lblpermission.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblpermission.Location = new Point(426, 86);
            Lblpermission.Margin = new Padding(4, 0, 4, 0);
            Lblpermission.Name = "Lblpermission";
            Lblpermission.Size = new Size(113, 24);
            Lblpermission.TabIndex = 185;
            Lblpermission.Text = "Permission :";
            // 
            // Lbltittle
            // 
            Lbltittle.AutoSize = true;
            Lbltittle.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lbltittle.Location = new Point(39, 146);
            Lbltittle.Margin = new Padding(4, 0, 4, 0);
            Lbltittle.Name = "Lbltittle";
            Lbltittle.Size = new Size(64, 24);
            Lbltittle.TabIndex = 184;
            Lbltittle.Text = "Tittle :";
            // 
            // Lblpubshisher
            // 
            Lblpubshisher.AutoSize = true;
            Lblpubshisher.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblpubshisher.Location = new Point(39, 211);
            Lblpubshisher.Margin = new Padding(4, 0, 4, 0);
            Lblpubshisher.Name = "Lblpubshisher";
            Lblpubshisher.Size = new Size(100, 24);
            Lblpubshisher.TabIndex = 183;
            Lblpubshisher.Text = "Publisher :";
            // 
            // Lblauthor
            // 
            Lblauthor.AutoSize = true;
            Lblauthor.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblauthor.Location = new Point(39, 81);
            Lblauthor.Margin = new Padding(4, 0, 4, 0);
            Lblauthor.Name = "Lblauthor";
            Lblauthor.Size = new Size(80, 24);
            Lblauthor.TabIndex = 182;
            Lblauthor.Text = "Author :";
            // 
            // LblISBN
            // 
            LblISBN.AutoSize = true;
            LblISBN.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblISBN.Location = new Point(39, 23);
            LblISBN.Margin = new Padding(4, 0, 4, 0);
            LblISBN.Name = "LblISBN";
            LblISBN.Size = new Size(59, 24);
            LblISBN.TabIndex = 181;
            LblISBN.Text = "ISBN :";
            // 
            // GridBook
            // 
            GridBook.BackgroundColor = SystemColors.Control;
            GridBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBook.Location = new Point(30, 214);
            GridBook.Name = "GridBook";
            GridBook.RowHeadersWidth = 51;
            GridBook.Size = new Size(1046, 231);
            GridBook.TabIndex = 0;
            GridBook.CellContentClick += GridBook_CellContentClick;
            // 
            // Lblname
            // 
            Lblname.AutoSize = true;
            Lblname.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblname.Location = new Point(145, 181);
            Lblname.Name = "Lblname";
            Lblname.Size = new Size(107, 24);
            Lblname.TabIndex = 18;
            Lblname.Text = "Book Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(465, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // BtnRef
            // 
            BtnRef.Font = new Font("Calibri", 12F, FontStyle.Bold);
            BtnRef.Location = new Point(860, 175);
            BtnRef.Name = "BtnRef";
            BtnRef.Size = new Size(135, 33);
            BtnRef.TabIndex = 20;
            BtnRef.Text = "Refresh";
            BtnRef.UseVisualStyleBackColor = true;
            BtnRef.Click += BtnRef_Click;
            // 
            // CLoseN
            // 
            CLoseN.Image = Properties.Resources.classe;
            CLoseN.Location = new Point(1096, 14);
            CLoseN.Margin = new Padding(5);
            CLoseN.Name = "CLoseN";
            CLoseN.Size = new Size(31, 33);
            CLoseN.SizeMode = PictureBoxSizeMode.StretchImage;
            CLoseN.TabIndex = 156;
            CLoseN.TabStop = false;
            CLoseN.Click += CLoseN_Click;
            // 
            // MinimizeN
            // 
            MinimizeN.Image = Properties.Resources.min;
            MinimizeN.Location = new Point(1055, 14);
            MinimizeN.Margin = new Padding(5);
            MinimizeN.Name = "MinimizeN";
            MinimizeN.Size = new Size(31, 33);
            MinimizeN.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeN.TabIndex = 157;
            MinimizeN.TabStop = false;
            MinimizeN.Click += MinimizeN_Click;
            // 
            // BackN
            // 
            BackN.BackColor = Color.Transparent;
            BackN.Image = Properties.Resources.Back;
            BackN.Location = new Point(30, 19);
            BackN.Name = "BackN";
            BackN.Size = new Size(31, 28);
            BackN.SizeMode = PictureBoxSizeMode.StretchImage;
            BackN.TabIndex = 167;
            BackN.TabStop = false;
            BackN.Click += BackN_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.Font = new Font("Calibri", 12F, FontStyle.Bold);
            BtnSearch.Location = new Point(641, 175);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(135, 33);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // FormBooK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1139, 764);
            Controls.Add(BackN);
            Controls.Add(MinimizeN);
            Controls.Add(CLoseN);
            Controls.Add(BtnRef);
            Controls.Add(pictureBox1);
            Controls.Add(Lblname);
            Controls.Add(BtnSearch);
            Controls.Add(PanelEdit);
            Controls.Add(TxtNam);
            Controls.Add(GridBook);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBooK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBooK";
            Load += FormBooK_Load;
            PanelEdit.ResumeLayout(false);
            PanelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CLoseN).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeN).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtNam;
        private Panel PanelEdit;
        private DataGridView GridBook;
        private Label Lblname;
        private TextBox TxtTitle;
        private TextBox TxtIsbn;
        private TextBox TxtPublisher;
        private TextBox TxtGenre;
        private TextBox TxtPerMission;
        private TextBox TxtNocopiew;
        private TextBox TxtShwlf;
        private TextBox TxtAuthor;
        private Label label1;
        private Label Lblshelf;
        private Label Lblgenre;
        private Label Lblpermission;
        private Label Lbltittle;
        private Label Lblpubshisher;
        private Label Lblauthor;
        private Label LblISBN;
        private Button Btnupdt;
        private Button Btndel;
        private PictureBox pictureBox1;
        private Button BtnRef;
        private PictureBox CLoseN;
        private PictureBox MinimizeN;
        private PictureBox BackN;
        private TextBox Txtcono;
        private Label Lblnoof;
        private Button BtnSearch;
    }
}