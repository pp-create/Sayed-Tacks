using DAL.Entities;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.InterFace
{
    public interface IGetData
    {
        bool Add(Surveydetails_vm ENtity, string[] response);
        IQueryable<Area> Getallarea(int id);
        IQueryable<Citys> Getallcity(int id);
        IQueryable<Park> Getallpark(int id);
        IQueryable<governorate> Getallgovernorate();
    }
}
