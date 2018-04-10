using System;
using ColorCode.Provider.Contracts;
using ColorCode.Provider.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColorCode.App.Controllers
{
    /// <summary>
    /// Ohm Value Controller
    /// </summary>
    [Route("ohmvalue")]
    public class OhmValueController : Controller
    {
        #region Private Members
        private readonly IOhmProvider _provider;
        #endregion

        public OhmValueController(IOhmProvider provider)
        {
            _provider = provider ?? throw new Exception("OhmProvider is NULL");
        }

        #region Action Methods
        [Route("index")]
        public IActionResult Index(PageModel model)
        {
            PageModel viewModel = _provider.InitializeModel();
            return View(viewModel);
        }

        [Route("calculate")]
        public IActionResult Calculate(PageModel model)
        {
            if (ModelState.IsValid)
            {
                ResponseModel responseModel = _provider.GetDataAsync(model);
                model = _provider.InitializeModel();
                model.OhmValue = responseModel.OhmValue.ToString();
            }
            return View("index", model);
        }
        #endregion
    }
}