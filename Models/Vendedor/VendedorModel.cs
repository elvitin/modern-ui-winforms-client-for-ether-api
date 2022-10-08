namespace AppEngSoft.Models.Vendedor
{
    internal class VendedorModel
    {
        public uint Id { get; set; }
        public string Nome { get; set; }

        public VendedorModel(uint id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public VendedorModel()
        {

        }
    }
}
