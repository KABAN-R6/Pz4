using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Date:Tread
    {
        public int _day;
        public int _month;
        public int _year;
        public Date(int d, int m)
        {
            _day = d;
            _month = m;
            
        }
        public void Read(int d, int m)
        {
            _day = d;
            _month = m;
           
        }
        public void Display()
        {
            Console.WriteLine($"год {year} , день{_day}, месяц {_month} ");
           
        }
        
    }

    
   
   
}



