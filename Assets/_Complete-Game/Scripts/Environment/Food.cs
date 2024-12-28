namespace Completed
{
    public class Food
    {
        public Food(int initialValue)
        {
            amount = initialValue;
        }

        public int amount { get; private set; }
        public void Add(int value) => amount += value;
        public void Remove(int value) => amount -= value;
    }
}