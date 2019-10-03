' <snippetserializeanddeserialize>


Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
    ''' This sample shows how to serialize both early-bound and late-bound entity instances (records).
    ''' In addition, it shows how to de-serialize from XML to an early-bound entity instance.
	''' </summary>
	Public Class SerializeAndDeserialize
		#Region "Class Level Members"

		Private _serviceProxy As OrganizationServiceProxy
		Private _contactId As Guid

		#End Region ' Class Level Members

		#Region "How To Sample Code"

		''' <summary>
		''' Run this sample, which shows both how to serialize late-bound and
        ''' early-bound entity instances to XML, and how to de-serialize the XML back into
        ''' entity instances.
		''' </summary>
		''' <param name="serverConfig"> Contains server connection information.</param>
		''' <param name="promptToDelete"> When True, the user will be prompted to delete all
		''' created entities.
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptToDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound entity type support.
                _serviceProxy.EnableProxyTypes()

                CreateRequiredRecords()

                '#Region "Retrieve the contact from Microsoft Dynamics CRM"

                ' Create the column set object that indicates the fields to be retrieved.
                Dim columns = New ColumnSet(
                              "contactid",
                              "firstname",
                              "lastname",
                              "jobtitle")

                ' Retrieve the contact from Microsoft Dynamics CRM using the ID of the record that was just created.
                ' The EntityLogicalName indicates the EntityType of the object being retrieved.
                Dim sampleContact = _serviceProxy.Retrieve(Contact.EntityLogicalName, 
                                                           _contactId, 
                                                           columns).ToEntity(Of Contact)()

                Console.WriteLine("The contact for the sample has been retrieved.")

                '#End Region

                '#Region "Serialize the contact into XML and save it"

                ' Serialize the contact instance into XML and write it to the hard drive.
                Dim earlyBoundSerializer = New DataContractSerializer(GetType(Contact))

                ' Create a unique file name for the XML.
                Dim earlyboundFile As String = "Contact_early_" _
                                               &amp; sampleContact.ContactId.Value.ToString("B") _
                                               &amp; ".xml"

                ' Write the serialized object to a file.  The using statement will
                ' ensure that the FileStream is disposed of correctly.  The FileMode
                ' will ensure that the file is overwritten if it already exists.
                Using file = New FileStream(earlyboundFile, FileMode.Create)
                    ' Write the XML to disk.
                    earlyBoundSerializer.WriteObject(file, sampleContact)
                End Using

                Console.WriteLine("The early-bound contact instance has been serialized to a file, {0}.",
                                  earlyboundFile)

                ' Convert the contact to a late-bound entity instance and serialize it to disk.
                Dim lateboundContact = sampleContact.ToEntity(Of Entity)()
                Dim lateboundFile As String = "Contact_late_" _
                                              &amp; lateboundContact.Id.ToString("B") _
                                              &amp; ".xml"

                Dim lateBoundSerializer = New DataContractSerializer(GetType(Entity))
                ' Write the serialized object to a file.
                Using file = New FileStream(lateboundFile, FileMode.Create)
                    lateBoundSerializer.WriteObject(file, lateboundContact)
                End Using

                Console.WriteLine("The late-bound contact instance has been serialized to a file, {0}.",
                                  lateboundFile)

                '#End Region

                '#Region "De-serialize the Microsoft Dynamics CRM contact from XML"

                Dim deserializedContact As Contact = Nothing
                Using file = New FileStream(earlyboundFile, FileMode.Open)
                    deserializedContact = CType(earlyBoundSerializer.ReadObject(file), 
                        Contact)
                    Console.WriteLine("The contact has been de-serialized: {0} {1}",
                                      deserializedContact.FirstName,
                                      deserializedContact.LastName)
                End Using

                '#End Region

                '#Region "Update contact in Microsoft Dynamics CRM"

                ' Update the contact record in Microsoft Dynamics CRM to prove that the de-serialization worked.
                deserializedContact.JobTitle = "Plumber"
                _serviceProxy.Update(deserializedContact)

                Console.WriteLine("The contact was updated in Microsoft CRM.")

                '#End Region

                DeleteRequiredRecords(promptToDelete)
            End Using
        End Sub

		''' <summary>
        ''' Creates a contact record which is required for running this sample.
		''' </summary>
		Private Sub CreateRequiredRecords()
            ' Create a contact entity record that will be serialized into XML.
			Dim contactCreate = New Contact()
			contactCreate.FirstName = "Thomas"
			contactCreate.LastName = "Andersen"

            ' Create the entity record in Microsoft CRM and get its ID.
			_contactId = _serviceProxy.Create(contactCreate)

			Console.WriteLine("The contact for the sample has been created.")
		End Sub

		''' <summary>
        ''' Deletes the contact record that was used in the sample if the user responds in the
		''' affirmative.
		''' </summary>
		''' <param name="promptToDelete">whether or not to delete the contact</param>
		Private Sub DeleteRequiredRecords(ByVal promptToDelete As Boolean)
			Dim toBeDeleted = True
			If promptToDelete Then
				' Ask the user if the created entities should be deleted.
				Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse
                    answer.StartsWith("Y") OrElse
                    answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				_serviceProxy.Delete(Contact.EntityLogicalName, _contactId)
				Console.WriteLine("The contact has been deleted.")
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
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app = New SerializeAndDeserialize()
				app.Run(config, True)
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
			Catch ex As System.TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
			Catch ex As System.Exception
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
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
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

' </snippetserializeanddeserialize>