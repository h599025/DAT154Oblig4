using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningSystem.Serivces
{
    public static class ArrangeData
    {

        public static List<Service> Cleaning(List<Service> Services)
        {
            foreach(var item in Services)
            {
                item.Description = item.Cleaning;
            }
            return Services;
        }


        public static List<Service> Service(List<Service> Services)
        {
            foreach (var item in Services)
            {
                item.Description = item.Service1;
            }
            return Services;
        }

        public static List<Service> Maintenance(List<Service> Services)
        {
            foreach (var item in Services)
            {
                item.Description = item.Maintenance;
            }
            return Services;
        }
    }
}
