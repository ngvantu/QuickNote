------------THÔNG TIN--------------------------------
MSSV: 1512649
Họ và Tên: Nguyễn Văn Tú
Email: ngvantu2912@gmail.com

-----------------CHƯƠNG TRÌNH------------------------
Chương trình giúp lưu ghi chú nhanh
Môi trường lập trình: Visual Studio 2017
Ngôn ngữ lập trình: C#

--------------CÁC CHỨC NĂNG ĐÃ LÀM ĐƯỢC--------------
1. Người dùng truy cập app. Mặc định hiển thị màn hình View Notes
Một icon sẽ được thêm vào vùng thông báo (notification area)
Người dùng có thể nhấn chuột phải vào icon sẽ thấy menu: Note (Windows + N), View Notes, View Statistics, Exit

-	Note (Windows + N): (Có thể mở bằng phím tắt Windows + N)
	+ Mở một dialog Note
	+ Người dùng có thể nhập nội dung ghi chú ở khung Note, nhập nhiều tag tách nhau bằng dấu phẩy ","
	+ Click vào Save để lưu
	
-	View Notes:
	+ Hiển thị màn hình View Notes
	+ TAGS:	Một listbox hiển thị tất cả các tag, mỗi tag sẽ có số note tương ứng và được sắp xếp theo bảng chữ cái.
			Luôn có một tag "All Notes" ở dòng đầu tiên và ở trạng thái được chọn khi mở View Notes.
	+ NOTES:Một listbox hiển thị tất cả các note tương ứng với tag đang được chọn.
			Mỗi note hiển thị ngắn gọn nội dung khoảng 40 ký tự.
	+ FULL CONTENT:	Khi click vào một note bất kỳ, sẽ mở khóa 2 textbox và 1 button Edit
		. Textbox trên chứa tất cả các tag của note được chọn
		. Textbox dưới chứa nội dung đầy đủ của note
		. Button "Edit":Người dùng có thể chỉnh sửa nội dung của 2 textbox chứa Tags và Nội dung của note hiện tại.
						Click vào button "Edit" để lưu chỉnh sửa.
	+ Button "New note":	Mở dialog Note
	+ Button "Statistics":	Mở dialog Statistics					

-	View Statistics:
	+ Mở một dialog Statistics
	+ Hiển thị biểu đồ tròn dựa trên tag và số note tương ứng
	+ Dùng 5 tag được sử dụng nhiều nhất để vẽ biểu đồ. Còn lại sẽ hợp thành một tag "Others"
	
-	Exit: đóng chương trình

2. Các chức năng nâng cao:
-	Khi nhập tag sẽ có gợi ý danh sách tag sắp xếp ưu tiên số lần sử dụng

----------------LUỒNG SỰ KIỆN PHỤ-------------------
1.	Double click vào icon app trong notification area để mở nhanh màn hình View Notes
2.	Màn hình View Notes:
	+ Click vào Minimized để ẩn màn hình
	+ 2 textbox của mục FULL CONTENT và button "Edit" chỉ có thể thao tác khi đã có một note được chọn
	+ Khi click vào một tag, sẽ quay về trạng thái không có note được chọn
	+ Khi click vào button "Edit", dữ liệu của note (tag, nội dung) đang được chọn sẽ thay đổi. 
		. Dẫn đến số lượng note của mỗi tag có thể thay đổi tăng hoặc giảm.
		. Tag có số lượng 0 sẽ bị xóa
		. Cập nhật lại khung TAGS và quay về trạng thái ban đầu là chọn "All Notes", không có note được chọn
3.	Các textbox nhập tag và nội dung note không được để trống
4.	Các tag tự động bỏ các khoảng trắng dư thừa và không nhận tag là khoảng trắng

--------------LINK BITBUCKET------------------------
https://bitbucket.org/ngvantu/quick-note

--------------LINK YOUTUBE--------------------------
https://youtu.be/AAdZ9x5ijxY
Từ giây 59 là demo nhấn phím tắt Windows + N