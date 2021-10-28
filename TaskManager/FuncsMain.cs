using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class FuncsMain
    {
        public struct User
        {
            public string login; //логин
            public string pass; //пароль
            public string f_name; //имя
            public string l_name; //фамилия
            public string department; //отдел

            //конструктор для регистрации
            public User(string log, string p, string f, string l_n, string d)
            {
                this.login = log;
                this.pass = SHA256Hash(p);
                this.f_name = f;
                this.l_name = l_n;
                this.department = d;
            }

            //конструктор для авторизации
            public User(string log, string p)
            {
                this.login = log;
                this.pass = SHA256Hash(p);

                this.f_name = "";
                this.l_name = "";
                this.department = "";
            }
        }

        //ХЭШ паролей
        public static string SHA256Hash(string msg)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //вычисляем значение
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(msg));

                //конвентируем в строку
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //регистрация
        public static bool UserReg(User acc)
        {
            //проверяем уникальность аккаунта
            string cmd = String.Format("SELECT id FROM users WHERE login = '{0}'", acc.login);

            if (FuncsDB.SQLSelect(cmd) != "null")
                return false;
          
            //запрос на регистрацию
            cmd = String.Format("INSERT INTO users (login, pass, first_name, last_name, department) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                acc.login, acc.pass, acc.l_name, acc.f_name, acc.department);     
            FuncsDB.SQLIUD(cmd); //вставка

            return true;
        }

        //авторизация
        public static int Auth(User acc)
        {
            //проверка имени и пароля
            string cmd = String.Format("SELECT id FROM users WHERE login = '{0}' AND pass = '{1}'", acc.login, acc.pass);

            string result = FuncsDB.SQLSelect(cmd);

            if (result == "-1" || result == "null")
                return -1;
            else
                return Convert.ToInt32(result);
        }

        public static List<string> DepartmentList()
        {
            string cmd = "SELECT name FROM department";

            List<string> allDepartament = new List<string> { };

            allDepartament = FuncsDB.SQLSelect(cmd, 1);

            if (allDepartament == null || allDepartament[0] == "Ошибка")
                allDepartament.Add("Ошибка загрузки данных, проверьте плдключение к сети."); 

            return allDepartament;
        }
    }
}
