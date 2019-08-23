using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WT_Task_1
{
    class ArrayMetods
    {
        public string[] arr { get; set; }
        public ArrayMetods(string array)
        {
            arr = array.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
         
        }
    }
}
