﻿namespace TouchSidesTechnicalAssessment
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUploadFile = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pnlShowResult = new System.Windows.Forms.Panel();
            this.txtHighestScore = new System.Windows.Forms.TextBox();
            this.lblHighestScoreH = new System.Windows.Forms.Label();
            this.txtMostSevenCharWord = new System.Windows.Forms.TextBox();
            this.lblMostSevenCharWordH = new System.Windows.Forms.Label();
            this.txtMostFrequentWord = new System.Windows.Forms.TextBox();
            this.lblHmostfreqword = new System.Windows.Forms.Label();
            this.ofdLoadFile = new System.Windows.Forms.OpenFileDialog();
            this.pnlUploadFile.SuspendLayout();
            this.pnlShowResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUploadFile
            // 
            this.pnlUploadFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUploadFile.Controls.Add(this.btnUpload);
            this.pnlUploadFile.Location = new System.Drawing.Point(12, 12);
            this.pnlUploadFile.Name = "pnlUploadFile";
            this.pnlUploadFile.Size = new System.Drawing.Size(776, 125);
            this.pnlUploadFile.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(631, 73);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(142, 49);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pnlShowResult
            // 
            this.pnlShowResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShowResult.Controls.Add(this.txtHighestScore);
            this.pnlShowResult.Controls.Add(this.lblHighestScoreH);
            this.pnlShowResult.Controls.Add(this.txtMostSevenCharWord);
            this.pnlShowResult.Controls.Add(this.lblMostSevenCharWordH);
            this.pnlShowResult.Controls.Add(this.txtMostFrequentWord);
            this.pnlShowResult.Controls.Add(this.lblHmostfreqword);
            this.pnlShowResult.Location = new System.Drawing.Point(12, 153);
            this.pnlShowResult.Name = "pnlShowResult";
            this.pnlShowResult.Size = new System.Drawing.Size(776, 216);
            this.pnlShowResult.TabIndex = 1;
            this.pnlShowResult.Visible = false;
            // 
            // txtHighestScore
            // 
            this.txtHighestScore.Enabled = false;
            this.txtHighestScore.Location = new System.Drawing.Point(358, 97);
            this.txtHighestScore.Name = "txtHighestScore";
            this.txtHighestScore.Size = new System.Drawing.Size(134, 27);
            this.txtHighestScore.TabIndex = 5;
            // 
            // lblHighestScoreH
            // 
            this.lblHighestScoreH.AutoSize = true;
            this.lblHighestScoreH.Location = new System.Drawing.Point(18, 97);
            this.lblHighestScoreH.Name = "lblHighestScoreH";
            this.lblHighestScoreH.Size = new System.Drawing.Size(273, 20);
            this.lblHighestScoreH.TabIndex = 4;
            this.lblHighestScoreH.Text = "Most Frequent Word (Seven Characters):";
            // 
            // txtMostSevenCharWord
            // 
            this.txtMostSevenCharWord.Enabled = false;
            this.txtMostSevenCharWord.Location = new System.Drawing.Point(358, 52);
            this.txtMostSevenCharWord.Name = "txtMostSevenCharWord";
            this.txtMostSevenCharWord.Size = new System.Drawing.Size(134, 27);
            this.txtMostSevenCharWord.TabIndex = 3;
            // 
            // lblMostSevenCharWordH
            // 
            this.lblMostSevenCharWordH.AutoSize = true;
            this.lblMostSevenCharWordH.Location = new System.Drawing.Point(18, 55);
            this.lblMostSevenCharWordH.Name = "lblMostSevenCharWordH";
            this.lblMostSevenCharWordH.Size = new System.Drawing.Size(273, 20);
            this.lblMostSevenCharWordH.TabIndex = 2;
            this.lblMostSevenCharWordH.Text = "Most Frequent Word (Seven Characters):";
            // 
            // txtMostFrequentWord
            // 
            this.txtMostFrequentWord.Enabled = false;
            this.txtMostFrequentWord.Location = new System.Drawing.Point(358, 8);
            this.txtMostFrequentWord.Name = "txtMostFrequentWord";
            this.txtMostFrequentWord.Size = new System.Drawing.Size(134, 27);
            this.txtMostFrequentWord.TabIndex = 1;
            // 
            // lblHmostfreqword
            // 
            this.lblHmostfreqword.AutoSize = true;
            this.lblHmostfreqword.Location = new System.Drawing.Point(18, 11);
            this.lblHmostfreqword.Name = "lblHmostfreqword";
            this.lblHmostfreqword.Size = new System.Drawing.Size(147, 20);
            this.lblHmostfreqword.TabIndex = 0;
            this.lblHmostfreqword.Text = "Most Frequent Word:";
            // 
            // ofdLoadFile
            // 
            this.ofdLoadFile.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.pnlShowResult);
            this.Controls.Add(this.pnlUploadFile);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.pnlUploadFile.ResumeLayout(false);
            this.pnlShowResult.ResumeLayout(false);
            this.pnlShowResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlUploadFile;
        private Button btnUpload;
        private Panel pnlShowResult;
        private OpenFileDialog ofdLoadFile;
        private TextBox txtMostFrequentWord;
        private Label lblHmostfreqword;
        private TextBox txtMostSevenCharWord;
        private Label lblMostSevenCharWordH;
        private TextBox txtHighestScore;
        private Label lblHighestScoreH;
    }
}