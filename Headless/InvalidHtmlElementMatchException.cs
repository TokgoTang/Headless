﻿namespace Headless
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    ///     The <see cref="InvalidHtmlElementMatchException" />
    ///     class identifies scenarios where an invalid element match is encountered.
    /// </summary>
    [Serializable]
    public class InvalidHtmlElementMatchException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="InvalidHtmlElementMatchException" /> class.
        /// </summary>
        public InvalidHtmlElementMatchException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidHtmlElementMatchException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public InvalidHtmlElementMatchException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidHtmlElementMatchException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="inner">
        /// The inner.
        /// </param>
        public InvalidHtmlElementMatchException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidHtmlElementMatchException"/> class.
        /// </summary>
        /// <param name="info">
        /// The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object
        ///     data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual
        ///     information about the source or destination.
        /// </param>
        protected InvalidHtmlElementMatchException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}