namespace FelveteliFeladat.Models
{
    public class Team
    {
        public int Id { get; }

        public string Name { get; set; }
        public int FoundationYear { get; set; }
        public int NumberOfChampionshipWins { get; set; }
        public bool IsPayedTheEntryFee { get; set; }

        public Team(string name, int foundationYear, int numberOfChampionshipWins, bool isPayedTheEntryFee)
        {
            Name = name;
            FoundationYear = foundationYear;
            NumberOfChampionshipWins = numberOfChampionshipWins;
            IsPayedTheEntryFee = isPayedTheEntryFee;
        }
    }
}
