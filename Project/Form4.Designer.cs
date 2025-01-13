namespace Project.presentation
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            dtgr = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnAddPro = new Button();
            btnUpdatePro = new Button();
            btnDeletePro = new Button();
            labId = new Label();
            labName = new Label();
            labPrice = new Label();
            labCatId = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtCatId = new TextBox();
            btnAddCat = new Button();
            btnUpdateCat = new Button();
            btnDeleteCat = new Button();
            labAge = new Label();
            labAdress = new Label();
            labRole = new Label();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            comRole = new ComboBox();
            btnAddUser = new Button();
            btnUbdateUser = new Button();
            btnDeleteUser = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtgr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dtgr
            // 
            dtgr.AllowUserToAddRows = false;
            dtgr.AllowUserToDeleteRows = false;
            dtgr.AllowUserToOrderColumns = true;
            dtgr.AllowUserToResizeColumns = false;
            dtgr.AllowUserToResizeRows = false;
            dtgr.BackgroundColor = SystemColors.Control;
            dtgr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgr.Location = new Point(265, 108);
            dtgr.Name = "dtgr";
            dtgr.RowHeadersWidth = 62;
            dtgr.Size = new Size(691, 227);
            dtgr.TabIndex = 0;
            dtgr.CellDoubleClick += dtgr_CellDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.SandyBrown;
            button1.Location = new Point(15, 368);
            button1.Name = "button1";
            button1.Size = new Size(224, 70);
            button1.TabIndex = 2;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.SandyBrown;
            button2.Location = new Point(15, 451);
            button2.Name = "button2";
            button2.Size = new Size(224, 67);
            button2.TabIndex = 3;
            button2.Text = "Categories";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Snow;
            button3.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.SandyBrown;
            button3.Location = new Point(15, 524);
            button3.Name = "button3";
            button3.Size = new Size(224, 66);
            button3.TabIndex = 4;
            button3.Text = "Users";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnAddPro
            // 
            btnAddPro.BackColor = Color.Transparent;
            btnAddPro.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddPro.ForeColor = Color.SandyBrown;
            btnAddPro.Location = new Point(575, 563);
            btnAddPro.Name = "btnAddPro";
            btnAddPro.Size = new Size(130, 42);
            btnAddPro.TabIndex = 5;
            btnAddPro.Text = "ADD";
            btnAddPro.UseVisualStyleBackColor = false;
            btnAddPro.Click += btnAddPro_Click;
            // 
            // btnUpdatePro
            // 
            btnUpdatePro.BackColor = Color.Transparent;
            btnUpdatePro.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdatePro.ForeColor = Color.SandyBrown;
            btnUpdatePro.Location = new Point(711, 562);
            btnUpdatePro.Name = "btnUpdatePro";
            btnUpdatePro.Size = new Size(119, 42);
            btnUpdatePro.TabIndex = 6;
            btnUpdatePro.Text = "UPDATE";
            btnUpdatePro.UseVisualStyleBackColor = false;
            btnUpdatePro.Click += btnUpdatePro_Click;
            // 
            // btnDeletePro
            // 
            btnDeletePro.BackColor = Color.Transparent;
            btnDeletePro.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeletePro.ForeColor = Color.SandyBrown;
            btnDeletePro.Location = new Point(836, 558);
            btnDeletePro.Name = "btnDeletePro";
            btnDeletePro.Size = new Size(120, 42);
            btnDeletePro.TabIndex = 7;
            btnDeletePro.Text = "DELETE";
            btnDeletePro.UseVisualStyleBackColor = false;
            btnDeletePro.Click += btnDeletePro_Click;
            // 
            // labId
            // 
            labId.AutoSize = true;
            labId.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labId.ForeColor = Color.Transparent;
            labId.Location = new Point(265, 387);
            labId.Name = "labId";
            labId.Size = new Size(104, 28);
            labId.TabIndex = 8;
            labId.Text = "ProductId";
            // 
            // labName
            // 
            labName.AutoSize = true;
            labName.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labName.ForeColor = Color.Transparent;
            labName.Location = new Point(599, 387);
            labName.Name = "labName";
            labName.Size = new Size(142, 28);
            labName.TabIndex = 9;
            labName.Text = "ProductName";
            // 
            // labPrice
            // 
            labPrice.AutoSize = true;
            labPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labPrice.ForeColor = Color.Transparent;
            labPrice.Location = new Point(265, 438);
            labPrice.Name = "labPrice";
            labPrice.Size = new Size(58, 28);
            labPrice.TabIndex = 10;
            labPrice.Text = "Price";
            // 
            // labCatId
            // 
            labCatId.AutoSize = true;
            labCatId.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labCatId.ForeColor = Color.Transparent;
            labCatId.Location = new Point(610, 441);
            labCatId.Name = "labCatId";
            labCatId.Size = new Size(116, 28);
            labCatId.TabIndex = 11;
            labCatId.Text = "CategoryId";
            // 
            // txtId
            // 
            txtId.Location = new Point(388, 387);
            txtId.Name = "txtId";
            txtId.Size = new Size(205, 31);
            txtId.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(751, 384);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 31);
            txtName.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(388, 441);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(205, 31);
            txtPrice.TabIndex = 14;
            // 
            // txtCatId
            // 
            txtCatId.Location = new Point(751, 441);
            txtCatId.Name = "txtCatId";
            txtCatId.Size = new Size(205, 31);
            txtCatId.TabIndex = 15;
            // 
            // btnAddCat
            // 
            btnAddCat.BackColor = Color.Transparent;
            btnAddCat.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddCat.ForeColor = Color.SandyBrown;
            btnAddCat.Location = new Point(576, 561);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.Size = new Size(130, 42);
            btnAddCat.TabIndex = 16;
            btnAddCat.Text = "ADD";
            btnAddCat.UseVisualStyleBackColor = false;
            btnAddCat.Click += btnAddCat_Click;
            // 
            // btnUpdateCat
            // 
            btnUpdateCat.BackColor = Color.Transparent;
            btnUpdateCat.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdateCat.ForeColor = Color.SandyBrown;
            btnUpdateCat.Location = new Point(711, 557);
            btnUpdateCat.Name = "btnUpdateCat";
            btnUpdateCat.Size = new Size(119, 45);
            btnUpdateCat.TabIndex = 17;
            btnUpdateCat.Text = "UPDATE";
            btnUpdateCat.UseVisualStyleBackColor = false;
            btnUpdateCat.Click += btnUpdateCat_Click;
            // 
            // btnDeleteCat
            // 
            btnDeleteCat.BackColor = Color.Transparent;
            btnDeleteCat.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeleteCat.ForeColor = Color.SandyBrown;
            btnDeleteCat.Location = new Point(836, 556);
            btnDeleteCat.Name = "btnDeleteCat";
            btnDeleteCat.Size = new Size(120, 45);
            btnDeleteCat.TabIndex = 18;
            btnDeleteCat.Text = "DELETE";
            btnDeleteCat.UseVisualStyleBackColor = false;
            btnDeleteCat.Click += btnDeleteCat_Click;
            // 
            // labAge
            // 
            labAge.AutoSize = true;
            labAge.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labAge.ForeColor = Color.Transparent;
            labAge.Location = new Point(265, 490);
            labAge.Name = "labAge";
            labAge.Size = new Size(48, 28);
            labAge.TabIndex = 19;
            labAge.Text = "Age";
            // 
            // labAdress
            // 
            labAdress.AutoSize = true;
            labAdress.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labAdress.ForeColor = Color.Transparent;
            labAdress.Location = new Point(610, 490);
            labAdress.Name = "labAdress";
            labAdress.Size = new Size(86, 28);
            labAdress.TabIndex = 20;
            labAdress.Text = "Address";
            // 
            // labRole
            // 
            labRole.AutoSize = true;
            labRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labRole.ForeColor = Color.Transparent;
            labRole.Location = new Point(265, 542);
            labRole.Name = "labRole";
            labRole.Size = new Size(53, 28);
            labRole.TabIndex = 21;
            labRole.Text = "Role";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(751, 490);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(205, 31);
            txtAddress.TabIndex = 22;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(388, 490);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(205, 31);
            txtAge.TabIndex = 23;
            // 
            // comRole
            // 
            comRole.AccessibleRole = AccessibleRole.MenuBar;
            comRole.FormattingEnabled = true;
            comRole.Items.AddRange(new object[] { "Admin", "User" });
            comRole.Location = new Point(388, 537);
            comRole.Name = "comRole";
            comRole.Size = new Size(126, 33);
            comRole.TabIndex = 24;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Snow;
            btnAddUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.SandyBrown;
            btnAddUser.Location = new Point(575, 560);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(130, 44);
            btnAddUser.TabIndex = 25;
            btnAddUser.Text = "ADD";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnUbdateUser
            // 
            btnUbdateUser.BackColor = Color.Transparent;
            btnUbdateUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUbdateUser.ForeColor = Color.SandyBrown;
            btnUbdateUser.Location = new Point(711, 558);
            btnUbdateUser.Name = "btnUbdateUser";
            btnUbdateUser.Size = new Size(119, 44);
            btnUbdateUser.TabIndex = 26;
            btnUbdateUser.Text = "UPDATE";
            btnUbdateUser.UseVisualStyleBackColor = false;
            btnUbdateUser.Click += btnUpdateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Snow;
            btnDeleteUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.SandyBrown;
            btnDeleteUser.Location = new Point(836, 557);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(120, 44);
            btnDeleteUser.TabIndex = 27;
            btnDeleteUser.Text = "DELETE";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(313, 25);
            label1.Name = "label1";
            label1.Size = new Size(228, 59);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(824, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(565, 441);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 31;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(968, 614);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnUbdateUser);
            Controls.Add(btnAddUser);
            Controls.Add(comRole);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(labRole);
            Controls.Add(labAdress);
            Controls.Add(labAge);
            Controls.Add(btnDeleteCat);
            Controls.Add(btnUpdateCat);
            Controls.Add(btnAddCat);
            Controls.Add(txtCatId);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(labCatId);
            Controls.Add(labPrice);
            Controls.Add(labName);
            Controls.Add(labId);
            Controls.Add(btnDeletePro);
            Controls.Add(btnUpdatePro);
            Controls.Add(btnAddPro);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dtgr);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Location = new Point(50, 50);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dtgr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgr;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnAddPro;
        private Button btnUpdatePro;
        private Button btnDeletePro;
        private Label labId;
        private Label labName;
        private Label labPrice;
        private Label labCatId;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtCatId;
        private Button btnAddCat;
        private Button btnUpdateCat;
        private Button btnDeleteCat;
        private Label labAge;
        private Label labAdress;
        private Label labRole;
        private TextBox txtAddress;
        private TextBox txtAge;
        private ComboBox comRole;
        private Button btnAddUser;
        private Button btnUbdateUser;
        private Button btnDeleteUser;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox checkBox1;
    }
}