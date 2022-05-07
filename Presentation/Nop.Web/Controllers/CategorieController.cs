using Microsoft.AspNetCore.Mvc;
using Nop.Services.Catalog;
using Nop.Web.Factories;
using System.Threading.Tasks;

namespace Nop.Web.Controllers
{
    public class CategorieController : BasePublicController
    {
        //private readonly ICategoryService _categoryService;
        //public CategorieController(ICategoryService categoryService)
        //{
        //    _categoryService = categoryService;
        //}
        private readonly ICatalogModelFactory _catalogModelFactory;

        public CategorieController(ICatalogModelFactory catalogModelFactory)
        {
            _catalogModelFactory = catalogModelFactory;
        }

        public async Task<IActionResult> Index()
        {
            //var category = await _categoryService.GetAllCategoriesAsync();
            //return View(category);
            var model = await _catalogModelFactory.PrepareTopMenuModelAsync();
            return View(model);
        }


        public async Task<IActionResult> GetTopMenuCategorys()
        {
            //var category = await _categoryService.GetAllCategoriesAsync();
            //return View(category);
            var model = await _catalogModelFactory.PrepareTopMenuModelAsync();
            return Ok(model);
        }


        public async Task<IActionResult> GetHomepageCategorys()
        {
            //var category = await _categoryService.GetAllCategoriesAsync();
            //return View(category);
            var model = await _catalogModelFactory.PrepareHomepageCategoryModelsAsync();
            return Ok(model);
        }

        public async Task<IActionResult> GetCustomerCategorys(int cusId)
        {
            //var category = await _categoryService.GetAllCategoriesAsync();
            //return View(category);
            var model = await _catalogModelFactory.PrepareCustomerModelsAsync(cusId);
            return Ok(model);
        }


    }
}
