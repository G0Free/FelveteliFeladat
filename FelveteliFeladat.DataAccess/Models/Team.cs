using System.ComponentModel.DataAnnotations;

namespace FelveteliFeladat.Models
{
    public class Team : Entity
    {
        [Key]
        public int Id { get; }
        
        [MaxLength(50)]
        public string Name { get; set; }
        public int FoundationYear { get; set; }

        [Range(0,int.MaxValue)]
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
