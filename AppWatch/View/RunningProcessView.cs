using AppWatch.ViewModel;

namespace AppWatch.View
{
    internal class RunningProcessView
    {
        private readonly RunningProcessViewModel _viewModel;

        public RunningProcessView()
        {
            _viewModel = new RunningProcessViewModel();
        }

        public void UpdateUserProcesses(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            foreach (var process in _viewModel.Processes)
            {
                dataGridView.Rows.Add(process.Title, process.Executable, process.CommandLine, process.Path);
            }
        }
    }
}
