namespace BlazorSampleCrud.DataAccessLayer.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }

    }
}
