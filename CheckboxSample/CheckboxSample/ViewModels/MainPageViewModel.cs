using CheckboxSample.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckboxSample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<User> _users;

        /// <summary>
        /// Users to display in the ListView
        /// </summary>
        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("Users"));
                }
            }
        }

        public Command AllCommand { get; set; }

        public MainPageViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User("John", false, "1"));
            Users.Add(new User("Peter", false, "2"));
            Users.Add(new User("Thomas", false, "3"));
            Users.Add(new User("Jefferson", false, "4"));
            Users.Add(new User("Dennis", false, "5"));
            Users.Add(new User("Kevin", false, "6"));

            AllCommand = new Command(() => All());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void All()
        {
            foreach (User user in Users)
            {
                user.IsSelected = true;
            }
            Users = new ObservableCollection<User>(Users);
        }
    }
}
