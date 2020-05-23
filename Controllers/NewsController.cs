using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 * Теория:

Информация о View: https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-3.1
Общая инфо про Controller: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/actions?view=aspnetcore-3.1
Практика: 0. 
1)В вашем репозитории с ДЗ содайте новый проект по шаблону MVC
2)и скопируйте туда модель News и статический класс NewsBase из моего проекта. 
3)Создайте NewsController.

4)В контроллер NewsController добавьте action Index,
5)при его вызове должны вывестись все News из NewsBase в виде HTML таблицы.

6)Вынесите таблицу из прошлого задания в отдельную секцию.
7)С помощью @RenderSection добавьте эту секцию в _Layout.
8)В navigation bar, который определен у вас в _Layout (с использованием тега nav),
9)добавьте элемент News,
10)при нажатии на него вы должны будете обращаться к action Index
11)контроллера News
12)и соответственно будет отображена таблица с новостями из прошлого задания.
Задача от Бердичева
Скажешь как картинки загружать, и передавать с вебформы в контроллер
Вы верстку проходили?
Вам рассказывали как работают кнопки на вебформе?

Академическое описание паттерна Repository: http://design-pattern.ru/patterns/repository.html
Про внедрение зависимостей (DI) и зависимости в частности: https://habr.com/en/post/349836/,
если будет интересно или необходимо можете прочитать весь цикл этих статьей, на который есть ссылка в статье.
Оригинальная статья про IoC и DI от Марка Фовлера: 
https://martinfowler.com/articles/injection.html#InversionOfControl
Метафорическое(простыми аналогиями) описание преимущества DI контейнеров в первых двух комментариях:
https://ru.stackoverflow.com/questions/461814/%D0%97%D0%B0%D1%87%D0%B5%D0%BC-%D0%BD%D1%83%D0%B6%D0%B5%D0%BD-dependency-injection-%D0%BA%D0%BE%D0%BD%D1%82%D0%B5%D0%B9%D0%BD%D0%B5%D1%80
Повторите информацию из презентации по БД.
Практика:

1)Добавьте в ваш репозиторий новое консольное приложение, 
2)скопируйте туда интерфейсы IFortuneTeller и IFortuneLoader из SimpleDiExample. 
3)Добавьте интерфейс IFortuneGetter и IFortuneFacade. 
4)В IFortuneFacade вам необходимо заинжектить IFortuneLoader и IFortuneGetter. 
5)IFortuneFacade должен содержать два метода, 
6)которые будут выводить или возвращать предсказание из IFortuneTeller
7)и IFortuneGetter соответственно. 
8)В оба и IFortuneLoader и IFortuneGetter необходимо инжектить IFortuneLoader. 
9)В Main вам с помощью Unity необходимо зарегистрировать все четыре экземпляра 
10)для каждого из интерфейсов и сделать Rezolve для IFortuneFacade. 
11)Попробуйте вызвать оба его метода.

12)Добавьте в проект с News то что на данный момент есть в моем проекте Infestation
13)+ то что мы сделали в нем на уроке. 
14)Переименуйте проект в Infestation(или в то, что по вашему усмотрению больше подходит для названия, 
15)это будет проект-инфографика количества больных вирусом на текущий момент времени, 
16)плюс будет раздел новостей). 
17)Это будет проект на который мы будем навешивать плюшки и выполнять на нем некоторые задания.
18)Поставьте все проекты в вашем репозитории с ДЗ(их должно быть 3 на данный момент) под CI.

19)На все эти проекты должен быть создан всего один проект в AppVeyor. 20)
Для этого вам придется разобратся с build matrix.

 */
namespace IntroductionHomeworkKukhar.Controllers
{
    public class NewsController : Controller
    {
    }
}
