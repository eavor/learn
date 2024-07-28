using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericBate.Extend
{
    public interface ICustomerListOut<out T>
    {
        T GetT();
    }

    public class CustomerListOut<T> : ICustomerListOut<T>
    {
        public T GetT()
        {
            return default(T);
        }
    }

    //逆变
    public interface ICustomerListIn<in T>
    {
        void GetT(T t);
    }

    public class CustomerListIn<T> : ICustomerListIn<T>
    {
        public void GetT(T t)
        {
            return;
        }
    }
}
