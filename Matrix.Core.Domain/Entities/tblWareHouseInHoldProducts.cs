using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblWareHouseInHoldProducts
    {
        [Key]
        public int RecID { get; set; }
        public int ModelID { get; set; }
        public int WareHouseID { get; set; }
        public int QTY { get; set; }

        [ForeignKey("WareHouseID")]
        public virtual tblWareHouse WareHouse { get; set; }

        [ForeignKey("ModelID")]
        public virtual tblModels Model { get; set; }
    }
}
