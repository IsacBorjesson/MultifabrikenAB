using System;
using System.Collections.Generic;
using System.Text;

namespace MultifabrikenAB
{
    class InventoryDepartment
    {
        public List<CarDepartment> CarList;
        public List<CandyDepartment> CandyList;
        public List<PipeDepartment> PipeList;

        public InventoryDepartment()
        {
            CarList = new List<CarDepartment>();
            CandyList = new List<CandyDepartment>();
            PipeList = new List<PipeDepartment>();
        }
        

        

    }
}
