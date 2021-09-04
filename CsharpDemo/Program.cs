﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
          
        }

    }
    class Day2
    {
        /// <summary>
        /// Day2-01
        /// 列印
        /// </summary>
        void Day2_01()
        {
            //印出文字
            Console.WriteLine("姓名 : 孤獨一隻雞");
            Console.WriteLine("年齡 : 48歲");
            Console.WriteLine("血型 : O型");
            Console.WriteLine("星座 : 金牛座");
            Console.WriteLine("自我介紹 : 我像是一隻你可有可無的小雞");
            Console.ReadKey();
        }
    }
    class Day3
    {
        /// <summary>
        /// Day3-01
        /// 整數運算
        /// </summary>
        void Day3_01()
        {
            //首先要來一個型態為整數的蘿蔔變數
            int radish;
            //再來個型態為整數的豬肉變數
            int pork;
            //此時阿嬤問攤主蘿蔔多少錢，攤主告訴阿嬤50元
            //我們就可以讓蘿蔔變成50元
            radish = 50;
            //這時阿嬤又問攤主豬肉多少錢，攤主告訴阿嬤70元
            //我們就可以就來讓豬肉變成70元
            pork = 70;
            //阿嬤為了計算方便就先把價錢寫下來了
            Console.WriteLine("蘿蔔 " + radish + "元 ，豬肉 " + pork + "元");
            //這時候店家拿出計算機按給阿嬤看
            int computer = radish + pork;
            //阿嬤看按計算機上面寫的價錢，就從錢包拿出錢給攤販開心回家了
            Console.WriteLine("計算機畫面 => " + radish + " + " + pork + " = " + computer);
            Console.ReadKey();
        }
        /// <summary>
        /// Day3-02
        /// 浮點數
        /// </summary>
        void Day3_02()
        {
            //使用float型別來宣告變數
            //記得數字最後要加上後置詞f
            float pi_f = 3.1415926535879f;

            //使用double來宣告變數
            double pi_d = 3.1415926535879;

            Console.WriteLine("pi_f = " + pi_f);
            Console.WriteLine("pi_d = " + pi_d);
            Console.ReadKey();
        }
    }
    class Day4
    {
        /// <summary>
        /// Day4-01 
        /// 字串
        /// </summary>
        void Day4_01()
        {
            //宣告一個整數叫做 hi，然後賦予他100的值
            int hi = 100;

            //我們來列印看看
            Console.WriteLine("我沒有加雙引號 : " + hi);
            Console.WriteLine("我有加雙引號 : " + "hi");
            Console.ReadKey();
        }
        /// <summary>
        /// Day4-02 
        /// char
        /// </summary>
        void Day4_02()
        {
            //宣告一個char型別的變數
            char hi;

            //先賦值A給變數hi，然後印出來
            hi = 'A';
            Console.WriteLine("1. " + hi);

            //再來賦值B給變數hi，然後印出來
            hi = 'B';
            Console.WriteLine("2. " + hi);

            //最後賦值C給變數hi，然後印出來
            hi = 'C';
            Console.WriteLine("3. " + hi);

            Console.ReadKey();
        }
        /// <summary>
        /// Day4-03 
        /// string
        /// </summary>
        void Day4_03()
        {
            //宣告一個string型別的變數
            string hi;

            //讓電腦來個問候
            hi = "安安，你好，幾歲?住哪裡?";
            Console.WriteLine(hi);

            //讓電腦回答自己
            hi = "你好，你是個好人，但我才不要告訴你勒";
            Console.WriteLine(hi);

            Console.ReadKey();
        }
        /// <summary>
        /// Day4-04 
        /// 字串讀取
        /// </summary>
        void Day4_04()
        {
            //我們一開始使用Console.ReadLine()函式，讓電腦聽聽我們的心聲
            //並將輸入的名字賦值到字串變數中
            string name = Console.ReadLine();

            //接下來讓電腦回答我們
            Console.WriteLine(name + "，帥氣十足!");

            Console.ReadKey();
        }
        /// <summary>
        /// Day4-05 
        /// 字元讀取
        /// </summary>
        void Day4_05()
        {
            //我們使用Console.Read()函式，讓電腦讀取我們輸入的字母
            //電腦會自動將他轉成ASCII編碼
            //並將ASCII編碼賦值到變數中
            int ch = Console.Read();

            //印出輸入字母的 ASCII
            Console.WriteLine("The ASCII code is " + ch);
            Console.ReadKey();
        }
        /// <summary>
        /// Day4-06 
        /// 圓面積
        /// </summary>
        void Day4_06()
        {

            //宣告半徑為整數變數
            int r;
            //宣告圓面積為浮點數變數
            double s;
            //宣告圓周率為浮點數變數
            double π = 3.1415926536;

            //我們輸入一個半徑，並將輸入的半徑轉成整數，賦值給變數r
            Console.Write("r = ");
            r = Convert.ToInt32(Console.ReadLine());

            //計算面積 面積 = 圓周率 X 半徑 X 半徑
            s = π * r * r;
            //印出答案
            Console.WriteLine("Ans:" + s);

            Console.ReadKey();
        }
        /// <summary>
        /// Day4-07 
        /// 字串的累加
        /// </summary>
        void Day4_07()
        {
            //宣告雞
            string chicken = "雞";
            //宣告魚
            string fish = "魚";
            //宣告狗
            string dog = "象";
            //宣告形容詞
            string lonely = "孤獨一隻";

            //將他們做累加
            Console.WriteLine(lonely + chicken);
            Console.WriteLine(lonely + fish);
            Console.WriteLine(lonely + dog);

            Console.ReadKey();
        }
    }
}
