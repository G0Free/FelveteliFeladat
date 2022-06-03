using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FelveteliFeladat.Models
{
    public class Team : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }
        public int FoundationYear { get; set; }

        [Range(0,int.MaxValue)]
        public int NumberOfChampionshipWins { get; set; }
        public bool IsPayedTheEntryFee { get; set; }

        public Team(int id, string name, int foundationYear, int numberOfChampionshipWins, bool isPayedTheEntryFee)
        {
            Id = id; 
            Name = name;
            FoundationYear = foundationYear;
            NumberOfChampionshipWins = numberOfChampionshipWins;
            IsPayedTheEntryFee = isPayedTheEntryFee;
        }
        public Team()
        {

        }
    }
}
