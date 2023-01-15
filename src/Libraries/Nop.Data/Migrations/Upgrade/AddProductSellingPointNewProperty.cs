using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;
using Nop.Core.Domain.Catalog;
using Nop.Data.Migrations;

[NopMigration("2023-01-15 00:00:00", "Product. Add selling point", UpdateMigrationType.Data, MigrationProcessType.Update)]
public class AddProductSellingPointNewProperty : AutoReversingMigration
{
    /// <summary>Collect the UP migration expressions</summary>
    public override void Up()
    {
        Create.Column(nameof(Product.SellingPoint))
        .OnTable(nameof(Product))
        .AsString(int.MaxValue)
        .Nullable();
    }
}