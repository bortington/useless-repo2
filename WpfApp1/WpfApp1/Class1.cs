using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Blahable
    {
        public string Name { get; set; }

        public bool HasBlah { get; set; }

    }

    public interface IBlah
    {
        void DoThing(Blahable b);
    }

    public class Blahberry : IBlah
    {
        public void DoThing(Blahable b)
        {
            b.HasBlah = true;
        }
    }
}
