using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            //var albums = GetAlbums();
            return View();
        }

        //public ActionResult Buy(int id)
        //{
        //    var album = GetAlbums().Single(a => a.AlbumId == id);

        //    //Charge the user
        //    return View(album);
        //}

        //public static List<Album> GetAlbums()
        //{
        //    var albums = new List<Album>
        //    {
        //        new Album{AlbumId = 1, Title = "The Fall of Math", price = 8.99M},
        //        new Album{AlbumId = 1, Title = "The Fall of Math", price = 8.99M},
        //        new Album{AlbumId = 1, Title = "The Fall of Math", price = 8.99M},
        //        new Album{AlbumId = 1, Title = "The Fall of Math", price = 8.99M},

        //    };
        //    return albums;
        //}
        //public string Index()
        //{
        //    return "Hello from Store.Index()";
        //}

        //public string browse(string genre)
        //{
        //    string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
        //    return message;
        //}
        //public string Details(int id)   
        //{
        //    string message = HttpUtility.HtmlDecode("Store.Details, ID = "+ id);
        //    return message;
        //}
	}
}