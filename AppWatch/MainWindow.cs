using AppWatch.View;
using System.Diagnostics;

namespace AppWatch
{
    public partial class MainWindow : Form
    {
        private RunningProcessView processView = new();

        public MainWindow()
        {
            InitializeComponent();
            processView.UpdateUserProcesses(dataGridViewProcesses);
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            processView.UpdateUserProcesses(dataGridViewProcesses);

            SelectProcess selectProcessForm = new SelectProcess();
            selectProcessForm.Show();
        }

        private void dataGridViewProcesses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Debug.WriteLine($"Try to remove: {senderGrid.SelectedRows[0].Cells[0].Value}");
            }
        }
    }
}