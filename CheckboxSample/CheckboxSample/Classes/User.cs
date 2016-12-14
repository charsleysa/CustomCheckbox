using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckboxSample.Classes
{
    public class User
    {
        /// <summary>
        /// The name of the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Defines if the user is selected.
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// OpenId des Users.
        /// </summary>
        public string OpenId { get; set; }

        public User(string userName, bool isSelected, string openId)
        {
            UserName = userName;
            IsSelected = isSelected;
            OpenId = openId;
        }
    }
}
