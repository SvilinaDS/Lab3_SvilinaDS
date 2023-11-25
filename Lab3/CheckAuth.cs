using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class CheckAuth
    {
        public (string, string) CheckData(string login, string password, string repeatPassword)
        {
            if (login.Length == 0)
            {
                return ("Ошибка", "Задан пустой логин");
            }
            else
            {
                if (login.Contains("+"))
                {
                    if (login.Any(c => char.IsLetter(c)))
                    {
                        return ("Ошибка", "Номер телефона не должен содержать букв");
                    }
                    else if (login.Substring(1).Any(c => char.IsSymbol(c)))
                    {

                        return ("Ошибка", "Логин не  должен содержать символов");

                    }
                    else if (login.Any(c => char.IsPunctuation(c)))
                    {

                        return ("Ошибка", "Логин не должен содержать знаки препинания");
                    }
                    else if (login.Any(c => char.IsWhiteSpace(c)))
                    {

                        return ("Ошибка", "Логин не должен содержать пробелов");
                    }
                    else if (login.Length > 0 && login.Length - 1 < 11)
                    {

                        return ("Ошибка", "Номер должен состоять из 11 цифр. Количество цифр меньше 11");
                    }

                    else if (login.Length - 1 > 11)
                    {

                        return ("Ошибка", "Номер должен состоять из 11 цифр. Количество цифр больше 11");
                    }


                }
                else if (login.Contains("@"))
                {
                    if (!login.Contains("."))
                    {

                        return ("Ошибка", "Отсутствует .");

                    }
                    else if (login.Last() == '.')
                    {

                        return ("Ошибка", "Отсутствует домен");
                    }
                    else if (login.IndexOf('.') < login.IndexOf('@'))
                    {

                        return ("Ошибка", "Неверная последовательность символов почты");
                    }

                    else if (login.Any(c => char.IsWhiteSpace(c)))
                    {

                        return ("Ошибка", "Логин не должен содержать пробелов");
                    }
                    else if (login.Any(x => char.IsLetter(x) && x >= 1072 && x <= 1103))
                    {

                        return ("Ошибка", "Логин должен содержать только латиницу");
                    }

                    else if (login.Any(c => char.IsSymbol(c)))
                    {

                        return ("Ошибка", "Логин не должен содержать символов");
                    }
                    else if (login.Any(c => char.IsPunctuation(c) && c != '.' && c != '@'))
                    {

                        return ("Ошибка", "Логин не должен содержать знаки препинания");
                    }

                }
                else if (!login.Contains('@') && !login.Contains('+'))
                {
                    if (login.Length < 5 && login.Length != 0)
                    {

                        return ("Ошибка", "Длина логина должна быть минимум 5 символов");
                    }

                    else if (login.Any(x => char.IsLetter(x) && (x >= 1072 && x <= 1103) || (x >= 1040 && x <= 1071)))
                    {

                        return ("Ошибка", "Логин должен содержать только латиницу");
                    }

                    else if (login.Any(c => char.IsSymbol(c)))
                    {

                        return ("Ошибка", "Логин не должен содержать символов");

                    }
                    else if (login.Any(c => char.IsPunctuation(c) && c != '_'))
                    {

                        return ("Ошибка", "Логин не должен содержать знаки препинания");
                    }
                    else if (login.Any(c => char.IsWhiteSpace(c)))
                    {

                        return ("Ошибка", "Логин не должен содержать пробелов");
                    }

                }

                if (password.Length == 0)
                {

                    return ("Ошибка", "Задан пустой пароль");
                }
                else
                {
                    if (password.Length > 0 && password.Length < 7)
                    {

                        return ("Ошибка", "Пароль меньше 7-ми символов");
                    }
                    else if (password.Any(x => char.IsLetter(x) && (x >= 97 && x <= 122) || (x >= 65 && x <= 90)))
                    {

                        return ("Ошибка", "Пароль должен содержать только кириллицу");
                    }
                    else if (!password.Any(c => char.IsDigit(c)))
                    {

                        return ("Ошибка", "Пароль должен содержать хотя бы одну цифру");
                    }
                    else if (!password.Any(c => char.IsSymbol(c)))
                    {

                        return ("Ошибка", "Пароль должен содержать хотя бы один спецсимвол");
                    }
                    else if (!password.Any(x => char.IsLetter(x) && x >= 1072 && x <= 1103))
                    {

                        return ("Ошибка", "Пароль должен содержать хотя бы одну букву в нижнем регистре");
                    }
                    else if (!password.Any(x => char.IsLetter(x) && x >= 1040 && x <= 1071))
                    {

                        return ("Ошибка", "Пароль должен содержать хотя бы одну букву в верхнем регистре");
                    }
                    else if (repeatPassword != password)
                    {

                        return ("Ошибка", "Пароли не совпадают");
                    }

                    else
                    {
                        return (" ", "Регистрация прошла успешно");
                    }
                }
            }
        }
    }
}
