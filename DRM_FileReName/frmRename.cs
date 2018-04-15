using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRM_FileReMame
{
    public partial class frmRename : Form
    {
        public frmRename()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Explorer_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                txtSourceFolder.Text = folderBrowserDialog1.SelectedPath;
                if (txtSourceFolder.Text.Trim() == null)
                {
                    btnStart.Enabled = false;
                }
                else
                {
                    btnStart.Enabled = true;
                }
            }
        }

        private void frmRename_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }

        private int StartConversion_FileNameWithSemiColon (string sFilePath)
        {
            int iFileCount = 0;
            int iSeperatorPos = 0;
            int iDashSpaceCount = 0;

            string[] files = Directory.GetFiles(sFilePath);

            foreach (string sFile in files)
            {
                iSeperatorPos = sFile.IndexOf(';');

                if (iSeperatorPos > 0)
                {
                    iDashSpaceCount = sFile.Split('-').Length;

                    if (iDashSpaceCount == 3)
                    {
                        var sPartName = sFile.Substring(iSeperatorPos + 1, 8);
                        DateTime dDate = System.Convert.ToDateTime(sPartName);

                        MessageBox.Show(dDate.ToString());
                    }
                    else if (iDashSpaceCount == 4)
                    {
                        var sPartName = sFile.Substring(iSeperatorPos + 1, 8);
                        DateTime dDate = System.Convert.ToDateTime(sPartName);

                        MessageBox.Show(dDate.ToString());

                    }
                }

                iSeperatorPos = sFile.IndexOf('_');

                if (iSeperatorPos > 0)
                {
                    iDashSpaceCount = sFile.Split('-').Length;

                    if (iDashSpaceCount == 1)
                    {
                        var sPartName = sFile.Substring(iSeperatorPos + 1, 8);
                        DateTime dDate = System.Convert.ToDateTime(sPartName);

                        MessageBox.Show(dDate.ToString());
                    }
                    else if (iDashSpaceCount == 2)
                    {
                        var sPartName = sFile.Substring(iSeperatorPos + 1, 8);
                        DateTime dDate = System.Convert.ToDateTime(sPartName);

                        MessageBox.Show(dDate.ToString());

                    }
                    else if (iDashSpaceCount == 3)
                    {
                        var sPartName = sFile.Substring(iSeperatorPos + 1, 8);
                        DateTime dDate = System.Convert.ToDateTime(sPartName);

                        MessageBox.Show(dDate.ToString());

                    }
                    else
                    {
                        var sPartName = sFile.Substring(iSeperatorPos + 1);
                        DateTime dDate = System.Convert.ToDateTime(sPartName);

                        MessageBox.Show(dDate.ToString());
                    }
                }

            }


            return iFileCount;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartConversion_FileNameWithSemiColon(txtSourceFolder.Text.Trim());
        }
    }
}
