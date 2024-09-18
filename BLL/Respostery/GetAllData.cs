using AutoMapper;
using BLL.InterFace;
using DAL.DataBase;
using DAL.Entities;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Respostery
{
    public class GetAllData : IGetData
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;
        public GetAllData(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public bool Add(Surveydetails_vm ENtity, string[] response)
        {
            try
            {
                Details_Task details_Task = new Details_Task();
                details_Task.Addries = ENtity.Government +"-"+ ENtity.City+"-"+ ENtity.area+"-"+ ENtity.park;
                details_Task.Day = ENtity.Day;
                details_Task.year=ENtity.year;
                details_Task.data = ENtity.data;
               
                details_Task.month= ENtity.month;
                



                var Add =db.Details_Task_TBL.Add(details_Task);
                db.SaveChanges();
                
                string [] categories = { "منطقة الخدمات", "البويات", "منطقة الأطفال", "المواقف", "المظلات", "الطرق والممرات" };
                int number = 0;
                foreach (var item in response)
                {

                    SurveysVistor surveysVistor = new SurveysVistor();
                    surveysVistor.Details_TaskID = details_Task.ID;
                    surveysVistor.NameService = categories[number];
                    surveysVistor.Think = item;
                    db.SurveysVistor_TBL.Add(surveysVistor);
                    number++;

                }
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

               return false;
            }
        }

        public IQueryable<Area> Getallarea(int id)
        {
           var entities = db.Area_TBL.Where(x=>x.cityId==id).ToList();return entities.AsQueryable();
        }

        public IQueryable<Citys> Getallcity(int id)
        {
           var entities = db.Citys_TBL.Where(x => x.governorateId == id).ToList();return entities.AsQueryable();
        }

        public IQueryable<governorate> Getallgovernorate()
        {
           var entities = db.governorate_TBL.ToList();return entities.AsQueryable();
        }

        public IQueryable<Park> Getallpark(int id)
        {
           var entities = db.Park_TBL.Where(x => x.AreaId == id).ToList(); return entities.AsQueryable();
        }
    }
}
