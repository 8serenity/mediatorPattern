using System;
namespace MediatorPattern
{
    public class HouseOwner
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string HouseAddress
        {
            get;
            set;
        }

        public RealEstateMediator Mediator
        {
            get;
            set;
        }

        public HouseOwner(long id, string name, RealEstateMediator mediator)
        {
            Id = id;
            Name = name;
            Mediator = mediator;
        }

        public void SellHouse (){
            Mediator.SellOffer(this);
        }

    }
}
