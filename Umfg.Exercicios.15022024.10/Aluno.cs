using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Exercicios._15022024._10
{
    public sealed class Aluno
    {
        public string Nome {  get; set; }
        public string RA {  get; set; }
        public float NotaProva {  get; set; }
        public float NotaTrabalho {  get; set; }
        public uint Faltas {  get; set; }

        public Aluno(string nome, string ra) 
        {
            Nome = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentNullException(nameof(nome)) : nome;

            RA = string.IsNullOrWhiteSpace(ra)
                ? throw new ArgumentNullException(nameof(ra)) : ra;

            NotaProva = 0;

            NotaTrabalho = 0;

            Faltas = 0;
        }

    }
}
