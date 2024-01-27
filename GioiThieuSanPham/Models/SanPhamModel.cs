using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GioiThieuSanPham.Models
{
    public class SanPhamModel
    {
        public int ID { get; set; }
        public string TenSanPham { get; set; }
        public float GiaCu { get; set; }
        public float GiaMoi { get; set; }
        public string HangSanXuat { get; set; }
        public int SoThangBaoHanh { get; set; }
        public string TomTatThongTin { get; set; }

        public List<SanPhamModel> DanhSach()
        {
            var ListKetQua = new List<SanPhamModel>();

            SanPhamModel sp1 = new SanPhamModel();
            sp1.ID = 1;
            sp1.TenSanPham = "Máy khoan cầm tay";
            sp1.GiaCu = 15000000;
            sp1.GiaMoi = 12000000;
            sp1.HangSanXuat = "Sony";
            sp1.SoThangBaoHanh = 12;
            sp1.TomTatThongTin = "Máy khoan cầm tay 12V";
            ListKetQua.Add(sp1);

            SanPhamModel sp2 = new SanPhamModel();
            sp2.ID = 2;
            sp2.TenSanPham = "Rừu đốn củi";
            sp2.GiaCu = 15000000;
            sp2.GiaMoi = 12000000;
            sp2.HangSanXuat = "Google";
            sp2.SoThangBaoHanh = 12;
            sp2.TomTatThongTin = "Rất êm tay và uy lực";
            ListKetQua.Add(sp2);

            SanPhamModel sp3 = new SanPhamModel();
            sp3.ID = 3;
            sp3.TenSanPham = "Pin dự phòng";
            sp3.GiaCu = 15000000;
            sp3.GiaMoi = 12000000;
            sp3.HangSanXuat = "SsS";
            sp3.SoThangBaoHanh = 12;
            sp3.TomTatThongTin = "Pin 10.000";
            ListKetQua.Add(sp3);

            return ListKetQua;
        }

        public SanPhamModel ThongTin(int? id)
        {
            //id= 1 ; return sp1
            if (id == 1)
            {

                SanPhamModel sp1 = new SanPhamModel();
                sp1.ID = 1;
                sp1.TenSanPham = "Máy khoan cầm tay";
                sp1.GiaCu = 15000000;
                sp1.GiaMoi = 12000000;
                sp1.HangSanXuat = "Sony";
                sp1.SoThangBaoHanh = 12;
                sp1.TomTatThongTin = "Máy khoan cầm tay 12V";
                return sp1;
            }
            

            //id= 2 ; return sp2
            else if (id == 2)
            {

                SanPhamModel sp2 = new SanPhamModel();
                sp2.ID = 2;
                sp2.TenSanPham = "Rừu đốn củi";
                sp2.GiaCu = 15000000;
                sp2.GiaMoi = 12000000;
                sp2.HangSanXuat = "Google";
                sp2.SoThangBaoHanh = 12;
                sp2.TomTatThongTin = "Rất êm tay và uy lực";
                return sp2;
            }
            
            //id= 3 ; return sp3
            else if(id == 3)
            {

                SanPhamModel sp3 = new SanPhamModel();
                sp3.ID = 3;
                sp3.TenSanPham = "Pin dự phòng";
                sp3.GiaCu = 15000000;
                sp3.GiaMoi = 12000000;
                sp3.HangSanXuat = "SsS";
                sp3.SoThangBaoHanh = 12;
                sp3.TomTatThongTin = "Pin 10.000";
                return sp3;
            }
            else
            {
                return null;
            }
        }
    }
}