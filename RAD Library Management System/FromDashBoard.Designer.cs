namespace RAD_Library_Management_System
{
    partial class Frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhome));
            label2 = new Label();
            Btnadd = new Button();
            label1 = new Label();
            Pclib = new PictureBox();
            CLose = new PictureBox();
            Minimize = new PictureBox();
            BtnIss = new Button();
            Btnmember = new Button();
            BtnDV = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pclib).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CLose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Stencil", 23.2F, FontStyle.Bold);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(408, 54);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(258, 46);
            label2.TabIndex = 29;
            label2.Text = "Welcome!!! ";
            // 
            // Btnadd
            // 
            Btnadd.BackColor = Color.SlateGray;
            Btnadd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Btnadd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Btnadd.FlatStyle = FlatStyle.Flat;
            Btnadd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnadd.ForeColor = Color.SeaShell;
            Btnadd.Location = new Point(659, 342);
            Btnadd.Name = "Btnadd";
            Btnadd.Size = new Size(167, 64);
            Btnadd.TabIndex = 23;
            Btnadd.Text = "Add Books ";
            Btnadd.UseVisualStyleBackColor = false;
            Btnadd.Click += Btnadd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 23.2F, FontStyle.Bold);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(191, 100);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(725, 46);
            label1.TabIndex = 22;
            label1.Text = "ABC Library Management  System";
            // 
            // Pclib
            // 
            Pclib.Image = Properties.Resources.MiddleSchool_LMC;
            Pclib.Location = new Point(69, 151);
            Pclib.Margin = new Padding(5);
            Pclib.Name = "Pclib";
            Pclib.Size = new Size(538, 603);
            Pclib.SizeMode = PictureBoxSizeMode.StretchImage;
            Pclib.TabIndex = 21;
            Pclib.TabStop = false;
            // 
            // CLose
            // 
            CLose.Image = Properties.Resources.classe;
            CLose.Location = new Point(1133, 14);
            CLose.Margin = new Padding(5);
            CLose.Name = "CLose";
            CLose.Size = new Size(34, 33);
            CLose.SizeMode = PictureBoxSizeMode.StretchImage;
            CLose.TabIndex = 30;
            CLose.TabStop = false;
            CLose.Click += CLose_Click;
            // 
            // Minimize
            // 
            Minimize.Image = Properties.Resources.min;
            Minimize.Location = new Point(1089, 14);
            Minimize.Margin = new Padding(5);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(34, 33);
            Minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            Minimize.TabIndex = 33;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // BtnIss
            // 
            BtnIss.BackColor = Color.SlateGray;
            BtnIss.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnIss.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnIss.FlatStyle = FlatStyle.Flat;
            BtnIss.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIss.ForeColor = Color.SeaShell;
            BtnIss.Location = new Point(947, 600);
            BtnIss.Name = "BtnIss";
            BtnIss.Size = new Size(167, 64);
            BtnIss.TabIndex = 37;
            BtnIss.Text = "Issue And Return Books ";
            BtnIss.UseVisualStyleBackColor = false;
            BtnIss.Click += BtnIss_Click;
            // 
            // Btnmember
            // 
            Btnmember.BackColor = Color.SlateGray;
            Btnmember.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Btnmember.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Btnmember.FlatStyle = FlatStyle.Flat;
            Btnmember.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnmember.ForeColor = Color.SeaShell;
            Btnmember.Location = new Point(947, 342);
            Btnmember.Name = "Btnmember";
            Btnmember.Size = new Size(181, 64);
            Btnmember.TabIndex = 38;
            Btnmember.Text = "Memebership Management";
            Btnmember.UseVisualStyleBackColor = false;
            Btnmember.Click += Btnmember_Click;
            // 
            // BtnDV
            // 
            BtnDV.BackColor = Color.SlateGray;
            BtnDV.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnDV.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnDV.FlatStyle = FlatStyle.Flat;
            BtnDV.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDV.ForeColor = Color.SeaShell;
            BtnDV.Location = new Point(659, 600);
            BtnDV.Name = "BtnDV";
            BtnDV.Size = new Size(167, 64);
            BtnDV.TabIndex = 40;
            BtnDV.Text = "View, Update or Delete Books ";
            BtnDV.UseVisualStyleBackColor = false;
            BtnDV.Click += BtnDV_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_13_211426;
            pictureBox1.Location = new Point(649, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.memb;
            pictureBox2.Location = new Point(938, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.bckmgy;
            pictureBox3.Location = new Point(649, 431);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(201, 163);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.issue2;
            pictureBox4.Location = new Point(922, 431);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(201, 163);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // Frmhome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 768);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnDV);
            Controls.Add(Btnmember);
            Controls.Add(BtnIss);
            Controls.Add(Minimize);
            Controls.Add(CLose);
            Controls.Add(label2);
            Controls.Add(Btnadd);
            Controls.Add(label1);
            Controls.Add(Pclib);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frmhome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Frmhome_Load;
            ((System.ComponentModel.ISupportInitialize)Pclib).EndInit();
            ((System.ComponentModel.ISupportInitialize)CLose).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button Btnadd;
        private Label label1;
        private PictureBox Pclib;
        private PictureBox CLose;
        private PictureBox Minimize;
        private Button BtnIss;
        private Button Btnmember;
        private Button BtnDV;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}