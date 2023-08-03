using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models;

[UsedImplicitly(ImplicitUseTargetFlags.Members)]
[Resource]
[Table("Product")]
public class Product : IIdentifiable<int>
{
    [Key]
    [Attr]
    [Column("ProductId")]
    public int Id { get; set; }
    //public int ProductId { get; set; }

    [Attr]
    public string Name { get; set; } = null!;

    [Attr]
    public double Price { get; set; }

    int IIdentifiable<int>.Id
    {
        get => Id;
        set => Id = value;
        //get => ProductId;
        //set => ProductId = value;
    }

    string? IIdentifiable.StringId
    {
        get => Id.ToString();
        set => Id = int.Parse(value ?? "0");
        //get => ProductId.ToString();
        //set => ProductId = int.Parse(value ?? "0");
    }
    
    string? IIdentifiable.LocalId { get; set; }
}