using EcommerceMVC.Data;
using EcommerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly Hshop2023Context _hshopDB;
        public HangHoaController(Hshop2023Context hshopDB)
        {
            _hshopDB= hshopDB;
        }
        [Route("/products")]
        public IActionResult Index(int? loai)
        {
            var hanghoa = _hshopDB.HangHoas.AsQueryable();
            if (loai.HasValue)
            {
               hanghoa = hanghoa.Where(p=>p.MaLoai == loai.Value);
            }
           var results = hanghoa.Select(p=> new HangHoaVM
           {
              MaHh = p.MaHh,
              DonGia = p.DonGia ?? 0,
              Hinh = p.Hinh ?? "",
              MoTaNgan = p.MoTaDonVi  ?? " ",
              TenHH = p.TenHh,
              TenLoai= p.MaLoaiNavigation.TenLoai
           });
            return View(results);
        }
    }
}
