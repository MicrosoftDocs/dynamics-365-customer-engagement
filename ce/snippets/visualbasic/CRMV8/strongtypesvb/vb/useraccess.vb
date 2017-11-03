' <snippetuseraccess>


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
    Public Class UserAccess
#Region "Class Level Members"
        Private _serviceProxy As OrganizationServiceProxy
        Private _currentUserId As Guid
        Private _systemUserIds As List(Of Guid)
        Private _teamId As Guid
        Private _leadId As Guid
        Private _taskId As Guid
#End Region

#Region "How To Sample Code"
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early bound type support.
                _serviceProxy.EnableProxyTypes()
                CreateRequiredRecords()

                ' Retrieve and display the access that the calling user has to the
                ' created lead.
                Dim leadReference = New EntityReference(Lead.EntityLogicalName,
                                                        _leadId)
                Dim currentUserReference = New EntityReference(SystemUser.EntityLogicalName,
                                                               _currentUserId)
                RetrieveAndDisplayPrincipalAccess(leadReference,
                                                  currentUserReference,
                                                  "Current User")

                ' Retrieve and display the access that the first user has to the
                ' created lead.
                Dim systemUser1Ref = New EntityReference(SystemUser.EntityLogicalName,
                                                         _systemUserIds(0))
                RetrieveAndDisplayPrincipalAccess(leadReference,
                                                  systemUser1Ref,
                                                  "System User 1")

                ' Grant the first user read access to the created lead.
                Dim grantAccessRequest = New GrantAccessRequest With
                                         {
                                             .PrincipalAccess =
                                             New PrincipalAccess With
                                             {
                                                 .AccessMask = AccessRights.ReadAccess,
                                                 .Principal = systemUser1Ref
                                             },
                                             .Target = leadReference
                                         }

                Console.WriteLine("Granting {0} to {1} ({2}) on the lead..." &amp; vbCrLf,
                                  AccessRights.ReadAccess, GetEntityReferenceString(systemUser1Ref),
                                  "System User 1")
                _serviceProxy.Execute(grantAccessRequest)


                ' Retrieve and display access information for the lead.
                RetrieveAndDisplayPrincipalAccess(leadReference,
                                                  systemUser1Ref,
                                                  "System User 1")
                RetrieveAndDisplayLeadAccess(leadReference)

                ' Grant the team read/write access to the lead.
                Dim teamReference = New EntityReference(Team.EntityLogicalName,
                                                        _teamId)
                
                Dim grantAccessRequest1 = New GrantAccessRequest With
                                         {
                                             .PrincipalAccess =
                                             New PrincipalAccess With
                                             {
                                                 .AccessMask = AccessRights.ReadAccess Or AccessRights.WriteAccess,
                                                 .Principal = teamReference
                                             },
                                             .Target = leadReference
                                         }

                Console.WriteLine("Granting {0} to {1} ({2}) on the lead..." &amp; vbCrLf,
                                  AccessRights.ReadAccess Or AccessRights.WriteAccess, GetEntityReferenceString(teamReference),
                                  "Team")
                _serviceProxy.Execute(grantAccessRequest1)


                Dim systemUser2Ref = New EntityReference(SystemUser.EntityLogicalName,
                                                         _systemUserIds(1))

                ' Retrieve and display access information for the lead and system user 2.
                RetrieveAndDisplayPrincipalAccess(leadReference, systemUser2Ref,
                                                  "System User 2")
                RetrieveAndDisplayLeadAccess(leadReference)


                ' Grant the first user delete access to the lead.
                Dim modifyUser1AccessReq = New ModifyAccessRequest With
                                           {
                                               .PrincipalAccess =
                                               New PrincipalAccess With
                                               {
                                                   .AccessMask = AccessRights.DeleteAccess,
                                                   .Principal = systemUser1Ref
                                               },
                                               .Target = leadReference
                                           }

                Console.WriteLine("Granting delete access to {0} on the lead..." &amp; vbCrLf,
                                  GetEntityReferenceString(systemUser1Ref))
                _serviceProxy.Execute(modifyUser1AccessReq)

                ' Retrieve and display access information for the lead.
                RetrieveAndDisplayLeadAccess(leadReference)


                ' Revoke access to the lead for the second user.
                Dim revokeUser2AccessReq = New RevokeAccessRequest With
                                           {
                                               .Revokee = systemUser2Ref,
                                               .Target = leadReference
                                           }

                Console.WriteLine("Revoking access to the lead for {0}..." &amp; vbCrLf,
                                  GetEntityReferenceString(systemUser2Ref))
                _serviceProxy.Execute(revokeUser2AccessReq)

                ' Retrieve and display access information for the lead.
                RetrieveAndDisplayPrincipalAccess(leadReference,
                                                  systemUser2Ref,
                                                  "System User 2")

                RetrieveAndDisplayLeadAccess(leadReference)

                DeleteRequiredRecords(promptforDelete)
            End Using
        End Sub

        Private Sub RetrieveAndDisplayPrincipalAccess(ByVal leadReference As EntityReference,
                                                      ByVal principal As EntityReference,
                                                      ByVal additionalIdentifier As String)
            Dim principalAccessReq = New RetrievePrincipalAccessRequest With
                                     {
                                         .Principal = principal,
                                         .Target = leadReference
                                     }
            Dim principalAccessRes = CType(_serviceProxy.Execute(principalAccessReq), 
                RetrievePrincipalAccessResponse)
            Console.WriteLine("Access rights of {0} ({1}) on the lead: {2}" &amp; vbCrLf,
                              GetEntityReferenceString(principal),
                              additionalIdentifier,
                              principalAccessRes.AccessRights)
        End Sub


        Private Sub RetrieveAndDisplayLeadAccess(ByVal leadReference As EntityReference)

            Dim accessRequest = New RetrieveSharedPrincipalsAndAccessRequest With
                                {
                                    .Target = leadReference
                                }

            ' The RetrieveSharedPrincipalsAndAccessResponse returns an entity reference
            ' that has a LogicalName of "user" when returning access information for a
            ' "team."
            Dim accessResponse = CType(_serviceProxy.Execute(accessRequest), 
                RetrieveSharedPrincipalsAndAccessResponse)
            Console.WriteLine("The following have the specified granted access to the lead.")
            For Each principalAccess In accessResponse.PrincipalAccesses
                Console.WriteLine(vbTab &amp; "{0}:" &amp; vbCrLf &amp; vbTab &amp; vbTab &amp; "{1}",
                                  GetEntityReferenceString(principalAccess.Principal),
                                  principalAccess.AccessMask)
            Next principalAccess
            Console.WriteLine()

        End Sub

        Private Function GetEntityReferenceString(ByVal entityReference As EntityReference) As String
            Return String.Format("{0} with GUID {1}",
                                 entityReference.LogicalName,
                                 entityReference.Id)
        End Function

        ''' <summary>
        ''' Creates any entity records that this sample requires.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create a unique identifier for this sample for preventing name conflicts.
            Dim sampleIdentifier = Guid.NewGuid()

            ' Retrieve/create the system users to use for the sample.
            Dim ldapPath = String.Empty
            _systemUserIds = SystemUserProvider.RetrieveDelegates(_serviceProxy, ldapPath)

            ' Retrieve the root business unit to use for creating the team for the
            ' sample.
            Dim businessUnitQuery = New QueryExpression With
                                    {
                                        .EntityName = BusinessUnit.EntityLogicalName,
                                        .ColumnSet = New ColumnSet("businessunitid"),
                                        .Criteria = New FilterExpression()
                                    }

            businessUnitQuery.Criteria.AddCondition("parentbusinessunitid",
                                                    ConditionOperator.Null)
            Dim businessUnitResult = _serviceProxy.RetrieveMultiple(businessUnitQuery)
            Dim businessUnit1 = businessUnitResult.Entities(0).ToEntity(Of BusinessUnit)()

            ' Get the GUID of the current user.
            Dim who = New WhoAmIRequest()
            Dim whoResponse = CType(_serviceProxy.Execute(who), WhoAmIResponse)
            _currentUserId = whoResponse.UserId

            ' Create a team for use in the sample.
            Dim team = New Team With
                       {
                           .AdministratorId = New EntityReference("systemuser",
                                                                  _currentUserId),
                           .Name = String.Format("User Access Sample Team {0}",
                                                 sampleIdentifier),
                           .BusinessUnitId = businessUnit1.ToEntityReference()
                       }
            _teamId = _serviceProxy.Create(team)

            ' Add the second user to the newly created team.
            Dim addToTeamRequest = New AddMembersTeamRequest With
                                   {
                                       .TeamId = _teamId,
                                       .MemberIds = {_systemUserIds(1)}
                                   }
            _serviceProxy.Execute(addToTeamRequest)

            ' Create a lead for use in the sample.
            Dim lead = New Lead With
                       {
                           .CompanyName = "User Access Sample Company",
                           .FirstName = "Sample",
                           .LastName = "Lead",
                           .Subject = "User Access Sample Lead"
                       }
            _leadId = _serviceProxy.Create(lead)

            ' Create a task to associate to the lead.
            Dim leadReference = New EntityReference(Lead.EntityLogicalName, _leadId)
            Dim task = New Task With
                       {
                           .Subject = "User Access Sample Task",
                           .RegardingObjectId = leadReference
                       }
            _taskId = _serviceProxy.Create(task)

            ' Create a letter to associate to the lead.
            Dim letter = New Letter With
                         {
                             .Subject = "User Access Sample Letter",
                             .RegardingObjectId = leadReference
                         }
            _serviceProxy.Create(letter)
        End Sub

        Private Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer =
                    String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                ' Delete records created in this sample.
                _serviceProxy.Delete(Team.EntityLogicalName, _teamId)
                ' Deleting the lead will delete its associated activities.
                _serviceProxy.Delete(Lead.EntityLogicalName, _leadId)

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
                ' Obtain the target organization's web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

                Dim app = New UserAccess()
                app.Run(config, True)
            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
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

' </snippetuseraccess>