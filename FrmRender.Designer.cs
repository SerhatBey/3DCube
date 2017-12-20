namespace _DCubeNoGimbalLock
{
    partial class FrmRender
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tX = new System.Windows.Forms.TrackBar();
            this.tY = new System.Windows.Forms.TrackBar();
            this.tZ = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chFront = new System.Windows.Forms.CheckBox();
            this.gFilling = new System.Windows.Forms.GroupBox();
            this.chWires = new System.Windows.Forms.CheckBox();
            this.chBottom = new System.Windows.Forms.CheckBox();
            this.chTop = new System.Windows.Forms.CheckBox();
            this.chRight = new System.Windows.Forms.CheckBox();
            this.chBack = new System.Windows.Forms.CheckBox();
            this.chLeft = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).BeginInit();
            this.gFilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(335, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 407);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z:";
            // 
            // tX
            // 
            this.tX.AutoSize = false;
            this.tX.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tX.Location = new System.Drawing.Point(23, 7);
            this.tX.Maximum = 360;
            this.tX.Minimum = -360;
            this.tX.Name = "tX";
            this.tX.Size = new System.Drawing.Size(306, 19);
            this.tX.TabIndex = 10;
            this.tX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tX.Scroll += new System.EventHandler(this.tX_Scroll);
            // 
            // tY
            // 
            this.tY.AutoSize = false;
            this.tY.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tY.Location = new System.Drawing.Point(23, 32);
            this.tY.Maximum = 360;
            this.tY.Minimum = -360;
            this.tY.Name = "tY";
            this.tY.Size = new System.Drawing.Size(306, 19);
            this.tY.TabIndex = 11;
            this.tY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tY.Scroll += new System.EventHandler(this.tY_Scroll);
            // 
            // tZ
            // 
            this.tZ.AutoSize = false;
            this.tZ.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tZ.Location = new System.Drawing.Point(23, 57);
            this.tZ.Maximum = 360;
            this.tZ.Minimum = -360;
            this.tZ.Name = "tZ";
            this.tZ.Size = new System.Drawing.Size(306, 19);
            this.tZ.TabIndex = 12;
            this.tZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tZ.Scroll += new System.EventHandler(this.tZ_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(206, 272);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 33);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(8, 426);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(241, 16);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "C# KOD DÜNYAM (SERHAT ÞOS)";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chFront
            // 
            this.chFront.AutoSize = true;
            this.chFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chFront.Location = new System.Drawing.Point(16, 42);
            this.chFront.Name = "chFront";
            this.chFront.Size = new System.Drawing.Size(46, 20);
            this.chFront.TabIndex = 15;
            this.chFront.Text = "Ön";
            this.chFront.UseVisualStyleBackColor = true;
            this.chFront.CheckedChanged += new System.EventHandler(this.chFront_CheckedChanged);
            // 
            // gFilling
            // 
            this.gFilling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gFilling.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gFilling.Controls.Add(this.chWires);
            this.gFilling.Controls.Add(this.chBottom);
            this.gFilling.Controls.Add(this.chTop);
            this.gFilling.Controls.Add(this.chRight);
            this.gFilling.Controls.Add(this.chBack);
            this.gFilling.Controls.Add(this.chLeft);
            this.gFilling.Controls.Add(this.chFront);
            this.gFilling.Location = new System.Drawing.Point(206, 82);
            this.gFilling.Name = "gFilling";
            this.gFilling.Size = new System.Drawing.Size(123, 184);
            this.gFilling.TabIndex = 16;
            this.gFilling.TabStop = false;
            this.gFilling.Text = "Fill";
            // 
            // chWires
            // 
            this.chWires.AutoSize = true;
            this.chWires.Checked = true;
            this.chWires.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chWires.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chWires.Location = new System.Drawing.Point(8, 17);
            this.chWires.Name = "chWires";
            this.chWires.Size = new System.Drawing.Size(109, 19);
            this.chWires.TabIndex = 21;
            this.chWires.Text = "Kenarlarý Çiz";
            this.chWires.UseVisualStyleBackColor = true;
            this.chWires.CheckedChanged += new System.EventHandler(this.chWires_CheckedChanged);
            // 
            // chBottom
            // 
            this.chBottom.AutoSize = true;
            this.chBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chBottom.Location = new System.Drawing.Point(16, 158);
            this.chBottom.Name = "chBottom";
            this.chBottom.Size = new System.Drawing.Size(45, 20);
            this.chBottom.TabIndex = 20;
            this.chBottom.Text = "Alt";
            this.chBottom.UseVisualStyleBackColor = true;
            this.chBottom.CheckedChanged += new System.EventHandler(this.chBottom_CheckedChanged);
            // 
            // chTop
            // 
            this.chTop.AutoSize = true;
            this.chTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chTop.Location = new System.Drawing.Point(16, 132);
            this.chTop.Name = "chTop";
            this.chTop.Size = new System.Drawing.Size(50, 20);
            this.chTop.TabIndex = 19;
            this.chTop.Text = "Üst";
            this.chTop.UseVisualStyleBackColor = true;
            this.chTop.CheckedChanged += new System.EventHandler(this.chTop_CheckedChanged);
            // 
            // chRight
            // 
            this.chRight.AutoSize = true;
            this.chRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chRight.Location = new System.Drawing.Point(16, 106);
            this.chRight.Name = "chRight";
            this.chRight.Size = new System.Drawing.Size(55, 20);
            this.chRight.TabIndex = 18;
            this.chRight.Text = "Sað";
            this.chRight.UseVisualStyleBackColor = true;
            this.chRight.CheckedChanged += new System.EventHandler(this.chRight_CheckedChanged);
            // 
            // chBack
            // 
            this.chBack.AutoSize = true;
            this.chBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chBack.Location = new System.Drawing.Point(16, 68);
            this.chBack.Name = "chBack";
            this.chBack.Size = new System.Drawing.Size(59, 20);
            this.chBack.TabIndex = 16;
            this.chBack.Text = "Arka";
            this.chBack.UseVisualStyleBackColor = true;
            this.chBack.CheckedChanged += new System.EventHandler(this.chBack_CheckedChanged);
            // 
            // chLeft
            // 
            this.chLeft.AutoSize = true;
            this.chLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chLeft.Location = new System.Drawing.Point(16, 85);
            this.chLeft.Name = "chLeft";
            this.chLeft.Size = new System.Drawing.Size(50, 20);
            this.chLeft.TabIndex = 17;
            this.chLeft.Text = "Sol";
            this.chLeft.UseVisualStyleBackColor = true;
            this.chLeft.CheckedChanged += new System.EventHandler(this.chLeft_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tam Renk";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(891, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gFilling);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tZ);
            this.Controls.Add(this.tY);
            this.Controls.Add(this.tX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRender";
            this.Text = "3D ve Gölgeleme";
            this.Load += new System.EventHandler(this.FrmRender_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).EndInit();
            this.gFilling.ResumeLayout(false);
            this.gFilling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tX;
        private System.Windows.Forms.TrackBar tY;
        private System.Windows.Forms.TrackBar tZ;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chFront;
        private System.Windows.Forms.GroupBox gFilling;
        private System.Windows.Forms.CheckBox chBottom;
        private System.Windows.Forms.CheckBox chTop;
        private System.Windows.Forms.CheckBox chRight;
        private System.Windows.Forms.CheckBox chBack;
        private System.Windows.Forms.CheckBox chLeft;
        private System.Windows.Forms.CheckBox chWires;
        private System.Windows.Forms.Button button1;
    }
}

