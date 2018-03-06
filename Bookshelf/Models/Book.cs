using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book // it is the one table in the one-to-many dynamic
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        //navigation property
        [ForeignKey("Category")]//same as primary key in category class (many table)
        public int CategoryID { get; set; } //foreign key allows relationship
        public virtual Category Category { get; set; } //
    }
}