using Microsoft.Win32;
using System.Windows.Forms;
namespace CustomUtil
{
    public class OpenWindows
    {
        public static void SelectFile(string title,string fileFilter,Action<string> success,Action? fail =null) {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Title = title;
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                openFileDialog.Filter = fileFilter;
                openFileDialog.Multiselect = false;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex= 0; 
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath=openFileDialog.FileName;
                    success.Invoke(filePath);
                }
                else
                {
                    fail?.Invoke();
                }
            }
        }
    }
}
