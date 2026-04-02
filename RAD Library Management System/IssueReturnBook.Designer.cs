namespace RAD_Library_Management_System
{
    partial class IssueReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueReturnBook));
            dateReturn = new DateTimePicker();
            LblReturn = new Label();
            Btnreturn = new Button();
            Txtcontact = new TextBox();
            Lbcont = new Label();
            Lblstname = new Label();
            Txtname = new TextBox();
            comboBox1 = new ComboBox();
            TxtEnr = new TextBox();
            DateIssueB = new DateTimePicker();
            LblIssue = new Label();
            LblIsseud = new Label();
            Lblname = new Label();
            Lblenr = new Label();
            BtnIssue = new Button();
            BtnSearchI = new Button();
            PicIssue = new PictureBox();
            PicClose = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PicIssue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateReturn
            // 
            dateReturn.Font = new Font("Calibri", 10.8F);
            dateReturn.Location = new Point(523, 445);
            dateReturn.Name = "dateReturn";
            dateReturn.Size = new Size(309, 29);
            dateReturn.TabIndex = 65;
            // 
            // LblReturn
            // 
            LblReturn.AutoSize = true;
            LblReturn.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblReturn.Location = new Point(362, 450);
            LblReturn.Name = "LblReturn";
            LblReturn.Size = new Size(112, 24);
            LblReturn.TabIndex = 64;
            LblReturn.Text = "Return Date";
            // 
            // Btnreturn
            // 
            Btnreturn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnreturn.Location = new Point(916, 424);
            Btnreturn.Name = "Btnreturn";
            Btnreturn.Size = new Size(133, 37);
            Btnreturn.TabIndex = 63;
            Btnreturn.Text = "Return";
            Btnreturn.UseVisualStyleBackColor = true;
            // 
            // Txtcontact
            // 
            Txtcontact.Font = new Font("Calibri", 10.8F);
            Txtcontact.Location = new Point(523, 299);
            Txtcontact.Name = "Txtcontact";
            Txtcontact.Size = new Size(309, 29);
            Txtcontact.TabIndex = 62;
            // 
            // Lbcont
            // 
            Lbcont.AutoSize = true;
            Lbcont.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lbcont.Location = new Point(357, 304);
            Lbcont.Name = "Lbcont";
            Lbcont.Size = new Size(148, 24);
            Lbcont.TabIndex = 61;
            Lbcont.Text = "Contact Number";
            // 
            // Lblstname
            // 
            Lblstname.AutoSize = true;
            Lblstname.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblstname.Location = new Point(362, 234);
            Lblstname.Name = "Lblstname";
            Lblstname.Size = new Size(130, 24);
            Lblstname.TabIndex = 60;
            Lblstname.Text = "Student Name";
            // 
            // Txtname
            // 
            Txtname.Font = new Font("Calibri", 10.8F);
            Txtname.Location = new Point(523, 234);
            Txtname.Name = "Txtname";
            Txtname.Size = new Size(139, 29);
            Txtname.TabIndex = 59;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(523, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 28);
            comboBox1.TabIndex = 58;
            // 
            // TxtEnr
            // 
            TxtEnr.Font = new Font("Calibri", 10.8F);
            TxtEnr.Location = new Point(34, 464);
            TxtEnr.Name = "TxtEnr";
            TxtEnr.Size = new Size(252, 29);
            TxtEnr.TabIndex = 57;
            // 
            // DateIssueB
            // 
            DateIssueB.Font = new Font("Calibri", 10.8F);
            DateIssueB.Location = new Point(523, 375);
            DateIssueB.Name = "DateIssueB";
            DateIssueB.Size = new Size(309, 29);
            DateIssueB.TabIndex = 56;
            // 
            // LblIssue
            // 
            LblIssue.AutoSize = true;
            LblIssue.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIssue.ForeColor = Color.AliceBlue;
            LblIssue.Location = new Point(406, 55);
            LblIssue.Name = "LblIssue";
            LblIssue.Size = new Size(256, 47);
            LblIssue.TabIndex = 55;
            LblIssue.Text = "ISSUE BOOK";
            // 
            // LblIsseud
            // 
            LblIsseud.AutoSize = true;
            LblIsseud.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblIsseud.Location = new Point(362, 380);
            LblIsseud.Name = "LblIsseud";
            LblIsseud.Size = new Size(97, 24);
            LblIsseud.TabIndex = 54;
            LblIsseud.Text = "Issue Date";
            // 
            // Lblname
            // 
            Lblname.AutoSize = true;
            Lblname.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblname.Location = new Point(362, 165);
            Lblname.Name = "Lblname";
            Lblname.Size = new Size(107, 24);
            Lblname.TabIndex = 53;
            Lblname.Text = "Book Name";
            // 
            // Lblenr
            // 
            Lblenr.AutoSize = true;
            Lblenr.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblenr.Location = new Point(34, 437);
            Lblenr.Name = "Lblenr";
            Lblenr.Size = new Size(138, 24);
            Lblenr.TabIndex = 52;
            Lblenr.Text = "Enter Enroll No";
            // 
            // BtnIssue
            // 
            BtnIssue.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIssue.Location = new Point(916, 367);
            BtnIssue.Name = "BtnIssue";
            BtnIssue.Size = new Size(133, 37);
            BtnIssue.TabIndex = 51;
            BtnIssue.Text = "Issue";
            BtnIssue.UseVisualStyleBackColor = true;
            BtnIssue.Click += BtnIssue_Click;
            // 
            // BtnSearchI
            // 
            BtnSearchI.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            BtnSearchI.Location = new Point(72, 499);
            BtnSearchI.Name = "BtnSearchI";
            BtnSearchI.Size = new Size(184, 54);
            BtnSearchI.TabIndex = 50;
            BtnSearchI.Text = "Search";
            BtnSearchI.UseVisualStyleBackColor = true;
            BtnSearchI.Click += BtnSearchI_Click;
            // 
            // PicIssue
            // 
            PicIssue.Image = (Image)resources.GetObject("PicIssue.Image");
            PicIssue.Location = new Point(34, 76);
            PicIssue.Name = "PicIssue";
            PicIssue.Size = new Size(301, 328);
            PicIssue.SizeMode = PictureBoxSizeMode.StretchImage;
            PicIssue.TabIndex = 49;
            PicIssue.TabStop = false;
            // 
            // PicClose
            // 
            PicClose.BackColor = Color.Transparent;
            PicClose.Location = new Point(1025, 13);
            PicClose.Margin = new Padding(4);
            PicClose.Name = "PicClose";
            PicClose.Size = new Size(38, 36);
            PicClose.SizeMode = PictureBoxSizeMode.Zoom;
            PicClose.TabIndex = 48;
            PicClose.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(979, 13);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 10.8F);
            textBox1.Location = new Point(693, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 29);
            textBox1.TabIndex = 67;
            // 
            // IssueReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1076, 609);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dateReturn);
            Controls.Add(LblReturn);
            Controls.Add(Btnreturn);
            Controls.Add(Txtcontact);
            Controls.Add(Lbcont);
            Controls.Add(Lblstname);
            Controls.Add(Txtname);
            Controls.Add(comboBox1);
            Controls.Add(TxtEnr);
            Controls.Add(DateIssueB);
            Controls.Add(LblIssue);
            Controls.Add(LblIsseud);
            Controls.Add(Lblname);
            Controls.Add(Lblenr);
            Controls.Add(BtnIssue);
            Controls.Add(BtnSearchI);
            Controls.Add(PicIssue);
            Controls.Add(PicClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IssueReturnBook";
            Text = "IssueReturnBook";
            ((System.ComponentModel.ISupportInitialize)PicIssue).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateReturn;
        private Label LblReturn;
        private Button Btnreturn;
        private TextBox Txtcontact;
        private Label Lbcont;
        private Label Lblstname;
        private TextBox Txtname;
        private ComboBox comboBox1;
        private TextBox TxtEnr;
        private DateTimePicker DateIssueB;
        private Label LblIssue;
        private Label LblIsseud;
        private Label Lblname;
        private Label Lblenr;
        private Button BtnIssue;
        private Button BtnSearchI;
        private PictureBox PicIssue;
        private PictureBox PicClose;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}