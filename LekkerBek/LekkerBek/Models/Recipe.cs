namespace LekkerBek.Models
{
    public class Recipe : Dish
    {
        public enum DishType
        {
            Meat,
            Fish,
            Asian,
            Vegetarian,
            Combo
        }
        public string RecipeText { get; set; }
        public DishType RecipeType { get; set; }

        public Recipe(int id, string name, double price, string recipeText, DishType dishType) : base(id, name, price)
        {
            RecipeText = recipeText;
            RecipeType = dishType;
        }


        public Recipe() : base(0, "", 0.0)
        {
        }


    }
}
