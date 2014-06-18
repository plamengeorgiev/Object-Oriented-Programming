using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public class School
    {
        private List<Class> classes;

        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
            set
            {
                this.classes = value;
            }
        }

        public School()
        {
            this.Classes = new List<Class>();
        }
    }
}
