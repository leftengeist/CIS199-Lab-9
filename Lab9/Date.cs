using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Date
    {
        private int _month; // 1-12
        private int _day;   // 1-31
        private int _year;  // Positive Integer

        // Precondition:  1 <= m <= 12
        //                1 <= d <= 31
        //                0 <= y
        // Postcondition: Date object is initialized with set month, day, and year
        public Date(int m = 1, int d = 1, int y = 2019)
        {
            Month = m;
            Day = d;
            Year = y;
        }
        
        public int Month
        {
            // Precondition:  None
            // Postcondition: Month is returned
            get
            {
                return _month;
            }

            // Precondition:  1 <= value <= 12
            // Postcondition: Month value is set
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                else
                    _month = 1;
            }
        }
        
        public int Day
        {
            // Precondition:  None
            // Postcondition: Day is returned
            get
            {
                return _day;
            }

            // Precondition:  1 <= value <= 31
            // Postcondition: Day value is set
            set
            {
                if (value >= 1 && value <= 31)
                    _day = value;
                else
                    _day = 1;
            }
        }

        public int Year
        {
            // Precondition:  None
            // Postcondition: Year is returned
            get
            {
                return _year;
            }

            // Precondition:  0 <= value
            // Postcondition: Year value is set
            set
            {
                if (value >= 0)
                    _year = value;
                else
                    _year = 2019;
            }
        }

        // Precondition:  None
        // Postcondition: A result string is formed and returned
        public override string ToString()
        {
            string result = $"{Month:D2}/{Day:D2}/{Year:D4}";   // A result format is set
            return result;
        }
    }
}
