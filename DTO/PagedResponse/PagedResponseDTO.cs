namespace DTO.PagedResponse
{
    public class PagedResponseDTO<T>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public IEnumerable<T> Values { get; set; }

        public PagedResponseDTO(int page, int pageSize, IEnumerable<T> values)
        {
            Page = page;
            PageSize = pageSize;
            Values = values;
        }
    }
}