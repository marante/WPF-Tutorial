using MVVMDemo.Core;
using MVVMDemo.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVMDemo.ViewModels
{
    public class TeacherViewModel
        : ViewModelBase
    {
        private ObservableCollection<Teacher> _teachers;

        public ObservableCollection<Teacher> Teachers
        {
            get { return _teachers; }
            set
            {
                _teachers = value;
                NotifyOfPropertyChange(() => Teachers);
            }
        }

        private Teacher _selectedTeacher;

        public Teacher SelectedTeacher
        {
            get { return _selectedTeacher; }
            set
            {
                _selectedTeacher = value;
                NotifyOfPropertyChange(() => SelectedTeacher);
            }
        }

        public TeacherViewModel()
        {
            LoadTeachers();
        }

        public ICommand DeleteTeacher => new FlexCommand(
            t => { Teachers.Remove(SelectedTeacher); },
            t => SelectedTeacher != null);

        public void LoadTeachers()
        {
            _teachers = new ObservableCollection<Teacher>
            {
                new Teacher() {FirstName = "Mark", LastName = "Jacobs"},
                new Teacher() {FirstName = "Steve", LastName = "Jobs"},
                new Teacher() {FirstName = "Tim", LastName = "Cook"}
            };
        }
    }
}