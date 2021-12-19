using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Lanza.ContentContext;
using Lanza.SubscriptionContext;

namespace Lanza
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Article Example
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "c-sharp"));
            articles.Add(new Article("Artigo sobre .NET 6", "dotnet-6"));
            articles.Add(new Article("Artigo sobre Angular", "angular"));

            articles.ForEach(article => Console.WriteLine($"-{article.Id}\n-{article.Title}\n-{article.Url}\n"));
            Console.WriteLine($"Total de artigos {articles.Count}");
            #endregion

            Thread.Sleep(3000);
            Console.Clear();

            #region Course Example
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos do C#", "fundamentos-c#");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);
            #endregion

            #region Career Example
            var careers = new List<Career>();
            var careerDotnet = new Career("Carreira .NET", "carreira-dotnet");
            var careerItem3 = new CareerItem(3, "Comece por aqui", "", courseCsharp);
            var careerItem = new CareerItem(1, "Introdução a OOP", "", null);
            var careerItem2 = new CareerItem(2, "Introdução ao ASP.NET", "", courseAspNet);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);
            #endregion

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    // Caso haja notificações de erro, mostra a propriedade em que o erro ocorreu e a mensagem
                    // Sem parar a aplicação pois o erro foi tratado em CareerItem.
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            #region Subscription example
            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
            #endregion
        }
    }
}
