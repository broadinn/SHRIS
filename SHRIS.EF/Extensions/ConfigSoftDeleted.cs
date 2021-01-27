using SHRIS.EF.Models.Interface;
using SoftDeleteServices.Configuration;

namespace SHRIS.EF.Extensions
{
    class ConfigSoftDeleted : SingleSoftDeleteConfiguration<ISoftDelete>
    {
        public ConfigSoftDeleted(AppDbContext dbContext) : base(dbContext)
        {
            GetSoftDeleteValue = entity => entity.SoftDeleted;
            SetSoftDeleteValue = (entity, value) =>
            {
                entity.SoftDeleted = value;
            };
        }
    }
}
