namespace CustomExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a absolute path for a CSV file: ");
                var FilePath = Console.ReadLine();
                if (FilePath.Substring(FilePath.Length - 3) != "csv")
                {
                    throw new CSVNotFoundException("Not a CSV file");
                }
                File.OpenRead(FilePath);
                Console.WriteLine("File opened successfully");
                Console.WriteLine("Reading csv file");

                // File.OpenRead("E:\\Ara\\data\\auth.txt");
                // the above line will throw an exception
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("File closed successfully");
            }
            Console.ReadLine();
        }
    }
}