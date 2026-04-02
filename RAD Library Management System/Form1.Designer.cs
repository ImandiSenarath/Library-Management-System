namespace RAD_Library_Management_System
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
            Txtis = new TextBox();
            LblIssueID = new Label();
            TxtID = new TextBox();
            LblCampus = new Label();
            DateRet = new DateTimePicker();
            DateIssue = new DateTimePicker();
            Cisbn = new ComboBox();
            Return = new Label();
            LBliss = new Label();
            LblISBNI = new Label();
            Lblmsgi = new Label();
            MinimizeV = new PictureBox();
            CLoseV = new PictureBox();
            BtnIssue = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)MinimizeV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CLoseV).BeginInit();
            SuspendLayout();
            // 
            // Txtis
            // 
            Txtis.Location = new Point(219, 214);
            Txtis.Name = "Txtis";
            Txtis.Size = new Size(177, 27);
            Txtis.TabIndex = 220;
            // 
            // LblIssueID
            // 
            LblIssueID.AutoSize = true;
            LblIssueID.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblIssueID.Location = new Point(69, 217);
            LblIssueID.Margin = new Padding(4, 0, 4, 0);
            LblIssueID.Name = "LblIssueID";
            LblIssueID.Size = new Size(86, 24);
            LblIssueID.TabIndex = 219;
            LblIssueID.Text = "Issue ID :";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(219, 338);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(177, 27);
            TxtID.TabIndex = 218;
            // 
            // LblCampus
            // 
            LblCampus.AutoSize = true;
            LblCampus.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblCampus.Location = new Point(69, 341);
            LblCampus.Margin = new Padding(4, 0, 4, 0);
            LblCampus.Name = "LblCampus";
            LblCampus.Size = new Size(111, 24);
            LblCampus.TabIndex = 217;
            LblCampus.Text = "Campus ID :";
            // 
            // DateRet
            // 
            DateRet.Location = new Point(219, 482);
            DateRet.Name = "DateRet";
            DateRet.Size = new Size(177, 27);
            DateRet.TabIndex = 216;
            // 
            // DateIssue
            // 
            DateIssue.Location = new Point(219, 413);
            DateIssue.Name = "DateIssue";
            DateIssue.Size = new Size(177, 27);
            DateIssue.TabIndex = 215;
            DateIssue.Value = new DateTime(2024, 5, 19, 0, 0, 0, 0);
            // 
            // Cisbn
            // 
            Cisbn.FormattingEnabled = true;
            Cisbn.Location = new Point(219, 275);
            Cisbn.Name = "Cisbn";
            Cisbn.Size = new Size(177, 28);
            Cisbn.TabIndex = 214;
            // 
            // Return
            // 
            Return.AutoSize = true;
            Return.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Return.Location = new Point(69, 484);
            Return.Margin = new Padding(4, 0, 4, 0);
            Return.Name = "Return";
            Return.Size = new Size(112, 24);
            Return.TabIndex = 213;
            Return.Text = "Return Date";
            // 
            // LBliss
            // 
            LBliss.AutoSize = true;
            LBliss.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LBliss.Location = new Point(69, 416);
            LBliss.Margin = new Padding(4, 0, 4, 0);
            LBliss.Name = "LBliss";
            LBliss.Size = new Size(108, 24);
            LBliss.TabIndex = 212;
            LBliss.Text = "Issue Date :";
            // 
            // LblISBNI
            // 
            LblISBNI.AutoSize = true;
            LblISBNI.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblISBNI.Location = new Point(69, 279);
            LblISBNI.Margin = new Padding(4, 0, 4, 0);
            LblISBNI.Name = "LblISBNI";
            LblISBNI.Size = new Size(59, 24);
            LblISBNI.TabIndex = 211;
            LblISBNI.Text = "ISBN :";
            // 
            // Lblmsgi
            // 
            Lblmsgi.AutoSize = true;
            Lblmsgi.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblmsgi.Location = new Point(585, 51);
            Lblmsgi.Margin = new Padding(4, 0, 4, 0);
            Lblmsgi.Name = "Lblmsgi";
            Lblmsgi.Size = new Size(0, 24);
            Lblmsgi.TabIndex = 223;
            // 
            // MinimizeV
            // 
            MinimizeV.Image = Properties.Resources.min;
            MinimizeV.Location = new Point(955, 14);
            MinimizeV.Margin = new Padding(5);
            MinimizeV.Name = "MinimizeV";
            MinimizeV.Size = new Size(31, 33);
            MinimizeV.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeV.TabIndex = 222;
            MinimizeV.TabStop = false;
            // 
            // CLoseV
            // 
            CLoseV.Image = Properties.Resources.classe;
            CLoseV.Location = new Point(996, 14);
            CLoseV.Margin = new Padding(5);
            CLoseV.Name = "CLoseV";
            CLoseV.Size = new Size(31, 33);
            CLoseV.SizeMode = PictureBoxSizeMode.StretchImage;
            CLoseV.TabIndex = 221;
            CLoseV.TabStop = false;
            // 
            // BtnIssue
            // 
            BtnIssue.BackColor = Color.Gray;
            BtnIssue.BackgroundImageLayout = ImageLayout.None;
            BtnIssue.FlatStyle = FlatStyle.Popup;
            BtnIssue.Font = new Font("Calibri", 12F, FontStyle.Bold);
            BtnIssue.Location = new Point(445, 408);
            BtnIssue.Margin = new Padding(4);
            BtnIssue.Name = "BtnIssue";
            BtnIssue.Size = new Size(131, 40);
            BtnIssue.TabIndex = 224;
            BtnIssue.Text = "Issue";
            BtnIssue.UseVisualStyleBackColor = false;
            BtnIssue.Click += BtnIssue_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.Location = new Point(445, 482);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 225;
            button1.Text = "Issue";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.Location = new Point(445, 209);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 226;
            button2.Text = "Issue";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1041, 730);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnIssue);
            Controls.Add(Lblmsgi);
            Controls.Add(MinimizeV);
            Controls.Add(CLoseV);
            Controls.Add(Txtis);
            Controls.Add(LblIssueID);
            Controls.Add(TxtID);
            Controls.Add(LblCampus);
            Controls.Add(DateRet);
            Controls.Add(DateIssue);
            Controls.Add(Cisbn);
            Controls.Add(Return);
            Controls.Add(LBliss);
            Controls.Add(LblISBNI);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)MinimizeV).EndInit();
            ((System.ComponentModel.ISupportInitialize)CLoseV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txtis;
        private Label LblIssueID;
        private TextBox TxtID;
        private Label LblCampus;
        private DateTimePicker DateRet;
        private DateTimePicker DateIssue;
        private ComboBox Cisbn;
        private Label Return;
        private Label LBliss;
        private Label LblISBNI;
        private Label Lblmsgi;
        private PictureBox MinimizeV;
        private PictureBox CLoseV;
        private Button BtnIssue;
        private Button button1;
        private Button button2;
    }
}