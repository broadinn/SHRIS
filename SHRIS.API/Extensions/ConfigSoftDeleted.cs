using SHRIS.EF;
using SHRIS.EF.Models.Interface;
using SoftDeleteServices.Configuration;

namespace SHRIS.API.Extensions
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
