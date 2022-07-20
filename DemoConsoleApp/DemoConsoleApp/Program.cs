//// See https://aka.ms/new-console-template for more information
//// Console.WriteLine("Hello, World!");

//namespace Training
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }

//        public class Product
//        {
//            public string Name { get; set; }

//            public virtual int CalculateDiscount()
//            {
//                return 0;
//            }
//            private int _type;
//            public int Type { get { return _type; } set { _type = value; } }
//            public virtual int CalculateDiscount()
//            {
//                //if (_type == 0)
//                //{
//                //    return 10;
//                //}
//                //else if (_type == 1)
//                //{
//                //    return 2;
//                //}
//                //else
//                //    return 5;
//                return 0;
//            }
//            ErrorLogger errorLogger = new();
//            //public void add()
//            //{
//            //    try
//            //    {

//            //    }
//            //    catch(exception ex)
//            //    {
//            //        file.writealltext(@"e:\ara\dotnet\error.txt", ex.message);
//            //    }
//            //}
//        }


//        public class SmartWatch : Product
//        {
//            public override int CalculateDiscount()
//            {
//                return base.CalculateDiscount() + 10;
//            }
//        }

//        public class Firestick : Product
//        {
//            public string Name { get; set; }
//        }
//    }

//    public class ErrorLogger
//    {
//        public void WriteErrorLog(string message)
//        {
//            File.WriteAllText(@"E:\Ara\dotNet\Error.txt", message);
//        }
//    }
//}


class Program
{
    static void Main(string[] args)
    {
        Customer customer = new();

    }
}