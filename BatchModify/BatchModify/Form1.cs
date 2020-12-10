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

namespace BatchModify
{
    public partial class Form1 : Form
    {
        #region//全局变量
        public bool IsDistinction;//是否按文件类型分开进行重命名
        public List<string>[] OldFileName;//用于存储旧的所有文件名
        public List<string>[] NewFileName;//用于存储旧的所有文件名
        #endregion
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            IsDistinction = true;
            comb1.SelectedIndex = 0;
            comb2.SelectedIndex = 0;
            comb3.SelectedIndex = 0;
            MessageBox.Show("本软件可能会导致修改后的文件出现问题，因此强烈建议在使用前对你的文件进行备份！","提示", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        //输入路径按钮
        private void btn_input_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                text_input.Text = foldPath;              
            }
            
        }

        //判断后缀是否已经存在于fileTypes中
        public bool Non_Existent(string extension, string[] fileTypes,int nfileTypes)
        {
            int i = 0;
            for(i=0;i< nfileTypes; i++)
            {
                if(Path.GetExtension(fileTypes[i]) == extension)
                {
                    break;
                }
            }
            if(i == nfileTypes) { return true; }
            else { return false; }
        }

        //获取文件夹中所有的文件的后缀
        public int GetTypes(string[] files,string[] fileTypes)
        {
            int nfileTypes = 0;
            for(int i=0;i< files.Length; i++)
            {
                if (Non_Existent(Path.GetExtension(files[i]),fileTypes, nfileTypes))
                {
                    fileTypes[nfileTypes] = Path.GetExtension(files[i]);
                    nfileTypes++;
                }
            }

            return nfileTypes;
        }

        //获取后缀所在的索引号
        public int GetExtensionIndex(string extension, string[] fileTypes,int nfileTypes)
        {
            int i = 0;
            for(i=0;i< nfileTypes; i++)
            {
                if(fileTypes[i]== extension) { break; }
            }
            return i;
        }

        private void raBtn_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (raBtn_Yes.Checked)
            {
                IsDistinction = true;               
            }
               
        }

        private void raBtn_No_CheckedChanged(object sender, EventArgs e)
        {
            if (raBtn_No.Checked)
            {
                IsDistinction = false;
            }
            
        }

        //根据位数对数字补0
        public string Num2String(int num,int digits)
        {
            num++;//为了编号从1开始
            string str_num = num.ToString();
            for (int i=0;i< digits.ToString().Length- num.ToString().Length; i++)
            {
                str_num = "0" + str_num;
            }
            return str_num;
        }

        //根据combobox的选择返回前或后部分的字符串
        private string Getstr(ComboBox comb, string Old,int num,int digits)//flag为0代表前面部分，1代表后面部分
        {
            string str="";
            switch (comb.Text)
            {
                case "无":
                    str = "";
                    break;
                case "原文件名称":
                    str = Path.GetFileName(Old);
                    int index = str.LastIndexOf(".");
                    str = str.Remove(index);                      
                    break;                 
                case "数字递增（不补0）":
                    str = (num+1).ToString();
                    break;
                case "数字递增（补0）":
                    str = Num2String(num, digits);
                    break;
                default:
                    str = "";
                    break;
            }

            return str;
        }

        public bool VerifyCompliance()
        {
            if (comb1.Text == "无" && comb3.Text == "无")
            {
                MessageBox.Show("请确保前一部分和后一部分至少一个不为空");
                return false;
            }
            if (!Directory.Exists(text_input.Text))
            {
                MessageBox.Show("请选择需要批量修改的文件所在路径");
                return false;
            }
            return true;
        }

        public void GetOldAndNewFileName(bool IsDistinction)
        {
            if (IsDistinction)
            {
                if (Directory.Exists(text_input.Text))
                {
                    string[] files = Directory.GetFiles(text_input.Text);
                    string[] fileTypes = new string[files.Length];
                    int nfileTypes = GetTypes(files, fileTypes);
                    OldFileName = new List<string>[nfileTypes];
                    NewFileName = new List<string>[nfileTypes];
                    for (int i = 0; i < nfileTypes; i++)
                    {
                        OldFileName[i] = new List<string>();
                        NewFileName[i] = new List<string>();
                    }

                    for (int i = 0; i < files.Length; i++)
                    {
                        OldFileName[GetExtensionIndex(Path.GetExtension(files[i]), fileTypes, nfileTypes)].Add(files[i]);
                        NewFileName[GetExtensionIndex(Path.GetExtension(files[i]), fileTypes, nfileTypes)].Add(files[i]);
                    }
                }
            }
            else
            {
                if (Directory.Exists(text_input.Text))
                {
                    string[] files = Directory.GetFiles(text_input.Text);
                    OldFileName = new List<string>[1];
                    OldFileName[0] = new List<string>();
                    OldFileName[0].AddRange(files);

                    NewFileName = new List<string>[1];
                    NewFileName[0] = new List<string>();
                    NewFileName[0].AddRange(files);
                }
            }
            
        }
        //预览
        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (!VerifyCompliance()) { return; }
            GetOldAndNewFileName(IsDistinction);
            if (raBtn_Yes.Checked)// 按文件类型分别进行重命名
            {
                string str0, str1, str2, str3;
                str0 = text_input.Text + "\\";
                string extension="";
                this.dataGridView1.Rows.Clear();
                for(int i=0;i< OldFileName.Length; i++)
                {
                    for(int j=0;j< OldFileName[i].Count; j++)
                    {
                        extension = Path.GetExtension(OldFileName[i][j]);
                        str1 = Getstr(comb1, OldFileName[i][j], j, OldFileName[i].Count);
                        if (comb2.Text == "无") { str2 = ""; }
                        else { str2 = comb2.Text; }
                        str3 = Getstr(comb3, OldFileName[i][j], j, OldFileName[i].Count);
                        NewFileName[i][j] = str0 + str1 + str2 + str3 + extension;

                        this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[i * OldFileName[i].Count + j].Cells[0].Value = Path.GetFileName(OldFileName[i][j]);
                        this.dataGridView1.Rows[i * OldFileName[i].Count + j].Cells[1].Value = str1 + str2 + str3 + extension;
                    }
                }

            }
            else//不按文件类型分别进行重命名
            {
                string str0, str1, str2, str3;
                str0 = text_input.Text + "\\";
                string extension = "";
                this.dataGridView1.Rows.Clear();
                for (int i=0;i< OldFileName[0].Count; i++)
                {
                    extension = Path.GetExtension(OldFileName[0][i]);
                    str1 = Getstr(comb1, OldFileName[0][i],i, OldFileName[0].Count);
                    if (comb2.Text == "无") { str2 = ""; }
                    else { str2 = comb2.Text; }                    
                    str3 = Getstr(comb3, OldFileName[0][i],i, OldFileName[0].Count);
                    NewFileName[0][i] = str0 + str1 + str2 + str3 + extension;

                    this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[i].Cells[0].Value = Path.GetFileName(OldFileName[0][i]);
                    this.dataGridView1.Rows[i].Cells[1].Value = str1 + str2 + str3 + extension;
                }                           
            }
        }

        //执行
        private void btn_execute_Click(object sender, EventArgs e)
        {
            if (!VerifyCompliance()) { return; }
            GetOldAndNewFileName(IsDistinction);//获取当前文件夹下面的文件名
            string str0, str1, str2, str3;
            str0 = text_input.Text + "\\";
            string extension;
            this.dataGridView1.Rows.Clear();
            if (raBtn_Yes.Checked)// 按文件类型分别进行重命名
            {
                try
                {
                    for (int i = 0; i < OldFileName.Length; i++)
                    {
                        for (int j = 0; j < OldFileName[i].Count; j++)
                        {
                            extension = Path.GetExtension(OldFileName[i][j]);
                            str1 = Getstr(comb1, OldFileName[i][j], j, OldFileName[i].Count);
                            if (comb2.Text == "无") { str2 = ""; }
                            else { str2 = comb2.Text; }
                            str3 = Getstr(comb3, OldFileName[i][j], j, OldFileName[i].Count);
                            NewFileName[i][j] = str0 + str1 + str2 + str3 + extension;                       
                        
                            this.dataGridView1.Rows.Add();
                            this.dataGridView1.Rows[i * OldFileName[i].Count + j].Cells[0].Value = Path.GetFileName(OldFileName[i][j]);
                            this.dataGridView1.Rows[i * OldFileName[i].Count + j].Cells[1].Value = str1 + str2 + str3 + extension;
                            if(OldFileName[i][j]!= NewFileName[i][j])
                            {                           
                                    File.Move(OldFileName[i][j], NewFileName[i][j]);                           
                            }
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }

            }
            else//不按文件类型分别进行重命名
            {
                try
                {
                    for (int i = 0; i < OldFileName[0].Count; i++)
                    {
                        extension = Path.GetExtension(OldFileName[0][i]);
                        str1 = Getstr(comb1, OldFileName[0][i], i, OldFileName[0].Count);
                        if (comb2.Text == "无") { str2 = ""; }
                        else { str2 = comb2.Text; }
                        str3 = Getstr(comb3, OldFileName[0][i], i, OldFileName[0].Count);
                        NewFileName[0][i] = str0 + str1 + str2 + str3 + extension;

                        this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[i].Cells[0].Value = Path.GetFileName(OldFileName[0][i]);
                        this.dataGridView1.Rows[i].Cells[1].Value = str1 + str2 + str3 + extension;
                        if (OldFileName[0][i] != NewFileName[0][i])
                        {                    
                                File.Move(OldFileName[0][i], NewFileName[0][i]);         
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
            }
            MessageBox.Show("重命名已完成");
        }

        //撤回
        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            if (!VerifyCompliance()) { return; }
            if (raBtn_Yes.Checked)// 按文件类型分别进行重命名
            {
                try
                {
                    for (int i = 0; i < OldFileName.Length; i++)
                    {
                        for (int j = 0; j < OldFileName[i].Count; j++)
                        {
                            if (NewFileName[i][j] != OldFileName[i][j])
                            {
                                File.Move(NewFileName[i][j], OldFileName[i][j]);
                            }
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
            }
            else
            {
                try
                {
                    for (int i = 0; i < OldFileName[0].Count; i++)
                    {                  
                        if (NewFileName[0][i] != OldFileName[0][i])
                        {                    
                                File.Move(NewFileName[0][i], OldFileName[0][i]);
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
            }
            GetOldAndNewFileName(IsDistinction);
            MessageBox.Show("撤回成功");
        }
    }
}
