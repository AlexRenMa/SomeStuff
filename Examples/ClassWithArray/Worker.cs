using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithArray
{
    class Worker//класс рабочий
    {
        public string Name { get; set; }//поле имя
        public int Age { get; set; }//поле возраст
        public int Salary { get; set; }//поле зарплата

        public string Info() => $"имя рабочего:{this.Name} возраст рабочего:{this.Age} зарплата рабочего:{this.Salary}";
        //метод для удобного вывода данных в современной форме(=>)              
    }
}
