using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEngSoft.Models.Utils
{
  internal class ModelValidacao
  {
    public void Validar(object model)
    {
      StringBuilder mensagemErro = new();
      List<ValidationResult> erros = new();
      ValidationContext context = new(model);
      bool isValid = Validator.TryValidateObject(model, context, erros, true);
      if (!isValid)
      {
        foreach (var erro in erros)
        {
          mensagemErro.AppendLine(erro.ErrorMessage);
        }
        throw new(mensagemErro.ToString());
      }
    }
  }
}
