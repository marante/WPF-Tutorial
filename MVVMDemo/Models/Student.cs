using MVVMDemo.ViewModels;

namespace MVVMDemo.Models
{
    public class Student
        : ViewModelBase
    {
        private string firstName;

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        private string lastName;

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName => $"{FirstName} {LastName}";
    }
}