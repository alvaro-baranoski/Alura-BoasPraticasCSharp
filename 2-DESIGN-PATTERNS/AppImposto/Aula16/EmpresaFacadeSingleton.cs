using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula16
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia()
        {
            return facade;
        }
    }
}