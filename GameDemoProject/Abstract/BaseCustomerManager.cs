using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Your Account Has Been Successfully Closed!");
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("The Account Has Been Successfully Created. Welcome " + customer.FirstName);
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Your Info Has Been Successfully Updated!");
        }
    }
}
