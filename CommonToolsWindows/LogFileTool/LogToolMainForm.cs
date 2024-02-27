using CustomUtil;
namespace LogFileTool
{
    public partial class LogToolMainForm : Form
    {
        public LogToolMainForm()
        {
            InitializeComponent();
        }

        private void OriFilePathTextBoxChanged(object sender, EventArgs e)
        {

        }

        private void OnGetLinesBtnClick(object sender, EventArgs e)
        {

        }
        private void OnDelLinesBtnClick(object sender, EventArgs e)
        {

        }

        private void OutPutFilePathTextBoxChanged(object sender, EventArgs e)
        {

        }

        private void OnSelectFileBtnClick(object sender, EventArgs e)
        {
            CustomUtil.OpenWindows.SelectFile("Ñ¡ÔñlogÎÄ¼þ", "All files(*.*)|*.*", str=>{ 
                oriFilePathTextBox.Text = str;
            },null);
        }
    }
}
