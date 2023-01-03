using Microsoft.AspNetCore.Mvc;
using Phan1.Models.StringProcess;
namespace Phan1.Controllers
{
    public class StringProcessController :Controller
    {
        StringProcess strPro = new StringProcess();
        
        public IActionResult XoaKhoangTrang()
        {
            return View(); 
        }
       [HttpPost]
        public IActionResult XoaKhoangTrang(string strInput )
        { 
            ViewBag.thongbao="Sau khi xóa khoảng trắng :  "+ strPro.RemoveRemainingWhiteSpace(strInput);
            return View();
        }
          //in ra chuỗi chuyển từ in hoa ra in thường
        public IActionResult InThuong()
        {
            return View(); 
        }
       [HttpPost]
        public IActionResult InThuong(string strInput )
        { 
            ViewBag.thongbao="chuyển chuỗi sang in thường:  "+ strPro.UpperToLower(strInput);
            return View();
        }
        //Chuyển từ in thường ra in hoa
        public IActionResult InHoa()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult InHoa(string strInput )
        { 
            ViewBag.thongbao="chuyển chuỗi sang in hoa:  "+ strPro.LowerToUpper(strInput);
            return View();
        }
         //chuyển chuỗi sang in hoa chữ đầu  
        public IActionResult InHoaChuDau()
        {
            return View(); 
        }
       
       [HttpPost]
        public IActionResult InHoaChuDau(string strInput )
        { 
            ViewBag.thongbao="In hoa chữ cái đầu tiên:  "+ strPro.CapitalizeOneFirstCharacter(strInput);
            return View();
        }
        public IActionResult InHoaTatCaChuDau()
        {
            return View(); 
        }
       
       [HttpPost]
        public IActionResult InHoaTatCaChuDau(string strInput )
        { 
            ViewBag.thongbao="in hoa tất cả chữ cái đầu:  "+ strPro.CapitalizeFirstCharacter(strInput);
            return View();
        }
         public IActionResult BoDau()
        {
            return View(); 
        }
       
       [HttpPost]
        public IActionResult BoDau(string strInput )
        { 
            ViewBag.thongbao="Sau khi bỏ dấu:  "+ strPro.RemoveVietnameseAccents(strInput);
            return View();
        }
    }
}