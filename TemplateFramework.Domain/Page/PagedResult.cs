namespace TemplateFramework.Domain.Page
{
    /// <summary>
    /// Kết quả phân trang cho một tập hợp các bản ghi.
    /// </summary>
    /// <typeparam name="T">T là kiểu entity mà bn muốn phân trang</typeparam>
    public class PagedResult<T>
    {
        /// <summary>
        /// danh sách các bản ghi của trang hiện tại.
        /// </summary>
        public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();

        /// <summary>
        /// số trang hiện tại.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// kích thước của trang (số bản ghi mỗi trang).
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// tổng số bản ghi trong toàn bộ tập dữ liệu.
        /// </summary>
        public int TotalRecords { get; set; }

        /// <summary>
        /// tổng số trang. Đây là thuộc tính được tính toán.
        /// </summary>
        public int TotalPages => (int)Math.Ceiling(TotalRecords / (double)PageSize);
    }
}
