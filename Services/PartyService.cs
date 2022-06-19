using PartyPlan.Models;

namespace PartyPlan.Services;
public static class PartyService
{
    static List<Party> Parties { get; }
    static int nextId = 3;
    static PartyService()
    {
        Parties = new List<Party>
                {
                    new Party { Id = 1, Name = "Smith Birthday Bash", Type = PartyType.Birthday, PartySize= 47, IsGlutenFree = false, Special = SpecialAddition.Entertainer, Contact = "smith@hotmail.com"},
                    new Party { Id = 2, Name = "Cohen Anniversary Dinner", Type = PartyType.Anniversary, PartySize= 26, IsGlutenFree = true, Special = SpecialAddition.Alcoholic_Beverages, Contact = "daveandedna@yahoo.com"}
                };
    }

    public static List<Party> GetAll() => Parties;

    public static Party? Get(int id) => Parties.FirstOrDefault(p => p.Id == id);

    public static void Add(Party party)
    {
        party.Id = nextId++;
        Parties.Add(party);
    }

    public static void Delete(int id)
    {
        var party = Get(id);
        if (party is null)
            return;

        Parties.Remove(party);
    }

    public static void Update(Party party)
    {
        var index = Parties.FindIndex(p => p.Id == party.Id);
        if (index == -1)
            return;

        Parties[index] = party;
    }
                }