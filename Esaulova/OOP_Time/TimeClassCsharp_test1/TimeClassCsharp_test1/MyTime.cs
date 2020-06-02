using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClassCsharp_test1
{ 

    public class MyTime
    {
        private int Ds, Hs, Ms, Ss; //День, Час, Минута, Секунда


        public MyTime() //конструктор по умолчанию
        {
            Ds = 0;
            Hs = 0;
            Ms = 0;
            Ss = 0;
        }

        public MyTime(int _D, int _H, int _M, int _S) // с параметрами
        {
            if ((_D >= 0) && (_H >= 0) && (_M >= 0) && (_S >= 0))
            {
                Ds = _D;
                Hs = _H;
                Ms = _M;
                Ss = _S;
            }
            else
            {
                this.Reset();
                throw new MyTimeException("Попытка сделать отрицательное время");
            }                
        }

        public void Reset() // сбросить все данные в 0
        {
            this.Ds = 0;
            this.Hs = 0;
            this.Ms = 0;
            this.Ss = 0;
        }

        public MyTime ConvertTo_Ss() // конвертируем всё время в Секунды
        {
            MyTime xt = new MyTime(); // на всякий случай делаем отлельное время
            xt.Ds = Ds;
            xt.Hs = Hs;
            xt.Ms = Ms;
            xt.Ss = Ss;

            xt.Hs = (xt.Ds * 24) + xt.Hs; // переводим дни в часы
            xt.Ds = 0;                    // и обнуляем дни

            xt.Ms = (xt.Hs * 60) + xt.Ms; // переводим часы в минуты
            xt.Hs = 0;                    // и обнуляем часы

            xt.Ss = (xt.Ms * 60) + xt.Ss; // переводим минуты в секунды
            xt.Ms = 0;                    // и обнуляем минуты

            return xt;
        }

        public MyTime ConvertTo_Ms() // конвертируем всё время в Минуты ( и "остаток" пишем в секунды)
        {
            MyTime xt = new MyTime();
            xt.Ds = Ds;
            xt.Hs = Hs;
            xt.Ms = Ms;
            xt.Ss = Ss;
            xt = xt.ConvertTo_Ss(); // конвертируем всё время в Секунды

            xt.Ms = xt.Ss / 60;     // переводим секунды в минуты
            xt.Ss = 0 + Math.Abs(xt.Ms * 60 - xt.Ss); // В секунды пишем остаток

            return xt;
        }

        public MyTime ConvertTo_Hs() // конвертируем всё время в Часы (и раскидываем "остаток" на минуты и секунды)
        {
            MyTime xt = new MyTime();
            xt.Ds = Ds;
            xt.Hs = Hs;
            xt.Ms = Ms;
            xt.Ss = Ss;
            xt = xt.ConvertTo_Ss(); // конвертируем всё время в Секунды

            xt.Ms = xt.Ss / 60;     // получаем минуты
            xt.Ss = 0 + Math.Abs(xt.Ms * 60 - xt.Ss); // В секунды пишем остаток

            xt.Hs = xt.Ms / 60;     // получаем часы
            xt.Ms = 0 + Math.Abs(xt.Hs * 60 - xt.Ms); // В минуты пишем остаток

            return xt;
        }

        public MyTime ConvertTo_Ds() // конвертируем всё время в Дни (и раскидываем "остаток" на часы, минуты и секунды)
        {//Также этот метод полностью "нормализует" время
            MyTime xt = new MyTime();
            xt.Ds = Ds;
            xt.Hs = Hs;
            xt.Ms = Ms;
            xt.Ss = Ss;
            xt = xt.ConvertTo_Hs(); // конвертируем всё время в Часы (и раскидываем "остаток" на минуты и секунды)

            xt.Ds = xt.Hs / 24; // получаем колличество дней
            xt.Hs = 0 + Math.Abs(xt.Ds * 24 - xt.Hs); // В часы пишем остаток

            return xt;
        }

        //Добавление дней, часов, минут, секунд
        public void AddDs(int _D) 
        {                         
            this.Ds += _D;        
        }                         
        public void AddHs(int _H) 
        {                         
            this.Hs += _H;        
        }                         
        public void AddMs(int _M) 
        {                         
            this.Ms += _M;       
        }                         
        public void AddSs(int _S) 
        {                         
            this.Ss += _S;      
        }                         


        public int Days //Свойство для дней
        {
            get { return Ds; } //геттер
            set                //сеттер
            {
                if (Ds >= 0)
                    Ds = value;
                else
                    throw new MyTimeException("Попытка сделать отрицательное время");
            }
        }

        public int Hours //Свойство для часов
        {
            get { return Hs; }
            set
            {
                if (Hs >= 0)
                    Hs = value;
                else
                    throw new MyTimeException("Попытка сделать отрицательное время");
            }
        }

        public int Minutes //Свойство для минут
        {
            get { return Ms; }
            set
            {
                if (Ms >= 0)
                    Ms = value;
                else
                    throw new MyTimeException("Попытка сделать отрицательное время");
            }
        }

        public int Seconds //Свойство для секунд
        {
            get { return Ss; }
            set
            {
                if (Ss >= 0)
                    Ss = value;
                else
                    throw new MyTimeException("Попытка сделать отрицательное время");
            }
        }

        public static MyTime operator + (MyTime t1, MyTime t2) //Сложить два время
        {
            MyTime t3 = new MyTime
            {
                Ds = (t1.Ds + t2.Ds),
                Hs = (t1.Hs + t2.Hs),
                Ms = (t1.Ms + t2.Ms),
                Ss = (t1.Ss + t2.Ss)
            };

            return t3;
        }

        public static MyTime operator - (MyTime t1, MyTime t2) //Разница между двумя временами
        {
            MyTime xt1 = t1.ConvertTo_Ss(); //конвертируем 2 времени в секунды
            MyTime xt2 = t2.ConvertTo_Ss();
            MyTime xt3 = new MyTime();

            xt3.Ss = Math.Abs(xt1.Ss - xt2.Ss); //вычетаем секунды по модулю
            xt3.ConvertTo_Ds(); //конвертируем обратнов дни

            return xt3;
        }


        public static bool operator >(MyTime a, MyTime b)  // Если A > B, то True
        {
            MyTime TempA = new MyTime(), TempB = new MyTime(); // на всякий случай делаем отлельное время

            TempA.Days = a.Days; 
            TempA.Hours = a.Hours;
            TempA.Minutes = a.Minutes; 
            TempA.Seconds = a.Seconds;

            TempB.Days = b.Days;
            TempB.Hours = b.Hours; 
            TempB.Minutes = b.Minutes;
            TempB.Seconds = b.Seconds;

            //Чтобы сравнить MyTime(0d 0,60,0) и MyTime(0d 1,0,0) приведём оба времени "к общему знаменателю"
            //Переведём всё в секунды и сравним
            TempA = TempA.ConvertTo_Ss();
            TempB = TempB.ConvertTo_Ss();

            if ((TempA.Seconds) > (TempB.Seconds)) //Сравниваем секунды
            {
                return true; 
            }
            else
                return false; 
        }

        public static bool operator <(MyTime a, MyTime b) // Если A < B, то True
        {
            MyTime TempA = new MyTime(), TempB = new MyTime(); // на всякий случай делаем отлельное время

            TempA.Days = a.Days; TempA.Hours = a.Hours; TempA.Minutes = a.Minutes; TempA.Seconds = a.Seconds;
            TempB.Days = b.Days; TempB.Hours = b.Hours; TempB.Minutes = b.Minutes; TempB.Seconds = b.Seconds;

            //Чтобы сравнить MyTime(0d 0,60,0) и MyTime(0d 1,0,0) приведём оба времени "к общему знаменателю"
            //Переведём всё в секунды и сравним
            TempA = TempA.ConvertTo_Ss();
            TempB = TempB.ConvertTo_Ss();

            if ((TempA.Seconds) < (TempB.Seconds)) //Сравниваем секунды
            {
                return true;
            }
            else
                return false;
        }   


        public static bool operator == (MyTime a, MyTime b)  // Если времена равны, то True
        {
            MyTime TempA = new MyTime(), TempB = new MyTime(); // на всякий случай делаем отлельное время

            TempA.Days = a.Days; TempA.Hours = a.Hours; TempA.Minutes = a.Minutes; TempA.Seconds = a.Seconds;
            TempB.Days = b.Days; TempB.Hours = b.Hours; TempB.Minutes = b.Minutes; TempB.Seconds = b.Seconds;

            //Чтобы сравнить MyTime(0d 0,60,0) и MyTime(0d 1,0,0) приведём оба времени "к общему знаменателю"
            //Переведём всё в секунды и сравним
            TempA = TempA.ConvertTo_Ss();
            TempB = TempB.ConvertTo_Ss();

            if ((TempA.Seconds) == (TempB.Seconds)) //Сравниваем секунды
            {
                return true; //если времена не равны то это true. 
            }
            else
                return false; //если времена не равны то это false. 
        }

        public static bool operator !=(MyTime a, MyTime b)  // Если времена НЕравны, то True
        {
            //Так как у нас уже есть оператор ==, то просто сравним с помощью него два времени и FALSE
            if ((a==b) is false) //если дроби не равны то это false. 
            {
                return true; //если FALSE is FALSE то это TRUE - времена не равны
            }
            else
                return false; //иначе TRUE is FAlSE это FALSE - времена на самом деле равны
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            MyTime t = (MyTime)obj;
            return (Days == t.Days && Hours == t.Hours && Minutes == t.Minutes && Seconds == t.Seconds);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString() // конвертация в строку
        {
            return 
                  this.Ds.ToString() + "d " 
                + this.Hs.ToString() + ":" 
                + this.Ms.ToString() + ":" 
                + this.Ss.ToString();
        }
    }
}


