using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamLai
{
    class Calculator : ICalculator
    {
        public double TinhTongChiPhiVanChuyen(List<BuuPham> listBuuPham)
        {
            return listBuuPham.Sum(buuPham => buuPham.TinhPhiVanChuyen());
        }
    }
}
