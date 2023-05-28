using AutoMapper;
using MnanejoPresupuesto.Models;

namespace MnanejoPresupuesto.Servicios
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Cuenta, CuentaCreacionViewModel>();
            CreateMap<TransaccionActualizacionViewModel,Transaccion>().ReverseMap();
            
        }
    }
}
