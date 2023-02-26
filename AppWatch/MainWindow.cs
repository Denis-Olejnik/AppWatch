using AppWatch.View;

namespace AppWatch
{
    public partial class MainWindow : Form
    {
        private ProcessView processView = new();

        public MainWindow()
        {
            InitializeComponent();
            processView.UpdateProcesses(dataGridViewProcesses);
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            SelectProcess selectProcessForm = new SelectProcess();
            selectProcessForm.Show();
        }
    }
}