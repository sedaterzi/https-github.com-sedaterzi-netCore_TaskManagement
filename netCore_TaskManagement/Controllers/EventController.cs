using Microsoft.AspNetCore.Mvc;
using netCore_TaskManagement.Data;
using netCore_TaskManagement.Data.Entity;
using netCore_TaskManagement.Models;
using System;
using System.Linq;

namespace netCore_TaskManagement.Controllers
{
    public class EventController : Controller
    {
        private ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }
        public JsonResult GetEvent()
        {
            var model = _context.Events.Select(x => new EventViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Description = x.Description,
            });
            return Json(model);
        }
        [HttpPost]
        public JsonResult AddOrUpdateEvent(AddOrUpdateEventModel model)
        {
            if (model.Id == 0)
            {
                Event entity = new Event()
                {
                    CreatedDate = DateTime.Now,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    Description = model.Description,
                    Title = model.Title,
                };

                _context.Add(entity);
                _context.SaveChanges();
            }
            else
            {
                var entity = _context.Events.SingleOrDefault(x => x.Id == model.Id);
                if (entity == null)
                {
                    return Json("Güncellenecek veri bulunamadı.");
                }
                entity.UpdatedDate = DateTime.Now;
                entity.StartDate = model.StartDate;
                entity.EndDate = model.EndDate;
                entity.Description = model.Description;
                entity.Title = model.Title;

                _context.Update(entity);
                _context.SaveChanges();
            }
            return Json("200");
        }

        public JsonResult DeleteEvent(int id = 0)
        {
            var entity = _context.Events.SingleOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return Json("Kayıt bulunamadı.");
            }
            _context.Remove(entity);
            _context.SaveChanges();
            return Json("200");
        }




    }
}
