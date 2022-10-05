using AppEngSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEngSoft.Repositorios
{
  internal class ClienteRepositorio : RepositorioBase, IClienteRepositorio
  {

    public ClienteRepositorio(string stringConexao)
    {
      base.stringConexao = stringConexao;
    }

    public void Adicionar(ClienteModel clienteModel)
    {
      throw new NotImplementedException();
    }

    public void Deletar(uint clienteId)
    {
      throw new NotImplementedException();
    }

    public void Editar(ClienteModel clienteModel)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ClienteModel> ObterPorValor(string valor)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ClienteModel> ObterTodos()
    {
      //Chamamento da API
      List<ClienteModel> clientes = new();
      clientes.Add(new() { 
        Id = 1,
        Email = "victortavi@outlook.com",
        Fone = "18 99681 1971",
        Nome = "Victor Rodrigues",
        TipoPessoa = "Fisíca"
      });

      clientes.Add(new()
      {
        Id = 2,
        Email = "emillycat@outlook.com",
        Fone = "18 99681 1971",
        Nome = "Emilly Rodrigues",
        TipoPessoa = "Juridica"
      });

      for (int i = 0; i < 100; i++)
      {
        clientes.Add(new()
        {
          Id = 2,
          Email = "emillycat@outlook.com",
          Fone = "18 99681 1971",
          Nome = "Emilly Rodrigues",
          TipoPessoa = "Juridica"
        });
      }
      return clientes;
    }
  }
}
