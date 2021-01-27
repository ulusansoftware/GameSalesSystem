using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSystem
{
    interface ICustomerControlService
    {
        bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
