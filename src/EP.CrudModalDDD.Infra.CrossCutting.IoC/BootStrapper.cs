using EP.CrudModalDDD.Application;
using EP.CrudModalDDD.Application.Interfaces;
using EP.CrudModalDDD.Domain.Interfaces.Repository;
using EP.CrudModalDDD.Domain.Interfaces.Service;
using EP.CrudModalDDD.Domain.Services;
using EP.CrudModalDDD.Infra.Data.Context;
using EP.CrudModalDDD.Infra.Data.Interfaces;
using EP.CrudModalDDD.Infra.Data.Repository;
using EP.CrudModalDDD.Infra.Data.UoW;
using SimpleInjector;

namespace EP.CrudModalDDD.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App
            container.RegisterPerWebRequest<IClienteAppService, ClienteAppService>();

            // Domain
            container.RegisterPerWebRequest<IClienteService, ClienteService>();

            // Infra Dados
            container.RegisterPerWebRequest<IClienteRepository, ClienteRepository>();
            container.RegisterPerWebRequest<IEnderecoRepository, EnderecoRepository>();
            container.RegisterPerWebRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterPerWebRequest<CrudModalDDDContext>();

            //container.Register(typeof (IRepository<>), typeof (Repository<>));
        }
    }
}