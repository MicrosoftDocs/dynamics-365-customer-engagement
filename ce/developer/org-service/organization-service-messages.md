---
title: "Organization service messages in Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This topic shows the messages available in the Dynamics 365 namespace"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8d7119a7-6cb4-41c8-bf93-a40041f2b5a0
caps.latest.revision: 75
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Organization service messages in Dynamics 365 Customer Engagement

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The <xref:Microsoft.Crm.Sdk.Messages> namespace contains all the messages you need to work with the data stored in any entity. The solution messages are also in this namespace.  
  
 Messages are used with the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method. Most messages available in this namespace apply to all three deployment types. The request page for each message indicates which deployment types support the message. The deployment types are:  
  
- [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement - On-premises deployment  
  
- [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] – Internet-facing deployment (IFD)  
  
- [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)]  
  
 The request page also indicates whether the message works while online (connected to the server) or offline (disconnected from the server).  

 [!INCLUDE[cc_sdk_onpremises_note](../../includes/cc-sdk-onpremises-note.md)]
  
## Messages  
 The following table shows the messages available in the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] namespace.  
  
|Message request class|Description|  
|---------------------------|-----------------|  
|<xref:Microsoft.Crm.Sdk.Messages.AddChannelAccessProfilePrivilegesRequest>|Adds entity privileges to a channel access profile.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignActivityRequest>|Adds an item to a campaign activity.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignRequest>|Adds an item to a campaign. The item added must be one of the following entity types: campaign, list, product, or salesliterature.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddListMembersListRequest>|Adds a list of members to a list.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddMemberListRequest>|Adds a member to a list. The member added must be one of the following entity types: account, contact, or lead.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddMembersTeamRequest>|Adds members to a team.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddToQueueRequest>|Moves an entity record from a source queue to a destination queue.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddPrivilegesRoleRequest>|Adds a set of existing privileges to an existing role.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddProductToKitRequest>|Adds a product to a kit.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddRecurrenceRequest>|Adds recurrence information to an existing appointment to make it a recurring appointment master.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddSolutionComponentRequest>|Adds a solution component to an unmanaged solution.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddSubstituteProductRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Establishes an association between a product and a substitute product.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddToQueueRequest>|Moves a record from a source queue to a destination queue.|  
|<xref:Microsoft.Crm.Sdk.Messages.AddUserToRecordTeamRequest>|Adds a user to the auto created access team for the specified record.|  
|<xref:Microsoft.Crm.Sdk.Messages.ApplyRecordCreationAndUpdateRuleRequest>|Contains data to apply record creating and update rule to incoming activities in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].|  
|<xref:Microsoft.Crm.Sdk.Messages.ApplyRoutingRuleRequest>|Applies the active routing rule to the incident (case).|  
|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|Assigns the specified record to a new security principal (user). This changes the `ownerid` attribute of the instance.|  
|<xref:Microsoft.Crm.Sdk.Messages.AssociateEntitiesRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Adds a link between two records in a many-to-many relationship.|  
|<xref:Microsoft.Crm.Sdk.Messages.AutoMapEntityRequest>|Creates the attribute mappings between two entities.|  
|<xref:Microsoft.Crm.Sdk.Messages.BackgroundSendEmailRequest>|Sends an email asynchronously.|  
|<xref:Microsoft.Crm.Sdk.Messages.BookRequest>|Schedules or "books" an appointment.|  
|<xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest>|Submits an asynchronous bulk delete job.|  
|<xref:Microsoft.Crm.Sdk.Messages.BulkDetectDuplicatesRequest>|Submits an asynchronous duplicates detection job.|  
|<xref:Microsoft.Crm.Sdk.Messages.CalculateActualValueOpportunityRequest>|Calculates the value of an opportunity that is in the "Won" state.|  
|<xref:Microsoft.Crm.Sdk.Messages.CalculateTotalTimeIncidentRequest>|Calculates the total number of minutes spent on an incident (case).|  
|<xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest>|Defines custom pricing for your products in opportunities, quotes, orders, and invoices.|  
|<xref:Microsoft.Crm.Sdk.Messages.CalculateRollupFieldRequest>|Calculates a rollup attribute value on demand.|  
|<xref:Microsoft.Crm.Sdk.Messages.CancelContractRequest>|Cancels a contract.|  
|<xref:Microsoft.Crm.Sdk.Messages.CancelSalesOrderRequest>|Cancels a sales order.|  
|<xref:Microsoft.Crm.Sdk.Messages.CheckIncomingEmailRequest>|Checks whether the incoming email message is relevant to the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] system.|  
|<xref:Microsoft.Crm.Sdk.Messages.CheckPromoteEmailRequest>|Checks whether the incoming email message should be promoted to the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] system.|  
|<xref:Microsoft.Crm.Sdk.Messages.CloneAsPatchRequest>|Creates a solution patch from a managed or unmanaged solution.|  
|<xref:Microsoft.Crm.Sdk.Messages.CloneAsSolutionRequest>|Creates a new copy of an unmanaged solution that contains the original solution plus all of its patches.|  
|<xref:Microsoft.Crm.Sdk.Messages.CloneContractRequest>|Copies an existing contract and its line items.|  
|<xref:Microsoft.Crm.Sdk.Messages.CloneProductRequest>|Clones a product family, product, or bundle record, and creates a copy of the record under the same parent node.|  
|<xref:Microsoft.Crm.Sdk.Messages.CloseIncidentRequest>|Closes an incident (case).|  
|<xref:Microsoft.Crm.Sdk.Messages.CloseQuoteRequest>|Closes a quote.|  
|<xref:Microsoft.Crm.Sdk.Messages.CompoundCreateRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Creates a compound entity (salesorder, invoice, quote, or duplicaterule) and its related entity (salesorderdetail, invoicedetail, quotedetail, or duplicaterulecondition).|  
|<xref:Microsoft.Crm.Sdk.Messages.CompoundUpdateDuplicateDetectionRuleRequest>|Updates a duplicate detection rule and its conditions.|  
|<xref:Microsoft.Crm.Sdk.Messages.CompoundUpdateRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Updates a compound record (salesorder, invoice, quote or duplicaterule) and its related detail record (salesorderdetail, invoicedetail, quotedetail or duplicaterulecondition).|  
|<xref:Microsoft.Crm.Sdk.Messages.ConvertKitToProductRequest>|Converts a kit to a product.|  
|<xref:Microsoft.Crm.Sdk.Messages.ConvertOwnerTeamToAccessTeamRequest>|Converts a team of type owner to a team of type access.|  
|<xref:Microsoft.Crm.Sdk.Messages.ConvertProductToKitRequest>|Converts a product to a kit.|  
|<xref:Microsoft.Crm.Sdk.Messages.ConvertQuoteToSalesOrderRequest>|Converts a quote to a sales order.|  
|<xref:Microsoft.Crm.Sdk.Messages.ConvertSalesOrderToInvoiceRequest>|Converts a sales order to an invoice.|  
|<xref:Microsoft.Crm.Sdk.Messages.CopyCampaignRequest>|Copies a campaign.|  
|<xref:Microsoft.Crm.Sdk.Messages.CopyCampaignResponseRequest>|Copies the information from one campaign response to another, and optionally creates a campaign response template.|  
|<xref:Microsoft.Crm.Sdk.Messages.CopyDynamicListToStaticRequest>|Creates a static list from the specified dynamic list and adds the members that satisfy the dynamic list query criteria to the static list.|  
|<xref:Microsoft.Crm.Sdk.Messages.CopyMembersListRequest>|Copies the members from the source list to the target list without creating duplicates.|  
|<xref:Microsoft.Crm.Sdk.Messages.CopySystemFormRequest>|Creates a new entity form that is based on an existing entity form.|  
|<xref:Microsoft.Crm.Sdk.Messages.CreateActivitiesListRequest>|Creates the activities for a list.|  
|<xref:Microsoft.Crm.Sdk.Messages.CreateExceptionRequest>|Creates an exception for the recurring appointment instance.|  
|<xref:Microsoft.Crm.Sdk.Messages.CreateInstanceRequest>|Creates future unexpanded instances of a recurring appointment master.|  
|<xref:Microsoft.Crm.Sdk.Messages.CreateKnowledgeArticleTranslationRequest>|Creates a translation of a knowledge article record.|  
|<xref:Microsoft.Crm.Sdk.Messages.CreateKnowledgeArticleVersionRequest>|Creates a major or minor version of a knowledge article record.|  
|<xref:Microsoft.Crm.Sdk.Messages.CreateWorkflowFromTemplateRequest>|Creates a workflow from a workflow template.|  
|<xref:Microsoft.Crm.Sdk.Messages.DeleteAndPromoteRequest>|Replaces a managed solution plus all of its patches.|  
|<xref:Microsoft.Crm.Sdk.Messages.DeleteAuditDataRequest>|Deletes all partitions containing audit data created before a given end date.|  
|<xref:Microsoft.Crm.Sdk.Messages.DeleteOpenInstancesRequest>|Deletes instances of a recurring appointment master that have an Open state.|  
|<xref:Microsoft.Crm.Sdk.Messages.DeliverIncomingEmailRequest>|Creates an email activity instance from an incoming email message.|  
|<xref:Microsoft.Crm.Sdk.Messages.DeliverPromoteEmailRequest>|Creates an email activity instance from the specified email message.|  
|<xref:Microsoft.Crm.Sdk.Messages.DeprovisionLanguageRequest>|Deprovisions a language.|  
|<xref:Microsoft.Crm.Sdk.Messages.DisassociateEntitiesRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Removes a link between two records in a many to many relationship.|  
|<xref:Microsoft.Crm.Sdk.Messages.DistributeCampaignActivityRequest>|Creates a bulk operation to distribute the activity, creating the appropriate activity for each member in the list for the specified campaign activity.|  
|<xref:Microsoft.Crm.Sdk.Messages.DownloadReportDefinitionRequest>|Downloads a report definition.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExecuteByIdSavedQueryRequest>|Executes a saved query (view) that has the specified ID.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExecuteByIdUserQueryRequest>|Executes the user query (saved view) that has the specified ID.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExecuteFetchRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Executes the specified Fetch XML query.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExecuteWorkflowRequest>|Executes a workflow.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExpandCalendarRequest>|Converts the calendar rules to an array of available time blocks for the specified period.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExportMappingsImportMapRequest>|Exports an import data map to an XML file.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExportFieldTranslationRequest>|Exports localizable attributes for translation.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExportSolutionRequest>|Exports a managed or unmanaged solution.|  
|<xref:Microsoft.Crm.Sdk.Messages.ExportTranslationRequest>|Exports all translations for a specific solution to a compressed file.|  
|<xref:Microsoft.Crm.Sdk.Messages.FetchXmlToQueryExpressionRequest>|Converts a query in Fetch XML to a QueryExpression.|  
|<xref:Microsoft.Crm.Sdk.Messages.FindParentResourceGroupRequest>|Finds a parent resource group (scheduling group) for the specified resource groups (scheduling groups).|  
|<xref:Microsoft.Crm.Sdk.Messages.FulfillSalesOrderRequest>|Fulfills a sales order (order).|  
|<xref:Microsoft.Crm.Sdk.Messages.FullTextSearchKnowledgeArticleRequest>|Performs a full-text search on knowledge articles in Dynamics 365 using the specified search text.|  
|<xref:Microsoft.Crm.Sdk.Messages.GenerateInvoiceFromOpportunityRequest>|Generates an invoice from an opportunity.|  
|<xref:Microsoft.Crm.Sdk.Messages.GenerateQuoteFromOpportunityRequest>|Generates a quote from an opportunity.|  
|<xref:Microsoft.Crm.Sdk.Messages.GenerateSalesOrderFromOpportunityRequest>|Generates a sales order from an opportunity.|  
|<xref:Microsoft.Crm.Sdk.Messages.GenerateSocialProfileRequest>|Returns an existing social profile record if one exists, otherwise generates a new one and returns it.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetAllTimeZonesWithDisplayNameRequest>|Retrieves all the time-zone definitions for the specified locale returning only the display name attribute.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetDecryptionKeyRequest>|Gets a decryption key.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetDefaultPriceLevelRequest>|Contains the data that is needed to retrieve the default price level (price list) for the current user based on the user’s territory relationship with the price list.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetDistinctValuesImportFileRequest>|Returns distinct values for a column in the source file that contains list values.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetHeaderColumnsImportFileRequest>|Retrieves the source-file column headings, or system-generated column headings, if the source file does not contain column headings.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetInvoiceProductsFromOpportunityRequest>|Retrieves the products from an opportunity and copies them to the specified invoice.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetQuantityDecimalRequest>|Gets the quantity decimal value for a product.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetQuoteProductsFromOpportunityRequest>|Retrieves the products from an opportunity and copies them to the quote.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetReportHistoryLimitRequest>|Gets the history limit for a report.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetSalesOrderProductsFromOpportunityRequest>|Retrieves the products from an opportunity and copies them to the sales order.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetTimeZoneCodeByLocalizedNameRequest>|Retrieves the time-zone code for the specified localized time-zone name.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetTrackingTokenEmailRequest>|Returns a tracking token that can be then passed in as a parameter to the <xref:Microsoft.Crm.Sdk.Messages.SendEmailRequest> message.|  
|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|Grants a security principal (user or team) access to the specified record.|  
|<xref:Microsoft.Crm.Sdk.Messages.ImportFieldTranslationRequest>|Imports localizable attributes for translation.|  
|<xref:Microsoft.Crm.Sdk.Messages.ImportMappingsImportMapRequest>|Imports XML mappings and creates an import data map.|  
|<xref:Microsoft.Crm.Sdk.Messages.ImportRecordsImportRequest>|Submits an asynchronous job that uploads the transformed data into [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|  
|<xref:Microsoft.Crm.Sdk.Messages.ImportSolutionRequest>|Imports a managed or unmanaged solution.|  
|<xref:Microsoft.Crm.Sdk.Messages.ImportTranslationRequest>|Imports all translations from a compressed file.|  
|<xref:Microsoft.Crm.Sdk.Messages.IncrementKnowledgeArticleViewCountRequest>|Increments the per day view count of a knowledge article record.|  
|<xref:Microsoft.Crm.Sdk.Messages.InitializeFromRequest>|Initializes a new record from an existing record.|  
|<xref:Microsoft.Crm.Sdk.Messages.InstallSampleDataRequest>|Installs sample data for an organization.|  
|<xref:Microsoft.Crm.Sdk.Messages.InstantiateFiltersRequest>|Instantiates a filter.|  
|<xref:Microsoft.Crm.Sdk.Messages.InstantiateTemplateRequest>|Creates an email message from a template.|  
|<xref:Microsoft.Crm.Sdk.Messages.IsBackOfficeInstalledRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Checks if [!INCLUDE[pn_MS_Great_Plains](../../includes/pn-ms-great-plains.md)] is installed.|  
|<xref:Microsoft.Crm.Sdk.Messages.IsComponentCustomizableRequest>|Determines whether a solution component is customizable.|  
|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|Checks to see if the state transition is valid.|  
|<xref:Microsoft.Crm.Sdk.Messages.LocalTimeFromUtcTimeRequest>|Retrieves the local time for the specified Universal Time Coordinate (UTC) time.|  
|<xref:Microsoft.Crm.Sdk.Messages.LockInvoicePricingRequest>|Locks the total price of products and services specified in the invoice. When the invoice pricing is locked, changes to underlying price lists (price levels) do not affect the prices for an invoice.|  
|<xref:Microsoft.Crm.Sdk.Messages.LockSalesOrderPricingRequest>|Locks the total price of products and services specified in the sales order (order). When the sales order pricing is locked, changes to underlying price lists (price levels) do not affect the prices for a sales order (order).|  
|<xref:Microsoft.Crm.Sdk.Messages.LoseOpportunityRequest>|Sets the state of an opportunity to Lost.|  
|<xref:Microsoft.Crm.Sdk.Messages.MakeAvailableToOrganizationReportRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Makes the report available to all users in the organization.|  
|<xref:Microsoft.Crm.Sdk.Messages.MakeAvailableToOrganizationTemplateRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Makes the specified email template available to the entire organization.|  
|<xref:Microsoft.Crm.Sdk.Messages.MakeUnavailableToOrganizationReportRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Makes the report unavailable to all users in the organization.|  
|<xref:Microsoft.Crm.Sdk.Messages.MakeUnavailableToOrganizationTemplateRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Makes the specified email template no longer available to the entire organization.|  
|<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|Merges the information from two records of the same type.|  
|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|Replaces the access rights on the target record for the specified security principal (user or team).|  
|<xref:Microsoft.Crm.Sdk.Messages.ParseImportRequest>|Submits an asynchronous job that parses all import files associated with the specified data import (import).|  
|<xref:Microsoft.Crm.Sdk.Messages.PickFromQueueRequest>|Assigns a queue item to a user and optionally remove the queue item from the queue.|  
|<xref:Microsoft.Crm.Sdk.Messages.ProcessInboundEmailRequest>|Processes marketing campaign email responses.|  
|<xref:Microsoft.Crm.Sdk.Messages.PropagateByExpressionRequest>|Distributes an activity to a quick campaign.|  
|<xref:Microsoft.Crm.Sdk.Messages.ProvisionLanguageRequest>|Provisions a language.|  
|<xref:Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest>|Publishes all customizations.|  
|<xref:Microsoft.Crm.Sdk.Messages.PublishDuplicateRuleRequest>|Submits an asynchronous job to publish a duplicate rule.|  
|<xref:Microsoft.Crm.Sdk.Messages.PublishProductHierarchyRequest>|Publishes a product family hierarchy including the child products and bundles.|  
|<xref:Microsoft.Crm.Sdk.Messages.PublishThemeRequest>|Publishes a theme.|  
|<xref:Microsoft.Crm.Sdk.Messages.PublishXmlRequest>|Publishes the customizations for the specified entities.|  
|<xref:Microsoft.Crm.Sdk.Messages.QualifyLeadRequest>|Qualifies a lead and creates an account, contact, or opportunity records that are linked to the originating lead.|  
|<xref:Microsoft.Crm.Sdk.Messages.QualifyMemberListRequest>|Qualifies the specified member list and either overrides the list members or removes them according to the specified option.|  
|<xref:Microsoft.Crm.Sdk.Messages.QueryExpressionToFetchXmlRequest>|Converts a query represented as a `QueryExpression` class to the equivalent query represented as FetchXML.|  
|<xref:Microsoft.Crm.Sdk.Messages.QueryMultipleSchedulesRequest>|Searches multiple resources for an available time slot matching the specified parameters. This is similar to the QuerySchedule message but it works for multiple resources at one time.|  
|<xref:Microsoft.Crm.Sdk.Messages.QueryScheduleRequest>|Searches the specified resource for an available time slot matching the specified parameters.|  
|<xref:Microsoft.Crm.Sdk.Messages.ReassignObjectsOwnerRequest>|Reassigns all records that are owned by the security principal (user or team) to another security principal (user or team).|  
|<xref:Microsoft.Crm.Sdk.Messages.ReassignObjectsSystemUserRequest>|Reassigns all records that are owned by the user to another security principal (user or team).|  
|<xref:Microsoft.Crm.Sdk.Messages.RecalculateRequest>|Recalculates the rollup attribute values for all goals in the goal hierarchy that contain a specified goal.|  
|<xref:Microsoft.Crm.Sdk.Messages.ReleaseToQueueRequest>|Assigns a queue item back to the queue owner so others can pick it.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveFromQueueRequest>|Removes a queue item from a queue.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignActivityRequest>|Removes an item from a campaign activity.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveItemCampaignRequest>|Removes an item from a campaign.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveMemberListRequest>|Removes a member from a list.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveMembersTeamRequest>|Removes members from a team.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveParentRequest>|Removes the parent for a record.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemovePrivilegeRoleRequest>|Removes a privilege from an existing role.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveProductFromKitRequest>|Removes a product from a kit.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveRelatedRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Removes the relationship between two records as defined by the target classes listed below. For example, remove the relationship between an invoice and a contact.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveSolutionComponentRequest>|Removes a solution component to an unmanaged solution.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveSubstituteProductRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Removes the association between a product and a substitute product.|  
|<xref:Microsoft.Crm.Sdk.Messages.RemoveUserFromRecordTeamRequest>|Removes a user from the auto created access team for the specified record.|  
|<xref:Microsoft.Crm.Sdk.Messages.RenewContractRequest>|Renews a contract.|  
|<xref:Microsoft.Crm.Sdk.Messages.RenewEntitlementRequest>|Renews an entitlement.|  
|<xref:Microsoft.Crm.Sdk.Messages.ReplacePrivilegesRoleRequest>|Replaces the privilege set of an existing role. This effectively deletes all existing privileges from the role and adds the new specified privileges.|  
|<xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>|Reschedules an appointment, service appointment or recurring appointment.|  
|<xref:Microsoft.Crm.Sdk.Messages.ResetUserFiltersRequest>|Resets the offline data filters for the calling user to the default filters for the organization.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveAbsoluteAndSiteCollectionUrlRequest>|Retrieves the absolute (complete) URL and the site collection URL of a [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] document location or [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] site.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveAllChildUsersSystemUserRequest>|Retrieves a collection of system users who report to the specified system user.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveApplicationRibbonRequest>|Retrieves the core application ribbons including the entity template.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveAttributeChangeHistoryRequest>|Retrieves all changes to a specific attribute.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveAuditDetailsRequest>|Retrieves the full audit details of a particular audit record.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveAuditPartitionListRequest>|Retrieves the list of auditing partitions.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveAvailableLanguagesRequest>|Retrieves the list of available languages.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveBusinessHierarchyBusinessUnitRequest>|Retrieves all the business units in the business unit hierarchy.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveByGroupResourceRequest>|Retrieves all the resource groups to which the specified resource belongs.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveByResourceResourceGroupRequest>|Retrieves the resource groups that contain the specified resource.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveByResourcesServiceRequest>|Retrieves a collection of services related to the specified set of services.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveByTopIncidentProductKbArticleRequest>|Retrieves the top ten knowledge base articles for the product specified.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveByTopIncidentSubjectKbArticleRequest>|Retrieves the top ten knowledge base articles for the subject specified.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveChannelAccessProfilePrivilegesRequest>|Retrieves the channel access profile with entity privileges.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveCurrentOrganizationRequest>|Retrieves organization information from the organization service rather than the discovery service.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveDependenciesForDeleteRequest>|Retrieves the dependencies for solution components that will prevent a solution component from being deleted.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveDependenciesForUninstallRequest>|Retrieves the dependencies for solution components that could prevent uninstalling a managed solution.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveDependentComponentsRequest>|Retrieves all components that depend on the specified component.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveDeploymentLicenseTypeRequest>|Retrieves the type of license for a deployment of [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveDeprovisionedLanguagesRequest>|Retrieves the list of language packs installed on the server that have been disabled.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveDuplicatesRequest>|Detects and retrieves duplicate records for the specified record, provided duplicate detection is enabled and there are published duplicate detection rules for the entity.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveEntityRibbonRequest>|Retrieves the ribbon definition used for a specific entity.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveExchangeRateRequest>|Retrieves the exchange rate.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveFilteredFormsRequest>|Retrieves the system forms for the specified user.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveFormattedImportJobResultsRequest>|Retrieves the formatted results from an import job.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveFormXmlRequest>|[!INCLUDE[internal](../../includes/internal.md)]|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveInstalledLanguagePacksRequest>|Retrieves the list of language packs installed on the server.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveInstalledLanguagePackVersionRequest>|Retrieves the version of an installed language pack.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveLicenseInfoRequest>|Retrieves the number of licenses for a deployment of [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveLocLabelsRequest>|Retrieves the localized labels for the specified attribute.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveMailboxTrackingFoldersRequest>|Retrieves folder mapping rules for a user.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveMembersBulkOperationRequest>|Retrieves the members of a bulk operation.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveMembersTeamRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Retrieves the members of a team.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveMissingComponentsRequest>|Retrieves a list of missing components for the target organization.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveMissingDependenciesRequest>|Verifies whether any solution components are not included in the solution but possibly should be for a complete solution to be exported.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveOrganizationResourcesRequest>|Retrieves the resources used by an organization.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveParentGroupsResourceGroupRequest>|Retrieves a collection of the parent resource groups of the specified resource group (scheduling group).|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveParsedDataImportFileRequest>|Retrieves the data from the parse table.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrievePersonalWallRequest>|Retrieves pages of posts, with comments for each post, for all records that the calling user follows.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|Retrieves the access rights the specified security principal (user or team) has to a record.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAttributePrivilegesRequest>|Retrieves all the secured attribute privileges a user or team has through direct or indirect (through team membership) associations with the FieldSecurityProfile entity.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalSyncAttributeMappingsRequest>|Retrieves the synchronization attribute mapping information that defines the flow of data from the server to client application.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrivilegeSetRequest>|Retrieves the set of privileges defined in the system.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveProductPropertiesRequest>|Retrieves all the property instances (dynamic property instances) for a product added to an opportunity, quote, order, or invoice.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveProvisionedLanguagePackVersionRequest>|Retrieves the version of the language packs installed on the server.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveProvisionedLanguagesRequest>|Retrieves the list of language packs installed on the server that are enabled.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveRecordChangeHistoryRequest>|Retrieves all changes to a specific entity.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveRecordWallRequest>|Retrieves pages of posts, with comments for each post, for a specific record.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveRequiredComponentsRequest>|Retrieves all components that this component requires.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveRolePrivilegesRoleRequest>|Retrieves the privileges that are assigned to the specified role.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|Retrieves all the security principals (users or teams) that have access to a record, together with their access rights to the record.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSubGroupsResourceGroupRequest>|Retrieves a collection of the child resource groups of the specified resource group (scheduling group).|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSubsidiaryTeamsBusinessUnitRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Retrieves all the team information for child business units of the specified business unit.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSubsidiaryUsersBusinessUnitRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Retrieves all system users for the child business units of the specified business unit.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveTeamPrivilegesRequest>|Retrieves the privileges for a team.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveTeamsSystemUserRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Retrieves a collection of teams of which the specified system user is a member.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUnpublishedMultipleRequest>|Retrieves the current saved definitions of Web resources, organization-owned charts, or organization-owned dashboards, whether they have been published or not.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUnpublishedRequest>|Retrieves the current saved definition of a Web resource, organization-owned chart, or organization-owned dashboard, whether is has been published or not.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUserPrivilegesRequest>|Retrieves all the privileges a system user (user) has through his or her roles in the specified business unit.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUserSettingsSystemUserRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Retrieves the system user settings for the specified system user.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveVersionRequest>|Retrieves the version number of the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] server.|  
|<xref:Microsoft.Crm.Sdk.Messages.RevertProductRequest>|Reverts a product family, product, or bundle record to its last Active state. All the product property (attribute) changes done to the record since it was last published (Active state) will be lost.|  
|<xref:Microsoft.Crm.Sdk.Messages.ReviseQuoteRequest>|Sets the state of a quote to Draft.|  
|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|Removes all access to a record for the specified security principal (user or team).|  
|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|Retrieves all the records related to the specified record (account or contact). This applies to all activity entities, annotation (note), contract, incident (case), invoice, opportunity, quote and sales order (order) entities.|  
|<xref:Microsoft.Crm.Sdk.Messages.RouteToRequest>|Routes a queue item to a different user or queue.|  
|<xref:Microsoft.Crm.Sdk.Messages.SearchByBodyKbArticleRequest>|Finds all the document indexes that contain the specified text in the body.|  
|<xref:Microsoft.Crm.Sdk.Messages.SearchByKeywordsKbArticleRequest>|Finds all the document indexes that contain the specified keywords.|  
|<xref:Microsoft.Crm.Sdk.Messages.SearchByTitleKbArticleRequest>|Finds all the document indexes that contain the specified text in the title.|  
|<xref:Microsoft.Crm.Sdk.Messages.SearchRequest>|Searches for available time slots that fulfill the specified appointment request.|  
|<xref:Microsoft.Crm.Sdk.Messages.SendBulkMailRequest>|Sends bulk email messages.|  
|<xref:Microsoft.Crm.Sdk.Messages.SendEmailFromTemplateRequest>|Sends an email message using a template.|  
|<xref:Microsoft.Crm.Sdk.Messages.SendEmailRequest>|Sends an email message.|  
|<xref:Microsoft.Crm.Sdk.Messages.SendFaxRequest>|Sends a fax.|  
|<xref:Microsoft.Crm.Sdk.Messages.SendTemplateRequest>|Sends a bulk email message that is created from a template.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetBusinessEquipmentRequest>|Sets the business that owns the equipment.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetBusinessSystemUserRequest>|Sets the business unit for the specified system user.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetLocLabelsRequest>|Sets the localized labels for the specified attribute.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetParentBusinessUnitRequest>|Sets the parent (manager) for the specified business unit.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetParentSystemUserRequest>|Sets the parent (manager) for the specified system user.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetParentTeamRequest>|Sets the parent (manager) for the specified team.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetProcessRequest>|Sets the process that associates with a given target entity.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetRelatedRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Creates a link between an opportunity and an account, contact, or competitor.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetReportRelatedRequest>|Specifies in which areas of [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] the report can be run and viewed.|  
|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|Sets the state of a record.|  
|<xref:Microsoft.Crm.Sdk.Messages.TransformImportRequest>|Submits an asynchronous job to transform the parsed data.|  
|<xref:Microsoft.Crm.Sdk.Messages.TriggerServiceEndpointCheckRequest>|Validates the configuration of a [!INCLUDE[pn_Windows_Azure](../../includes/pn-windows-azure.md)] solution’s service endpoint.|  
|<xref:Microsoft.Crm.Sdk.Messages.UninstallSampleDataRequest>|Uninstalls sample data for an organization.|  
|<xref:Microsoft.Crm.Sdk.Messages.UnlockInvoicePricingRequest>|Unlocks the price per unit for the products in the specified invoice.|  
|<xref:Microsoft.Crm.Sdk.Messages.UnlockSalesOrderPricingRequest>|Unlocks the price per unit for the products in the specified sales order (order).|  
|<xref:Microsoft.Crm.Sdk.Messages.UnpublishDuplicateRuleRequest>|Unpublishes a duplicate rule.|  
|<xref:Microsoft.Crm.Sdk.Messages.UpdateProductPropertiesRequest>|Updates all the retrieved property instances (dynamic property instances) for a product added to an opportunity, quote, order, or invoice.|  
|<xref:Microsoft.Crm.Sdk.Messages.UpdateSolutionComponentRequest>|Updates a component in an unmanaged solution.|  
|<xref:Microsoft.Crm.Sdk.Messages.UpdateUserSettingsSystemUserRequest>|[!INCLUDE[deprecated](../../includes/deprecated.md)] Updates the user settings for a system user.|  
|<xref:Microsoft.Crm.Sdk.Messages.UtcTimeFromLocalTimeRequest>|Retrieves the UTC time for the specified local time.|  
|<xref:Microsoft.Crm.Sdk.Messages.ValidateRecurrenceRuleRequest>|Validates a recurrence rule for a recurring appointment.|  
|<xref:Microsoft.Crm.Sdk.Messages.ValidateRequest>|Validates that all the constraints of an appointment or service appointment are met.|  
|<xref:Microsoft.Crm.Sdk.Messages.ValidateSavedQueryRequest>|Validates a saved query.|  
|<xref:Microsoft.Crm.Sdk.Messages.WhoAmIRequest>|Retrieves the user information for the logged on user.|  
|<xref:Microsoft.Crm.Sdk.Messages.WinOpportunityRequest>|Changes the state of an opportunity to Won.|  
|<xref:Microsoft.Crm.Sdk.Messages.WinQuoteRequest>|Changes the state of a quote to Won.|  
  
### See also  
 [Web Services: IOrganizationService](use-organization-service-read-write-data-metadata.md)   
 [IOrganizationService entities](organization-service-entities.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages>