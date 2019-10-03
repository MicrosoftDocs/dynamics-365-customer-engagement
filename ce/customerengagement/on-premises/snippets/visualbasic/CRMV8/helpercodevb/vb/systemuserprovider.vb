' <snippetsystemuserprovider>


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.DirectoryServices
Imports System.Threading

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This class contains methods which retrieve the IDs of several fictitious Microsoft Dynamics
    ''' CRM system users.  Several SDK samples require these additional user accounts in order to run.
    ''' </summary>
    ''' <remarks>For On-premises and IFD deployments, if these users do not exist they are created in
    ''' Active Directory. This assumes that the system user account under which the application runs has
    ''' system administrator privileges. Since it is not possible to programmatically create user accounts
    ''' in Microsoft account, when running this code against a Microsoft Dynamics CRM Online server, you will have
    ''' to manually add these users.</remarks>
    Public Class SystemUserProvider
		Public Shared Function RetrieveSalesManager(ByVal proxy As OrganizationServiceProxy) As Guid
			Dim ldapPath As String = String.Empty
			Return RetrieveSystemUser("kcook", "Kevin", "Cook", "Sales Manager", proxy, ldapPath)
		End Function
		Public Shared Function RetrieveSalesManager(ByVal proxy As OrganizationServiceProxy, ByRef ldapPath As String) As Guid
			Return RetrieveSystemUser("kcook", "Kevin", "Cook", "Sales Manager", proxy, ldapPath)
		End Function

		Public Shared Function RetrieveSalespersons(ByVal proxy As OrganizationServiceProxy, ByRef ldapPath As String) As List(Of Guid)
			Dim reps As New List(Of Guid)()

			reps.Add(RetrieveSystemUser("nanderson", "Nancy", "Anderson", "Salesperson", proxy, ldapPath))
			reps.Add(RetrieveSystemUser("dbristol", "David", "Bristol", "Salesperson", proxy, ldapPath))

			Return reps
		End Function

		Public Shared Function RetrieveDelegates(ByVal proxy As OrganizationServiceProxy, ByRef ldapPath As String) As List(Of Guid)
			Dim delegates As New List(Of Guid)()

			delegates.Add(RetrieveSystemUser("dwilson", "Dan", "Wilson", "Delegate", proxy, ldapPath))
			delegates.Add(RetrieveSystemUser("canderson", "Christen", "Anderson", "Delegate", proxy, ldapPath))
			Return delegates
		End Function

		Public Shared Function RetrieveVPSales(ByVal proxy As OrganizationServiceProxy, ByRef ldapPath As String) As Guid
			Return RetrieveSystemUser("mtucker", "Michael", "Tucker", "Vice President of Sales", proxy, ldapPath)
		End Function

		Public Shared Function RetrieveMarketingManager(ByVal proxy As OrganizationServiceProxy) As Guid
			Dim ldapPath As String = String.Empty
			Return RetrieveMarketingManager(proxy, ldapPath)
		End Function

		Public Shared Function RetrieveMarketingManager(ByVal proxy As OrganizationServiceProxy, ByRef ldapPath As String) As Guid
			Return RetrieveSystemUser("ssmith", "Samantha", "Smith", "Marketing Manager", proxy, ldapPath)
		End Function

		Public Shared Function RetrieveAUserWithoutAnyRoleAssigned(ByVal proxy As OrganizationServiceProxy) As Guid
			Dim ldapPath As String = String.Empty
			Return RetrieveSystemUser("dpark", "Dan", "Park", "", proxy, ldapPath)
		End Function

        ''' <summary>
        ''' Retrieves the requested SystemUser record.  If the record does not exist, a new
        ''' Microsoft Dynamics CRM SystemUser record is created and an associated Active
        ''' Directory account is created, if it doesn't currently exist.
        ''' </summary>
        ''' <param name="userName">The username field as set in Microsoft Dynamics CRM</param>
        ''' <param name="firstName">The first name of the system user to be retrieved</param>
        ''' <param name="lastName">The last name of the system user to be retrieved</param>
        ''' <param name="roleStr">The string representing the Microsoft Dynamics CRM security
        ''' role for the user</param>
        ''' <param name="serviceProxy">The OrganizationServiceProxy object to your Microsoft
        ''' Dynamics CRM environment</param>
        ''' <param name="ldapPath">The LDAP path for your network - you can either call
        ''' ConsolePromptForLDAPPath() to prompt the user or provide a value in code</param>
        ''' <returns></returns>
        Public Shared Function RetrieveSystemUser(ByVal userName As String, ByVal firstName As String, ByVal lastName As String, _
                                                  ByVal roleStr As String, ByVal serviceProxy As OrganizationServiceProxy, _
                                                  ByRef ldapPath As String) As Guid
            Dim domain As String
            Dim userId As Guid = Guid.Empty

            If serviceProxy Is Nothing Then
                Throw New ArgumentNullException("serviceProxy")
            End If

            If String.IsNullOrWhiteSpace(userName) Then
                Throw New ArgumentNullException("UserName")
            End If

            If String.IsNullOrWhiteSpace(firstName) Then
                Throw New ArgumentNullException("FirstName")
            End If

            If String.IsNullOrWhiteSpace(lastName) Then
                Throw New ArgumentNullException("LastName")
            End If

            ' Obtain the current user's information.
            Dim who As New WhoAmIRequest()
            Dim whoResp As WhoAmIResponse = CType(serviceProxy.Execute(who), WhoAmIResponse)
            Dim currentUserId As Guid = whoResp.UserId

            Dim currentUser As SystemUser = serviceProxy.Retrieve(SystemUser.EntityLogicalName, currentUserId, _
                                                                        New ColumnSet("domainname")).ToEntity(Of SystemUser)()

            ' Extract the domain and create the LDAP object.
            Dim userPath() As String = currentUser.DomainName.Split(New Char() {"\"c})
            If userPath.Length > 1 Then
                domain = userPath(0) &amp; "\"
            Else
                domain = String.Empty
            End If


			Dim existingUser As SystemUser = GetUserIdIfExist(serviceProxy, domain, userName, firstName, lastName)


            If existingUser IsNot Nothing Then
                userId = existingUser.SystemUserId.Value

				If Not String.IsNullOrWhiteSpace(roleStr) Then
                ' Check to make sure the user is assigned the correct role.
                Dim role_Renamed As Role = RetrieveRoleByName(serviceProxy, roleStr)

                ' Associate the user with the role when needed.
                If Not UserInRole(serviceProxy, userId, role_Renamed.Id) Then
                    Dim associate As New AssociateRequest() With { _
                        .Target = New EntityReference(SystemUser.EntityLogicalName, userId), _
                        .RelatedEntities = New EntityReferenceCollection() From {New EntityReference(Role.EntityLogicalName, role_Renamed.Id)}, _
                        .Relationship = New Relationship("systemuserroles_association")}
                    serviceProxy.Execute(associate)
                End If
				End If
            Else
				' Create the system user in Microsoft Dynamics CRM if the user doesn't 
				' already exist.
                userId = CreateSystemUser(userName, firstName, lastName, domain, roleStr, serviceProxy, ldapPath)
            End If

            Return userId
        End Function

		''' <summary>
		''' Helper method to check if system user already exist with either given username or first and last name.
		''' </summary>
		''' <param name="serviceProxy">The OrganizationServiceProxy object to your Microsoft
		''' Dynamics CRM environment</param>
		''' <param name="domainName">Current domain name of the account.</param>
		''' <param name="userName">The username field as set in Microsoft Dynamics CRM</param>
		''' <param name="firstName">The first name of the system user to be retrieved</param>
		''' <param name="lastName">The last name of the system user to be retrieved</param>
		''' <returns></returns>
        Public Shared Function GetUserIdIfExist(ByVal serviceProxy As OrganizationServiceProxy,
                                                ByVal domainName As String,
                                                ByVal userName As String,
                                                ByVal firstName As String,
                                                ByVal lastName As String) As SystemUser
            Dim userQuery As QueryExpression = New QueryExpression With
                                               {
                                                   .EntityName = SystemUser.EntityLogicalName,
                                                   .ColumnSet = New ColumnSet("systemuserid")
                                               }
            userQuery.Criteria.Filters.Add(New FilterExpression(LogicalOperator.And))
            userQuery.Criteria.Filters(0).AddCondition(New ConditionExpression("domainname", ConditionOperator.Equal, domainName &amp; userName))
            userQuery.Criteria.Filters.Add(New FilterExpression(LogicalOperator.And))
            userQuery.Criteria.Filters(1).AddCondition(New ConditionExpression("firstname", ConditionOperator.Equal, firstName))
            userQuery.Criteria.Filters(1).AddCondition(New ConditionExpression("lastname", ConditionOperator.Equal, lastName))
            userQuery.Criteria.FilterOperator = LogicalOperator.Or

            Dim existingUsers As DataCollection(Of Entity) = CType(serviceProxy.RetrieveMultiple(userQuery).Entities, DataCollection(Of Entity))



            If existingUsers.Count > 0 Then
                Return existingUsers(0).ToEntity(Of SystemUser)()
            End If
            Return Nothing
        End Function

        Private Shared Function CreateSystemUser(ByVal userName As String, ByVal firstName As String, ByVal lastName As String, _
                                                 ByVal domain As String, ByVal roleStr As String, ByVal serviceProxy As OrganizationServiceProxy, _
                                                 ByRef ldapPath As String) As Guid
			CreateADAccount(userName, firstName, lastName, serviceProxy, ldapPath)

            ' Retrieve the default business unit needed to create the user.
            Dim businessUnitQuery As QueryExpression = New QueryExpression With { _
                .EntityName = BusinessUnit.EntityLogicalName,
                .ColumnSet = New ColumnSet("businessunitid")
            }
            businessUnitQuery.Criteria.AddCondition(
                New ConditionExpression("parentbusinessunitid",
                                        ConditionOperator.Null))

            Dim defaultBusinessUnit As BusinessUnit =
                serviceProxy.RetrieveMultiple(businessUnitQuery).Entities(0).ToEntity(Of BusinessUnit)()

            'Create a new system user.
            Dim user As SystemUser = New SystemUser With
                                     {
                                         .DomainName = domain &amp; userName,
                                         .FirstName = firstName,
                                         .LastName = lastName,
                                         .BusinessUnitId = New EntityReference With
                                                           {
                                                               .LogicalName = BusinessUnit.EntityLogicalName,
                                                               .Name = BusinessUnit.EntityLogicalName,
                                                               .Id = defaultBusinessUnit.Id
                                                           }
                                     }
			Dim userId As Guid = serviceProxy.Create(user)

			If Not String.IsNullOrWhiteSpace(roleStr) Then
            ' Retrieve the specified security role.
            Dim role_Renamed As Role = RetrieveRoleByName(serviceProxy, roleStr)

            ' Assign the security role to the newly created Microsoft Dynamics CRM user.
                Dim associate As New AssociateRequest() With
                    {
                        .Target = New EntityReference(SystemUser.EntityLogicalName, userId),
                        .RelatedEntities = New EntityReferenceCollection() From
                            {
                                New EntityReference(Role.EntityLogicalName, role_Renamed.Id)
                            },
                        .Relationship = New Relationship("systemuserroles_association")
                    }
            serviceProxy.Execute(associate)
			End If
            Return userId
        End Function

		''' <summary>
		''' Helper method to create an active directory account
		''' </summary>
		''' <param name="userName">The username field as set in Microsoft Dynamics CRM</param>
		''' <param name="firstName">The first name of the system user to be retrieved</param>
		''' <param name="lastName">The last name of the system user to be retrieved</param>
		''' <param name="serviceProxy">The OrganizationServiceProxy object to your Microsoft
		''' Dynamics CRM environment</param>
		''' <param name="ldapPath">The LDAP path for your network - you can either call
		''' ConsolePromptForLDAPPath() to prompt the user or provide a value in code</param>
		''' <returns>Return true if new account is created or return false if account already exist.</returns>
		Public Shared Function CreateADAccount(ByVal userName As String, ByVal firstName As String, ByVal lastName As String, ByVal serviceProxy As OrganizationServiceProxy, ByRef ldapPath As String) As Boolean
			' Check to make sure this is not Microsoft Dynamics CRM Online.
            If serviceProxy.ServiceConfiguration.AuthenticationType = AuthenticationProviderType.LiveId OrElse
                serviceProxy.ServiceConfiguration.AuthenticationType = AuthenticationProviderType.OnlineFederation Then
                Throw New Exception(String.Format("To run this sample, {0} {1} must be an active system user " &amp; vbLf _
                                                  &amp; "in your Microsoft Dynamics CRM Online organization.",
                                                  firstName, lastName))
            End If

			If String.IsNullOrEmpty(ldapPath) Then
				ldapPath = SystemUserProvider.ConsolePromptForLDAPPath()
			End If

			' Create an Active Directory user account if it doesn't exist already.
			If String.IsNullOrEmpty(ldapPath) Then
				Throw New ArgumentException("Required argument ldapPath was not provided.")
            End If
            Dim directoryEntry_Renamed As DirectoryEntry
            If serviceProxy.ClientCredentials.Windows IsNot Nothing Then
                Dim LUser As String = serviceProxy.ClientCredentials.Windows.ClientCredential.UserName
                Dim LPwd As String = serviceProxy.ClientCredentials.Windows.ClientCredential.Password
                directoryEntry_Renamed = New DirectoryEntry(ldapPath, LUser, LPwd)
            Else
                directoryEntry_Renamed = New DirectoryEntry(ldapPath)
            End If

			Dim userADAccount As DirectoryEntry = Nothing

			' Search AD to see if the user already exists.
			Dim search As New DirectorySearcher(directoryEntry_Renamed)
			search.Filter = String.Format("(sAMAccountName={0})", userName)
			search.PropertiesToLoad.Add("samaccountname")
			search.PropertiesToLoad.Add("givenname")
			search.PropertiesToLoad.Add("sn")
			search.PropertiesToLoad.Add("cn")
			Dim result As SearchResult = search.FindOne()
			Dim accountCreated As Boolean = False
			If result Is Nothing Then
				' Create the Active Directory account. 
				userADAccount = directoryEntry_Renamed.Children.Add("CN= " &amp; userName, "user")
				userADAccount.Properties("samAccountName").Value = userName
				userADAccount.Properties("givenName").Value = firstName
				userADAccount.Properties("sn").Value = lastName
				userADAccount.CommitChanges()
				accountCreated = True
			Else
				' Use the existing AD account.
				userADAccount = result.GetDirectoryEntry()
				accountCreated = False
			End If

			' Set the password for the account.
			Dim password As String = "pass@word1"
			userADAccount.Invoke("SetPassword", New Object() { password })
			userADAccount.CommitChanges()
			directoryEntry_Renamed.Close()
			userADAccount.Close()

			' Enable the newly created Active Directory account.
            userADAccount.Properties("userAccountControl").Value =
                CInt(Fix(userADAccount.Properties("userAccountControl").Value)) And Not &amp;H2
			userADAccount.CommitChanges()

			' Wait 10 seconds for the AD account to propagate.
			Thread.Sleep(10000)
			Return accountCreated
		End Function

        ''' <summary>
        ''' Helper method to prompt the user for the LDAP path for the network
        ''' </summary>
        ''' <returns>The LDAP path for your network</returns>
        Public Shared Function ConsolePromptForLDAPPath() As String
            ' Prompt for the LDAP path.
            Console.WriteLine("An Active Directory connection is required. Please enter an")
            Console.WriteLine("LDAP path for your network in the format 'LDAP://server/DC=subdomain,DC=domain,DC=com': ")
            Dim ldapPath As String = Console.ReadLine()

            Return ldapPath
        End Function

        Private Shared Function UserInRole(ByVal serviceProxy As OrganizationServiceProxy,
                                           ByVal userId As Guid, ByVal roleId As Guid) As Boolean
            ' Establish a SystemUser link for a query.
            Dim systemUserLink As New LinkEntity() With
                {
                    .LinkFromEntityName = SystemUserRoles.EntityLogicalName,
                    .LinkFromAttributeName = "systemuserid",
                    .LinkToEntityName = SystemUser.EntityLogicalName,
                    .LinkToAttributeName = "systemuserid"
                }
            systemUserLink.LinkCriteria.AddCondition(
                New ConditionExpression("systemuserid", ConditionOperator.Equal, userId))

            ' Build the query.
            Dim query As New QueryExpression() With
                {
                    .EntityName = Role.EntityLogicalName,
                    .ColumnSet = New ColumnSet("roleid")
                }
            query.Criteria.AddCondition(New ConditionExpression("roleid", ConditionOperator.Equal, roleId))
            Dim systemUserRoleLink As New LinkEntity() With
                {
                    .LinkFromEntityName = Role.EntityLogicalName,
                    .LinkFromAttributeName = "roleid",
                    .LinkToEntityName = SystemUserRoles.EntityLogicalName,
                    .LinkToAttributeName = "roleid"
                }
            systemUserRoleLink.LinkEntities.Add(systemUserLink)
            query.LinkEntities.Add(systemUserRoleLink)

            ' Retrieve matching roles.
            Dim ec As EntityCollection = serviceProxy.RetrieveMultiple(query)

            If ec.Entities.Count > 0 Then
                Return True
            End If

            Return False
        End Function

        Private Shared Function RetrieveRoleByName(ByVal serviceProxy As OrganizationServiceProxy,
                                                   ByVal roleStr As String) As Role
            Dim roleQuery As QueryExpression = New QueryExpression With
                                               {
                                                   .EntityName = Role.EntityLogicalName,
                                                   .ColumnSet = New ColumnSet("roleid")
                                               }
            roleQuery.Criteria.AddCondition(New ConditionExpression("name", ConditionOperator.Equal, roleStr))

            Return serviceProxy.RetrieveMultiple(roleQuery).Entities(0).ToEntity(Of Role)()
        End Function
    End Class
End Namespace

' </snippetsystemuserprovider>