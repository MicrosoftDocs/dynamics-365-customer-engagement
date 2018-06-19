// <snippetcreatealinqquery>


using System;
using System.ServiceModel;
using System.Linq;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
 /// <summary>
 /// Demonstrates how to do create basic LINQ queries against Microsoft Dynamics CRM
 /// records.</summary>
 /// <remarks>
 /// At run-time, you will be given the option to delete all the
 /// database records created by this program.</remarks>
 public class CreateALinqQuery
 {
  #region Class Level Members

  private Dictionary<Guid, String> _recordIds = new Dictionary<Guid, String>();
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
       using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                        serverConfig.Credentials, serverConfig.DeviceCredentials))
    {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();
     _service = (IOrganizationService)_serviceProxy;

     CreateRequiredRecords();

     // Create the ServiceContext object that will generate
     // the IQueryable collections for LINQ calls.

     ServiceContext svcContext = new ServiceContext(_service);
     // Loop through all CRM account using the IQueryable interface
     // on the ServiceContext object
     var accounts = from a in svcContext.AccountSet
                    select new Account
                    {
                     Name = a.Name,
                     Address1_County = a.Address1_County
                    };
     System.Console.WriteLine("List all accounts in CRM");
     System.Console.WriteLine("========================");
     foreach (var a in accounts)
     {
      System.Console.WriteLine(a.Name + " " + a.Address1_County);
     }
     System.Console.WriteLine();
     System.Console.WriteLine("<End of Listing>");
     System.Console.WriteLine();
     //OUTPUT:
     //List all accounts in CRM
     //========================
     //Fourth Coffee
     //School of Fine Art Lake County
     //Tailspin Toys King County
     //Woodgrove Bank
     //Contoso, Ltd. Saint Louis County

     //<End of Listing>
     System.Console.WriteLine();



     // Retrieve all accounts owned by the user who has read access rights
     // to the accounts and where the last name of the user is not Cannon.
     var queryAccounts = from a in svcContext.AccountSet
                         join owner in svcContext.SystemUserSet
                           on a.OwnerId.Id equals owner.SystemUserId
                         where owner.LastName != "Cannon"
                         select new Account
                         {
                          Name = a.Name,
                          Address1_City = a.Address1_City
                         };
     System.Console.WriteLine("Accounts not owned by user w/ last name 'Cannon'");
     System.Console.WriteLine("================================================");
     foreach (var a in queryAccounts)
     {
      System.Console.WriteLine(a.Name + " " + a.Address1_County);
     }
     System.Console.WriteLine();
     System.Console.WriteLine("<End of Listing>");
     System.Console.WriteLine();
     //OUTPUT:
     //Accounts not owned by user w/ last name 'Cannon'
     //================================================
     //Fourth Coffee
     //School of Fine Art
     //Tailspin Toys
     //Woodgrove Bank
     //Contoso, Ltd.

     //<End of Listing>
     System.Console.WriteLine();



     // Return a count of all accounts which have a county specified
     // in their address.
     int accountsWithCounty = (from a in svcContext.AccountSet
                               where (a.Address1_County != null)
                               select new Account
                               {
                                Name = a.Name,
                                Address1_City = a.Address1_City
                               }).ToArray().Count();
     System.Console.Write("Number of accounts with a county specified: ");
     System.Console.WriteLine(accountsWithCounty);
     System.Console.WriteLine();
     //OUTPUT:
     //Number of accounts with a county specified: 3
     System.Console.WriteLine();



     // Return a count of states in which we have an account. This
     // uses the 'distinct' keyword which counts a state only one time.
     int statesWithAccounts = (from a in svcContext.AccountSet
                               where (a.Address1_StateOrProvince != null)
                               select a.Address1_StateOrProvince)
                               .Distinct().ToArray().Count();
     System.Console.Write("Number of unique states that contain accounts: ");
     System.Console.WriteLine(statesWithAccounts);
     System.Console.WriteLine();
     //OUTPUT:
     //Number of unique states that contain accounts: 3
     System.Console.WriteLine();



     // Return contacts where the city equals Redmond AND the first
     // name is Joe OR John.
     var queryContacts = from c in svcContext.ContactSet
                         where (c.Address1_City == "Redmond") &&
                               (c.FirstName.Equals("Joe") ||
                                c.FirstName.Equals("John"))
                         select new Contact
                         {
                          FirstName = c.FirstName,
                          LastName = c.LastName,
                          Address1_City = c.Address1_City
                         };
     System.Console.WriteLine("Contacts in Redmond named Joe OR John");
     System.Console.WriteLine("=====================================");
     foreach (var c in queryContacts)
     {
      System.Console.WriteLine(c.FirstName + " " +
          c.LastName + " " + c.Address1_City);
     }
     System.Console.WriteLine();
     System.Console.WriteLine("<End of Listing>");
     System.Console.WriteLine();
     //OUTPUT:
     //Contacts in Redmond named Joe OR John
     //=====================================
     //Joe  Redmond
     //John  Redmond
     //Joe  Redmond

     //<End of Listing>

     System.Console.WriteLine();


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
   // Create 5 Accounts and 5 Contacts for the LINQ samples.
   Account account = new Account
   {
    Name = "Fourth Coffee",
    Address1_StateOrProvince = "Colorado",
   };
   _recordIds.Add(_service.Create(account), Account.EntityLogicalName);
   account = new Account
   {
    Name = "School of Fine Art",
    Address1_StateOrProvince = "Illinois",
    Address1_County = "Lake County"
   };
   _recordIds.Add(_service.Create(account), Account.EntityLogicalName);
   account = new Account
   {
    Name = "Tailspin Toys",
    Address1_StateOrProvince = "Washington",
    Address1_County = "King County",
   };
   _recordIds.Add(_service.Create(account), Account.EntityLogicalName);
   account = new Account
   {
    Name = "Woodgrove Bank",
    Address1_StateOrProvince = "Washington"
   };
   _recordIds.Add(_service.Create(account), Account.EntityLogicalName);
   account = new Account
   {
    Name = "Contoso, Ltd.",
    Address1_County = "Saint Louis County"
   };
   _recordIds.Add(_service.Create(account), Account.EntityLogicalName);

   Contact contact = new Contact
   {
    FirstName = "Joe",
    Address1_City = "Redmond",
   };
   _recordIds.Add(_service.Create(contact), Contact.EntityLogicalName);
   contact = new Contact
   {
    FirstName = "John",
    Address1_City = "Redmond",
   };
   _recordIds.Add(_service.Create(contact), Contact.EntityLogicalName);
   contact = new Contact
   {
    FirstName = "John",
    Address1_City = "Cleveland",
   };
   _recordIds.Add(_service.Create(contact), Contact.EntityLogicalName);
   contact = new Contact
   {
    FirstName = "Joe",
    Address1_City = "Redmond",
   };
   _recordIds.Add(_service.Create(contact), Contact.EntityLogicalName);
   contact = new Contact
   {
    FirstName = "Jim",
    Address1_City = "Redmond",
   };
   _recordIds.Add(_service.Create(contact), Contact.EntityLogicalName);
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
    foreach (var record in _recordIds)
    {
     _service.Delete(record.Value, record.Key);
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

    CreateALinqQuery app = new CreateALinqQuery();
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

// </snippetcreatealinqquery>