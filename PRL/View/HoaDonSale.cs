using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRL.View
{ 
    public class SaleSanPham
    {
        // Chúng ta tạo ra 1 ViewModel để chứa sản phẩm sau khi đã sale, giá bán thực tế lưu hóa đơn là giá SalePrice
        public Guid Id { get; set; }
        public string TenSP { get; set; }
        public string MoTa { get; set; } // Mô tả
        public string HinhAnh { get; set; } // Link ảnh
        public string XuatXu { get; set; }
        public long Gia { get; set; }
        public int Soluongcon { get; set; } // SỐ lượng còn
        public int TrangThai { get; set; }
        public long GiaSale { get; set; }
    }
}
