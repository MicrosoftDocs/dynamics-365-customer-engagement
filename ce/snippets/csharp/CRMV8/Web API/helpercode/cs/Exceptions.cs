// =====================================================================
//  This file is part of the Microsoft Dynamics CRM SDK code samples.
//
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//
//  This source code is intended only as a supplement to Microsoft
//  Development Tools and/or on-line documentation.  See these other
//  materials for detailed information regarding Microsoft code samples.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
// =====================================================================
//<snippetCrmHttpResponseException>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Microsoft.Crm.Sdk.Samples.HelperCode
{
    /// <summary>
    /// Produces a populated exception from an error message in the content of an HTTP response. 
    /// </summary>
    public class CrmHttpResponseException : System.Exception
    {
        #region Properties
        private static string _stackTrace;
        
        /// <summary>
        /// Gets a string representation of the immediate frames on the call stack.
        /// </summary>
        public override string StackTrace
        {
            get { return _stackTrace; }
        }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the CrmHttpResponseException class.
        /// </summary>
        /// <param name="content">The populated HTTP content in Json format.</param>
        public CrmHttpResponseException(HttpContent content)
            : base(ExtractMessageFromContent(content)) { }

        /// <summary>
        /// Initializes a new instance of the CrmHttpResponseException class.
        /// </summary>
        /// <param name="content">The populated HTTP content in Json format.</param>
        /// <param name="innerexception">The exception that is the cause of the current exception, or a null reference
        /// if no inner exception is specified.</param>
        public CrmHttpResponseException(HttpContent content, Exception innerexception)
            : base(ExtractMessageFromContent(content), innerexception) { }

        #endregion Constructors

        #region Methods
        /// <summary>
        /// Extracts the CRM specific error message and stack trace from an HTTP content. 
        /// </summary>
        /// <param name="content">The HTTP content in Json format.</param>
        /// <returns>The error message.</returns>
        private static string ExtractMessageFromContent(HttpContent content)
        {
            string message = String.Empty;

            string downloadedContent = content.ReadAsStringAsync().Result;

            if (content.Headers.ContentType.MediaType.Equals("text/plain"))
            {
                message = downloadedContent;
            }
            else if (content.Headers.ContentType.MediaType.Equals("application/json"))
            {
                JObject jcontent = (JObject)JsonConvert.DeserializeObject(downloadedContent);
                IDictionary<string, JToken> d = jcontent;

                // An error message is returned in the content under the 'error' key. 
                if (d.ContainsKey("error"))
                {
                    JObject error = (JObject)jcontent.Property("error").Value;
                    message = (String)error.Property("message").Value;
                }
                else if (d.ContainsKey("Message"))
                    message = (String)jcontent.Property("Message").Value;

                if (d.ContainsKey("StackTrace"))
                    _stackTrace = (String)jcontent.Property("StackTrace").Value;
            }
            else if (content.Headers.ContentType.MediaType.Equals("text/html"))
            {
                message = "HTML content that was returned is shown below.";
                message += "\n\n" + downloadedContent;
            }
            else
            {
                message = String.Format("No handler is available for content in the {0} format.",  
                    content.Headers.ContentType.MediaType.ToString());
            }

            return message;
            #endregion Methods
        }
    }
}
//</snippetCrmHttpResponseException>
