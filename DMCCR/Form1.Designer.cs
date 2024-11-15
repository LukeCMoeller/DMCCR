namespace DMCCR
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
            this.UxOpenImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UXedit = new System.Windows.Forms.Button();
            this.UXdmcList = new System.Windows.Forms.ListBox();
            this.ColorExample = new System.Windows.Forms.Panel();
            this.DMCHexColorName = new System.Windows.Forms.TextBox();
            this.border = new System.Windows.Forms.Panel();
            this.ColorExampleImage = new System.Windows.Forms.Panel();
            this.HexColorName = new System.Windows.Forms.TextBox();
            this.Border2 = new System.Windows.Forms.Panel();
            this.UxFilteredColors = new System.Windows.Forms.ListBox();
            this.ColorExampleFiltered = new System.Windows.Forms.Panel();
            this.FilteredHexColorName = new System.Windows.Forms.TextBox();
            this.border3 = new System.Windows.Forms.Panel();
            this.Tab1 = new System.Windows.Forms.Button();
            this.Tab2 = new System.Windows.Forms.Button();
            this.UxSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ColorExample.SuspendLayout();
            this.ColorExampleImage.SuspendLayout();
            this.ColorExampleFiltered.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxOpenImage
            // 
            this.UxOpenImage.Location = new System.Drawing.Point(25, 484);
            this.UxOpenImage.Name = "UxOpenImage";
            this.UxOpenImage.Size = new System.Drawing.Size(188, 99);
            this.UxOpenImage.TabIndex = 0;
            this.UxOpenImage.Text = "Open Image";
            this.UxOpenImage.UseVisualStyleBackColor = true;
            this.UxOpenImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(25, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // UXedit
            // 
            this.UXedit.Location = new System.Drawing.Point(440, 484);
            this.UXedit.Name = "UXedit";
            this.UXedit.Size = new System.Drawing.Size(188, 99);
            this.UXedit.TabIndex = 2;
            this.UXedit.Text = "Convert";
            this.UXedit.UseVisualStyleBackColor = true;
            this.UXedit.Click += new System.EventHandler(this.Convert_Click);
            // 
            // UXdmcList
            // 
            this.UXdmcList.FormattingEnabled = true;
            this.UXdmcList.Location = new System.Drawing.Point(866, 12);
            this.UXdmcList.Name = "UXdmcList";
            this.UXdmcList.Size = new System.Drawing.Size(132, 277);
            this.UXdmcList.TabIndex = 5;
            this.UXdmcList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ColorExample
            // 
            this.ColorExample.Controls.Add(this.DMCHexColorName);
            this.ColorExample.Location = new System.Drawing.Point(651, 17);
            this.ColorExample.Name = "ColorExample";
            this.ColorExample.Size = new System.Drawing.Size(200, 120);
            this.ColorExample.TabIndex = 4;
            // 
            // DMCHexColorName
            // 
            this.DMCHexColorName.BackColor = System.Drawing.SystemColors.Control;
            this.DMCHexColorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DMCHexColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.DMCHexColorName.Location = new System.Drawing.Point(0, 50);
            this.DMCHexColorName.Name = "DMCHexColorName";
            this.DMCHexColorName.ReadOnly = true;
            this.DMCHexColorName.Size = new System.Drawing.Size(200, 25);
            this.DMCHexColorName.TabIndex = 10;
            this.DMCHexColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.border.Location = new System.Drawing.Point(646, 12);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(210, 130);
            this.border.TabIndex = 6;
            // 
            // ColorExampleImage
            // 
            this.ColorExampleImage.Controls.Add(this.HexColorName);
            this.ColorExampleImage.Location = new System.Drawing.Point(651, 164);
            this.ColorExampleImage.Name = "ColorExampleImage";
            this.ColorExampleImage.Size = new System.Drawing.Size(200, 120);
            this.ColorExampleImage.TabIndex = 7;
            // 
            // HexColorName
            // 
            this.HexColorName.BackColor = System.Drawing.SystemColors.Control;
            this.HexColorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HexColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.HexColorName.Location = new System.Drawing.Point(0, 43);
            this.HexColorName.Name = "HexColorName";
            this.HexColorName.ReadOnly = true;
            this.HexColorName.Size = new System.Drawing.Size(200, 25);
            this.HexColorName.TabIndex = 9;
            this.HexColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Border2
            // 
            this.Border2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Border2.Location = new System.Drawing.Point(646, 159);
            this.Border2.Name = "Border2";
            this.Border2.Size = new System.Drawing.Size(210, 130);
            this.Border2.TabIndex = 8;
            // 
            // UxFilteredColors
            // 
            this.UxFilteredColors.FormattingEnabled = true;
            this.UxFilteredColors.Location = new System.Drawing.Point(866, 305);
            this.UxFilteredColors.Name = "UxFilteredColors";
            this.UxFilteredColors.Size = new System.Drawing.Size(132, 147);
            this.UxFilteredColors.TabIndex = 9;
            this.UxFilteredColors.SelectedIndexChanged += new System.EventHandler(this.UxFilteredColors_SelectedIndexChanged);
            // 
            // ColorExampleFiltered
            // 
            this.ColorExampleFiltered.Controls.Add(this.FilteredHexColorName);
            this.ColorExampleFiltered.Location = new System.Drawing.Point(651, 327);
            this.ColorExampleFiltered.Name = "ColorExampleFiltered";
            this.ColorExampleFiltered.Size = new System.Drawing.Size(200, 120);
            this.ColorExampleFiltered.TabIndex = 10;
            this.ColorExampleFiltered.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorExampleFiltered_Paint);
            // 
            // FilteredHexColorName
            // 
            this.FilteredHexColorName.BackColor = System.Drawing.SystemColors.Control;
            this.FilteredHexColorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilteredHexColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.FilteredHexColorName.Location = new System.Drawing.Point(0, 43);
            this.FilteredHexColorName.Name = "FilteredHexColorName";
            this.FilteredHexColorName.ReadOnly = true;
            this.FilteredHexColorName.Size = new System.Drawing.Size(200, 25);
            this.FilteredHexColorName.TabIndex = 9;
            this.FilteredHexColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.border3.Location = new System.Drawing.Point(646, 322);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(210, 130);
            this.border3.TabIndex = 11;
            // 
            // Tab1
            // 
            this.Tab1.Enabled = false;
            this.Tab1.Location = new System.Drawing.Point(78, 28);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(74, 23);
            this.Tab1.TabIndex = 14;
            this.Tab1.Text = "Unedited";
            this.Tab1.UseVisualStyleBackColor = true;
            this.Tab1.Click += new System.EventHandler(this.Tab1_Click);
            // 
            // Tab2
            // 
            this.Tab2.Enabled = false;
            this.Tab2.Location = new System.Drawing.Point(402, 28);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(74, 23);
            this.Tab2.TabIndex = 15;
            this.Tab2.Text = "Edited";
            this.Tab2.UseVisualStyleBackColor = true;
            this.Tab2.Click += new System.EventHandler(this.Tab2_Click);
            // 
            // UxSave
            // 
            this.UxSave.Location = new System.Drawing.Point(813, 503);
            this.UxSave.Name = "UxSave";
            this.UxSave.Size = new System.Drawing.Size(185, 61);
            this.UxSave.TabIndex = 16;
            this.UxSave.Text = "SAVE";
            this.UxSave.UseVisualStyleBackColor = true;
            this.UxSave.Click += new System.EventHandler(this.UxSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(693, 496);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UxSave);
            this.Controls.Add(this.Tab2);
            this.Controls.Add(this.Tab1);
            this.Controls.Add(this.ColorExampleFiltered);
            this.Controls.Add(this.border3);
            this.Controls.Add(this.UxFilteredColors);
            this.Controls.Add(this.ColorExampleImage);
            this.Controls.Add(this.Border2);
            this.Controls.Add(this.ColorExample);
            this.Controls.Add(this.border);
            this.Controls.Add(this.UXdmcList);
            this.Controls.Add(this.UXedit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UxOpenImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ColorExample.ResumeLayout(false);
            this.ColorExample.PerformLayout();
            this.ColorExampleImage.ResumeLayout(false);
            this.ColorExampleImage.PerformLayout();
            this.ColorExampleFiltered.ResumeLayout(false);
            this.ColorExampleFiltered.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UxOpenImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UXedit;
        private System.Windows.Forms.ListBox UXdmcList;
        private System.Windows.Forms.Panel ColorExample;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Panel ColorExampleImage;
        private System.Windows.Forms.Panel Border2;
        private System.Windows.Forms.TextBox HexColorName;
        private System.Windows.Forms.TextBox DMCHexColorName;
        private System.Windows.Forms.ListBox UxFilteredColors;
        private System.Windows.Forms.Panel ColorExampleFiltered;
        private System.Windows.Forms.TextBox FilteredHexColorName;
        private System.Windows.Forms.Panel border3;
        private System.Windows.Forms.Button Tab1;
        private System.Windows.Forms.Button Tab2;
        private System.Windows.Forms.Button UxSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

