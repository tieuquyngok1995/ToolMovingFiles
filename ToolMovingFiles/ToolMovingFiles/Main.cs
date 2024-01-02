using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ToolMovingFiles
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        #region Event 
        private void Main_Load(object sender, System.EventArgs e)
        {
            try
            {
                txtSouFolder1.Text = Properties.Settings.Default.pathSou1;
                txtDesFolder1.Text = Properties.Settings.Default.pathDes1;
                chkCopyPath1.Checked = Properties.Settings.Default.isCopyPath1;

                txtSouFolder2.Text = Properties.Settings.Default.pathSou2;
                txtDesFolder2.Text = Properties.Settings.Default.pathDes2;
                chkCopyPath2.Checked = Properties.Settings.Default.isCopyPath2;

                txtSouFolder3.Text = Properties.Settings.Default.pathSou3;
                txtDesFolder3.Text = Properties.Settings.Default.pathDes3;
                chkCopyPath3.Checked = Properties.Settings.Default.isCopyPath3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during processing.\r\nError detail: " + ex.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkCopyPath1_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCopyPath1.Checked && !chkCopyPath2.Checked && !chkCopyPath3.Checked) btCopy.Enabled = false;
            else btCopy.Enabled = true;

            Properties.Settings.Default.isCopyPath1 = chkCopyPath1.Checked;
            Properties.Settings.Default.Save();
        }

        private void btSouFolder1_Click(object sender, System.EventArgs e)
        {
            try
            {
                string path = folderBrowserDialog(txtSouFolder1.Text);
                if (path != null)
                {
                    txtSouFolder1.Text = path;

                    Properties.Settings.Default.pathSou1 = path;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during processing.\r\nError detail: " + ex.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDesFolder1_Click(object sender, System.EventArgs e)
        {
            try
            {
                string path = folderBrowserDialog(txtDesFolder1.Text);
                if (path != null)
                {
                    txtDesFolder1.Text = path;

                    Properties.Settings.Default.pathDes1 = path;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during processing.\r\nError detail: " + ex.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkCopyPath2_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCopyPath1.Checked && !chkCopyPath2.Checked && !chkCopyPath3.Checked) btCopy.Enabled = false;
            else btCopy.Enabled = true;

            Properties.Settings.Default.isCopyPath2 = chkCopyPath2.Checked;
            Properties.Settings.Default.Save();
        }

        private void btSouFolder2_Click(object sender, System.EventArgs e)
        {
            try
            {
                string path = folderBrowserDialog(txtSouFolder2.Text);
                if (path != null)
                {
                    txtSouFolder2.Text = path;

                    Properties.Settings.Default.pathSou2 = path;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during processing.\r\nError detail: " + ex.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDesFolder2_Click(object sender, System.EventArgs e)
        {
            try
            {
                string path = folderBrowserDialog(txtDesFolder2.Text);
                if (path != null)
                {
                    txtDesFolder2.Text = path;

                    Properties.Settings.Default.pathDes2 = path;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during processing.\r\nError detail: " + ex.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkCopyPath3_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCopyPath1.Checked && !chkCopyPath2.Checked && !chkCopyPath3.Checked) btCopy.Enabled = false;
            else btCopy.Enabled = true;

            Properties.Settings.Default.isCopyPath3 = chkCopyPath3.Checked;
            Properties.Settings.Default.Save();
        }

        private void btSouFolder3_Click(object sender, System.EventArgs e)
        {
            try
            {
                string path = folderBrowserDialog(txtSouFolder3.Text);
                if (path != null)
                {
                    txtSouFolder3.Text = path;

                    Properties.Settings.Default.pathSou3 = path;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during processing.\r\nError detail: " + ex.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDesFolder3_Click(object sender, System.EventArgs e)
        {
            try
            {
                string path = folderBrowserDialog(txtDesFolder3.Text);
                if (path != null)
                {
                    txtDesFolder3.Text = path;

                    Properties.Settings.Default.pathDes3 = path;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during processing.\r\nError detail: " + ex.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCopy_Click(object sender, System.EventArgs e)
        {
            try
            {
                txtResult.Text = string.Empty;
                if (chkCopyPath1.Checked)
                {
                    copyAll(txtSouFolder1.Text, txtDesFolder1.Text);
                    txtResult.Text += "Copy files in folder 1 successfully";
                }
                if (chkCopyPath2.Checked)
                {
                    copyAll(txtSouFolder2.Text, txtDesFolder2.Text);
                    txtResult.Text += "Copy files in folder 2 successfully";
                }
                if (chkCopyPath3.Checked)
                {
                    copyAll(txtSouFolder3.Text, txtDesFolder3.Text);
                    txtResult.Text += "Copy files in folder 3 successfully";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during processing.\r\nError detail: " + ex.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClear_Click(object sender, System.EventArgs e)
        {
            try
            {
                txtResult.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during processing.\r\nError detail: " + ex.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Method 
        /// <summary>
        /// Open browser dialog folder
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string folderBrowserDialog(string path)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (!string.IsNullOrEmpty(path)) fbd.SelectedPath = path;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    return fbd.SelectedPath;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void copyAll(string sourcePath, string desPath)
        {
            //Setting ProgressBar Maximum Value
            progressBarFolder.Maximum = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(sourcePath, "**", SearchOption.AllDirectories).Length;

            if (!Directory.Exists(desPath)) Directory.CreateDirectory(desPath);
            DirectoryInfo source = new DirectoryInfo(sourcePath);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(desPath, fi.Name), true);
                updateProgress();
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo target = new DirectoryInfo(desPath);
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                copyAll(diSourceSubDir.FullName, nextTargetSubDir.FullName);
            }
        }

        /// <summary>
        /// Update processing progress
        /// </summary>
        private void updateProgress()
        {
            if (progressBarFolder.Value < progressBarFolder.Maximum)
            {
                progressBarFolder.Value++;
                int percent = (int)(((double)progressBarFolder.Value / (double)progressBarFolder.Maximum) * 100);
                string percentDisplay = percent < 10 ? "0" + percent.ToString() : percent.ToString();
                progressBarFolder.CreateGraphics().DrawString(percentDisplay + " %", new Font("Century Gothic", (float)10, FontStyle.Regular), Brushes.Black, new PointF(progressBarFolder.Width / 2 - 10, progressBarFolder.Height / 2 - 7));
                Application.DoEvents();
            }
        }
        #endregion
    }
}
