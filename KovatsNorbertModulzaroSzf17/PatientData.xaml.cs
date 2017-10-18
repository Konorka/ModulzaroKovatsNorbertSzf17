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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace KovatsNorbertModulzaroSzf17
{
    /// <summary>
    /// Interaction logic for PatientData.xaml
    /// </summary>
    public partial class PatientData : Window
    {
        
        public PatientData()
        {
            InitializeComponent();
            MainWindow.saveButton = false;
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            
            string nameTB = patientNameTextBox.Text;
            string bLocationTB = patientBLocationTextBox.Text;
            int TAJTB = int.Parse(patientTAJTextBox.Text);
            string bDateDP = patientBDateDatePicker.Text;

            if (string.IsNullOrEmpty(nameTB))
            {
                MessageBox.Show("A Beteg neve mező üres, kérem töltse ki");
                return;
            }
            if (string.IsNullOrEmpty(bLocationTB))
            {
                MessageBox.Show("A Születési hely mező üres, kérem töltse ki");
                return;
            }
            if (TAJTB == null)
            { 
                MessageBox.Show("A TAJ szám mező üres, kérem töltse ki");
                return;
            }
            if (string.IsNullOrEmpty(bDateDP))
            { 
                MessageBox.Show("A Születési Dátum mező üres, kérem töltse ki");
                return;
            }   
            MainWindow.saveButton = true;
            DialogResult = false;

        }

        private void TAJFocus(object sender, RoutedEventArgs e)
        {
            if (patientTAJTextBox.Text == "0")
            {
            patientTAJTextBox.Text = "";

            }
        }
    }
}
