namespace kalkul
{
    partial class main
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ButPunel = new System.Windows.Forms.Panel();
            this.ButtonErase = new System.Windows.Forms.Button();
            this.ButtonEraseAll = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ButtonShare = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.ButPunel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.pictureBox3);
            this.TopPanel.Controls.Add(this.pictureBox2);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(384, 47);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(0, 47);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(384, 58);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButPunel
            // 
            this.ButPunel.BackColor = System.Drawing.Color.White;
            this.ButPunel.Controls.Add(this.Button0);
            this.ButPunel.Controls.Add(this.ButtonPoint);
            this.ButPunel.Controls.Add(this.ButtonEquals);
            this.ButPunel.Controls.Add(this.ButtonAdd);
            this.ButPunel.Controls.Add(this.Button3);
            this.ButPunel.Controls.Add(this.Button2);
            this.ButPunel.Controls.Add(this.Button1);
            this.ButPunel.Controls.Add(this.ButtonSubtract);
            this.ButPunel.Controls.Add(this.Button6);
            this.ButPunel.Controls.Add(this.Button5);
            this.ButPunel.Controls.Add(this.Button4);
            this.ButPunel.Controls.Add(this.ButtonMultiply);
            this.ButPunel.Controls.Add(this.Button9);
            this.ButPunel.Controls.Add(this.Button8);
            this.ButPunel.Controls.Add(this.Button7);
            this.ButPunel.Controls.Add(this.ButtonShare);
            this.ButPunel.Controls.Add(this.ButtonPercent);
            this.ButPunel.Controls.Add(this.ButtonEraseAll);
            this.ButPunel.Controls.Add(this.ButtonErase);
            this.ButPunel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButPunel.Location = new System.Drawing.Point(0, 105);
            this.ButPunel.Name = "ButPunel";
            this.ButPunel.Size = new System.Drawing.Size(384, 450);
            this.ButPunel.TabIndex = 1;
            // 
            // ButtonErase
            // 
            this.ButtonErase.FlatAppearance.BorderSize = 0;
            this.ButtonErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonErase.Location = new System.Drawing.Point(12, 6);
            this.ButtonErase.Name = "ButtonErase";
            this.ButtonErase.Size = new System.Drawing.Size(85, 85);
            this.ButtonErase.TabIndex = 0;
            this.ButtonErase.Text = "C";
            this.ButtonErase.UseVisualStyleBackColor = true;
            this.ButtonErase.Click += new System.EventHandler(this.ButtonErase_Click);
            // 
            // ButtonEraseAll
            // 
            this.ButtonEraseAll.FlatAppearance.BorderSize = 0;
            this.ButtonEraseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEraseAll.Location = new System.Drawing.Point(105, 6);
            this.ButtonEraseAll.Name = "ButtonEraseAll";
            this.ButtonEraseAll.Size = new System.Drawing.Size(85, 85);
            this.ButtonEraseAll.TabIndex = 1;
            this.ButtonEraseAll.Text = "CE";
            this.ButtonEraseAll.UseVisualStyleBackColor = true;
            this.ButtonEraseAll.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.FlatAppearance.BorderSize = 0;
            this.ButtonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPercent.Location = new System.Drawing.Point(196, 6);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(85, 85);
            this.ButtonPercent.TabIndex = 2;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonShare
            // 
            this.ButtonShare.FlatAppearance.BorderSize = 0;
            this.ButtonShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShare.Location = new System.Drawing.Point(287, 6);
            this.ButtonShare.Name = "ButtonShare";
            this.ButtonShare.Size = new System.Drawing.Size(85, 85);
            this.ButtonShare.TabIndex = 3;
            this.ButtonShare.Text = "/";
            this.ButtonShare.UseVisualStyleBackColor = true;
            this.ButtonShare.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Button7
            // 
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Location = new System.Drawing.Point(12, 97);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(85, 85);
            this.Button7.TabIndex = 4;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Button8
            // 
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Location = new System.Drawing.Point(105, 97);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(85, 85);
            this.Button8.TabIndex = 5;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Button9
            // 
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Location = new System.Drawing.Point(196, 97);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(85, 85);
            this.Button9.TabIndex = 6;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.FlatAppearance.BorderSize = 0;
            this.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultiply.Location = new System.Drawing.Point(287, 97);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(85, 85);
            this.ButtonMultiply.TabIndex = 7;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Button4
            // 
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Location = new System.Drawing.Point(12, 188);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(85, 85);
            this.Button4.TabIndex = 8;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Button5
            // 
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Location = new System.Drawing.Point(105, 188);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(85, 85);
            this.Button5.TabIndex = 9;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Button6
            // 
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Location = new System.Drawing.Point(196, 188);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(85, 85);
            this.Button6.TabIndex = 10;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.FlatAppearance.BorderSize = 0;
            this.ButtonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubtract.Location = new System.Drawing.Point(287, 188);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(85, 85);
            this.ButtonSubtract.TabIndex = 11;
            this.ButtonSubtract.Text = "-";
            this.ButtonSubtract.UseVisualStyleBackColor = true;
            this.ButtonSubtract.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Button1
            // 
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Location = new System.Drawing.Point(12, 279);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(85, 85);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Button2
            // 
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Location = new System.Drawing.Point(105, 279);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(85, 85);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Button3
            // 
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Location = new System.Drawing.Point(196, 279);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(85, 85);
            this.Button3.TabIndex = 14;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Location = new System.Drawing.Point(287, 279);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(85, 85);
            this.ButtonAdd.TabIndex = 15;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.FlatAppearance.BorderSize = 0;
            this.ButtonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEquals.Location = new System.Drawing.Point(287, 370);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(85, 85);
            this.ButtonEquals.TabIndex = 16;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.FlatAppearance.BorderSize = 0;
            this.ButtonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPoint.Location = new System.Drawing.Point(196, 370);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(85, 85);
            this.ButtonPoint.TabIndex = 17;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            this.ButtonPoint.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Button0
            // 
            this.Button0.FlatAppearance.BorderSize = 0;
            this.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button0.Location = new System.Drawing.Point(12, 370);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(178, 85);
            this.Button0.TabIndex = 18;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::kalkul.Properties.Resources.ButtonChange;
            this.pictureBox3.Location = new System.Drawing.Point(237, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::kalkul.Properties.Resources.ButtonSvorachivanie;
            this.pictureBox2.Location = new System.Drawing.Point(287, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::kalkul.Properties.Resources.ButtonClose;
            this.pictureBox1.Location = new System.Drawing.Point(339, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.ButPunel);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.TopPanel.ResumeLayout(false);
            this.ButPunel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Panel ButPunel;
        private System.Windows.Forms.Button ButtonErase;
        private System.Windows.Forms.Button ButtonShare;
        private System.Windows.Forms.Button ButtonPercent;
        private System.Windows.Forms.Button ButtonEraseAll;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button ButtonSubtract;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

