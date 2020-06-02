using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeClassCsharp_test1;

namespace TimeClassTests
{
    [TestClass]
    public class TimeClassTests_SomeInterestingTests
    {
        [TestMethod] //Конструктор по умолчанию
        public void Constructor_Default()
        {
            MyTime exp = new MyTime(0, 0, 0, 0);
            MyTime act = new MyTime();
            Assert.AreEqual(exp, act);
        }

        [TestMethod] //Конструктор с параметрами и свойства
        public void ConstructorParam_Properties()
        {
            MyTime exp = new MyTime(1, 2, 3, 4);
            MyTime act = new MyTime();
            act.Days = 1; act.Hours = 2; act.Minutes = 3; act.Seconds = 4;
            Assert.AreEqual(exp, act);
        }


        [TestMethod] // вызывается ли исключение, при попытке задать отрицательные значения
        public void Constructor_NegativeException()
        {
            try // попытка вызвать исключение
            {
                MyTime t = new MyTime(0, 0, -1, 0); // исключение должно вызваться здесь и дальше код не пойдёт
                Assert.Fail(); // если исключение не вызвалось, то тест провален
            }
            catch (MyTimeException) //если вызвалось, то тест пройден
            {

            }
        }


        [TestMethod] //Конвертация в строку
        public void ToString_test()
        {
            MyTime exp = new MyTime(4, 3, 2, 1);
            string act = "4d 3:2:1";

            Assert.AreEqual(exp.ToString(), act);
        }

        [TestMethod] //Нормализация (247 часов, 324 минуты, 5654 секунды переведёт в 10 дней 13:58:14)
        public void convertToDays()
        {
            MyTime exp = new MyTime(0, 247, 324, 5654);
            MyTime act = new MyTime(10,13,58,14);

            Assert.AreEqual(exp.ConvertTo_Ds(), act);
        }

        [TestMethod] //Сумма 1 day 23:59:59 + 6 sec = 2 day 00:00:05
        public void Sum_test()
        {
            MyTime s1 = new MyTime(1, 23, 59, 59);
            MyTime s2 = new MyTime(0, 0, 0, 6);
            MyTime s3 = s1 + s2;
            MyTime act = new MyTime(2, 0, 0, 5);

            Assert.AreEqual(s3.ConvertTo_Ds(), act);
        }

        [TestMethod] //Разница 1 day 02:03:04 + 4 day 03:02:01 = 3 day 00:58:57
        public void Sub_test()
        {
            MyTime s1 = new MyTime(1, 2, 3, 4);
            MyTime s2 = new MyTime(4, 3, 2, 1);
            MyTime s3 = s1 - s2;
            MyTime act = new MyTime(3, 0, 58, 57);

            Assert.AreEqual(s3.ConvertTo_Ds(), act);
        }

        [TestMethod] //Сравнивает 1 день и 100 000 секунд (100 000 секунд = 1d 03:46:40)
        public void A_less_B()
        {
            MyTime t1 = new MyTime(0, 1, 0, 0);
            MyTime t2 = new MyTime(0, 0, 0, 100000);

            bool act = (t1 < t2);
            bool exp = true;

            Assert.AreEqual(exp, act);
        }
    }
}
