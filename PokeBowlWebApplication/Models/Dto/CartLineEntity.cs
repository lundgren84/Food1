using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeBowlWebApplication.Models.Dto
{
    public class CartLineEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImgUrl { get; set; } = Global.DefaultFoodImgUrl;
        public string Description { get; set; }
        public decimal? UnitPrice { get; set; }
        public int Quantity { get; set; }
        //Foreign Keys
        [DisplayName("Cart reference Id")]
        public int CartRefId { get; set; }
        [ForeignKey("CartRefId")]
        public virtual CartEntity Cart { get; set; }
    }
}