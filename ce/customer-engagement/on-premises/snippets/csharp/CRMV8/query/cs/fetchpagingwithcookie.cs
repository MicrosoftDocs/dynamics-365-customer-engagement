// <snippetfetchpagingwithcookie>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;


namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to use the Fetch XML method with a paging
    /// cookie to retrieve a batch of records.
    /// If you want to run this sample repeatedly, you have the option to 
    /// delete all the records created at the end of execution.
    /// </summary>
    class FetchPagingWithCookie
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        // Define the IDs needed for this sample.
        public Guid _parentAccountId;
        public Guid[] _childAccountIds;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create a parent account record and subsequent 10 child account records.
        /// Retrieve batch of records using RetrieveMultiple message with paging cookie.
        /// Optionally delete any entity records that were created for this sample.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                 
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    _service = (IOrganizationService)_serviceProxy;

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Define the fetch attributes.
                    // Set the number of records per page to retrieve.
                    int fetchCount = 3;
                    // Initialize the page number.
                    int pageNumber = 1;
                    // Initialize the number of records.
                    int recordCount = 0;
                    // Specify the current paging cookie. For retrieving the first page, 
                    // pagingCookie should be null.
                    string pagingCookie = null;

                    // Create the FetchXml string for retrieving all child accounts to a parent account.
                    // This fetch query is using 1 placeholder to specify the parent account id 
                    // for filtering out required accounts. Filter query is optional.
                    // Fetch query also includes optional order criteria that, in this case, is used 
                    // to order the results in ascending order on the name data column.
                    string fetchXml = string.Format(@"<fetch version='1.0' 
                                                    mapping='logical' 
                                                    output-format='xml-platform'>
                                                    <entity name='account'>
                                                        <attribute name='name' />
                                                        <attribute name='emailaddress1' />
                                                        <order attribute='name' descending='false'/>
                                                        <filter type='and'>
				                                            <condition attribute='parentaccountid' 
                                                                operator='eq' value='{0}' uiname='' uitype='' />
                                                        </filter>
                                                    </entity>
                                                </fetch>",
                                                    _parentAccountId);

                    Console.WriteLine("Retrieving data in pages\n"); 
                    Console.WriteLine("#\tAccount Name\t\t\tEmail Address");

                    while (true)
                    {
                        // Build fetchXml string with the placeholders.
                        string xml = CreateXml(fetchXml, pagingCookie, pageNumber, fetchCount);

                        // Excute the fetch query and get the xml result.
                        RetrieveMultipleRequest fetchRequest1 = new RetrieveMultipleRequest
                        {
                            Query = new FetchExpression(xml)
                        };

                        EntityCollection returnCollection = ((RetrieveMultipleResponse)_service.Execute(fetchRequest1)).EntityCollection;
                        
                        foreach (var c in returnCollection.Entities)
                        {
                            System.Console.WriteLine("{0}.\t{1}\t\t{2}", ++recordCount, c.Attributes["name"], c.Attributes["emailaddress1"] );
                        }                        
                        
                        // Check for morerecords, if it returns 1.
                        if (returnCollection.MoreRecords)
                        {
                            Console.WriteLine("\n****************\nPage number {0}\n****************", pageNumber);
                            Console.WriteLine("#\tAccount Name\t\t\tEmail Address");
                            
                            // Increment the page number to retrieve the next page.
                            pageNumber++;

                            // Set the paging cookie to the paging cookie returned from current results.                            
                            pagingCookie = returnCollection.PagingCookie;
                        }
                        else
                        {
                            // If no more records in the result nodes, exit the loop.
                            break;
                        }
                    }

                    DeleteRequiredRecords(promptForDelete);
                }
            }
            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
            return;
        }

        
        public string ExtractNodeValue(XmlNode parentNode, string name)
        {
            XmlNode childNode = parentNode.SelectSingleNode(name);

            if (null == childNode)
            {
                return null;
            }
            return childNode.InnerText;
        }

        public string ExtractAttribute(XmlDocument doc, string name)
        {
            XmlAttributeCollection attrs = doc.DocumentElement.Attributes;
            XmlAttribute attr = (XmlAttribute)attrs.GetNamedItem(name);
            if (null == attr)
            {
                return null;
            }
            return attr.Value;
        }

        public string CreateXml(string xml, string cookie, int page, int count)
        {
            StringReader stringReader = new StringReader(xml);
            XmlTextReader reader = new XmlTextReader(stringReader);

            // Load document
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);

            return CreateXml(doc, cookie, page, count);
        }

        public string CreateXml(XmlDocument doc, string cookie, int page, int count)
        {
            XmlAttributeCollection attrs = doc.DocumentElement.Attributes;

            if (cookie != null)
            {
                XmlAttribute pagingAttr = doc.CreateAttribute("paging-cookie");
                pagingAttr.Value = cookie;
                attrs.Append(pagingAttr);
            }

            XmlAttribute pageAttr = doc.CreateAttribute("page");
            pageAttr.Value = System.Convert.ToString(page);
            attrs.Append(pageAttr);

            XmlAttribute countAttr = doc.CreateAttribute("count");
            countAttr.Value = System.Convert.ToString(count);
            attrs.Append(countAttr);

            StringBuilder sb = new StringBuilder(1024);
            StringWriter stringWriter = new StringWriter(sb);

            XmlTextWriter writer = new XmlTextWriter(stringWriter);
            doc.WriteTo(writer);
            writer.Close();

            return sb.ToString();
        }

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Create a parent account record.
        /// Create 10 child accounts to the parent account record.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Instantiate a account entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation
            // to determine which attributes must be set for each entity.
            // Create the parent account.
            Account parentAccount = new Account
            {
                Name = "Root Test Account",
                EMailAddress1 = "root@root.com"
            };
            
            
            _parentAccountId = _service.Create(parentAccount);

            // Create 10 child accounts.
            _childAccountIds = new Guid[10]; 
            int count = 1;
            while (true)
            {
                Account childAccount = new Account
                {
                    Name = "Child Test Account " + count.ToString(),
                    EMailAddress1 = "child" + count.ToString() + "@root.com",
                    EMailAddress2 = "same@root.com",
                    ParentAccountId = new EntityReference(Account.EntityLogicalName, _parentAccountId)
                };
                
                _childAccountIds[count - 1] = _service.Create(childAccount);

                // Jump out of the loop after creating 10 child accounts.
                if (count == 10)
                    break;
                // Increment the count.
                count++;
            }            
            return;
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                // Remove the test parent account.
                _service.Delete(Account.EntityLogicalName, _parentAccountId);
                
                // Remove 10 test child accounts.
                int deleteCount = 0;
                while (deleteCount < 10)
                {
                    _service.Delete(Account.EntityLogicalName, _childAccountIds[deleteCount]);
                    ++deleteCount;
                }

                Console.WriteLine("Entity records have been deleted.");
            }
        }
                
        #endregion How To Sample Code

        #region Main

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

                FetchPagingWithCookie app = new FetchPagingWithCookie();
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
        #endregion Main

    }
}

// </snippetfetchpagingwithcookie>