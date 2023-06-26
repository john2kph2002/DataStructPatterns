using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.LinkList
{
    public class GenericNode<T>
    {
        public T Value { get; set; }
        public GenericNode<T> Next { get; set; }

        public GenericNode(T value)
        {
            this.Value = value;
        }      
    }
}
