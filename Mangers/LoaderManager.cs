using KMA.ProgramingInCSharp.Lab1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA.ProgramingInCSharp.Practice3.Managers
{
    internal class LoaderManager
    {
        private static LoaderManager _instance;
        private static readonly object _locker = new object();

        public static LoaderManager Instance
        {
            get
            {
                if(_instance != null)
                    return _instance;
                lock (_locker)
                {
                    return _instance = new LoaderManager();
                }
                
            }
        }

        private CalculateAgeViewModel _loaderOwner;

        private LoaderManager()
        {

        }

        public void Initialize(CalculateAgeViewModel loaderOwner)
        {
            _loaderOwner = loaderOwner;
        }
        public void ShowLoader()
        {
            _loaderOwner.IsEnable = false;
            _loaderOwner.LoaderVisibility = Visibility.Visible;
        }

        public void HideLoader()
        {
            _loaderOwner.IsEnable = true;
            _loaderOwner.LoaderVisibility = Visibility.Collapsed;

        }
    }
}
