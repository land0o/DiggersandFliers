namespace DiggersandFliers
{
    public interface IFlyable
    {
        bool BirdHouse {get; set;}  
        void Fly();
        void LivesInBirdHouse(); 
    }
}