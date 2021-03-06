﻿using System;
using System.Messaging;

namespace MessagePipelines
{
  public static class MessageExtensions
    {
        public static void TraceMessage(this Message requestMessage)
        {
            Console.WriteLine("Sent request");
            Console.WriteLine("\tTime:       {0}", DateTime.Now.ToString("HH:mm:ss.ffffff"));
            Console.WriteLine("\tMessage ID: {0}", requestMessage.Id);
            Console.WriteLine("\tCorrel. ID: {0}", requestMessage.CorrelationId);
            Console.WriteLine("\tContents:   {0}", requestMessage.Body);
        }
    }}
