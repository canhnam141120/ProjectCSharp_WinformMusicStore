using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1432_Group2_Lab3.DTL
{
    public class User
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private int role;
        public int Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
