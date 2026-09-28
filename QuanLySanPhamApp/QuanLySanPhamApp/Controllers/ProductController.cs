using Microsoft.AspNetCore.Mvc;
using QuanLySanPhamApp.Models; // Import thư mục Models để sử dụng lớp Product

namespace QuanLySanPhamApp.Controllers
{
    public class ProductController : Controller
    {
        // Action Index sẽ chạy khi truy cập /Product/Index
        public IActionResult Index()
        {
            // 1. Tạo danh sách dữ liệu sản phẩm mẫu
            List<Product> danhSachSanPham = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop Dell XPS", Price = 25000000 },
                new Product { Id = 2, Name = "Chuột không dây Logitech", Price = 450000 },
                new Product { Id = 3, Name = "Bàn phím cơ AKKO", Price = 1250000 },
                new Product { Id = 4, Name = "Màn hình LG 27 inch", Price = 5800000 }
            };

            // 2. Truyền danh sách dữ liệu sang View
            return View(danhSachSanPham);
        }
    }
}