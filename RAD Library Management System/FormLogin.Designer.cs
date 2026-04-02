namespace RAD_Library_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            Lblmain = new Label();
            Btnlogin = new Button();
            textBox1 = new TextBox();
            Invalid = new Label();
            label3 = new Label();
            label4 = new Label();
            Btnclear = new Button();
            textBox2 = new TextBox();
            Show = new CheckBox();
            CLoseL = new PictureBox();
            MinimizeL = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CLoseL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeL).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.lib;
            pictureBox1.Location = new Point(174, 30);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Lblmain
            // 
            Lblmain.AutoSize = true;
            Lblmain.BackColor = Color.Transparent;
            Lblmain.Font = new Font("Elephant", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lblmain.Location = new Point(167, 141);
            Lblmain.Margin = new Padding(4, 0, 4, 0);
            Lblmain.Name = "Lblmain";
            Lblmain.Size = new Size(139, 38);
            Lblmain.TabIndex = 1;
            Lblmain.Text = "LOGIN";
            // 
            // Btnlogin
            // 
            Btnlogin.ForeColor = SystemColors.WindowFrame;
            Btnlogin.Location = new Point(73, 399);
            Btnlogin.Margin = new Padding(4);
            Btnlogin.Name = "Btnlogin";
            Btnlogin.Size = new Size(297, 55);
            Btnlogin.TabIndex = 2;
            Btnlogin.Text = "Login";
            Btnlogin.UseVisualStyleBackColor = true;
            Btnlogin.Click += Btnlogin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 233);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 32);
            textBox1.TabIndex = 3;
            // 
            // Invalid
            // 
            Invalid.AutoSize = true;
            Invalid.BackColor = Color.Transparent;
            Invalid.Location = new Point(73, 192);
            Invalid.Margin = new Padding(4, 0, 4, 0);
            Invalid.Name = "Invalid";
            Invalid.Size = new Size(0, 24);
            Invalid.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(27, 302);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 24);
            label3.TabIndex = 5;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(27, 233);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 24);
            label4.TabIndex = 6;
            label4.Text = "UserID :";
            // 
            // Btnclear
            // 
            Btnclear.ForeColor = SystemColors.WindowFrame;
            Btnclear.Location = new Point(73, 462);
            Btnclear.Margin = new Padding(4);
            Btnclear.Name = "Btnclear";
            Btnclear.Size = new Size(297, 55);
            Btnclear.TabIndex = 7;
            Btnclear.Text = "Clear";
            Btnclear.UseVisualStyleBackColor = true;
            Btnclear.Click += Btnclear_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 294);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 32);
            textBox2.TabIndex = 8;
            // 
            // Show
            // 
            Show.AutoSize = true;
            Show.BackColor = Color.Transparent;
            Show.ForeColor = Color.White;
            Show.Location = new Point(236, 348);
            Show.Name = "Show";
            Show.Size = new Size(164, 28);
            Show.TabIndex = 9;
            Show.Text = "Show Password";
            Show.UseVisualStyleBackColor = false;
            Show.CheckedChanged += Show_CheckedChanged;
            // 
            // CLoseL
            // 
            CLoseL.Image = Properties.Resources.classe;
            CLoseL.Location = new Point(409, 5);
            CLoseL.Margin = new Padding(5);
            CLoseL.Name = "CLoseL";
            CLoseL.Size = new Size(31, 33);
            CLoseL.SizeMode = PictureBoxSizeMode.StretchImage;
            CLoseL.TabIndex = 36;
            CLoseL.TabStop = false;
            CLoseL.Click += CLoseL_Click;
            // 
            // MinimizeL
            // 
            MinimizeL.Image = Properties.Resources.min;
            MinimizeL.Location = new Point(368, 5);
            MinimizeL.Margin = new Padding(5);
            MinimizeL.Name = "MinimizeL";
            MinimizeL.Size = new Size(31, 33);
            MinimizeL.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeL.TabIndex = 37;
            MinimizeL.TabStop = false;
            MinimizeL.Click += MinimizeL_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(447, 542);
            Controls.Add(MinimizeL);
            Controls.Add(CLoseL);
            Controls.Add(Show);
            Controls.Add(textBox2);
            Controls.Add(Btnclear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Invalid);
            Controls.Add(textBox1);
            Controls.Add(Btnlogin);
            Controls.Add(Lblmain);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CLoseL).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Lblmain;
        private Button Btnlogin;
        private TextBox textBox1;
        private Label Invalid;
        private Label label3;
        private Label label4;
        private Button Btnclear;
        private TextBox textBox2;
        private CheckBox Show;
        private PictureBox CLoseL;
        private PictureBox MinimizeL;
    }
}