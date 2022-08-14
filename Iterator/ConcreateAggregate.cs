using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreateAggregate : AAggregate
    {
        List<object> list = new List<object>();
        public object this[int index] 
        {
            get { return list[index]; }
            set { list.Insert(index, value); } 
        }

        public override IIterator CreateIterator()
        {
            return new ConcreateIterator(this);
        }

        public int Count()
        {
            return list.Count;
        }

    }
}
