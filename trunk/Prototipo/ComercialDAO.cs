using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comercial
{
    class ComercialDAO
    {
        private COMERCIALEntities db = new COMERCIALEntities();

        public COMERCIALEntities getComercialEntities()
        {
            return db;
        }
    }
}
