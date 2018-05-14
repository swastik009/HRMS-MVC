namespace Hrms1
{
    partial class Dashboard
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton8 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton9 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDay = new System.Windows.Forms.Label();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dashboard";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(730, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar.Controls.Add(this.btnMenu);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Controls.Add(this.bunifuFlatButton8);
            this.sidebar.Controls.Add(this.bunifuFlatButton7);
            this.sidebar.Controls.Add(this.label3);
            this.sidebar.Controls.Add(this.label2);
            this.sidebar.Controls.Add(this.bunifuFlatButton6);
            this.sidebar.Controls.Add(this.bunifuFlatButton5);
            this.sidebar.Controls.Add(this.bunifuFlatButton4);
            this.sidebar.Controls.Add(this.bunifuFlatButton3);
            this.sidebar.Controls.Add(this.bunifuFlatButton2);
            this.sidebar.Controls.Add(this.bunifuFlatButton1);
            this.animator.SetDecoration(this.sidebar, BunifuAnimatorNS.DecorationType.None);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 32);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(244, 495);
            this.sidebar.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblDay);
            this.panel4.Controls.Add(this.lblClock);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.imgLogo);
            this.panel4.Controls.Add(this.bunifuTileButton9);
            this.panel4.Controls.Add(this.bunifuTileButton8);
            this.panel4.Controls.Add(this.bunifuTileButton7);
            this.panel4.Controls.Add(this.bunifuTileButton6);
            this.panel4.Controls.Add(this.bunifuTileButton5);
            this.panel4.Controls.Add(this.bunifuTileButton4);
            this.panel4.Controls.Add(this.bunifuTileButton3);
            this.panel4.Controls.Add(this.bunifuTileButton2);
            this.panel4.Controls.Add(this.bunifuTileButton1);
            this.animator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(244, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 495);
            this.panel4.TabIndex = 0;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuTileButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Employees";
            this.bunifuTileButton1.Location = new System.Drawing.Point(54, 67);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 132);
            this.bunifuTileButton1.TabIndex = 3;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Departments";
            this.bunifuTileButton2.Location = new System.Drawing.Point(194, 70);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton2.TabIndex = 4;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuTileButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Users";
            this.bunifuTileButton3.Location = new System.Drawing.Point(334, 69);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton3.TabIndex = 5;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton4.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuTileButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 20;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 41;
            this.bunifuTileButton4.LabelText = "Projects";
            this.bunifuTileButton4.Location = new System.Drawing.Point(54, 210);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton4.TabIndex = 6;
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton5.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton5.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuTileButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 20;
            this.bunifuTileButton5.ImageZoom = 50;
            this.bunifuTileButton5.LabelPosition = 41;
            this.bunifuTileButton5.LabelText = "Attendance";
            this.bunifuTileButton5.Location = new System.Drawing.Point(194, 210);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton5.TabIndex = 7;
            // 
            // bunifuTileButton6
            // 
            this.bunifuTileButton6.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton6.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton6.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuTileButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton6.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton6.Image")));
            this.bunifuTileButton6.ImagePosition = 20;
            this.bunifuTileButton6.ImageZoom = 50;
            this.bunifuTileButton6.LabelPosition = 41;
            this.bunifuTileButton6.LabelText = "Reports";
            this.bunifuTileButton6.Location = new System.Drawing.Point(334, 210);
            this.bunifuTileButton6.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton6.Name = "bunifuTileButton6";
            this.bunifuTileButton6.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton6.TabIndex = 8;
            // 
            // bunifuTileButton7
            // 
            this.bunifuTileButton7.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton7.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton7.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuTileButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton7.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton7.Image")));
            this.bunifuTileButton7.ImagePosition = 20;
            this.bunifuTileButton7.ImageZoom = 50;
            this.bunifuTileButton7.LabelPosition = 41;
            this.bunifuTileButton7.LabelText = "Training";
            this.bunifuTileButton7.Location = new System.Drawing.Point(54, 350);
            this.bunifuTileButton7.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton7.Name = "bunifuTileButton7";
            this.bunifuTileButton7.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton7.TabIndex = 9;
            // 
            // bunifuTileButton8
            // 
            this.bunifuTileButton8.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton8.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton8.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuTileButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton8.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton8.Image")));
            this.bunifuTileButton8.ImagePosition = 20;
            this.bunifuTileButton8.ImageZoom = 50;
            this.bunifuTileButton8.LabelPosition = 41;
            this.bunifuTileButton8.LabelText = "Documents";
            this.bunifuTileButton8.Location = new System.Drawing.Point(194, 351);
            this.bunifuTileButton8.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton8.Name = "bunifuTileButton8";
            this.bunifuTileButton8.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton8.TabIndex = 10;
            // 
            // bunifuTileButton9
            // 
            this.bunifuTileButton9.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton9.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton9.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuTileButton9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton9.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton9.Image")));
            this.bunifuTileButton9.ImagePosition = 20;
            this.bunifuTileButton9.ImageZoom = 50;
            this.bunifuTileButton9.LabelPosition = 41;
            this.bunifuTileButton9.LabelText = "Payroll";
            this.bunifuTileButton9.Location = new System.Drawing.Point(334, 350);
            this.bunifuTileButton9.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton9.Name = "bunifuTileButton9";
            this.bunifuTileButton9.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton9.TabIndex = 11;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Employees";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 70);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Employees";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Department";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(-1, 117);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Text = "Department";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Personal Information";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(-1, 164);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "Personal Information";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Insights";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(-1, 211);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "Insights";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Payroll";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 258);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton5.TabIndex = 6;
            this.bunifuFlatButton5.Text = "Payroll";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Leave";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(-1, 305);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton6.TabIndex = 7;
            this.bunifuFlatButton6.Text = "Leave";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administrator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Logged in";
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.imgLogo, BunifuAnimatorNS.DecorationType.None);
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.ImageActive = null;
            this.imgLogo.Location = new System.Drawing.Point(54, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(131, 61);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 9;
            this.imgLogo.TabStop = false;
            this.imgLogo.Zoom = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.animator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "System Time:";
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Finance";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 352);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton7.TabIndex = 9;
            this.bunifuFlatButton7.Text = "Finance";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Settings";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(0, 399);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(244, 48);
            this.bunifuFlatButton8.TabIndex = 10;
            this.bunifuFlatButton8.Text = "Settings";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.animator.SetDecoration(this.lblClock, BunifuAnimatorNS.DecorationType.None);
            this.lblClock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(363, 21);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 15);
            this.lblClock.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.animator.SetDecoration(this.lblDay, BunifuAnimatorNS.DecorationType.None);
            this.lblDay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(363, 36);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(0, 15);
            this.lblDay.TabIndex = 13;
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 90D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 446);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.Gray;
            this.btnLogout.OnHovercolor = System.Drawing.Color.Gray;
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(244, 48);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.Black;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(11, 23);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(26, 27);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 12;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // animator
            // 
            this.animator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator.DefaultAnimation = animation1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 527);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton9;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton8;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton7;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton imgLogo;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDay;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private BunifuAnimatorNS.BunifuTransition animator;
    }
}