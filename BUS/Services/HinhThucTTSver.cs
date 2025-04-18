using DAL.Models;
using DAL.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HinhThucTTSver
    {
        HinhThucTTrepo trepo;
        public HinhThucTTSver()
        {
            trepo = new HinhThucTTrepo();
        }
        public List<HinhThucThanhToan> GetAllHinhThucThanhToans()
        {
            return trepo.GetAllHinhThucTT();
        }

        public HinhThucThanhToan GetHThucThanhToanById(Guid id)
        {
            return trepo.GetidHinhThucTT(id);
        }

        public string CreateLichSuThanhToan(HinhThucThanhToan hinhThuc)
        {
            return trepo.CreateHthucThanhToan(hinhThuc);
        }

        public string UpdateLichSuThanhToan(HinhThucThanhToan hinhThuc, Guid id)
        {
            return trepo.UpdateHThucThanhToan(hinhThuc ,id);
        }

        public string DeleteLichSuThanhToan(Guid id)
        {
            return trepo.DeleteHThucThanhToan(id);
        }
    }
}
