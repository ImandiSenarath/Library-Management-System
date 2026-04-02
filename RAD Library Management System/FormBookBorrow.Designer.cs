namespace RAD_Library_Management_System
{
    partial class FrmIssueReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIssueReturn));
            pictureBox1 = new PictureBox();
            Lblmsgi = new Label();
            BackV = new PictureBox();
            MinimizeV = new PictureBox();
            CLoseV = new PictureBox();
            Cisbn = new ComboBox();
            Lblfirn = new Label();
            Return = new Label();
            Deu = new Label();
            LBliss = new Label();
            LblISBNI = new Label();
            BtnIssue = new Button();
            Btnret = new Button();
            BTn = new Button();
            TxtFine = new TextBox();
            DateIssue = new DateTimePicker();
            DateRet = new DateTimePicker();
            DateDue = new DateTimePicker();
            LblCampus = new Label();
            TxtID = new TextBox();
            Txtis = new TextBox();
            LblIssueID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CLoseV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 197;
            pictureBox1.TabStop = false;
            // 
            // Lblmsgi
            // 
            Lblmsgi.AutoSize = true;
            Lblmsgi.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblmsgi.Location = new Point(586, 55);
            Lblmsgi.Margin = new Padding(4, 0, 4, 0);
            Lblmsgi.Name = "Lblmsgi";
            Lblmsgi.Size = new Size(0, 24);
            Lblmsgi.TabIndex = 196;
            // 
            // BackV
            // 
            BackV.BackColor = Color.Transparent;
            BackV.Image = Properties.Resources.Back;
            BackV.Location = new Point(22, 18);
            BackV.Name = "BackV";
            BackV.Size = new Size(31, 28);
            BackV.SizeMode = PictureBoxSizeMode.StretchImage;
            BackV.TabIndex = 193;
            BackV.TabStop = false;
            // 
            // MinimizeV
            // 
            MinimizeV.Image = Properties.Resources.min;
            MinimizeV.Location = new Point(579, 18);
            MinimizeV.Margin = new Padding(5);
            MinimizeV.Name = "MinimizeV";
            MinimizeV.Size = new Size(31, 33);
            MinimizeV.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeV.TabIndex = 192;
            MinimizeV.TabStop = false;
            MinimizeV.Click += MinimizeV_Click;
            // 
            // CLoseV
            // 
            CLoseV.Image = Properties.Resources.classe;
            CLoseV.Location = new Point(620, 18);
            CLoseV.Margin = new Padding(5);
            CLoseV.Name = "CLoseV";
            CLoseV.Size = new Size(31, 33);
            CLoseV.SizeMode = PictureBoxSizeMode.StretchImage;
            CLoseV.TabIndex = 191;
            CLoseV.TabStop = false;
            CLoseV.Click += CLoseV_Click;
            // 
            // Cisbn
            // 
            Cisbn.FormattingEnabled = true;
            Cisbn.Location = new Point(197, 319);
            Cisbn.Name = "Cisbn";
            Cisbn.Size = new Size(177, 28);
            Cisbn.TabIndex = 183;
            // 
            // Lblfirn
            // 
            Lblfirn.AutoSize = true;
            Lblfirn.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblfirn.Location = new Point(47, 660);
            Lblfirn.Margin = new Padding(4, 0, 4, 0);
            Lblfirn.Name = "Lblfirn";
            Lblfirn.Size = new Size(45, 24);
            Lblfirn.TabIndex = 178;
            Lblfirn.Text = "Fine";
            // 
            // Return
            // 
            Return.AutoSize = true;
            Return.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Return.Location = new Point(47, 528);
            Return.Margin = new Padding(4, 0, 4, 0);
            Return.Name = "Return";
            Return.Size = new Size(112, 24);
            Return.TabIndex = 176;
            Return.Text = "Return Date";
            // 
            // Deu
            // 
            Deu.AutoSize = true;
            Deu.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Deu.Location = new Point(47, 594);
            Deu.Margin = new Padding(4, 0, 4, 0);
            Deu.Name = "Deu";
            Deu.Size = new Size(87, 24);
            Deu.TabIndex = 175;
            Deu.Text = "Due date";
            // 
            // LBliss
            // 
            LBliss.AutoSize = true;
            LBliss.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LBliss.Location = new Point(47, 460);
            LBliss.Margin = new Padding(4, 0, 4, 0);
            LBliss.Name = "LBliss";
            LBliss.Size = new Size(108, 24);
            LBliss.TabIndex = 174;
            LBliss.Text = "Issue Date :";
            // 
            // LblISBNI
            // 
            LblISBNI.AutoSize = true;
            LblISBNI.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblISBNI.Location = new Point(47, 323);
            LblISBNI.Margin = new Padding(4, 0, 4, 0);
            LblISBNI.Name = "LblISBNI";
            LblISBNI.Size = new Size(59, 24);
            LblISBNI.TabIndex = 173;
            LblISBNI.Text = "ISBN :";
            // 
            // BtnIssue
            // 
            BtnIssue.BackColor = Color.Gray;
            BtnIssue.BackgroundImageLayout = ImageLayout.None;
            BtnIssue.FlatStyle = FlatStyle.Popup;
            BtnIssue.Font = new Font("Calibri", 12F, FontStyle.Bold);
            BtnIssue.Location = new Point(470, 271);
            BtnIssue.Margin = new Padding(4);
            BtnIssue.Name = "BtnIssue";
            BtnIssue.Size = new Size(163, 56);
            BtnIssue.TabIndex = 172;
            BtnIssue.Text = "Issue";
            BtnIssue.UseVisualStyleBackColor = false;
            BtnIssue.Click += BtnIssue_Click_1;
            // 
            // Btnret
            // 
            Btnret.BackColor = Color.Gray;
            Btnret.BackgroundImageLayout = ImageLayout.None;
            Btnret.FlatStyle = FlatStyle.Popup;
            Btnret.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Btnret.Location = new Point(470, 408);
            Btnret.Margin = new Padding(4);
            Btnret.Name = "Btnret";
            Btnret.Size = new Size(163, 56);
            Btnret.TabIndex = 190;
            Btnret.Text = "Return";
            Btnret.UseVisualStyleBackColor = false;
            Btnret.Click += Btnret_Click;
            // 
            // BTn
            // 
            BTn.BackColor = Color.Gray;
            BTn.BackgroundImageLayout = ImageLayout.None;
            BTn.FlatStyle = FlatStyle.Popup;
            BTn.Font = new Font("Calibri", 12F, FontStyle.Bold);
            BTn.Location = new Point(470, 528);
            BTn.Margin = new Padding(4);
            BTn.Name = "BTn";
            BTn.Size = new Size(163, 56);
            BTn.TabIndex = 198;
            BTn.Text = "View";
            BTn.UseVisualStyleBackColor = false;
            // 
            // TxtFine
            // 
            TxtFine.Location = new Point(197, 657);
            TxtFine.Name = "TxtFine";
            TxtFine.Size = new Size(177, 27);
            TxtFine.TabIndex = 200;
            // 
            // DateIssue
            // 
            DateIssue.Location = new Point(197, 457);
            DateIssue.Name = "DateIssue";
            DateIssue.Size = new Size(177, 27);
            DateIssue.TabIndex = 201;
            DateIssue.Value = new DateTime(2024, 5, 19, 0, 0, 0, 0);
            // 
            // DateRet
            // 
            DateRet.Location = new Point(197, 526);
            DateRet.Name = "DateRet";
            DateRet.Size = new Size(177, 27);
            DateRet.TabIndex = 205;
            // 
            // DateDue
            // 
            DateDue.Location = new Point(197, 594);
            DateDue.MaxDate = new DateTime(2900, 12, 31, 0, 0, 0, 0);
            DateDue.MinDate = new DateTime(2001, 1, 1, 0, 0, 0, 0);
            DateDue.Name = "DateDue";
            DateDue.Size = new Size(177, 27);
            DateDue.TabIndex = 206;
            // 
            // LblCampus
            // 
            LblCampus.AutoSize = true;
            LblCampus.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblCampus.Location = new Point(47, 385);
            LblCampus.Margin = new Padding(4, 0, 4, 0);
            LblCampus.Name = "LblCampus";
            LblCampus.Size = new Size(111, 24);
            LblCampus.TabIndex = 207;
            LblCampus.Text = "Campus ID :";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(197, 382);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(177, 27);
            TxtID.TabIndex = 208;
            // 
            // Txtis
            // 
            Txtis.Location = new Point(197, 246);
            Txtis.Name = "Txtis";
            Txtis.Size = new Size(177, 27);
            Txtis.TabIndex = 210;
            // 
            // LblIssueID
            // 
            LblIssueID.AutoSize = true;
            LblIssueID.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblIssueID.Location = new Point(47, 249);
            LblIssueID.Margin = new Padding(4, 0, 4, 0);
            LblIssueID.Name = "LblIssueID";
            LblIssueID.Size = new Size(86, 24);
            LblIssueID.TabIndex = 209;
            LblIssueID.Text = "Issue ID :";
            // 
            // FrmIssueReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(671, 738);
            Controls.Add(Txtis);
            Controls.Add(LblIssueID);
            Controls.Add(TxtID);
            Controls.Add(LblCampus);
            Controls.Add(DateDue);
            Controls.Add(DateRet);
            Controls.Add(DateIssue);
            Controls.Add(TxtFine);
            Controls.Add(BTn);
            Controls.Add(pictureBox1);
            Controls.Add(Lblmsgi);
            Controls.Add(BackV);
            Controls.Add(MinimizeV);
            Controls.Add(CLoseV);
            Controls.Add(Btnret);
            Controls.Add(Cisbn);
            Controls.Add(Lblfirn);
            Controls.Add(Return);
            Controls.Add(Deu);
            Controls.Add(LBliss);
            Controls.Add(LblISBNI);
            Controls.Add(BtnIssue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmIssueReturn";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackV).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeV).EndInit();
            ((System.ComponentModel.ISupportInitialize)CLoseV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Lblmsgi;
        private PictureBox BackV;
        private PictureBox MinimizeV;
        private PictureBox CLoseV;
        private ComboBox Cisbn;
        private Label Lblfirn;
        private Label Return;
        private Label Deu;
        private Label LBliss;
        private Label LblISBNI;
        private Button BtnIssue;
        private Button Btnret;
        private Button BTn;
        private TextBox TxtIssue;
        private TextBox TxtFine;
        private DateTimePicker DateIssue;
        private DateTimePicker DateRet;
        private DateTimePicker DateDue;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label LblCampus;
        private TextBox TxtID;
        private TextBox Txtis;
        private Label LblIssueID;
    }
}