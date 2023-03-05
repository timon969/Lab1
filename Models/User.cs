using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum WesternZodiacSigns
{
    Aries,
    Taurus,
    Gemini,
    Cancer,
    Leo,
    Virgo,
    Libra,
    Scorpio,
    Sagittarius,
    Capricorn,
    Aquarius,
    Pisces,
}

public enum ChineseZodiacSigns
{
    Rat,
    Ox,
    Tiger,
    Rabbit,
    Dragon,
    Snake,
    Horse,
    Ram,
    Monkey,
    Rooster,
    Dog,
    Pig,
}
namespace KMA.ProgramingInCSharp.Lab1.Models
{
    internal class User
    {
        private DateTime _birthday;

        #region Propesties
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public int Age
        {
            get 
            {
                return (_birthday.DayOfYear <= DateTime.Now.DayOfYear) ?  DateTime.Now.Year - _birthday.Year :  DateTime.Now.Year - _birthday.Year - 1;
            }
        }

        public WesternZodiacSigns WestZodiacSigns
        {
            get
            {
                return CalculateWesternZodiac();
            }
        }

        public ChineseZodiacSigns ChineseZodiacSigns
        {
            get
            {
                return CalculateChenesZodiac();
            }
        }

        public bool IsBirthday
        {
            get
            {
                
               return (_birthday.Month == DateTime.Now.Month && _birthday.Day == DateTime.Now.Day) ? true : false;
            }
        }

        public bool IsCorrect
        {
            get
            {
                return !( (Birthday > DateTime.Now) || (Age > 135) );
            }
        }



        #endregion

        private WesternZodiacSigns CalculateWesternZodiac()
        {
            var dayOfYear = Birthday.DayOfYear;

            if (Birthday.Year%4 == 0 && Birthday.Month >= 3)
            {
                dayOfYear--;
            }

            
            if (dayOfYear >= new DateTime(1901, 3, 21).DayOfYear && dayOfYear <= new DateTime(1901, 4, 19).DayOfYear)
            {
                return WesternZodiacSigns.Aries;
            }
            else if(dayOfYear >= new DateTime(1901, 4, 20).DayOfYear && dayOfYear <= new DateTime(1901, 5, 20).DayOfYear)
            {
                return WesternZodiacSigns.Taurus;
            }
            else if (dayOfYear >= new DateTime(1901, 5, 21).DayOfYear && dayOfYear <= new DateTime(1901, 6, 22).DayOfYear)
            {
                return WesternZodiacSigns.Gemini;
            }
            else if (dayOfYear >= new DateTime(1901, 6, 23).DayOfYear && dayOfYear <= new DateTime(1901, 7,22).DayOfYear)
            {
                return WesternZodiacSigns.Cancer;

            }
            else if (dayOfYear >= new DateTime(1901, 7, 23).DayOfYear && dayOfYear <= new DateTime(1901, 8,22).DayOfYear)
            {
                return WesternZodiacSigns.Leo;
            }
            else if (dayOfYear >= new DateTime(1901, 8, 23).DayOfYear && dayOfYear <= new DateTime(1901, 9, 22).DayOfYear)
            {
                return WesternZodiacSigns.Virgo;
            }
            else if (dayOfYear >= new DateTime(1901, 9, 23).DayOfYear && dayOfYear <= new DateTime(1901, 10, 23).DayOfYear)
            {
                return WesternZodiacSigns.Libra;
            }
            else if (dayOfYear >= new DateTime(1901, 10, 24).DayOfYear && dayOfYear <= new DateTime(1901, 11, 21 ).DayOfYear)
            {
                return WesternZodiacSigns.Scorpio;
            }
            else if (dayOfYear >= new DateTime(1901, 11, 22).DayOfYear && dayOfYear <= new DateTime(1901, 12, 19).DayOfYear)
            {
                return WesternZodiacSigns.Sagittarius;
            }
            else if ((dayOfYear >=new DateTime(1901, 12, 20).DayOfYear  &&  dayOfYear <= 365)  || dayOfYear <= new DateTime(1901, 1, 20).DayOfYear)
            {
                return WesternZodiacSigns.Capricorn;
            }
            else if (dayOfYear >= new DateTime(1901, 1, 21).DayOfYear && dayOfYear <= new DateTime(1901, 2, 18).DayOfYear)
            {
                return WesternZodiacSigns.Aquarius;
            }
            else
            {
                return WesternZodiacSigns.Pisces;
            }


        }


        private ChineseZodiacSigns CalculateChenesZodiac()
        {
            var dayOfYear = Birthday.DayOfYear;

            if (Birthday.Year%4 == 0 && Birthday.Month >= 3)
            {
                dayOfYear--;
            }


            if ( (dayOfYear >=new DateTime(1901, 12, 6).DayOfYear  &&  dayOfYear <= 365)  || dayOfYear <= new DateTime(DateTime.Now.Year , DateTime.Now.Month, (Int32) 05).DayOfYear)
            {
                return ChineseZodiacSigns.Rat;
            }
            else if (dayOfYear >= new DateTime(1901, 1, 6).DayOfYear && dayOfYear <= new DateTime(1901, 2,3).DayOfYear)
            {
                return ChineseZodiacSigns.Ox;
            }
            else if (dayOfYear >= new DateTime(1901, 2, 4).DayOfYear && dayOfYear <= new DateTime(1901, 3, 5).DayOfYear)
            {
                return ChineseZodiacSigns.Tiger;
            }
            else if (dayOfYear >= new DateTime(1901, 3, 6).DayOfYear && dayOfYear <= new DateTime(1901, 4, 5).DayOfYear)
            {
                return ChineseZodiacSigns.Rabbit;

            }
            else if (dayOfYear >= new DateTime(1901, 4, 6).DayOfYear  && dayOfYear <= new DateTime(1901, 5, 5).DayOfYear)
            {
                return ChineseZodiacSigns.Dragon;
            }
            else if (dayOfYear >= new DateTime(1901, 5, 6).DayOfYear  && dayOfYear <= new DateTime(1901, 6, 5).DayOfYear)
            {
                return ChineseZodiacSigns.Snake;
            }
            else if (dayOfYear >= new DateTime(1901, 6, 6).DayOfYear  && dayOfYear <= new DateTime(1901, 7, 5).DayOfYear)
            {
                return ChineseZodiacSigns.Horse;
            }
            else if (dayOfYear >= new DateTime(1901, 7, 6).DayOfYear  && dayOfYear <= new DateTime(1901, 8, 5).DayOfYear)
            {
                return ChineseZodiacSigns.Ram;
            }
            else if (dayOfYear >= new DateTime(1901, 8, 6).DayOfYear  && dayOfYear <= new DateTime(1901, 8, 5).DayOfYear)
            {
                return ChineseZodiacSigns.Monkey;
            }
            else if (dayOfYear >= new DateTime(1901, 9, 6).DayOfYear  && dayOfYear <= new DateTime(1901, 8, 5).DayOfYear)
            {
                return ChineseZodiacSigns.Rooster;
            }
            else if (dayOfYear >= new DateTime(1901, 10, 6).DayOfYear  && dayOfYear <= new DateTime(1901, 11, 5).DayOfYear)
            {
                return ChineseZodiacSigns.Dog;
            }
            else
            {
                return ChineseZodiacSigns.Pig;
            }


        }
    }

    
}
