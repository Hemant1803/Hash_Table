using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    internal class MyMapNode<TKey,TValue>
    {
        public TKey Key { get; }
        public TValue Value { get; set; }

        public MyMapNode(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

       
    }
}
