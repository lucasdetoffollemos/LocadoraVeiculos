using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    #region Input

    public class ParceiroInputViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]

        public string Nome { get; set;}
    }

    public class ParceiroCreateViewModel : ParceiroInputViewModel, ITituloViewModel
    {
        public string Titulo => "Cadastro de Parceiros";
    }
    #endregion
}
