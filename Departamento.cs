using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Composicao
{
    internal class Departamento
    {
        public string Nome { get; set; }

        public string Codigo { get; set;}

        public List<Funcionario> Funcionarios { get; set; }
    }
}
