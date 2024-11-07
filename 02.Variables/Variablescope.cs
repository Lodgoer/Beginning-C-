using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Variables
{
    public class Variablescope
    {
        private int _age;

        public int GetAge()
        {
            int birthDay = 11;

            if (birthDay < 11)
            {
                int birthYear = 2006;
                int birthDay = 18;
            }
           
            return _age;
        }
        
        public void SetAge(int age)
        { 
            this._age = age; 
        }

    }
}
