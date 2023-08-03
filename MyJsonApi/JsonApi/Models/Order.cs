using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models;

[UsedImplicitly(ImplicitUseTargetFlags.Members)]
[Resource]
[Table("Order")]
public class Order : IIdentifiable<int>
{
    [Key]
    [Attr]
    [Column("OrderId")]
    public int Id { get; set; }
    //public int OrderId { get; set; }
    


    [Attr]
    public int CustomerId { get; set; }

    
    [HasOne]
    public virtual Customer Customer { get; set; } = null!;

    [HasMany]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;

    int IIdentifiable<int>.Id
    {
        get => Id;
        set => Id = value;
        //get => OrderId;
        //set => OrderId = value;
    }

    string? IIdentifiable.StringId
    {
        get => Id.ToString();
        set => Id = int.Parse(value ?? "0");
        //get => OrderId.ToString();
        //set => OrderId = int.Parse(value ?? "0");
    }
    
    string? IIdentifiable.LocalId { get; set; }
}


