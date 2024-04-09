using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
  public  class SYS_CONFIG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public TB_Config getItem(String name)
        {
            return db.TB_Config.FirstOrDefault(x => x.Name == name);
        }

    }
}
