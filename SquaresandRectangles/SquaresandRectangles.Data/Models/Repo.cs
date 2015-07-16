using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SquaresandRectangles.Data.Models
{
    public class Repo
    {
        [Key]
        public string Id { get; set; }
        public List<IUniversalItem> Collection { get; set; }
    }
}
