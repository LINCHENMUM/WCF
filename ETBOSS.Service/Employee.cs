using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBOSSService
{
    public class Employee
    {
        private int _id;
        private string _name;
        private DateTime _dob;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
    }
}
