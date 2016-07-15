using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_25_Polymorphism_pt2
{
    public class A
    {
        public virtual void Method()
        {
            Console.WriteLine("method of class A");
        }
    }

    public class B : A
    {
        public override void Method()
        {
            Console.WriteLine("method of class B");
        }
    }

    public class C : B
    {
        public new void Method()
        {
            Console.WriteLine("method of class C");
        }
    }

    public class D : C
    {
        public virtual void Method()
        {
            Console.WriteLine("method of class D");
        }
    }

    public class Z : A
    {
        public sealed override void Method()
        {
            Console.WriteLine("method of class Z");
        }
    }

    public class X : Z
    {
        public virtual void Method()
        {
            Console.WriteLine("method of class X");
        }
    }

    public class R : A
    {
        public void Method()
        {
            Console.WriteLine("method of class R");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A aa = new A();
            aa.Method();
            aa = new B();
            aa.Method();
            aa = new C();
            aa.Method();
            aa = new D();
            aa.Method();
            aa = new Z();
            aa.Method();
            aa = new X();
            aa.Method();
            aa = new R();
            aa.Method();
        }
    }
}
