using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_lab1
{
    public class CustomItem
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int ID { get; set; }

        public int IDLocal { get; set; }

        public override string ToString()
        {
            return string.Format("{0}. {1} с кодом {2}", this.IDLocal, this.Name, this.Code);
            //return base.ToString();
        }

        public CustomItem()
        {
            this.Name = "Новый элемент";
            this.Code = "new_spec";
            this.ID = -1;
            this.IDLocal = -1;
        }

    }
}
