

namespace CustomExceptionDemo
{
    public class CSVNotFoundException : Exception
    {

        public CSVNotFoundException()
        {
        }
        public CSVNotFoundException(string message): base(message)
        {
        }
        public CSVNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
