using AppWatch.Model;
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

        private List<System.Diagnostics.Process> processesList = new();

        public void GetListOSProcesses()
        {
            string _processName = string.Empty;
            try
            {
                dataGridViewOSProcesses.Rows.Clear();
                
                //TODO: Rename the class. "Process" - system class
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
                foreach (System.Diagnostics.Process process in processes)
                {
                    if (string.IsNullOrEmpty(process.MainWindowTitle)) continue;

                    _processName = process.ProcessName;
                    dataGridViewOSProcesses.Rows.Add(process.MainWindowTitle, Path.GetFileName(process.MainModule.FileName));
                    
                    processesList.Add(process);
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
            AppWatch.Model.Process process = new Model.Process();
            AppWatch.ViewModel.ProcessViewModel processViewModel = new AppWatch.ViewModel.ProcessViewModel();

            foreach (DataGridViewRow row in dataGridViewOSProcesses.SelectedRows)
            {
                string? processPath = processesList[row.Index].MainModule.FileName;
                string? processExecutable = Path.GetFileName(processPath);

                process.Title = processesList[row.Index].MainWindowTitle;
                process.Executable = processExecutable;
                process.Path = processPath;
                //process.CommandLine = processesList[row.Index].StartInfo.Arguments;
                process.CommandLine = "${process_args}";

                processViewModel.AddProcess(process);
            }
        }
    }
}
