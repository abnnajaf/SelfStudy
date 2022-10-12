namespace Composites.Good.Internet
{
    public interface IComponent
    {
        int CalculatePrice();

        void AddComponents(params IComponent[] component);
    }
}
