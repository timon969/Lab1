using KMA.ProgramingInCSharp.Lab1.Models;
using KMA.ProgramingInCSharp.Practice3.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA.ProgramingInCSharp.Lab1.ViewModels
{
    internal class CalculateAgeViewModel : INotifyPropertyChanged
    {

        private User _user = new User();

        private RelayCommand<object> _proceed;

        private Visibility _isVisibile = Visibility.Hidden;

        private bool _isEnable = true;
        private Visibility _loaderVisibility = Visibility.Collapsed;



        public bool IsEnable
        {
            get => _isEnable;
            set
            {
                _isEnable = value;
                onPropertyChanged();
            }
        }

        public Visibility LoaderVisibility
        {
            get => _loaderVisibility;
            set
            {
                _loaderVisibility = value;
                onPropertyChanged();
            }
        }


        public String FirstName
        {
            get
            {
                return _user.FirstName;
            }

            set
            {
                _user.FirstName = value;
                
            }
        }
        public String LastName
        {
            get
            {
                return _user.LastName;
            }

            set
            {
                _user.LastName = value;
            }
        }
        public String Email
        {
            get
            {
                return _user.Email;
            }

            set
            {
                _user.Email = value;
            }
        }

        public String BirsthdayToString
        {
            get { return $"Date of birth: {_user.Birthday}"; }
        }

        public String WesternZodiacSignsToString
        {
            get { return $"In Western Zodiac: {WesternZodiacSigns}"; }

        }

        public String ChineseZodiacSignsToString
        {
            get { return $"In Chinese Zodiac: {ChineseZodiacSigns}"; }

        }

        public String IsAdultToString
        {
            get { return $"Is Adult: {IsAdult}"; }
        }

        public String IsBirsthdayToString
        {
            get { return $"Is Birthday: {IsBirthday}"; }
        }


        public DateTime Birthday
        {
            get { return _user.Birthday; }
            set { _user.Birthday = value; }
        }

        

        public WesternZodiacSigns WesternZodiacSigns
        {
            get { return _user.WestZodiacSigns; }
        }

        public ChineseZodiacSigns ChineseZodiacSigns
        {
            get { return _user.ChineseZodiacSigns; }
        }
        public bool IsBirthday
        {
            get { return _user.IsBirthday; }
        }
        public bool IsAdult
        {
            get { return _user.IsAdult; }
        }



        public int Age
        {
            get { return _user.Age; }
        }

        public Visibility IsVisibile
        {
            get { return _isVisibile; }
            set
            {
                _isVisibile = value;
                onPropertyChanged();
            }
        }



        public RelayCommand<object> ProceedCommand
        {
            get
            {
                return _proceed ??= new RelayCommand<object>(o => Proceed(), CanExecute); ;
            }
        }

       
        private async void Proceed()
        {
            
            Person user;
            IsEnable = false;
            LoaderVisibility = Visibility.Visible;
            user = await Task.Run(() => new Person(FirstName,LastName,Email,Birthday));
            if (user.IsCorrect)
            {
                LoaderVisibility = Visibility.Collapsed;
                IsVisibile = Visibility.Hidden;
                onPropertyChanged("LastName");
                onPropertyChanged("FirstName");
                onPropertyChanged("Email");
                onPropertyChanged("BirsthdayToString");
                onPropertyChanged("WesternZodiacSignsToString");
                onPropertyChanged("ChineseZodiacSignsToString"); 
                onPropertyChanged("IsAdultToString");
                onPropertyChanged("IsBirthdayToString");
                IsVisibile = Visibility.Visible;
                
                IsEnable = true;
            }
            else
            {
                IsVisibile = Visibility.Hidden;
                LoaderVisibility = Visibility.Collapsed;
                MessageBox.Show("The date of birth is incorrect");
                
                IsEnable = true;
            }
           

            

        }




        private bool CanExecute(Object obj)
        {
            return !String.IsNullOrWhiteSpace(_user.FirstName) && !String.IsNullOrWhiteSpace(_user.LastName) && !String.IsNullOrWhiteSpace(_user.Email) && !String.IsNullOrWhiteSpace(_user.Birthday.ToString());
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
        
}
