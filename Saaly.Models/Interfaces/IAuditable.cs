namespace Saaly.Models.Interfaces
{
    public interface IAuditable
    {
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
        DateTime? Deleted { get; set; }
        Guid? CreatedByUser { get; set; }
        Guid? ModifiedByUser { get; set; }
        Guid? DeletedByUser { get; set; }
    }
}
