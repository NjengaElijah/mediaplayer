namespace MediaPlayer
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblMedia = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPlayPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinVol = new System.Windows.Forms.Label();
            this.trkVol = new Bunifu.Framework.UI.BunifuTrackbar();
            this.lblFullTime = new System.Windows.Forms.Label();
            this.lblProgressTime = new System.Windows.Forms.Label();
            this.trkTrack = new Bunifu.Framework.UI.BunifuTrackbar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelBody.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.panelLeft.Controls.Add(this.bunifuImageButton2);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.bunifuFlatButton2);
            this.panelLeft.Controls.Add(this.bunifuFlatButton1);
            this.bunifuTransition1.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(195, 544);
            this.panelLeft.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(159, 43);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 15;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Media Player";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 76);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Developed By : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Njenga Elijah";
            // 
            // pictureBox1
            // 
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::MediaPlayer.Properties.Resources.Koala;
            this.pictureBox1.Location = new System.Drawing.Point(4, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Playlist";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1, 188);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(200, 48);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "Playlist";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Open";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1, 135);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(200, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Open";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.panelHeader.Controls.Add(this.panel3);
            this.panelHeader.Controls.Add(this.lblMedia);
            this.bunifuTransition1.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(195, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(726, 40);
            this.panelHeader.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.bunifuImageButton4);
            this.panel3.Controls.Add(this.bunifuImageButton3);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(604, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 40);
            this.panel3.TabIndex = 7;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton4.Image = global::MediaPlayer.Properties.Resources.minimize;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(31, 31);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton4.TabIndex = 6;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 15;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click_1);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = global::MediaPlayer.Properties.Resources.maximize;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(40, 3);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(36, 31);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 6;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 15;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(82, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(31, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 15;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.lblMedia, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblMedia, BunifuAnimatorNS.DecorationType.None);
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMedia.ForeColor = System.Drawing.Color.White;
            this.lblMedia.Location = new System.Drawing.Point(6, 12);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 17);
            this.lblMedia.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panel1);
            this.panelBody.Controls.Add(this.axWindowsMediaPlayer1);
            this.bunifuTransition1.SetDecoration(this.panelBody, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelBody, BunifuAnimatorNS.DecorationType.None);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(195, 40);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(726, 504);
            this.panelBody.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPlayPause);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMinVol);
            this.panel1.Controls.Add(this.trkVol);
            this.panel1.Controls.Add(this.lblFullTime);
            this.panel1.Controls.Add(this.lblProgressTime);
            this.panel1.Controls.Add(this.trkTrack);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 76);
            this.panel1.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.btnNext, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnNext, BunifuAnimatorNS.DecorationType.None);
            this.btnNext.Image = global::MediaPlayer.Properties.Resources.next;
            this.btnNext.ImageActive = null;
            this.btnNext.Location = new System.Drawing.Point(185, 34);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 30);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 4;
            this.btnNext.TabStop = false;
            this.btnNext.Zoom = 15;
            this.btnNext.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.btnPlayPause, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnPlayPause, BunifuAnimatorNS.DecorationType.None);
            this.btnPlayPause.Image = global::MediaPlayer.Properties.Resources.play1;
            this.btnPlayPause.ImageActive = null;
            this.btnPlayPause.Location = new System.Drawing.Point(134, 34);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(45, 31);
            this.btnPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlayPause.TabIndex = 4;
            this.btnPlayPause.TabStop = false;
            this.btnPlayPause.Zoom = 15;
            this.btnPlayPause.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.btnPrevious, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnPrevious, BunifuAnimatorNS.DecorationType.None);
            this.btnPrevious.Image = global::MediaPlayer.Properties.Resources.prev;
            this.btnPrevious.ImageActive = null;
            this.btnPrevious.Location = new System.Drawing.Point(83, 34);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 30);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Zoom = 15;
            this.btnPrevious.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(668, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "400";
            // 
            // lblMinVol
            // 
            this.lblMinVol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinVol.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.lblMinVol, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblMinVol, BunifuAnimatorNS.DecorationType.None);
            this.lblMinVol.ForeColor = System.Drawing.Color.White;
            this.lblMinVol.Location = new System.Drawing.Point(484, 42);
            this.lblMinVol.Name = "lblMinVol";
            this.lblMinVol.Size = new System.Drawing.Size(25, 13);
            this.lblMinVol.TabIndex = 3;
            this.lblMinVol.Text = "100";
            // 
            // trkVol
            // 
            this.trkVol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkVol.BackColor = System.Drawing.Color.Transparent;
            this.trkVol.BackgroudColor = System.Drawing.Color.Gainsboro;
            this.trkVol.BorderRadius = 0;
            this.bunifuTransition2.SetDecoration(this.trkVol, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.trkVol, BunifuAnimatorNS.DecorationType.None);
            this.trkVol.IndicatorColor = System.Drawing.Color.White;
            this.trkVol.Location = new System.Drawing.Point(515, 35);
            this.trkVol.MaximumValue = 400;
            this.trkVol.Name = "trkVol";
            this.trkVol.Size = new System.Drawing.Size(147, 30);
            this.trkVol.SliderRadius = 200;
            this.trkVol.TabIndex = 1;
            this.trkVol.Value = 100;
            this.trkVol.ValueChanged += new System.EventHandler(this.bunifuTrackbar2_ValueChanged);
            // 
            // lblFullTime
            // 
            this.lblFullTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullTime.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.lblFullTime, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblFullTime, BunifuAnimatorNS.DecorationType.None);
            this.lblFullTime.ForeColor = System.Drawing.Color.White;
            this.lblFullTime.Location = new System.Drawing.Point(665, 11);
            this.lblFullTime.Name = "lblFullTime";
            this.lblFullTime.Size = new System.Drawing.Size(49, 13);
            this.lblFullTime.TabIndex = 1;
            this.lblFullTime.Text = "00:00:00";
            // 
            // lblProgressTime
            // 
            this.lblProgressTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProgressTime.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.lblProgressTime, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblProgressTime, BunifuAnimatorNS.DecorationType.None);
            this.lblProgressTime.ForeColor = System.Drawing.Color.White;
            this.lblProgressTime.Location = new System.Drawing.Point(3, 11);
            this.lblProgressTime.Name = "lblProgressTime";
            this.lblProgressTime.Size = new System.Drawing.Size(49, 13);
            this.lblProgressTime.TabIndex = 1;
            this.lblProgressTime.Text = "00:00:00";
            // 
            // trkTrack
            // 
            this.trkTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trkTrack.BackColor = System.Drawing.Color.Transparent;
            this.trkTrack.BackgroudColor = System.Drawing.Color.White;
            this.trkTrack.BorderRadius = 0;
            this.bunifuTransition2.SetDecoration(this.trkTrack, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.trkTrack, BunifuAnimatorNS.DecorationType.None);
            this.trkTrack.IndicatorColor = System.Drawing.SystemColors.HotTrack;
            this.trkTrack.Location = new System.Drawing.Point(58, 6);
            this.trkTrack.MaximumValue = 100;
            this.trkTrack.Name = "trkTrack";
            this.trkTrack.Size = new System.Drawing.Size(604, 30);
            this.trkTrack.SliderRadius = 150;
            this.trkTrack.TabIndex = 0;
            this.trkTrack.Value = 0;
            this.trkTrack.ValueChanged += new System.EventHandler(this.bunifuTrackbar1_ValueChanged);
            this.trkTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trkTrack_MouseDown);
            this.trkTrack.MouseHover += new System.EventHandler(this.trkTrack_MouseHover);
            // 
            // axWindowsMediaPlayer1
            // 
            this.bunifuTransition1.SetDecoration(this.axWindowsMediaPlayer1, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(726, 504);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer1_MediaChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblMedia;
            this.bunifuDragControl2.Vertical = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 400;
            this.bunifuElipse2.TargetControl = this.pictureBox1;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 544);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeft);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label lblMedia;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTrackbar trkTrack;
        private System.Windows.Forms.Label lblProgressTime;
        private System.Windows.Forms.Label lblFullTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Label lblMinVol;
        private Bunifu.Framework.UI.BunifuTrackbar trkVol;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnPlayPause;
        private Bunifu.Framework.UI.BunifuImageButton btnPrevious;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

