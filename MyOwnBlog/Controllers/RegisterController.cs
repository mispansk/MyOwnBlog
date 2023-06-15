using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyOwnBlog.Models;
using MyOwnBlog.ViewModels.Account;


namespace MyOwnBlog.Controllers
{
    public class RegisterController: Controller
    {
      //  private IMapper _mapper;

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public RegisterController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            //_mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //[Route("Register")]
        //[HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //[Route("Register")]
        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterViewModel model)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //        var user = _mapper.Map<User>(model);

        //        var result = await _userManager.CreateAsync(user, model.Password);
        //        //if (result.Succeeded)
        //        //{
        //            await _signInManager.SignInAsync(user, false);
        //            return RedirectToAction("Index", "Home");
        //        //}
        //        //else
        //        //{
        //        //    foreach (var error in result.Errors)
        //        //    {
        //        //        ModelState.AddModelError(string.Empty, error.Description);
        //        //    }
        //        //}
        //    //}
        //    //return View("RegisterPart2", model);

        //}

        //[Route("Login")]
        //[HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult AddTag()
        {
            return View();
        }

        //[Route("Login")]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        var user = _mapper.Map<User>(model);

        //        var result = await _signInManager.PasswordSignInAsync(user.Email, model.Password, false, false);

        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("MyPage", "AccountManager");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Неправильный логин и (или) пароль");
        //        }
        //    }
        //    return View("Views/Home/Index.cshtml");
        //}

        //[Route("Logout")]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Logout()
        //{
        //    await _signInManager.SignOutAsync();
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
