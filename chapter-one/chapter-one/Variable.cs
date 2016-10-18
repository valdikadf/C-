using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_one
{
    public class Variable
    {
        private string Name;
        private double Value;

        public Variable(string name)
        {
            Name = name;
        }

        public bool IsName(string name)
        {
            return this.Name.Equals(name, StringComparison.Ordinal);
        }
        
        public void SetValue(double value)
        {
            this.Value = value;
        }
        
        public double GetValue(){ return this.Value; }        
    }
}
  