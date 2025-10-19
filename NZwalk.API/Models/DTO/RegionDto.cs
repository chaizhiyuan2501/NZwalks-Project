namespace NZwalk.API.Models.DTO
{
    public class RegionDto
    {
        //可以指定限制对前端暴露某些字段，类似于drf的序列化器
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
