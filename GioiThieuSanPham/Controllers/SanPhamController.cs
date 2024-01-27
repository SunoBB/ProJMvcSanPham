using GioiThieuSanPham.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GioiThieuSanPham.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult ShowDanhSach()
        {
            var listSanPham = new DBconnect().SanPhams.ToList();
            return View(listSanPham); // View DB
        }

        public ActionResult DanhSachSanPham()
        {
            var listSanPham = new GioiThieuSanPham.Models.SanPhamModel().DanhSach();
            ViewBag.listSanPham = listSanPham;
            return View();
        }

        public ActionResult ChiTietSanPham(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult XemTheoLoai(string tenLoai, int?page) 
        {
            ViewBag.page = page??1;
            ViewBag.tenLoai = tenLoai;
            return View();
        }
    }
}