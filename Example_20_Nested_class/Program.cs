using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_20_Nested_class
{
    public class Container
    {
        private int _container_var;
        public Container(int nested_var)
        {
            NestedClass1 n1 = new NestedClass1();
            n1._nested_var = nested_var;
        }

        class NestedClass1
        {
            public int _nested_var;
        }

        public class NestedClass2
        {
            private Container _container;
            public NestedClass2(Container container, int container_var)
            {
                this._container = container;
                this._container._container_var = container_var;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Container mainContainer = new Container(5);
            
            Container.NestedClass2 nestedClass = new Container.NestedClass2(mainContainer, 5);
        }
    }
}
