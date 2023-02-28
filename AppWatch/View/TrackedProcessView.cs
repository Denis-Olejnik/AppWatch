using AppWatch.ViewModel;

namespace AppWatch.View
{
    internal class TrackedProcessView
    {
        private readonly TrackedProcessViewModel _viewModel;

        public TrackedProcessView()
        {
            _viewModel = new TrackedProcessViewModel();
        }

        public void UpdateTrackedProcesses(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            foreach (var process in _viewModel.Processes)
            {
                dataGridView.Rows.Add(process.Title, process.Executable, process.CommandLine, process.Path);
            }
        }
    }
}
