using AppWatch.Model;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using RunningProcess = AppWatch.Model.RunningProcess; // This doesn't look very cool. TODO: Fix it?

namespace AppWatch.ViewModel
{
    internal class RunningProcessViewModel : INotifyPropertyChanged
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        private readonly RunningProcessDataContext dataContext;
        private List<RunningProcess> processes;

        public event PropertyChangedEventHandler PropertyChanged;

        public RunningProcessViewModel()
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            dataContext = new RunningProcessDataContext();
            processes = dataContext.GetProcesses();
        }

        public List<RunningProcess> Processes
        {
            get { return processes; }
            set
            {
                if (processes != value)
                {
                    processes = value;
                    OnPropertyChanged(nameof(Processes));
                }
            }
        }

        public void AddProcess(RunningProcess process)
        {
            dataContext.AddProcess(process);
            Processes = dataContext.GetProcesses();

            MessageBox.Show($"{process.Path}", "RunningProcess added!");
        }

        public void DeleteProcess(int id)
        {
            dataContext.DeleteProcess(id);
            Processes = dataContext.GetProcesses();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
