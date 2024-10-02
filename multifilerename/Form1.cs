using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multifilerename
{
    public partial class rename : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        public rename()
        {
            InitializeComponent();
            folderBrowserDialog = new FolderBrowserDialog();
            //listBoxFiles = new ListBox();

            //Button btnBrowse = new Button();
            //btnBrowse.Text = "...";
            //btnBrowse.Click += button1_Click;
            //button1.Text = "选择文件夹";
            
            //this.Controls.Add(listBoxFiles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // 列出选择的文件夹内的所有文件
                listBox1.Items.Clear();
                listBox3.Items.Clear();
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                listBox1.Items.AddRange(files);

                // 列出所有更改后的文件名，按照顺序一次在文件前新增数字序号
                for (int i = 0; i < files.Length; i++)
                {
                    String fileDirectory= Path.GetDirectoryName(files[i]);
                    String fileName = Path.GetFileName(files[i]);
                    String newFilePath = Path.Combine(fileDirectory, (i + 1) + fileName);
                    listBox3.Items.Add(newFilePath);
                }
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 确认修改按钮
            try
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    // 如果目标文件存在，则删除
                    if (File.Exists(listBox3.Items[i].ToString()))
                    {
                        File.Delete(listBox3.Items[i].ToString());
                    }

                    // move
                    File.Move(listBox1.Items[i].ToString(), listBox3.Items[i].ToString());
                }
                MessageBox.Show("修改成功。");
                
                // 将修改置为失效，直到重新选择了文件夹
                button3.Enabled = false;
            }
            catch {
                MessageBox.Show("修改失败，请重试。");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
