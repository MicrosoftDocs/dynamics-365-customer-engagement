// <snippetuploadanddownloadattachment>


using System;
using System.IO;
using System.Text;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to upload attachments to an annotation and how to download attachments.
    /// </summary>
    public class UploadAndDownloadAttachment
    {

        #region Class Level Members

        private Guid _annotationId;
        private OrganizationServiceProxy _serviceProxy;
        private String _fileName;

        #endregion Class Level Members

        #region How-To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// an annotation is created, uploaded, then finally downloaded.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    #region Create and Upload annotation attachment

                    // Instantiate an Annotation object.
                    // See the Entity Metadata topic in the SDK documentation to determine
                    // which attributes must be set for each entity.
                    Annotation setupAnnotation = new Annotation()
                    {
                        Subject = "Example Annotation",
                        FileName = "ExampleAnnotationAttachment.txt",
                        DocumentBody = Convert.ToBase64String(
                            new UnicodeEncoding().GetBytes("Sample Annotation Text")),
                        MimeType = "text/plain"
                    };

                    // Create the Annotation object.
                    _annotationId = _serviceProxy.Create(setupAnnotation);

                    Console.Write("{0} created with an attachment", setupAnnotation.Subject);

                    #endregion Create and Upload annotation attachment

                    #region Download attachment from annotation record

                    // Define columns to retrieve from the annotation record.
                    ColumnSet cols = new ColumnSet("filename", "documentbody");
                   

                    // Retrieve the annotation record.
                    Annotation retrievedAnnotation = 
                        (Annotation)_serviceProxy.Retrieve("annotation", _annotationId, cols);
                    Console.WriteLine(", and retrieved.");
                    _fileName = retrievedAnnotation.FileName;

                    // Download the attachment in the current execution folder.
                    using (FileStream fileStream = new FileStream(retrievedAnnotation.FileName, FileMode.OpenOrCreate))
                    {
                        byte[] fileContent = Convert.FromBase64String(retrievedAnnotation.DocumentBody);
                        fileStream.Write(fileContent, 0, fileContent.Length);
                    }

                    Console.WriteLine("Attachment downloaded.");

                    #endregion Download attachment from annotation record

                    DeleteRequiredRecords(promptforDelete);
                }
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        /// <summary>
        /// Deletes any entity records and files that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(Annotation.EntityLogicalName, _annotationId);
                File.Delete(_fileName);
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion How-To Sample Code

        #region Main method

        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                UploadAndDownloadAttachment app = new UploadAndDownloadAttachment();
                app.Run(config, true);
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
            }
            catch (System.TimeoutException ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }
        #endregion Main method
    }
}

// </snippetuploadanddownloadattachment>