
/*
 * ������:
1. ����������� ����������� � �������������� ��� ��������� ��������� ��� ��������. �� ����������� ������ ������� �� ���������� ��������.
2. ���� ����������, �������� ���. ���������� �� ������� Startup: https://metanit.com/sharp/aspnet5/2.1.php, https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=windows#the-startup-class
� Program: https://metanit.com/sharp/aspnet5/2.13.php, https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=windows#host
�� ������� ����� ������� �������, ������ ������ ������� ���������, ������ ����� ����� ������ �� MSDN � ���������� ���������� ������, �.�. ������� ������ ��������� ����� �������� �������.
3. ���� ����������, ���������� ������������� ������ �� �������� �������� ������ � Git: https://git-scm.com/book/ru/v2. 

��������:
1. �������� ������ �� ������ ������� Empty Project. ������� ����� Startup. �������� ����� ����� � ������������ ���������(�� �� Startup). �������� ��� ���� �����, ��������� ���� ����� �������� ������ ������ Startup 
� ���� ���������� ��������.
2. �������� � �������� �������� ����� "Microsoft.Hosting.Lifetime" �� ����� appsettings.json.
3. ��������� ���� �� ������, � ������� GitBash ��������� �������� ������ �������� ��� Git, �������� ������������ ��������� � �������, ���� �������� ��� ��� ���������. 
��� �������� ������� �������� ������� ������� ������������ � ���� � ������� � ��� ����������� ��� ������ ������� ������� ��� � Telegram.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

������:
1. ��������� ��������� � ������� � ���: https://git-scm.com/book/ru/v2 (�. 3.2)
2. ������ ������ �� rebase � merge: https://habr.com/ru/post/432420/
3. ����������� �� CI/CD: https://habr.com/ru/company/piter/blog/343270/
5. ��� Application Layers: https://metanit.com/sharp/mvc5/23.5.php

��������:
1. �������� � ��� ������ � �������� �� ���� .gitignore ��� .NET Core ���� ������ ������ ����� �� ��� ����������� ��������. 
���������� ������ ��������� ����� ����������� ��� AppVeyor.
2. �������� ��� ������ � �� ��� Continuous Integration � AppVeyor.
3. � ���� �� ������� (������� ������ �� ������� Empty Project), �������� ����� � Controllers � ����� HomeController
�������� ���� ����� Index � ������������ ����� string. 
(���� ��� ��������� ����� ������ ����� ������������ ����� �� �������� ��������, View ��������� �� �����)
���������� ������� ����� �� ������ https://localhost:{port}/Home/Index, ��� port - ��� ���� �� ������� �������� ���� ����������.
4. �������� � ������ Configure � ConfigureServices ������ ����� ������ ������� ��� ���� ���� ������� ����� ���������� ���� ������ �� �����������. 
�� ����������� ���������� �� ������� ���������� �� ������� MVC, ������� ���������, ����� ������� �� ������� ��� ����������� ������ ������ � �����������.
��� ������ ������� �� ����������, ��� �����.
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
