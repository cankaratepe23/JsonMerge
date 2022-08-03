using System.ComponentModel;

namespace JsonMerge
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblOriginalFilePath = new System.Windows.Forms.Label();
            this.btnOriginalFileBrowse = new System.Windows.Forms.Button();
            this.txtOriginalFilePath = new System.Windows.Forms.TextBox();
            this.pnlOriginalFile = new System.Windows.Forms.Panel();
            this.pnlCompareFile = new System.Windows.Forms.Panel();
            this.txtCompareFilePath = new System.Windows.Forms.TextBox();
            this.btnCompareFileBrowse = new System.Windows.Forms.Button();
            this.lblCompareFilePath = new System.Windows.Forms.Label();
            this.btnCompareFiles = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlOriginalFile.SuspendLayout();
            this.pnlCompareFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOriginalFilePath
            // 
            this.lblOriginalFilePath.AutoSize = true;
            this.lblOriginalFilePath.Location = new System.Drawing.Point(8, 5);
            this.lblOriginalFilePath.Name = "lblOriginalFilePath";
            this.lblOriginalFilePath.Size = new System.Drawing.Size(71, 13);
            this.lblOriginalFilePath.TabIndex = 0;
            this.lblOriginalFilePath.Text = "Orijinal Dosya";
            // 
            // btnOriginalFileBrowse
            // 
            this.btnOriginalFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOriginalFileBrowse.Location = new System.Drawing.Point(367, 19);
            this.btnOriginalFileBrowse.Name = "btnOriginalFileBrowse";
            this.btnOriginalFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnOriginalFileBrowse.TabIndex = 1;
            this.btnOriginalFileBrowse.Text = "Gözat...";
            this.btnOriginalFileBrowse.UseVisualStyleBackColor = true;
            this.btnOriginalFileBrowse.Click += new System.EventHandler(this.btnOriginalFileBrowse_Click);
            // 
            // txtOriginalFilePath
            // 
            this.txtOriginalFilePath.Location = new System.Drawing.Point(8, 21);
            this.txtOriginalFilePath.Name = "txtOriginalFilePath";
            this.txtOriginalFilePath.Size = new System.Drawing.Size(353, 20);
            this.txtOriginalFilePath.TabIndex = 2;
            this.txtOriginalFilePath.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtOriginalFilePath.Leave += new System.EventHandler(this.TextBoxPath_Leave);
            // 
            // pnlOriginalFile
            // 
            this.pnlOriginalFile.AllowDrop = true;
            this.pnlOriginalFile.Controls.Add(this.txtOriginalFilePath);
            this.pnlOriginalFile.Controls.Add(this.lblOriginalFilePath);
            this.pnlOriginalFile.Controls.Add(this.btnOriginalFileBrowse);
            this.pnlOriginalFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOriginalFile.Location = new System.Drawing.Point(0, 0);
            this.pnlOriginalFile.Name = "pnlOriginalFile";
            this.pnlOriginalFile.Padding = new System.Windows.Forms.Padding(5);
            this.pnlOriginalFile.Size = new System.Drawing.Size(450, 111);
            this.pnlOriginalFile.TabIndex = 3;
            this.pnlOriginalFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_DragDrop);
            this.pnlOriginalFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // pnlCompareFile
            // 
            this.pnlCompareFile.AllowDrop = true;
            this.pnlCompareFile.Controls.Add(this.txtCompareFilePath);
            this.pnlCompareFile.Controls.Add(this.btnCompareFileBrowse);
            this.pnlCompareFile.Controls.Add(this.lblCompareFilePath);
            this.pnlCompareFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCompareFile.Location = new System.Drawing.Point(494, 0);
            this.pnlCompareFile.Name = "pnlCompareFile";
            this.pnlCompareFile.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCompareFile.Size = new System.Drawing.Size(450, 111);
            this.pnlCompareFile.TabIndex = 4;
            this.pnlCompareFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_DragDrop);
            this.pnlCompareFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // txtCompareFilePath
            // 
            this.txtCompareFilePath.Location = new System.Drawing.Point(8, 21);
            this.txtCompareFilePath.Name = "txtCompareFilePath";
            this.txtCompareFilePath.Size = new System.Drawing.Size(353, 20);
            this.txtCompareFilePath.TabIndex = 5;
            this.txtCompareFilePath.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtCompareFilePath.Leave += new System.EventHandler(this.TextBoxPath_Leave);
            // 
            // btnCompareFileBrowse
            // 
            this.btnCompareFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompareFileBrowse.Location = new System.Drawing.Point(367, 19);
            this.btnCompareFileBrowse.Name = "btnCompareFileBrowse";
            this.btnCompareFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnCompareFileBrowse.TabIndex = 4;
            this.btnCompareFileBrowse.Text = "Gözat...";
            this.btnCompareFileBrowse.UseVisualStyleBackColor = true;
            this.btnCompareFileBrowse.Click += new System.EventHandler(this.btnCompareFileBrowse_Click);
            // 
            // lblCompareFilePath
            // 
            this.lblCompareFilePath.AutoSize = true;
            this.lblCompareFilePath.Location = new System.Drawing.Point(8, 5);
            this.lblCompareFilePath.Name = "lblCompareFilePath";
            this.lblCompareFilePath.Size = new System.Drawing.Size(112, 13);
            this.lblCompareFilePath.TabIndex = 3;
            this.lblCompareFilePath.Text = "Karşılaştırılacak Dosya";
            // 
            // btnCompareFiles
            // 
            this.btnCompareFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCompareFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCompareFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompareFiles.Location = new System.Drawing.Point(456, 18);
            this.btnCompareFiles.Name = "btnCompareFiles";
            this.btnCompareFiles.Size = new System.Drawing.Size(32, 23);
            this.btnCompareFiles.TabIndex = 5;
            this.btnCompareFiles.Text = "⇄";
            this.btnCompareFiles.UseVisualStyleBackColor = true;
            this.btnCompareFiles.Click += new System.EventHandler(this.btnCompareFiles_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "en.json5";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json5";
            this.saveFileDialog.FileName = "merged";
            this.saveFileDialog.Filter = "JSON5 Files|*.json5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 111);
            this.Controls.Add(this.btnCompareFiles);
            this.Controls.Add(this.pnlCompareFile);
            this.Controls.Add(this.pnlOriginalFile);
            this.MinimumSize = new System.Drawing.Size(640, 39);
            this.Name = "MainForm";
            this.Text = "JSON Merge";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.pnlOriginalFile.ResumeLayout(false);
            this.pnlOriginalFile.PerformLayout();
            this.pnlCompareFile.ResumeLayout(false);
            this.pnlCompareFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOriginalFilePath;
        private System.Windows.Forms.Button btnOriginalFileBrowse;
        private System.Windows.Forms.TextBox txtOriginalFilePath;
        private System.Windows.Forms.Panel pnlOriginalFile;
        private System.Windows.Forms.Panel pnlCompareFile;
        private System.Windows.Forms.TextBox txtCompareFilePath;
        private System.Windows.Forms.Button btnCompareFileBrowse;
        private System.Windows.Forms.Label lblCompareFilePath;
        private System.Windows.Forms.Button btnCompareFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}