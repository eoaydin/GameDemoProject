using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
