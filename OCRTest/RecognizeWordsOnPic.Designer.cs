﻿namespace OCRTest
{
    partial class RecognizeWordsOnPic
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_recognizeButton = new System.Windows.Forms.Button();
            this.m_selectPictureButton = new System.Windows.Forms.Button();
            this.m_imagePathText = new System.Windows.Forms.TextBox();
            this.m_tipLabel = new System.Windows.Forms.Label();
            this.m_imagePathLabel = new System.Windows.Forms.Label();
            this.m_originalPictureBox = new System.Windows.Forms.PictureBox();
            this.picDig = new System.Windows.Forms.FolderBrowserDialog();
            this.m_resultTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_originalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.m_recognizeButton);
            this.panel1.Controls.Add(this.m_selectPictureButton);
            this.panel1.Controls.Add(this.m_imagePathText);
            this.panel1.Controls.Add(this.m_tipLabel);
            this.panel1.Controls.Add(this.m_imagePathLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 50);
            this.panel1.TabIndex = 0;
            // 
            // m_recognizeButton
            // 
            this.m_recognizeButton.Location = new System.Drawing.Point(1020, 13);
            this.m_recognizeButton.Name = "m_recognizeButton";
            this.m_recognizeButton.Size = new System.Drawing.Size(75, 23);
            this.m_recognizeButton.TabIndex = 3;
            this.m_recognizeButton.Text = "识别文字";
            this.m_recognizeButton.UseVisualStyleBackColor = true;
            this.m_recognizeButton.Click += new System.EventHandler(this.OnRecognizeButtonClick);
            // 
            // m_selectPictureButton
            // 
            this.m_selectPictureButton.Location = new System.Drawing.Point(644, 14);
            this.m_selectPictureButton.Name = "m_selectPictureButton";
            this.m_selectPictureButton.Size = new System.Drawing.Size(75, 23);
            this.m_selectPictureButton.TabIndex = 2;
            this.m_selectPictureButton.Text = "选择图片";
            this.m_selectPictureButton.UseVisualStyleBackColor = true;
            this.m_selectPictureButton.Click += new System.EventHandler(this.OnSelectPictureButtonClick);
            // 
            // m_imagePathText
            // 
            this.m_imagePathText.Location = new System.Drawing.Point(75, 15);
            this.m_imagePathText.Name = "m_imagePathText";
            this.m_imagePathText.Size = new System.Drawing.Size(570, 21);
            this.m_imagePathText.TabIndex = 1;
            // 
            // m_tipLabel
            // 
            this.m_tipLabel.AutoSize = true;
            this.m_tipLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.m_tipLabel.Location = new System.Drawing.Point(725, 18);
            this.m_tipLabel.Name = "m_tipLabel";
            this.m_tipLabel.Size = new System.Drawing.Size(185, 12);
            this.m_tipLabel.TabIndex = 0;
            this.m_tipLabel.Text = "选择图片或将图片拖入左侧图片框";
            // 
            // m_imagePathLabel
            // 
            this.m_imagePathLabel.AutoSize = true;
            this.m_imagePathLabel.Location = new System.Drawing.Point(12, 18);
            this.m_imagePathLabel.Name = "m_imagePathLabel";
            this.m_imagePathLabel.Size = new System.Drawing.Size(59, 12);
            this.m_imagePathLabel.TabIndex = 0;
            this.m_imagePathLabel.Text = "图片路径:";
            // 
            // m_originalPictureBox
            // 
            this.m_originalPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_originalPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_originalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_originalPictureBox.Location = new System.Drawing.Point(9, 61);
            this.m_originalPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.m_originalPictureBox.Name = "m_originalPictureBox";
            this.m_originalPictureBox.Size = new System.Drawing.Size(566, 550);
            this.m_originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_originalPictureBox.TabIndex = 1;
            this.m_originalPictureBox.TabStop = false;
            this.m_originalPictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // m_resultTextBox
            // 
            this.m_resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_resultTextBox.Location = new System.Drawing.Point(590, 61);
            this.m_resultTextBox.Name = "m_resultTextBox";
            this.m_resultTextBox.Size = new System.Drawing.Size(536, 550);
            this.m_resultTextBox.TabIndex = 2;
            this.m_resultTextBox.Text = "";
            // 
            // RecognizeWordsOnPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_resultTextBox);
            this.Controls.Add(this.m_originalPictureBox);
            this.MaximumSize = new System.Drawing.Size(1145, 662);
            this.MinimumSize = new System.Drawing.Size(1145, 662);
            this.Name = "RecognizeWordsOnPic";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片文字识别";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_originalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m_selectPictureButton;
        private System.Windows.Forms.TextBox m_imagePathText;
        private System.Windows.Forms.Label m_imagePathLabel;
        private System.Windows.Forms.PictureBox m_originalPictureBox;
        private System.Windows.Forms.FolderBrowserDialog picDig;
        private System.Windows.Forms.RichTextBox m_resultTextBox;
        private System.Windows.Forms.Label m_tipLabel;
        private System.Windows.Forms.Button m_recognizeButton;
    }
}
