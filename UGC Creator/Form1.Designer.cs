namespace UGC_Creator
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.UgcDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.XmlDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.ugcLocation = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.XMLLocation = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.ListBox();
            this.txtDone = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XmlDialog
            // 
            this.XmlDialog.FileName = "openFileDialog1";
            this.XmlDialog.Filter = "MAME XML file|*.xml";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder for New UGC Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ugcLocation
            // 
            this.ugcLocation.AutoEllipsis = true;
            this.ugcLocation.Location = new System.Drawing.Point(12, 50);
            this.ugcLocation.Name = "ugcLocation";
            this.ugcLocation.Size = new System.Drawing.Size(260, 44);
            this.ugcLocation.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Select MAME XML File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // XMLLocation
            // 
            this.XMLLocation.AutoEllipsis = true;
            this.XMLLocation.Location = new System.Drawing.Point(12, 127);
            this.XMLLocation.Name = "XMLLocation";
            this.XMLLocation.Size = new System.Drawing.Size(260, 44);
            this.XMLLocation.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(178, 174);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 39);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Files";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 174);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // infoBox
            // 
            this.infoBox.FormattingEnabled = true;
            this.infoBox.HorizontalScrollbar = true;
            this.infoBox.Location = new System.Drawing.Point(12, 237);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(260, 225);
            this.infoBox.TabIndex = 7;
            // 
            // txtDone
            // 
            this.txtDone.AutoSize = true;
            this.txtDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDone.Location = new System.Drawing.Point(8, 471);
            this.txtDone.MinimumSize = new System.Drawing.Size(100, 0);
            this.txtDone.Name = "txtDone";
            this.txtDone.Size = new System.Drawing.Size(100, 20);
            this.txtDone.TabIndex = 8;
            this.txtDone.Text = "DONE!";
            this.txtDone.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Open UGC Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 500);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDone);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.XMLLocation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ugcLocation);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UGC Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog UgcDialog;
        private System.Windows.Forms.OpenFileDialog XmlDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ugcLocation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label XMLLocation;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox infoBox;
        private System.Windows.Forms.Label txtDone;
        private System.Windows.Forms.Button button3;
    }
}

