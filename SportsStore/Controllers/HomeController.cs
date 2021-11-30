using SportsStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {


    //    public IActionResult Index()
    //    {
    //        //checks to see if a user is logged in and displays name at the top right corner of the page
    //        //else it clears the cart and order summary, basically doing the log out 
    //        if (Repo.isLogin)
    //        {

    //            ViewBag.displayname = "Welcome " + Repo.displayName;
    //            return View();
    //        }
    //        else
    //        {
    //            Repo.cart.Clear();
    //            Repo.orderSummary.Clear();
    //            ViewBag.displayname = "Please log in";
    //            return View();
    //        }

    //    }

    //    public IActionResult Privacy()
    //    {

    //        return View();
    //    }
    //    public IActionResult FAQ()
    //    {
    //        return View();
    //    }
    //    public IActionResult AboutUs()
    //    {

    //        return View();
    //    }

    //    [HttpGet]
    //    public IActionResult Login()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public IActionResult Login(Login login)
    //    {
    //        //goes through the list of accounts in Repo and checks if login information matches any of the accounts
    //        foreach (Account account in Repo.accounts)
    //        {
    //            if (account.Email.Equals(login.Email) && account.Password.Equals(login.Password))
    //            {
    //                Repo.isLogin = true;
    //                Repo.displayName = account.FirstName;
    //                return RedirectToAction("Index");
    //            }
    //        }
    //        ViewBag.AccountNotFound = "Account not found";
    //        return View();
    //    }


    //    [HttpGet]
    //    public IActionResult Signup()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public IActionResult Signup(Account newAccount)
    //    {
    //        //the ModelState.IsValid internal C# command checks to see if all the validation test are met 
    //        if (ModelState.IsValid)
    //        {
    //            if (newAccount.Password.Equals(newAccount.ConfirmPassword))
    //            {
    //                foreach (Account account in Repo.accounts)
    //                {
    //                    if (account.Email.Equals(newAccount.Email))
    //                    {
    //                        ViewBag.accountExist = "Acccont Already Exists";
    //                        return View();
    //                    }
    //                }
    //                Repo.addAccounts(newAccount);
    //                return View("Login"); //redirects to the login page
    //            }
    //            else
    //            {
    //                return RedirectToAction("Signup"); //redirects to the Signup method
    //            }
    //        }
    //        else
    //        {

    //            return View();

    //        }

    //    }

    //    [HttpGet]
    //    public IActionResult Products()
    //    {
    //        Repo.books.Clear(); //Avoids displaying books more than once in the products page
    //        if (Repo.isLogin)
    //        {

    //            //string[] lines = System.IO.File.ReadAllLines("E:/GitHub/AAA/AAABookStore/AAABookStore/wwwroot/bookpics/ProductsDatabase.txt"); //Austin's path
    //            //string[] lines = System.IO.File.ReadAllLines("C:/Users/Owner/Documents/Github/AAA/AAABookStore/AAABookStore/wwwroot/bookpics/ProductsDatabase.txt"); //Alex's path
    //            string[] lines = System.IO.File.ReadAllLines("C:/Users/owner/Documents/AAA/AAABookStore/AAABookStore/wwwroot/bookpics/ProductsDatabase.txt"); //Ahmad's path
    //            for (int i = 0; i < lines.Length; i += 4)
    //            {
    //                if (i >= lines.Length)
    //                {
    //                    break;
    //                }
    //                Books book = new Books(lines[i], Double.Parse(lines[i + 1]), lines[i + 2], lines[i + 3]);
    //                Repo.books.Add(book);
    //            }
    //            return View(Repo.Books);
    //        }
    //        else
    //        {
    //            return View("Login");
    //        }
    //    }

    //    [HttpPost]
    //    public IActionResult Products(BookInCart book)
    //    {
    //        foreach (BookInCart bookinList in Repo.cart)
    //        {
    //            if (bookinList.Name == book.Name)
    //            {
    //                bookinList.Quantity = bookinList.Quantity + 1;
    //                return RedirectToAction("Products");
    //            }

    //        }
    //        Repo.addToCart(book);
    //        return RedirectToAction("Products");
    //    }

    //    [HttpGet]
    //    public IActionResult Cart()
    //    {

    //        return View(Repo.Cart);
    //    }

    //    [HttpGet]
    //    public IActionResult Checkout()
    //    {

    //        double subtotal = 0;
    //        foreach (BookInCart item in Repo.Cart)
    //        {
    //            subtotal += item.Price * item.Quantity;
    //        }

    //        double Tax = subtotal * 0.07;
    //        Tax = System.Math.Round(Tax, 2);
    //        double Total = Tax + subtotal;
    //        Total = System.Math.Round(Total, 2);
    //        OrderSummary orderSum = new OrderSummary(Repo.cart, subtotal, Tax, Total);

    //        Repo.addToSummary(orderSum);
    //        return View(orderSum);
    //    }

    //    [HttpPost]
    //    public IActionResult Checkout(CreditCard card)
    //    {
    //        Repo.cart.Clear();
    //        return RedirectToAction("OrderSummary");
    //    }


    //    [HttpGet]
    //    public IActionResult OrderSummary()
    //    {
    //        return View(Repo.orderSummary);
    //    }

    //    public IActionResult Logout()
    //    {
    //        Repo.isLogin = false;
    //        return RedirectToAction("Index");
    //    }

    //    //all of the followings methods return the product page information for the books listed on the home page
    //    public IActionResult AT()
    //    {

    //        return View();
    //    }

    //    public IActionResult DIA()
    //    {

    //        return View();
    //    }

    //    public IActionResult HLW()
    //    {

    //        return View();
    //    }

    //    public IActionResult PSQL()
    //    {

    //        return View();
    //    }

    //    public IActionResult PCC()
    //    {

    //        return View();
    //    }

    //    public IActionResult clearCart()
    //    {
    //        Repo.cart.Clear();
    //        return RedirectToAction("Cart");
    //    }

    }
}
