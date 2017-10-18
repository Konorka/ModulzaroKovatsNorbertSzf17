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
using System.Linq;


namespace KovatsNorbertModulzaroSzf17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel _vm = new MainViewModel();
        public static bool saveButton = false;
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _vm;
        }

        private void NewPatientButtonClick(object sender, RoutedEventArgs e)
        {
            var vm = new PatientDataViewModel
            {
                Patient = new Patient()
            };
            var form = new PatientData
            {
                DataContext = vm
            };

            form.ShowDialog();
            if (saveButton == true)
            {
                ((MainViewModel)DataContext).Patients.Add(vm.Patient);
            }

        }

        private void ChangeButtonClick(object sender, RoutedEventArgs e)
        {
            var modiPatient = ((MainViewModel)DataContext).SelectedPatient;

            if (modiPatient == null)
            {
                return;
            }
            var vm = new PatientDataViewModel
            {
                Patient = modiPatient
            };

            var form = new PatientData
            {
                DataContext = vm
            };
            form.ShowDialog();
            
        }

        private void UseButtonClick(object sender, RoutedEventArgs e)
        {
            var selectedPatient = ((MainViewModel)DataContext).SelectedPatient;

            if (selectedPatient == null)
            {
                return;
            }
            var vm = new PatientDataViewModel
            {
                Patient = selectedPatient
            };

            var form = new TreatmentSheetView
            {
                DataContext = vm
            };
            form.ShowDialog();
        }
        public static IEnumerable<Patient> patientSum (IEnumerable<Patient> patient)
        {

            return patient.Sum(x => x.Name);
        }

        private void StatClick(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show(_vm.Patients
                .OrderBy(x => x.BNOPass)
                .First().Name);

            MessageBox.Show(_vm.Patients.Count.ToString());

        }
    }
}
