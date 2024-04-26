using System;
using System.Runtime.Serialization;

namespace RaylibTiledCS
{
    [Serializable]
    internal class RaylibTiledCSException : Exception
    {
        public RaylibTiledCSException()
        {
        }

        public RaylibTiledCSException(string message) : base(message)
        {
        }

        public RaylibTiledCSException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RaylibTiledCSException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}