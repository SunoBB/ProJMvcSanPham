﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GioiThieuSanPham.Models;
namespace GioiThieuSanPham.Controllers

{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult DanhSachSanPham()
        {
            QuanLySanPham_DBEntities db = new QuanLySanPham_DBEntities();
            // Get list of products
            /*List<SanPham> KetQua = db.SanPhams.ToList();*/

            //Truy vấn toàn bộ: Select * from SanPham
            var Kq = (from item in db.SanPhams
                      select item).ToList();

            return View(Kq);
        }

        public ActionResult ChiTietSanPham(int id)
        {

            QuanLySanPham_DBEntities db = new QuanLySanPham_DBEntities();
            // Get product by id
            SanPham KetQua = db.SanPhams.Find(id);

            return View(KetQua);
        }

        public ActionResult ThemMoi()
        {
            return View(new SanPham() { GiaBanCu = 0, GiaBanMoi = 0});
        }

        [HttpPost]
        public ActionResult ThemMoi(SanPham model)
        {
            // Save new data to database
            if (string.IsNullOrEmpty(model.TenSanPham))
            {
                ModelState.AddModelError("TenSanPham", "Tên sản phẩm không được để trống");
                return View(model);
            }
            if (model.GiaBanMoi <= 0)
            {
                ModelState.AddModelError("GiaBanMoi", "Giá bán mới phải lớn hơn 0");
                return View(model);
            }
            // Save new data to database
            QuanLySanPham_DBEntities db = new QuanLySanPham_DBEntities();
            // Func add new product
            db.SanPhams.Add(model);

            // Save to database
            db.SaveChanges();
            if (model.ID > 0)
            {
                return RedirectToAction("DanhSachSanPham"); // Redirect to list of products
            }
            else
            {
                ModelState.AddModelError("", "Thêm mới không thành công");
                return View(model);
            }
        }

        public ActionResult CapNhat(int id)
        {
            QuanLySanPham_DBEntities db = new QuanLySanPham_DBEntities();
            // Get product by id
            SanPham sanPhamModel = db.SanPhams.Find(id);

            return View(sanPhamModel) ;
        }
        [HttpPost]
        public ActionResult CapNhat(SanPham model)
        {
            if (string.IsNullOrEmpty(model.TenSanPham))
            {
                ModelState.AddModelError("TenSanPham", "Tên sản phẩm không được để trống");
                return View(model);
            }
            if (model.GiaBanMoi <= 0)
            {
                ModelState.AddModelError("GiaBanMoi", "Giá bán mới phải lớn hơn 0");
                return View(model);
            }
            // Save
            QuanLySanPham_DBEntities db = new QuanLySanPham_DBEntities();
            //1. Find product by id want edit

            var updateModel = db.SanPhams.Find(model.ID);
            // 
            updateModel.TenSanPham = model.TenSanPham;
            updateModel.GiaBanCu = model.GiaBanCu;
            updateModel.GiaBanMoi = model.GiaBanMoi;
            updateModel.BaiViet = model.BaiViet;
            updateModel.idHang = model.idHang;
            updateModel.TomTat = model.TomTat;

            var id = db.SaveChanges();
            if ( id > 0)
            {
                return RedirectToAction("DanhSachSanPham");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật không thành công");
                return View(model);
            }

        }
        
        public ActionResult Xoa(int id)
        {
            QuanLySanPham_DBEntities db = new QuanLySanPham_DBEntities();
            var model = db.SanPhams.Find(id);
            db.SanPhams.Remove(model);
            db.SaveChanges();

            return RedirectToAction("DanhSachSanPham");
        }


    }
}