using System;

class MainClass
{
    public static void Main(string[] args)
    {

        
    }
    class Address
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public Address(string city, string region, string postalCode, string country)
        {
            this.City = city;
            this.Region = region;
            this.PostalCode = postalCode;
            this.Country = country;
        }
        public string show()
        {
            return "address";
        }
    }
    class Product
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
    abstract class Delivery
    {
        public Address address;
        public Delivery(string city, string region, string postalCode, string country)
        {
            address = new Address(city, region, postalCode, country);
            address.City=city;
            address.Region = region;
            address.PostalCode = postalCode;
            address.Country = country;
        }
    }
    
    class HomeDelivery : Delivery
    {
        /* ... */
    }

    class PickPointDelivery : Delivery
    {
        /* ... */
    }

    class ShopDelivery : Delivery
    {
        /* ... */
    }

    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;
        public List<Product> Product_list;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address.show());
        }

        // ... Другие поля
    }



}