using System;

namespace API.Models
{
    public class Pessoa
    {
        //Construtor
        public Pessoa() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | Criado em: {CriadoEm}";
    }
}