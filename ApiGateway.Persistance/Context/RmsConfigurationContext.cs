using ApiGateway.Domain.Configuration.Agents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiGateway.Persistance.Context
{
    public class RmsConfigurationContext : DbContext
    {
        private const string SCHEMA = "Configuration";

        public RmsConfigurationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Agent> Agents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Agent>(ConfigureAgentEntity);
        }

        private void ConfigureAgentEntity(EntityTypeBuilder<Agent> agentConfiguration)
        {
            agentConfiguration.ToTable("Agents", SCHEMA);
            agentConfiguration.HasKey(a => a.Id);
            agentConfiguration.Property(a => a.Id).HasField("id").IsRequired();
            agentConfiguration.Property<string>("Name").HasField("name").IsRequired();
            agentConfiguration.Property<string>("Description").HasField("description").IsRequired();
            agentConfiguration.Property<bool>("IsEnabled").HasField("isEnabled").IsRequired();
        }
    }
}