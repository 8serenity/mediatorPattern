namespace MediatorPattern
{
    public class Client
    {
        public long Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

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



        public Client(long id, string name, RealEstateMediator mediator)
        {
            Id = id;
            Name = name;
            Mediator = mediator;
        }

        public void BuyHouse(){
            Mediator.BuyOffer(this);
        }


    }
}