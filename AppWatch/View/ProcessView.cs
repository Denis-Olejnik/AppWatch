using AppWatch.ViewModel;

namespace AppWatch.View
{
    internal class ProcessView
    {
        private readonly ProcessViewModel _viewModel;

        public ProcessView()
        {
            _viewModel = new ProcessViewModel();
        }

        public void UpdateProcesses(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            foreach (var process in _viewModel.Processes)
            {
                dataGridView.Rows.Add(process.Title, process.Executable, process.CommandLine, process.Path);
            }
        }
    }
}
