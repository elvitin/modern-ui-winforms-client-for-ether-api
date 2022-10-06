﻿using AppEngSoft.Models;
using EtherAPI.Control;
using Newtonsoft.Json;

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
      ClienteControl clienteControl = new();
      clienteModel.Id = 0;
      string clienteSerializado = JsonConvert.SerializeObject(
        clienteModel,
        Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
      );
      clienteControl.Salvar(clienteSerializado);
    }

    public void Deletar(uint clienteId)
    {
      throw new NotImplementedException();
    }

    public void Editar(ClienteModel clienteModel)
    {
      ClienteControl clienteControl = new();
      string clienteSerializado = JsonConvert.SerializeObject(
        clienteModel,
        Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
      );
      MessageBox.Show("Cliente editado:\n\n" + clienteSerializado);
      clienteControl.Salvar(clienteSerializado);
    }

    public IEnumerable<ClienteModel> ObterPorValor(string valor)
    {
      ClienteControl clienteControl = new();
      MessageBox.Show("Obtendo por valor!");
      string json = clienteControl.ObterPorValor(valor);
      MessageBox.Show(json);
      List<ClienteModel> clientes = JsonConvert.DeserializeObject<List<ClienteModel>>(json);
      return clientes;
    }

    public IEnumerable<ClienteModel> ObterTodos()
    {

      ClienteControl clienteControl = new();
      
      string json = clienteControl.ObterTodos();
      MessageBox.Show(json);
      List<ClienteModel> clientes = JsonConvert.DeserializeObject<List<ClienteModel>>(json);
      return clientes;
    }
  }
}
