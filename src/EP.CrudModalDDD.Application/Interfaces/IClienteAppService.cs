using System;
using System.Collections.Generic;
using EP.CrudModalDDD.Application.ViewModels;

namespace EP.CrudModalDDD.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);
        ClienteViewModel ObterPorId(Guid id);
        ClienteViewModel ObterPorCpf(string cpf);
        ClienteViewModel ObterPorEmail(string email);
        IEnumerable<ClienteViewModel> ObterTodos();
        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);
        void Remover(Guid id);

        EnderecoViewModel AdicionarEndereco(EnderecoViewModel enderecoViewModel);
        EnderecoViewModel AtualizarEndereco(EnderecoViewModel enderecoViewModel);
        EnderecoViewModel ObterEnderecoPorId(Guid id);
        void RemoverEndereco(Guid id);
    }
}