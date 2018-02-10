namespace ImgToAsciiArt
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Open_Image_Bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Save_Path_Bt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Start_Bt = new System.Windows.Forms.Button();
            this.Size_Tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_Image_Bt
            // 
            this.Open_Image_Bt.Location = new System.Drawing.Point(12, 463);
            this.Open_Image_Bt.Name = "Open_Image_Bt";
            this.Open_Image_Bt.Size = new System.Drawing.Size(132, 37);
            this.Open_Image_Bt.TabIndex = 0;
            this.Open_Image_Bt.Text = "Open Image";
            this.Open_Image_Bt.UseVisualStyleBackColor = true;
            this.Open_Image_Bt.Click += new System.EventHandler(this.Open_Image_Bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Save_Path_Bt
            // 
            this.Save_Path_Bt.Location = new System.Drawing.Point(150, 463);
            this.Save_Path_Bt.Name = "Save_Path_Bt";
            this.Save_Path_Bt.Size = new System.Drawing.Size(132, 37);
            this.Save_Path_Bt.TabIndex = 2;
            this.Save_Path_Bt.Text = "Save Path";
            this.Save_Path_Bt.UseVisualStyleBackColor = true;
            this.Save_Path_Bt.Click += new System.EventHandler(this.Save_Path_Bt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(289, 463);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(392, 37);
            this.textBox1.TabIndex = 3;
            // 
            // Start_Bt
            // 
            this.Start_Bt.Location = new System.Drawing.Point(12, 549);
            this.Start_Bt.Name = "Start_Bt";
            this.Start_Bt.Size = new System.Drawing.Size(270, 37);
            this.Start_Bt.TabIndex = 4;
            this.Start_Bt.Text = "Start";
            this.Start_Bt.UseVisualStyleBackColor = true;
            this.Start_Bt.Click += new System.EventHandler(this.Start_Bt_Click);
            // 
            // Size_Tb
            // 
            this.Size_Tb.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Size_Tb.Location = new System.Drawing.Point(346, 506);
            this.Size_Tb.Multiline = true;
            this.Size_Tb.Name = "Size_Tb";
            this.Size_Tb.Size = new System.Drawing.Size(132, 37);
            this.Size_Tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(285, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Image\'s Width:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(166, 507);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(116, 36);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 598);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Size_Tb);
            this.Controls.Add(this.Start_Bt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Save_Path_Bt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Open_Image_Bt);
            this.Name = "Form1";
            this.Text = "Image To Ascii Art";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_Image_Bt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Save_Path_Bt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Start_Bt;
        private System.Windows.Forms.TextBox Size_Tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

