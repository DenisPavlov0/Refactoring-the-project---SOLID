namespace Completed
{
    public class FoodManager
    {
        public static FoodManager Instance
        {
            get
            {
                if (Instance == null)
                {
                    _instance = new FoodManager();
                }

                return _instance;
            }
        }

        private static FoodManager _instance;
        private FoodManager(){}

        private Food _storedFood;

        public void SaveFood(Food food)
        {
            _storedFood = food;
        }

        public Food GetFood()
        {
            return _storedFood;
        }
    }
    
}