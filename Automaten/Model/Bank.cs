using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Model
{
    internal class Bank
    {
        private int _excess; 
        private Dictionary<string, int> _change = new Dictionary<string, int>();
        private int _total;

        protected int Excess { get { return _excess; } set { _excess = value; } }
        protected Dictionary<string, int> Change { get { return _change; } set { _change = value; } }
        protected int Total { get { return _total; } set { _total = value; } }

    }
}
