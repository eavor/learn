using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericBate.Extend
{
    public class CCTest
    {
        public void Show()
        {
            {
                Bird bird1 = new Bird();
                Bird bird2 = new Sparrow();
                Sparrow sparrow1 = new Sparrow();
                //Sparrow sparrow2 = new Bird();            
            }

            {
                List<Bird> birdList1 = new List<Bird>();
                // List<Bird> birdList2 = new List<Sparrow>();

                List<Bird> birrdList3 = new List<Sparrow>().Select(s => (Bird)s).ToList();
            }

            //协变
            {
                IEnumerable<Bird> birdList1 = new List<Bird>();
                IEnumerable<Bird> birdLlist2 = new List<Sparrow>();
            }
            {
                ICustomerListOut<Bird> customerList1 = new CustomerListOut<Bird>();
                ICustomerListOut<Bird> customerList2 = new CustomerListOut<Sparrow>();
            }
            //逆变
            {
                //List<Sparrow> birdList2 = new List<Bird>();
                ICustomerListIn<Sparrow> birdList1 = new CustomerListIn<Bird>();


            }
        }
    }
    public class Bird
    {
        public int Id { get; set; }
    }
    public class Sparrow : Bird
    {
        public string Name { get; set; }
    }

}
