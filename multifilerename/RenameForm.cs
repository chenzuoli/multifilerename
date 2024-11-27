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
            checkBox_numOrder.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 选择文件夹
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // 列出选择的文件夹内的所有文件
                listBox1.Items.Clear();
                listBox3.Items.Clear();

                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                //listBox1.Items.AddRange(files);

                // 列出所有更改后的文件名，按照顺序一次在文件前新增数字序号
                for (int i = 0; i < files.Length; i++)
                {
                    String fileDirectory= Path.GetDirectoryName(files[i]);
                    String fileName = Path.GetFileName(files[i]);
                    String newFileName = (i + 1) + "_" + fileName;
                    String newFilePath = Path.Combine(fileDirectory, newFileName);
                    //listBox3.Items.Add(newFilePath);
                    listBox1.Items.Add(fileName);
                    listBox3.Items.Add(newFileName);
                    //listBox1.Items.Add("-----------------------------------------------------------------");
                    //listBox3.Items.Add("-----------------------------------------------------------------");
                }
                button3.Enabled = true;

                // 隐藏btn1
                button1.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void checkBox_charOrder_CheckedChanged(object sender, EventArgs e)
        {
            List<string> newFiles = new List<string>();

            // 修改文件夹名称，按照字母前缀 添加
            if (checkBox_charOrder.Checked)
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    // 按照字母顺序，如果超过26个字母，字母循环
                    char initChar = 'a';
                    int addNum = i % 26;
                    char b = Convert.ToChar(Convert.ToInt16(initChar + addNum));

                    string newFileName = b.ToString() + "_" + listBox3.Items[i].ToString();
                    newFiles.Add(newFileName);
                }
                listBox3.Items.Clear();
                newFiles.ForEach(item => listBox3.Items.Add(item));
            }
            else
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    // 将前缀字母删除
                    char initChar = 'a';
                    int addNum = i % 26;
                    char b = Convert.ToChar(Convert.ToInt16(initChar + addNum));

                    // 这里有bug，当文件原名中包含了字母下划线时，可能会误替换
                    //string newFileName =  listBox3.Items[i].ToString().Replace(b.ToString() + "_", "");
                    string item = listBox3.Items[i].ToString();
                    string prefix = b.ToString() + "_";
                    if (item.StartsWith(prefix))
                    {
                        string newFileName = item.Substring(prefix.Length);
                        newFiles.Add(newFileName);
                    }
                }
                listBox3.Items.Clear();
                newFiles.ForEach(item => listBox3.Items.Add(item));
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
                    string fileOriPath = Path.Combine(folderBrowserDialog.SelectedPath, listBox1.Items[i].ToString());
                    string fileAbsPath = Path.Combine(folderBrowserDialog.SelectedPath, listBox3.Items[i].ToString());
                    if (File.Exists(fileAbsPath))
                    {
                        File.Delete(fileAbsPath);
                    }

                    // move
                    File.Move(fileOriPath, fileAbsPath);
                }
                MessageBox.Show("修改成功。");

                // 将修改置为失效，直到重新选择了文件夹
                button3.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex + "修改失败，请重试。");
            }
        }


    }
}
