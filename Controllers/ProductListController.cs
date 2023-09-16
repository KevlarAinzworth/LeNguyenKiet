using LeNguyenKiet.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Configuration;

namespace LeNguyenKiet.Controllers
{
    public class ProductListController : Controller
    {
        public static List<ProductListModel> productList = new List<ProductListModel>();
        public IActionResult ProductList(bool? check = false)
        {
            
            if ((bool)check)
            {
                productList.Clear();
            }
            else
            {
                return View(productList.ToList());
            }
            return View();
        }
        [HttpPost]
        public IActionResult ProductList(string productName,int productQuantity, int productPrice, double productDiscount)
        {
            var homeProducts = new ProductListModel(productName,productQuantity, productPrice, productDiscount);
            productList.Add(homeProducts);
            return View(productList);
        }


        public IActionResult RemoveProduct(int position)
        {
            productList.RemoveAt(position - 1);
            return RedirectToAction("Index", "Home");
        }
    }
}
