using Matrix.Core.Application;
using Matrix.Core.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class WareHouseController : Controller
    {

        private IRepositoryWrapper _repoWrapper;

        public async Task<IActionResult> Index()
        {
            //List<GetWareHouse> resp = await _repoWrapper.WareHouseRepo.GetWareHouse();
            return View(/*resp*/);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public async Task<JsonResult> Add(WareHouseDTO req)
        {
            JSONResultResp resp = new JSONResultResp();
            try
            {
                throw new Exception(req.WareHouseName + " is not a valid name for warehouse!");
                if (req == null)
                    throw new Exception("Kindly enter warehouse name");
                else
                {
                    _repoWrapper.WareHouseRepo.AddWareHouse(req);
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);
        }
    }
}
