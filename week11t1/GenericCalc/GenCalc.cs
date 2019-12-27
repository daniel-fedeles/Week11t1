using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalc
{
    public class GenCalc<T>
    {

        public T Add(T a, T b)
        {
            if (!EvaluateType(a, b)) throw new NotANumberException();
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
        public T Sub(T a, T b)
        {
            if (!EvaluateType(a, b)) throw new NotANumberException();
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }
        public T Mul(T a, T b)
        {
            if (!EvaluateType(a, b)) throw new NotANumberException();
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }
        public T Div(T a, T b)
        {
            if (!EvaluateType(a, b)) throw new NotANumberException();
            if (b == null)
            { throw new ArgumentNullException(nameof(b));}
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }

        private bool EvaluateType(T a, T b)
        {
            if ((a is int || a is decimal || a is double || a is float)
                || (b is int || b is decimal || b is double || b is float))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    [Serializable]
    public class NotANumberException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public NotANumberException()
        {
        }

        public NotANumberException(string message) : base(message)
        {
        }

        public NotANumberException(string message, Exception inner) : base(message, inner)
        {
        }

        protected NotANumberException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
