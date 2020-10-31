using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;

namespace lab2
{
    public class ActionHandler
    {
        private static string INSERT_DATE = "Введите дату закупки компьютеров в формате дд.мм.гггг\n>>";
        private static string INSERT_COMP_COUNT = "Введите количество компьютеров\n>>";
        
        public static void doAction(string actionCode) 
        {
            switch (actionCode) {
                case "1":
                    addOrUpdateRecord();
                    break;
                case "2":
                    deleteRecord();
                    break;
                case "3":
                    searchRecord();
                    break;
                case "4":
                    readData();
                    break;
                case "5":
                    readSortedData();
                    break;
                default: 
                    Console.WriteLine("Вы выбрали несуществующие действие.");
                    break;
            }
        }
        
        private static DateTime readDate()
        {
            Console.WriteLine(INSERT_DATE);
            return Convert.ToDateTime(Console.ReadLine() + " 00:00:00");
        }

        private static int readCompCount()
        {
            Console.WriteLine(INSERT_COMP_COUNT);
            return Int32.Parse(Console.ReadLine());
        }

        private static CompRecord createCompRecordFromInput()
        {
            DateTime date = readDate();
            int compCount = readCompCount(); 
            return new CompRecord(date, compCount);
        }

        public static void addOrUpdateRecord() 
        {
            string[] allLines = File.ReadAllLines(Paths.root + Paths.compFile);
            CompRecord obj = createCompRecordFromInput();
            List<string> newLines = new List<string>();
            bool haveRecord = false;
            foreach (var line in allLines)
            {
                if (line.Contains(obj.Date.ToShortDateString()))
                {
                    newLines.Add(obj.ToString());
                    haveRecord = true;
                }
                else
                {
                    newLines.Add(line);
                }
            }

            if (!haveRecord)
            {
                newLines.Add(obj.ToString());
            }
            saveRecords(newLines);
        }
        
        public static void deleteRecord() 
        {
            string[] allLines = File.ReadAllLines(Paths.root + Paths.compFile);
            DateTime date = readDate();
            List<string> newLines = new List<string>(allLines);
            string line = allLines.FirstOrDefault(line => line.Contains(date.ToShortDateString()));
            if (line != null)
            {
                newLines.Remove(line);
            }

            saveRecords(newLines);
            Console.WriteLine("Удалено.\n>>");
        }

        public static void searchRecord() 
        {
            string[] allLines = File.ReadAllLines(Paths.root + Paths.compFile);
            DateTime date = readDate();
            string line = allLines.FirstOrDefault(line => line.Contains(date.ToShortDateString()));
            if (line != null)
            {
                Console.WriteLine("Результат:\n" + line + "\n");
            }
            else
            {
                Console.WriteLine("Запись не найдена.\n");   
            }
        }

        public static void readData()
        {
            string data = File.ReadAllText(Paths.root + Paths.compFile);
            Console.Write("\n" + data + "\n");
        }
        public static void readSortedData()
        {
            string[] allRecords = File.ReadAllLines(Paths.root + Paths.compFile);
            Dictionary<DateTime, string> dateRecordMap = new Dictionary<DateTime, string>();
            
            foreach (var record in allRecords)
            {
                int dateLength = "дд.мм.гггг".Length;
                string dateStr = record.Substring(0, dateLength);
                DateTime date = Convert.ToDateTime(dateStr + " 00:00:00");
                dateRecordMap.Add(date, record);
            }
            var sortedMap = new SortedDictionary<DateTime, string>(dateRecordMap);
            Console.Write("\n");
            foreach (var value in sortedMap.Values)
            {
                Console.Write(value + "\n");
            }

            Console.Write("\n");
        }

        private static void saveRecords(List<string> lines)
        {
            File.WriteAllText(Paths.root + Paths.compFile, string.Empty);
            File.WriteAllLines(Paths.root + Paths.compFile, lines);
        }
    }
}