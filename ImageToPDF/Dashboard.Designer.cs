namespace ImageToPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.grpSourceFiles = new System.Windows.Forms.GroupBox();
            this.listSourceFiles = new System.Windows.Forms.ListBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpDestinationFile = new System.Windows.Forms.GroupBox();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.cbIsOpen = new System.Windows.Forms.CheckBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.myBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip_Status = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.isImageCompress = new System.Windows.Forms.CheckBox();
            this.grpSourceFiles.SuspendLayout();
            this.grpDestinationFile.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(565, 19);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Upload";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            this.myOpenFileDialog.Multiselect = true;
            this.myOpenFileDialog.Title = "Select Images";
            // 
            // mySaveFileDialog
            // 
            this.mySaveFileDialog.DefaultExt = "pdf";
            this.mySaveFileDialog.Filter = "PDF document (*.pdf)|*.pdf";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(565, 14);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 0;
            this.btnSaveFile.Text = "Choose Destination";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // grpSourceFiles
            // 
            this.grpSourceFiles.Controls.Add(this.listSourceFiles);
            this.grpSourceFiles.Controls.Add(this.btnPreview);
            this.grpSourceFiles.Controls.Add(this.btnDown);
            this.grpSourceFiles.Controls.Add(this.btnUp);
            this.grpSourceFiles.Controls.Add(this.btnClear);
            this.grpSourceFiles.Controls.Add(this.btnSelectFiles);
            this.grpSourceFiles.Location = new System.Drawing.Point(13, 12);
            this.grpSourceFiles.Name = "grpSourceFiles";
            this.grpSourceFiles.Size = new System.Drawing.Size(646, 219);
            this.grpSourceFiles.TabIndex = 0;
            this.grpSourceFiles.TabStop = false;
            this.grpSourceFiles.Text = "Source File(s)";
            // 
            // listSourceFiles
            // 
            this.listSourceFiles.FormattingEnabled = true;
            this.listSourceFiles.Location = new System.Drawing.Point(89, 20);
            this.listSourceFiles.Name = "listSourceFiles";
            this.listSourceFiles.Size = new System.Drawing.Size(470, 186);
            this.listSourceFiles.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(7, 79);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(7, 49);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(7, 18);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(565, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpDestinationFile
            // 
            this.grpDestinationFile.Controls.Add(this.txtDestinationPath);
            this.grpDestinationFile.Controls.Add(this.btnSaveFile);
            this.grpDestinationFile.Location = new System.Drawing.Point(13, 237);
            this.grpDestinationFile.Name = "grpDestinationFile";
            this.grpDestinationFile.Size = new System.Drawing.Size(646, 50);
            this.grpDestinationFile.TabIndex = 1;
            this.grpDestinationFile.TabStop = false;
            this.grpDestinationFile.Text = "Destination File";
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(7, 17);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.ReadOnly = true;
            this.txtDestinationPath.Size = new System.Drawing.Size(552, 20);
            this.txtDestinationPath.TabIndex = 0;
            // 
            // cbIsOpen
            // 
            this.cbIsOpen.AutoSize = true;
            this.cbIsOpen.Checked = true;
            this.cbIsOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsOpen.Location = new System.Drawing.Point(13, 294);
            this.cbIsOpen.Name = "cbIsOpen";
            this.cbIsOpen.Size = new System.Drawing.Size(213, 17);
            this.cbIsOpen.TabIndex = 2;
            this.cbIsOpen.Text = "Preview destination file after conversion";
            this.cbIsOpen.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(13, 332);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(646, 46);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert to PDF";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // myBackgroundWorker
            // 
            this.myBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.myBackgroundWorker_DoWork);
            this.myBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.myBackgroundWorker_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_ProgressBar,
            this.toolStrip_Status});
            this.toolStrip1.Location = new System.Drawing.Point(0, 404);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_ProgressBar
            // 
            this.toolStrip_ProgressBar.Name = "toolStrip_ProgressBar";
            this.toolStrip_ProgressBar.Size = new System.Drawing.Size(250, 22);
            // 
            // toolStrip_Status
            // 
            this.toolStrip_Status.Name = "toolStrip_Status";
            this.toolStrip_Status.Size = new System.Drawing.Size(0, 22);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Developed and Maintain by , ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(450, 385);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(212, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "";
            this.linkLabel1.Text = "Jenish Jadav (+91 9909277305)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // isImageCompress
            // 
            this.isImageCompress.AutoSize = true;
            this.isImageCompress.Checked = true;
            this.isImageCompress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isImageCompress.Location = new System.Drawing.Point(232, 294);
            this.isImageCompress.Name = "isImageCompress";
            this.isImageCompress.Size = new System.Drawing.Size(109, 17);
            this.isImageCompress.TabIndex = 3;
            this.isImageCompress.Text = "Compress Images";
            this.isImageCompress.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 429);
            this.Controls.Add(this.isImageCompress);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cbIsOpen);
            this.Controls.Add(this.grpDestinationFile);
            this.Controls.Add(this.grpSourceFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image to PDF Convertor";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.grpSourceFiles.ResumeLayout(false);
            this.grpDestinationFile.ResumeLayout(false);
            this.grpDestinationFile.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog mySaveFileDialog;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.GroupBox grpSourceFiles;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpDestinationFile;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.CheckBox cbIsOpen;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ListBox listSourceFiles;
        private System.ComponentModel.BackgroundWorker myBackgroundWorker;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStrip_ProgressBar;
        private System.Windows.Forms.ToolStripLabel toolStrip_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox isImageCompress;
    }
}

