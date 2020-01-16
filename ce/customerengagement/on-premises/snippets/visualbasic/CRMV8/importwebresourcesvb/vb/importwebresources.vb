' <snippetimportwebresources>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Crm.Sdk.Messages

'These references are required for this sample
Imports System.IO


Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to import Web Resources.</summary>
	''' <remarks>
	''' The Web Resources will be defined in an XML document.</remarks>
	Public Class ImportWebResources
		#Region "Class Level Members"


		Private _serviceProxy As OrganizationServiceProxy

		'Define Ids needed in this sample
		Private _crmSdkPublisherId As Guid
		Private _customizationPrefix As String
		Private _createdPublisher As Boolean = False
		Private _importWebResourcesSampleSolutionId As Guid
		Private _ImportWebResourcesSolutionUniqueName As String
		Private _webResourceIds(4) As Guid




		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service. Afterwards,
		''' basic create, retrieve, update, and delete entity operations are performed.
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


                    'Read the descriptive data from the XML file
                    Dim xmlDoc As XDocument = XDocument.Load("../../ImportJob.xml")

                    'Create a collection of anonymous type references to each of the Web Resources
                    Dim webResources =
                        From webResource In xmlDoc.Descendants("webResource") _
                        Select New With
                               {
                                   Key .path = webResource.Element("path").Value,
                                   Key .displayName =
                                   webResource.Element("displayName").Value,
                                   Key .description =
                                   webResource.Element("description").Value,
                                   Key .name = webResource.Element("name").Value,
                                   Key .type = webResource.Element("type").Value
                               }

                    ' Loop through the collection creating Web Resources
                    Dim counter As Integer = 0
                    For Each awebResource In webResources
                        'Set the Web Resource properties
                        Dim wr As WebResource =
                            New WebResource With
                            {
                                .Content = getEncodedFileContents("../../" _
                                                                  &amp; awebResource.path),
                                .DisplayName = awebResource.displayName,
                                .Description = awebResource.description,
                                .Name = _customizationPrefix &amp; awebResource.name,
                                .LogicalName = WebResource.EntityLogicalName,
                                .WebResourceType =
                                New OptionSetValue(Int32.Parse(awebResource.type))
                            }

                        ' Using CreateRequest because we want to add an optional parameter
                        Dim cr As CreateRequest = New CreateRequest With {.Target = wr}
                        'Set the SolutionUniqueName optional parameter so the Web Resources will be
                        ' created in the context of a specific solution.
                        cr.Parameters.Add("SolutionUniqueName",
                                          _ImportWebResourcesSolutionUniqueName)

                        Dim cresp As CreateResponse = CType(_serviceProxy.Execute(cr), 
                            CreateResponse)
                        ' Capture the id values for the Web Resources so the sample can delete them.
                        _webResourceIds(counter) = cresp.id
                        counter += 1
                        Console.WriteLine("Created Web Resource: {0}",
                                          awebResource.displayName)
                    Next awebResource

                    DeleteRequiredRecords(promptforDelete)

                End Using


                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		'Encodes the Web Resource File
		Public Shared Function getEncodedFileContents(ByVal pathToFile As String) As String
			Dim fs As New FileStream(pathToFile, FileMode.Open, FileAccess.Read)
            Dim binaryData(CType(fs.Length, Integer) - 1) As Byte
			Dim bytesRead As Long = fs.Read(binaryData, 0, CInt(fs.Length))
			fs.Close()
			Return Convert.ToBase64String(binaryData, 0, binaryData.Length)
		End Function

		''' <summary>
		''' This method creates a publisher and a solution to use when adding the Web resources.
		''' </summary>
		Public Sub CreateRequiredRecords()

			'Define a new publisher
            Dim _crmSdkPublisher As Publisher =
                New Publisher With
                {
                    .UniqueName =
                    "microsoftdynamicscrmsdksamplesimportwebresourcessample",
                    .FriendlyName =
                    "Microsoft Dynamics CRM SDK Samples Import Web Resources Sample",
                    .SupportingWebsiteUrl =
                    "http://msdn.microsoft.com/dynamics/crm/default.aspx",
                    .CustomizationPrefix = "sample",
                    .EMailAddress = "someone@microsoft.com",
                    .Description = "This publisher is used by the Import Web Resources " _
                    &amp; "sample from the Dynamics 365 developer documentation."
                }

			'Does publisher already exist?
            Dim querySDKSamplePublisher As QueryExpression =
                New QueryExpression With
                {
                    .EntityName = Publisher.EntityLogicalName,
                    .ColumnSet = New ColumnSet("publisherid",
                                               "customizationprefix",
                                               "friendlyname",
                                               "isreadonly"),
                    .Criteria = New FilterExpression()
                }

            querySDKSamplePublisher.Criteria.AddCondition("uniquename",
                                                          ConditionOperator.Equal,
                                                          _crmSdkPublisher.UniqueName)
            Dim querySDKSamplePublisherResults As EntityCollection =
                _serviceProxy.RetrieveMultiple(querySDKSamplePublisher)
			Dim SDKSamplePublisherResults As Publisher = Nothing

			'If it already exists, use it
			If querySDKSamplePublisherResults.Entities.Count > 0 Then
                SDKSamplePublisherResults =
                    CType(querySDKSamplePublisherResults.Entities(0), Publisher)
				_crmSdkPublisherId = CType(SDKSamplePublisherResults.PublisherId, Guid)
				_customizationPrefix = SDKSamplePublisherResults.CustomizationPrefix

                Console.WriteLine("Using existing publisher: {0}",
                                  SDKSamplePublisherResults.FriendlyName)
			End If
			'If it doesn't exist, create it
			If SDKSamplePublisherResults Is Nothing Then
				_crmSdkPublisherId = _serviceProxy.Create(_crmSdkPublisher)
                Console.WriteLine(String.Format("Created publisher: {0}.",
                                                _crmSdkPublisher.FriendlyName))
				_customizationPrefix = _crmSdkPublisher.CustomizationPrefix
				' Set this flag to delete the publisher if this sample created it.
				_createdPublisher = True
                Console.WriteLine("Created new publisher: {0}",
                                  _crmSdkPublisher.FriendlyName)
			End If

			' Create a Solution
			'Define a solution
            Dim solution As Solution =
                New Solution With
                {
                    .UniqueName = "ImportWebResourcesSample",
                    .FriendlyName = "Import Web Resources Sample Solution",
                    .PublisherId = New EntityReference(Publisher.EntityLogicalName,
                                                       _crmSdkPublisherId),
                    .Description = "This solution was created by the ImportWebResources " _
                    &amp; "sample code in the Microsoft Dynamics CRM SDK samples.",
                    .Version = "1.0"
                }
			' Save save this variable  to use when creating the Web resources in the context of this solution.
			_ImportWebResourcesSolutionUniqueName = solution.UniqueName

			'Check whether it already exists
            Dim queryCheckForSampleSolution As QueryExpression =
                New QueryExpression With
                {
                    .EntityName = solution.EntityLogicalName,
                    .ColumnSet = New ColumnSet("friendlyname"),
                    .Criteria = New FilterExpression()
                }
            queryCheckForSampleSolution.Criteria.AddCondition("uniquename",
                                                              ConditionOperator.Equal,
                                                              solution.UniqueName)

			'Create the solution if it does not already exist.
            Dim querySampleSolutionResults As EntityCollection =
                _serviceProxy.RetrieveMultiple(queryCheckForSampleSolution)
			Dim SampleSolutionResults As Solution = Nothing
			If querySampleSolutionResults.Entities.Count > 0 Then
                SampleSolutionResults = CType(querySampleSolutionResults.Entities(0), 
                    Solution)
                _importWebResourcesSampleSolutionId =
                    CType(SampleSolutionResults.SolutionId, Guid)
                Console.WriteLine("Using existing solution: {0}",
                                  SampleSolutionResults.FriendlyName)
			End If
			If SampleSolutionResults Is Nothing Then
				_importWebResourcesSampleSolutionId = _serviceProxy.Create(solution)
				Console.WriteLine("Created new solution: {0}", solution.FriendlyName)
			End If



		End Sub

		''' <summary>
		''' Deletes the custom entity record that was created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the entity created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim deleteRecords As Boolean = True

			If prompt Then
                Console.WriteLine(vbLf _
                                  &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse _
                                 answer.StartsWith("Y") OrElse answer = String.Empty)
			End If

			If deleteRecords Then
				'delete Web Resources
				For Each id As Guid In _webResourceIds
					_serviceProxy.Delete(WebResource.EntityLogicalName, id)
				Next id
				Console.WriteLine("Web Resource records have been deleted.")
				'Delete Solution

                _serviceProxy.Delete(Solution.EntityLogicalName,
                                     _importWebResourcesSampleSolutionId)
				Console.WriteLine("Solution has been deleted.")

				'
				If _createdPublisher Then
					' Delete the publisher
					_serviceProxy.Delete(Publisher.EntityLogicalName, _crmSdkPublisherId)
					Console.WriteLine("Publisher has been deleted.")
				End If

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

				Dim app As New ImportWebResources()
				app.Run(config, True)
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault,
                                                        "No Inner Fault", "Has Inner Fault"))
			Catch ex As TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message,
                                                        "No Inner Fault", ex.InnerException.Message))
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
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault,
                                                                "No Inner Fault", "Has Inner Fault"))
					End If
				End If
			' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
			' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

			Finally
				Console.WriteLine("Press <Enter> to exit.")
				Console.ReadLine()
			End Try
		End Sub
		#End Region ' Main method
	End Class
End Namespace

' </snippetimportwebresources>