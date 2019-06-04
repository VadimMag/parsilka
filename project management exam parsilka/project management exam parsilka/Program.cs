using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_management_exam_parsilka
{
    class Program
    {
        public Dictionary<string, int> Parsilka(string path)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            string book = File.ReadAllText(path);

            int BLen = book.Length;
            bool WordCorrect = true;
            int WordStart = -1;
            for (int i = 0; i < BLen; i++)//запуск цикла прохода всех символов в файле
            {
                char ch = book[i];

                if (ch == '\r' || ch == '\n' || ch == ',' || ch == '!' || ch == '?' || ch == '.' || ch == ';' || ch == ':' || ch == ' ')//нахождение разделителя
                {
                    if (WordCorrect == true && WordStart > -1/* && book[i - 1] != '-'*/)//разделитель найден проверка на правильность слова
                    {
                        string word = book.Substring(WordStart, i - WordStart);//если слово правильно выделяем его
                        if (dic.ContainsKey(word))//и заносим в словарь
                        {
                            int count = dic[word];
                            dic[word] = count + 1;
                        }
                        else
                        {
                            dic[word] = 1;
                        }
                    }
                    WordCorrect = true;//сброс настроек проверки на правильность слова
                    WordStart = -1;
                    continue;
                }
                if (WordCorrect == false)//прокручивание итерации если слово уже неправильное
                {
                    continue;
                }
                if (!(ch >= 'a' && ch <= 'z') && ch != '-' && !(ch >= 'A' && ch <= 'Z')&& ch != '\'')//перечислены все разрешённые символы если этот символ не тот, слово помечается неправильным
                {
                    WordCorrect = false;
                    continue;
                }
                /*if (WordStart == -1 && ch == '-')//
                {
                    WordCorrect = false;
                    continue;
                }*/
                if (WordStart == -1)//запись точки начала слова
                {
                    WordStart = i;
                    continue;
                }

            }

            return dic;
        }

        static void Main(string[] args)
        {
            Program pr = new Program();
            Dictionary<string, int> asd = pr.Parsilka(@"c:\temp\north.sql");

            foreach (var item in asd)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
            

        }
    }
}
