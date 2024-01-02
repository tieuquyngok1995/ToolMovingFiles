
namespace ToolMovingFiles
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCopyPath1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDesFolder1 = new System.Windows.Forms.Button();
            this.txtDesFolder1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSouFolder1 = new System.Windows.Forms.Button();
            this.txtSouFolder1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCopyPath2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDesFolder2 = new System.Windows.Forms.Button();
            this.txtDesFolder2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSouFolder2 = new System.Windows.Forms.Button();
            this.txtSouFolder2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkCopyPath3 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btDesFolder3 = new System.Windows.Forms.Button();
            this.txtDesFolder3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSouFolder3 = new System.Windows.Forms.Button();
            this.txtSouFolder3 = new System.Windows.Forms.TextBox();
            this.progressBarFolder = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCopyPath1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btDesFolder1);
            this.groupBox1.Controls.Add(this.txtDesFolder1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btSouFolder1);
            this.groupBox1.Controls.Add(this.txtSouFolder1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path Moving Files";
            // 
            // chkCopyPath1
            // 
            this.chkCopyPath1.AutoSize = true;
            this.chkCopyPath1.Location = new System.Drawing.Point(112, 21);
            this.chkCopyPath1.Name = "chkCopyPath1";
            this.chkCopyPath1.Size = new System.Drawing.Size(15, 14);
            this.chkCopyPath1.TabIndex = 9;
            this.chkCopyPath1.UseVisualStyleBackColor = true;
            this.chkCopyPath1.CheckedChanged += new System.EventHandler(this.chkCopyPath1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destination Folder";
            // 
            // btDesFolder1
            // 
            this.btDesFolder1.Image = global::ToolMovingFiles.Properties.Resources.icon_folder_16x16;
            this.btDesFolder1.Location = new System.Drawing.Point(386, 45);
            this.btDesFolder1.Name = "btDesFolder1";
            this.btDesFolder1.Size = new System.Drawing.Size(26, 24);
            this.btDesFolder1.TabIndex = 4;
            this.btDesFolder1.UseVisualStyleBackColor = true;
            this.btDesFolder1.Click += new System.EventHandler(this.btDesFolder1_Click);
            // 
            // txtDesFolder1
            // 
            this.txtDesFolder1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDesFolder1.Location = new System.Drawing.Point(131, 45);
            this.txtDesFolder1.Name = "txtDesFolder1";
            this.txtDesFolder1.Size = new System.Drawing.Size(250, 24);
            this.txtDesFolder1.TabIndex = 3;
            this.txtDesFolder1.Leave += new System.EventHandler(this.txtDesFolder1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source Folder";
            // 
            // btSouFolder1
            // 
            this.btSouFolder1.Image = global::ToolMovingFiles.Properties.Resources.icon_folder_16x16;
            this.btSouFolder1.Location = new System.Drawing.Point(386, 15);
            this.btSouFolder1.Name = "btSouFolder1";
            this.btSouFolder1.Size = new System.Drawing.Size(26, 24);
            this.btSouFolder1.TabIndex = 2;
            this.btSouFolder1.UseVisualStyleBackColor = true;
            this.btSouFolder1.Click += new System.EventHandler(this.btSouFolder1_Click);
            // 
            // txtSouFolder1
            // 
            this.txtSouFolder1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSouFolder1.Location = new System.Drawing.Point(131, 15);
            this.txtSouFolder1.Name = "txtSouFolder1";
            this.txtSouFolder1.ReadOnly = true;
            this.txtSouFolder1.Size = new System.Drawing.Size(250, 24);
            this.txtSouFolder1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCopyPath2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btDesFolder2);
            this.groupBox2.Controls.Add(this.txtDesFolder2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btSouFolder2);
            this.groupBox2.Controls.Add(this.txtSouFolder2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(9, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 77);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path Moving Files";
            // 
            // chkCopyPath2
            // 
            this.chkCopyPath2.AutoSize = true;
            this.chkCopyPath2.Location = new System.Drawing.Point(112, 21);
            this.chkCopyPath2.Name = "chkCopyPath2";
            this.chkCopyPath2.Size = new System.Drawing.Size(15, 14);
            this.chkCopyPath2.TabIndex = 10;
            this.chkCopyPath2.UseVisualStyleBackColor = true;
            this.chkCopyPath2.CheckedChanged += new System.EventHandler(this.chkCopyPath2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Destination Folder";
            // 
            // btDesFolder2
            // 
            this.btDesFolder2.Image = global::ToolMovingFiles.Properties.Resources.icon_folder_16x16;
            this.btDesFolder2.Location = new System.Drawing.Point(386, 45);
            this.btDesFolder2.Name = "btDesFolder2";
            this.btDesFolder2.Size = new System.Drawing.Size(26, 24);
            this.btDesFolder2.TabIndex = 8;
            this.btDesFolder2.UseVisualStyleBackColor = true;
            this.btDesFolder2.Click += new System.EventHandler(this.btDesFolder2_Click);
            // 
            // txtDesFolder2
            // 
            this.txtDesFolder2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDesFolder2.Location = new System.Drawing.Point(131, 45);
            this.txtDesFolder2.Name = "txtDesFolder2";
            this.txtDesFolder2.Size = new System.Drawing.Size(250, 24);
            this.txtDesFolder2.TabIndex = 7;
            this.txtDesFolder2.Leave += new System.EventHandler(this.txtDesFolder2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Source Folder";
            // 
            // btSouFolder2
            // 
            this.btSouFolder2.Image = global::ToolMovingFiles.Properties.Resources.icon_folder_16x16;
            this.btSouFolder2.Location = new System.Drawing.Point(386, 15);
            this.btSouFolder2.Name = "btSouFolder2";
            this.btSouFolder2.Size = new System.Drawing.Size(26, 24);
            this.btSouFolder2.TabIndex = 6;
            this.btSouFolder2.UseVisualStyleBackColor = true;
            this.btSouFolder2.Click += new System.EventHandler(this.btSouFolder2_Click);
            // 
            // txtSouFolder2
            // 
            this.txtSouFolder2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSouFolder2.Location = new System.Drawing.Point(131, 15);
            this.txtSouFolder2.Name = "txtSouFolder2";
            this.txtSouFolder2.ReadOnly = true;
            this.txtSouFolder2.Size = new System.Drawing.Size(250, 24);
            this.txtSouFolder2.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkCopyPath3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btDesFolder3);
            this.groupBox3.Controls.Add(this.txtDesFolder3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btSouFolder3);
            this.groupBox3.Controls.Add(this.txtSouFolder3);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(9, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 77);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Path Moving Files";
            // 
            // chkCopyPath3
            // 
            this.chkCopyPath3.AutoSize = true;
            this.chkCopyPath3.Location = new System.Drawing.Point(112, 21);
            this.chkCopyPath3.Name = "chkCopyPath3";
            this.chkCopyPath3.Size = new System.Drawing.Size(15, 14);
            this.chkCopyPath3.TabIndex = 11;
            this.chkCopyPath3.UseVisualStyleBackColor = true;
            this.chkCopyPath3.CheckedChanged += new System.EventHandler(this.chkCopyPath3_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Destination Folder";
            // 
            // btDesFolder3
            // 
            this.btDesFolder3.Image = global::ToolMovingFiles.Properties.Resources.icon_folder_16x16;
            this.btDesFolder3.Location = new System.Drawing.Point(386, 45);
            this.btDesFolder3.Name = "btDesFolder3";
            this.btDesFolder3.Size = new System.Drawing.Size(26, 24);
            this.btDesFolder3.TabIndex = 12;
            this.btDesFolder3.UseVisualStyleBackColor = true;
            this.btDesFolder3.Click += new System.EventHandler(this.btDesFolder3_Click);
            // 
            // txtDesFolder3
            // 
            this.txtDesFolder3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDesFolder3.Location = new System.Drawing.Point(131, 45);
            this.txtDesFolder3.Name = "txtDesFolder3";
            this.txtDesFolder3.Size = new System.Drawing.Size(250, 24);
            this.txtDesFolder3.TabIndex = 11;
            this.txtDesFolder3.Leave += new System.EventHandler(this.txtDesFolder3_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Source Folder";
            // 
            // btSouFolder3
            // 
            this.btSouFolder3.Image = global::ToolMovingFiles.Properties.Resources.icon_folder_16x16;
            this.btSouFolder3.Location = new System.Drawing.Point(386, 15);
            this.btSouFolder3.Name = "btSouFolder3";
            this.btSouFolder3.Size = new System.Drawing.Size(26, 24);
            this.btSouFolder3.TabIndex = 10;
            this.btSouFolder3.UseVisualStyleBackColor = true;
            this.btSouFolder3.Click += new System.EventHandler(this.btSouFolder3_Click);
            // 
            // txtSouFolder3
            // 
            this.txtSouFolder3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSouFolder3.Location = new System.Drawing.Point(131, 15);
            this.txtSouFolder3.Name = "txtSouFolder3";
            this.txtSouFolder3.ReadOnly = true;
            this.txtSouFolder3.Size = new System.Drawing.Size(250, 24);
            this.txtSouFolder3.TabIndex = 9;
            // 
            // progressBarFolder
            // 
            this.progressBarFolder.Location = new System.Drawing.Point(9, 231);
            this.progressBarFolder.Name = "progressBarFolder";
            this.progressBarFolder.Size = new System.Drawing.Size(418, 21);
            this.progressBarFolder.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btClear);
            this.groupBox4.Controls.Add(this.btCopy);
            this.groupBox4.Controls.Add(this.txtResult);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox4.Location = new System.Drawing.Point(9, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 75);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logs";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btClear.Image = global::ToolMovingFiles.Properties.Resources.icon_clear_16x16;
            this.btClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClear.Location = new System.Drawing.Point(337, 43);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 25);
            this.btClear.TabIndex = 15;
            this.btClear.TabStop = false;
            this.btClear.Text = "    Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCopy
            // 
            this.btCopy.Enabled = false;
            this.btCopy.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btCopy.Image = global::ToolMovingFiles.Properties.Resources.icon_copy_16x16;
            this.btCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCopy.Location = new System.Drawing.Point(337, 14);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(75, 25);
            this.btCopy.TabIndex = 14;
            this.btCopy.Text = "    Copy";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtResult.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(3, 19);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(329, 53);
            this.txtResult.TabIndex = 99;
            this.txtResult.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 333);
            this.Controls.Add(this.progressBarFolder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Tool Moving Files";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDesFolder1;
        private System.Windows.Forms.TextBox txtDesFolder1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSouFolder1;
        private System.Windows.Forms.TextBox txtSouFolder1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDesFolder2;
        private System.Windows.Forms.TextBox txtDesFolder2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSouFolder2;
        private System.Windows.Forms.TextBox txtSouFolder2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDesFolder3;
        private System.Windows.Forms.TextBox txtDesFolder3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSouFolder3;
        private System.Windows.Forms.TextBox txtSouFolder3;
        private System.Windows.Forms.ProgressBar progressBarFolder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.CheckBox chkCopyPath1;
        private System.Windows.Forms.CheckBox chkCopyPath2;
        private System.Windows.Forms.CheckBox chkCopyPath3;
    }
}

