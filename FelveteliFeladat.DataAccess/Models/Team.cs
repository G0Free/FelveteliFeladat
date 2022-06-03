using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FelveteliFeladat.Models
{
    public class Team : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [DisplayName("Foundation Year")]
        public int FoundationYear { get; set; }

        [Required]
        [Range(0,int.MaxValue)]
        [DisplayName("Number of Championship Wins")]
        public int NumberOfChampionshipWins { get; set; }

        [DisplayName("Entry Fee is payed")]
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
