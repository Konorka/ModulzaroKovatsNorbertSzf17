using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KovatsNorbertModulzaroSzf17
{
    class MainViewModel : BaseModel
    {
        public ObservableCollection<Patient> Patients { get; set; }
        
        public MainViewModel()
        { var today = DateTime.Today;
            Patients = new ObservableCollection<Patient>
            {
                new Patient{ Name="Valami János", BLocation="Budapest", BDate="01/04/1990", TAJ=458765248, BNOPass=000001, BNOComm="Betegség23", Age=27},
                new Patient{ Name="Valami Edina", BLocation="Debrecen", BDate="02/11/1981", TAJ=245478951, BNOPass=000002, BNOComm="Betegség56", Age=36},
                new Patient{ Name="Valami Lajos", BLocation="Miskolc", BDate="03/08/1972", TAJ=214748965, BNOPass=000003, BNOComm="Betegség11", Age=45 },
                new Patient{ Name="Valami Krisztina", BLocation="Budapest", BDate="04/08/1963", TAJ=854765423, BNOPass=000004, BNOComm="Betegség11", Age=54 },
                new Patient{ Name="Valami Anna", BLocation="Hatvan", BDate="05/12/1954", TAJ=547883654, BNOPass=000005, BNOComm="Betegség23", Age=63 }

            };

        }
        public Patient SelectedPatient { get; set; }
    }
}
