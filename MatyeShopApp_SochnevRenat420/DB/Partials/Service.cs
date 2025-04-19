using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatyeShopApp_SochnevRenat420.DB
{
    public partial class Service
    {
        public string CollectionName
        {
            get
            {
                return ServiceCollection == null ? "Отсутствует" : ServiceCollection.Name;
            }
            set
            {

            }
        }
    }
}
