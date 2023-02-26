using AppWatch.Model;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using Process = AppWatch.Model.Process; // This doesn't look very cool. TODO: Fix it?

namespace AppWatch.ViewModel
{
    internal class ProcessViewModel : INotifyPropertyChanged
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        private readonly ProcessDataContext dataContext;
        private List<Process> processes;

        public event PropertyChangedEventHandler PropertyChanged;

        public ProcessViewModel()
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            dataContext = new ProcessDataContext();
            processes = dataContext.GetProcesses();
        }

        public List<Process> Processes
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

        public void AddProcess(Process process)
        {
            dataContext.AddProcess(process);
            Processes = dataContext.GetProcesses();
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
