// <snippetbulkimporthelper>


using System;
using System.IO;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{    
    public static class BulkImportHelper
    {
        /// <summary>
        /// Reads data from the specified .csv file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string ReadCsvFile(string filePath)
        {
            string data = string.Empty;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string value = reader.ReadLine();
                while (value != null)
                {
                    data += value;
                    data += "\n";
                    value = reader.ReadLine();
                }
            }
            return data;
        }

        /// <summary>
        /// Reads data from the specified .xml file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string ReadXmlFile(string filePath)
        {
            string data = string.Empty;
            using (StreamReader reader = new StreamReader(filePath))
            {
                data = reader.ReadToEnd();
            }
            return data;
        }

        /// <summary>
        /// Check for importlog records
        /// </summary>
        /// <param name="service"></param>
        /// <param name="importFileId"></param>
        public static void ReportErrors(OrganizationServiceProxy serviceProxy, Guid importFileId)
        {
            QueryByAttribute importLogQuery = new QueryByAttribute();
            importLogQuery.EntityName = ImportLog.EntityLogicalName;
            importLogQuery.ColumnSet = new ColumnSet(true);
            importLogQuery.Attributes.Add("importfileid");
            importLogQuery.Values.Add(new object[1]);
            importLogQuery.Values[0] = importFileId;

            EntityCollection importLogs = serviceProxy.RetrieveMultiple(importLogQuery);

            if (importLogs.Entities.Count > 0)
            {
                Console.WriteLine("Number of Failures: " + importLogs.Entities.Count.ToString());
                Console.WriteLine("Sequence Number    Error Number    Description    Column Header    Column Value   Line Number");

                // Display errors.
                foreach (ImportLog log in importLogs.Entities)
                {
                    Console.WriteLine(
                        string.Format("Sequence Number: {0}\nError Number: {1}\nDescription: {2}\nColumn Header: {3}\nColumn Value: {4}\nLine Number: {5}",
                            log.SequenceNumber.Value,
                            log.ErrorNumber.Value,
                            log.ErrorDescription,
                            log.HeaderColumn,
                            log.ColumnValue,
                            log.LineNumber.Value));
                }
            }
        }

        /// <summary>
        /// Waits for the async job to complete.
        /// </summary>
        /// <param name="asyncJobId"></param>
        public static void WaitForAsyncJobCompletion(OrganizationServiceProxy serviceProxy, Guid asyncJobId)
        {
            ColumnSet cs = new ColumnSet("statecode", "statuscode");
            AsyncOperation asyncjob =
                (AsyncOperation)serviceProxy.Retrieve("asyncoperation", asyncJobId, cs);

            int retryCount = 100;

            while (asyncjob.StateCode.Value != AsyncOperationState.Completed && retryCount > 0)
            {
                asyncjob = (AsyncOperation)serviceProxy.Retrieve("asyncoperation", asyncJobId, cs);
                System.Threading.Thread.Sleep(2000);
                retryCount--;
                Console.WriteLine("Async operation state is " + asyncjob.StateCode.Value.ToString());
            }

            Console.WriteLine("Async job is " + asyncjob.StateCode.Value.ToString() + " with status " + ((asyncoperation_statuscode)asyncjob.StatusCode.Value).ToString());
        }
    }
}

// </snippetbulkimporthelper>