﻿using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class SanPhamRepository : ISanPhamRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public SanPhamRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }
        public void themSanPham(SanPham sanPham)
        {
            _conText.sanPham.Add(sanPham);//gọi biến sanPham ở donghocontext thêm vào database
            _conText.SaveChanges();//lưu lại thay đổi
        }

        public IEnumerable<SanPham> getAll(int pageIndex, int pageSize,string textSearch, out int count)
        {
            
            var query = _conText.sanPham.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            if(!string.IsNullOrEmpty(textSearch))
            {        
                query=query.Where(m => m.TenSanPham.Contains(textSearch));
            }
            count = query.Count();//Hàm Count dùng để dếm số lượng phần tử thuongHieu có trong context

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }
        public IEnumerable<SanPham> getAll()
        {
            return _conText.sanPham.ToList();
        }
        public IEnumerable<SanPham> get4sp(int boqua)
        {
            var query = _conText.sanPham.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            return query.Skip(boqua)
                        .Take(8).ToList();
        }
        public void suaSanPham(SanPham sanPham)
        {
            _conText.sanPham.Update(sanPham);//gọi biến sanPham ở donghocontext thêm vào database
            _conText.SaveChanges();//lưu lại thay đổi
        }
        public void xoaSanPham(SanPham sanPham)
        {
            _conText.sanPham.Remove(sanPham);//gọi biến sanPham ở donghocontext thêm vào database
            _conText.SaveChanges();//lưu lại thay đổi
        }
        public SanPham Xemsp(string maSanPham)
        {

            return _conText.sanPham.Find(maSanPham); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }
    }
}
