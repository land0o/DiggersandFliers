namespace DiggersandFliers
{
    public interface IDigable
    {
        int GroundDepth { get; }
        void Dig();
    }
}