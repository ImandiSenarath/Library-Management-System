namespace RAD_Library_Management_System
{
    partial class FormMemebership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemebership));
            BackN = new PictureBox();
            MinimizeN = new PictureBox();
            CLoseN = new PictureBox();
            BtnRef = new Button();
            pictureBox1 = new PictureBox();
            CampId = new Label();
            BtnSearch = new Button();
            PanelEdit = new Panel();
            TxtPhone = new TextBox();
            Lblphone = new Label();
            TxtLand = new TextBox();
            LblLans = new Label();
            Txtaddr = new TextBox();
            Kbladdr = new Label();
            TxtLast = new TextBox();
            Lbllast = new Label();
            Txtfirst = new TextBox();
            Lblfirst = new Label();
            TxtNIC = new TextBox();
            Lblnic = new Label();
            TxtcampusId = new TextBox();
            LblId = new Label();
            Btnupdt = new Button();
            Btndel = new Button();
            TxtSearchID = new TextBox();
            GridMember = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)BackN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CLoseN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridMember).BeginInit();
            SuspendLayout();
            // 
            // BackN
            // 
            BackN.BackColor = Color.Transparent;
            BackN.Image = Properties.Resources.Back;
            BackN.Location = new Point(39, 19);
            BackN.Name = "BackN";
            BackN.Size = new Size(31, 28);
            BackN.SizeMode = PictureBoxSizeMode.StretchImage;
            BackN.TabIndex = 177;
            BackN.TabStop = false;
            BackN.Click += BackN_Click;
            // 
            // MinimizeN
            // 
            MinimizeN.Image = Properties.Resources.min;
            MinimizeN.Location = new Point(973, 14);
            MinimizeN.Margin = new Padding(5);
            MinimizeN.Name = "MinimizeN";
            MinimizeN.Size = new Size(31, 33);
            MinimizeN.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeN.TabIndex = 176;
            MinimizeN.TabStop = false;
            MinimizeN.Click += MinimizeN_Click;
            // 
            // CLoseN
            // 
            CLoseN.Image = Properties.Resources.classe;
            CLoseN.Location = new Point(1014, 14);
            CLoseN.Margin = new Padding(5);
            CLoseN.Name = "CLoseN";
            CLoseN.Size = new Size(31, 33);
            CLoseN.SizeMode = PictureBoxSizeMode.StretchImage;
            CLoseN.TabIndex = 175;
            CLoseN.TabStop = false;
            CLoseN.Click += CLoseN_Click;
            // 
            // BtnRef
            // 
            BtnRef.Font = new Font("Calibri", 12F, FontStyle.Bold);
            BtnRef.Location = new Point(869, 175);
            BtnRef.Name = "BtnRef";
            BtnRef.Size = new Size(135, 33);
            BtnRef.TabIndex = 174;
            BtnRef.Text = "Refresh";
            BtnRef.UseVisualStyleBackColor = true;
            BtnRef.Click += BtnRef_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(479, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 173;
            pictureBox1.TabStop = false;
            // 
            // CampId
            // 
            CampId.AutoSize = true;
            CampId.Font = new Font("Calibri", 12F, FontStyle.Bold);
            CampId.Location = new Point(154, 181);
            CampId.Name = "CampId";
            CampId.Size = new Size(100, 24);
            CampId.TabIndex = 172;
            CampId.Text = "Campus ID";
            // 
            // BtnSearch
            // 
            BtnSearch.Font = new Font("Calibri", 12F, FontStyle.Bold);
            BtnSearch.Location = new Point(670, 175);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(135, 33);
            BtnSearch.TabIndex = 171;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // PanelEdit
            // 
            PanelEdit.BackColor = SystemColors.ControlDarkDark;
            PanelEdit.Controls.Add(TxtPhone);
            PanelEdit.Controls.Add(Lblphone);
            PanelEdit.Controls.Add(TxtLand);
            PanelEdit.Controls.Add(LblLans);
            PanelEdit.Controls.Add(Txtaddr);
            PanelEdit.Controls.Add(Kbladdr);
            PanelEdit.Controls.Add(TxtLast);
            PanelEdit.Controls.Add(Lbllast);
            PanelEdit.Controls.Add(Txtfirst);
            PanelEdit.Controls.Add(Lblfirst);
            PanelEdit.Controls.Add(TxtNIC);
            PanelEdit.Controls.Add(Lblnic);
            PanelEdit.Controls.Add(TxtcampusId);
            PanelEdit.Controls.Add(LblId);
            PanelEdit.Controls.Add(Btnupdt);
            PanelEdit.Controls.Add(Btndel);
            PanelEdit.Location = new Point(39, 472);
            PanelEdit.Name = "PanelEdit";
            PanelEdit.Size = new Size(981, 269);
            PanelEdit.TabIndex = 170;
            // 
            // TxtPhone
            // 
            TxtPhone.Font = new Font("Calibri", 12F, FontStyle.Bold);
            TxtPhone.Location = new Point(611, 157);
            TxtPhone.Margin = new Padding(4);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(155, 32);
            TxtPhone.TabIndex = 205;
            // 
            // Lblphone
            // 
            Lblphone.AutoSize = true;
            Lblphone.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblphone.Location = new Point(440, 165);
            Lblphone.Margin = new Padding(4, 0, 4, 0);
            Lblphone.Name = "Lblphone";
            Lblphone.Size = new Size(99, 24);
            Lblphone.TabIndex = 204;
            Lblphone.Text = "Phone No:";
            // 
            // TxtLand
            // 
            TxtLand.Font = new Font("Calibri", 12F, FontStyle.Bold);
            TxtLand.Location = new Point(611, 94);
            TxtLand.Margin = new Padding(4);
            TxtLand.Name = "TxtLand";
            TxtLand.Size = new Size(155, 32);
            TxtLand.TabIndex = 203;
            // 
            // LblLans
            // 
            LblLans.AutoSize = true;
            LblLans.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblLans.Location = new Point(440, 102);
            LblLans.Margin = new Padding(4, 0, 4, 0);
            LblLans.Name = "LblLans";
            LblLans.Size = new Size(100, 24);
            LblLans.TabIndex = 202;
            LblLans.Text = "Land Line :";
            // 
            // Txtaddr
            // 
            Txtaddr.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Txtaddr.Location = new Point(611, 34);
            Txtaddr.Margin = new Padding(4);
            Txtaddr.Name = "Txtaddr";
            Txtaddr.Size = new Size(155, 32);
            Txtaddr.TabIndex = 201;
            // 
            // Kbladdr
            // 
            Kbladdr.AutoSize = true;
            Kbladdr.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Kbladdr.Location = new Point(440, 42);
            Kbladdr.Margin = new Padding(4, 0, 4, 0);
            Kbladdr.Name = "Kbladdr";
            Kbladdr.Size = new Size(77, 24);
            Kbladdr.TabIndex = 200;
            Kbladdr.Text = "Address";
            // 
            // TxtLast
            // 
            TxtLast.Font = new Font("Calibri", 12F, FontStyle.Bold);
            TxtLast.Location = new Point(204, 216);
            TxtLast.Margin = new Padding(4);
            TxtLast.Name = "TxtLast";
            TxtLast.Size = new Size(155, 32);
            TxtLast.TabIndex = 199;
            // 
            // Lbllast
            // 
            Lbllast.AutoSize = true;
            Lbllast.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lbllast.Location = new Point(33, 225);
            Lbllast.Margin = new Padding(4, 0, 4, 0);
            Lbllast.Name = "Lbllast";
            Lbllast.Size = new Size(108, 24);
            Lbllast.TabIndex = 198;
            Lbllast.Text = "Last Name :";
            // 
            // Txtfirst
            // 
            Txtfirst.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Txtfirst.Location = new Point(204, 156);
            Txtfirst.Margin = new Padding(4);
            Txtfirst.Name = "Txtfirst";
            Txtfirst.Size = new Size(155, 32);
            Txtfirst.TabIndex = 197;
            // 
            // Lblfirst
            // 
            Lblfirst.AutoSize = true;
            Lblfirst.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblfirst.Location = new Point(33, 165);
            Lblfirst.Margin = new Padding(4, 0, 4, 0);
            Lblfirst.Name = "Lblfirst";
            Lblfirst.Size = new Size(111, 24);
            Lblfirst.TabIndex = 196;
            Lblfirst.Text = "First Name :";
            // 
            // TxtNIC
            // 
            TxtNIC.Font = new Font("Calibri", 12F, FontStyle.Bold);
            TxtNIC.Location = new Point(204, 96);
            TxtNIC.Margin = new Padding(4);
            TxtNIC.Name = "TxtNIC";
            TxtNIC.Size = new Size(155, 32);
            TxtNIC.TabIndex = 195;
            // 
            // Lblnic
            // 
            Lblnic.AutoSize = true;
            Lblnic.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Lblnic.Location = new Point(33, 105);
            Lblnic.Margin = new Padding(4, 0, 4, 0);
            Lblnic.Name = "Lblnic";
            Lblnic.Size = new Size(39, 24);
            Lblnic.TabIndex = 194;
            Lblnic.Text = "NIC";
            // 
            // TxtcampusId
            // 
            TxtcampusId.Font = new Font("Calibri", 12F, FontStyle.Bold);
            TxtcampusId.Location = new Point(204, 36);
            TxtcampusId.Margin = new Padding(4);
            TxtcampusId.Name = "TxtcampusId";
            TxtcampusId.Size = new Size(155, 32);
            TxtcampusId.TabIndex = 193;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LblId.Location = new Point(33, 45);
            LblId.Margin = new Padding(4, 0, 4, 0);
            LblId.Name = "LblId";
            LblId.Size = new Size(111, 24);
            LblId.TabIndex = 192;
            LblId.Text = "Campus ID :";
            // 
            // Btnupdt
            // 
            Btnupdt.BackColor = Color.Gray;
            Btnupdt.BackgroundImageLayout = ImageLayout.None;
            Btnupdt.FlatStyle = FlatStyle.Popup;
            Btnupdt.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Btnupdt.Location = new Point(805, 45);
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
            Btndel.Location = new Point(805, 97);
            Btndel.Margin = new Padding(4);
            Btndel.Name = "Btndel";
            Btndel.Size = new Size(142, 35);
            Btndel.TabIndex = 157;
            Btndel.Text = "Delete";
            Btndel.UseVisualStyleBackColor = false;
            // 
            // TxtSearchID
            // 
            TxtSearchID.Location = new Point(321, 178);
            TxtSearchID.Name = "TxtSearchID";
            TxtSearchID.Size = new Size(273, 27);
            TxtSearchID.TabIndex = 169;
            TxtSearchID.TextChanged += TxtSearchID_TextChanged;
            // 
            // GridMember
            // 
            GridMember.BackgroundColor = SystemColors.Control;
            GridMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridMember.Location = new Point(39, 214);
            GridMember.Name = "GridMember";
            GridMember.RowHeadersWidth = 51;
            GridMember.Size = new Size(981, 252);
            GridMember.TabIndex = 168;
            GridMember.CellContentClick += GridMember_CellContentClick;
            // 
            // FormMemebership
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1057, 763);
            Controls.Add(BackN);
            Controls.Add(MinimizeN);
            Controls.Add(CLoseN);
            Controls.Add(BtnRef);
            Controls.Add(pictureBox1);
            Controls.Add(CampId);
            Controls.Add(BtnSearch);
            Controls.Add(PanelEdit);
            Controls.Add(TxtSearchID);
            Controls.Add(GridMember);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMemebership";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMemebership";
            Load += FormMemebership_Load;
            ((System.ComponentModel.ISupportInitialize)BackN).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeN).EndInit();
            ((System.ComponentModel.ISupportInitialize)CLoseN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelEdit.ResumeLayout(false);
            PanelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BackN;
        private PictureBox MinimizeN;
        private PictureBox CLoseN;
        private Button BtnRef;
        private PictureBox pictureBox1;
        private Label CampId;
        private Button BtnSearch;
        private Panel PanelEdit;
        private Button Btnupdt;
        private Button Btndel;
        private TextBox TxtSearchID;
        private DataGridView GridMember;
        private TextBox TxtPhone;
        private Label Lblphone;
        private TextBox TxtLand;
        private Label LblLans;
        private TextBox Txtaddr;
        private Label Kbladdr;
        private TextBox TxtLast;
        private Label Lbllast;
        private TextBox Txtfirst;
        private Label Lblfirst;
        private TextBox TxtNIC;
        private Label Lblnic;
        private TextBox TxtcampusId;
        private Label LblId;
    }
}