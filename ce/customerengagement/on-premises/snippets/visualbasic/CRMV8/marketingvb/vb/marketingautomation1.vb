' <snippetmarketingautomation1>


                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy

                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()

                    '                    #Region "Create Dynamic List"

                    ' Create FetchXml for marketing list's query which locates accounts
                    ' in Seattle.
                    Dim fetchXml As String = _
                        "<fetch version='1.0' output-format='xml-platform' " _
                        &amp; "     mapping='logical' distinct='false'>" _
                        &amp; " <entity name='account'>" _
                        &amp; "     <attribute name='name' />" _
                        &amp; "     <attribute name='address1_city' />" _
                        &amp; "     <attribute name='primarycontactid' />" _
                        &amp; "     <attribute name='telephone1' />" _
                        &amp; "     <attribute name='accountid' />" _
                        &amp; "     <order attribute='name' descending='false' />" _
                        &amp; "     <filter type='and'>" _
                        &amp; "         <condition attribute='address1_city' " _
                        &amp; "                     operator='eq' value='seattle' />" _
                        &amp; "     </filter>" _
                        &amp; " </entity>" _
                        &amp; "</fetch>"

                    ' Create dynamic list. Set the type to true to declare a dynamic
                    ' list. Set CreatedFromCode to 1 for account member type.
                    Dim dynamicList As New List() With
                        {
                            .Type = True,
                            .ListName = "Dynamic List",
                            .CreatedFromCode = New OptionSetValue(CInt(ListCreatedFromCode.Account)),
                            .Query = fetchXml
                        }
                    _dynamicListId = _serviceProxy.Create(dynamicList)
                    dynamicList.Id = _dynamicListId

                    Console.WriteLine("Created dynamic list.")

                    '                    #End Region

                    '                    #Region "Associate dynamic list to campaign"
                    ' Create a campaign.
                    Dim campaign As New Campaign() With {.Name = "Sample Campaign"}
                    _campaignId = _serviceProxy.Create(campaign)
                    campaign.Id = _campaignId

                    ' Add the dynamic list to the campaign.
                    Dim addListToCampaignRequest As New AddItemCampaignRequest() With
                        {
                            .CampaignId = _campaignId,
                            .EntityId = _dynamicListId,
                            .EntityName = List.EntityLogicalName
                        }
                    _serviceProxy.Execute(addListToCampaignRequest)

                    Console.WriteLine("Added dynamic list to the campaign.")

                    ' Create a campaign activity to distribute fax to the list members.
                    Dim campaignActivity As New CampaignActivity() With
                        {.Subject = "Sample Campaign Activity",
                         .ChannelTypeCode = New OptionSetValue(CInt(CampaignActivityChannelTypeCode.Fax)),
                         .RegardingObjectId = campaign.ToEntityReference()}
                    _campaignActivityId = _serviceProxy.Create(campaignActivity)

                    ' Add dynamic list to campaign activity.
                    Dim addListToCampaignActivityRequest As _
                        New AddItemCampaignActivityRequest() With
                        {
                            .CampaignActivityId = _campaignActivityId,
                            .ItemId = _dynamicListId,
                            .EntityName = List.EntityLogicalName
                        }
                    _serviceProxy.Execute(addListToCampaignActivityRequest)

                    Console.WriteLine("Added dynamic list to the campaign activity.")

                    '                    #End Region

                    '                    #Region "Associate static list to campaign"

                    ' Copy the dynamic list to a static list.
                    Dim copyRequest As New CopyDynamicListToStaticRequest() With
                        {
                            .ListId = _dynamicListId
                        }
                    Dim copyResponse As CopyDynamicListToStaticResponse =
                        CType(_serviceProxy.Execute(copyRequest), 
                            CopyDynamicListToStaticResponse)
                    _staticListId = copyResponse.StaticListId

                    Console.WriteLine("Copied dynamic list to a static list.")

                    ' Add the static list to the campaign.
                    Dim addStaticListToCampaignRequest As _
                        New AddItemCampaignRequest() With
                        {
                            .CampaignId = _campaignId,
                            .EntityId = _staticListId,
                            .EntityName = List.EntityLogicalName
                        }
                    _serviceProxy.Execute(addStaticListToCampaignRequest)

                    Console.WriteLine("Added static list to the campaign.")

                    ' Add the static list to the campaign activity.
                    Dim addStaticListToCampaignActivityRequest As _
                        New AddItemCampaignActivityRequest() With
                        {
                            .CampaignActivityId = _campaignActivityId,
                            .ItemId = _staticListId,
                            .EntityName = List.EntityLogicalName
                        }
                    _serviceProxy.Execute(addStaticListToCampaignActivityRequest)

                    Console.WriteLine("Added static list to the campaign's activity.")

                    '                    #End Region

'		#Region "Create fax for campaign's activity"
                    ' Create a fax.
                    Dim fax As New Fax() With {.Subject = "Example Fax"}

                    Console.WriteLine("Created fax for campaign's activity.")
'		#End Region ' Create fax for campaign's activity

'					#Region "Distribute fax to the marketing list"
                    ' Distribute the campaign activity to the marketing lists.
                    Dim distributeRequest As New DistributeCampaignActivityRequest() With
                        {
                            .CampaignActivityId = _campaignActivityId,
                            .Activity = fax,
                            .Owner = New EntityReference("systemuser", _salesManagerId),
                            .Propagate = True,
                            .SendEmail = False,
                            .PostWorkflowEvent = True
                        }
                    _serviceProxy.Execute(distributeRequest)

                    Console.WriteLine("Distributed fax to the marketing lists.")
                    '					#End Region ' Distribute fax to the marketing list

'					#Region "Retrieve collection of entities from marketing list"
					' Retrieve a collection of entities that correspond 
					' to all of the members in a marketing list
					' This approach of retrieving list members allows you to dynamically
					' retrieve the members of a list programmatically without requiring 
					' knowledge of the member entity type.
					Dim orgContext As New OrganizationServiceContext(_serviceProxy)

					Dim member = ( _
					    From mb In orgContext.CreateQuery(Of List)() _
					    Where mb.Id = _dynamicListId _
					    Select mb).FirstOrDefault()

					Dim fetchQuery As String = member.Query

					Dim memberRequest As New RetrieveMultipleRequest()
					Dim fetch As New FetchExpression(fetchQuery)
					memberRequest.Query = fetch
					Dim memberResponse As RetrieveMultipleResponse = CType(_serviceProxy.Execute(memberRequest), RetrieveMultipleResponse)

					Console.WriteLine("Retrieved collection of entities from a marketing list.")
'					#End Region ' Retrieve collection of entities from marketing list
                    DeleteRequiredRecords(promptforDelete)

                End Using

' </snippetmarketingautomation1>