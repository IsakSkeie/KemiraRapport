using DataAccesLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLib
{

   public static class RecipeRead
    {
        public static List<RecipeModels> Table;
        
        
    }
    
  public static class RecipeSearch
    {
        public static List<RecipeModels> Table;
    }

    public class RecipeData : IRecipeData
    {
      
      

        private readonly ISQLDataAccess _db;
        public RecipeData(ISQLDataAccess db)
        {
            _db = db;

        }
        
            public Task<List<RecipeModels>> GetRecipes(string sql)
        {
            return _db.LoadData<RecipeModels, dynamic>(sql, new { });
        }

        public Task InsertRecipe(RecipeModels recipe)
        {
            string sql = @"insert into recipe values (@batch, @id, @hcl)";
            return _db.SaveData(sql, recipe);

        }

        
    }

}
