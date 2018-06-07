using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flg = true;

            while (flg == true)
            {
                try
                {
                    Console.WriteLine("――――――Menu――――――\n");
                    Console.WriteLine("[1]：フィルター3表示");
                    Console.WriteLine("[2]：文字入力による3組の組み合わせ出力");
                    Console.WriteLine("[3]：全通りの文字入力による3組の組み合わせ出力");
                    Console.WriteLine("[4]：フィルター4表示");
                    Console.WriteLine("[5]：文字入力による4組の組み合わせ出力");
                    Console.WriteLine("[6]：全通りの文字入力による4組の組み合わせ出力\n");
                    Console.WriteLine("[0]：終了");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("実行したい数字を入力してください。\n");
                    string menu = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (menu == "1" || menu == "１")
                    {
                        text(3);
                    }
                    else if (menu == "2" || menu == "２")
                    {
                        io3(3);
                    }
                    else if (menu == "3" || menu == "３")
                    {
                        all3(3);
                    }
                    else if (menu == "4" || menu == "４")
                    {
                        text(4);
                    }
                    else if (menu == "5" || menu == "５")
                    {
                        io4(4);
                    }
                    else if (menu == "6" || menu == "６")
                    {
                        all4(4);
                    }
                    else if (menu == "0" || menu == "０")
                    {
                        Console.WriteLine("終了します。");
                        flg = false;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }

        static void text(int num)
        {
            //テキストからデータを読み込む
            string[] log = new string[100];
            string pass = @"./../../";
            string file_name = "filter" + num + ".txt";
            string r;
            int i = 0;

            StreamReader readtext = new StreamReader(pass + file_name, Encoding.GetEncoding("UTF-8"));
            while ((r = readtext.ReadLine()) != null)
            {
                log[i] = r;
                Console.WriteLine(log[i]);    //テキストの中身を表示
                i++;
            }
            Console.WriteLine("フィルターの合計　" + i + "個");
        }

        static void io3(int num)
        {
            //テキストからデータを読み込む
            string[] log = new string[100];
            string pass = @"./../../";
            string file_name = "filter" + num + ".txt";
            string r;
            int i = 0;
            int sum = 0;

            StreamReader readtext = new StreamReader(pass + file_name, Encoding.GetEncoding("UTF-8"));
            while ((r = readtext.ReadLine()) != null)
            {
                log[i] = r;
                //Console.WriteLine(log[i]);    //テキストの中身を表示
                i++;
            }

            Console.WriteLine("文字を３回入力してください。(一度に複数入力する場合は、スペースで区切る)");

            //string版
            string[] a = new string[100];
            string[] b = new string[100];
            string[] c = new string[100];
            string tmp;

            a = Console.ReadLine().Split(' ', '　'); //あい うえ お => a[0]=あい、a[1]=うえ、a[2]=お
            b = Console.ReadLine().Split(' ', '　');
            c = Console.ReadLine().Split(' ', '　');

            Console.WriteLine("");

            for (int ai = 0; ai < a.Length; ai++)
            {
                for (int bi = 0; bi < b.Length; bi++)
                {
                    for (int ci = 0; ci < c.Length; ci++)
                    {
                        for (int x = 0; x < log.Length; x++)   //フィルタと一致する物は排除する
                        {
                            tmp = a[ai] + b[bi] + c[ci];
                            //Console.WriteLine(text[x]);

                            if (log[x] == tmp)
                            {
                                break;
                            }
                            else
                            {
                                if (x + 1 == log.Length)
                                {
                                    Console.WriteLine(tmp);
                                    sum++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("合計　" + sum + "パターン");
        }

        static void io4(int num)
        {
            //テキストからデータを読み込む
            string[] log = new string[100];
            string pass = @"./../../";
            string file_name = "filter" + num + ".txt";
            string r;
            int i = 0;
            int sum = 0;

            StreamReader readtext = new StreamReader(pass + file_name, Encoding.GetEncoding("UTF-8"));
            while ((r = readtext.ReadLine()) != null)
            {
                log[i] = r;
                //Console.WriteLine(log[i]);    //テキストの中身を表示
                i++;
            }

            Console.WriteLine("文字を４回入力してください。(一度に複数入力する場合は、スペースで区切る)");

            string[] a = new string[100];
            string[] b = new string[100];
            string[] c = new string[100];
            string[] d = new string[100];
            string tmp;

            a = Console.ReadLine().Split(' ','　'); //あい@うえ@お=>a[0]=あい、a[1]=うえ、a[2]=お
            b = Console.ReadLine().Split(' ','　');
            c = Console.ReadLine().Split(' ','　');
            d = Console.ReadLine().Split(' ','　');

            Console.WriteLine("");

            for (int ai = 0; ai < a.Length; ai++)
            {
                for (int bi = 0; bi < b.Length; bi++)
                {
                    for (int ci = 0; ci < c.Length; ci++)
                    {
                        for (int di = 0; di < d.Length; di++)
                        {
                            for (int x = 0; x < log.Length; x++)   //フィルタと一致する物は排除する
                            {
                                tmp = a[ai] + b[bi] + c[ci] + d[di];
                                //Console.WriteLine(text[x]);

                                if (log[x] == tmp)
                                {
                                    break;
                                }
                                else
                                {
                                    if (x + 1 == log.Length)
                                    {
                                        Console.WriteLine(tmp);
                                        sum++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("合計　" + sum + "パターン");
        }

        static void all3(int num)
        {
            //テキストからデータを読み込む
            string[] log = new string[100];
            string pass = @"./../../";
            string file_name = "filter" + num + ".txt";
            string r;
            int i = 0;
            int sum = 0;

            StreamReader readtext = new StreamReader(pass + file_name, Encoding.GetEncoding("UTF-8"));
            while ((r = readtext.ReadLine()) != null)
            {
                log[i] = r;
                //Console.WriteLine(log[i]);    //テキストの中身を表示
                i++;
            }

            Console.WriteLine("文字を３回入力してください。(一度に複数入力する場合は、スペースで区切る)");

            string[] a = new string[100];
            string[] b = new string[100];
            string[] c = new string[100];

            a = Console.ReadLine().Split(' ', '　'); //あい うえ お => a[0]=あい、a[1]=うえ、a[2]=お
            b = Console.ReadLine().Split(' ', '　');
            c = Console.ReadLine().Split(' ', '　');

            Console.WriteLine("");

            for (int ai = 0; ai < a.Length; ai++)
            {
                for (int bi = 0; bi < b.Length; bi++)
                {
                    for (int ci = 0; ci < c.Length; ci++)
                    {
                        //for (int x = 0; x < log.Length; x++)   //フィルタと一致する物は排除する
                        //{
                            //Console.WriteLine(text[x]);

                            //if (log[x] == tmp)
                            //{
                            //    break;
                            //}
                            //else
                            //{
                            //    if (x + 1 == log.Length)
                            //    {
                                    Console.WriteLine(a[ai] + b[bi] + c[ci]);
                                    Console.WriteLine(a[ai] + c[ci] + b[bi]);
                                    Console.WriteLine(b[bi] + a[ai] + c[ci]);
                                    Console.WriteLine(b[bi] + c[ci] + a[ai]);
                                    Console.WriteLine(c[ci] + a[ai] + b[bi]);
                                    Console.WriteLine(c[ci] + b[bi] + a[ai]);
                                    sum += 6;
                            //    }
                            //}
                        //}


                    }
                }
            }
            Console.WriteLine("合計　" + sum + "パターン");
        }

        static void all4(int num)
        {
            //テキストからデータを読み込む
            string[] log = new string[100];
            string pass = @"./../../";
            string file_name = "filter" + num + ".txt";
            string r;
            int i = 0;
            int sum = 0;

            StreamReader readtext = new StreamReader(pass + file_name, Encoding.GetEncoding("UTF-8"));
            while ((r = readtext.ReadLine()) != null)
            {
                log[i] = r;
                //Console.WriteLine(log[i]);    //テキストの中身を表示
                i++;
            }

            Console.WriteLine("文字を４回入力してください。(一度に複数入力する場合は、スペースで区切る)");

            string[] a = new string[100];
            string[] b = new string[100];
            string[] c = new string[100];
            string[] d = new string[100];

            a = Console.ReadLine().Split(' ', '　'); //あい@うえ@お=>a[0]=あい、a[1]=うえ、a[2]=お
            b = Console.ReadLine().Split(' ', '　');
            c = Console.ReadLine().Split(' ', '　');
            d = Console.ReadLine().Split(' ', '　');

            Console.WriteLine("");

            for (int ai = 0; ai < a.Length; ai++)
            {
                for (int bi = 0; bi < b.Length; bi++)
                {
                    for (int ci = 0; ci < c.Length; ci++)
                    {
                        for (int di = 0; di < d.Length; di++)
                        {
                            Console.WriteLine(a[ai] + b[bi] + c[ci] + d[di]);
                            Console.WriteLine(a[ai] + b[bi] + d[di] + c[ci]);
                            Console.WriteLine(a[ai] + c[ci] + b[bi] + d[di]);
                            Console.WriteLine(a[ai] + c[ci] + d[di] + b[bi]);
                            Console.WriteLine(a[ai] + d[di] + b[bi] + c[ci]);
                            Console.WriteLine(a[ai] + d[di] + c[ci] + b[bi]);

                            Console.WriteLine(b[bi] + a[ai] + c[ci] + d[di]);
                            Console.WriteLine(b[bi] + a[ai] + d[di] + c[ci]);
                            Console.WriteLine(b[bi] + c[ci] + a[ai] + d[di]);
                            Console.WriteLine(b[bi] + c[ci] + d[di] + a[ai]);
                            Console.WriteLine(b[bi] + d[di] + a[ai] + c[ci]);
                            Console.WriteLine(b[bi] + d[di] + c[ci] + a[ai]);

                            Console.WriteLine(c[ci] + a[ai] + b[bi] + d[di]);
                            Console.WriteLine(c[ci] + a[ai] + d[di] + b[bi]);
                            Console.WriteLine(c[ci] + b[bi] + a[ai] + d[di]);
                            Console.WriteLine(c[ci] + b[bi] + d[di] + a[ai]);
                            Console.WriteLine(c[ci] + d[di] + a[ai] + b[bi]);
                            Console.WriteLine(c[ci] + d[di] + b[bi] + a[ai]);

                            Console.WriteLine(d[di] + a[ai] + b[bi] + c[ci]);
                            Console.WriteLine(d[di] + a[ai] + c[ci] + b[bi]);
                            Console.WriteLine(d[di] + b[bi] + a[ai] + c[ci]);
                            Console.WriteLine(d[di] + b[bi] + c[ci] + a[ai]);
                            Console.WriteLine(d[di] + c[ci] + a[ai] + b[bi]);
                            Console.WriteLine(d[di] + c[ci] + b[bi] + a[ai]);
                            sum += 24;
                        }
                    }
                }
            }
            Console.WriteLine("合計　" + sum + "パターン");
        }
    }
}