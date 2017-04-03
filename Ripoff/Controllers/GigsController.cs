using Microsoft.AspNet.Identity;
using Ripoff.Models;
using Ripoff.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;


namespace Ripoff.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;
        public GigsController()
        {
            _context = new ApplicationDbContext(); 
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
                //GeneresNames = GetGeneres()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            //query
            //var artistId = User.Identity.GetUserId();
            //var artist = _context.Users.Single(u => u.Id == artistId);
            //var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);

            //asocijacija na objekt
            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        //private IEnumerable<SelectListItem> GetGeneres()
        //{
        //    var generes = _context.Genres.Select(x => new SelectListItem
        //    {
        //        Value = x.Id.ToString(),
        //        Text = x.Name
        //    });
        //    return generes;
        //}
       
    }
}