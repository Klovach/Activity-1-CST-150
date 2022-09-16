namespace Activity_1___CST_150
{
    partial class Form1
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
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.chk_male = new System.Windows.Forms.CheckBox();
            this.chk_female = new System.Windows.Forms.CheckBox();
            this.lbl_about = new System.Windows.Forms.Label();
            this.rtx_about = new System.Windows.Forms.RichTextBox();
            this.btn_confirmation = new System.Windows.Forms.Button();
            this.lbl_confirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(14, 13);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(275, 16);
            this.lbl_message.TabIndex = 0;
            this.lbl_message.Text = "Before you proceed, please answer this form.";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(14, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(121, 16);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "What\'s your name?";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(17, 71);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 2;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(14, 109);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(111, 16);
            this.lbl_age.TabIndex = 3;
            this.lbl_age.Text = "How old are you?";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(17, 128);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 22);
            this.txt_age.TabIndex = 4;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(14, 168);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(93, 16);
            this.lbl_gender.TabIndex = 5;
            this.lbl_gender.Text = "My gender is...";
            // 
            // chk_male
            // 
            this.chk_male.AutoSize = true;
            this.chk_male.Location = new System.Drawing.Point(17, 188);
            this.chk_male.Name = "chk_male";
            this.chk_male.Size = new System.Drawing.Size(59, 20);
            this.chk_male.TabIndex = 6;
            this.chk_male.Text = "Male";
            this.chk_male.UseVisualStyleBackColor = true;
            // 
            // chk_female
            // 
            this.chk_female.AutoSize = true;
            this.chk_female.Location = new System.Drawing.Point(17, 214);
            this.chk_female.Name = "chk_female";
            this.chk_female.Size = new System.Drawing.Size(75, 20);
            this.chk_female.TabIndex = 7;
            this.chk_female.Text = "Female";
            this.chk_female.UseVisualStyleBackColor = true;
            // 
            // lbl_about
            // 
            this.lbl_about.AutoSize = true;
            this.lbl_about.Location = new System.Drawing.Point(14, 248);
            this.lbl_about.Name = "lbl_about";
            this.lbl_about.Size = new System.Drawing.Size(76, 16);
            this.lbl_about.TabIndex = 8;
            this.lbl_about.Text = "About you...";
            // 
            // rtx_about
            // 
            this.rtx_about.Location = new System.Drawing.Point(17, 268);
            this.rtx_about.Name = "rtx_about";
            this.rtx_about.Size = new System.Drawing.Size(771, 96);
            this.rtx_about.TabIndex = 9;
            this.rtx_about.Text = "Tell us about yourself in this box...";
            this.rtx_about.TextChanged += new System.EventHandler(this.rtx_about_TextChanged);
            // 
            // btn_confirmation
            // 
            this.btn_confirmation.Location = new System.Drawing.Point(17, 382);
            this.btn_confirmation.Name = "btn_confirmation";
            this.btn_confirmation.Size = new System.Drawing.Size(230, 23);
            this.btn_confirmation.TabIndex = 10;
            this.btn_confirmation.Text = "I\'m All Done!";
            this.btn_confirmation.UseVisualStyleBackColor = true;
            this.btn_confirmation.Click += new System.EventHandler(this.btn_confirmation_Click);
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Location = new System.Drawing.Point(14, 417);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(0, 16);
            this.lbl_confirmation.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.lbl_confirmation);
            this.Controls.Add(this.btn_confirmation);
            this.Controls.Add(this.rtx_about);
            this.Controls.Add(this.lbl_about);
            this.Controls.Add(this.chk_female);
            this.Controls.Add(this.chk_male);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_message);
            this.Name = "Form1";
            this.Text = "Activity One - Grand Canyon University";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.CheckBox chk_male;
        private System.Windows.Forms.CheckBox chk_female;
        private System.Windows.Forms.Label lbl_about;
        private System.Windows.Forms.RichTextBox rtx_about;
        private System.Windows.Forms.Button btn_confirmation;
        private System.Windows.Forms.Label lbl_confirmation;
    }
}

