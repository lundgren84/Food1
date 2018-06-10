using PokeBowlWebApplication.Models.Dto;
using System.Collections.Generic;

namespace PokeBowlWebApplication.Models.Home
{
    public class ExtrasModalViewModel
    {
        public int ItemId { get; set; }
        public string ModalTarget { get; set; }
        public string Heading { get; set; }
        public decimal ProductPrice { get; set; }
        public List<ExtrasModel> Extras { get; set; }
    }

    public class ExtrasModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}