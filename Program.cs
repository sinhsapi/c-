using System;
using System.Text;
using System.Linq;
using System.Collections;
namespace codecamp
{
    class Program
    {
        public static void Factorial()
        {
            try
            {
                Console.Write("n=");
                int n=Convert.ToInt32(Console.ReadLine());
                long gt=1;
                for(int i=1;i<=n;i++)
                {
                    gt=gt*i;
                }
                Console.WriteLine("giai thua cua so {0} la {1}",n,gt);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("bạn phải nhập là chu cai");
            }
            catch(System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);  
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("kết thúc chương trình");
            }
        }
        public static void CountDigits()
        {
            try
            {
                string input;
                Console.Write("input=");
                input=Console.ReadLine();
                int sum=0;
                for(int i=0;i<input.Length;i++)
                {
                    sum+=Convert.ToInt32(input[i].ToString());
                }
                Console.WriteLine("tong la {0}",sum);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("bạn phải nhập là số");
            }
            catch(System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);  
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("kết thúc chương trình");
            }
        }
        public static void Capitalise()
        {
            Console.Write("input=");
            string input=Console.ReadLine();
            if(input==""||input==null)
            {
                Console.WriteLine("chuoi rong");
            }
            string result="";
            string[] words=input.Split(' ');
            foreach(string word in words)
            {
                if(word.Length>1)
                {
                    result+=word.Substring(0,1).ToUpper()+word.Substring(1).ToLower()+" ";
                }
                else
                {
                    result+=word.Substring(0,1).ToUpper()+" ";
                }
            }
            Console.WriteLine(result);
        }
        public void SecondLargest()
        {
            try
            {
                int n;
                Console.Write("n=");
                n=int.Parse(Console.ReadLine());
                int[] arr=new int[n];
                for(int i=0;i<n;i++)
                {
                    Console.Write("arr[{0}]=",i);
                    arr[i]=int.Parse(Console.ReadLine());
                }
                for(int i=0;i<n;i++)
                {
                    for(int j=i+1;j<n;j++)
                    {
                        if(arr[i]<arr[j])
                        {
                            int temp=arr[i];
                            arr[i]=arr[j];
                            arr[j]=temp;
                        }
                    }
                 }
                Console.WriteLine("so lon thu 2 trong mang la {0}",arr[1]);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("bạn phải nhập là số");
            }
            catch(System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);  
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("kết thúc chương trình");
            }
        }
        public static void QuadraticFunc()
        {
            try
            {
                int a,b,c;
                Console.Write("a=");
                a=int.Parse(Console.ReadLine());
                Console.Write("b=");
                b=int.Parse(Console.ReadLine());
                Console.Write("c=");
                c=int.Parse(Console.ReadLine());
                if(a==0)
                {
                    Console.WriteLine("phuong trinh khoong phai phuong trinh bac 2");
                }
                else
                {
                    float delta=b*b-4*a*c;
                    if(delta<0)
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                    else if(delta==0)
                    {
                        Console.WriteLine("phuong trinh co nghiem duy nhat la {0}",-b/(2*a));
                    }
                    else
                    {
                        float x1=(float)(-b+Math.Sqrt(delta))/(2*a);
                        float x2=(float)(-b-Math.Sqrt(delta))/(2*a);
                        Console.WriteLine("phuong trinh co 2 nghiem pham biet la x1={0} va x2={1}",x1,x2);
                    }
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("bạn phải nhập là số");
            }
            catch(System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);  
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("kết thúc chương trình");
            }
        }
        static void Main(string[] args)
        {
            Program a=new Program();
           // Capitalise();
            //CountDigits();
            //Factorial();
            //a.SecondLargest();
            QuadraticFunc();
            Console.ReadKey();
        }
    }
}
