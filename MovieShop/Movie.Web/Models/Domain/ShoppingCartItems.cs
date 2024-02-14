using System.ComponentModel.DataAnnotations;

namespace Movie.Web.Models.Domain
{
    public class ShoppingCartItems
    {
        [Key]
        public int Id { get; set; }

        public Movies Movie { get; set; }
        public int Amount { get; set; }


        public string ShoppingCartId { get; set; }
    }
}
