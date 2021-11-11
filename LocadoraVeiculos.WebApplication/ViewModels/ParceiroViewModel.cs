using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WebApplication.ViewModels
{
    #region List
    public class ParceiroListViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }

    public class ParceiroIndexViewModel : ITituloViewModel
    {
        public string Titulo => "Parceiros";
       
        public List<ParceiroListViewModel> registros { get; set; } 
    }


    #endregion
}
