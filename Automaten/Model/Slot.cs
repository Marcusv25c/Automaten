using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Model
{
    internal class Slot
    {
        private string _id; 
        private Product _product; 

        protected string Id { get { return _id; } set { _id = value; } }
        protected Product Product { get { return _product; } set { _product = value; } }


    }
}
