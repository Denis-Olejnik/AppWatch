using System.Diagnostics;

namespace AppWatch
{
    public partial class SelectProcess : Form
    {
        public SelectProcess()
        {
            InitializeComponent();
            GetListOSProcesses();
        }

        public void GetListOSProcesses()
        {
            string _processName = string.Empty;
            try
            {
                dataGridViewOSProcesses.Rows.Clear();

                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    if (string.IsNullOrEmpty(process.MainWindowTitle)) continue;

                    _processName = process.ProcessName;
                    dataGridViewOSProcesses.Rows.Add(process.MainWindowTitle, Path.GetFileName(process.MainModule.FileName));
                }
            }
            catch (System.ComponentModel.Win32Exception exception)
            {
                MessageBox.Show($"Пропущено: \"{_processName}.exe\" - недостаточно прав." +
                    $"\n\nТребуется запуск с правами Администратора.", 
                    $"{_processName}.exe: {exception.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSubmitSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOSProcesses.SelectedRows)
            {
                // TODO: Pass from the form not the name ".exe" or something else, but some unique value, such as PID
                MessageBox.Show($"Selected: {row.Cells[0].Value.ToString()} | {row.Cells[1].Value.ToString()}");
            }
        }
    }
}
