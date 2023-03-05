using KMA.ProgramingInCSharp.Lab1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KMA.ProgramingInCSharp.Lab1.Views
{
    /// <summary>
    /// Interaction logic for CalculateAgeView.xaml
    /// </summary>
    public partial class CalculateAgeView : UserControl
    {
        private CalculateAgeViewModel _viewModel;



        public CalculateAgeView()
        {
            InitializeComponent();
            DataContext = _viewModel = new CalculateAgeViewModel();
        }

        private void ChooseBirthday_DateChanged(object arg1, RoutedEventArgs arg2)
        {

            _viewModel.Birthday = BirthdayInformation.Birthday;

            if (!_viewModel.IsCorrect)
            {
                MessageBox.Show("The age is incorrect");
                Age.Text = "";
                WesternZodiac.Text = "";
                ChineseZodiac.Text = "";
                
            }
            else
            {
                Age.Text = $"Age - {_viewModel.Age}";
                WesternZodiac.Text = $"In Western astrological system: {_viewModel.WesternZodiacSigns}";
                ChineseZodiac.Text = $"In Estern astrological system: {_viewModel.ChineseZodiacSigns}";

            }

            if (_viewModel.IsBirthday)
            {
                MessageBox.Show("Happy birthday");
            }



        }

       
    }
}
