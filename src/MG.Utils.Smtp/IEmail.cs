﻿using System.Threading.Tasks;

namespace MG.Utils.Smtp
{
    public interface IEmail
    {
        Task SendAsync(string serializedEmailMessage);

        Task SendAsync(EmailMessage message);

        /// <summary>
        /// Gets log messages generated by smtp provider.
        /// </summary>
        string Logs { get; }
    }
}