
using Microsoft.EntityFrameworkCore;

namespace Tap2021E02.RepositoryPattern
{
    public interface IEntityTypeConfigurationRegistrar
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}
