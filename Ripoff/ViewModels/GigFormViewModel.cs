using Ripoff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Ripoff.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Genre { get; set; }
        [Required]
        public IEnumerable<Genre> Genres  { get; set; }

        //[Required]
        //public DateTime DateTime
        //{
        //    get { return DateTime.Parse(string.Format("{0}{1}", Date, Time)); }
        //}
        public IEnumerable<SelectListItem> GeneresNames { get; set; }
    }
}