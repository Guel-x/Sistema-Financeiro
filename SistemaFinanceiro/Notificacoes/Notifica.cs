using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notificacoes
{
    public class Notifica
    {

        public Notifica()
        {
            notificacoes = new List<Notifica>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string mensagem { get; set; }

        [NotMapped]
        public List<Notifica> notificacoes { get; set; }

        public bool ValidarPropriedadeString( string valor, string nomePropeiedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropeiedade))
            {
                notificacoes.Add(new Notifica
                {
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropeiedade,
                });


                return false;
            }

            return true;
        }

        public bool ValidarPropriedadeInt(int valor, string nomePropeiedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropeiedade))
            {
                notificacoes.Add(new Notifica
                {
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropeiedade,
                });


                return false;
            }

            return true;
        }
    }
}
