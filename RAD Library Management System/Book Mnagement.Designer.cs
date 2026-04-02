namespace RAD_Library_Management_System
{
    partial class FrmBookmgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookmgt));
            pictureBox1 = new PictureBox();
            BackB = new PictureBox();
            Btnadd = new Button();
            BtnupdtD = new Button();
            Btnview = new Button();
            Minimize = new PictureBox();
            CLose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CLose).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.k_removebg_preview;
            pictureBox1.Location = new Point(102, 93);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BackB
            // 
            BackB.BackColor = Color.Transparent;
            BackB.Image = Properties.Resources.Back;
            BackB.Location = new Point(15, 14);
            BackB.Margin = new Padding(4);
            BackB.Name = "BackB";
            BackB.Size = new Size(39, 34);
            BackB.SizeMode = PictureBoxSizeMode.StretchImage;
            BackB.TabIndex = 1;
            BackB.TabStop = false;
            BackB.Click += BackB_Click;
            // 
            // Btnadd
            // 
            Btnadd.BackColor = SystemColors.ControlDark;
            Btnadd.FlatStyle = FlatStyle.Popup;
            Btnadd.Location = new Point(582, 69);
            Btnadd.Margin = new Padding(4);
            Btnadd.Name = "Btnadd";
            Btnadd.Size = new Size(269, 124);
            Btnadd.TabIndex = 4;
            Btnadd.Text = "Add New Book";
            Btnadd.UseVisualStyleBackColor = false;
            Btnadd.Click += Btnadd_Click;
            // 
            // BtnupdtD
            // 
            BtnupdtD.BackColor = SystemColors.ControlDark;
            BtnupdtD.FlatStyle = FlatStyle.Popup;
            BtnupdtD.Location = new Point(582, 490);
            BtnupdtD.Margin = new Padding(4);
            BtnupdtD.Name = "BtnupdtD";
            BtnupdtD.Size = new Size(269, 124);
            BtnupdtD.TabIndex = 5;
            BtnupdtD.Text = "Update Existing Book Detail";
            BtnupdtD.UseVisualStyleBackColor = false;
            BtnupdtD.Click += BtnupdtD_Click;
            // 
            // Btnview
            // 
            Btnview.BackColor = SystemColors.ControlDark;
            Btnview.FlatStyle = FlatStyle.Popup;
            Btnview.Location = new Point(582, 270);
            Btnview.Margin = new Padding(4);
            Btnview.Name = "Btnview";
            Btnview.Size = new Size(269, 124);
            Btnview.TabIndex = 6;
            Btnview.Text = "View or Remove Book Details";
            Btnview.UseVisualStyleBackColor = false;
            Btnview.Click += Btnview_Click;
            // 
            // Minimize
            // 
            Minimize.Image = Properties.Resources.min;
            Minimize.Location = new Point(870, 8);
            Minimize.Margin = new Padding(6);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(39, 40);
            Minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            Minimize.TabIndex = 35;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // CLose
            // 
            CLose.Image = Properties.Resources.classe;
            CLose.Location = new Point(914, 8);
            CLose.Margin = new Padding(6);
            CLose.Name = "CLose";
            CLose.Size = new Size(39, 40);
            CLose.SizeMode = PictureBoxSizeMode.StretchImage;
            CLose.TabIndex = 34;
            CLose.TabStop = false;
            CLose.Click += CLose_Click;
            // 
            // FrmBookmgt
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 734);
            Controls.Add(BtnupdtD);
            Controls.Add(Btnview);
            Controls.Add(Minimize);
            Controls.Add(CLose);
            Controls.Add(Btnadd);
            Controls.Add(BackB);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmBookmgt";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackB).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)CLose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox BackB;
        private Button Btnadd;
        private Button BtnupdtD;
        private Button Btnview;
        private PictureBox Minimize;
        private PictureBox CLose;
    }
}