using System.ComponentModel;

namespace AppEngSoft.Models.Cliente
{
    internal class PessoaJuridicaModel
    {
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [DisplayName("Inscrição Estadual")]
        public string InscEstadual { get; set; }

        [DisplayName("Inscrição Municipal")]
        public string InscMunicipal { get; set; }
        public uint ClienteId { get; set; }

        public PessoaJuridicaModel()
        {

        }

        public PessoaJuridicaModel(string Cnpj, string InscEstadual, string InscMunicipal, uint ClienteId)
        {
            this.Cnpj = Cnpj;
            this.InscEstadual = InscEstadual;
            this.InscMunicipal = InscMunicipal;
            this.ClienteId = ClienteId;
        }
    }
}
