using BobsBricks.Data;
using BobsBricks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BobsBricks.Controllers
{
    public class GroupBuildController : Controller
    {

        private readonly ApplicationDbContext _db;

        public GroupBuildController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<GroupBuild> groupBuilds = _db.GroupBuilds.OrderBy(x => x.StartTime).Where(x => x.StartTime > System.DateTime.Now).ToList();
            return View(groupBuilds);
        }
        public IActionResult Detail(int id)
        {
            GroupBuild? gb = _db.GroupBuilds.Include(gb => gb.Product).FirstOrDefault(gb => gb.Id == id);
            if (gb != null)
            {
                return View(gb);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
