// <snippetretrievemultipleconditionoperatorslinq>


using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
 /// <summary>
 /// Demonstrates how to do use retrieve multiple condition operators for all
 /// query types.</summary>
 /// <remarks>
 /// At run-time, you will be given the option to delete all the
 /// database records created by this program.</remarks>
 public class RetrieveMultipleConditionOperatorsLinq
 {
  #region Class Level Members

  private Guid _accountId;
  private List<Guid> _contactIdList = new List<Guid>();
  private OrganizationServiceProxy _serviceProxy;
  private IOrganizationService _service;

  #endregion Class Level Members

  #region How To Sample Code
  /// <summary>
  /// This method first connects to the Organization service. Afterwards,
  /// basic LINQ queries are performed.
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

     _service = (IOrganizationService)_serviceProxy;

     CreateRequiredRecords();

     // Create the ServiceContext object that will generate
     // the IQueryable collections for LINQ calls.
     ServiceContext svcContext =
         new ServiceContext(_service);

                         
     #region SQL Query Translated to LINQ
     // Build the following SQL query using QueryExpression:
     //
     //		SELECT contact.fullname, contact.address1_telephone1
     //		FROM contact
     //			LEFT OUTER JOIN account
     //				ON contact.parentcustomerid = account.accountid
     //				AND
     //				account.name = 'Litware, Inc.'
     //		WHERE (contact.address1_stateorprovince = 'WA'
     //		AND
     //			contact.address1_city in ('Redmond', 'Bellevue', 'Kirkland', 'Seattle')
     //		AND 
     //			contact.address1_telephone1 like '(206)%'
     //			OR
     //			contact.address1_telephone1 like '(425)%'
     //		AND
     //			contact.emailaddress1 Not NULL
     //			   )
     var contacts = (from c in svcContext.ContactSet
                     join a in svcContext.AccountSet on c.ParentCustomerId.Id equals a.AccountId
                     where (a.Name == "Litware, Inc.")
                     where (c.Address1_StateOrProvince == "WA"
                     && (c.Address1_Telephone1.StartsWith("(206)") ||
                         c.Address1_Telephone1.StartsWith("(425)"))
                     && (c.Address1_City == "Redmond" ||
                         c.Address1_City == "Bellevue" ||
                         c.Address1_City == "Kirkland" ||
                         c.Address1_City == "Seattle")
                     && (c.EMailAddress1 != null && c.EMailAddress1 != ""))
                     select new Contact
                     {
                      ContactId = c.ContactId,
                      FirstName = c.FirstName,
                      LastName = c.LastName,
                      Address1_Telephone1 = c.Address1_Telephone1
                     });

     // Display the results.
     Console.WriteLine("List all contacts matching specified parameters");
     Console.WriteLine("===============================================");
     foreach (Contact contact in contacts)
     {
      Console.WriteLine("Contact ID: {0}", contact.Id);
      Console.WriteLine("Contact Name: {0}", contact.FullName);
      Console.WriteLine("Contact Phone: {0}", contact.Address1_Telephone1);
     }
     Console.WriteLine("<End of Listing>");
     Console.WriteLine();
     #endregion

     //OUTPUT:
     //List all contacts matching specified parameters
     //===============================================
     //Contact ID: a263e139-63a3-e011-aea3-00155dba3818
     //Contact Name:
     //Contact Phone: (206)555-5555
     //Contact ID: a463e139-63a3-e011-aea3-00155dba3818
     //Contact Name:
     //Contact Phone: (425)555-5555
     //<End of Listing>

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
  /// Creates any entity records that this sample requires.
  /// </summary>
  public void CreateRequiredRecords()
  {
   // Create an account.
   Account account = new Account
   {
    Name = "Litware, Inc."
   };
   _accountId = _service.Create(account);

   // Create the 2 contacts.
   Contact contact = new Contact()
   {
    FirstName = "Ben",
    LastName = "Andrews",
    EMailAddress1 = "sample@example.com",
    Address1_City = "Redmond",
    Address1_StateOrProvince = "WA",
    Address1_Telephone1 = "(206)555-5555",
    ParentCustomerId = new EntityReference
    {
     Id = _accountId,
     LogicalName = account.LogicalName
    }
   };
   _contactIdList.Add(_service.Create(contact));

   contact = new Contact()
   {
    FirstName = "Colin",
    LastName = "Wilcox",
    EMailAddress1 = "sample@example.com",
    Address1_City = "Bellevue",
    Address1_StateOrProvince = "WA",
    Address1_Telephone1 = "(425)555-5555",
    ParentCustomerId = new EntityReference
    {
     Id = _accountId,
     LogicalName = account.LogicalName
    }
   };
   _contactIdList.Add(_service.Create(contact));
  }

  /// <summary>
  /// Deletes any entity records that were created for this sample.
  /// <param name="prompt">Indicates whether to prompt the user 
  /// to delete the records created in this sample.</param>
  /// </summary>
  public void DeleteRequiredRecords(bool prompt)
  {
   bool toBeDeleted = true;

   if (prompt)
   {
    // Ask the user if the created entities should be deleted.
    Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
    String answer = Console.ReadLine();
    if (answer.StartsWith("y") ||
        answer.StartsWith("Y") ||
        answer == String.Empty)
    {
     toBeDeleted = true;
    }
    else
    {
     toBeDeleted = false;
    }
   }

   if (toBeDeleted)
   {
    // Delete all records created in this sample.
    foreach (Guid contactId in _contactIdList)
    {
     _service.Delete(Contact.EntityLogicalName, contactId);
    }

    _service.Delete(Account.EntityLogicalName, _accountId);

    Console.WriteLine("Entity record(s) have been deleted.");
   }
  }

  #endregion How To Sample Code

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

    RetrieveMultipleConditionOperatorsLinq app = new RetrieveMultipleConditionOperatorsLinq();
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

// </snippetretrievemultipleconditionoperatorslinq>