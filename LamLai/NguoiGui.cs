using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamLai
{
    class NguoiGui : Nguoi
    {
        public string DiaChiGui { get; set; }
        public NguoiGui(string ten, string soDienThoai, int tuoi, string diaChiGui) : base(ten, soDienThoai, tuoi)
        {
            DiaChiGui = diaChiGui;
        }
    }
} 