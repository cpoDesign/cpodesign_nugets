namespace CpoDesign.Lib.Exception
{
    public class AssertFailedException : System.Exception
    {

        public AssertFailedException()
        {
        }

        public AssertFailedException(string message)
            : base(message)
        {
        }

        public AssertFailedException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }

}
