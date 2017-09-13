using System.ComponentModel;

namespace MVVMDemo.Models
{
    public class TeacherModel
    {
    }

    public class Teacher : INotifyPropertyChanged
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value) return;
                _firstName = value;
                RaisePropertyChanged("FirstName");
                RaisePropertyChanged("FullName");
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName == value) return;
                _lastName = value;
                RaisePropertyChanged("LastName");
                RaisePropertyChanged("FullName");
            }
        }

        public string FullName => _firstName + " " + _lastName;


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            // This is the same as checking if (PropertyChanged != null)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}