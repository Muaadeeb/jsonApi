using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models;

[UsedImplicitly(ImplicitUseTargetFlags.Members)]
[Resource]
[Table("Customer")]
public class Customer : IIdentifiable<int>
{
    [Key]
    [Attr]
    [Column("CustomerId")]
    public int Id { get; set; }
    //public int CustomerId { get; set; }

    [Attr]
    public string FirstName { get; set; } = null!;

    [Attr]
    public string LastName { get; set; } = null!;

    [Attr]
    public string Email { get; set; } = null!;

    // Additional fields like Address, Phone Number, etc.

    // Uncomment if you need navigation properties
    // public virtual ICollection<Order> Orders { get; set; }

    int IIdentifiable<int>.Id
    {
        get => Id;
        set => Id = value;
        //get => CustomerId;
        //set => CustomerId = value;
    }

    string? IIdentifiable.StringId
    {
        get => Id.ToString();
        set => Id = int.Parse(value ?? "0");
        //get => CustomerId.ToString();
        //set => CustomerId = int.Parse(value ?? "0");
    }
    
    string? IIdentifiable.LocalId { get; set; }
}