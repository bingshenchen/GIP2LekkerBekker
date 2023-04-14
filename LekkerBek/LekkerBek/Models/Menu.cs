using System.Xml.Linq;

namespace LekkerBek.Models
{
    public class Menu
    {
        // Propertys
        private static List<Recipe> dishes; 
        private static Menu instance;


        // Initial Value

        private Menu()
        {
            // Set initial values if necessary
            dishes = new List<Recipe> {
            new Recipe(1, "Stoemp", 1.5, "Aardappelen: 1000 g;<br>\r\nWortelen: 500 g;<br>\r\nUien: 200 g;\r\nBoter: 50 g;\r\nMelk: 200 ml;\r\nZout en peper naar smaak", Recipe.DishType.Meat),
            new Recipe(2, "Wafels", 2.7,"Bloem: 250 g;\r\nBakpoeder: 2 g;\r\nSuiker: 50 g;\r\nZout: 1 g;\r\nEieren: 2 (100 g);\r\nMelk: 250 ml;\r\nBoter: 100 g;\r\nVanille-extract: 1 theelepel (5 g)", Recipe.DishType.Vegetarian),
            new Recipe(3, "Chocolade ijs", 2.8,"Volle melk: 400 ml;\r\nSlagroom: 200 ml;\r\nSuiker: 150 g;\r\nEieren: 4 (200 g);\r\nCacao poeder: 40 g;\r\nPure chocolade: 100 g;\r\nVanille-extract: 1 theelepel (5 g)", Recipe.DishType.Vegetarian),
            new Recipe(4, "Tomatensoep met balletjes", 4.2,"Tomaten: 1 kg;\r\nUi: 150 g;\r\nWortelen: 100 g;\r\nBleekselderij: 100 g;\r\nKnoflook: 2 teentjes (10 g);\r\nTomatenpuree: 50 g;\r\nGroentebouillon: 1 liter;\r\nRundvleesgehakt: 250 g;\r\nPaneermeel: 50 g;\r\nEi: 1 (50 g);\r\nPeterselie: 1 eetlepel (5 g);\r\nOlijfolie: 2 eetlepels (30 ml);\r\nZout en peper naar smaak", Recipe.DishType.Meat),
            new Recipe(5, "Koninginnehapje", 5.1,"Kippenbouillon: 500 g;\r\nKippenborstfilet: 250 g;\r\nBoter: 50 g;\r\nBloem: 50 g;\r\nMelk: 500 ml;\r\nChampignons: 150 g;\r\nErwten: 100 g;\r\nZout en peper naar smaak;\r\nBladerdeeg: 500 g;\r\nEi: 1 (50 g)", Recipe.DishType.Meat),
            new Recipe(6, "Witloof in de oven", 6.3,"Witloof: 6 stuks (ongeveer 1 kg);\r\nBoter: 50 g;\r\nBloem: 50 g;\r\nMelk: 500 ml;\r\nGeraspte kaas: 100 g;\r\nPaneermeel: 50 g;\r\nZout en peper naar smaak", Recipe.DishType.Vegetarian),
            new Recipe(7, "Garnaalkroketten", 7.9,"Grijze garnalen: 250 g;\r\nBoter: 100 g;\r\nBloem: 100 g;\r\nVolle melk: 1 liter;\r\nPaneermeel: 150 g;\r\nEieren: 3;\r\nZout en peper naar smaak;\r\nCitroensap: 1 eetlepel;\r\nPeterselie: 1 eetlepel", Recipe.DishType.Fish),
            new Recipe(8, "Waterzooi", 8.2,"Kippenbouten: 4 stuks (ongeveer 800 g);\r\nPrei: 2 stuks (ongeveer 200 g);\r\nSelderij: 1 stengel (ongeveer 50 g);\r\nWortelen: 2 stuks (ongeveer 200 g);\r\nAardappelen: 4 stuks (ongeveer 400 g);\r\nUi: 1 stuk (ongeveer 100 g);\r\nBoter: 50 g;\r\nBloem: 50 g;\r\nRoom: 250 ml;\r\nEieren: 2;\r\nCitroen: 1 stuk;\r\nLaurierblaadjes: 2 stuks;\r\nPeterselie: 1 eetlepel;\r\nZout en peper naar smaak", Recipe.DishType.Meat),
            new Recipe(9, "Kip aan 't spit", 9.7,"Hele kip: 1 (ongeveer 1,5 kg);\r\nCitroen: 1 stuk;\r\nKnoflook: 4 teentjes;\r\nOlijfolie: 2 eetlepels;\r\nRozemarijn: 1 eetlepel;\r\nTijm: 1 eetlepel;\r\nZout en peper naar smaak", Recipe.DishType.Meat),
            new Recipe(10, "Vlaamse stoverij", 10.4,"Runderstoofvlees: 1 kg;\r\nUien: 2 grote stuks (ongeveer 200 g);\r\nBoter: 50 g;\r\nRode wijn: 500 ml;\r\nRunderbouillon: 500 ml;\r\nAzijn: 50 ml;\r\nLaurierblaadjes: 2 stuks;\r\nKruidnagels: 2 stuks;\r\nMosterd: 1 eetlepel;\r\nBruine suiker: 1 eetlepel;\r\nOntbijtkoek: 1 plak (ongeveer 50 g);\r\nZout en peper naar smaak.", Recipe.DishType.Meat),
            new Recipe(11, "Mosselen-friet", 11.5,"Verse mosselen: 2 kg;\r\nFrietaardappelen: 1 kg;\r\nOlie om te frituren;\r\nBoter: 100 g;\r\nUien: 2 middelgrote stuks (ongeveer 200 g);\r\nPrei: 1 stuk (ongeveer 150 g);\r\nBleekselderij: 2 stengels (ongeveer 150 g);\r\nLaurierblaadjes: 2 stuks;\r\nKruidnagels: 2 stuks;\r\nWitte wijn: 250 ml;\r\nRoom: 200 ml;\r\nKnoflook: 2 teentjes;\r\nPeterselie: een handvol;\r\nZout en peper naar smaak", Recipe.DishType.Fish),
            new Recipe(12, "Menu A", 25,"", Recipe.DishType.Combo),
            new Recipe(13, "Menu B", 25,"", Recipe.DishType.Combo),
            new Recipe(14, "Menu C", 25,"", Recipe.DishType.Combo),
            new Recipe(15, "Menu D", 25,"", Recipe.DishType.Combo),
            new Recipe(16, "Menu E", 25,"", Recipe.DishType.Combo),
            new Recipe(17, "Menu F", 25,"", Recipe.DishType.Combo)
            };
        }


        // Functions

        // Public static method to access the singleton instance
        public static Menu GetInstance()
        {
            if (instance == null)
            {
                instance = new Menu();
            }
            return instance;
        }


        public static List<Recipe> GetDishes()
        {
            GetInstance();
            return dishes;
        }
        public static Recipe GetDishById(int id)
        {
            Recipe result = null;
            foreach (Recipe recipe in GetDishes())
            {
                if (recipe.Id == id)
                {
                    result = recipe;
                    break;
                }
            }
            return result;
        }

        public static void AddDish(Recipe recipe)
        {
            int nextId = 0;
            foreach (Recipe newRecipe in GetDishes())
            {
                nextId = Math.Max(nextId, newRecipe.Id);
            }

            recipe.Id = nextId + 1;
            GetDishes().Add(new Recipe(recipe.Id, recipe.Name, recipe.Price, recipe.RecipeText, recipe.RecipeType));
        }


        public static void UpDish(int id, string name, double price, string recipeText, Recipe.DishType dishType)
        {
            // using (var db = new DbContext()){ }
            Recipe DishToUpdate = GetDishById(id);
            if (DishToUpdate != null)
            {
                DishToUpdate.Id = id;
                DishToUpdate.Name = name;
                DishToUpdate.Price = price;
                DishToUpdate.RecipeText = recipeText;
                DishToUpdate.RecipeType = dishType;
            }
            
            // db.SaveChanges();
        }
    }
}
