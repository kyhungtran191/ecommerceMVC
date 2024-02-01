using EcommerceMVC.Data;
using EcommerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EcommerceMVC.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly Hshop2023Context _Hshop2023Contexthshop2023Context;
        public MenuLoaiViewComponent(Hshop2023Context hshop2023Context)
        {
            _Hshop2023Contexthshop2023Context= hshop2023Context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = _Hshop2023Contexthshop2023Context.Loais.Select((loai) =>
            new MenuLoaiVM{
                    MaLoai = loai.MaLoai,
                    TenLoai= loai.TenLoai,
                    SoLuong = loai.HangHoas.Count
                 
            });
            return View(data);                
        }
    }
}
