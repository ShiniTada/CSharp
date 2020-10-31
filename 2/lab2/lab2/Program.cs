
using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Учет закупки компьютеров университетом\n");
            bool isShowActions = true;
            while (isShowActions) {
                Console.WriteLine("Выберите действие:\n" +
                                  "1.Добавить/изменить запись\n" +
                                  "2.Удалить запись\n" +
                                  "3.Искать запись\n" +
                                  "4.Просмотр данных в порядке добавления\n" +
                                  "5.Просмотр отсортированных данных\n" +
                                  "0.Выход\n" +
                                  ">>");
                string actionCode = Console.ReadLine();
                if (actionCode.Equals("0")) {
                    isShowActions = false;
                } else { 
                    ActionHandler.doAction(actionCode);
                }
            }
        }
    }
}