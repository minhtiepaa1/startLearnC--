// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Console.WriteLine("Hello, World!");
namespace LearnC
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Hello world, start lession";
            Console.WriteLine(name);
            // doc mot ki tu tu ban phim tra ve kieu so nguyen(chi doc duoc mot ki tu)
            // Console.WriteLine(Console.Read());
            // doc den khi nhan phim enter thi dung
            // Console.WriteLine(Console.ReadLine());

            // render lessions here
            while (true)
            {
                Lession3Variable();
                Thread.Sleep(5000);
            }
            

            // 

            Console.ReadKey(); // mac dinh la false, hien thi phim an tu ban phim len man hinh
            // Console.ReadKey(true); // khong hien thi phim an tu ban phim len man hinh
        }

        
        static void Lession3Variable()
        {
            // la ten goi tham chieu den mot vung nho nao do trong bo nho
            // la thanh phan cot loi cua mot ngon ngu lap trinh
            // thao tac voi bo nho mot cach de dang
            int integer = 1;
            string str = "mot";
            bool boolean = true;
            char charater = 'c';
            Console.WriteLine("int:" + integer + " string:" + str + " boolean:" + boolean + " charater:" + charater);
        }
        
    }
}