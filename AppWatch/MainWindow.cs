using AppWatch.View;
using Microsoft.Extensions.Logging;

namespace AppWatch
{
    
    public partial class MainWindow : Form
    {
        private readonly ILogger<MainWindow> _logger;

        private TrackedProcessView processView = new();

        public MainWindow(ILogger<MainWindow> logger)
        {
            _logger = logger;
            InitializeComponent();

            _logger.LogInformation("Program started!");
            processView.UpdateTrackedProcesses(dataGridViewProcesses);
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            processView.UpdateTrackedProcesses(dataGridViewProcesses);

            SelectProcess selectProcessForm = new(_logger);
            selectProcessForm.Show();
        }
    }
}