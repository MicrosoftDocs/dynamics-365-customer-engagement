' <snippetassignvisualizationtouser>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Imports System.DirectoryServices
Imports System.Threading

Namespace Microsoft.Crm.Sdk.Samples
	Public Class AssignVisualizationToUser
		#Region "Class Level Members"

		''' <summary>
		''' Stores the organization service proxy.
		''' </summary>
		Private _serviceProxy As OrganizationServiceProxy

		' Define the IDs needed for this sample.
		Private _userOwnedVisualizationId As Guid
		Private _accountId As Guid
		Private _opportunitiyIds() As Guid
		Private _otherUserId As Guid

		#End Region ' Class Level Members

		#Region "How To Sample Code"

		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>

	   Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
			Try
				' Connect to the Organization service. 
				' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
				Using _serviceProxy
					' This statement is required to enable early-bound type support.
					_serviceProxy.EnableProxyTypes()

					' Call the method to create any data that this sample requires.
					CreateRequiredRecords()


                    Dim assignRequest As AssignRequest =
                        New AssignRequest With
                        {
                            .Assignee = New EntityReference With
                                        {
                                            .LogicalName = SystemUser.EntityLogicalName,
                                            .Id = _otherUserId
                                        },
                            .Target = New EntityReference With
                                      {
                                          .LogicalName = UserQueryVisualization.EntityLogicalName,
                                          .Id = _userOwnedVisualizationId
                                      }
                        }
                    ' Here we could assign the visualization to the newly created user
					_serviceProxy.Execute(assignRequest)

					Console.WriteLine("The user visualization has been assigned to Kevin Cook.")


					DeleteRequiredRecords(promptForDelete)
				End Using

			' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
			Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				' You can handle an exception here or pass it back to the calling method.
				Throw
			End Try
	   End Sub

		''' <summary>
		''' This method creates any entity records that this sample requires.
		''' Creates the visualization.
		''' </summary>
		Public Sub CreateRequiredRecords()
			' Create a sample account
			Dim setupAccount As Account = New Account With {.Name = "Sample Account"}
			_accountId = _serviceProxy.Create(setupAccount)
			Console.WriteLine("Created {0}.", setupAccount.Name)

			' Create some oppotunity records for the visualization
            Dim setupOpportunities() As Opportunity =
                {
                    New Opportunity With
                    {
                        .Name = "Sample Opp 01",
                        .EstimatedValue = New Money(120000D),
                        .ActualValue = New Money(100000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    },
                    New Opportunity With
                    {
                        .Name = "Sample Opp 02",
                        .EstimatedValue = New Money(240000D),
                        .ActualValue = New Money(200000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    },
                    New Opportunity With
                    {
                        .Name = "Sample Opp 03",
                        .EstimatedValue = New Money(360000D),
                        .ActualValue = New Money(300000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    },
                    New Opportunity With
                    {
                        .Name = "Sample Opp 04",
                        .EstimatedValue = New Money(500000D),
                        .ActualValue = New Money(500000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    },
                    New Opportunity With
                    {
                        .Name = "Sample Opp 05",
                        .EstimatedValue = New Money(110000D),
                        .ActualValue = New Money(60000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    },
                    New Opportunity With
                    {
                        .Name = "Sample Opp 06",
                        .EstimatedValue = New Money(90000D),
                        .ActualValue = New Money(70000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    },
                    New Opportunity With
                    {
                        .Name = "Sample Opp 07",
                        .EstimatedValue = New Money(620000D),
                        .ActualValue = New Money(480000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    },
                    New Opportunity With
                    {
                        .Name = "Sample Opp 08",
                        .EstimatedValue = New Money(440000D),
                        .ActualValue = New Money(400000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    },
                    New Opportunity With
                    {
                        .Name = "Sample Opp 09",
                        .EstimatedValue = New Money(410000D),
                        .ActualValue = New Money(400000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    },
                    New Opportunity With
                    {
                        .Name = "Sample Opp 10",
                        .EstimatedValue = New Money(650000D),
                        .ActualValue = New Money(650000D),
                        .CustomerId =
                        New EntityReference(Account.EntityLogicalName, _accountId),
                        .StepName = "Open"
                    }
                }

			_opportunitiyIds = ( _
			    From opp In setupOpportunities _
			    Select _serviceProxy.Create(opp)).ToArray()

			Console.WriteLine("Created few opportunity records for {0}.", setupAccount.Name)

			' Create a visualization

			' Set The presentation XML string.
            Dim presentationXml As String =
                " <Chart Palette='BrightPastel'>" &amp; ControlChars.CrLf &amp;
                "     <Series>" &amp; ControlChars.CrLf &amp;
                "         <Series _Template_='All' ShadowOffset='2' " &amp; ControlChars.CrLf &amp;
                "             BorderColor='64, 64, 64' BorderDashStyle='Solid'" &amp; ControlChars.CrLf &amp;
                "             BorderWidth='1' IsValueShownAsLabel='true' " &amp; ControlChars.CrLf &amp;
                "             Font='Tahoma, 6.75pt, GdiCharSet=0' " &amp; ControlChars.CrLf &amp;
                "             LabelForeColor='100, 100, 100'" &amp; ControlChars.CrLf &amp;
                "             CustomProperties='FunnelLabelStyle=Outside' " &amp; ControlChars.CrLf &amp;
                "             ChartType='Funnel'>" &amp; ControlChars.CrLf &amp;
                "             <SmartLabelStyle Enabled='True' />" &amp; ControlChars.CrLf &amp;
                "             <Points />" &amp; ControlChars.CrLf &amp;
                "         </Series>" &amp; ControlChars.CrLf &amp;
                "      </Series>" &amp; ControlChars.CrLf &amp;
                "     <ChartAreas>" &amp; ControlChars.CrLf &amp;
                "         <ChartArea _Template_='All' BackColor='Transparent'" &amp; ControlChars.CrLf &amp;
                "             BorderColor='Transparent' " &amp; ControlChars.CrLf &amp;
                "             BorderDashStyle='Solid'>" &amp; ControlChars.CrLf &amp;
                "             <Area3DStyle Enable3D='True' " &amp; ControlChars.CrLf &amp;
                "                 IsClustered='True'/>" &amp; ControlChars.CrLf &amp;
                "         </ChartArea>" &amp; ControlChars.CrLf &amp;
                "     </ChartAreas>" &amp; ControlChars.CrLf &amp;
                "     <Legends>" &amp; ControlChars.CrLf &amp;
                "         <Legend _Template_='All' Alignment='Center' " &amp; ControlChars.CrLf &amp;
                "             LegendStyle='Table' Docking='Bottom' " &amp; ControlChars.CrLf &amp;
                "             IsEquallySpacedItems='True' BackColor='White'" &amp; ControlChars.CrLf &amp;
                "             BorderColor='228, 228, 228' BorderWidth='0' " &amp; ControlChars.CrLf &amp;
                "             Font='Tahoma, 8pt, GdiCharSet=0' " &amp; ControlChars.CrLf &amp;
                "             ShadowColor='0, 0, 0, 0' " &amp; ControlChars.CrLf &amp;
                "             ForeColor='100, 100, 100'>" &amp; ControlChars.CrLf &amp;
                "         </Legend>" &amp; ControlChars.CrLf &amp;
                "     </Legends>" &amp; ControlChars.CrLf &amp;
                "     <Titles>" &amp; ControlChars.CrLf &amp;
                "         <Title _Template_='All'" &amp; ControlChars.CrLf &amp;
                "             Font='Tahoma, 9pt, style=Bold, GdiCharSet=0'" &amp; ControlChars.CrLf &amp;
                "             ForeColor='102, 102, 102'>" &amp; ControlChars.CrLf &amp;
                "         </Title>" &amp; ControlChars.CrLf &amp;
                "     </Titles>" &amp; ControlChars.CrLf &amp;
                "     <BorderSkin PageColor='Control'" &amp; ControlChars.CrLf &amp;
                "         BackColor='CornflowerBlue'" &amp; ControlChars.CrLf &amp;
                "         BackSecondaryColor='CornflowerBlue' />" &amp; ControlChars.CrLf &amp;
                " </Chart>" &amp; ControlChars.CrLf

			' Set the data XML string.
            Dim dataXml As String =
                "<datadefinition>" &amp; ControlChars.CrLf &amp;
                "    <fetchcollection>" &amp; ControlChars.CrLf &amp;
                "        <fetch mapping='logical' count='10' " &amp; ControlChars.CrLf &amp;
                "            aggregate='true'>" &amp; ControlChars.CrLf &amp;
                "            <entity name='opportunity'>" &amp; ControlChars.CrLf &amp;
                "                <attribute name='actualvalue_base' " &amp; ControlChars.CrLf &amp;
                "                    aggregate='sum' " &amp; ControlChars.CrLf &amp;
                "                    alias='sum_actualvalue_base' />" &amp; ControlChars.CrLf &amp;
                "                <attribute name='stepname' groupby='true' " &amp; ControlChars.CrLf &amp;
                "                    alias='stepname' />" &amp; ControlChars.CrLf &amp;
                "                <order alias='stepname' descending='false'/>" &amp; ControlChars.CrLf &amp;
                "            </entity>" &amp; ControlChars.CrLf &amp;
                "        </fetch>" &amp; ControlChars.CrLf &amp;
                "    </fetchcollection>" &amp; ControlChars.CrLf &amp;
                "    <categorycollection>" &amp; ControlChars.CrLf &amp;
                "        <category>" &amp; ControlChars.CrLf &amp;
                "            <measurecollection>" &amp; ControlChars.CrLf &amp;
                "                <measure alias='sum_actualvalue_base'/>" &amp; ControlChars.CrLf &amp;
                "            </measurecollection>" &amp; ControlChars.CrLf &amp;
                "        </category>" &amp; ControlChars.CrLf &amp;
                "    </categorycollection>" &amp; ControlChars.CrLf &amp;
                "</datadefinition>"

			' Create the visualization entity instance.
            Dim newUserOwnedVisualization As UserQueryVisualization =
                New UserQueryVisualization With
                {
                    .Name = "Sample User Visualization",
                    .Description = "Sample user-owned visualization.",
                    .PresentationDescription = presentationXml,
                    .DataDescription = dataXml,
                    .PrimaryEntityTypeCode = Opportunity.EntityLogicalName
                }
			_userOwnedVisualizationId = _serviceProxy.Create(newUserOwnedVisualization)

			Console.WriteLine("Created {0}.", newUserOwnedVisualization.Name)

			' Create another user to whom the visualization will be assigned.
			_otherUserId = SystemUserProvider.RetrieveSalesManager(_serviceProxy)

		End Sub

		''' <summary>
		''' Deletes the entity record that was created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the entity created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                ' Delete action doesn't work on the UserQueryVisualization instance if it is assigned
                ' to a user other than current user.
                ' So as a workaround, we are impersonating the actual owner of 
                ' the UserQueryVisualization instance to complete the delete action.
                ' To impersonate another user, set the OrganizationServiceProxy.CallerId
                ' property to the ID of the other user.
                _serviceProxy.CallerId = _otherUserId

                _serviceProxy.Delete(UserQueryVisualization.EntityLogicalName, _userOwnedVisualizationId)
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId)
                Console.WriteLine("Entity records have been deleted.")
            End If
		End Sub

		#End Region ' How To Sample Code

		#Region "Main"
		''' <summary>
		''' Main. Runs the sample and provides error output.
		''' <param name="args">Array of arguments to Main method.</param>
		''' </summary>
		Public Shared Sub Main(ByVal args() As String)
			Try
				' Obtain the target organization's Web address and client logon 
				' credentials from the user.
				Dim serverConnect As New ServerConnection()
				Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

				Dim app As New AssignVisualizationToUser()
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
			' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
			' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

			Finally
				Console.WriteLine("Press <Enter> to exit.")
				Console.ReadLine()
			End Try

		End Sub
		#End Region ' Main

	End Class
End Namespace

' </snippetassignvisualizationtouser>