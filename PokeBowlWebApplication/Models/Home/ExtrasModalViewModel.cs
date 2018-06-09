using System.Collections.Generic;

namespace PokeBowlWebApplication.Models.Home
{
    public class ExtrasModalViewModel
    {
        public string ModalId { get; set; }
        public string Heading { get; set; }
        public decimal ProductPrice { get; set; }
        public List<ExtrasModel> Extras { get; set; }
    }

    public class ExtrasModel
    {
        public string Name { get; set; } = "Tonfisk";
        public decimal Price { get; set; } = 25.0M;
    }
}