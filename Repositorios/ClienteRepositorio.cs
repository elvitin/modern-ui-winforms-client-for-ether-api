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
      uint petId = uint.TryParse(valor, out _) ? Convert.ToUInt32(valor) : 0;

      List<ClienteModel> clientes = new();
      if (petId == 0)
      {
        for (int i = 0; i < 4; i++)
        {
          clientes.Add(new()
          {
            Id = (uint)i,
            Email = "tavis@outlook.com",
            Fone = "18 99681 1971",
            Nome = "Emilly Rodrigues",
            TipoPessoa = "Juridica"
          });
        }
      }
      else
      {
        clientes.Add(new()
        {
          Id = petId,
          Email = "taveirinha@outlook.com",
          Fone = "18 99681 1971",
          Nome = "Emilly Rodrigues",
          TipoPessoa = "Juridica"
        });
      }
      return clientes;
    }

    public IEnumerable<ClienteModel> ObterTodos()
    {
      //Chamamento da API
      List<ClienteModel> clientes = new();

      for (int i = 0; i < 100; i++)
      {
        clientes.Add(new()
        {
          Id = (uint)i,
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
