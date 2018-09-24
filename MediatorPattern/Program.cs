using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstateMediator mediator = new RealEstateMediator();

            HouseOwner owner = new HouseOwner(1, "Abay", mediator);

            Client client = new Client(1, "Serzhan", mediator);


            owner.HouseAddress = "Zenkova 32";
            owner.SellHouse();


            client.HouseAddress = "Zenkova 32";


            client.BuyHouse();

        }
    }
}
