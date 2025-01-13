namespace Project
{
    partial class Registr
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtname = new TextBox();
            txtpass = new TextBox();
            txtemail = new TextBox();
            txtage = new TextBox();
            txtaddress = new TextBox();
            txtconfpass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(33, 213);
            label2.Name = "label2";
            label2.Size = new Size(138, 35);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(33, 368);
            label3.Name = "label3";
            label3.Size = new Size(91, 35);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(33, 435);
            label4.Name = "label4";
            label4.Size = new Size(64, 35);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(33, 287);
            label5.Name = "label5";
            label5.Size = new Size(221, 35);
            label5.TabIndex = 4;
            label5.Text = "Conf Passoword";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(33, 507);
            label6.Name = "label6";
            label6.Size = new Size(118, 35);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // txtname
            // 
            txtname.BackColor = SystemColors.Control;
            txtname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.ForeColor = SystemColors.AppWorkspace;
            txtname.Location = new Point(276, 147);
            txtname.Name = "txtname";
            txtname.Size = new Size(313, 39);
            txtname.TabIndex = 6;
            // 
            // txtpass
            // 
            txtpass.ForeColor = SystemColors.AppWorkspace;
            txtpass.Location = new Point(274, 226);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(315, 31);
            txtpass.TabIndex = 7;
            // 
            // txtemail
            // 
            txtemail.ForeColor = SystemColors.AppWorkspace;
            txtemail.Location = new Point(274, 362);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(313, 31);
            txtemail.TabIndex = 8;
            txtemail.Validating += textBox3_Validating;
            // 
            // txtage
            // 
            txtage.ForeColor = SystemColors.AppWorkspace;
            txtage.Location = new Point(276, 435);
            txtage.Name = "txtage";
            txtage.Size = new Size(317, 31);
            txtage.TabIndex = 9;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(270, 511);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(319, 31);
            txtaddress.TabIndex = 10;
            // 
            // txtconfpass
            // 
            txtconfpass.ForeColor = SystemColors.AppWorkspace;
            txtconfpass.Location = new Point(276, 291);
            txtconfpass.Name = "txtconfpass";
            txtconfpass.PasswordChar = '*';
            txtconfpass.Size = new Size(313, 31);
            txtconfpass.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Constantia", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(129, 581);
            button1.Name = "button1";
            button1.Size = new Size(170, 57);
            button1.TabIndex = 14;
            button1.Text = "Regist";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Constantia", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SandyBrown;
            button2.Location = new Point(330, 581);
            button2.Name = "button2";
            button2.Size = new Size(159, 57);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(567, 264);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 16;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(170, 31);
            label1.Name = "label1";
            label1.Size = new Size(197, 59);
            label1.TabIndex = 32;
            label1.Text = "Sign Up";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(33, 147);
            label7.Name = "label7";
            label7.Size = new Size(90, 35);
            label7.TabIndex = 33;
            label7.Text = "Name";
            // 
            // Registr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(632, 650);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtconfpass);
            Controls.Add(txtaddress);
            Controls.Add(txtage);
            Controls.Add(txtemail);
            Controls.Add(txtpass);
            Controls.Add(txtname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Location = new Point(50, 50);
            Name = "Registr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registr";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtname;
        private TextBox txtpass;
        private TextBox txtemail;
        private TextBox txtage;
        private TextBox txtaddress;
        private TextBox txtconfpass;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private Label label1;
        private Label label7;
    }
}