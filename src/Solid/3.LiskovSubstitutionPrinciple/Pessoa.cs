﻿namespace Solid._3.LiskovSubstitutionPrinciple
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual string RetornarDados()
        {
            return Nome;
        }
    }
}
