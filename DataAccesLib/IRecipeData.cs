using DataAccesLib.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccesLib
{
    public interface IRecipeData
    {
        Task<List<RecipeModels>> GetRecipes(string sql);
        Task InsertRecipe(RecipeModels recipe);

        Task EditRecipe(string sql);
    }
}