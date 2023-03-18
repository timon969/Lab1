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

namespace KMA.ProgramingInCSharp.Lab1.Tools.Controls
{
    /// <summary>
    /// Interaction logic for ChooseBirthday.xaml
    /// </summary>
    public partial class ChooseBirthday : UserControl
    {
        public event Action<object, RoutedEventArgs> DateChanged;
                
            
        

        public DateTime Birthday
        {
            get
            {
                return (DateTime)Calendar.SelectedDate;
            }
            set
            {
                Calendar.SelectedDate = value;
            }
        }

     

        public ChooseBirthday()
        {
            InitializeComponent();
        }

        private void Calendar_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateChanged?.Invoke(sender, e);

        }
    }
}
