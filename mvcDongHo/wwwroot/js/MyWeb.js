 //Hàm xóa thương hiệu
 //viết jquery, do xài cái model để xác nhận có muốn xóa hay không thì mình không lấy mã trực tiếp như cái sửa được nên phải viết thêm cái này  
$("button#xoathuonghieu").click(function ()
//  tạo sự kiên click cho cái button ở trên theo cú pháp của jquery: "tenthe#mã thẻ" 
{
    var id = $(this).data("id");//gán IDThuongHieu đã được lưu vào data-id ở trên để gán vào biến id
    var obj = '<a class="btn btn-success" href="https://localhost:5001/Admin/QuanLiThuongHieu/XoaThuongHieuData/' + id + '">Có</a>'
        + '<button type="button" class="btn btn-secondary" data-dismiss="modal">Không</button>';//tạo biến obj để lưu lại cái html mình cần xuất ra, cái này tui không quá rõ nhưng mà cứ làm theo thôi, hok khó
    $("div#footer-del").html(obj);//gọi cái thẻ div có mã là footer-del để chèn phần html zo
});
$('button#xemchitietban').click(function ()
{
    var id = $(this).data("id");
    console.log(id);
    $.ajax({
        type:"GET",
        url:"/Admin/QuanLiHoaDonBan/HoaDonBan",
        data:{IDHoaDon:id},
        success:function(response){
            console.log(response)
            $('tbody#content').empty();
            response.forEach(function(item) {
                var obj='<tr>'
                        +'<td>'+item.idSanPham+'</td>'
                        +'<td>'+item.soLuong+'</td>'
                        +'</tr>';
                $('tbody#content').append(obj);
            });
            
        }
    });   
});
$('button#xemchitietnhap').click(function ()
{
    var id = $(this).data("id");
    console.log(id);
    $.ajax({
        type:"GET",
        url:"/Admin/QuanLiHoaDonNhap/HoaDonNhap",
        data:{IDHoaDonNhap:id},
        success:function(response){
            console.log(response)
            $('tbody#content').empty();
            response.forEach(function(item) {
                var obj='<tr>'
                            +'<td>'+item.idSanPham+'</td>'
                            +'<td>'+item.soLuong+'</td>'
                        +'</tr>';
                $('tbody#content').append(obj);
            });
            
        }
    });   
});
// $('input#search').keyup(function(){
//     var text = $(this).val();
//     console.log(text);
//     $.ajax({
//         type:"GET",
//         url:"/Home/Search",
//         data:{textSearch:text},
//         success:function(response){
//             $('div#content').empty();
//             console.log(response);
//             response.forEach(function(item){
//                 var obj='<div class="box-img-hover">'
//                             +'<div class="type-lb">'
//                                 +'<p class="sale">Mới</p>'
//                             +'</div>'
//                             +'<img src="'+item.hinhAnh+'" class="img-fluid" alt="Image">'
//                             +'<div class="mask-icon">'
//                                 +'<ul>'
//                                     +'<li><a data-toggle="tooltip" data-placement="right" title="View" asp-controller="Home" asp-action="Shopdetail" '+'asp-route-id="'+item.idSanPham+'"><i class="fas fa-eye"></i></a></li>'
//                                 +'</ul>'
//                                 +'<a class="cart" href="#">Thêm vào giỏ hàng</a>'
//                             +'</div>'
//                         +'</div>'
//                         +'<div class="why-text">'
//                             +'<h4>'+item.tenSanPham+'</h4>'
//                             +'<h5>'+item.gia+'</h5>'
//                         +'</div>';
                        
//                 $('div#content').append(obj);
//             });
//         }
//     });
// });
    
