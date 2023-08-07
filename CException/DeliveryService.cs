using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CException
{
    public class DeliveryService
    {
        private readonly static Random random = new Random();

        public void Start(Delivery delivery)
        {
            Process(delivery);
            Ship(delivery);
            Transit(delivery);
            Deliver(delivery);

        }
        private void Process(Delivery delivery)
        {
            FakeIt("Processing");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("unable to process the item");
            }
            delivery.DelivaryStatus = DeliveryStatus.PROCESSED;
        }
        private void Ship(Delivery delivery)
        {
            FakeIt("Shipping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Parcel is damaged during the loading the process");
            }
            delivery.DelivaryStatus = DeliveryStatus.SHIPPED;
        }
        private void Transit(Delivery delivery)
        {
            FakeIt("On Its way");
            delivery.DelivaryStatus = DeliveryStatus.INTRANSIT;
        }
        private void Deliver(Delivery delivery)
        {
            FakeIt("Delivering");
            delivery.DelivaryStatus = DeliveryStatus.DELIVARED;
        }
        private void FakeIt(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine(".");
        }
    }
}
