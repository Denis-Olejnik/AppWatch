using AppWatch.Model;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using Serilog;

namespace AppWatch.ViewModel
{
    internal class TrackedProcessViewModel : INotifyPropertyChanged
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        private static readonly Serilog.ILogger logger = Log.ForContext<TrackedProcessViewModel>();

        private readonly TrackedProcessDataContext dataContext;
        private List<TrackedProcess> processes;

        public event PropertyChangedEventHandler PropertyChanged;

        public TrackedProcessViewModel()
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            dataContext = new TrackedProcessDataContext();
            processes = dataContext.GetProcesses();
        }

        public List<TrackedProcess> Processes
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

        public void AddProcess(TrackedProcess process)
        {
            dataContext.AddProcess(process);
            Processes = dataContext.GetProcesses();
            logger.Debug("Added new process: {@Process}", process);
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
