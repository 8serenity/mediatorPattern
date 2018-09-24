using System.Collections.Generic;

namespace MediatorPattern
{
    public class RealEstateMediator
    {


        public List<HouseOwner> Owners
        {
            get;
            set;
        }



        public List<string> HousesForSale
        {
            get;
            set;
        }

        public RealEstateMediator()
        {
            Owners = new List<HouseOwner>();
            HousesForSale = new List<string>();
        }

        public void AddOwner (HouseOwner owner){
            Owners.Add(owner);
        }

        public void SellOffer(HouseOwner owner){
            HousesForSale.Add(owner.HouseAddress);
            System.Console.WriteLine($"{owner.HouseAddress} is set for sale by {owner.Name}");
        }

        public void BuyOffer(Client client){
            if (HousesForSale.Contains(client.HouseAddress)){
                HousesForSale.Remove(client.HouseAddress);
                System.Console.WriteLine($"{client.HouseAddress} is bought by {client.Name}");
            }


        }

    }
}