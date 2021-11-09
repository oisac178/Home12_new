using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home12
{
    public class Department
    {
        public string Name { get; set; }
        public uint SalaryAll { get; set; }
        public uint SalaryHead { get; set; }
        public uint IDDept { get; set; }
        public ObservableCollection<Department> Inner { get; set; } = new ObservableCollection<Department>();
        public ObservableCollection<Human> Employee { get; set; } = new ObservableCollection<Human>();
    }
}
