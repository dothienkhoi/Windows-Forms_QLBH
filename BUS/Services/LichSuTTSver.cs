using DAL.Models;
using DAL.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class LichSuTTSver
    {
        LichSuThanhToanrepo lichSuThanhToanrepo;
        public LichSuTTSver()
        {
            lichSuThanhToanrepo = new LichSuThanhToanrepo();
        }
        public List<LichSuThanhToan> GetAllLichSuThanhToans()
        {
            return lichSuThanhToanrepo.GetAllLichSuThanhToans();
        }

        public LichSuThanhToan GetLichSuThanhToanById(Guid id)
        {
            return lichSuThanhToanrepo.GetLichSuThanhToanById(id);
        }

        public string CreateLichSuThanhToan(LichSuThanhToan lichSu)
        {
            return lichSuThanhToanrepo.CreateLichSuThanhToan(lichSu);
        }

        public string UpdateLichSuThanhToan(LichSuThanhToan lichSu)
        {
            return lichSuThanhToanrepo.UpdateLichSuThanhToan(lichSu);
        }

        public string DeleteLichSuThanhToan(Guid id)
        {
            return lichSuThanhToanrepo.DeleteLichSuThanhToan(id);
        }
    }
}
