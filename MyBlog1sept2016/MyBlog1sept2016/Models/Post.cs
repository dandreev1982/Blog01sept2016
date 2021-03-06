﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlog1sept2016.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
        }
            
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        
        public DateTime Date { get; set; }
        public string Author_Id { get; set; }
        [ForeignKey("Author_Id")]
        public ApplicationUser Author { get; set; }

        public int? CommentsCount { get; set; }
    }
}