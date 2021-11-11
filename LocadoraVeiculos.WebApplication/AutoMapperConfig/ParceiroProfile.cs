using AutoMapper;
using LocadoraVeiculos.netCore.Dominio.ParceiroModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace LocadoraVeiculos.WebApplication.AutoMapperConfig
{
    public class ParceiroProfile : Profile
    {
        //public ParceiroProfile()
        //{
        //    ConfigurarConversaoDeDominioParaViewModel();

        //    ConfigurarConversaoDeViewModelParaDominio();
        //}

        //private void ConfigurarConversaoDeDominioParaViewModel()
        //{
        //    CreateMap<List<Parceiro>, ParceiroIndexViewModel>()
        //        .ForMember(dest => dest.Registros, opt => opt.MapFrom(a => a));

        //    CreateMap<Parceiro, ParceiroEditViewModel>();

        //    CreateMap<Parceiro, ParceiroDeleteViewModel>();

        //    CreateMap<Parceiro, ParceiroDetailsViewModel>();

        //    CreateMap<Parceiro, ParceiroListViewModel>();

        //    CreateMap<Parceiro, SelectListItem>()
        //        .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Nome))
        //        .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));
        //}
    }
}
