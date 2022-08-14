using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreateIterator : IIterator
    {
        ConcreateAggregate aggregate;
        int currentIndex = 0;

        public ConcreateIterator(ConcreateAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public object CurrentItem()
        {
            return aggregate[currentIndex];
        }

        public object First()
        {
            return aggregate[0];
        }

        public bool IsDone()
        {
            return currentIndex >= aggregate.Count();
        }

        public object Next()
        {
            if (currentIndex < aggregate.Count()-1)
            {
                return aggregate[++currentIndex];
            }
            else
            {
                return null;
            }
        }
    }
}
