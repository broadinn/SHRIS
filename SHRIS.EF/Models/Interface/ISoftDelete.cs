namespace SHRIS.EF.Models.Interface
{
    interface ISoftDelete
    {
        bool SoftDeleted { get; set; }
    }
}
