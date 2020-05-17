
/*
 * Теория:
1. Просмотрите презентацию и удостоверьтесь что понимаете изложеный там материал. Не стесняйтесь писать вопросы по непонятным моментам.
2. Если необходимо, почиайте доп. информацию по классам Startup: https://metanit.com/sharp/aspnet5/2.1.php, https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=windows#the-startup-class
и Program: https://metanit.com/sharp/aspnet5/2.13.php, https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=windows#host
На метанит часто неплохо описано, однако бывает немного замудрено, потому лучше также читать на MSDN и желательно английскую версию, т.к. перевод иногда привносит очень странные термины.
3. Если необходимо, прочитайте вступительную теорию по системам контроля версий и Git: https://git-scm.com/book/ru/v2. 

Практика:
1. Создайте проект на основе шаблона Empty Project. Удалите класс Startup. Создайте новый класс с произвольным названием(но не Startup). Сделайте так чтоб новый, созданный вами класс выполнял фунции класса Startup 
и чтоб приложение работало.
2. Выведите в браузере значение ключа "Microsoft.Hosting.Lifetime" из файла appsettings.json.
3. Пользуясь инфо из теории, с помощью GitBash настройте локально другой редактор для Git, выведите установленую наструйку в консоль, чтоб убедится что она сработала. 
Для проверки задания запишите команды которые использовали в файл и залейте в ваш репозиторий или просто скиньте команды мне в Telegram.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Теория:
1. Повторите ветвление и слияние в гит: https://git-scm.com/book/ru/v2 (п. 3.2)
2. Другой взгляд на rebase и merge: https://habr.com/ru/post/432420/
3. Рассуждения по CI/CD: https://habr.com/ru/company/piter/blog/343270/
5. Про Application Layers: https://metanit.com/sharp/mvc5/23.5.php

Практика:
1. Добавьте в ваш проект с прошлого ДЗ файл .gitignore для .NET Core чтоб убрать лишние файла из под версионного контроля. 
Исключение должны составить файлы необходимые для AppVeyor.
2. Добавить ваш проект с ДЗ под Continuous Integration в AppVeyor.
3. В этом же проекте (который создан по шаблону Empty Project), добавьте папку с Controllers и класс HomeController
добавьте туда метод Index с возвращаемым типом string. 
(пока что результат этого метода будет возвращаться прямо на страницу браузера, View создавать не нужно)
Попробуйте вызвать метод по адресу https://localhost:{port}/Home/Index, где port - это порт на котором работает ваше приложение.
4. Добавьте в методы Configure и ConfigureServices класса вызов нужных методов для того чтоб работал вызов созданного вами метода из контроллера. 
Не стесняйтесь копировать из проекта созданного по шаблону MVC, главное запомните, каких методов не хватало для правильного вызова метода в контроллере.
Чем меньше лишнего вы скопируете, тем лучше.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace IntroductionHomeworkKukhar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<RedlineKukharHomework>();
                });
    }
}
