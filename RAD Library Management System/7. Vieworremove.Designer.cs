namespace RAD_Library_Management_System
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Lblshelf = new Label();
            Lblgenre = new Label();
            Lblpermission = new Label();
            Lbltittle = new Label();
            Lblpubshisher = new Label();
            Lblauthor = new Label();
            LblISBN = new Label();
            Btncancel = new Button();
            Btnview = new Button();
            Ctittle = new ComboBox();
            Cpub = new ComboBox();
            Cisbn = new ComboBox();
            Cauth = new ComboBox();
            Cperm = new ComboBox();
            Cgen = new ComboBox();
            Cshelf = new ComboBox();
            Cno = new ComboBox();
            Btncear = new Button();
            Btndel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(55, 498);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 24);
            label1.TabIndex = 71;
            label1.Text = "No of copies :";
            // 
            // Lblshelf
            // 
            Lblshelf.AutoSize = true;
            Lblshelf.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblshelf.Location = new Point(54, 436);
            Lblshelf.Margin = new Padding(4, 0, 4, 0);
            Lblshelf.Name = "Lblshelf";
            Lblshelf.Size = new Size(62, 24);
            Lblshelf.TabIndex = 69;
            Lblshelf.Text = "Shelf :";
            // 
            // Lblgenre
            // 
            Lblgenre.AutoSize = true;
            Lblgenre.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblgenre.Location = new Point(54, 311);
            Lblgenre.Margin = new Padding(4, 0, 4, 0);
            Lblgenre.Name = "Lblgenre";
            Lblgenre.Size = new Size(72, 24);
            Lblgenre.TabIndex = 64;
            Lblgenre.Text = "Genre :";
            // 
            // Lblpermission
            // 
            Lblpermission.AutoSize = true;
            Lblpermission.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblpermission.Location = new Point(54, 371);
            Lblpermission.Margin = new Padding(4, 0, 4, 0);
            Lblpermission.Name = "Lblpermission";
            Lblpermission.Size = new Size(113, 24);
            Lblpermission.TabIndex = 63;
            Lblpermission.Text = "Permission :";
            // 
            // Lbltittle
            // 
            Lbltittle.AutoSize = true;
            Lbltittle.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lbltittle.Location = new Point(54, 180);
            Lbltittle.Margin = new Padding(4, 0, 4, 0);
            Lbltittle.Name = "Lbltittle";
            Lbltittle.Size = new Size(64, 24);
            Lbltittle.TabIndex = 62;
            Lbltittle.Text = "Tittle :";
            // 
            // Lblpubshisher
            // 
            Lblpubshisher.AutoSize = true;
            Lblpubshisher.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblpubshisher.Location = new Point(54, 245);
            Lblpubshisher.Margin = new Padding(4, 0, 4, 0);
            Lblpubshisher.Name = "Lblpubshisher";
            Lblpubshisher.Size = new Size(100, 24);
            Lblpubshisher.TabIndex = 61;
            Lblpubshisher.Text = "Publisher :";
            // 
            // Lblauthor
            // 
            Lblauthor.AutoSize = true;
            Lblauthor.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblauthor.Location = new Point(54, 115);
            Lblauthor.Margin = new Padding(4, 0, 4, 0);
            Lblauthor.Name = "Lblauthor";
            Lblauthor.Size = new Size(80, 24);
            Lblauthor.TabIndex = 58;
            Lblauthor.Text = "Author :";
            // 
            // LblISBN
            // 
            LblISBN.AutoSize = true;
            LblISBN.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblISBN.Location = new Point(54, 57);
            LblISBN.Margin = new Padding(4, 0, 4, 0);
            LblISBN.Name = "LblISBN";
            LblISBN.Size = new Size(59, 24);
            LblISBN.TabIndex = 57;
            LblISBN.Text = "ISBN :";
            // 
            // Btncancel
            // 
            Btncancel.BackColor = Color.Gray;
            Btncancel.BackgroundImageLayout = ImageLayout.None;
            Btncancel.FlatStyle = FlatStyle.Popup;
            Btncancel.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Btncancel.Location = new Point(419, 397);
            Btncancel.Margin = new Padding(4);
            Btncancel.Name = "Btncancel";
            Btncancel.Size = new Size(213, 56);
            Btncancel.TabIndex = 56;
            Btncancel.Text = "Cancel";
            Btncancel.UseVisualStyleBackColor = false;
            // 
            // Btnview
            // 
            Btnview.BackColor = Color.Gray;
            Btnview.BackgroundImageLayout = ImageLayout.None;
            Btnview.FlatStyle = FlatStyle.Popup;
            Btnview.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Btnview.Location = new Point(419, 111);
            Btnview.Margin = new Padding(4);
            Btnview.Name = "Btnview";
            Btnview.Size = new Size(213, 56);
            Btnview.TabIndex = 55;
            Btnview.Text = "View";
            Btnview.UseVisualStyleBackColor = false;
            Btnview.Click += Btnview_Click;
            // 
            // Ctittle
            // 
            Ctittle.FormattingEnabled = true;
            Ctittle.Location = new Point(225, 176);
            Ctittle.Name = "Ctittle";
            Ctittle.Size = new Size(151, 28);
            Ctittle.TabIndex = 83;
            // 
            // Cpub
            // 
            Cpub.FormattingEnabled = true;
            Cpub.Location = new Point(225, 245);
            Cpub.Name = "Cpub";
            Cpub.Size = new Size(151, 28);
            Cpub.TabIndex = 84;
            // 
            // Cisbn
            // 
            Cisbn.FormattingEnabled = true;
            Cisbn.Location = new Point(225, 53);
            Cisbn.Name = "Cisbn";
            Cisbn.Size = new Size(151, 28);
            Cisbn.TabIndex = 85;
            // 
            // Cauth
            // 
            Cauth.FormattingEnabled = true;
            Cauth.Location = new Point(225, 111);
            Cauth.Name = "Cauth";
            Cauth.Size = new Size(151, 28);
            Cauth.TabIndex = 86;
            // 
            // Cperm
            // 
            Cperm.FormattingEnabled = true;
            Cperm.Location = new Point(225, 367);
            Cperm.Name = "Cperm";
            Cperm.Size = new Size(151, 28);
            Cperm.TabIndex = 87;
            // 
            // Cgen
            // 
            Cgen.FormattingEnabled = true;
            Cgen.Location = new Point(225, 307);
            Cgen.Name = "Cgen";
            Cgen.Size = new Size(151, 28);
            Cgen.TabIndex = 88;
            // 
            // Cshelf
            // 
            Cshelf.FormattingEnabled = true;
            Cshelf.Location = new Point(225, 432);
            Cshelf.Name = "Cshelf";
            Cshelf.Size = new Size(151, 28);
            Cshelf.TabIndex = 89;
            // 
            // Cno
            // 
            Cno.FormattingEnabled = true;
            Cno.Location = new Point(225, 494);
            Cno.Name = "Cno";
            Cno.Size = new Size(151, 28);
            Cno.TabIndex = 90;
            // 
            // Btncear
            // 
            Btncear.BackColor = Color.Gray;
            Btncear.BackgroundImageLayout = ImageLayout.None;
            Btncear.FlatStyle = FlatStyle.Popup;
            Btncear.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Btncear.Location = new Point(419, 295);
            Btncear.Margin = new Padding(4);
            Btncear.Name = "Btncear";
            Btncear.Size = new Size(213, 56);
            Btncear.TabIndex = 91;
            Btncear.Text = "Clear";
            Btncear.UseVisualStyleBackColor = false;
            // 
            // Btndel
            // 
            Btndel.BackColor = Color.Gray;
            Btndel.BackgroundImageLayout = ImageLayout.None;
            Btndel.FlatStyle = FlatStyle.Popup;
            Btndel.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Btndel.Location = new Point(419, 201);
            Btndel.Margin = new Padding(4);
            Btndel.Name = "Btndel";
            Btndel.Size = new Size(213, 56);
            Btndel.TabIndex = 92;
            Btndel.Text = "Delete";
            Btndel.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(Btndel);
            Controls.Add(Btncear);
            Controls.Add(Cno);
            Controls.Add(Cshelf);
            Controls.Add(Cgen);
            Controls.Add(Cperm);
            Controls.Add(Cauth);
            Controls.Add(Cisbn);
            Controls.Add(Cpub);
            Controls.Add(Ctittle);
            Controls.Add(label1);
            Controls.Add(Lblshelf);
            Controls.Add(Lblgenre);
            Controls.Add(Lblpermission);
            Controls.Add(Lbltittle);
            Controls.Add(Lblpubshisher);
            Controls.Add(Lblauthor);
            Controls.Add(LblISBN);
            Controls.Add(Btncancel);
            Controls.Add(Btnview);
            Name = "UserControl1";
            Size = new Size(690, 576);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label Lblshelf;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label Lblgenre;
        private Label Lblpermission;
        private Label Lbltittle;
        private Label Lblpubshisher;
        private TextBox textBox1;
        private Label Lblauthor;
        private Label LblISBN;
        private Button Btncancel;
        private Button Btnview;
        private ComboBox permC;
        private ComboBox Ctittle;
        private ComboBox Cpub;
        private ComboBox Cisbn;
        private ComboBox Cauth;
        private ComboBox Cperm;
        private ComboBox Cgen;
        private ComboBox Cshelf;
        private ComboBox Cno;
        private Button Btncear;
        private Button Btndel;
    }
}
