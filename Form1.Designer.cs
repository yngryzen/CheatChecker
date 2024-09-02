namespace CheatChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.discordinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cheateravatar = new System.Windows.Forms.PictureBox();
            this.cheatername = new System.Windows.Forms.Label();
            this.cheatsused = new System.Windows.Forms.Label();
            this.cheaterdate = new System.Windows.Forms.Label();
            this.notcheater = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.discordegg = new System.Windows.Forms.Label();
            this.invalidid = new System.Windows.Forms.Label();
            this.Alts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cheateravatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(4, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discord ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // discordinput
            // 
            this.discordinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discordinput.Location = new System.Drawing.Point(4, 158);
            this.discordinput.Margin = new System.Windows.Forms.Padding(4);
            this.discordinput.Name = "discordinput";
            this.discordinput.Size = new System.Drawing.Size(240, 22);
            this.discordinput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(246, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cheateravatar
            // 
            this.cheateravatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("cheateravatar.ErrorImage")));
            this.cheateravatar.Image = ((System.Drawing.Image)(resources.GetObject("cheateravatar.Image")));
            this.cheateravatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("cheateravatar.InitialImage")));
            this.cheateravatar.Location = new System.Drawing.Point(-1, 0);
            this.cheateravatar.Name = "cheateravatar";
            this.cheateravatar.Size = new System.Drawing.Size(96, 99);
            this.cheateravatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheateravatar.TabIndex = 3;
            this.cheateravatar.TabStop = false;
            this.cheateravatar.WaitOnLoad = true;
            this.cheateravatar.Click += new System.EventHandler(this.cheateravatar_Click);
            // 
            // cheatername
            // 
            this.cheatername.AutoSize = true;
            this.cheatername.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatername.ForeColor = System.Drawing.Color.Purple;
            this.cheatername.Location = new System.Drawing.Point(101, 8);
            this.cheatername.Name = "cheatername";
            this.cheatername.Size = new System.Drawing.Size(73, 28);
            this.cheatername.TabIndex = 4;
            this.cheatername.Text = "Name";
            this.cheatername.Visible = false;
            // 
            // cheatsused
            // 
            this.cheatsused.AutoSize = true;
            this.cheatsused.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatsused.ForeColor = System.Drawing.Color.Purple;
            this.cheatsused.Location = new System.Drawing.Point(101, 36);
            this.cheatsused.Name = "cheatsused";
            this.cheatsused.Size = new System.Drawing.Size(109, 21);
            this.cheatsused.TabIndex = 5;
            this.cheatsused.Text = "Cheats Used:";
            this.cheatsused.Visible = false;
            // 
            // cheaterdate
            // 
            this.cheaterdate.AutoSize = true;
            this.cheaterdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheaterdate.ForeColor = System.Drawing.Color.Purple;
            this.cheaterdate.Location = new System.Drawing.Point(101, 57);
            this.cheaterdate.Name = "cheaterdate";
            this.cheaterdate.Size = new System.Drawing.Size(113, 21);
            this.cheaterdate.TabIndex = 6;
            this.cheaterdate.Text = "Last Cheated:";
            this.cheaterdate.Visible = false;
            // 
            // notcheater
            // 
            this.notcheater.AutoSize = true;
            this.notcheater.BackColor = System.Drawing.Color.Thistle;
            this.notcheater.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notcheater.ForeColor = System.Drawing.Color.DarkOrchid;
            this.notcheater.Location = new System.Drawing.Point(100, 8);
            this.notcheater.Name = "notcheater";
            this.notcheater.Size = new System.Drawing.Size(153, 28);
            this.notcheater.TabIndex = 7;
            this.notcheater.Text = "Not a Cheater";
            this.notcheater.Visible = false;
            this.notcheater.Click += new System.EventHandler(this.notcheater_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Made by Ryzenix";
            // 
            // discordegg
            // 
            this.discordegg.AutoSize = true;
            this.discordegg.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordegg.Location = new System.Drawing.Point(337, 128);
            this.discordegg.Name = "discordegg";
            this.discordegg.Size = new System.Drawing.Size(191, 28);
            this.discordegg.TabIndex = 10;
            this.discordegg.Text = "Discord: yngryzen";
            // 
            // invalidid
            // 
            this.invalidid.AutoSize = true;
            this.invalidid.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidid.ForeColor = System.Drawing.Color.Red;
            this.invalidid.Location = new System.Drawing.Point(3, 105);
            this.invalidid.Name = "invalidid";
            this.invalidid.Size = new System.Drawing.Size(207, 28);
            this.invalidid.TabIndex = 11;
            this.invalidid.Text = "ERROR: INVALID ID";
            this.invalidid.Visible = false;
            // 
            // Alts
            // 
            this.Alts.AutoSize = true;
            this.Alts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alts.Location = new System.Drawing.Point(101, 77);
            this.Alts.Name = "Alts";
            this.Alts.Size = new System.Drawing.Size(147, 22);
            this.Alts.TabIndex = 12;
            this.Alts.Text = "Has alt accounts.";
            this.Alts.Visible = false;
            this.Alts.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.invalidid);
            this.panel1.Controls.Add(this.discordegg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Alts);
            this.panel1.Controls.Add(this.notcheater);
            this.panel1.Controls.Add(this.cheaterdate);
            this.panel1.Controls.Add(this.cheatsused);
            this.panel1.Controls.Add(this.cheatername);
            this.panel1.Controls.Add(this.cheateravatar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.discordinput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 185);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(529, 182);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheatChecker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cheateravatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discordinput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox cheateravatar;
        private System.Windows.Forms.Label cheatername;
        private System.Windows.Forms.Label cheatsused;
        private System.Windows.Forms.Label cheaterdate;
        private System.Windows.Forms.Label notcheater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label discordegg;
        private System.Windows.Forms.Label invalidid;
        private System.Windows.Forms.Label Alts;
        private System.Windows.Forms.Panel panel1;
    }
}

