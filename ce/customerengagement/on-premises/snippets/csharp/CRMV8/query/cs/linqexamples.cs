// <snippetlinqexamples>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

using System.Linq;     //namespace for LINQ queries
namespace Microsoft.Crm.Sdk.Samples
{
 /// <summary>
 /// Demonstrates basic and complex LINQ queries used with Microsoft Dynamics CRM
 /// </summary>
 /// <remarks>
 /// At run-time, you will be given the option to delete all the
 /// database records created by this program.</remarks>
 public class LINQ101
 {
  #region Class Level Members
  private Guid _contactId1;
  private Guid _contactId2;
  private Guid _contactId3;
  private Guid _contactId4;
  private Guid _accountId1;
  private Guid _accountId2;
  private Guid _incidentId1;
  private Guid _incidentId2;
  private Guid _leadId;

  private OrganizationServiceProxy _serviceProxy;

  #endregion Class Level Members

  #region How To Sample Code
  /// <summary>
  /// This method first connects to the Organization service. Afterwards,
  /// a series of LINQ queries are performed.
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

     CreateRequiredRecords();

     #region EarlyBoundExamples

     // *****************************************************************************************************************
     //    LNQ    Simple where clause 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Accounts using one where clause");
     System.Console.WriteLine("======================================");

     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_where1 = from a in svcContext.AccountSet
                         where a.Name.Contains("Contoso")
                         select a;
      foreach (var a in query_where1)
      {
       System.Console.WriteLine(a.Name + " " + a.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     // List of Accounts using where clause 1
     //======================================
     //Contoso Ltd Redmond
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ    Simple where clause 2
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Accounts using two where clauses");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_where2 = from a in svcContext.AccountSet
                         where a.Name.Contains("Contoso")
                         where a.Address1_City == "Redmond"
                         select a;

      foreach (var a in query_where2)
      {
       System.Console.WriteLine(a.Name + " " + a.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //     List of Accounts using where clause 2
     //======================================
     //Contoso Ltd Redmond
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ    Join and simple where clause query
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Account and Contact Info using where clause");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_where3 = from c in svcContext.ContactSet
                         join a in svcContext.AccountSet
                         on c.ContactId equals a.PrimaryContactId.Id
                         where a.Name.Contains("Contoso")
                         where c.LastName.Contains("Smith")
                         select new
                         {
                          account_name = a.Name,
                          contact_name = c.LastName
                         };

      foreach (var c in query_where3)
      {
       System.Console.WriteLine("acct: " +
        c.account_name +
        "\t\t\t" +
        "contact: " +
        c.contact_name);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Account and Contact Info using where clause
     //======================================
     //acct: Contoso Ltd                       contact: Smith
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the Distinct operator (returns only one of duplicate elements)
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using Distinct operator");
     System.Console.WriteLine("======================================");

     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_distinct = (from c in svcContext.ContactSet
                            select c.LastName).Distinct();
      foreach (var c in query_distinct)
      {
       System.Console.WriteLine(c);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //     List of Contact Info using Distinct operator
     //======================================
     //Parker
     //Smith
     //Wilcox
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ    Simple inner join 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact and Account Info Using join 1 ");
     System.Console.WriteLine("==================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_join1 = from c in svcContext.ContactSet
                        join a in svcContext.AccountSet
                       on c.ContactId equals a.PrimaryContactId.Id
                        select new
                        {
                         c.FullName,
                         c.Address1_City,
                         a.Name,
                         a.Address1_Name
                        };
      foreach (var c in query_join1)
      {
       System.Console.WriteLine("acct: " +
        c.Name +
        "\t\t\t" +
        "contact: " +
        c.FullName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact and Account Info Using join 1
     //==================================
     //acct: Contoso Ltd                       contact: Brian Smith
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ                  Multiple join 4
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact, Account, Lead Info using multiple join 4");
     System.Console.WriteLine("==================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_join4 = from a in svcContext.AccountSet
                        join c in svcContext.ContactSet
                        on a.PrimaryContactId.Id equals c.ContactId
                        join l in svcContext.LeadSet
                        on a.OriginatingLeadId.Id equals l.LeadId
                        select new
                        {
                         contact_name = c.FullName,
                         account_name = a.Name,
                         lead_name = l.FullName
                        };
      foreach (var c in query_join4)
      {
       System.Console.WriteLine(c.contact_name +
        "  " +
        c.account_name +
        "  " +
        c.lead_name);
      }
     }
     System.Console.WriteLine("==================================");
     // OUTPUT:
     //List of Contact, Account, Lead Info using multiple join 4
     //==================================
     //Brian Smith  Contoso Ltd  Diogo Andrade
     //==================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ                  Self join 5
     // *****************************************************************************************************************
     System.Console.WriteLine();
     System.Console.WriteLine("List of Account Info using self join 5");
     System.Console.WriteLine("==================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_join5 = from a in svcContext.AccountSet
                        join a2 in svcContext.AccountSet
                        on a.ParentAccountId.Id equals a2.AccountId

                        select new
                        {
                         account_name = a.Name,
                         account_city = a.Address1_City
                        };
      foreach (var c in query_join5)
      {
       System.Console.WriteLine(c.account_name + "  " + c.account_city);
      }
     }
     System.Console.WriteLine("==================================");
     // OUTPUT:
     //List of Account Info using self join 5
     //==================================
     //Contoso Ltd  Redmond
     //==================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ                  Double join 6
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using double join 6");
     System.Console.WriteLine("==================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_join6 = from c in svcContext.ContactSet
                        join a in svcContext.AccountSet
                        on c.ContactId equals a.PrimaryContactId.Id
                        join a2 in svcContext.AccountSet
                        on a.ParentAccountId.Id equals a2.AccountId
                        select new
                        {
                         contact_name = c.FullName,
                         account_name = a.Name
                        };
      foreach (var c in query_join6)
      {
       System.Console.WriteLine(c.contact_name + "  " + c.account_name);
      }
     }
     System.Console.WriteLine("==================================");
     // OUTPUT:     
     //List of Contact Info using double join 6
     //==================================
     //Brian Smith  Contoso Ltd
     //==================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ                  Entity Fields join 7
     // *****************************************************************************************************************
     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using entity field join 7");
     System.Console.WriteLine("==================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var list_join = (from a in svcContext.AccountSet
                       join c in svcContext.ContactSet
                       on a.PrimaryContactId.Id equals c.ContactId
                       where a.Name == "Contoso Ltd" &&
                       a.Address1_Name == "Contoso Pharmaceuticals"
                       select a).ToList();
      foreach (var c in list_join)
      {
       System.Console.WriteLine("Account " + list_join[0].Name
           + " and it's primary contact "
           + list_join[0].PrimaryContactId.Id);
      }
     }
     System.Console.WriteLine("==================================");
     // OUTPUT:
     // Account Contoso Ltd and it's primary contact 918228af-04a1-e011-b1b7-00155dba3818
     //==================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ                  Left join 8
     //  A left join is designed to return parents with and without children from two sources.
     //   There is a correlation between parent and child, but no child may actually exist.
     // *****************************************************************************************************************
     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using left join 8");
     System.Console.WriteLine("==================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_join8 = from a in svcContext.AccountSet
                        join c in svcContext.ContactSet
                        on a.PrimaryContactId.Id equals c.ContactId
                        into gr
                        from c_joined in gr.DefaultIfEmpty()
                        select new
                        {
                         contact_name = c_joined.FullName,
                         account_name = a.Name
                        };
      foreach (var c in query_join8)
      {
       System.Console.WriteLine(c.contact_name + "  " + c.account_name);
      }
     }
     System.Console.WriteLine("==================================");
     // OUTPUT:
     //List of Contact Info using left join 8
     //==================================
     //  Coho Winery
     //Brian Smith  Contoso Ltd
     //==================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the Equals operator 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using Equals operator 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_equals1 = from c in svcContext.ContactSet
                          where c.FirstName.Equals("Colin")
                          select new
                          {
                           c.FirstName,
                           c.LastName,
                           c.Address1_City
                          };
      foreach (var c in query_equals1)
      {
       System.Console.WriteLine(c.FirstName +
        " " + c.LastName +
        " " + c.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     // List of Contact Info using Equals operator 1
     //======================================
     //Colin Wilcox Redmond
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the Equals operator 2
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using Equals operator 2");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_equals2 = from c in svcContext.ContactSet
                          where c.FamilyStatusCode.Equals(3)
                          select new
                          {
                           c.FirstName,
                           c.LastName,
                           c.Address1_City
                          };
      foreach (var c in query_equals2)
      {
       System.Console.WriteLine(c.FirstName +
        " " + c.LastName +
        " " + c.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     // List of Contact Info using Equals operator 2
     //======================================
     //Brian Smith Bellevue
     //Darren Parker Kirkland
     //Ben Smith Kirkland
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the not equals operator 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using not equals operator 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_ne1 = from c in svcContext.ContactSet
                      where c.Address1_City != "Redmond"
                      select new
                      {
                       c.FirstName,
                       c.LastName,
                       c.Address1_City
                      };
      foreach (var c in query_ne1)
      {
       System.Console.WriteLine(c.FirstName + " " +
        c.LastName + " " + c.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     // List of Contact Info using not equals operator 1
     //======================================
     //Brian Smith Bellevue
     //Darren Parker Kirkland
     //Ben Smith Kirkland
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the not equals operator 2
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using not equals operator 2");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_ne2 = from c in svcContext.ContactSet
                      where !c.FirstName.Equals("Colin")
                      select new
                      {
                       c.FirstName,
                       c.LastName,
                       c.Address1_City
                      };

      foreach (var c in query_ne2)
      {
       System.Console.WriteLine(c.FirstName + " " +
        c.LastName + " " + c.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //     List of Contact Info using not equals operator 2
     //======================================
     //Brian Smith Bellevue
     //Darren Parker Kirkland
     //Ben Smith Kirkland
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //              LINQ      Method-based LINQ query with where clause
     // *****************************************************************************************************************
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var methodResults = svcContext.ContactSet
       .Where(a => a.LastName == "Smith");
      var methodResults2 = svcContext.ContactSet
       .Where(a => a.LastName.StartsWith("Smi"));
      Console.WriteLine();
      Console.WriteLine("Method query using Lambda expression");
      Console.WriteLine("---------------------------------------");
      foreach (var a in methodResults)
      {
       Console.WriteLine("Name: " + a.FirstName + " " + a.LastName);
      }
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("Method query 2 using Lambda expression");
      Console.WriteLine("---------------------------------------");
      foreach (var a in methodResults2)
      {
       Console.WriteLine("Name: " + a.Attributes["firstname"] +
        " " + a.Attributes["lastname"]);
      }
     }
     Console.WriteLine("---------------------------------------");
     // OUTPUT:
     //Method query using Lambda expression
     //---------------------------------------
     //Name: Brian Smith
     //Name: Ben Smith
     //---------------------------------------
     //Method query 2 using Lambda expression
     //---------------------------------------
     //Name: Brian Smith
     //Name: Ben Smith
     //---------------------------------------

     // *****************************************************************************************************************
     //    LNQ        Using the greater than operator 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using greater than operator 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_gt1 = from c in svcContext.ContactSet
                      where c.Anniversary > new DateTime(2010, 2, 5)
                      select new
                      {
                       c.FirstName,
                       c.LastName,
                       c.Address1_City
                      };

      foreach (var c in query_gt1)
      {
       System.Console.WriteLine(c.FirstName + " " +
        c.LastName + " " + c.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using greater than operator 1
     //======================================
     //Colin Wilcox Redmond
     //Brian Smith Bellevue
     //Darren Parker Kirkland
     //Ben Smith Kirkland
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the greater than operator 2
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using greater than operator 2");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_gt2 = from c in svcContext.ContactSet
                      where c.CreditLimit.Value > 20000
                      select new
                      {
                       c.FirstName,
                       c.LastName,
                       c.Address1_City
                      };
      foreach (var c in query_gt2)
      {
       System.Console.WriteLine(c.FirstName + " " +
        c.LastName + " " + c.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //     List of Contact Info using greater than operator 2
     //======================================
     //Brian Smith Bellevue
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the ge and le operators 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the ge and le operators 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_gele1 = from c in svcContext.ContactSet
                        where c.CreditLimit.Value >= 200 &&
                        c.CreditLimit.Value <= 400
                        select new
                        {
                         c.FirstName,
                         c.LastName
                        };
      foreach (var c in query_gele1)
      {
       System.Console.WriteLine(c.FirstName + " " + c.LastName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //     List of Contact Info using the ge and le operators 1
     //======================================
     //Colin Wilcox
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the contains operator 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the contains operator 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_contains1 = from c in svcContext.ContactSet
                            where c.Description.Contains("Alpine")
                            select new
                            {
                             c.FirstName,
                             c.LastName
                            };
      foreach (var c in query_contains1)
      {
       System.Console.WriteLine(c.FirstName + " " + c.LastName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using the contains operator 1
     //======================================
     //Colin Wilcox
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the negated contains operator 2
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the negated contains operator 2");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_contains2 = from c in svcContext.ContactSet
                            where !c.Description.Contains("Coho")
                            select new
                            {
                             c.FirstName,
                             c.LastName
                            };
      foreach (var c in query_contains2)
      {
       System.Console.WriteLine(c.FirstName + " " + c.LastName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using the negated contains operator 2
     //======================================
     //Colin Wilcox
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the StartsWith operator 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the StartsWith operator 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_startswith1 = from c in svcContext.ContactSet
                              where c.FirstName.StartsWith("Bri")
                              select new
                              {
                               c.FirstName,
                               c.LastName
                              };
      foreach (var c in query_startswith1)
      {
       System.Console.WriteLine(c.FirstName + " " + c.LastName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using the StartsWith operator 1
     //======================================
     //Brian Smith
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the endswith operator 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the EndsWith operator 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_endswith1 = from c in svcContext.ContactSet
                            where c.LastName.EndsWith("cox")
                            select new
                            {
                             c.FirstName,
                             c.LastName
                            };
      foreach (var c in query_endswith1)
      {
       System.Console.WriteLine(c.FirstName + " " + c.LastName);
      }
     }

     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using the EndsWith operator 1
     //======================================
     //Colin Wilcox
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the && and || operators 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the && and || operators 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_andor1 = from c in svcContext.ContactSet
                         where ((c.Address1_City == "Redmond" ||
                         c.Address1_City == "Bellevue") &&
                         (c.CreditLimit.Value != null &&
                         c.CreditLimit.Value >= 200))
                         select c;

      foreach (var c in query_andor1)
      {
       System.Console.WriteLine(c.LastName + ", " + c.FirstName + " " +
        c.Address1_City + " " + c.CreditLimit.Value);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     // List of Contact Info using the && and || operators 1
     //======================================
     //Wilcox, Colin Redmond 300.0000
     //Smith, Brian Bellevue 30000.0000
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the orderby operator 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the orderby operator 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_orderby1 = from c in svcContext.ContactSet
                           where !c.CreditLimit.Equals(null)
                           orderby c.CreditLimit descending
                           select new
                           {
                            limit = c.CreditLimit,
                            first = c.FirstName,
                            last = c.LastName
                           };
      foreach (var c in query_orderby1)
      {
       System.Console.WriteLine(c.limit.Value + " " +
        c.last + ", " + c.first);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using the orderby operator 1
     //======================================
     //30000.0000 Smith, Brian
     //12000.0000 Smith, Ben
     //10000.0000 Parker, Darren
     //300.0000 Wilcox, Colin
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the orderby operator 2
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the orderby operator 2");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_orderby2 = from c in svcContext.ContactSet
                           orderby c.LastName descending,
                           c.FirstName ascending
                           select new
                           {
                            first = c.FirstName,
                            last = c.LastName
                           };

      foreach (var c in query_orderby2)
      {
       System.Console.WriteLine(c.last + ", " + c.first);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using the orderby operator 2
     //======================================
     //Wilcox, Colin
     //Smith, Ben
     //Smith, Brian
     //Parker, Darren
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the First and Single operators 
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("==========================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      Contact firstcontact = svcContext.ContactSet.First();

      Contact singlecontact = svcContext.ContactSet.Single(c => c.ContactId == _contactId1);
      System.Console.WriteLine(firstcontact.LastName + ", " +
       firstcontact.FirstName + " is the first contact");
      System.Console.WriteLine("==========================");
      System.Console.WriteLine(singlecontact.LastName + ", " +
       singlecontact.FirstName + " is the single contact");
     }
     System.Console.WriteLine("======================================");
     // OUTPUT:
     //==========================
     //Wilcox, Colin is the first contact
     //==========================
     //Wilcox, Colin is the single contact
     //======================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Retrieving formatted values 1
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("Retrieving formatted values 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var list_retrieve1 = from c in svcContext.ContactSet
                           where c.ContactId == _contactId1
                           select new { StatusReason = c.FormattedValues["statuscode"] };
      foreach (var c in list_retrieve1)
      {
       System.Console.WriteLine("Status: " + c.StatusReason);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //Retrieving formatted values 1
     //======================================
     //Status: Active
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the Skip and Take operators (non-paging)
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the Skip and Take operators");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {

      var query_skip = (from c in svcContext.ContactSet
                        where c.LastName != "Parker"
                        orderby c.FirstName
                        select new
                            {
                             last = c.LastName,
                             first = c.FirstName
                            }).Skip(2).Take(2);
      foreach (var c in query_skip)
      {
       System.Console.WriteLine(c.first + " " + c.last);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using the Skip and Take operators
     //======================================
     //Colin Wilcox
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the FirstOrDefault and SingleOrDefault operators 
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("==========================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {

      Contact firstorcontact = svcContext.ContactSet.FirstOrDefault();

      Contact singleorcontact = svcContext.ContactSet
       .SingleOrDefault(c => c.ContactId == _contactId1);


      System.Console.WriteLine(firstorcontact.FullName +
       " is the first contact");
      System.Console.WriteLine("==========================");
      System.Console.WriteLine(singleorcontact.FullName +
       " is the single contact");
     }
     System.Console.WriteLine("======================================");
     // OUTPUT:
     //==========================
     //Colin Wilcox is the first contact
     //==========================
     //Colin Wilcox is the single contact
     //======================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using a self join with a condition on the linked entity 
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using a self join with a condition on the linked entity");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_joincond = from a1 in svcContext.AccountSet
                           join a2 in svcContext.AccountSet
                           on a1.ParentAccountId.Id equals a2.AccountId
                           where a2.AccountId == _accountId1
                           select new { Account = a1, Parent = a2 };
      foreach (var a in query_joincond)
      {
       System.Console.WriteLine(a.Account.Name + " " + a.Parent.Name);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using a self join with a condition on the linked entity
     //======================================
     //Contoso Ltd Coho Winery
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using a transformation in the where clause
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using a transformation in the where clause");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_wheretrans = from c in svcContext.ContactSet
                             where c.ContactId == _contactId1 &&
                             c.Anniversary > DateTime.Parse("1/1/2010")
                             select new
                             {
                              c.FirstName,
                              c.LastName
                             };
      foreach (var c in query_wheretrans)
      {
       System.Console.WriteLine(c.FirstName + " " + c.LastName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     // List of Contact Info using a transformation in the where clause
     //======================================
     //Colin Wilcox
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using a lookup value to order by
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Account Info using a lookup value to order by");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_orderbylookup = from a in svcContext.AccountSet
                                where a.Address1_Name == "Contoso Pharmaceuticals"
                                orderby a.PrimaryContactId
                                select new
                                {
                                 a.Name,
                                 a.Address1_City
                                };
      foreach (var a in query_orderbylookup)
      {
       System.Console.WriteLine(a.Name + " " + a.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     // List of Account Info using a lookup value to order by
     //======================================
     //Contoso Ltd Redmond
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using a picklist to order by
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using a picklist to order by");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_orderbypicklist = from c in svcContext.ContactSet
                                  where c.LastName != "Parker" &&
                                  c.AccountRoleCode != null
                                  orderby c.AccountRoleCode, c.FirstName
                                  select new
                                  {
                                   AccountRole = c.FormattedValues["accountrolecode"],
                                   c.FirstName,
                                   c.LastName
                                  };
      foreach (var c in query_orderbypicklist)
      {
       System.Console.WriteLine(c.AccountRole + " " +
        c.FirstName + " " + c.LastName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using a picklist to order by
     //======================================
     //Decision Maker Colin Wilcox
     //Employee Ben Smith
     //Employee Brian Smith
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using a paging sort 1 
     //            (Multi-column sort with extra condition)
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using a paging sort 1");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_pagingsort1 = (from c in svcContext.ContactSet
                               where c.LastName != "Parker"
                               orderby c.LastName ascending,
                               c.FirstName descending
                               select new { c.FirstName, c.LastName })
                               .Skip(2).Take(2);
      foreach (var c in query_pagingsort1)
      {
       System.Console.WriteLine(c.FirstName + " " + c.LastName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //     List of Contact Info using a paging sort 1
     //======================================
     //Colin Wilcox
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using a paging sort 2 
     //    (Page and sort where the column being sorted is different from the column being retrieved
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using a paging sort 2");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_pagingsort2 = (from c in svcContext.ContactSet
                               where c.LastName != "Parker"
                               orderby c.FirstName descending
                               select new { c.FirstName }).Skip(2).Take(2);
      foreach (var c in query_pagingsort2)
      {
       System.Console.WriteLine(c.FirstName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //     List of Contact Info using a paging sort 2
     //======================================
     //Ben
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using a paging sort 3
     //          (Creates only the first page)
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using a paging sort 3");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_pagingsort3 = (from c in svcContext.ContactSet
                               where c.LastName.StartsWith("W")
                               orderby c.MiddleName ascending,
                               c.FirstName descending
                               select new
                               {
                                c.FirstName,
                                c.MiddleName,
                                c.LastName
                               }).Take(10);
      foreach (var c in query_pagingsort3)
      {
       System.Console.WriteLine(c.FirstName + " " +
        c.MiddleName + " " + c.LastName);
      }
     }
     System.Console.WriteLine("=====================================");

     // OUTPUT:
     //List of Contact Info using a paging sort 3
     //======================================
     //Colin  Wilcox
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Retrieving related entity columns (for 1 to N relationships)
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact and Account Info by retrieving related entity columns");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_retrieve1 = from c in svcContext.ContactSet
                            join a in svcContext.AccountSet
                            on c.ContactId equals a.PrimaryContactId.Id
                            where c.ContactId != _contactId1
                            select new { Contact = c, Account = a };
      foreach (var c in query_retrieve1)
      {
       System.Console.WriteLine("Acct: " + c.Account.Name +
        "\t\t" + "Contact: " + c.Contact.FullName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //     List of Contact and Account Info by retrieving related entity columns
     //======================================
     //Acct: Contoso Ltd               Contact: Brian Smith
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using .Value to retrieve the value of an attribute
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using .Value to retrieve the value of an attribute");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {

      var query_value = from c in svcContext.ContactSet
                        where c.ContactId != _contactId2
                        select new
                        {
                         ContactId = c.ContactId != null ?
                          c.ContactId.Value : Guid.Empty,
                         NumberOfChildren = c.NumberOfChildren != null ?
                          c.NumberOfChildren.Value : default(int),
                         CreditOnHold = c.CreditOnHold != null ?
                          c.CreditOnHold.Value : default(bool),
                         Anniversary = c.Anniversary != null ?
                          c.Anniversary.Value : default(DateTime)
                        };

      foreach (var c in query_value)
      {
       System.Console.WriteLine(c.ContactId + " " + c.NumberOfChildren + 
        " " + c.CreditOnHold + " " + c.Anniversary);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using .Value to retrieve the value of an attribute
     //======================================
     //8f8228af-04a1-e011-b1b7-00155dba3818 1 False 3/5/2010 8:00:00 AM
     //938228af-04a1-e011-b1b7-00155dba3818 2 False 10/5/2010 7:00:00 AM
     //958228af-04a1-e011-b1b7-00155dba3818 2 True 7/5/2010 7:00:00 AM
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Multiple projections, new data type casting to different types
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using multiple projections");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_projections = from c in svcContext.ContactSet
                              where c.ContactId == _contactId1
                              && c.NumberOfChildren != null && 
                              c.Anniversary.Value != null
                              select new
                              {
                               Contact = new Contact { 
                                LastName = c.LastName, 
                                NumberOfChildren = c.NumberOfChildren 
                               },
                               NumberOfChildren = (double)c.NumberOfChildren,
                               Anniversary = c.Anniversary.Value.AddYears(1),
                              };
      foreach (var c in query_projections)
      {
       System.Console.WriteLine(c.Contact.LastName + " " + 
        c.NumberOfChildren + " " + c.Anniversary);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using multiple projections
     //======================================
     //Wilcox 1 3/5/2011 8:00:00 AM
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the GetAttributeValue method
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using the GetAttributeValue method");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_getattrib = from c in svcContext.ContactSet
                            where c.GetAttributeValue<Guid>("contactid") != _contactId1
                            select new
                            {
                             ContactId = c.GetAttributeValue<Guid?>("contactid"),
                             NumberOfChildren = c.GetAttributeValue<int?>("numberofchildren"),
                             CreditOnHold = c.GetAttributeValue<bool?>("creditonhold"),
                             Anniversary = c.GetAttributeValue<DateTime?>("anniversary"),
                            };

      foreach (var c in query_getattrib)
      {
       System.Console.WriteLine(c.ContactId + " " + c.NumberOfChildren + 
        " " + c.CreditOnHold + " " + c.Anniversary);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using the GetAttributeValue method
     //======================================
     //918228af-04a1-e011-b1b7-00155dba3818 2 False 4/5/2010 7:00:00 AM
     //938228af-04a1-e011-b1b7-00155dba3818 2 False 10/5/2010 7:00:00 AM
     //958228af-04a1-e011-b1b7-00155dba3818 2 True 7/5/2010 7:00:00 AM
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using math operations
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using math operations");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_math = from c in svcContext.ContactSet
                       where c.ContactId != _contactId2
                       && c.Address1_Latitude != null && 
                       c.Address1_Longitude != null
                       select new
                       {
                        Round = Math.Round(c.Address1_Latitude.Value),
                        Floor = Math.Floor(c.Address1_Latitude.Value),
                        Ceiling = Math.Ceiling(c.Address1_Latitude.Value),
                        Abs = Math.Abs(c.Address1_Latitude.Value),
                       };
      foreach (var c in query_math)
      {
       System.Console.WriteLine(c.Round + " " + c.Floor + 
        " " + c.Ceiling + " " + c.Abs);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //     List of Contact Info using math operations
     //======================================
     //48 47 48 47.67417
     //48 47 48 47.61056
     //48 47 48 47.61056
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using multiple select and where clauses
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Incidents using multiple select and where clauses");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_multiselect = svcContext.IncidentSet
                             .Where(i => i.IncidentId != _incidentId1)
                             .Select(i => i.incident_customer_accounts)
                             .Where(a => a.AccountId != _accountId2)
                             .Select(a => a.account_primary_contact)
                             .OrderBy(c => c.FirstName)
                             .Select(c => c.ContactId);
      foreach (var c in query_multiselect)
      {
       System.Console.WriteLine(c.GetValueOrDefault());
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Incidents using multiple select and where clauses
     //======================================
     //918228af-04a1-e011-b1b7-00155dba3818
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using SelectMany
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Account Info using SelectMany");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_selectmany = svcContext.ContactSet
                             .Where(c => c.ContactId != _contactId2)
                             .SelectMany(c => c.account_primary_contact)
                             .OrderBy(a => a.Name);
      foreach (var c in query_selectmany)
      {
       System.Console.WriteLine(c.AccountId + " " + c.Name);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Account Info using SelectMany
     //======================================
     //9b8228af-04a1-e011-b1b7-00155dba3818 Contoso Ltd
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using String operations
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using String operations");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_string = from c in svcContext.ContactSet
                         where c.ContactId == _contactId2
                         select new
                         {
                          IndexOf = c.FirstName.IndexOf("contact"),
                          Insert = c.FirstName.Insert(1, "Insert"),
                          Remove = c.FirstName.Remove(1, 1),
                          Substring = c.FirstName.Substring(1, 1),
                          ToUpper = c.FirstName.ToUpper(),
                          ToLower = c.FirstName.ToLower(),
                          TrimStart = c.FirstName.TrimStart(),
                          TrimEnd = c.FirstName.TrimEnd(),
                         };

      foreach (var c in query_string)
      {
       System.Console.WriteLine(c.IndexOf + "\n" + c.Insert + "\n" + 
        c.Remove + "\n" + c.Substring + "\n"
                                + c.ToUpper + "\n" + c.ToLower + 
                                "\n" + c.TrimStart + " " + c.TrimEnd);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using String operations
     //======================================
     //-1
     //BInsertrian
     //Bian
     //r
     //BRIAN
     //brian
     //Brian Brian
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using Two Where Clauses
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Account and Contact Info using two where clauses");
     System.Console.WriteLine("======================================");
     using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
     {
      var query_twowhere = from a in svcContext.AccountSet
                           join c in svcContext.ContactSet 
                           on a.PrimaryContactId.Id equals c.ContactId
                           where c.LastName == "Smith" && c.CreditOnHold != null
                           where a.Name == "Contoso Ltd"
                           orderby a.Name
                           select a;
      foreach (var c in query_twowhere)
      {
       System.Console.WriteLine(c.AccountId + " " + c.Name);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:  
     //List of Account and Contact Info using two where clauses
     //======================================
     //9b8228af-04a1-e011-b1b7-00155dba3818 Contoso Ltd
     //=====================================
     System.Console.WriteLine();


     #endregion EarlyBoundExamples

     #region LateBoundExamples


     // *****************************************************************************************************************
     //    LNQ    Using late-bound entities, simple inner join 2
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact and Account Info using late-bound entities with join 2");
     System.Console.WriteLine("==================================");
     using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
     {
      var query_join2 = from c in orgSvcContext.CreateQuery("contact")
                        join a in orgSvcContext.CreateQuery("account")
                        on c["contactid"] equals a["primarycontactid"]
                        select new
                        {
                         contact_name = c["fullname"],
                         account_name = a["name"]
                        };
      foreach (var c in query_join2)
      {
       System.Console.WriteLine(c.contact_name + "  " + c.account_name);
      }
     }
     System.Console.WriteLine("==================================");
     // OUTPUT:
     //List of Contact and Account Info using late-bound entities with join 2
     //==================================
     //Brian Smith  Contoso Ltd
     //==================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ    Alternative syntax simple inner join 3
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact and Account Info with alternative syntax join 3");
     System.Console.WriteLine("==================================");

     using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
     {
      var query_join3 = from c in orgSvcContext.CreateQuery("contact")
                        join a in orgSvcContext.CreateQuery("account")
                        on c["contactid"] equals (Guid)((EntityReference)a["primarycontactid"]).Id
                        select new
                        {
                         contact_name = c["fullname"],
                         account_name = a["name"]
                        };

      foreach (var c in query_join3)
      {
       System.Console.WriteLine(c.contact_name + "  " + c.account_name);
      }
     }
     System.Console.WriteLine("==================================");
     // OUTPUT:     
     //List of Contact and Account Info with alternative syntax join 3
     //==================================
     //Brian Smith  Contoso Ltd
     //==================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ                  Late binding left join 9
     //  A left join is designed to return parents with and without children from two sources.
     //   There is a correlation between parent and child, but no child may actually exist.
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using late binding left join 9");
     System.Console.WriteLine("==================================");
     using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
     {
      var query_join9 = from a in orgSvcContext.CreateQuery("account")
                        join c in orgSvcContext.CreateQuery("contact") 
                        on a["primarycontactid"] equals c["contactid"] into gr
                        from c_joined in gr.DefaultIfEmpty()
                        select new
                        {
                         account_name = a.Attributes["name"]
                        };
      foreach (var c in query_join9)
      {
       System.Console.WriteLine(c.account_name);
      }
     }
     System.Console.WriteLine("==================================");
     // OUTPUT:
     //List of Contact Info using late binding left join 9
     //==================================
     //Coho Winery
     //Contoso Ltd
     //==================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using late binding and not equals operator 3
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using late binding and not equals operator 3");
     System.Console.WriteLine("======================================");

     using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
     {
      var query_ne3 = from c in orgSvcContext.CreateQuery("contact")
                      where !c["address1_city"].Equals(null)
                      select new
                      {
                       FirstName = c["firstname"],
                       LastName = c["lastname"],
                       Address1_City = c["address1_city"]
                      };
      foreach (var c in query_ne3)
      {
       System.Console.WriteLine(c.FirstName + " " + 
        c.LastName + " " + c.Address1_City);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     // List of Contact Info using late binding and not equals operator 3
     //======================================
     //Colin Wilcox Redmond
     //Brian Smith Bellevue
     //Darren Parker Kirkland
     //Ben Smith Kirkland
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using late binding with Contains operator 3
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using late binding with Contains operator 3");
     System.Console.WriteLine("======================================");
     using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
     {
      var query_contains3 = from c in orgSvcContext.CreateQuery("contact")
                            where ((string)c["description"]).Contains("Coho")
                            select new
                            {
                             firstname = c.Attributes["firstname"],
                             lastname = c.Attributes["lastname"]
                            };
      foreach (var c in query_contains3)
      {
       System.Console.WriteLine(c.firstname + " " + c.lastname);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using late binding with Contains operator 3
     //======================================
     //Brian Smith
     //Darren Parker
     //Ben Smith
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using the GetAttributeValue (late binding) method 1
     // *****************************************************************************************************************     
     System.Console.WriteLine();
     System.Console.WriteLine("List of Contact Info using late binding and the GetAttributeValue method 2");
     System.Console.WriteLine("======================================");
     using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
     {

      var list_getattrib1 = (from c in orgSvcContext.CreateQuery("contact")
                             where c.GetAttributeValue<Guid?>("contactid") != _contactId1
                             select new { 
                              FirstName = c.GetAttributeValue<string>("firstname"), 
                              LastName = c.GetAttributeValue<string>("lastname") 
                             }).ToList();
      foreach (var c in list_getattrib1)
      {
       System.Console.WriteLine(c.FirstName + " " + c.LastName);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Contact Info using late binding and the GetAttributeValue method 2
     //======================================
     //Brian Smith
     //Darren Parker
     //Ben Smith
     //=====================================
     System.Console.WriteLine();

     // *****************************************************************************************************************
     //    LNQ        Using a late binding join
     // *****************************************************************************************************************

     System.Console.WriteLine();
     System.Console.WriteLine("List of Info using a late binding join");
     System.Console.WriteLine("======================================");
     using (OrganizationServiceContext orgSvcContext = new OrganizationServiceContext(_serviceProxy))
     {
      var query_dejoin = from c in orgSvcContext.CreateQuery("contact")
                         join a in orgSvcContext.CreateQuery("account") 
                         on c["contactid"] equals a["primarycontactid"]
                         join l in orgSvcContext.CreateQuery("lead") 
                         on a["originatingleadid"] equals l["leadid"]
                         where (string)c["lastname"] != "Parker"
                         select new { Contact = c, Account = a, Lead = l };
      foreach (var c in query_dejoin)
      {
       System.Console.WriteLine(c.Account.Attributes["name"] + " " + 
        c.Contact.Attributes["fullname"] + " " + c.Lead.Attributes["leadid"]);
      }
     }
     System.Console.WriteLine("=====================================");
     // OUTPUT:
     //List of Info using a late binding join
     //======================================
     //Contoso Ltd Brian Smith 9a8228af-04a1-e011-b1b7-00155dba3818
     //=====================================
     System.Console.WriteLine();

     #endregion LateBoundExamples
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
   Contact contact1 = new Contact
   {
    FirstName = "Colin",
    LastName = "Wilcox",
    Address1_City = "Redmond",
    Address1_StateOrProvince = "WA",
    Address1_PostalCode = "98052",
    Anniversary = new DateTime(2010, 3, 5),
    CreditLimit = new Money(300),
    Description = "Alpine Ski House",
    StatusCode = new OptionSetValue(1),
    AccountRoleCode = new OptionSetValue(1),
    NumberOfChildren = 1,
    Address1_Latitude = 47.6741667,
    Address1_Longitude = -122.1202778,
    CreditOnHold = false
   };
   _contactId1 = _serviceProxy.Create(contact1);

   Console.Write("Created a sample contact 1: {0}, ", contact1.FirstName + " " + contact1.LastName);

   Contact contact2 = new Contact
   {
    FirstName = "Brian",
    LastName = "Smith",
    Address1_City = "Bellevue",
    FamilyStatusCode = new OptionSetValue(3),
    Address1_StateOrProvince = "WA",
    Address1_PostalCode = "98008",
    Anniversary = new DateTime(2010, 4, 5),
    CreditLimit = new Money(30000),
    Description = "Coho Winery",
    StatusCode = new OptionSetValue(1),
    AccountRoleCode = new OptionSetValue(2),
    NumberOfChildren = 2,
    Address1_Latitude = 47.6105556,
    Address1_Longitude = -122.1994444,
    CreditOnHold = false
   };
   _contactId2 = _serviceProxy.Create(contact2);

   Console.Write("Created a sample contact 2: {0}, ", contact2.FirstName + " " + contact2.LastName);

   Contact contact3 = new Contact
   {
    FirstName = "Darren",
    LastName = "Parker",
    Address1_City = "Kirkland",
    FamilyStatusCode = new OptionSetValue(3),
    Address1_StateOrProvince = "WA",
    Address1_PostalCode = "98033",
    Anniversary = new DateTime(2010, 10, 5),
    CreditLimit = new Money(10000),
    Description = "Coho Winery",
    StatusCode = new OptionSetValue(1),
    AccountRoleCode = new OptionSetValue(2),
    NumberOfChildren = 2,
    Address1_Latitude = 47.6105556,
    Address1_Longitude = -122.1994444,
    CreditOnHold = false
   };
   _contactId3 = _serviceProxy.Create(contact3);

   Console.Write("Created a sample contact 3: {0}, ", contact3.FirstName + " " + contact3.LastName);

   Contact contact4 = new Contact
   {
    FirstName = "Ben",
    LastName = "Smith",
    Address1_City = "Kirkland",
    FamilyStatusCode = new OptionSetValue(3),
    Address1_StateOrProvince = "WA",
    Address1_PostalCode = "98033",
    Anniversary = new DateTime(2010, 7, 5),
    CreditLimit = new Money(12000),
    Description = "Coho Winery",
    StatusCode = new OptionSetValue(1),
    AccountRoleCode = new OptionSetValue(2),
    NumberOfChildren = 2,
    Address1_Latitude = 47.6105556,
    Address1_Longitude = -122.1994444,
    CreditOnHold = true
   };
   _contactId4 = _serviceProxy.Create(contact4);

   Console.Write("Created a sample contact 4: {0}, ", contact4.FirstName + " " + contact4.LastName);

   Incident incident1 = new Incident
   {
    Title = "Test Case 1",
    PriorityCode = new OptionSetValue(1), // 1 = High
    CaseOriginCode = new OptionSetValue(1), // 1 = Phone
    CaseTypeCode = new OptionSetValue(2), // 2 = Problem
    Description = "Description for Test Case 1.",
    FollowupBy = DateTime.Now.AddHours(3.0), // follow-up in 3 hours
    CustomerId = new EntityReference(Contact.EntityLogicalName, _contactId2)
   };

   _incidentId1 = _serviceProxy.Create(incident1);

   Console.Write("Created a sample incident 1: {0}, ", incident1.Title);

   Relationship relationship1 = new Relationship("incident_customer_contacts");
   EntityReferenceCollection relatedEntities1 = new EntityReferenceCollection();
   relatedEntities1.Add(new EntityReference(Contact.EntityLogicalName, _contactId1));
   _serviceProxy.Associate(Incident.EntityLogicalName, _incidentId1, relationship1, relatedEntities1);

   Console.Write("Added relationship between incident 1 and contact 1, ");


   Account account1 = new Account
   {
    Name = "Coho Winery",
    Address1_Name = "Coho Vineyard &amp; Winery",
    Address1_City = "Redmond"
   };
   _accountId1 = _serviceProxy.Create(account1);

   Console.Write("Created a sample account 1: {0}, ", account1.Name);

   Incident incident2 = new Incident
   {
    Title = "Test Case 2",
    PriorityCode = new OptionSetValue(1), // 1 = High
    CaseOriginCode = new OptionSetValue(1), // 1 = Phone
    CaseTypeCode = new OptionSetValue(2), // 2 = Problem
    Description = "Description for Sample Case 2.",
    FollowupBy = DateTime.Now.AddHours(3.0), // follow-up in 3 hours
    CustomerId = new EntityReference(Contact.EntityLogicalName, _contactId1)
   };

   _incidentId2 = _serviceProxy.Create(incident2);

   Console.Write("Created a sample incident 2: {0}, ", incident2.Title);

   Relationship relationship2 = new Relationship("incident_customer_accounts");
   EntityReferenceCollection relatedEntities2 = new EntityReferenceCollection();
   relatedEntities2.Add(new EntityReference(Account.EntityLogicalName, _accountId1));
   _serviceProxy.Associate(Incident.EntityLogicalName, _incidentId2, relationship2, relatedEntities2);

   Console.Write("Added relationship between incident 2 and account 1, ");

   Lead lead = new Lead()
   {
    FirstName = "Diogo",
    LastName = "Andrade"
   };
   _leadId = _serviceProxy.Create(lead);
   Console.Write("Created a sample Lead: {0} ", lead.FirstName + " " + lead.LastName);

   Account account2 = new Account
   {
    Name = "Contoso Ltd",
    ParentAccountId = new EntityReference(Account.EntityLogicalName, _accountId1),
    Address1_Name = "Contoso Pharmaceuticals",
    Address1_City = "Redmond",
    OriginatingLeadId = new EntityReference(Lead.EntityLogicalName, _leadId)
   };
   _accountId2 = _serviceProxy.Create(account2);

   Console.Write("Created a sample account 2: {0}, ", account2.Name);

   Relationship relationship3 = new Relationship("account_primary_contact");
   EntityReferenceCollection relatedEntities3 = new EntityReferenceCollection();
   relatedEntities3.Add(new EntityReference(Account.EntityLogicalName, _accountId2));
   _serviceProxy.Associate(Contact.EntityLogicalName, _contactId2, relationship3, relatedEntities3);

   Console.WriteLine("Added relationship between account 2 and contact 2.");
  }
  /// <summary>
  /// Deletes any entity records that were created for this sample.
  /// <param name="prompt">Indicates whether to prompt the user 
  /// to delete the records created in this sample.</param>
  /// </summary>
  public void DeleteRequiredRecords(bool prompt)
  {
   // The three system users that were created by this sample will continue to 
   // exist on your system because system users cannot be deleted in Microsoft
   // Dynamics CRM.  They can only be enabled or disabled.

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
    _serviceProxy.Delete(Account.EntityLogicalName, _accountId2);
    _serviceProxy.Delete(Incident.EntityLogicalName, _incidentId2);
    _serviceProxy.Delete(Account.EntityLogicalName, _accountId1);
    _serviceProxy.Delete(Lead.EntityLogicalName, _leadId);
    _serviceProxy.Delete(Incident.EntityLogicalName, _incidentId1);
    _serviceProxy.Delete(Contact.EntityLogicalName, _contactId4);
    _serviceProxy.Delete(Contact.EntityLogicalName, _contactId3);
    _serviceProxy.Delete(Contact.EntityLogicalName, _contactId2);
    _serviceProxy.Delete(Contact.EntityLogicalName, _contactId1);

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

    LINQ101 app = new LINQ101();
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
   // Additonal exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
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

// </snippetlinqexamples>