using System;

namespace CpoDesign.Lib.Exception
{
    public static class ExceptionAssert
    {
        /// <summary>
        /// Extension for asserting exceptions.
        /// </summary>
        /// <typeparam name="T">Type of an exception</typeparam>
        /// <param name="func">What is being asserted</param>
        /// <example>
        /// <![CDATA[
        /// ExceptionAssert.Throws<ArgumentNullException>(() => Class.SerilizeToString<object>(objectToSerialize));
        /// ]]> 
        /// </example>
        public static void Throws<T>(Action func) where T : System.Exception
        {
            var exceptionThrown = false;
            try
            {
                func.Invoke();
            }
            catch (T)
            {
                exceptionThrown = true;
            }

            if (!exceptionThrown)
            {
                throw new AssertFailedException(String.Format("An exception of type {0} was expected, but not thrown", typeof(T)));
            }
        }
    }
}