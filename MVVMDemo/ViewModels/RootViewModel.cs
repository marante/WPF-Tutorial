namespace MVVMDemo.ViewModels
{
    public class RootViewModel
        : ViewModelBase
    {
        private TeacherViewModel teacherView;

        public TeacherViewModel TeacherView
        {
            get => teacherView;
            set
            {
                teacherView = value;
                NotifyOfPropertyChange(() => TeacherView);
            }
        }

        private StudentViewModel studentView;

        public StudentViewModel StudentView
        {
            get => studentView;
            set
            {
                studentView = value;
                NotifyOfPropertyChange(() => StudentView);
            }
        }

        public RootViewModel()
        {
            TeacherView = new TeacherViewModel();
            StudentView = new StudentViewModel();
        }
    }
}