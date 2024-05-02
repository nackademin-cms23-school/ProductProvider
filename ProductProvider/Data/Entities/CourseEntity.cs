using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductProvider.Data.Entities;

public class CourseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string PartitionKey { get; set; } = "Courses";
    public bool IsBestseller { get; set; }
    public bool IsDigital { get; set; }
    public List<string> Categories { get; set; } = [];
    public string Title { get; set; } = null!;
    public string Ingress { get; set; } = null!;
    public int StarRating { get; set; }
    public string Reviews { get; set; } = null!;
    public string LikesInProcent { get; set; } = null!;
    public string Likes { get; set; } = null!;
    public int Hours { get; set; }
    public List<string> Authors { get; set; } = [];
    public Prices Prices { get; set; } = null!;
    public Content Content { get; set; } = null!;
}

public class Prices
{
    public string Currency { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}

public class Content
{
    public string Description { get; set; } = null!;
    public List<string> Includes { get; set; } = [];
    public List<Programdetail> ProgramDetails { get; set; } = [];
}

public class Programdetail
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
}