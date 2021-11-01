using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Home12
{
    public class MainWindowVM : ViewModelBase
    {
        public ObservableCollection<Department> Departments { get; set; } = new ObservableCollection<Department>();
        private Department selectDepart;

        private RelayCommand addCommand;
        private RelayCommand delCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                    Department departament = new Department { Name = "2345" };
                    for (int i = 1; i < 10; i++)
                    {
                        departament.Employee.Add(new Human("имя"+i, "фамилия"+i, "должность"+i, 1000));
                    }    
                    if (!Departments.Any())
                        {
                            Departments.Add(departament);
                        }
                    else
                        {
                            departament.Name = "{111555}";
                            SelectDepart?.Departments.Add(departament);
                        }
                    }));
            }
        }
        public RelayCommand DelCommand
        {
            get
            {
                return delCommand ??
                    (delCommand = new RelayCommand(obj =>
                    {
                        Department departament = new Department();
                        Departments.Remove(departament);
                        SelectDepart = departament;
                    }));
            }
        }

        public Department SelectDepart
        {
            get { return selectDepart; }
            set 
            {
                selectDepart = value;
                RaisePropertyChanged(nameof(SelectDepart));
            }
        }
    }
}
