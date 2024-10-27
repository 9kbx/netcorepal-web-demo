﻿using NetCorePal.Extensions.Repository.EntityFrameworkCore;
using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;
using My.Project.D3Shop.Infrastructure.EntityConfigurations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using My.Project.D3Shop.Domain.AggregatesModel.DeliverAggregate;

namespace My.Project.D3Shop.Infrastructure
{
    public partial class ApplicationDbContext(DbContextOptions options, IMediator mediator, IServiceProvider provider)
        : AppDbContextBase(options, mediator, provider)
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            ConfigureStronglyTypedIdValueConverter(configurationBuilder);
            base.ConfigureConventions(configurationBuilder);
        }

        public DbSet<Order> Orders => Set<Order>();
        public DbSet<DeliverRecord> DeliverRecords => Set<DeliverRecord>();
    }
}