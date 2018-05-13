namespace Hrms1
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.middleName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaleBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.FemaleBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.OthersBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.emailAddr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.email = new System.Windows.Forms.Label();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.hireDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.ImageActive = null;
            this.imgLogo.Location = new System.Drawing.Point(22, 57);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(155, 79);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 13;
            this.imgLogo.TabStop = false;
            this.imgLogo.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.Depth = 0;
            this.firstName.Hint = "";
            this.firstName.Location = new System.Drawing.Point(133, 173);
            this.firstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.SelectedText = "";
            this.firstName.SelectionLength = 0;
            this.firstName.SelectionStart = 0;
            this.firstName.Size = new System.Drawing.Size(278, 23);
            this.firstName.TabIndex = 2;
            this.firstName.UseSystemPasswordChar = false;
            // 
            // middleName
            // 
            this.middleName.Depth = 0;
            this.middleName.Hint = "";
            this.middleName.Location = new System.Drawing.Point(133, 201);
            this.middleName.MouseState = MaterialSkin.MouseState.HOVER;
            this.middleName.Name = "middleName";
            this.middleName.PasswordChar = '\0';
            this.middleName.SelectedText = "";
            this.middleName.SelectionLength = 0;
            this.middleName.SelectionStart = 0;
            this.middleName.Size = new System.Drawing.Size(278, 23);
            this.middleName.TabIndex = 3;
            this.middleName.UseSystemPasswordChar = false;
            this.middleName.Click += new System.EventHandler(this.middleName_Click);
            // 
            // lastName
            // 
            this.lastName.Depth = 0;
            this.lastName.Hint = "";
            this.lastName.Location = new System.Drawing.Point(133, 229);
            this.lastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastName.Name = "lastName";
            this.lastName.PasswordChar = '\0';
            this.lastName.SelectedText = "";
            this.lastName.SelectionLength = 0;
            this.lastName.SelectionStart = 0;
            this.lastName.Size = new System.Drawing.Size(278, 23);
            this.lastName.TabIndex = 4;
            this.lastName.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Birth Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Gender";
            // 
            // MaleBtn
            // 
            this.MaleBtn.AutoSize = true;
            this.MaleBtn.Checked = true;
            this.MaleBtn.Depth = 0;
            this.MaleBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.MaleBtn.Location = new System.Drawing.Point(128, 362);
            this.MaleBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MaleBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaleBtn.Name = "MaleBtn";
            this.MaleBtn.Ripple = true;
            this.MaleBtn.Size = new System.Drawing.Size(59, 30);
            this.MaleBtn.TabIndex = 8;
            this.MaleBtn.TabStop = true;
            this.MaleBtn.Text = "Male";
            this.MaleBtn.UseVisualStyleBackColor = true;
            // 
            // FemaleBtn
            // 
            this.FemaleBtn.AutoSize = true;
            this.FemaleBtn.Depth = 0;
            this.FemaleBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.FemaleBtn.Location = new System.Drawing.Point(227, 362);
            this.FemaleBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FemaleBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FemaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.FemaleBtn.Name = "FemaleBtn";
            this.FemaleBtn.Ripple = true;
            this.FemaleBtn.Size = new System.Drawing.Size(74, 30);
            this.FemaleBtn.TabIndex = 9;
            this.FemaleBtn.Text = "Female";
            this.FemaleBtn.UseVisualStyleBackColor = true;
            this.FemaleBtn.CheckedChanged += new System.EventHandler(this.FemaleBtn_CheckedChanged);
            // 
            // OthersBtn
            // 
            this.OthersBtn.AutoSize = true;
            this.OthersBtn.Depth = 0;
            this.OthersBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.OthersBtn.Location = new System.Drawing.Point(341, 362);
            this.OthersBtn.Margin = new System.Windows.Forms.Padding(0);
            this.OthersBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OthersBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.OthersBtn.Name = "OthersBtn";
            this.OthersBtn.Ripple = true;
            this.OthersBtn.Size = new System.Drawing.Size(70, 30);
            this.OthersBtn.TabIndex = 10;
            this.OthersBtn.TabStop = true;
            this.OthersBtn.Text = "Others";
            this.OthersBtn.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(427, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 37;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(147)))), ((int)(((byte)(227)))));
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.BorderRadius = 0;
            this.btnSignUp.ButtonText = "Sign Up";
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnSignUp.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignUp.Iconimage = null;
            this.btnSignUp.Iconimage_right = null;
            this.btnSignUp.Iconimage_right_Selected = null;
            this.btnSignUp.Iconimage_Selected = null;
            this.btnSignUp.IconMarginLeft = 0;
            this.btnSignUp.IconMarginRight = 0;
            this.btnSignUp.IconRightVisible = true;
            this.btnSignUp.IconRightZoom = 0D;
            this.btnSignUp.IconVisible = true;
            this.btnSignUp.IconZoom = 90D;
            this.btnSignUp.IsTab = false;
            this.btnSignUp.Location = new System.Drawing.Point(331, 473);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(147)))), ((int)(((byte)(227)))));
            this.btnSignUp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
            this.btnSignUp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignUp.selected = false;
            this.btnSignUp.Size = new System.Drawing.Size(80, 26);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Textcolor = System.Drawing.Color.White;
            this.btnSignUp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // emailAddr
            // 
            this.emailAddr.Depth = 0;
            this.emailAddr.Hint = "";
            this.emailAddr.Location = new System.Drawing.Point(133, 258);
            this.emailAddr.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailAddr.Name = "emailAddr";
            this.emailAddr.PasswordChar = '\0';
            this.emailAddr.SelectedText = "";
            this.emailAddr.SelectionLength = 0;
            this.emailAddr.SelectionStart = 0;
            this.emailAddr.Size = new System.Drawing.Size(278, 23);
            this.emailAddr.TabIndex = 5;
            this.emailAddr.UseSystemPasswordChar = false;
            this.emailAddr.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(43, 269);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(33, 16);
            this.email.TabIndex = 39;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.label7_Click);
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "";
            this.password.Location = new System.Drawing.Point(133, 286);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(278, 23);
            this.password.TabIndex = 6;
            this.password.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Hire Date";
            // 
            // birthDate
            // 
            this.birthDate.CustomFormat = "yyyy-MM-dd";
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDate.Location = new System.Drawing.Point(133, 329);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(278, 20);
            this.birthDate.TabIndex = 7;
            // 
            // hireDate
            // 
            this.hireDate.CustomFormat = "yyyy-MM-dd";
            this.hireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hireDate.Location = new System.Drawing.Point(133, 400);
            this.hireDate.Name = "hireDate";
            this.hireDate.Size = new System.Drawing.Size(278, 20);
            this.hireDate.TabIndex = 11;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 545);
            this.Controls.Add(this.hireDate);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailAddr);
            this.Controls.Add(this.email);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.OthersBtn);
            this.Controls.Add(this.FemaleBtn);
            this.Controls.Add(this.MaleBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton imgLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField middleName;
        private MaterialSkin.Controls.MaterialSingleLineTextField firstName;
        private MaterialSkin.Controls.MaterialRadioButton OthersBtn;
        private MaterialSkin.Controls.MaterialRadioButton FemaleBtn;
        private MaterialSkin.Controls.MaterialRadioButton MaleBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField lastName;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignUp;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailAddr;
        private System.Windows.Forms.Label email;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker hireDate;
        private System.Windows.Forms.DateTimePicker birthDate;
    }
}