using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WT_Task_2
{
    class Account
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IDNumber { get; set; }
        public Double Balans { get; set; }

        public Account(string name, string surname, int id)
        {
            Name = name;
            Surname = surname;
            IDNumber = id;
            Balans = 0;
        }

    }
}
