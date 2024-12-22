using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multifilerename.util
{
    public class RenameFile
    {
        private static bool hasRenameRule(CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox, int ruleId)
        {
            // 判断此规则之前的规则是否配置了重命名
            if (numPrefixCheckBox.Checked) {
                if (ruleId >= 2) return true;
            };
            if (charPrefixCheckBox.Checked)
            {
                if (ruleId >= 3) return true;
            };
            if (customPrefixBox.Text.Length > 0)
            {
                if (ruleId >= 4) return true;
            };
            if (numSubfixCheckBox.Checked)
            {
                if (ruleId >= 5) return true;
            };
            if (charSubfixCheckBox.Checked)
            {
                if (ruleId >= 6) return true;
            };
            if (customSubfixBox.Text.Length > 0)
            {
                if (ruleId >= 7) return true;
            };
            if (textBeforeBox.Text.Length > 0)
            {
                if (ruleId >= 8) return true;
            };
            if (textAfterBox.Text.Length > 0)
            {
                if (ruleId >= 9) return true;
            };
            return false;
        }

        public static List<string> renameNumPrefix(CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox)
        {
            int initNum = 1;
            List<string> newFiles = new List<string>();
            // 数字顺序
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string newFileName = (i + initNum) + "_" + listBox1.Items[i].ToString();
                newFiles.Add(newFileName);
            }
            listBox3.Items.Clear();
            newFiles.ForEach(item => listBox3.Items.Add(item));
            return newFiles;
        }

        public static List<string> renameCharPrefix(CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox)
        {
            bool many_rename_rule_flag = hasRenameRule(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox,
                listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox, 2);
            List<string> newFiles = new List<string>();
            ListBox listBox = listBox1;
            if (many_rename_rule_flag)
            {
                listBox = listBox3;
            }
            // 字符顺序前缀
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                // 按照字母顺序，如果超过26个字母，字母循环
                char initChar = 'a';
                int addNum = i % 26;
                char b = Convert.ToChar(Convert.ToInt16(initChar + addNum));

                string newFileName = b.ToString() + "_" + listBox.Items[i].ToString();
                newFiles.Add(newFileName);
            }
            listBox3.Items.Clear();
            newFiles.ForEach(item => listBox3.Items.Add(item));
            return newFiles;
        }

        public static List<string> renameCustomPrefix(CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox)
        {
            bool many_rename_rule_flag = hasRenameRule(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox,
                listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox, 3);
            string filePrefix = customPrefixBox.Text;
            ListBox listBox = listBox1;
            if (many_rename_rule_flag)
            {
                listBox = listBox3;
            }
            // 变更目标文件名
            List<string> newFiles = new List<string>();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                // 按照自定义的前缀，添加到文件列表中
                string fileName = listBox.Items[i].ToString();
                newFiles.Add(filePrefix + fileName);
            }
            listBox3.Items.Clear();
            newFiles.ForEach(item => listBox3.Items.Add(item));
            return newFiles;
        }

        public static List<string> renameCharSubfix(CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox)
        {
            bool many_rename_rule_flag = hasRenameRule(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox,
                listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox, 4);
            List<string> newFiles = new List<string>();

            ListBox listBox = listBox1;
            if (many_rename_rule_flag)
            {
                listBox = listBox3;
            }
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                // 按照字母顺序，如果超过26个字母，字母循环
                char initChar = 'a';
                int addNum = i % 26;
                char b = Convert.ToChar(Convert.ToInt16(initChar + addNum));

                string newFileName = listBox.Items[i].ToString() + "_" + b.ToString();
                newFiles.Add(newFileName);
            }
            listBox3.Items.Clear();
            newFiles.ForEach(item => listBox3.Items.Add(item));
            return newFiles;
        }

        public static List<string> renameNumSubfix(CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox)
        {
            bool many_rename_rule_flag = hasRenameRule(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox,
                listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox, 5);
            List<string> newFiles = new List<string>();
            ListBox listBox = listBox1;
            if (many_rename_rule_flag)
            {
                listBox = listBox3;
            }
            int initNum = 1;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                string newFileName = listBox.Items[i].ToString() + "_" + (i + initNum);
                newFiles.Add(newFileName);
            }
            listBox3.Items.Clear();
            newFiles.ForEach(item => listBox3.Items.Add(item));
            return newFiles;
        }

        public static List<string> renameCustomSubfix(CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox)
        {
            bool many_rename_rule_flag = hasRenameRule(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox,
                listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox, 6);
            string fileSubfix = customSubfixBox.Text;
            ListBox listBox = listBox1;
            if (many_rename_rule_flag)
            {
                listBox = listBox3;
            }
            // 变更目标文件名
            List<string> newFiles = new List<string>();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                // 按照自定义的后缀，添加到文件列表中
                string fileName = listBox.Items[i].ToString();
                newFiles.Add(fileName + fileSubfix);
            }
            listBox3.Items.Clear();
            newFiles.ForEach(item => listBox3.Items.Add(item));
            return newFiles;
        }

        public static List<string> replaceCustomBefore(CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox)
        {
            bool many_rename_rule_flag = hasRenameRule(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox,
                listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox, 7);
            // 变更目标文件名
            List<string> newFiles = new List<string>();

            ListBox listBox = listBox1;
            if (many_rename_rule_flag)
            {
                listBox = listBox3;
            }
            string textBefore = textBeforeBox.Text;
            if (textBefore.Length <= 0)
            {
                // 如果为空，则不需要替换
                newFiles = listBox3.Items.Cast<string>().ToList();
                return newFiles;
            }
            
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                // 按照自定义的替换，更新到文件列表中
                string fileName = listBox.Items[i].ToString();
                newFiles.Add(fileName.Replace(textBefore, ""));
            }
            listBox3.Items.Clear();
            newFiles.ForEach(item => listBox3.Items.Add(item));
            return newFiles; 
        }


        public static List<string> replaceCustomAfter(CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox)
        {
            bool many_rename_rule_flag = hasRenameRule(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox,
                listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox, 8);
            string textAfter = textAfterBox.Text;
            string textBefore = textBeforeBox.Text;
            ListBox listBox = listBox1;
            if (many_rename_rule_flag)
            {
                listBox = listBox3;
            }
            // 变更目标文件名
            List<string> newFiles = new List<string>();

            if (textBefore.Length <= 0)
            {
                // 如果为空，则不需要替换
                newFiles = listBox3.Items.Cast<string>().ToList();
                return newFiles;
            }

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                // 按照自定义的替换，更新到文件列表中
                string fileName = listBox.Items[i].ToString();
                newFiles.Add(fileName.Replace(textBefore, textAfter));
            }
            listBox3.Items.Clear();
            newFiles.ForEach(item => listBox3.Items.Add(item));
            return newFiles;
        }

        public static List<string> renameRuleChange(
            CheckBox numPrefixCheckBox,
            CheckBox charPrefixCheckBox,
            CheckBox numSubfixCheckBox,
            CheckBox charSubfixCheckBox,
            ListBox listBox1, ListBox listBox3,
            TextBox customPrefixBox, TextBox customSubfixBox,
            TextBox textBeforeBox, TextBox textAfterBox)
        {
            List<string> newFiles = new List<string>();
            // 按照顺序依次进行重命名
            // 数字顺序前缀 字符顺序前缀 自定义前缀 数字顺序后缀 字符顺序后缀 自定义后缀
            // 若取消勾选某项重命名规则，则重新按照listBox1中的文件名列表重新按顺序命名
            if (numPrefixCheckBox.Checked) newFiles = renameNumPrefix(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox, listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox);
            if (charPrefixCheckBox.Checked) newFiles = renameCharPrefix(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox, listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox);
            if (customPrefixBox.Text.Length > 0) newFiles = renameCustomPrefix(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox, listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox);
            if (numSubfixCheckBox.Checked) newFiles = renameNumSubfix(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox, listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox);
            if (charSubfixCheckBox.Checked) newFiles = renameCharSubfix(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox, listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox);
            if (customSubfixBox.Text.Length > 0) newFiles = renameCustomSubfix(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox, listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox);
            if (textBeforeBox.Text.Length > 0) newFiles = replaceCustomBefore(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox, listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox);
            if (textAfterBox.Text.Length > 0) newFiles = replaceCustomAfter(numPrefixCheckBox, charPrefixCheckBox, numSubfixCheckBox, charSubfixCheckBox, listBox1, listBox3, customPrefixBox, customSubfixBox, textBeforeBox, textAfterBox);
            return newFiles;
        }

    }
}
