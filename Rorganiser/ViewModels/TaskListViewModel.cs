using Roganiser.Models;
using Rorganiser.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rorganiser.ViewModels
{
    public class TaskListViewModel
    {
        private RogDbContext _context;
        public ObservableCollection<TaskList> TaskList { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public TaskListViewModel() 
        {
            _context = new RogDbContext();
            TaskList = new ObservableCollection<TaskList>();
            LoadTaskLists();
        }
        private void LoadTaskLists()
        {            
            var taskListsFromDb = _context.TaskList.ToList();
            if (!taskListsFromDb.Where(tl => tl.Title == "General").Any())
            {
                var defaultTaskList = ReturnGeneralTaskList();
                _context.TaskList.Add(defaultTaskList);
                _context.SaveChanges();
                taskListsFromDb = _context.TaskList.ToList();
            }            
            TaskList.Clear();
            foreach (var taskList in taskListsFromDb)
            {
                TaskList.Add(taskList);
            }           
            OnPropertyChanged(nameof(TaskList));
        }
        public TaskList ReturnGeneralTaskList()
        {
            return new TaskList()
            {
                Id = new Guid(),
                Title = "General",
                Description = "",
            };
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
