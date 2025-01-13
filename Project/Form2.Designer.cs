namespace Project
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
            label1 = new Label();
            txtname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(95, 190);
            label1.Name = "label1";
            label1.Size = new Size(130, 49);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(322, 208);
            txtname.Name = "txtname";
            txtname.Size = new Size(298, 31);
            txtname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 20F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(77, 283);
            label2.Name = "label2";
            label2.Size = new Size(198, 49);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 20F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.SeaShell;
            label3.Location = new Point(247, 81);
            label3.Name = "label3";
            label3.Size = new Size(161, 49);
            label3.TabIndex = 3;
            label3.Text = "LOG IN";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(326, 298);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(298, 31);
            txtPass.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(366, 392);
            button1.Name = "button1";
            button1.Size = new Size(190, 61);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.SandyBrown;
            button2.Location = new Point(142, 392);
            button2.Name = "button2";
            button2.Size = new Size(179, 61);
            button2.TabIndex = 8;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic);
            checkBox1.ForeColor = Color.Transparent;
            checkBox1.Location = new Point(587, 303);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(657, 599);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Location = new Point(50, 50);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtname;
        private Label label2;
        private Label label3;
        private TextBox txtPass;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}