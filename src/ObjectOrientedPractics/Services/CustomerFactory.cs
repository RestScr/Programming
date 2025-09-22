using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс фабрики покупателей
    /// </summary>
    internal static class CustomerFactory
    {
        public static Customer GenerateCustomer()
        {
            return new Customer("New Customer", "Address");
        }
    }
}
