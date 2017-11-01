// <snippetuselinqquery>


using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
 /// <summary>
 /// Demonstrates how to make LINQ queries with the OrganizationServiceContext
 /// object and strongly-typed entities.</summary>
 /// <remarks>
 /// At run-time, you will be given the option to delete all the
 /// database records created by this program.</remarks>
 public class UseLinqQuery
 {
  #region Class Level Members

  private List<Guid> _accountIds = new List<Guid>();
  private List<Guid> _contactIds = new List<Guid>();
  private List<Guid> _leadIds = new List<Guid>();
  private List<Guid> _taskIds = new List<Guid>();
  private OrganizationServiceProxy _serviceProxy;
  private IOrganizationService _service;

  #endregion Class Level Members

  #region How To Sample Code
  /// <summary>
  /// This method first connects to the Organization service and service context.
  /// Afterwards, several LINQ query techniques are demonstrated.
  /// </summary>
  /// <param name="serverConfig">Contains server connection information.</param>
  /// <param name="promptForDelete">When True, the user will be prompted to delete
  /// all created entities.</param>
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

     CreateRequiredRecords();

     ServiceContext svcContext =
         new ServiceContext(_service);


     // Retrieve records with Skip/Take record paging. Setting a page size
     // can help you manage your Skip and Take calls, since Skip must be
     // passed a multiple of Take's parameter value.
     int pageSize = 5;

     var accountsByPage = (from a in svcContext.AccountSet
                           select new Account
                           {
                            Name = a.Name,
                           });
     System.Console.WriteLine("Skip 10 accounts, then Take 5 accounts");
     System.Console.WriteLine("======================================");
     foreach (var a in accountsByPage.Skip(2 * pageSize).Take(pageSize))
     {
      System.Console.WriteLine(a.Name);
     }
     System.Console.WriteLine();
     System.Console.WriteLine("<End of Listing>");
     System.Console.WriteLine();
     //OUTPUT:
     //Skip 10 accounts, then Take 5 accounts
     //======================================
     //Fourth Coffee 6
     //Fourth Coffee 7
     //Fourth Coffee 8
     //Fourth Coffee 9
     //Fourth Coffee 10

     //<End of Listing>



     // Use orderBy to order items retrieved.
     var orderedAccounts = from a in svcContext.AccountSet
                           orderby a.Name
                           select new Account
                           {
                            Name = a.Name,
                           };
     System.Console.WriteLine("Display accounts ordered by name");
     System.Console.WriteLine("================================");
     foreach (var a in orderedAccounts)
     {
      System.Console.WriteLine(a.Name);
     }
     System.Console.WriteLine();
     System.Console.WriteLine("<End of Listing>");
     System.Console.WriteLine();
     //OUTPUT:
     //Display accounts ordered by name
     //================================
     //A. Datum Corporation
     //Adventure Works
     //Coho Vineyard
     //Fabrikam
     //Fourth Coffee 1
     //Fourth Coffee 10
     //Fourth Coffee 2
     //Fourth Coffee 3
     //Fourth Coffee 4
     //Fourth Coffee 5
     //Fourth Coffee 6
     //Fourth Coffee 7
     //Fourth Coffee 8
     //Fourth Coffee 9
     //Humongous Insurance

     //<End of Listing>


     // Filter multiple entities using LINQ.
     var query = from c in svcContext.ContactSet
                 join a in svcContext.AccountSet
                               on c.ContactId equals a.PrimaryContactId.Id
                 where c.LastName == "Wilcox" || c.LastName == "Andrews"
                 where a.Address1_Telephone1.Contains("(206)")
                     || a.Address1_Telephone1.Contains("(425)")
                 select new
                 {
                  Contact = new Contact
                  {
                   FirstName = c.FirstName,
                   LastName = c.LastName,
                  },
                  Account = new Account
                  {
                   Address1_Telephone1 = a.Address1_Telephone1
                  }
                 };

     Console.WriteLine("Join account and contact");
     Console.WriteLine("List all records matching specified parameters");
     Console.WriteLine("Contact name: Wilcox or Andrews");
     Console.WriteLine("Account area code: 206 or 425");
     Console.WriteLine("==============================================");
     foreach (var record in query)
     {
      Console.WriteLine("Contact Name: {0} {1}",
          record.Contact.FirstName, record.Contact.LastName);
      Console.WriteLine("Account Phone: {0}",
          record.Account.Address1_Telephone1);
     }
     Console.WriteLine("<End of Listing>");
     Console.WriteLine();
     //OUTPUT:
     //Join account and contact
     //List all records matching specified parameters
     //Contact name: Wilcox or Andrews
     //Account area code: 206 or 425
     //==============================================
     //Contact Name: Ben Andrews
     //Account Phone: (206)555-5555
     //Contact Name: Ben Andrews
     //Account Phone: (425)555-5555
     //Contact Name: Colin Wilcox
     //Account Phone: (425)555-5555
     //<End of Listing>



     // Build a complex query with LINQ. This query includes multiple
     // JOINs and a complex WHERE statement.
     var complexQuery = from c in svcContext.ContactSet
                        join a in svcContext.AccountSet
                               on c.ContactId equals a.PrimaryContactId.Id
                        join l in svcContext.CreateQuery<Lead>()
                               on a.OriginatingLeadId.Id equals l.LeadId
                        where c.LastName == "Wilcox" || c.LastName == "Andrews"
                        where a.Address1_Telephone1.Contains("(206)")
                            || a.Address1_Telephone1.Contains("(425)")
                        select new
                        {
                         Contact = new Contact
                         {
                          FirstName = c.FirstName,
                          LastName = c.LastName,
                         },
                         Account = new Account
                         {
                          Address1_Telephone1 = a.Address1_Telephone1
                         },
                         Lead = new Lead
                         {
                          LeadId = l.LeadId
                         }
                        };

     Console.WriteLine("Join account, contact and lead");
     Console.WriteLine("List all records matching specified parameters");
     Console.WriteLine("Contact name: Wilcox or Andrews");
     Console.WriteLine("Account area code: 206 or 425");
     Console.WriteLine("==============================================");
     foreach (var record in complexQuery)
     {
      Console.WriteLine("Lead ID: {0}",
          record.Lead.LeadId);
      Console.WriteLine("Contact Name: {0} {1}",
          record.Contact.FirstName, record.Contact.LastName);
      Console.WriteLine("Account Phone: {0}",
          record.Account.Address1_Telephone1);
     }
     Console.WriteLine("<End of Listing>");
     Console.WriteLine();
     //OUTPUT:
     //Join account, contact and lead
     //List all records matching specified parameters
     //Contact name: Wilcox or Andrews
     //Account area code: 206 or 425
     //==============================================
     //Lead ID: 78d5df14-64a3-e011-aea3-00155dba3818
     //Contact Name: Colin Wilcox
     //Account Phone: (425)555-5555
     //<End of Listing>

     //Retrieve a related Task for a Contact
     //Shows requirement that LoadProperty must be used to access the related record.
     Contact benAndrews = svcContext.ContactSet.Where(c => c.FullName == "Ben Andrews").FirstOrDefault();
     if (benAndrews != null)
     {
      //benAndrews.Contact_Tasks is null until LoadProperty is used.
      svcContext.LoadProperty(benAndrews, "Contact_Tasks");
      Task benAndrewsFirstTask = benAndrews.Contact_Tasks.FirstOrDefault();
      if (benAndrewsFirstTask != null)
      {
       Console.WriteLine("Ben Andrews first task with Subject: '{0}' retrieved.", benAndrewsFirstTask.Subject);
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
  }

  /// <summary>
  /// Creates any entity records that this sample requires.
  /// </summary>
  public void CreateRequiredRecords()
  {
   // Create 3 contacts.
   Contact contact = new Contact()
   {
    FirstName = "Ben",
    LastName = "Andrews",
    EMailAddress1 = "sample@example.com",
    Address1_City = "Redmond",
    Address1_StateOrProvince = "WA"
   };
   Guid benAndrewsContactId = _service.Create(contact);
   _contactIds.Add(benAndrewsContactId);
   
   //Create a task associated with Ben Andrews
   Task task = new Task() { 
    Subject = "Sample Task", 
    RegardingObjectId = new EntityReference() { 
     LogicalName = Contact.EntityLogicalName,
     Id = benAndrewsContactId, 
     Name = contact.FullName 
    } 
   };
   _taskIds.Add(_service.Create(task));
  


   contact = new Contact()
   {
    FirstName = "Colin",
    LastName = "Wilcox",
    EMailAddress1 = "sample@example.com",
    Address1_City = "Bellevue",
    Address1_StateOrProvince = "WA"
   };
   _contactIds.Add(_service.Create(contact));

   contact = new Contact()
   {
    FirstName = "Ben",
    LastName = "Smith",
    EMailAddress1 = "sample@example.com",
    Address1_City = "Bellevue",
    Address1_StateOrProvince = "WA"
   };
   _contactIds.Add(_service.Create(contact));

   // Create 3 leads.
   Lead lead = new Lead()
   {
    FirstName = "Dan",
    LastName = "Wilson",
    EMailAddress1 = "sample@example.com",
    Address1_City = "Redmond",
    Address1_StateOrProvince = "WA"
   };
   _leadIds.Add(_service.Create(lead));

   lead = new Lead()
   {
    FirstName = "Jim",
    LastName = "Wilson",
    EMailAddress1 = "sample@example.com",
    Address1_City = "Bellevue",
    Address1_StateOrProvince = "WA"
   };
   _leadIds.Add(_service.Create(lead));

   lead = new Lead()
   {
    FirstName = "Denise",
    LastName = "Smith",
    EMailAddress1 = "sample@example.com",
    Address1_City = "Bellevue",
    Address1_StateOrProvince = "WA"
   };
   _leadIds.Add(_service.Create(lead));

   // Create 5 customized Accounts for the LINQ samples.
   Account account = new Account
   {
    Name = "A. Datum Corporation",
    Address1_StateOrProvince = "Colorado",
    Address1_Telephone1 = "(206)555-5555",
    PrimaryContactId =
        new EntityReference(Contact.EntityLogicalName, _contactIds[0])
   };
   _accountIds.Add(_service.Create(account));

   account = new Account
   {
    Name = "Adventure Works",
    Address1_StateOrProvince = "Illinois",
    Address1_County = "Lake County",
    Address1_Telephone1 = "(206)555-5555",
    OriginatingLeadId =
        new EntityReference(Lead.EntityLogicalName, _leadIds[0])
   };
   _accountIds.Add(_service.Create(account));

   account = new Account
   {
    Name = "Coho Vineyard",
    Address1_StateOrProvince = "Washington",
    Address1_County = "King County",
    Address1_Telephone1 = "(425)555-5555",
    PrimaryContactId =
        new EntityReference(Contact.EntityLogicalName, _contactIds[1]),
    OriginatingLeadId =
        new EntityReference(Lead.EntityLogicalName, _leadIds[0])
   };
   _accountIds.Add(_service.Create(account));

   account = new Account
   {
    Name = "Fabrikam",
    Address1_StateOrProvince = "Washington",
    Address1_Telephone1 = "(425)555-5555",
    PrimaryContactId =
        new EntityReference(Contact.EntityLogicalName, _contactIds[0])
   };
   _accountIds.Add(_service.Create(account));

   account = new Account
   {
    Name = "Humongous Insurance",
    Address1_StateOrProvince = "Missouri",
    Address1_County = "Saint Louis County",
    Address1_Telephone1 = "(314)555-5555",
    PrimaryContactId =
        new EntityReference(Contact.EntityLogicalName, _contactIds[1])
   };
   _accountIds.Add(_service.Create(account));

   // Create 10 basic Account records.
   for (int i = 1; i <= 10; i++)
   {
    account = new Account
    {
     Name = "Fourth Coffee " + i,
     Address1_StateOrProvince = "California"
    };
    _accountIds.Add(_service.Create(account));
   }
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


    foreach (Guid taskId in _taskIds)
    {
     _service.Delete(Task.EntityLogicalName, taskId);
    }
    foreach (Guid accountId in _accountIds)
    {
     _service.Delete(Account.EntityLogicalName, accountId);
    }
    foreach (Guid contactId in _contactIds)
    {
     _service.Delete(Contact.EntityLogicalName, contactId);
    }
    foreach (Guid leadId in _leadIds)
    {
     _service.Delete(Lead.EntityLogicalName, leadId);
    }
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

    UseLinqQuery app = new UseLinqQuery();
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

// </snippetuselinqquery>