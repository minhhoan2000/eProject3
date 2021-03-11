using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Railway.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Railway.Controllers
{
    public class HomeController : Controller
    {

        private RailwayContext context;
        
        public HomeController(RailwayContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
         
            
            
            return View();
        }

        public IActionResult Search(string to,string from,string tim )
        {
            var station = context.Stations.FirstOrDefault(s => s.FromWhere.Equals(from) && s.ToWhere.Equals(to)
            );
           
            //2. Tạo câu truy vấn kết 2 bảng Link, Category bằng mệnh đề join
           // var links = from l in context.Trains
                      //  join c in context.Stations on l.StationID equals c.StationID
                      //  select new { l.TrainID, l.TrainName,  l.StationID, c.SttionName ,c.TimeStart,c.FromWhere,c.ToWhere };
            ViewBag.trains= context.Trains.Where(t=>t.StationID.Equals(station.StationID.Equals(station.StationID))).ToList();
            //3. Tìm kiếm chuỗi truy vấn



            if (!String.IsNullOrEmpty(to))
                {
                   // links = links.Where(s => s.ToWhere.Contains(to));

                }
                if (!String.IsNullOrEmpty(from))
                {
                  //  links = links.Where(s => s.FromWhere.Contains(from));

                }
            if (!String.IsNullOrEmpty(tim))
            {
            //    links = links.Where(s => s.TimeStart.Contains(tim));

            }

            //4. Tìm kiếm theo CategoryID

            //5. Chuyển đổi kết quả từ var sang danh sách List<Link>
           /* List<Train> listLinks = new List<Train>();
            foreach (var item in links)
            {
                Train temp = new Train();
                temp.StationID = item.StationID;
                var satin = context.Stations.Find(item.StationID);
                satin.StationName = item.StationName;
                satin.TimeStart = item.TimeStart;
                temp.TrainID = item.TrainID;
                temp.TrainName = item.TrainName;
                satin.FromWhere = item.FromWhere;
                satin.ToWhere = item.ToWhere;



                listLinks.Add(temp);
            }*/
            return View(station);
        }
      public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Train train)
        {

            return View();
        }


    }
}
