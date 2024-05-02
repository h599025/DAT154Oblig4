using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningSystem.Serivces
{
    internal class StatusList: ObservableCollection<string> 
    {
        public StatusList()
        {
            Add("Todo");
            Add("In progress");
            Add("Done");
        }
    }

   
}
