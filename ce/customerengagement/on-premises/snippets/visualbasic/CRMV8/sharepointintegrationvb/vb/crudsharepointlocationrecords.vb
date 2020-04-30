' <snippetcrudsharepointlocationrecords>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
 ''' <summary>
 ''' Demonstrates how to create, retrieve, update, and delete.
 ''' SharePoint location records.</summary>
 ''' <remarks>
 ''' At run-time, you will be given the option to delete all the
 ''' database records created by this program.</remarks>
 Public Class CRUDSharePointLocationRecords
#Region "Class Level Members"

  Private _spSiteId As Guid
  Private _spDocLocId As Guid
  Private _account1Id As Guid
  Private _account2Id As Guid
  Private _serviceProxy As OrganizationServiceProxy

#End Region ' Class Level Members

#Region "How-To Sample Code"
  ''' <summary>
  ''' This method first connects to the Organization service. Afterwards,
  ''' create, retrieve, update, and delete operations are performed on the 
  ''' SharePoint location records.
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
     ' Instantiate a SharePoint site object.
     ' See the Entity Metadata topic in the SDK documentation to determine 
     ' which attributes must be set for each entity.
     Dim spSite As SharePointSite =
      New SharePointSite With {
       .Name = "Sample SharePoint Site",
       .Description = "Sample SharePoint Site Location record",
       .AbsoluteURL = "https://www.example.com"
      }
     ' TODO: Change this URL to a valid SharePoint URL.                        

     ' Create a SharePoint site record named Sample SharePoint Site.
     _spSiteId = _serviceProxy.Create(spSite)
     Console.WriteLine("{0} created.", spSite.Name)
     ' Instantiate a SharePoint document location object.
     ' See the Entity Metadata topic in the SDK documentation to determine 
     ' which attributes must be set for each entity.
     Dim spDocLoc As SharePointDocumentLocation =
      New SharePointDocumentLocation With {
       .Name = "Sample SharePoint Document Location",
       .Description = "Sample SharePoint Document Location record",
       .ParentSiteOrLocation = New EntityReference(SharePointSite.EntityLogicalName, _spSiteId),
       .RelativeUrl = "spdocloc",
       .RegardingObjectId = New EntityReference(Account.EntityLogicalName, _account1Id)
      }
     ' Set the Sample SharePoint Site created earlier as the parent site.
     ' Associate this document location instance with the Fourth Coffee
     ' sample account record.

     ' Create a SharePoint document location record named Sample SharePoint Document Location.
     _spDocLocId = _serviceProxy.Create(spDocLoc)
     Console.WriteLine("{0} created.", spDocLoc.Name)

     ' Retrieve the SharePoint site and SharePoint document location containing several of its attributes.
     Dim colsSpSite As New ColumnSet("name", "absoluteurl")
     Dim retrievedSpSite As SharePointSite = 
      CType(_serviceProxy.Retrieve(SharePointSite.EntityLogicalName, _spSiteId, colsSpSite), SharePointSite)

     Dim colsSpDocLoc As New ColumnSet("name", "regardingobjectid")
     Dim retrievedSpDocLoc As SharePointDocumentLocation =
      CType(_serviceProxy.Retrieve(SharePointDocumentLocation.EntityLogicalName, _spDocLocId, colsSpDocLoc), SharePointDocumentLocation)
     Console.Write("Retrieved,")

     ' Update the URL of the SharePoint site.
     ' TODO: Change this URL to a valid SharePoint URL.
     retrievedSpSite.AbsoluteURL = "https://www.example.net"
     _serviceProxy.Update(retrievedSpSite)

     ' Update the SharePoint document location to associate it with the 
     ' Northwind Traders sample account.
     retrievedSpDocLoc.RegardingObjectId = New EntityReference(Account.EntityLogicalName, _account2Id)
     _serviceProxy.Update(retrievedSpDocLoc)

     Console.WriteLine(" and updated the records.")

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
   ' Create two account records

   Dim account1 As Account =
    New Account With {
     .Name = "Fourth Coffee"
    }
   _account1Id = _serviceProxy.Create(account1)

   Dim account2 As Account =
    New Account With {
     .Name = "Northwind Traders"
    }
   _account2Id = _serviceProxy.Create(account2)

   Console.WriteLine("{0} and {1} sample accounts created.", account1.Name, account2.Name)
  End Sub

  ''' <summary>
  ''' Deletes any entity records that were created for this sample.
  ''' <param name="prompt">Indicates whether to prompt the user 
  ''' to delete the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   Dim deleteRecords As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
    Dim answer As String = Console.ReadLine()

    deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
   End If

   If deleteRecords Then
    _serviceProxy.Delete(SharePointDocumentLocation.EntityLogicalName, _spDocLocId)
    _serviceProxy.Delete(SharePointSite.EntityLogicalName, _spSiteId)
    _serviceProxy.Delete(Account.EntityLogicalName, _account1Id)
    _serviceProxy.Delete(Account.EntityLogicalName, _account2Id)
    Console.WriteLine("Entity records have been deleted.")
   End If
  End Sub

#End Region ' How-To Sample Code

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

    Dim app As New CRUDSharePointLocationRecords()
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
      TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
     If fe IsNot Nothing Then
      Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
      Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
      Console.WriteLine("Message: {0}", fe.Detail.Message)
      Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
     End If
    End If
   Finally
    Console.WriteLine("Press <Enter> to exit.")
    Console.ReadLine()
   End Try
  End Sub
#End Region ' Main method
 End Class
End Namespace

' </snippetcrudsharepointlocationrecords>