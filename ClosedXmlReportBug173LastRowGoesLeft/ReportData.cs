using System.Collections.Generic;

namespace ClosedXmlReportBug173LastRowGoesLeft
{
    public class ReportData
    {
        public int Id { get; set; }
        public IList<Customer> Customers { get; set; }
        public static ReportData GetExample()
        {
            var reportData = new ReportData();
            reportData.Id = 2;
            reportData.Customers = new List<Customer>();
            var a = new Customer() { Name = "qwe", Balance = "234", SomeSpecInfo = "zzz" };
            reportData.Customers.Add(a);
            reportData.Customers.Add(a);

            foreach (var customer in reportData.Customers)
            {
                customer.Orders = new List<Order>();
                var b = new Order() { Number = "777", Price = "123" };
                customer.Orders.Add(b);
                customer.Orders.Add(b);
            }
            return reportData;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public string SomeSpecInfo { get; set; }

        public IList<Order> Orders { get; set; }
    }
    public class Order
    {
        public string Number { get; set; }
        public string Price { get; set; }
    }
}
