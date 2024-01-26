using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace RefineAPI.Models
{
    public class Seed
    {
        public void StaticGen()
        {
            using (var context = new DBContext())
            {
                context.Database.EnsureCreated();

                var category = context.Category.FirstOrDefault();

                if (category == null)
                {
                    #region category
                    string jsonFilePath = "D:\\Project\\C#\\Test\\category.json";


                    // Read the JSON file contents
                    string jsonString = File.ReadAllText(jsonFilePath);

                    // Deserialize JSON into a dynamic object
                    List<Category>? jsonData = JsonConvert.DeserializeObject<List<Category>>(jsonString);
                    #endregion
                    if (jsonData!= null)
                    {
                        foreach (var i in jsonData)
                        {
                            context.Category.Add(i);
                        }
                    }
                    
                }
                var product = context.Product.FirstOrDefault();

                if (product == null)
                {
                    #region product
                    string jsonFilePath = "D:\\Project\\C#\\Test\\product.json";


                    // Read the JSON file contents
                    string jsonString = File.ReadAllText(jsonFilePath);

                    // Deserialize JSON into a dynamic object
                    List<Product>? jsonData = JsonConvert.DeserializeObject<List<Product>>(jsonString);
                    #endregion
                    if (jsonData != null)
                    {
                        foreach (var i in jsonData)
                        {
                            context.Product.Add(i);
                        }
                    }
                    
                }

                context.SaveChanges();
            }
        }
    }
}
