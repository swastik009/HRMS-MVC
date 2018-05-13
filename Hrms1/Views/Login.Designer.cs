namespace Hrms1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.emailAddr = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.checkBox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
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
            this.imgLogo.Location = new System.Drawing.Point(12, 80);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(155, 79);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            this.imgLogo.Zoom = 10;
            // 
            // emailAddr
            // 
            this.emailAddr.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(127)))));
            this.emailAddr.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.emailAddr.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(127)))));
            this.emailAddr.BorderThickness = 1;
            this.emailAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailAddr.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.emailAddr.isPassword = false;
            this.emailAddr.Location = new System.Drawing.Point(39, 166);
            this.emailAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailAddr.Name = "emailAddr";
            this.emailAddr.Size = new System.Drawing.Size(278, 41);
            this.emailAddr.TabIndex = 1;
            this.emailAddr.Text = "Email Address";
            this.emailAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailAddr.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.emailAddr.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // password
            // 
            this.password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(127)))));
            this.password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(127)))));
            this.password.BorderThickness = 1;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.password.isPassword = false;
            this.password.Location = new System.Drawing.Point(39, 215);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(278, 41);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            this.password.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.password.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBox1.Checked = true;
            this.checkBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(39, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(20, 20);
            this.checkBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stay signed in";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(147)))), ((int)(((byte)(227)))));
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.BorderRadius = 0;
            this.btnSignIn.ButtonText = "Sign In";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnSignIn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignIn.Iconimage = null;
            this.btnSignIn.Iconimage_right = null;
            this.btnSignIn.Iconimage_right_Selected = null;
            this.btnSignIn.Iconimage_Selected = null;
            this.btnSignIn.IconMarginLeft = 0;
            this.btnSignIn.IconMarginRight = 0;
            this.btnSignIn.IconRightVisible = true;
            this.btnSignIn.IconRightZoom = 0D;
            this.btnSignIn.IconVisible = true;
            this.btnSignIn.IconZoom = 90D;
            this.btnSignIn.IsTab = false;
            this.btnSignIn.Location = new System.Drawing.Point(227, 291);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(147)))), ((int)(((byte)(227)))));
            this.btnSignIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
            this.btnSignIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignIn.selected = false;
            this.btnSignIn.Size = new System.Drawing.Size(90, 29);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Textcolor = System.Drawing.Color.White;
            this.btnSignIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.Location = new System.Drawing.Point(34, 363);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(97, 16);
            this.signUpLabel.TabIndex = 6;
            this.signUpLabel.Text = "Not a member yet?";
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
            this.signUp.Location = new System.Drawing.Point(126, 364);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(112, 16);
            this.signUp.TabIndex = 10;
            this.signUp.TabStop = true;
            this.signUp.Text = "Get an KISTHRMS ID";
            this.signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.signUp.Click += new System.EventHandler(this.getANewID);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(322, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 499);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailAddr);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox checkBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailAddr;
        private Bunifu.Framework.UI.BunifuImageButton imgLogo;
        private System.Windows.Forms.LinkLabel signUp;
        private System.Windows.Forms.Label signUpLabel;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignIn;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
    }
}