using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22MayısUygulamaSınavı
{

    public class CheckoutCounter
    {
        private bool orderTakingStatus;
        private const int counterCount = 3;
        private List<Employee> employees;

        public CheckoutCounter()
        {
            orderTakingStatus = true;
            employees = new List<Employee>();
        }

        public void TakeOrder()
        {
            if (CounterAvailable() && orderTakingStatus)
            {
                Employee employee = employees.FirstOrDefault(e => !e.IsBusy && e.Role == Role.Cashier);
                if (employee != null)
                {
                    employee.TakeOrder();
                    Console.WriteLine($"Sipariş alındı. Çalışan: {employee.FirstName} {employee.LastName}");
                }
                else
                {
                    Console.WriteLine("Boşta kasiyer bulunmamaktadır.");
                }
            }
            else
            {
                Console.WriteLine("Şu anda sipariş alınmamaktadır.");
            }
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public void ChangeOrderTakingStatus(bool status)
        {
            orderTakingStatus = status;
        }

        private bool CounterAvailable()
        {
            return employees.Count < counterCount;
        }
    }


}

