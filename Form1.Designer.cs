namespace PRACTICA_OIB
{
    partial class registration_window
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration_window));
            this.button_sign_up = new System.Windows.Forms.Button();
            this.User_name_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sign_up
            // 
            this.button_sign_up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_sign_up.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_sign_up.Location = new System.Drawing.Point(72, 199);
            this.button_sign_up.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sign_up.Name = "button_sign_up";
            this.button_sign_up.Size = new System.Drawing.Size(147, 28);
            this.button_sign_up.TabIndex = 0;
            this.button_sign_up.Text = "Sign up";
            this.button_sign_up.UseVisualStyleBackColor = false;
            this.button_sign_up.Click += new System.EventHandler(this.button1_Click);
            // 
            // User_name_label
            // 
            this.User_name_label.AutoSize = true;
            this.User_name_label.Location = new System.Drawing.Point(58, 86);
            this.User_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.User_name_label.Name = "User_name_label";
            this.User_name_label.Size = new System.Drawing.Size(58, 13);
            this.User_name_label.TabIndex = 1;
            this.User_name_label.Text = "User name";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Password_label.Location = new System.Drawing.Point(58, 136);
            this.Password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(144, 86);
            this.user_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(76, 20);
            this.user_name.TabIndex = 3;
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(144, 136);
            this.user_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '•';
            this.user_password.Size = new System.Drawing.Size(76, 20);
            this.user_password.TabIndex = 4;
            this.user_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // registration_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(286, 287);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.User_name_label);
            this.Controls.Add(this.button_sign_up);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "registration_window";
            this.Text = "Data Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sign_up;
        private System.Windows.Forms.Label User_name_label;
        private System.Windows.Forms.Label Password_label;
        public System.Windows.Forms.TextBox user_name;
        public System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

