using System.ComponentModel.DataAnnotations;

namespace PartyPlan.Models;

public class Party
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Range(1, 100)]
    public int PartySize  { get; set; }
    public PartyType Type { get; set; }
    public bool IsGlutenFree { get; set; }
    public SpecialAddition Special {get;set;}
    public string? Contact {get;set;}

}

public enum PartyType{ Birthday, Anniversary, Engagement, Special_Order }
public enum SpecialAddition{Balloon_Arch, Sparklers, Alcoholic_Beverages, Entertainer, }

