using Microsoft.EntityFrameworkCore;
using System;

namespace Portal.Premium.Repository
{
    public class PortalContext : DbContext
    {
        public PortalContext(DbContextOptions<PortalContext> options)
            : base(options)
        {
        }
    }
}
