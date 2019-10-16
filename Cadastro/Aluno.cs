using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    class Aluno
    {
        public Aluno(string cpf)
        {
            this.cpf = cpf;
        }
        public string cpf { get; }
        public string nome { get; set; }
        public int idade { get; set; }
    }
}
