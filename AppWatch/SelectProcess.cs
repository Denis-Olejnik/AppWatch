using AppWatch.Model;
using AppWatch.ViewModel;
using Microsoft.Extensions.Logging;
using System.Diagnostics;


namespace AppWatch
{
    public partial class SelectProcess : Form
    {
        private readonly ILogger _logger;

        public SelectProcess(ILogger logger)
        {
            InitializeComponent();
            
            _logger = logger;
            GetListOSProcesses();
        }

        private List<Process> processesList = new();

        public void GetListOSProcesses()
        {
            string _processName = string.Empty;
            try
            {
                dataGridViewOSProcesses.Rows.Clear();

                Process[] processes = Process.GetProcesses();
                foreach (Process item in processes)
                {
                    if (string.IsNullOrEmpty(item.MainWindowTitle)) continue;

                    _processName = item.ProcessName;
                    dataGridViewOSProcesses.Rows.Add(item.MainWindowTitle, Path.GetFileName(item.MainModule.FileName));

                    processesList.Add(item);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                MessageBox.Show(exception.StackTrace, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save selected processes in the database
        /// </summary>
        private void buttonSubmitSelected_Click(object sender, EventArgs e)
        {
            TrackedProcess process = new();
            TrackedProcessViewModel processViewModel = new();

            foreach (DataGridViewRow row in dataGridViewOSProcesses.SelectedRows)
            {
                string? processPath = processesList[row.Index].MainModule.FileName;
                string? processExecutable = Path.GetFileName(processPath);

                process.Title = processesList[row.Index].MainWindowTitle;
                process.Executable = processExecutable;
                process.Path = processPath;
                //item.CommandLine = processesList[row.Index].StartInfo.Arguments;
                process.CommandLine = "${process_args}";

                processViewModel.AddProcess(process);
            }
        }
    }
}
