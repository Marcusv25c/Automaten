using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Repo
{
    internal interface IProductRepo
    {
        public void Create(string name, int price);
    }
}
