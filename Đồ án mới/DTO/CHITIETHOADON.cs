﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_mới.DTO
{
    internal class CHITIETHOADON
    {
        private DateTime ngayHoaDon;
        private int soLuongDichVu;
        private Double tongTienHoaDon;
        //private KHACHHANG khachhang;
        //private DICHVU dichvu;

        public CHITIETHOADON(double tong)
        {
            this.tongTienHoaDon = tong;
        }

        public CHITIETHOADON()
        {
        }

        public CHITIETHOADON(DateTime ngayHoaDon, int soLuongDichVu, Double tongTienHoaDon/*, KHACHHANG khachhang, DICHVU dichvu*/)
        {
            this.ngayHoaDon = ngayHoaDon;
            this.soLuongDichVu = soLuongDichVu;
            this.tongTienHoaDon = tongTienHoaDon;
            //this.khachhang = khachhang;
            //this.dichvu = dichvu;
        }

        public DateTime NgayHoaDon { get => ngayHoaDon; set => ngayHoaDon = value; }
        public int SoLuongDichVu { get => soLuongDichVu; set => soLuongDichVu = value; }
        public Double TongTienHoaDon { get => tongTienHoaDon; set => tongTienHoaDon = value; }
        //internal KHACHHANG Khachhang { get => khachhang; set => khachhang = value; }
        //internal DICHVU Dichvu { get => dichvu; set => dichvu = value; }
    }
}
