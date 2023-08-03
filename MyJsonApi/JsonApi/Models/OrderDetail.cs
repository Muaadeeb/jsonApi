using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models;

[UsedImplicitly(ImplicitUseTargetFlags.Members)]
[Resource]
[Table("OrderDetail")]
public class OrderDetail : IIdentifiable<int>
{
    [Key]
    [Attr]
    [Column("OrderDetailId")]
    public int Id { get; set; }
    //public int OrderDetailId { get; set; }

    [Attr]
    public int OrderId { get; set; }

    [Attr]
    public int ProductId { get; set; }

    [Attr]
    public int Quantity { get; set; }

    [Attr]
    public double UnitPrice { get; set; }

    // Optional navigation properties
    // public virtual Order Order { get; set; }
    // public virtual Product Product { get; set; }

    int IIdentifiable<int>.Id
    {
        get => Id;
        set => Id = value;
        //get => OrderDetailId;
        //set => OrderDetailId = value;
    }

    string? IIdentifiable.StringId
    {
        get => Id.ToString();
        set => Id = int.Parse(value ?? "0");
    }
    
    string? IIdentifiable.LocalId { get; set; }
}