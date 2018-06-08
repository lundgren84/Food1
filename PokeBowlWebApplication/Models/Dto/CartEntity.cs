using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Models.Dto
{
    public enum CartType
    {
        Anonymous,
        Authenticated
    }
    public class CartEntity
    {
        public int Id { get; set; }
        public string RecordId { get; set; }
        public string UserName { get; set; }
        public CartType CartType { get; set; }
        public DateTime Created { get; set; }

        //Collections
        public List<CartLineEntity> Lines { get; set; } = new List<CartLineEntity>();
    }
}