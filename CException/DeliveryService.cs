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
            try 
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliver(delivery);
            }
            catch (AccidentException ex)
            {
                // لو مكتبناش حاجه هنا هيبقى swallow Exception;
                Console.WriteLine($"There was an accident at {ex.Location} preventing us from delivering you parcel: {ex.Message}");
                delivery.DelivaryStatus = DeliveryStatus.UNKNOWN;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Deliver Fails due to: {ex.Message}");
                delivery.DelivaryStatus = DeliveryStatus.UNKNOWN;
            }
            finally 
            {
                Console.WriteLine("End");
            }
            

        }
        private void Process(Delivery delivery)
        {
            FakeIt("Processing");
            if (random.Next(1, 10) == 1)
            {
                throw new InvalidOperationException("unable to process the item");
            }
            delivery.DelivaryStatus = DeliveryStatus.PROCESSED;
        }
        private void Ship(Delivery delivery)
        {
            FakeIt("Shipping");
            if (random.Next(1, 10) == 1)
            {
                throw new InvalidOperationException("Parcel is damaged during the loading the process");
            }
            delivery.DelivaryStatus = DeliveryStatus.SHIPPED;
        }
        private void Transit(Delivery delivery)
        {
            FakeIt("On Its way");
            if (random.Next(1, 5) == 1)
            {
                throw new AccidentException("354 some another street", "ACCIDENT !!!");
            }
            delivery.DelivaryStatus = DeliveryStatus.INTRANSIT;
        }
        private void Deliver(Delivery delivery)
        {
            FakeIt("Delivering");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidAddressExcption($"'{delivery.Address}' is invalid !!!");
            }
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
