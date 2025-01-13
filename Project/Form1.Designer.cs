namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_login = new Button();
            btn_rej = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.ForeColor = Color.SandyBrown;
            btn_login.Location = new Point(597, 249);
            btn_login.Margin = new Padding(4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(168, 55);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login ";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_rej
            // 
            btn_rej.BackColor = Color.Snow;
            btn_rej.FlatAppearance.BorderSize = 0;
            btn_rej.ForeColor = Color.SandyBrown;
            btn_rej.Location = new Point(597, 329);
            btn_rej.Margin = new Padding(4);
            btn_rej.Name = "btn_rej";
            btn_rej.Size = new Size(168, 55);
            btn_rej.TabIndex = 1;
            btn_rej.Text = "Register";
            btn_rej.UseVisualStyleBackColor = false;
            btn_rej.Click += btn_rej_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(506, 543);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(541, 113);
            label1.Name = "label1";
            label1.Size = new Size(362, 59);
            label1.TabIndex = 33;
            label1.Text = "Welcome Back!";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(932, 538);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_rej);
            Controls.Add(btn_login);
            Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Location = new Point(50, 50);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Button btn_rej;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
