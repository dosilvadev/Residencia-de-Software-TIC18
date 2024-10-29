﻿using ResTIConnect.Domain.Common;

namespace ResTIConnect.Domain.Entities
{
    public class Enderecos : BaseEntity
    {
        public int EnderecoId { get; }
        public required string Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Cidade { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Estado { get; set; }
        public string? Cep { get; set; }
        public string? Pais { get; set; }
        
    }
}