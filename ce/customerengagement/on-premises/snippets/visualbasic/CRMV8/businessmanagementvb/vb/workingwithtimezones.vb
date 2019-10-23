' <snippetworkingwithtimezones>


Imports System
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This sample shows how to use various SDK messages with time zones.
	''' </summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.
	''' </remarks>
	Public Class WorkingWithTimeZones
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _timeZoneName As String
		Private _timeZoneId? As Guid
		Private _localeId? As Integer
		Private _timeZoneCode? As Integer
		#End Region

		#Region "How To Sample Code"

		''' <summary>
		''' This method shows how to retrieve the user's time zone, retrieve time zones
		''' on the system and convert time between UTC and local time for a user.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete
		''' all created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()

                _timeZoneId = New Guid("42B2880D-BED5-4AA3-BD69-418052D38B7E")
                _timeZoneName = "Central Standard Time"
                RetrieveCurrentUsersSettings()

                RetrieveAllTimeZonesForLocale()
                GetTimeZoneCodeByLocaleAndName()
                RetrieveTimeZoneById()
                RetrieveTimeZonesLessThan50()
                RetrieveLocalTimeFromUTCTime(New Date(1981, 6, 6, 9, 5, 0))
                RetrieveUTCTimeFromLocalTime(New Date(2012, 1, 1, 0, 0, 0))
            End Using
        End Sub

		''' <summary>
		''' Retrieves the current users timezone code and locale id
		''' </summary>
        Private Sub RetrieveCurrentUsersSettings()
            Dim myQueryExpression As QueryExpression = New QueryExpression With
                                                       {
                                                           .EntityName = UserSettings.EntityLogicalName,
                                                           .ColumnSet = New ColumnSet("localeid", "timezonecode")
                                                       }
            Dim myFilter As FilterExpression = New FilterExpression()
            myFilter.AddCondition(New ConditionExpression("systemuserid",
                                                          ConditionOperator.EqualUserId))
            myQueryExpression.Criteria.AddFilter(myFilter)
            Dim currentUserSettings =
                _serviceProxy.RetrieveMultiple(myQueryExpression).Entities(0).ToEntity(Of UserSettings)()

            _localeId = currentUserSettings.LocaleId
            _timeZoneCode = currentUserSettings.TimeZoneCode
        End Sub

		''' <summary>
		''' Uses the current locale id to retrieve all the timezones 
		''' </summary>
		Private Sub RetrieveAllTimeZonesForLocale()
			If Not _localeId.HasValue Then
				Return
			End If

            Console.WriteLine(String.Concat("Retrieving time zones for locale id: ",
                                            _localeId.Value))

            Dim response =
                CType(_serviceProxy.Execute(
                        New GetAllTimeZonesWithDisplayNameRequest With
                        {
                            .LocaleId = _localeId.Value
                        }), 
                GetAllTimeZonesWithDisplayNameResponse)

			For i As Integer = 0 To response.EntityCollection.Entities.Count - 1
				Dim timeZoneDefinition = response.EntityCollection.Entities(i).ToEntity(Of TimeZoneDefinition)()

                Console.WriteLine(String.Concat(timeZoneDefinition.UserInterfaceName,
                                                " found for ",
                                                _localeId.Value))
			Next i
		End Sub

		''' <summary>
		''' Retrieves a timezone by the name and the locale ID
		''' </summary>
		Private Sub GetTimeZoneCodeByLocaleAndName()
            If String.IsNullOrWhiteSpace(_timeZoneName) OrElse
                (Not _localeId.HasValue) Then
                Return
            End If

            Dim request = New GetTimeZoneCodeByLocalizedNameRequest With
                          {
                              .LocaleId = _localeId.Value,
                              .LocalizedStandardName = _timeZoneName
                          }

            Dim response = CType(_serviceProxy.Execute(request), 
                GetTimeZoneCodeByLocalizedNameResponse)

            Console.WriteLine(String.Concat("Time zone code: ",
                                            response.TimeZoneCode,
                                            " retrieved for locale id: ",
                                            _localeId.Value,
                                            ", and time zone name: ",
                                            _timeZoneName))
		End Sub

		''' <summary>
		''' Retieve time zone by id
		''' </summary>
		Private Sub RetrieveTimeZoneById()
			If Not _timeZoneId.HasValue Then
				Return
			End If

			' In addition to the RetrieveRequest message, 
			' you may use the IOrganizationService.Retrieve method
            Dim request = New RetrieveRequest With
                          {
                              .Target = New EntityReference(TimeZoneDefinition.EntityLogicalName,
                                                            _timeZoneId.Value),
                              .ColumnSet = New ColumnSet("standardname")
                          }

			Dim response = CType(_serviceProxy.Execute(request), RetrieveResponse)

            Console.WriteLine(String.Concat("Retrieve request on time zone ", _timeZoneId.Value,
                                            ".  Name: ",
                                            response.Entity.ToEntity(Of TimeZoneDefinition)().StandardName))
		End Sub

		''' <summary>
		''' Retrieve time zones less than 50.
		''' </summary>
		Private Sub RetrieveTimeZonesLessThan50()
			' In addition to the RetrieveMultipleRequest message,
            ' you may use the IOrganizationService.RetrieveMultiple method.
            Dim myQueryExpression As QueryExpression = New QueryExpression With
                                                       {
                                                           .EntityName = TimeZoneDefinition.EntityLogicalName,
                                                           .ColumnSet = New ColumnSet("timezonecode",
                                                                                      "standardname")
                                                       }
            myQueryExpression.Criteria.AddCondition(New ConditionExpression("timezonecode",
                                                                            ConditionOperator.LessThan,
                                                                            50))

            Dim request = New RetrieveMultipleRequest With
                          {
                              .Query = myQueryExpression
                          }

			Console.WriteLine("Retrieving all timezones with a timezonecode less than 50")
			Dim response = CType(_serviceProxy.Execute(request), RetrieveMultipleResponse)

			For Each item In response.EntityCollection.Entities
				Dim timeZone = item.ToEntity(Of TimeZoneDefinition)()

                Console.WriteLine(String.Concat("Time zone name: ",
                                                timeZone.StandardName,
                                                ", time zone code: ",
                                                If((Not timeZone.TimeZoneCode.HasValue),
                                                   "null",
                                                   timeZone.TimeZoneCode.Value.ToString())))
			Next item

		End Sub

		''' <summary>
		''' Retrieve the local time from the UTC time.
		''' </summary>
		''' <param name="utcTime"></param>
		Private Sub RetrieveLocalTimeFromUTCTime(ByVal utcTime As Date)
			If Not _timeZoneCode.HasValue Then
				Return
			End If

            Dim request = New LocalTimeFromUtcTimeRequest With
                          {
                              .TimeZoneCode = _timeZoneCode.Value,
                              .UtcTime = utcTime.ToUniversalTime()
                          }

            Dim response = CType(_serviceProxy.Execute(request), 
                LocalTimeFromUtcTimeResponse)

            Console.WriteLine(String.Concat("Calling LocalTimeFromUtcTimeRequest.  UTC time: ",
                                            utcTime.ToString("MM/dd/yyyy HH:mm:ss"),
                                            ". Local time: ",
                                            response.LocalTime.ToString("MM/dd/yyyy HH:mm:ss")))
		End Sub

		''' <summary>
		''' Retrieves the utc time from the local time
		''' </summary>
		''' <param name="localTime"></param>
		Private Sub RetrieveUTCTimeFromLocalTime(ByVal localTime As Date)
			If Not _timeZoneCode.HasValue Then
				Return
			End If

            Dim request = New UtcTimeFromLocalTimeRequest With
                          {
                              .TimeZoneCode = _timeZoneCode.Value,
                              .LocalTime = localTime
                          }

            Dim response = CType(_serviceProxy.Execute(request), 
                UtcTimeFromLocalTimeResponse)

            Console.WriteLine(String.Concat("Calling UtcTimeFromLocalTimeRequest.  Local time: ",
                                            localTime.ToString("MM/dd/yyyy HH:mm:ss"),
                                            ". UTC time: ",
                                            response.UtcTime.ToString("MM/dd/yyyy HH:mm:ss")))
		End Sub
		#End Region

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

				Dim app = New WorkingWithTimeZones()
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
		#End Region
	End Class
End Namespace

' </snippetworkingwithtimezones>