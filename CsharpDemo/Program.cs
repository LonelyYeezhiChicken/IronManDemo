using System;
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
}
