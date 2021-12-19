using System.Collections.Generic;
using Lanza.NotificationContext;

namespace Lanza.ContentContext
{
    // Como um artigo é um Conteúdo propriamente dito, não há necessidade de implementações extras.
    public class Article : Content
    {
        // Ao ser instanciada o construtor passa os parâmetros para o construtor da classe pai.
        public Article(string title, string url)
            : base(title, url)
        {

        }
    }
}
