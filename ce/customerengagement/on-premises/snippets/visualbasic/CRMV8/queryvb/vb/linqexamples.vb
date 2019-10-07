' <snippetlinqexamples>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
 ''' <summary>
 ''' Demonstrates basic and complex LINQ queries used with Microsoft Dynamics CRM
 ''' </summary>
 ''' <remarks>
 ''' At run-time, you will be given the option to delete all the
 ''' database records created by this program.</remarks>
 Public Class LINQ101
#Region "Class Level Members"
  Private _contactId1 As Guid
  Private _contactId2 As Guid
  Private _contactId3 As Guid
  Private _contactId4 As Guid
  Private _accountId1 As Guid
  Private _accountId2 As Guid
  Private _incidentId1 As Guid
  Private _incidentId2 As Guid
  Private _leadId As Guid

  Private _serviceProxy As OrganizationServiceProxy
#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' This method first connects to the Organization service. Afterwards,
  ''' a series of LINQ queries are performed.
  ''' </summary>
  ''' <param name="serverConfig">Contains server connection information.</param>
  ''' <param name="promptforDelete">When True, the user will be prompted to delete all
  ''' created entities.</param>
  Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                 ByVal promptforDelete As Boolean)
   Try
    ' Connect to the Organization service. 
    ' The using statement assures that the service proxy will be properly disposed.
    _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
    Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     CreateRequiredRecords()

     ' EarlyBoundExamples START ======================================================

     ' *****************************************************************************
     '    LNQ    Simple where clause 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Acounts using where clause 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_where1 = From c In svcContext.AccountSet _
                         Where c.Name.Contains("Contoso") _
                         Select c

      For Each c In query_where1
       Console.WriteLine(c.Name &amp; " " &amp; c.Address1_City)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '  List of Accounts using where clause 1
     ' ======================================
     ' Contoso Ltd Redmond
     ' =====================================
     Console.WriteLine()

     ' ****************************************************************************
     '    LNQ    Simple where clause 2
     ' ****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Acounts using where clause 2")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_where2 = From c In svcContext.AccountSet _
                         Where c.Name.Contains("Contoso") _
                         Where c.Address1_City.Equals("Redmond") _
                         Select c

      For Each c In query_where2
       Console.WriteLine(c.Name &amp; " " &amp; c.Address1_City)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '      List of Accounts using where clause 2
     ' ======================================
     ' Contoso Ltd Redmond
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ    Join and simple where clause query
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Acount and Contact Info using where clause 3")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_where3 = From c In svcContext.ContactSet _
                         Join a In svcContext.AccountSet _
                         On c.ContactId Equals a.account_primary_contact.Id _
                         Where a.Name.Contains("Contoso") _
                         Where c.LastName.Contains("Smith") _
                         Select New With {Key .account_name = a.Name,
                                          Key .contact_name = c.LastName}

      For Each c In query_where3
       Console.WriteLine("acct: " &amp; c.account_name &amp; vbTab &amp; vbTab _
                         &amp; vbTab &amp; "contact: " &amp; c.contact_name)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Account and Contact Info using where clause
     ' ======================================
     ' acct: Contoso Ltd                       contact: Smith
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ   Using the Distinct operator (returns only one of duplicate elements)
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using Distinct operator")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_distinct = ( _
          From c In svcContext.ContactSet _
          Select c.LastName).Distinct()
      For Each c In query_distinct
       Console.WriteLine(c)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '      List of Contact Info using Distinct operator
     ' ======================================
     ' Parker
     ' Smith
     ' Wilcox
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ    Simple inner join 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact and Account Info Using join 1 ")
     Console.WriteLine("==================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_join1 = From c In svcContext.ContactSet _
                        Join a In svcContext.AccountSet _
                        On c.ContactId Equals a.account_primary_contact.Id _
                        Select New With {Key c.FullName, Key c.Address1_City,
                                         Key a.Name, Key a.Address1_Name}
      For Each c In query_join1
       Console.WriteLine("acct: " &amp; c.Name &amp; vbTab &amp; vbTab _
                         &amp; vbTab &amp; "contact: " &amp; c.FullName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact and Account Info Using join 1
     ' ==================================
     ' acct: Contoso Ltd                       contact: Brian Smith
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ                  Multiple join 4
     ' *****************************************************************************
     Console.WriteLine()
     Console.WriteLine(
         "List of Contact, Account, Lead Info using multiple join 4")
     Console.WriteLine("==================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_join4 = From a In svcContext.AccountSet _
                        Join c In svcContext.ContactSet _
                        On a.PrimaryContactId.Id Equals c.ContactId _
                        Join l In svcContext.LeadSet _
                        On a.OriginatingLeadId.Id Equals l.LeadId _
                        Select New With {Key .contact_name = c.FullName,
                                         Key .account_name = a.Name,
                                         Key .lead_name = l.FullName}
      For Each c In query_join4
       Console.WriteLine(c.contact_name &amp; "  " &amp; c.account_name _
                         &amp; "  " &amp; c.lead_name)
      Next c
     End Using
     Console.WriteLine("==================================")
     '  OUTPUT:
     ' List of Contact, Account, Lead Info using multiple join 4
     ' ==================================
     ' Brian Smith  Contoso Ltd  Diogo Andrade
     ' ==================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ                  Self join 5
     ' *****************************************************************************
     Console.WriteLine()
     Console.WriteLine("List of Account Info using self join 5")
     Console.WriteLine("==================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_join5 = From a In svcContext.AccountSet _
                        Join a2 In svcContext.AccountSet _
                        On a.ParentAccountId.Id Equals a2.AccountId _
                        Select New With {
                              Key .account_name = a.Name,
                              Key .account_city = a.Address1_City
                              }
      For Each c In query_join5
       Console.WriteLine(c.account_name &amp; "  " &amp; c.account_city)
      Next c
     End Using
     Console.WriteLine("==================================")
     '  OUTPUT:
     ' List of Account Info using self join 5
     ' ==================================
     ' Contoso Ltd  Redmond
     ' ==================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ                  Double join 6
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using double join 6")
     Console.WriteLine("==================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_join6 = From c In svcContext.ContactSet _
                        Join a In svcContext.AccountSet _
                        On c.ContactId Equals a.PrimaryContactId.Id _
                        Join a2 In svcContext.AccountSet _
                        On a.ParentAccountId.Id Equals a2.AccountId _
                        Select New With {Key .contact_name = c.FullName,
                                         Key .account_name = a.Name}
      For Each c In query_join6
       Console.WriteLine(c.contact_name &amp; "  " &amp; c.account_name)
      Next c
     End Using
     Console.WriteLine("==================================")
     '  OUTPUT:     
     ' List of Contact Info using double join 6
     ' ==================================
     ' Brian Smith  Contoso Ltd
     ' ==================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ                  Entity Fields join 7
     ' *****************************************************************************
     Console.WriteLine()
     Console.WriteLine("List of Account Info using entity field join 7")
     Console.WriteLine("==================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim list_join = ( _
          From a In svcContext.AccountSet _
          Join c In svcContext.ContactSet _
          On a.PrimaryContactId.Id Equals c.ContactId _
          Where a.Name.Equals("Contoso Ltd") _
          And a.Address1_Name.Equals("Contoso Pharmaceuticals") _
          Select a).ToList()
      For Each c In list_join
       Console.WriteLine("Account " &amp; list_join(0).Name _
                         &amp; " and it's primary contact " _
                         &amp; list_join(0).PrimaryContactId.Id.ToString())
      Next c
     End Using
     Console.WriteLine("==================================")
     '  OUTPUT:
     '  Account Contoso Ltd and it's primary contact 918228af-04a1-e011-b1b7-00155dba3818
     ' ==================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ                  Left join 8
     '    A left join is designed to return parents with 
     '    and without children from two sources.
     '    There is a correlation between parent 
     '    and child, but no child may actually exist.
     ' *****************************************************************************
     Console.WriteLine()
     Console.WriteLine("List of Contact Info using left join 8")
     Console.WriteLine("==================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_join8 = From a In svcContext.AccountSet _
                        Group Join c In svcContext.ContactSet _
                        On a.PrimaryContactId.Id Equals c.ContactId Into gr = _
                        Group From c_joined In gr.DefaultIfEmpty() _
                        Select New With {Key .contact_name = c_joined.FullName,
                                         Key .account_name = a.Name}
      For Each c In query_join8
       Console.WriteLine(c.contact_name &amp; "  " &amp; c.account_name)
      Next c
     End Using
     Console.WriteLine("==================================")
     '  OUTPUT:
     ' List of Contact Info using left join 8
     ' ==================================
     '   Coho Winery
     ' Brian Smith  Contoso Ltd
     ' ==================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the Equals operator 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using Equals operator 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_equals1 = From c In svcContext.ContactSet _
                          Where c.FirstName.Equals("Colin") _
                          Select New With {Key c.FirstName,
                                           Key c.LastName,
                                           Key c.Address1_City}
      For Each c In query_equals1
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName &amp; " " _
                         &amp; c.Address1_City)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '  List of Contact Info using Equals operator 1
     ' ======================================
     ' Colin Wilcox Redmond
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the Equals operator 2
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using Equals operator 2")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_equals2 = From c In svcContext.ContactSet _
                          Where c.FamilyStatusCode.Equals(3) _
                          Select New With {Key c.FirstName,
                                           Key c.LastName,
                                           Key c.Address1_City}
      For Each c In query_equals2
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName &amp; " " _
                         &amp; c.Address1_City)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '  List of Contact Info using Equals operator 2
     ' ======================================
     ' Brian Smith Bellevue
     ' Darren Parker Kirkland
     ' Ben Smith Kirkland
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the not equals operator 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using not equals operator 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_ne1 = From c In svcContext.ContactSet _
                      Where c.Address1_City IsNot "Redmond" _
                      Select New With {Key c.FirstName,
                                       Key c.LastName,
                                       Key c.Address1_City}
      For Each c In query_ne1
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName _
                         &amp; " " &amp; c.Address1_City)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '  List of Contact Info using not equals operator 1
     ' ======================================
     ' Brian Smith Bellevue
     ' Darren Parker Kirkland
     ' Ben Smith Kirkland
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the not equals operator 2
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using not equals operator 2")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_ne2 = From c In svcContext.ContactSet _
                      Where (Not c.FirstName.Equals("Colin")) _
                      Select New With {Key c.FirstName,
                                       Key c.LastName,
                                       Key c.Address1_City}

      For Each c In query_ne2
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName &amp; " " _
                         &amp; c.Address1_City)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '      List of Contact Info using not equals operator 2
     ' ======================================
     ' Brian Smith Bellevue
     ' Darren Parker Kirkland
     ' Ben Smith Kirkland
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '              LINQ      Method-based LINQ query with where clause
     ' *****************************************************************************
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim methodResults = svcContext.ContactSet _
                          .Where(Function(a) a.LastName.Equals("Smith"))
      Dim methodResults2 = svcContext.ContactSet _
                           .Where(Function(a) a.LastName.StartsWith("Smi"))
      Console.WriteLine()
      Console.WriteLine("Method query using Lambda expression")
      Console.WriteLine("---------------------------------------")
      For Each a In methodResults
       Console.WriteLine("Name: " &amp; a.FirstName &amp; " " &amp; a.LastName)
      Next a
      Console.WriteLine("---------------------------------------")
      Console.WriteLine("Method query 2 using Lambda expression")
      Console.WriteLine("---------------------------------------")
      For Each a In methodResults2
       Console.WriteLine("Name: " &amp; a.Attributes("firstname").ToString() _
                         &amp; " " &amp; a.Attributes("lastname").ToString())
      Next a
     End Using
     Console.WriteLine("---------------------------------------")
     '  OUTPUT:
     ' Method query using Lambda expression
     ' ---------------------------------------
     ' Name: Brian Smith
     ' Name: Ben Smith
     ' ---------------------------------------
     ' Method query 2 using Lambda expression
     ' ---------------------------------------
     ' Name: Brian Smith
     ' Name: Ben Smith
     ' ---------------------------------------

     ' *****************************************************************************
     '    LNQ        Using the greater than operator 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using greater than operator 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_gt1 = From c In svcContext.ContactSet _
                      Where c.Anniversary > New Date(2010, 2, 5) _
                      Select New With {Key c.FirstName,
                                       Key c.LastName,
                                       Key c.Address1_City}

      For Each c In query_gt1
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName _
                         &amp; " " &amp; c.Address1_City)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using greater than operator 1
     ' ======================================
     ' Colin Wilcox Redmond
     ' Brian Smith Bellevue
     ' Darren Parker Kirkland
     ' Ben Smith Kirkland
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the greater than operator 2
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using greater than operator 2")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_gt2 = From c In svcContext.ContactSet _
                      Where c.CreditLimit.Value > 20000 _
                      Select New With {Key c.FirstName,
                                       Key c.LastName,
                                       Key c.Address1_City}
      For Each c In query_gt2
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName _
                         &amp; " " &amp; c.Address1_City)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '      List of Contact Info using greater than operator 2
     ' ======================================
     ' Brian Smith Bellevue
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the ge and le operators 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the ge and le operators 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_gele1 = From c In svcContext.ContactSet _
                        Where c.CreditLimit.Value >= 200 _
                        AndAlso c.CreditLimit.Value <= 400 _
                        Select New With {Key c.FirstName,
                                         Key c.LastName}
      For Each c In query_gele1
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '      List of Contact Info using the ge and le operators 1
     ' ======================================
     ' Colin Wilcox
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the contains operator 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the contains operator 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_contains1 = From c In svcContext.ContactSet _
                            Where c.Description.Contains("Alpine") _
                            Select New With {Key c.FirstName,
                                             Key c.LastName}
      For Each c In query_contains1
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using the contains operator 1
     ' ======================================
     ' Colin Wilcox
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the negated contains operator 2
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the negated contains operator 2")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_contains2 = From c In svcContext.ContactSet _
                            Where (Not c.Description.Contains("Coho")) _
                            Select New With {Key c.FirstName,
                                             Key c.LastName}
      For Each c In query_contains2
       Console.WriteLine(c.FirstName.ToString() &amp; " " _
                         &amp; c.LastName.ToString())
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using the negated contains operator 2
     ' ======================================
     ' Colin Wilcox
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the StartsWith operator 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the StartsWith operator 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_startswith1 = From c In svcContext.ContactSet _
                              Where c.FirstName.StartsWith("Bri") _
                              Select New With {Key c.FirstName,
                                               Key c.LastName}
      For Each c In query_startswith1
       Console.WriteLine(c.FirstName.ToString() &amp; " " _
                         &amp; c.LastName.ToString())
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using the StartsWith operator 1
     ' ======================================
     ' Brian Smith
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the endswith operator 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the EndsWith operator 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_endswith1 = From c In svcContext.ContactSet _
                            Where c.LastName.EndsWith("cox") _
                            Select New With {Key c.FirstName,
                                             Key c.LastName}
      For Each c In query_endswith1
       Console.WriteLine(c.FirstName.ToString() &amp; " " _
                         &amp; c.LastName.ToString())
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using the EndsWith operator 1
     ' ======================================
     ' Colin Wilcox
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the && and || operators 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the && and || operators 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_andor1 = From c In svcContext.ContactSet _
                         Where c.Address1_City.Equals("Redmond") _
                         OrElse c.Address1_City.Equals("Bellevue") _
                         AndAlso c.CreditLimit.Value >= 200 _
                         Select New With {Key c.FirstName,
                                          Key c.LastName,
                                          Key c.CreditLimit,
                                          Key c.Address1_City}
      For Each c In query_andor1
       Console.WriteLine(c.LastName.ToString() &amp; ", " _
                         &amp; c.FirstName.ToString() &amp; " " _
                         &amp; c.Address1_City.ToString() &amp; " " _
                         &amp; c.CreditLimit.Value.ToString())
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '  List of Contact Info using the && and || operators 1
     ' ======================================
     ' Wilcox, Colin Redmond 300.0000
     ' Smith, Brian Bellevue 30000.0000
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the orderby operator 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the orderby operator 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_orderby1 = From c In svcContext.ContactSet _
                           Where (Not c.CreditLimit.Equals(Nothing)) _
                           Order By c.CreditLimit Descending _
                           Select New With {Key .limit = c.CreditLimit,
                                            Key .first = c.FirstName,
                                            Key .last = c.LastName}
      For Each c In query_orderby1
       Console.WriteLine(c.limit.Value &amp; " " &amp; c.last &amp; ", " _
                         &amp; c.first)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using the orderby operator 1
     ' ======================================
     ' 30000.0000 Smith, Brian
     ' 12000.0000 Smith, Ben
     ' 10000.0000 Parker, Darren
     ' 300.0000 Wilcox, Colin
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the orderby operator 2
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the orderby operator 2")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_orderby2 = From c In svcContext.ContactSet _
                           Order By c.LastName Descending, _
                           c.FirstName Ascending _
                           Select New With {Key .first = c.FirstName,
                                            Key .last = c.LastName}

      For Each c In query_orderby2
       Console.WriteLine(c.last &amp; ", " &amp; c.first)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using the orderby operator 2
     ' ======================================
     ' Wilcox, Colin
     ' Smith, Ben
     ' Smith, Brian
     ' Parker, Darren
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the First and Single operators 
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("==========================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim firstcontact As Contact = svcContext.ContactSet _
                                    .First()
      Console.WriteLine(firstcontact.LastName &amp; ", " _
                        &amp; firstcontact.FirstName _
                        &amp; " is the first contact")
      Console.WriteLine("==========================")
      Dim singlecontact As Contact =
          svcContext.ContactSet _
          .Single(Function(c) c.ContactId.Value.Equals(_contactId1))
      Console.WriteLine(singlecontact.LastName &amp; ", " _
                        &amp; singlecontact.FirstName _
                        &amp; " is the single contact")
     End Using
     Console.WriteLine("======================================")
     '  OUTPUT:
     ' ==========================
     ' Wilcox, Colin is the first contact
     ' ==========================
     ' Wilcox, Colin is the single contact
     ' ======================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Retrieving formatted values 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("Retrieving formatted values 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim list_retrieve1 = From c In svcContext.ContactSet _
                           Where c.ContactId.Value.Equals(_contactId1) _
                           Select New With
                                  {Key .StatusReason =
                                      c.FormattedValues("statuscode")}
      For Each c In list_retrieve1
       Console.WriteLine("Status: " &amp; c.StatusReason)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' Retrieving formatted values 1
     ' ======================================
     ' Status: Active
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the Skip and Take operators (non-paging)
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the Skip and Take operators")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_skip = ( _
          From c In svcContext.ContactSet _
          Where c.LastName IsNot "Parker" _
          Order By c.FirstName _
          Select New With {Key .last = c.LastName,
                           Key .first = c.FirstName}).Skip(2).Take(2)
      For Each c In query_skip
       Console.WriteLine(c.first &amp; " " &amp; c.last)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using the Skip and Take operators
     ' ======================================
     ' Colin Wilcox
     ' =====================================
     Console.WriteLine()







     ' *****************************************************************************
     '    LNQ        Using the FirstOrDefault and SingleOrDefault operators 
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("==========================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim firstorcontact As Contact =
          svcContext.ContactSet.FirstOrDefault()
      Console.WriteLine(firstorcontact.FullName &amp; " is the first contact")

      Console.WriteLine("==========================")
      Dim singleorcontact As Contact =
          svcContext.ContactSet _
          .SingleOrDefault(Function(c) c.ContactId.Value.Equals(_contactId1))
      Console.WriteLine(singleorcontact.FullName &amp; " is the single contact")
     End Using
     Console.WriteLine("======================================")
     '  OUTPUT:
     ' ==========================
     ' Colin Wilcox is the first contact
     ' ==========================
     ' Colin Wilcox is the single contact
     ' ======================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using a self join with a condition on the linked entity 
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine(
         "List of Contact Info using a self join " _
         &amp; "with a condition on the linked entity")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_joincond = From a1 In svcContext.AccountSet _
                           Join a2 In svcContext.AccountSet _
                           On a1.ParentAccountId.Id Equals a2.AccountId _
                           Where a2.AccountId.Value.Equals(_accountId1) _
                           Select New With {Key .Account = a1,
                                            Key .Parent = a2}
      For Each a In query_joincond
       Console.WriteLine(a.Account.Name &amp; " " &amp; a.Parent.Name)
      Next a
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using a self join with a condition on the linked entity
     ' ======================================
     ' Contoso Ltd Coho Winery
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using a transformation in the where clause
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine(
         "List of Contact Info using a transformation in the where clause")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_wheretrans = From c In svcContext.ContactSet _
                             Where c.ContactId.Value.Equals(_contactId1) _
                             AndAlso c.Anniversary > Date.Parse("1/1/2010") _
                             Select New With {Key c.FirstName,
                                              Key c.LastName}
      For Each c In query_wheretrans
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '  List of Contact Info using a transformation in the where clause
     ' ======================================
     ' Colin Wilcox
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using a lookup value to order by
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Account Info using a lookup value to order by")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_orderbylookup = From a In svcContext.AccountSet _
                                Where a.Address1_Name.Equals("Contoso Pharmaceuticals") _
                                Order By a.PrimaryContactId _
                                Select New With {Key a.Name,
                                                 Key a.Address1_City}
      For Each a In query_orderbylookup
       Console.WriteLine(a.Name &amp; " " &amp; a.Address1_City)
      Next a
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '  List of Account Info using a lookup value to order by
     ' ======================================
     ' Contoso Ltd Redmond
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using a picklist to order by
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using a picklist to order by")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_orderbypicklist = From c In svcContext.ContactSet _
                                  Where c.LastName IsNot "Parker" _
                                  AndAlso c.AccountRoleCode IsNot Nothing _
                                  Order By c.AccountRoleCode, c.FirstName _
                                  Select New With
                                         {Key .AccountRole =
                                             c.FormattedValues("accountrolecode"),
                                          Key c.FirstName, Key c.LastName}
      For Each c In query_orderbypicklist
       Console.WriteLine(c.AccountRole &amp; " " &amp; c.FirstName _
                         &amp; " " &amp; c.LastName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using a picklist to order by
     ' ======================================
     ' Decision Maker Colin Wilcox
     ' Employee Ben Smith
     ' Employee Brian Smith
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using a paging sort 1 
     '            (Multi-column sort with extra condition)
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using a paging sort 1")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_pagingsort1 = ( _
          From c In svcContext.ContactSet _
          Where c.LastName IsNot "Parker" _
          Order By c.LastName Ascending, c.FirstName Descending _
          Select New With {Key c.FirstName,
                           Key c.LastName}).Skip(2).Take(2)
      For Each c In query_pagingsort1
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '      List of Contact Info using a paging sort 1
     ' ======================================
     ' Colin Wilcox
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using a paging sort 2 
     '    (Page and sort where the column being sorted 
     '    is different from the column being retrieved
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using a paging sort 2")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_pagingsort2 = ( _
          From c In svcContext.ContactSet _
          Where c.LastName IsNot "Parker" _
          Order By c.FirstName Descending _
          Select New With {Key c.FirstName}).Skip(2).Take(2)
      For Each c In query_pagingsort2
       Console.WriteLine(c.FirstName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '      List of Contact Info using a paging sort 2
     ' ======================================
     ' Ben
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using a paging sort 3
     '          (Creates only the first page)
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using a paging sort 3")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_pagingsort3 = ( _
          From c In svcContext.ContactSet _
          Where c.LastName.StartsWith("W") _
          Order By c.MiddleName Ascending, c.FirstName Descending _
          Select New With {Key c.FirstName,
                           Key c.MiddleName,
                           Key c.LastName}).Take(10)
      For Each c In query_pagingsort3
       Console.WriteLine(c.FirstName &amp; " " &amp; c.MiddleName &amp; " " &amp; c.LastName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using a paging sort 3
     ' ======================================
     ' Colin  Wilcox
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Retrieving related entity columns (for 1 to N relationships)
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine(
         "List of Contact and Account Info by retrieving related entity columns")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_retrieve1 = From c In svcContext.ContactSet _
                            Join a In svcContext.AccountSet _
                            On c.ContactId Equals a.PrimaryContactId.Id _
                            Where Not c.ContactId.Value.Equals(_contactId1) _
                            Select New With {Key .Contact = c,
                                             Key .Account = a}
      For Each c In query_retrieve1
       Console.WriteLine("Acct: " &amp; c.Account.Name &amp; vbTab &amp; vbTab _
                         &amp; "Contact: " &amp; c.Contact.FullName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '      List of Contact and Account Info by retrieving related entity columns
     ' ======================================
     ' Acct: Contoso Ltd               Contact: Brian Smith
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using .Value to retrieve the value of an attribute
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine(
         "List of Contact Info using .Value to retrieve the value of an attribute")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_value = From c In svcContext.ContactSet _
                        Where Not c.ContactId.Value.Equals(_contactId2) _
                        Select New With
                               {Key .ContactId = If(
                                       c.ContactId IsNot Nothing,
                                       c.ContactId.Value,
                                       Guid.Empty),
                                Key .NumberOfChildren = If(
                                    c.NumberOfChildren IsNot Nothing,
                                    c.NumberOfChildren.Value, Nothing),
                                Key .CreditOnHold = If(
                                    c.CreditOnHold IsNot Nothing,
                                    c.CreditOnHold.Value,
                                    Nothing),
                                Key .Anniversary = If(
                                    c.Anniversary IsNot Nothing,
                                    c.Anniversary.Value,
                                    Nothing)}

      For Each c In query_value
       Console.WriteLine(c.ContactId.ToString() &amp; " " _
                         &amp; c.NumberOfChildren &amp; " " _
                         &amp; c.CreditOnHold &amp; " " &amp; c.Anniversary)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using .Value to retrieve the value of an attribute
     ' ======================================
     ' 8f8228af-04a1-e011-b1b7-00155dba3818 1 False 3/5/2010 8:00:00 AM
     ' 938228af-04a1-e011-b1b7-00155dba3818 2 False 10/5/2010 7:00:00 AM
     ' 958228af-04a1-e011-b1b7-00155dba3818 2 True 7/5/2010 7:00:00 AM
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Multiple projections, new data type casting to different types
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using multiple projections")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_projections = From c In svcContext.ContactSet _
                              Where c.ContactId.Value.Equals(_contactId1) _
                              And Not c.NumberOfChildren.Equals(Nothing) _
                              And Not c.Anniversary.Equals(Nothing) _
             Select New With
                    {Key .Contact =
                        New Contact With
                        {.LastName = c.LastName,
                         .NumberOfChildren = c.NumberOfChildren},
                     Key .NumberOfChildren = CDbl(c.NumberOfChildren),
                     Key .Anniversary = c.Anniversary.Value.AddYears(1)}
      For Each c In query_projections
       Console.WriteLine(c.Contact.LastName &amp; " " &amp; c.NumberOfChildren _
                         &amp; " " &amp; c.Anniversary)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using multiple projections
     ' ======================================
     ' Wilcox 1 3/5/2011 8:00:00 AM
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the GetAttributeValue method
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using the GetAttributeValue method")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_getattrib = From c In svcContext.ContactSet _
                            Where Not c.GetAttributeValue(Of Guid)("contactid").Equals( _
                             _contactId1) _
                            Select New With
                                   {Key .ContactId =
                                       c.GetAttributeValue(Of Guid?)("contactid"),
                                    Key .NumberOfChildren =
                                    c.GetAttributeValue(Of Integer?)("numberofchildren"),
                                    Key .CreditOnHold =
                                    c.GetAttributeValue(Of Boolean?)("creditonhold"),
                                    Key .Anniversary =
                                    c.GetAttributeValue(Of Date?)("anniversary")}

      For Each c In query_getattrib
       Console.WriteLine(c.ContactId.ToString() &amp; " " _
                         &amp; c.NumberOfChildren &amp; " " &amp; c.CreditOnHold _
                         &amp; " " &amp; c.Anniversary)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using the GetAttributeValue method
     ' ======================================
     ' 918228af-04a1-e011-b1b7-00155dba3818 2 False 4/5/2010 7:00:00 AM
     ' 938228af-04a1-e011-b1b7-00155dba3818 2 False 10/5/2010 7:00:00 AM
     ' 958228af-04a1-e011-b1b7-00155dba3818 2 True 7/5/2010 7:00:00 AM
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using math operations
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using math operations")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_math = From c In svcContext.ContactSet _
                       Where Not c.ContactId.Value.Equals(_contactId2) _
                       AndAlso c.Address1_Latitude IsNot Nothing _
                       AndAlso c.Address1_Longitude IsNot Nothing _
                       Select New With
                              {Key .Round =
                                  Math.Round(c.Address1_Latitude.Value),
                               Key .Floor =
                                  Math.Floor(c.Address1_Latitude.Value),
                               Key .Ceiling =
                                  Math.Ceiling(c.Address1_Latitude.Value),
                               Key .Abs =
                                  Math.Abs(c.Address1_Latitude.Value)}
      For Each c In query_math
       Console.WriteLine(c.Round &amp; " " &amp; c.Floor &amp; " " _
                         &amp; c.Ceiling &amp; " " &amp; c.Abs)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '      List of Contact Info using math operations
     ' ======================================
     ' 48 47 48 47.67417
     ' 48 47 48 47.61056
     ' 48 47 48 47.61056
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using multiple select and where clauses
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine(
         "List of Incidents using multiple select and where clauses")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_multiselect =
          svcContext.IncidentSet _
          .Where(Function(i) Not i.IncidentId.Value.Equals(_incidentId1)) _
          .Select(Function(i) i.incident_customer_accounts) _
          .Where(Function(a) Not a.AccountId.Value.Equals(_accountId2)) _
          .Select(Function(a) a.account_primary_contact) _
          .OrderBy(Function(c) c.FirstName).Select(Function(c) c.ContactId)
      For Each c In query_multiselect
       Console.WriteLine(c.GetValueOrDefault())
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Incidents using multiple select and where clauses
     ' ======================================
     ' 918228af-04a1-e011-b1b7-00155dba3818
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using SelectMany
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Account Info using SelectMany")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_selectmany =
          svcContext.ContactSet _
          .Where(Function(c) Not c.ContactId.Value.Equals(_contactId2)) _
          .SelectMany(Function(c) c.account_primary_contact) _
          .OrderBy(Function(a) a.Name)
      For Each c In query_selectmany
       Console.WriteLine(c.AccountId.ToString() &amp; " " &amp; c.Name)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Account Info using SelectMany
     ' ======================================
     ' 9b8228af-04a1-e011-b1b7-00155dba3818 Contoso Ltd
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using String operations
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Contact Info using String operations")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_string = From c In svcContext.ContactSet _
                         Where c.ContactId.Value.Equals(_contactId2) _
                         Select New With
                                {Key .IndexOf = c.FirstName.IndexOf("contact"),
                                 Key .Insert = c.FirstName.Insert(1, "Insert"),
                                 Key .Remove = c.FirstName.Remove(1, 1),
                                 Key .Substring = c.FirstName.Substring(1, 1),
                                 Key .ToUpper = c.FirstName.ToUpper(),
                                 Key .ToLower = c.FirstName.ToLower(),
                                 Key .TrimStart = c.FirstName.TrimStart(),
                                 Key .TrimEnd = c.FirstName.TrimEnd()}

      For Each c In query_string
       Console.WriteLine(c.IndexOf &amp; vbLf &amp; c.Insert &amp; vbLf _
                         &amp; c.Remove &amp; vbLf &amp; c.Substring &amp; vbLf _
                         &amp; c.ToUpper &amp; vbLf &amp; c.ToLower &amp; vbLf _
                         &amp; c.TrimStart &amp; " " &amp; c.TrimEnd)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using String operations
     ' ======================================
     ' -1
     ' BInsertrian
     ' Bian
     ' r
     ' BRIAN
     ' brian
     ' Brian Brian
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using Two Where Clauses
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine(
         "List of Account and Contact Info using two where clauses")
     Console.WriteLine("======================================")
     Using svcContext As New ServiceContext(_serviceProxy)
      Dim query_twowhere = From a In svcContext.AccountSet _
                           Join c In svcContext.ContactSet _
                           On a.PrimaryContactId.Id Equals c.ContactId _
                           Where c.LastName.Equals("Smith") _
                           AndAlso c.CreditOnHold IsNot Nothing _
                           Where a.Name.Equals("Contoso Ltd") _
                           Order By a.Name _
                           Select a
      For Each c In query_twowhere
       Console.WriteLine(c.AccountId.ToString() &amp; " " &amp; c.Name)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:  
     ' List of Account and Contact Info using two where clauses
     ' ======================================
     ' 9b8228af-04a1-e011-b1b7-00155dba3818 Contoso Ltd
     ' =====================================
     Console.WriteLine()


     ' EarlyBoundExamples END   ======================================================

     ' LateBoundExamples START  ======================================================


     ' *****************************************************************************
     '    LNQ    Using late-bound entities, simple inner join 2
     ' *****************************************************************************
     Console.WriteLine()
     Console.WriteLine(
         "List of Contact and Account Info using late-bound entities with join 2")
     Console.WriteLine("==================================")
     Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
      Dim query_join2 = From c In orgSvcContext.CreateQuery("contact") _
                        Join a In orgSvcContext.CreateQuery("account") _
                        On c("contactid") Equals a("primarycontactid") _
                        Select New With {Key .contact_name = c("fullname"),
                                         Key .account_name = a("name")}
      For Each c In query_join2
       Console.WriteLine(c.contact_name.ToString() &amp; "  " _
                         &amp; c.account_name.ToString())
      Next c
     End Using
     Console.WriteLine("==================================")
     '  OUTPUT:
     ' List of Contact and Account Info using late-bound entities with join 2
     ' ==================================
     ' Brian Smith  Contoso Ltd
     ' ==================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ    Alternative syntax simple inner join 3
     ' *****************************************************************************
     Console.WriteLine()
     Console.WriteLine(
         "List of Contact and Account Info with alternative syntax join 3")
     Console.WriteLine("==================================")
     Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
      Dim query_join3 = From c In orgSvcContext.CreateQuery("contact") _
                        Join a In orgSvcContext.CreateQuery("account") _
                        On c("contactid") Equals a("primarycontactid") _
                        Select New With {Key .contact_name = c("fullname"),
                                         Key .account_name = a("name")}

      For Each c In query_join3
       Console.WriteLine(c.contact_name.ToString() &amp; "  " _
                         &amp; c.account_name.ToString())
      Next c
     End Using
     Console.WriteLine("==================================")
     '  OUTPUT:     
     ' List of Contact and Account Info with alternative syntax join 3
     ' ==================================
     ' Brian Smith  Contoso Ltd
     ' ==================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ                  Late binding left join 9
     '    A left join is designed to return parents with 
     '    and without children from two sources.
     '    There is a correlation between parent 
     '    and child, but no child may actually exist.
     ' *****************************************************************************
     Console.WriteLine()
     Console.WriteLine("List of Contact Info using late binding left join 9")
     Console.WriteLine("==================================")
     Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
      Dim query_join9 = From a In orgSvcContext.CreateQuery("account") _
                        Group Join c In orgSvcContext.CreateQuery("contact") _
                        On a("primarycontactid") Equals c("contactid") Into gr = _
                        Group From c_joined In gr.DefaultIfEmpty() _
                        Select New With {Key .account_name = a.Attributes("name")}
      For Each c In query_join9
       Console.WriteLine(c.account_name)
      Next c
     End Using
     Console.WriteLine("==================================")
     '  OUTPUT:
     ' List of Contact Info using late binding left join 9
     ' ==================================
     ' Coho Winery
     ' Contoso Ltd
     ' ==================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using late binding and not equals operator 3
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine(
         "List of Contact Info using late binding and not equals operator 3")
     Console.WriteLine("======================================")
     Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
      Dim query_ne3 = From c In orgSvcContext.CreateQuery("contact") _
                      Where (Not c("address1_city").Equals(Nothing)) _
                      Select New With {Key .FirstName = c("firstname"),
                                       Key .LastName = c("lastname"),
                                       Key .Address1_City =
                                       c("address1_city")}
      For Each c In query_ne3
       Console.WriteLine(c.FirstName.ToString() &amp; " " _
                         &amp; c.LastName.ToString() &amp; " " _
                         &amp; c.Address1_City.ToString())
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     '  List of Contact Info using late binding and not equals operator 3
     ' ======================================
     ' Colin Wilcox Redmond
     ' Brian Smith Bellevue
     ' Darren Parker Kirkland
     ' Ben Smith Kirkland
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using late binding with Contains operator 3
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine(
         "List of Contact Info using late binding with Contains operator 3")
     Console.WriteLine("======================================")
     Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
      Dim query_contains3 = From c In orgSvcContext.CreateQuery("contact") _
                            Where (CStr(c("description"))).Contains("Coho") _
                            Select New With
                                  {Key .firstname = c.Attributes("firstname"),
                                  Key .lastname = c.Attributes("lastname")}

      For Each c In query_contains3
       Console.WriteLine(c.firstname.ToString() &amp; " " _
                         &amp; c.lastname.ToString())
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using late binding with Contains operator 3
     ' ======================================
     ' Brian Smith
     ' Darren Parker
     ' Ben Smith
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using the GetAttributeValue (late binding) method 1
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine(
         "List of Contact Info using late binding " _
         &amp; "and the GetAttributeValue method 2")
     Console.WriteLine("======================================")
     Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
      Dim list_getattrib1 = ( _
          From c In orgSvcContext.CreateQuery("contact") _
          Where Not c.GetAttributeValue(Of Guid?)("contactid") _
          .Value.Equals(_contactId1) _
          Select New With
                 {
                  Key .FirstName = c.GetAttributeValue(Of String)("firstname"),
                  Key .LastName = c.GetAttributeValue(Of String)("lastname")}
              ).ToList()
      For Each c In list_getattrib1
       Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName)
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Contact Info using late binding and the GetAttributeValue method 2
     ' ======================================
     ' Brian Smith
     ' Darren Parker
     ' Ben Smith
     ' =====================================
     Console.WriteLine()

     ' *****************************************************************************
     '    LNQ        Using a late binding join
     ' *****************************************************************************

     Console.WriteLine()
     Console.WriteLine("List of Info using a late binding join")
     Console.WriteLine("======================================")
     'Note: Where statements are not working with the below multiple join query.
     '       Refer equivalent C# snippet for full complex query.
     'TODO: Fix issue to include where statements as showin in C# sample.
     Using orgSvcContext As New OrganizationServiceContext(_serviceProxy)
      Dim query_dejoin = From c In orgSvcContext.CreateQuery("contact") _
                         Join a In orgSvcContext.CreateQuery("account")
                         On c("contactid") Equals a("primarycontactid") _
                         Join l In orgSvcContext.CreateQuery("lead") _
                         On a("originatingleadid") Equals l("leadid") _
                         Select New With {Key .Contact = c,
                                          Key .Account = a,
                                          Key .Lead = l}
      For Each c In query_dejoin
       Console.WriteLine(c.Account.Attributes("name").ToString() _
                         &amp; " " _
                         &amp; c.Contact.Attributes("fullname").ToString() _
                         &amp; " " _
                         &amp; c.Lead.Attributes("leadid").ToString())
      Next c
     End Using
     Console.WriteLine("=====================================")
     '  OUTPUT:
     ' List of Info using a late binding join
     ' ======================================
     ' Contoso Ltd Brian Smith 9a8228af-04a1-e011-b1b7-00155dba3818
     ' =====================================
     Console.WriteLine()

     ' LateBoundExamples END    ======================================================
     DeleteRequiredRecords(promptforDelete)
    End Using


    ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    ' You can handle an exception here or pass it back to the calling method.
    Throw
   End Try
  End Sub

  ''' <summary>
  ''' Creates any entity records that this sample requires.
  ''' </summary>
  Public Sub CreateRequiredRecords()
   Dim contact1 As Contact =
       New Contact With
       {.FirstName = "Colin",
        .LastName = "Wilcox",
        .Address1_City = "Redmond",
        .Address1_StateOrProvince = "WA",
        .Address1_PostalCode = "98052",
        .Anniversary = New Date(2010, 3, 5),
        .CreditLimit = New Money(300),
        .Description = "Alpine Ski House",
        .StatusCode = New OptionSetValue(1),
        .AccountRoleCode = New OptionSetValue(1),
        .NumberOfChildren = 1,
        .Address1_Latitude = 47.6741667,
        .Address1_Longitude = -122.1202778,
        .CreditOnHold = False}
   _contactId1 = _serviceProxy.Create(contact1)

   Console.Write("Created a sample contact 1: {0}, ",
                 contact1.FirstName &amp; " " &amp; contact1.LastName)

   Dim contact2 As Contact = New Contact With
                             {.FirstName = "Brian",
                              .LastName = "Smith",
                              .Address1_City = "Bellevue",
                              .FamilyStatusCode = New OptionSetValue(3),
                              .Address1_StateOrProvince = "WA",
                              .Address1_PostalCode = "98008",
                              .Anniversary = New Date(2010, 4, 5),
                              .CreditLimit = New Money(30000),
                              .Description = "Coho Winery",
                              .StatusCode = New OptionSetValue(1),
                              .AccountRoleCode = New OptionSetValue(2),
                              .NumberOfChildren = 2,
                              .Address1_Latitude = 47.6105556,
                              .Address1_Longitude = -122.1994444,
                              .CreditOnHold = False}
   _contactId2 = _serviceProxy.Create(contact2)

   Console.Write("Created a sample contact 2: {0}, ",
                 contact2.FirstName &amp; " " &amp; contact2.LastName)

   Dim contact3 As Contact = New Contact With
                             {.FirstName = "Darren",
                              .LastName = "Parker",
                              .Address1_City = "Kirkland",
                              .FamilyStatusCode = New OptionSetValue(3),
                              .Address1_StateOrProvince = "WA",
                              .Address1_PostalCode = "98033",
                              .Anniversary = New Date(2010, 10, 5),
                              .CreditLimit = New Money(10000),
                              .Description = "Coho Winery",
                              .StatusCode = New OptionSetValue(1),
                              .AccountRoleCode = New OptionSetValue(2),
                              .NumberOfChildren = 2,
                              .Address1_Latitude = 47.6105556,
                              .Address1_Longitude = -122.1994444,
                              .CreditOnHold = False}
   _contactId3 = _serviceProxy.Create(contact3)

   Console.Write("Created a sample contact 3: {0}, ",
                 contact3.FirstName &amp; " " &amp; contact3.LastName)

   Dim contact4 As Contact = New Contact With
                             {.FirstName = "Ben",
                              .LastName = "Smith",
                              .Address1_City = "Kirkland",
                              .FamilyStatusCode = New OptionSetValue(3),
                              .Address1_StateOrProvince = "WA",
                              .Address1_PostalCode = "98033",
                              .Anniversary = New Date(2010, 7, 5),
                              .CreditLimit = New Money(12000),
                              .Description = "Coho Winery",
                              .StatusCode = New OptionSetValue(1),
                              .AccountRoleCode = New OptionSetValue(2),
                              .NumberOfChildren = 2,
                              .Address1_Latitude = 47.6105556,
                              .Address1_Longitude = -122.1994444,
                              .CreditOnHold = True}
   _contactId4 = _serviceProxy.Create(contact4)

   Console.Write("Created a sample contact 3: {0}, ",
                 contact4.FirstName &amp; " " &amp; contact4.LastName)

   Dim incident1 As Incident = New Incident With
                               {.Title = "Test Case 1",
                                .PriorityCode = New OptionSetValue(1),
                                .CaseOriginCode = New OptionSetValue(1),
                                .CaseTypeCode = New OptionSetValue(2),
                                .Description = "Description for Test Case 1.",
                                .FollowupBy = Date.Now.AddHours(3.0),
                                .CustomerId =
                                New EntityReference(Contact.EntityLogicalName,
                                                    _contactId2)}

   _incidentId1 = _serviceProxy.Create(incident1)

   Console.Write("Created a sample incident 1: {0}, ", incident1.Title)

   Dim relationship1 As New Relationship("incident_customer_contacts")
   Dim relatedEntities1 As New EntityReferenceCollection()
   relatedEntities1.Add(New EntityReference(Contact.EntityLogicalName,
                                            _contactId1))
   _serviceProxy.Associate(Incident.EntityLogicalName, _incidentId1,
                           relationship1, relatedEntities1)

   Console.Write("Added relationship between incident 1 and contact 1, ")


   Dim account1 As Account = New Account With
                             {.Name = "Coho Winery",
                              .Address1_Name = "Coho Vineyard &amp; Winery",
                              .Address1_City = "Redmond"}
   _accountId1 = _serviceProxy.Create(account1)

   Console.Write("Created a sample account 1: {0}, ", account1.Name)

   Dim incident2 As Incident = New Incident With
                               {.Title = "Test Case 2",
                                .PriorityCode = New OptionSetValue(1),
                                .CaseOriginCode = New OptionSetValue(1),
                                .CaseTypeCode = New OptionSetValue(2),
                                .Description = "Description for Sample Case 2.",
                                .FollowupBy = Date.Now.AddHours(3.0),
                                .CustomerId = New EntityReference(
                                    Contact.EntityLogicalName,
                                    _contactId1)}

   _incidentId2 = _serviceProxy.Create(incident2)

   Console.Write("Created a sample incident 2: {0}, ", incident2.Title)

   Dim relationship2 As New Relationship("incident_customer_accounts")
   Dim relatedEntities2 As New EntityReferenceCollection()
   relatedEntities2.Add(New EntityReference(Account.EntityLogicalName,
                                            _accountId1))
   _serviceProxy.Associate(Incident.EntityLogicalName, _incidentId2,
                           relationship2, relatedEntities2)

   Console.Write("Added relationship between incident 2 and account 1, ")

   Dim lead As New Lead() With {.FirstName = "Diogo", .LastName = "Andrade"}
   _leadId = _serviceProxy.Create(lead)
   Console.Write("Created a sample Lead: {0} ", lead.FirstName &amp; " " &amp; lead.LastName)

   Dim account2 As Account = New Account With
                             {.Name = "Contoso Ltd",
                              .ParentAccountId =
                              New EntityReference(Account.EntityLogicalName,
                                                  _accountId1),
                              .Address1_Name = "Contoso Pharmaceuticals",
                              .Address1_City = "Redmond",
                              .OriginatingLeadId =
                              New EntityReference(lead.EntityLogicalName,
                                                  _leadId)}
   _accountId2 = _serviceProxy.Create(account2)

   Console.Write("Created a sample account 2: {0}, ", account2.Name)

   Dim relationship3 As New Relationship("account_primary_contact")
   Dim relatedEntities3 As New EntityReferenceCollection()
   relatedEntities3.Add(New EntityReference(Account.EntityLogicalName,
                                            _accountId2))
   _serviceProxy.Associate(Contact.EntityLogicalName, _contactId2,
                           relationship3, relatedEntities3)

   Console.WriteLine("Added relationship between account 2 and contact 2.")
  End Sub
  ''' <summary>
  ''' Deletes any entity records that were created for this sample.
  ''' <param name="prompt">Indicates whether to prompt the user 
  ''' to delete the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   ' The three system users that were created by this sample will continue to 
   ' exist on your system because system users cannot be deleted in Microsoft
   ' Dynamics CRM.  They can only be enabled or disabled.

   Dim toBeDeleted As Boolean = True

   If prompt Then
    ' Ask the user if the created entities should be deleted.
    Console.Write(vbLf _
                  &amp; "Do you want these entity records deleted? (y/n) [y]: ")
    Dim answer As String = Console.ReadLine()
    If answer.StartsWith("y") OrElse answer.StartsWith("Y") _
        OrElse answer = String.Empty Then
     toBeDeleted = True
    Else
     toBeDeleted = False
    End If
   End If

   If toBeDeleted Then
    ' Delete all records created in this sample.
    _serviceProxy.Delete(Account.EntityLogicalName, _accountId2)
    _serviceProxy.Delete(Incident.EntityLogicalName, _incidentId2)
    _serviceProxy.Delete(Account.EntityLogicalName, _accountId1)
    _serviceProxy.Delete(Lead.EntityLogicalName, _leadId)
    _serviceProxy.Delete(Incident.EntityLogicalName, _incidentId1)
    _serviceProxy.Delete(Contact.EntityLogicalName, _contactId4)
    _serviceProxy.Delete(Contact.EntityLogicalName, _contactId3)
    _serviceProxy.Delete(Contact.EntityLogicalName, _contactId2)
    _serviceProxy.Delete(Contact.EntityLogicalName, _contactId1)

    Console.WriteLine("Entity record(s) have been deleted.")
   End If
  End Sub

#End Region ' How To Sample Code

#Region "Main method"

  ''' <summary>
  ''' Standard Main() method used by most SDK samples.
  ''' </summary>
  ''' <param name="args"></param>
  Public Shared Sub Main(ByVal args() As String)
   Try
    ' Obtain the target organization's Web address and client logon 
    ' credentials from the user.
    Dim serverConnect As New ServerConnection()
    Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

    Dim app As New LINQ101()
    app.Run(config, True)
   Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    Console.WriteLine("The application terminated with an error.")
    Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
    Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
    Console.WriteLine("Message: {0}", ex.Detail.Message)
    Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
   Catch ex As TimeoutException
    Console.WriteLine("The application terminated with an error.")
    Console.WriteLine("Message: {0}", ex.Message)
    Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
   Catch ex As Exception
    Console.WriteLine("The application terminated with an error.")
    Console.WriteLine(ex.Message)

    ' Display the details of the inner exception.
    If ex.InnerException IsNot Nothing Then
     Console.WriteLine(ex.InnerException.Message)

     Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
         TryCast(ex.InnerException, 
             FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
     If fe IsNot Nothing Then
      Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
      Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
      Console.WriteLine("Message: {0}", fe.Detail.Message)
      Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
     End If
    End If
    ' Additonal exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
    ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

   Finally
    Console.WriteLine("Press <Enter> to exit.")
    Console.ReadLine()
   End Try
  End Sub
#End Region ' Main method
 End Class
End Namespace

' </snippetlinqexamples>