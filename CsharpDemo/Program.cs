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
            //宣告整數陣列
            int[] scores = { 70, 89, 72, 93 };

            //宣告總和
            int sum = 0;

            //使用for迴圈，條件為陣列的長度
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
                sum += scores[i];
            }

            //將總和的分數除以陣列長度(總共幾門科)
            float average = sum / (scores.Length);
            Console.WriteLine("總分" + sum);
            Console.WriteLine("平均值" + average);

            Console.ReadKey();
        }
    }
    class Day12
    {
        /// <summary>
        /// Day12-01
        /// 整數陣列
        /// </summary>
        void Day12_01()
        {

            //宣告整數陣列
            int[] scores = { 70, 89, 72, 93 };

            //計算總合
            int sum = scores[0] + scores[1] + scores[2] + scores[3];

            Console.WriteLine("總合 : " + sum);

            //計算平均值
            Console.WriteLine("平均值 : " + (sum / 4));
            Console.ReadKey();
        }
        /// <summary>
        /// Day12-02
        /// 整數陣列-for迴圈
        /// </summary>
        void Day12_02()
        {
            int[] scores = { 120, 149, 112, 133 };
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
                sum += scores[i];
            }
            float average = sum / (scores.Length);
            Console.WriteLine("總分" + sum);
            Console.WriteLine("平均值" + average);

            Console.ReadKey();
        }
    }
    class Day11
    {
        /// <summary>
        /// Day11-01
        /// 宣告星期的列舉
        /// </summary>
        enum WeekDays { 星期一, 星期二, 星期三, 星期四, 星期五, 星期六, 星期天 }
        /// <summary>
        /// Day11-01
        /// 列舉定義星期
        /// </summary>
        void Day11_01()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            //將讀到的數字轉為星期
            WeekDays today = (WeekDays)a;

            //判斷今天是否為假日
            if ((today == WeekDays.星期天 || today == WeekDays.星期六))
            {
                Console.WriteLine("放!假!啦!!!!");
            }
            else
            {
                Console.WriteLine("無情上班日!");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// short型別的列舉
        /// </summary>
        enum WeekDays_02 : short
        {
            星期一,

            星期二,
            星期三,
            星期四,
            星期五,
            星期六,
            星期日
        }
        /// <summary>
        /// 學生，結構體
        /// </summary>
        struct Student
        {
            //學號
            public int number;
            //姓名
            public string name;
            //性別
            public string sex;
            //生日
            public string birthday;
        }
        /// <summary>
        /// Day11-02
        /// 結構體
        /// </summary>
        void Day11_02()
        {
            Student boy;//宣告變數boy
            boy.number = 5487;
            boy.name = "孤獨一隻雞";
            boy.sex = "公";
            boy.birthday = "1111.01.01";


            Student girl;//宣告變數girl
            girl.number = 9527;
            girl.name = "孤獨九十九隻雞";
            girl.sex = "母";
            girl.birthday = "9999.09.09";


            Console.WriteLine("學號:" + boy.number);
            Console.WriteLine("姓名:" + boy.name);
            Console.WriteLine("性別:" + boy.sex);
            Console.WriteLine("生日:" + boy.birthday);
            Console.WriteLine("");

            Console.WriteLine("學號:" + girl.number);
            Console.WriteLine("姓名:" + girl.name);
            Console.WriteLine("性別:" + girl.sex);
            Console.WriteLine("生日:" + girl.birthday);
            Console.ReadKey();
        }
    }
    class Day10
    {
        /// <summary>
        /// Day10-01
        /// 倒數10~1，數到1時就喊新年快樂
        /// </summary>
        void Day10_01()
        {
            //先宣告一個開關
            bool open = true;

            //宣告一個倒數用的整數變數
            int number = 10;

            //開始執行倒數
            while (open)
            {
                //如果數到1就把開關關掉，下次就不會執行
                if (number == 1)
                {
                    open = false;
                }

                //印出當前數字，印完後就減一
                Console.WriteLine(number--);
            }
            //都倒數完後就喊新年快樂
            Console.WriteLine("新年快樂!");

            Console.ReadKey();
        }
        /// <summary>
        /// Day10-02
        /// 倒數10~1，數到1時就喊新年快樂，break版
        /// </summary>
        void Day10_02()
        {
            //先宣告一個開關
            bool open = true;

            //宣告一個倒數用的整數變數
            int number = 10;

            //開始執行倒數
            while (open)
            {

                //印出當前數字
                Console.WriteLine(number);

                //如果數到1就break，放後面的原因是berak後就不會執行了
                if (number == 1)
                {
                    //執行到這邊就中斷
                    break;
                }
                //break後就不會執行了，所以遞減放到後面
                number--;
            }
            //都倒數完後就喊新年快樂
            Console.WriteLine("新年快樂!");

            //我們寫看看開關的值
            Console.WriteLine("開關 = " + open);

            Console.ReadKey();
        }
        /// <summary>
        /// Day10-03
        /// 印出1~10的偶數
        /// </summary>
        void Day10_03()
        {
            //宣告一個計數用的整數變數
            int number = 0;

            //開始執行計數
            while (number < 11)
            {
                //先做加一
                number++;
                //如果不是偶數，本次後面就不執行了
                if (number % 2 != 0)
                {
                    continue;
                }
                //印出當前數字，並加一
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }

    }
    class Day9
    {
        /// <summary>
        /// Day9-01
        /// 1+到100 for迴圈
        /// </summary>
        void Day9_01()
        {
            //宣告一個整數，來讓他自增
            int sum = 0;

            //開始使用for迴圈
            for (int i = 1; i <= 100; i++)
            {
                sum += i;//使用指派運算子
            }

            //看結果
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        /// <summary>
        /// Day9-02
        /// n!
        /// </summary>
        void Day9_02()
        {
            //讀取用戶輸入的數字
            int n = Convert.ToInt32(Console.ReadLine());

            //宣告一個長整數變數
            long a = 1;
            for (int i = 1; i <= n; i++)
            {
                //做乘法的累計
                a *= i;
            }
            Console.WriteLine(n + "! = " + a);
            Console.ReadKey();
        }
    }
    class Day8
    {
        /// <summary>
        /// Day8-01
        /// switch 猴子繞口令
        /// </summary>
        void Day8_01()
        {
            //禮拜幾
            string week = Console.ReadLine();

            //使用switch
            switch (week)
            {
                case "星期一":
                    Console.WriteLine("猴子穿新衣");
                    break;
                case "星期二":
                    Console.WriteLine("猴子肚子餓");
                    break;
                case "星期三":
                    Console.WriteLine("猴子去爬山");
                    break;
                case "星期四":
                    Console.WriteLine("猴子去考試");
                    break;
                case "星期五":
                    Console.WriteLine("猴子去跳舞");
                    break;
                case "星期六":
                    Console.WriteLine("猴子去斗六");
                    break;
                case "星期日":
                    Console.WriteLine("猴子過生日");
                    break;
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Day8-02
        /// switch 基姆拉爾森計算公式
        /// </summary>
        void Day8_02()
        {
            Console.WriteLine("請輸入年月日");
            int y = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int total = 365; //平年
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                total = 366;
            switch (m)
            {
                case 1:
                    total -= 31;
                    goto case 2;
                case 2:
                    if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0) //閏年
                    {
                        total -= 29;
                    }
                    else
                    {
                        total -= 28;
                    }
                    goto case 3;
                case 3:
                    total -= 31;
                    goto case 4;
                case 4:
                    total -= 30;
                    goto case 5;
                case 5:
                    total -= 31;
                    goto case 6;
                case 6:
                    total -= 30;
                    goto case 7;
                case 7:
                    total -= 31;
                    goto case 8;
                case 8:
                    total -= 31;
                    goto case 9;
                case 9:
                    total -= 30;
                    goto case 10;
                case 10:
                    total -= 31;
                    goto case 11;
                case 11:
                    total -= 30;
                    goto case 12;
                case 12:
                    total -= 31;
                    goto default;
                default: total += d; break;
            }
            Console.WriteLine(m + "月" + d + "日是" + y + "年的第" + total + "天");
            Console.ReadKey();
        }

    }
    class Day7
    {
        /// <summary>
        /// Day7-01
        /// if陳述式
        /// </summary>
        void Day7_01()
        {
            //宣告天氣
            string weather = "下雨";
            Console.WriteLine("今天天氣 : " + weather);

            //使用if陳述句來做判斷
            if (weather == "下雨")
            {
                Console.WriteLine("待在家");
            }
            else
            {
                Console.WriteLine("出去玩");
            }

            //把天氣改成晴天，再做一次判斷試試看
            weather = "晴天";
            Console.WriteLine("今天天氣 : " + weather);

            //使用if陳述句來做判斷
            if (weather == "下雨")
            {
                Console.WriteLine("待在家");
            }
            else
            {
                Console.WriteLine("出去玩");
            }

            Console.ReadKey();
        }
        /// <summary>
        /// Day7-02
        /// if陳述式-判斷數字的大小
        /// </summary>
        void Day7_02()
        {
            Console.WriteLine("請輸入年齡");
            //宣告年齡，並將輸入的值賦予給他
            int age = Convert.ToInt32(Console.ReadLine());

            //判斷年齡
            if (age < 18)
            {
                Console.WriteLine(age + " 歲是未成年，不可進入!");
            }
            else
            {
                Console.WriteLine(age + " 歲已成年，歡迎光臨!");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Day7-03
        /// else if
        /// </summary>
        void Day7_03()
        {
            Console.WriteLine("請輸入年齡");
            Console.WriteLine("請輸入年齡");
            //宣告年齡，並將輸入的值賦予給他
            int age = Convert.ToInt32(Console.ReadLine());

            //判斷年齡
            if (age < 18)
            {
                Console.WriteLine(age + " 歲是未成年，任何駕照都不能考!");
            }
            else if (age < 20)
            {
                Console.WriteLine(age + " 歲，可以考機車駕照，但不能考重機駕照!");
            }
            else
            {
                Console.WriteLine(age + " 歲，任何駕照都可以考!");
            }

            Console.ReadKey();
        }
        /// <summary>
        /// Day7-04
        /// 巢狀 if
        /// </summary>
        void Day7_04()
        {
            Console.WriteLine("今天星期幾?");
            string today = Console.ReadLine();
            //天氣
            Console.WriteLine("今天天氣?");
            string weather = Console.ReadLine();

            //先判斷今天日是不是假日
            if (today == "星期六" || today == "星期日")
            {
                if (weather == "晴天")
                {
                    Console.WriteLine("今天" + today + "，" + weather + ",來去海邊玩");
                }
                else
                {
                    Console.WriteLine("今天" + today + "，" + weather + ",來去爬山");
                }
            }
            else
            {
                Console.WriteLine("今天" + today + "，所以要上課");
            }

            Console.ReadKey();
        }
    }
    class Day6
    {
        /// <summary>
        /// Day6-01
        /// 邏輯表達式
        /// </summary>
        void Day6_01()
        {
            //直接印出結果
            Console.WriteLine(1 < 2);
            Console.WriteLine(3 > 2);
            Console.WriteLine(4 == 5);
            Console.WriteLine((6 / 2) != 3);

            Console.ReadKey();
        }
        /// <summary>
        /// Day6-02
        /// x是大於10的偶數
        /// </summary>
        void Day6_02()
        {
            //直接印出結果
            Console.WriteLine(1 < 2);
            Console.WriteLine(3 > 2);
            Console.WriteLine(4 == 5);
            Console.WriteLine((6 / 2) != 3);

            Console.ReadKey();
        }
        /// <summary>
        /// Day6-03
        /// x 是負數或是 x 是3的倍數
        /// </summary>
        void Day6_03()
        {
            //宣告x為12
            int x = 12;

            //x是正數，但x是三的倍數
            Console.Write("x = " + x + " , ");
            Console.WriteLine((x < 10) || (x % 3 == 0));

            //x是負數，但x不是三的倍數
            x = -10;
            Console.Write("x = " + x + " , ");
            Console.WriteLine((x < 10) || (x % 3 == 0));

            //x是正數，也x不是三的倍數
            x = 10;
            Console.Write("x = " + x + " , ");
            Console.WriteLine((x < 10) || (x % 3 == 0));

            Console.ReadKey();
        }
        /// <summary>
        /// Day6-04
        /// 布林變數
        /// </summary>
        void Day6_04()
        {
            //宣告一個布林變數
            bool isEven;

            Console.WriteLine("來輸入一個整數吧!");
            int x = Convert.ToInt32(Console.ReadLine());

            //判斷是不是偶數
            isEven = (x % 2) == 0;

            //列印結果
            Console.Write("請問神奇一隻雞，" + x + "是偶數嗎 ? ");
            Console.WriteLine(isEven);

            Console.ReadKey();
        }
    }
    class Day5
    {
        /// <summary>
        /// Day5-01
        /// 基姆拉爾森計算公式
        /// </summary>
        void Day5_01()
        {
            //宣告今年
            int y = 2021;
            //宣告今月
            int m = 9;
            //宣告今日
            int d = 6;

            //套用基姆拉爾森計算公式
            int week = (d + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400 + 1) % 7;

            //印出日期與星期
            Console.WriteLine("2021/9/6 星期" + week);
            Console.ReadKey();

        }
        /// <summary>
        /// Day5-02
        /// 3除以2
        /// </summary>
        void Day5_02()
        {
            //做三除以二的運算
            int ans = 3 / 2;

            //印出解答
            Console.WriteLine("Ans : " + ans);
            Console.ReadKey();

        }
        /// <summary>
        /// Day5-03
        /// 整數除法與浮點數除法
        /// </summary>
        void Day5_03()
        {
            //做整數除法，並賦值給浮點數變數
            double x = 9 / 2;

            //直接做浮點數除法
            double y = 9.0 / 2;

            //印出答案
            Console.WriteLine("x = " + x + " ，y = " + y);
            Console.ReadKey();

        }
        /// <summary>
        /// Day5-04
        /// 取餘運算子
        /// </summary>
        void Day5_04()
        {
            //分別將20~25與4做取餘運算
            int no20 = 20 % 4;
            int no21 = 21 % 4;
            int no22 = 22 % 4;
            int no23 = 23 % 4;
            int no24 = 24 % 4;
            int no25 = 25 % 4;

            //印結果
            Console.WriteLine("20 % 4 =" + no20);
            Console.WriteLine("21 % 4 =" + no21);
            Console.WriteLine("22 % 4 =" + no22);
            Console.WriteLine("23 % 4 =" + no23);
            Console.WriteLine("24 % 4 =" + no24);
            Console.WriteLine("25 % 4 =" + no25);

            Console.ReadKey();
        }
        /// <summary>
        /// Day5-05
        /// 梯形面積
        /// </summary>
        void Day5_05()
        {
            //宣告上底
            int x = 30;
            //宣告下底
            int y = 52;
            //宣告高
            int z = 46;

            //進行計算
            int ans = (x + y) * z / 2;

            //印出答案 
            Console.WriteLine("Ans : " + ans);

            Console.ReadKey();
        }
        /// <summary>
        /// Day5-06
        /// 後置遞增運算子
        /// </summary>
        void Day5_06()
        {
            //宣告我今年48歲
            int age = 48;
            Console.WriteLine("我今年" + age + "歲");

            //使用後置遞增運算子，計算明年年紀
            age++;
            Console.WriteLine("我明年" + age + "歲");
            Console.ReadKey();
        }
        /// <summary>
        /// Day5-07
        /// 比較前置，後置遞增運算子
        /// </summary>
        void Day5_07()
        {
            //後置遞增運算子，印出它的變化過程
            Console.WriteLine("--後置運算子--");
            int x = 1;
            Console.WriteLine(x);
            Console.WriteLine(x++);
            Console.WriteLine(x);

            //前置遞增運算子，印出它的變化過程
            Console.WriteLine("--前置運算子--");
            int y = 1;
            Console.WriteLine(y);
            Console.WriteLine(++y);
            Console.WriteLine(y);
            Console.ReadKey();
        }
        /// <summary>
        /// Day5-08
        /// 比較前置，後置遞減運算子
        /// </summary>
        void Day5_08()
        {
            //後置遞增運算子，印出它的變化過程
            //遞減運算子
            int x = 5;
            //後置
            Console.WriteLine(x--);
            //前置
            Console.WriteLine(--x);
            Console.ReadKey();
        }
        /// <summary>
        /// Day5-09
        /// 加法指派運算子 += 
        /// </summary>
        void Day5_09()
        {
            //加法指派運算子 += (整數版)
            Console.WriteLine("--整數版--");
            int x = 10;
            x += 100;
            Console.WriteLine(x);

            //加法指派運算子 += (字串版)
            Console.WriteLine("--字串版--");
            string name = "孤獨一隻雞";
            name += " 史上最帥!";
            Console.WriteLine(name);

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
}
