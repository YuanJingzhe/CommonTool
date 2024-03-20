using CustomUtil;
using System.Text;
namespace LogFileTool
{
    public partial class LogToolMainForm : Form
    {
        public LogToolMainForm()
        {
            InitializeComponent();
        }

        string oriFilePath = string.Empty;
        string keywords = string.Empty;
        string outputFilePath = string.Empty;

        /// <summary>
        /// 源文件路径变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OriFilePathTextBoxChanged(object sender, EventArgs e)
        {
            oriFilePath = ((TextBox)sender).Text;
        }
        /// <summary>
        /// 提取行按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnGetLinesBtnClick(object sender, EventArgs e)
        {
            if (!CheckStr()) return;
            CheckExistAndWriteFile(oriFilePath, outputFilePath, GetLogType.GET);
        }
        /// <summary>
        /// keywordTextBox发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyWordsChanged(object sender, EventArgs e)
        {
            keywords = ((TextBox)sender).Text;
        }
        /// <summary>
        /// 删除行按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDelLinesBtnClick(object sender, EventArgs e)
        {
            if (!CheckStr()) return;
            CheckExistAndWriteFile(oriFilePath, outputFilePath, GetLogType.DEL);
        }

        /// <summary>
        /// 输出路径TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutPutFilePathTextBoxChanged(object sender, EventArgs e)
        {
            outputFilePath = ((TextBox)sender).Text;
        }
        /// <summary>
        /// 选择文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectFileBtnClick(object sender, EventArgs e)
        {
            CustomUtil.OpenWindows.SelectFile("选择log文件（别瞎选啊，没做容错处理！！！）", "All files(*.*)|*.*", str =>
            {
                oriFilePathTextBox.Text = str;
                outputFilePathTextBox.Text = str + "-output";
            }, null);
        }

   
        /// <summary>
        /// 检查输出输入路径和关键词是否为空
        /// </summary>
        /// <returns></returns>
        private bool CheckStr()
        {
            if (string.IsNullOrEmpty(oriFilePath))
            {
                MessageBox.Show("源文件路径错误！");
                return false;
            }
            if (string.IsNullOrEmpty(keywords))
            {
                MessageBox.Show("未填入关键词");
                return false;
            }
            if (string.IsNullOrEmpty(outputFilePath))
            {
                MessageBox.Show("输出路径错误！");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 导出文件
        /// </summary>
        /// <param name="oriFilePath"></param>
        /// <param name="outputPath"></param>
        /// <param name="type"></param>
        private void CheckExistAndWriteFile(string oriFilePath, string outputPath, GetLogType type)
        {
            if (File.Exists(outputPath))
            {
                DialogResult fileExistResult = MessageBox.Show("文件已存在，是否覆盖？", "覆盖提示", MessageBoxButtons.OKCancel);
                if (fileExistResult == DialogResult.OK)
                {
                    WriteFile(oriFilePath, outputPath, type);
                }
            }
            else
            {
                WriteFile(oriFilePath, outputPath, type);
            }
        }

        private void WriteFile(string oriFilePath, string outputFilePath, GetLogType type)
        {

            string[] keywordArray = keywords.Split(',');
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(oriFilePath))
            {
                string lineStr = sr.ReadLine();
                while (lineStr != null)
                {
                    if (lineStr.Length > 0)
                    {
                        bool isContainKeyword = false;
                        for (int i = 0; i < keywordArray.Length; i++)
                        {
                            if (lineStr.Contains(keywordArray[i]))
                            {
                                isContainKeyword = true;
                                break;
                            }
                        }
                        if (isContainKeyword && type == GetLogType.GET)
                        {
                            sb.Append(lineStr);
                            sb.Append('\n');
                        }
                        if (!isContainKeyword && type == GetLogType.DEL)
                        {
                            sb.Append(lineStr);
                            sb.Append("\n");
                        }
                    }
                    lineStr = sr.ReadLine();
                }
            }
            File.WriteAllText(outputFilePath, sb.ToString());
            MessageBox.Show("处理完成");
        }

        protected enum GetLogType
        {
            DEL,
            GET
        }
    }

}
