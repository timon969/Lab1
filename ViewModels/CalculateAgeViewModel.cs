using KMA.ProgramingInCSharp.Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgramingInCSharp.Lab1.ViewModels
{
    internal class CalculateAgeViewModel
    {

        private User _user = new User();


        public DateTime Birthday
        {
            get { return _user.Birthday; }
            set { _user.Birthday = value; }
        }

        public int Age
        {
            get { return _user.Age; }
        }

        public WesternZodiacSigns WesternZodiacSigns
        {
            get { return _user.WestZodiacSigns; }
        }

        public ChineseZodiacSigns ChineseZodiacSigns
        {
            get { return _user.ChineseZodiacSigns; }
        }

        public bool IsCorrect
        {
            get { return _user.IsCorrect; }
        }
        public bool IsBirthday
        {
            get { return _user.IsBirthday; }
        }
    }
        
}
