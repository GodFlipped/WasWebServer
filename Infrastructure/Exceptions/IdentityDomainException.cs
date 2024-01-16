// -----------------------------------------------------------------------
// <copyright file="IdentityDomainException.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace WasWebServerCore.Infrastructure.Exceptions
{
    /// <summary>   Exception type for app exceptions. </summary>
    [Serializable]
    public class IdentityDomainException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityDomainException"/> class.
        /// </summary>
        public IdentityDomainException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityDomainException" /> class.
        /// </summary>
        ///
        /// <param name="message">  The message that describes the error. </param>
        public IdentityDomainException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityDomainException" /> class.
        /// </summary>
        ///
        /// <param name="message">          The error message that explains the reason for the exception. </param>
        /// <param name="innerException">   The exception that is the cause of the current exception, or
        ///                                 a null reference (<see langword="Nothing" /> in Visual Basic)
        ///                                 if no inner exception is specified. </param>
        public IdentityDomainException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityDomainException" /> class.
        /// </summary>
        ///
        /// <param name="info">     The <see cref="T:System.Runtime.Serialization.SerializationInfo" />
        ///                         that holds the serialized object data about the exception being
        ///                         thrown. </param>
        /// <param name="context">  The <see cref="T:System.Runtime.Serialization.StreamingContext" />
        ///                         that contains contextual information about the source or destination. </param>
        protected IdentityDomainException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
