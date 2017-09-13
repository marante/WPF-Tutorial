using MVVMDemo.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVMDemo.Core;

namespace MVVMDemo.ViewModels
{
    public class StudentViewModel
        : ViewModelBase
    {
        private ObservableCollection<Student> students;

        public ObservableCollection<Student> Students
        {
            get => students;
            set
            {
                students = value;
                NotifyOfPropertyChange(() => Students);
            }
        }

        private Student selectedStudent;

        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                NotifyOfPropertyChange(() => SelectedStudent);
            }
        }

        public ICommand DeleteStudent => new FlexCommand(
            t => { Students.Remove(SelectedStudent); },
            t => SelectedStudent != null);


        public StudentViewModel()
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            Students = new ObservableCollection<Student>
            {
                new Student {FirstName = "Victor", LastName = "Marante"},
                new Student {FirstName = "Sara", LastName = "Höjrup"},
                new Student {FirstName = "Alexander", LastName = "Arvidsson"}
            };
        }
    }
}