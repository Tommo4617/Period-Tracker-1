using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Period_tracker_1
{
<<<<<<< Updated upstream

=======
    internal class User
    {
        private string username { get; set; }
        private string password { get; set; }

        private DateTime lastPeriodStart { get; set; }

        List<string> symptoms { get; set; } = new List<string>();

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
>>>>>>> Stashed changes
}
