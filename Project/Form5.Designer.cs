namespace Project.presentation
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            dtgr = new DataGridView();
            btnAdd = new Button();
            btnremov = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(799, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(296, 29);
            label1.Name = "label1";
            label1.Size = new Size(228, 59);
            label1.TabIndex = 31;
            label1.Text = "Welcome";
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.SandyBrown;
            button2.Location = new Point(48, 462);
            button2.Name = "button2";
            button2.Size = new Size(201, 57);
            button2.TabIndex = 36;
            button2.Text = "Favorites";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SandyBrown;
            button1.Location = new Point(48, 389);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(2);
            button1.Size = new Size(201, 60);
            button1.TabIndex = 35;
            button1.Text = "Show Products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            dtgr.Location = new Point(283, 124);
            dtgr.Name = "dtgr";
            dtgr.RowHeadersWidth = 62;
            dtgr.Size = new Size(612, 245);
            dtgr.TabIndex = 37;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Snow;
            btnAdd.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.ForeColor = Color.SandyBrown;
            btnAdd.Location = new Point(445, 422);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(224, 67);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Add To Favorites";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnremov
            // 
            btnremov.BackColor = Color.Snow;
            btnremov.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic);
            btnremov.ForeColor = Color.SandyBrown;
            btnremov.Location = new Point(414, 422);
            btnremov.Name = "btnremov";
            btnremov.Size = new Size(301, 67);
            btnremov.TabIndex = 39;
            btnremov.Text = "Remov From Favorite";
            btnremov.UseVisualStyleBackColor = false;
            btnremov.Click += btnremov_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(898, 538);
            Controls.Add(pictureBox1);
            Controls.Add(btnremov);
            Controls.Add(btnAdd);
            Controls.Add(dtgr);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Location = new Point(50, 50);
            Name = "User";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView dtgr;
        private Button btnAdd;
        private Button btnremov;
        private PictureBox pictureBox1;
    }
}