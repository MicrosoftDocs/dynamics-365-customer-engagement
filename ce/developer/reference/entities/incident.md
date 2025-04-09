---
title: "Case (Incident) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Case (Incident) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Case (Incident) table/entity reference (Microsoft Dynamics 365)

Service request case associated with a contract.

## Messages

The following table lists the messages for the Case (Incident) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `ApplyRoutingRule`<br />Event: False |**ApplyRoutingRule action** |<xref:Microsoft.Crm.Sdk.Messages.ApplyRoutingRuleRequest>|
| `Assign`<br />Event: True |`PATCH` /incidents(*incidentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `CalculateTotalTimeIncident`<br />Event: False |**CalculateTotalTimeIncident function** |<xref:Microsoft.Crm.Sdk.Messages.CalculateTotalTimeIncidentRequest>|
| `CloseIncident`<br />Event: True |**CloseIncident action** |<xref:Microsoft.Crm.Sdk.Messages.CloseIncidentRequest>|
| `CloseQuote`<br />Event: True |**CloseQuote action** |<xref:Microsoft.Crm.Sdk.Messages.CloseQuoteRequest>|
| `Create`<br />Event: True |`POST` /incidents<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /incidents(*incidentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Merge`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Merge?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /incidents(*incidentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /incidents<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `Rollup`<br />Event: False |<xref:Microsoft.Dynamics.CRM.Rollup?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
| `SetState`<br />Event: True |`PATCH` /incidents(*incidentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /incidents(*incidentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /incidents(*incidentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Case (Incident) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Case** |
| **DisplayCollectionName** | **Cases** |
| **SchemaName** | `Incident` |
| **CollectionSchemaName** | `Incidents` |
| **EntitySetName** | `incidents`|
| **LogicalName** | `incident` |
| **LogicalCollectionName** | `incidents` |
| **PrimaryIdAttribute** | `incidentid` |
| **PrimaryNameAttribute** |`title` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivitiesComplete](#BKMK_ActivitiesComplete)
- [ActualServiceUnits](#BKMK_ActualServiceUnits)
- [BilledServiceUnits](#BKMK_BilledServiceUnits)
- [BlockedProfile](#BKMK_BlockedProfile)
- [CaseOriginCode](#BKMK_CaseOriginCode)
- [CaseTypeCode](#BKMK_CaseTypeCode)
- [CheckEmail](#BKMK_CheckEmail)
- [ContractDetailId](#BKMK_ContractDetailId)
- [ContractId](#BKMK_ContractId)
- [ContractServiceLevelCode](#BKMK_ContractServiceLevelCode)
- [CustomerContacted](#BKMK_CustomerContacted)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [CustomerSatisfactionCode](#BKMK_CustomerSatisfactionCode)
- [deactivatedon](#BKMK_deactivatedon)
- [DecrementEntitlementTerm](#BKMK_DecrementEntitlementTerm)
- [Description](#BKMK_Description)
- [EmailAddress](#BKMK_EmailAddress)
- [EntitlementId](#BKMK_EntitlementId)
- [EntityImage](#BKMK_EntityImage)
- [ExistingCase](#BKMK_ExistingCase)
- [FirstResponseByKPIId](#BKMK_FirstResponseByKPIId)
- [FirstResponseSent](#BKMK_FirstResponseSent)
- [FirstResponseSLAStatus](#BKMK_FirstResponseSLAStatus)
- [FollowupBy](#BKMK_FollowupBy)
- [FollowUpTaskCreated](#BKMK_FollowUpTaskCreated)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IncidentId](#BKMK_IncidentId)
- [IncidentStageCode](#BKMK_IncidentStageCode)
- [InfluenceScore](#BKMK_InfluenceScore)
- [IsDecrementing](#BKMK_IsDecrementing)
- [IsEscalated](#BKMK_IsEscalated)
- [KbArticleId](#BKMK_KbArticleId)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [MasterId](#BKMK_MasterId)
- [MessageTypeCode](#BKMK_MessageTypeCode)
- [msdyn_CaseSurveyInviteUrl](#BKMK_msdyn_CaseSurveyInviteUrl)
- [msdyn_copilotengaged](#BKMK_msdyn_copilotengaged)
- [msdyn_iotalert](#BKMK_msdyn_iotalert)
- [msdyn_precreateattachmentsid](#BKMK_msdyn_precreateattachmentsid)
- [msdyn_precreatenotesid](#BKMK_msdyn_precreatenotesid)
- [nextsla](#BKMK_nextsla)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ParentCaseId](#BKMK_ParentCaseId)
- [PrimaryContactId](#BKMK_PrimaryContactId)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [ProductId](#BKMK_ProductId)
- [ProductSerialNumber](#BKMK_ProductSerialNumber)
- [ResolveBy](#BKMK_ResolveBy)
- [ResolveByKPIId](#BKMK_ResolveByKPIId)
- [ResolveBySLAStatus](#BKMK_ResolveBySLAStatus)
- [ResponseBy](#BKMK_ResponseBy)
- [ResponsibleContactId](#BKMK_ResponsibleContactId)
- [RouteCase](#BKMK_RouteCase)
- [SentimentValue](#BKMK_SentimentValue)
- [ServiceStage](#BKMK_ServiceStage)
- [SeverityCode](#BKMK_SeverityCode)
- [SLAId](#BKMK_SLAId)
- [SocialProfileId](#BKMK_SocialProfileId)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [SubjectId](#BKMK_SubjectId)
- [TicketNumber](#BKMK_TicketNumber)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [Title](#BKMK_Title)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ActivitiesComplete"></a> ActivitiesComplete

|Property|Value|
|---|---|
|Description|**This attribute is used for Sample Service Business Processes.**|
|DisplayName|**Activities Complete**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`activitiescomplete`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_activities_complete`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ActualServiceUnits"></a> ActualServiceUnits

|Property|Value|
|---|---|
|Description|**Type the number of service units that were actually required to resolve the case.**|
|DisplayName|**Actual Service Units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`actualserviceunits`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_BilledServiceUnits"></a> BilledServiceUnits

|Property|Value|
|---|---|
|Description|**Type the number of service units that were billed to the customer for the case.**|
|DisplayName|**Billed Service Units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`billedserviceunits`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|0|

### <a name="BKMK_BlockedProfile"></a> BlockedProfile

|Property|Value|
|---|---|
|Description|**Details whether the profile is blocked or not.**|
|DisplayName|**Blocked Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`blockedprofile`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`socialprofile_isblocked`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_CaseOriginCode"></a> CaseOriginCode

|Property|Value|
|---|---|
|Description|**Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.**|
|DisplayName|**Origin**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`caseorigincode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`incident_caseorigincode`|

#### CaseOriginCode Choices/Options

|Value|Label|
|---|---|
|1|**Phone**|
|2|**Email**|
|3|**Web**|
|2483|**Facebook**|
|3986|**Twitter**|
|700610000|**IoT**|

### <a name="BKMK_CaseTypeCode"></a> CaseTypeCode

|Property|Value|
|---|---|
|Description|**Select the type of case to identify the incident for use in case routing and analysis.**|
|DisplayName|**Case Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`casetypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`incident_casetypecode`|

#### CaseTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Question**|
|2|**Problem**|
|3|**Request**|

### <a name="BKMK_CheckEmail"></a> CheckEmail

|Property|Value|
|---|---|
|Description|**This attribute is used for Sample Service Business Processes.**|
|DisplayName|**Check Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`checkemail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_check_email`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ContractDetailId"></a> ContractDetailId

|Property|Value|
|---|---|
|Description|**Choose the contract line that the case should be logged under to make sure the customer is charged correctly.**|
|DisplayName|**Contract Line**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contractdetailid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contractdetail|

### <a name="BKMK_ContractId"></a> ContractId

|Property|Value|
|---|---|
|Description|**Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.**|
|DisplayName|**Contract**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contractid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contract|

### <a name="BKMK_ContractServiceLevelCode"></a> ContractServiceLevelCode

|Property|Value|
|---|---|
|Description|**Select the service level for the case to make sure the case is handled correctly.**|
|DisplayName|**Service Level**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contractservicelevelcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`incident_contractservicelevelcode`|

#### ContractServiceLevelCode Choices/Options

|Value|Label|
|---|---|
|1|**Gold**|
|2|**Silver**|
|3|**Bronze**|

### <a name="BKMK_CustomerContacted"></a> CustomerContacted

|Property|Value|
|---|---|
|Description|**Tells whether customer service representative has contacted the customer or not.**|
|DisplayName|**Customer Contacted**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customercontacted`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_customercontacted`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|---|---|
|Description|**Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.**|
|DisplayName|**Customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customerid`|
|RequiredLevel|SystemRequired|
|Type|Customer|
|Targets|account, contact|

### <a name="BKMK_CustomerIdType"></a> CustomerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Customer Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridtype`|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|

### <a name="BKMK_CustomerSatisfactionCode"></a> CustomerSatisfactionCode

|Property|Value|
|---|---|
|Description|**Select the customer's level of satisfaction with the handling and resolution of the case.**|
|DisplayName|**Satisfaction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`customersatisfactioncode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`incident_customersatisfactioncode`|

#### CustomerSatisfactionCode Choices/Options

|Value|Label|
|---|---|
|1|**Very Dissatisfied**|
|2|**Dissatisfied**|
|3|**Neutral**|
|4|**Satisfied**|
|5|**Very Satisfied**|

### <a name="BKMK_deactivatedon"></a> deactivatedon

|Property|Value|
|---|---|
|Description|**Shows the date time when the Case was resolved.**|
|DisplayName|**Deactivated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`deactivatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_DecrementEntitlementTerm"></a> DecrementEntitlementTerm

|Property|Value|
|---|---|
|Description|**Shows whether terms of the associated entitlement should be decremented or not.**|
|DisplayName|**Decrement Entitlement Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`decremententitlementterm`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_decremententitlementterm`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the case to assist the service team in reaching a resolution.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|---|---|
|Description|**The primary email address for the entity.**|
|DisplayName|**Email Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_EntitlementId"></a> EntitlementId

|Property|Value|
|---|---|
|Description|**Choose the entitlement that is applicable for the case.**|
|DisplayName|**Entitlement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`entitlementid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|entitlement|

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description|**The default image for the entity.**|
|DisplayName|**Entity Image**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_ExistingCase"></a> ExistingCase

|Property|Value|
|---|---|
|Description|**Select an existing case for the customer that has been populated. For internal use only.**|
|DisplayName|**Existing Case**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`existingcase`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_FirstResponseByKPIId"></a> FirstResponseByKPIId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**First Response By KPI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`firstresponsebykpiid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|slakpiinstance|

### <a name="BKMK_FirstResponseSent"></a> FirstResponseSent

|Property|Value|
|---|---|
|Description|**Indicates if the first response has been sent.**|
|DisplayName|**First Response Sent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`firstresponsesent`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_firstresponsesent`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_FirstResponseSLAStatus"></a> FirstResponseSLAStatus

|Property|Value|
|---|---|
|Description|**Shows the status of the initial response time for the case according to the terms of the SLA.**|
|DisplayName|**First Response SLA Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`firstresponseslastatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`incident_firstresponseslastatus`|

#### FirstResponseSLAStatus Choices/Options

|Value|Label|
|---|---|
|1|**In Progress**|
|2|**Nearing Noncompliance**|
|3|**Succeeded**|
|4|**Noncompliant**|

### <a name="BKMK_FollowupBy"></a> FollowupBy

|Property|Value|
|---|---|
|Description|**Enter the date by which a customer service representative has to follow up with the customer on this case.**|
|DisplayName|**Follow Up By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`followupby`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_FollowUpTaskCreated"></a> FollowUpTaskCreated

|Property|Value|
|---|---|
|Description|**This attribute is used for Sample Service Business Processes.**|
|DisplayName|**Follow up Task Created**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`followuptaskcreated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_followup_task_created`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_IncidentId"></a> IncidentId

|Property|Value|
|---|---|
|Description|**Unique identifier of the case.**|
|DisplayName|**Case**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`incidentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_IncidentStageCode"></a> IncidentStageCode

|Property|Value|
|---|---|
|Description|**Select the current stage of the service process for the case to assist service team members when they review or transfer a case.**|
|DisplayName|**Case Stage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`incidentstagecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`incident_incidentstagecode`|

#### IncidentStageCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_InfluenceScore"></a> InfluenceScore

|Property|Value|
|---|---|
|Description|**Will contain the Influencer score coming from NetBreeze.**|
|DisplayName|**Influence Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`influencescore`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_IsDecrementing"></a> IsDecrementing

|Property|Value|
|---|---|
|Description|**For system use only.**|
|DisplayName|**Decrementing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isdecrementing`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_isdecrementing`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsEscalated"></a> IsEscalated

|Property|Value|
|---|---|
|Description|**Indicates if the case has been escalated.**|
|DisplayName|**Is Escalated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isescalated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_isescalated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_KbArticleId"></a> KbArticleId

|Property|Value|
|---|---|
|Description|**Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.**|
|DisplayName|**Knowledge Base Article**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`kbarticleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|kbarticle|

### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|---|---|
|Description|**Contains the date time stamp of the last on hold time.**|
|DisplayName|**Last On Hold Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastonholdtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_MasterId"></a> MasterId

|Property|Value|
|---|---|
|Description|**Choose the primary case the current case was merged into.**|
|DisplayName|**Master Case**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`masterid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_MessageTypeCode"></a> MessageTypeCode

|Property|Value|
|---|---|
|Description|**Shows whether the post originated as a public or private message.**|
|DisplayName|**Received As**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`messagetypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`socialactivity_postmessagetype`|

#### MessageTypeCode Choices/Options

|Value|Label|
|---|---|
|0|**Public Message**|
|1|**Private Message**|

### <a name="BKMK_msdyn_CaseSurveyInviteUrl"></a> msdyn_CaseSurveyInviteUrl

|Property|Value|
|---|---|
|Description|**Survey invite url for customer feedback.**|
|DisplayName|**Survey Invite**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_casesurveyinviteurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_copilotengaged"></a> msdyn_copilotengaged

|Property|Value|
|---|---|
|Description||
|DisplayName|**Copilot Engaged**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_copilotengaged`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_incident_msdyn_copilotengaged`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_iotalert"></a> msdyn_iotalert

|Property|Value|
|---|---|
|Description|**The iot alert that initiated this case**|
|DisplayName|**IoT Alert**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotalert`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotalert|

### <a name="BKMK_msdyn_precreateattachmentsid"></a> msdyn_precreateattachmentsid

|Property|Value|
|---|---|
|Description|**Entity Attachments Id before the case record is created**|
|DisplayName|**Pre Create Entity Attachments Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_precreateattachmentsid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdyn_precreatenotesid"></a> msdyn_precreatenotesid

|Property|Value|
|---|---|
|Description|**Notes Id before the case record is created**|
|DisplayName|**Pre Create Notes Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_precreatenotesid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_nextsla"></a> nextsla

|Property|Value|
|---|---|
|Description|**Shows the unresolved SLA KPI associated with the Case with the earliest expiry time.**|
|DisplayName|**Next Sla**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`nextsla`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_ParentCaseId"></a> ParentCaseId

|Property|Value|
|---|---|
|Description|**Choose the parent case for a case.**|
|DisplayName|**Parent Case**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`parentcaseid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_PrimaryContactId"></a> PrimaryContactId

|Property|Value|
|---|---|
|Description|**Select a primary contact for this case.**|
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`primarycontactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|---|---|
|Description|**Select the priority so that preferred customers or critical issues are handled quickly.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`prioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|2|
|GlobalChoiceName|`incident_prioritycode`|

#### PriorityCode Choices/Options

|Value|Label|
|---|---|
|1|**High**|
|2|**Normal**|
|3|**Low**|

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|---|---|
|Description|**Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.**|
|DisplayName|**Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_ProductSerialNumber"></a> ProductSerialNumber

|Property|Value|
|---|---|
|Description|**Type the serial number of the product that is associated with this case, so that the number of cases per product can be reported.**|
|DisplayName|**Serial Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`productserialnumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ResolveBy"></a> ResolveBy

|Property|Value|
|---|---|
|Description|**Enter the date by when the case must be resolved.**|
|DisplayName|**Resolve By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resolveby`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ResolveByKPIId"></a> ResolveByKPIId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Resolve By KPI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resolvebykpiid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|slakpiinstance|

### <a name="BKMK_ResolveBySLAStatus"></a> ResolveBySLAStatus

|Property|Value|
|---|---|
|Description|**Shows the status of the resolution time for the case according to the terms of the SLA.**|
|DisplayName|**Resolve By SLA Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resolvebyslastatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`incident_resolvebyslastatus`|

#### ResolveBySLAStatus Choices/Options

|Value|Label|
|---|---|
|1|**In Progress**|
|2|**Nearing Noncompliance**|
|3|**Succeeded**|
|4|**Noncompliant**|

### <a name="BKMK_ResponseBy"></a> ResponseBy

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**First Response By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`responseby`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ResponsibleContactId"></a> ResponsibleContactId

|Property|Value|
|---|---|
|Description|**Choose an additional customer contact who can also help resolve the case.**|
|DisplayName|**Responsible Contact (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`responsiblecontactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_RouteCase"></a> RouteCase

|Property|Value|
|---|---|
|Description|**Tells whether the incident has been routed to queue or not.**|
|DisplayName|**Route Case**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`routecase`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_routecase`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_SentimentValue"></a> SentimentValue

|Property|Value|
|---|---|
|Description|**Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.**|
|DisplayName|**Sentiment Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`sentimentvalue`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|

### <a name="BKMK_ServiceStage"></a> ServiceStage

|Property|Value|
|---|---|
|Description|**Select the stage, in the case resolution process, that the case is in.**|
|DisplayName|**Service Stage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`servicestage`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`servicestage`|

#### ServiceStage Choices/Options

|Value|Label|
|---|---|
|0|**Identify**|
|1|**Research**|
|2|**Resolve**|

### <a name="BKMK_SeverityCode"></a> SeverityCode

|Property|Value|
|---|---|
|Description|**Select the severity of this case to indicate the incident's impact on the customer's business.**|
|DisplayName|**Severity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`severitycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`incident_severitycode`|

#### SeverityCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|---|---|
|Description|**Choose the service level agreement (SLA) that you want to apply to the case record.**|
|DisplayName|**SLA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`slaid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_SocialProfileId"></a> SocialProfileId

|Property|Value|
|---|---|
|Description|**Unique identifier of the social profile with which the case is associated.**|
|DisplayName|**Social Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`socialprofileid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|socialprofile|

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**(Deprecated) Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be edited unless they are reactivated.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue|0|
|GlobalChoiceName|`incident_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Resolved**<br />DefaultStatus: 5<br />InvariantName: `Resolved`|
|2|Label: **Cancelled**<br />DefaultStatus: 6<br />InvariantName: `Cancelled`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the case's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`incident_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **In Progress**<br />State:0<br />TransitionData: None|
|2|Label: **On Hold**<br />State:0<br />TransitionData: None|
|3|Label: **Waiting for Details**<br />State:0<br />TransitionData: None|
|4|Label: **Researching**<br />State:0<br />TransitionData: None|
|5|Label: **Problem Solved**<br />State:1<br />TransitionData: None|
|6|Label: **Cancelled**<br />State:2<br />TransitionData: None|
|1000|Label: **Information Provided**<br />State:1<br />TransitionData: None|
|2000|Label: **Merged**<br />State:2<br />TransitionData: None|

### <a name="BKMK_SubjectId"></a> SubjectId

|Property|Value|
|---|---|
|Description|**Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`subjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|subject|

### <a name="BKMK_TicketNumber"></a> TicketNumber

|Property|Value|
|---|---|
|Description|**Shows the case number for customer reference and searching capabilities. This cannot be modified.**|
|DisplayName|**Case Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ticketnumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_Title"></a> Title

|Property|Value|
|---|---|
|Description|**Type a subject or descriptive name, such as the request, issue, or company name, to identify the case in Microsoft Dynamics 365 views.**|
|DisplayName|**Case Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`title`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**(Deprecated) Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [AccountId](#BKMK_AccountId)
- [caseage](#BKMK_caseage)
- [ContactId](#BKMK_ContactId)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [EscalatedOn](#BKMK_EscalatedOn)
- [ExchangeRate](#BKMK_ExchangeRate)
- [lastinteraction](#BKMK_lastinteraction)
- [Merged](#BKMK_Merged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByExternalParty](#BKMK_ModifiedByExternalParty)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [NumberOfChildIncidents](#BKMK_NumberOfChildIncidents)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|---|---|
|Description|**Unique identifier of the account with which the case is associated.**|
|DisplayName|**Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_caseage"></a> caseage

|Property|Value|
|---|---|
|Description|**Shows the duration for which the Case has been active for Active and Resolved Cases.**|
|DisplayName|**Case Age**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`caseage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|---|---|
|Description|**Unique identifier of the contact associated with the case.**|
|DisplayName|**Contact**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Shows who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

|Property|Value|
|---|---|
|Description|**Shows the external party who created the record.**|
|DisplayName|**Created By (External Party)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdbyexternalparty`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|externalparty|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Shows who created the record on behalf of another user.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`customeridyominame`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_EscalatedOn"></a> EscalatedOn

|Property|Value|
|---|---|
|Description|**Indicates the date and time when the case was escalated.**|
|DisplayName|**Escalated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`escalatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_lastinteraction"></a> lastinteraction

|Property|Value|
|---|---|
|Description|**Shows the latest activity associated with the Case and the action performed on that activity.**|
|DisplayName|**Last Interaction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`lastinteraction`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_Merged"></a> Merged

|Property|Value|
|---|---|
|Description|**Tells whether the incident has been merged with another incident.**|
|DisplayName|**Internal Use Only**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`merged`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`incident_merged`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Shows who last updated the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

|Property|Value|
|---|---|
|Description|**Shows the external party who modified the record.**|
|DisplayName|**Modified By (External Party)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedbyexternalparty`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|externalparty|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_NumberOfChildIncidents"></a> NumberOfChildIncidents

|Property|Value|
|---|---|
|Description|**Number of child incidents associated with the incident.**|
|DisplayName|**Child Cases**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`numberofchildincidents`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|---|---|
|Description|**Shows the duration in minutes for which the case was on hold.**|
|DisplayName|**On Hold Time (Minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`onholdtime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|---|---|
|Description|**Last SLA that was applied to this case. This field is for internal use only.**|
|DisplayName|**Last SLA applied**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`slainvokedid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|sla|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_incidents](#BKMK_business_unit_incidents)
- [contact_as_primary_contact](#BKMK_contact_as_primary_contact)
- [contact_as_responsible_contact](#BKMK_contact_as_responsible_contact)
- [contract_cases](#BKMK_contract_cases)
- [contract_detail_cases](#BKMK_contract_detail_cases)
- [entitlement_cases](#BKMK_entitlement_cases)
- [incident_customer_accounts](#BKMK_incident_customer_accounts)
- [incident_customer_contacts](#BKMK_incident_customer_contacts)
- [incident_existingcase](#BKMK_incident_existingcase-many-to-one)
- [incident_master_incident](#BKMK_incident_master_incident-many-to-one)
- [incident_parent_incident](#BKMK_incident_parent_incident-many-to-one)
- [kbarticle_incidents](#BKMK_kbarticle_incidents)
- [lk_incidentbase_createdby](#BKMK_lk_incidentbase_createdby)
- [lk_incidentbase_createdonbehalfby](#BKMK_lk_incidentbase_createdonbehalfby)
- [lk_incidentbase_modifiedby](#BKMK_lk_incidentbase_modifiedby)
- [lk_incidentbase_modifiedonbehalfby](#BKMK_lk_incidentbase_modifiedonbehalfby)
- [manualsla_cases](#BKMK_manualsla_cases)
- [msdyn_msdyn_iotalert_incident_IoTAlert](#BKMK_msdyn_msdyn_iotalert_incident_IoTAlert)
- [owner_incidents](#BKMK_owner_incidents)
- [processstage_incident](#BKMK_processstage_incident)
- [product_incidents](#BKMK_product_incidents)
- [sla_cases](#BKMK_sla_cases)
- [slakpiinstance_incident_firstresponsebykpi](#BKMK_slakpiinstance_incident_firstresponsebykpi)
- [slakpiinstance_incident_resolvebykpi](#BKMK_slakpiinstance_incident_resolvebykpi)
- [socialprofile_cases](#BKMK_socialprofile_cases)
- [subject_incidents](#BKMK_subject_incidents)
- [system_user_incidents](#BKMK_system_user_incidents)
- [team_incidents](#BKMK_team_incidents)
- [TransactionCurrency_Incident](#BKMK_TransactionCurrency_Incident)

### <a name="BKMK_business_unit_incidents"></a> business_unit_incidents

One-To-Many Relationship: [businessunit business_unit_incidents](businessunit.md#BKMK_business_unit_incidents)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contact_as_primary_contact"></a> contact_as_primary_contact

One-To-Many Relationship: [contact contact_as_primary_contact](contact.md#BKMK_contact_as_primary_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`primarycontactid`|
|ReferencingEntityNavigationPropertyName|`primarycontactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contact_as_responsible_contact"></a> contact_as_responsible_contact

One-To-Many Relationship: [contact contact_as_responsible_contact](contact.md#BKMK_contact_as_responsible_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`responsiblecontactid`|
|ReferencingEntityNavigationPropertyName|`responsiblecontactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_cases"></a> contract_cases

One-To-Many Relationship: [contract contract_cases](contract.md#BKMK_contract_cases)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`contractid`|
|ReferencingEntityNavigationPropertyName|`contractid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_detail_cases"></a> contract_detail_cases

One-To-Many Relationship: [contractdetail contract_detail_cases](contractdetail.md#BKMK_contract_detail_cases)

|Property|Value|
|---|---|
|ReferencedEntity|`contractdetail`|
|ReferencedAttribute|`contractdetailid`|
|ReferencingAttribute|`contractdetailid`|
|ReferencingEntityNavigationPropertyName|`contractdetailid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlement_cases"></a> entitlement_cases

One-To-Many Relationship: [entitlement entitlement_cases](entitlement.md#BKMK_entitlement_cases)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`entitlementid`|
|ReferencingEntityNavigationPropertyName|`entitlementid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_customer_accounts"></a> incident_customer_accounts

One-To-Many Relationship: [account incident_customer_accounts](account.md#BKMK_incident_customer_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_incident_customer_contacts"></a> incident_customer_contacts

One-To-Many Relationship: [contact incident_customer_contacts](contact.md#BKMK_incident_customer_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`customerid`|
|ReferencingEntityNavigationPropertyName|`customerid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_incident_existingcase-many-to-one"></a> incident_existingcase

One-To-Many Relationship: [incident incident_existingcase](#BKMK_incident_existingcase-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`existingcase`|
|ReferencingEntityNavigationPropertyName|`existingcase`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_master_incident-many-to-one"></a> incident_master_incident

One-To-Many Relationship: [incident incident_master_incident](#BKMK_incident_master_incident-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`masterid`|
|ReferencingEntityNavigationPropertyName|`masterid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_parent_incident-many-to-one"></a> incident_parent_incident

One-To-Many Relationship: [incident incident_parent_incident](#BKMK_incident_parent_incident-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`parentcaseid`|
|ReferencingEntityNavigationPropertyName|`parentcaseid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_kbarticle_incidents"></a> kbarticle_incidents

One-To-Many Relationship: [kbarticle kbarticle_incidents](kbarticle.md#BKMK_kbarticle_incidents)

|Property|Value|
|---|---|
|ReferencedEntity|`kbarticle`|
|ReferencedAttribute|`kbarticleid`|
|ReferencingAttribute|`kbarticleid`|
|ReferencingEntityNavigationPropertyName|`kbarticleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_incidentbase_createdby"></a> lk_incidentbase_createdby

One-To-Many Relationship: [systemuser lk_incidentbase_createdby](systemuser.md#BKMK_lk_incidentbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_incidentbase_createdonbehalfby"></a> lk_incidentbase_createdonbehalfby

One-To-Many Relationship: [systemuser lk_incidentbase_createdonbehalfby](systemuser.md#BKMK_lk_incidentbase_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_incidentbase_modifiedby"></a> lk_incidentbase_modifiedby

One-To-Many Relationship: [systemuser lk_incidentbase_modifiedby](systemuser.md#BKMK_lk_incidentbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_incidentbase_modifiedonbehalfby"></a> lk_incidentbase_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_incidentbase_modifiedonbehalfby](systemuser.md#BKMK_lk_incidentbase_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_manualsla_cases"></a> manualsla_cases

One-To-Many Relationship: [sla manualsla_cases](sla.md#BKMK_manualsla_cases)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slaid`|
|ReferencingEntityNavigationPropertyName|`slaid_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotalert_incident_IoTAlert"></a> msdyn_msdyn_iotalert_incident_IoTAlert

One-To-Many Relationship: [msdyn_iotalert msdyn_msdyn_iotalert_incident_IoTAlert](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotalert_incident_IoTAlert)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`msdyn_iotalert`|
|ReferencingEntityNavigationPropertyName|`msdyn_IoTAlert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_incidents"></a> owner_incidents

One-To-Many Relationship: [owner owner_incidents](owner.md#BKMK_owner_incidents)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_incident"></a> processstage_incident

One-To-Many Relationship: [processstage processstage_incident](processstage.md#BKMK_processstage_incident)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid_processstage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_product_incidents"></a> product_incidents

One-To-Many Relationship: [product product_incidents](product.md#BKMK_product_incidents)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`productid`|
|ReferencingEntityNavigationPropertyName|`productid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_sla_cases"></a> sla_cases

One-To-Many Relationship: [sla sla_cases](sla.md#BKMK_sla_cases)

|Property|Value|
|---|---|
|ReferencedEntity|`sla`|
|ReferencedAttribute|`slaid`|
|ReferencingAttribute|`slainvokedid`|
|ReferencingEntityNavigationPropertyName|`slainvokedid_sla`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_slakpiinstance_incident_firstresponsebykpi"></a> slakpiinstance_incident_firstresponsebykpi

One-To-Many Relationship: [slakpiinstance slakpiinstance_incident_firstresponsebykpi](slakpiinstance.md#BKMK_slakpiinstance_incident_firstresponsebykpi)

|Property|Value|
|---|---|
|ReferencedEntity|`slakpiinstance`|
|ReferencedAttribute|`slakpiinstanceid`|
|ReferencingAttribute|`firstresponsebykpiid`|
|ReferencingEntityNavigationPropertyName|`firstresponsebykpiid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_slakpiinstance_incident_resolvebykpi"></a> slakpiinstance_incident_resolvebykpi

One-To-Many Relationship: [slakpiinstance slakpiinstance_incident_resolvebykpi](slakpiinstance.md#BKMK_slakpiinstance_incident_resolvebykpi)

|Property|Value|
|---|---|
|ReferencedEntity|`slakpiinstance`|
|ReferencedAttribute|`slakpiinstanceid`|
|ReferencingAttribute|`resolvebykpiid`|
|ReferencingEntityNavigationPropertyName|`resolvebykpiid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_socialprofile_cases"></a> socialprofile_cases

One-To-Many Relationship: [socialprofile socialprofile_cases](socialprofile.md#BKMK_socialprofile_cases)

|Property|Value|
|---|---|
|ReferencedEntity|`socialprofile`|
|ReferencedAttribute|`socialprofileid`|
|ReferencingAttribute|`socialprofileid`|
|ReferencingEntityNavigationPropertyName|`socialprofileid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_subject_incidents"></a> subject_incidents

One-To-Many Relationship: [subject subject_incidents](subject.md#BKMK_subject_incidents)

|Property|Value|
|---|---|
|ReferencedEntity|`subject`|
|ReferencedAttribute|`subjectid`|
|ReferencingAttribute|`subjectid`|
|ReferencingEntityNavigationPropertyName|`subjectid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_system_user_incidents"></a> system_user_incidents

One-To-Many Relationship: [systemuser system_user_incidents](systemuser.md#BKMK_system_user_incidents)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_incidents"></a> team_incidents

One-To-Many Relationship: [team team_incidents](team.md#BKMK_team_incidents)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_Incident"></a> TransactionCurrency_Incident

One-To-Many Relationship: [transactioncurrency TransactionCurrency_Incident](transactioncurrency.md#BKMK_TransactionCurrency_Incident)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [bpf_incident_msdyn_iottocaseprocess](#BKMK_bpf_incident_msdyn_iottocaseprocess)
- [incident_actioncard](#BKMK_incident_actioncard)
- [incident_activity_parties](#BKMK_incident_activity_parties)
- [Incident_ActivityPointers](#BKMK_Incident_ActivityPointers)
- [incident_adx_inviteredemptions](#BKMK_incident_adx_inviteredemptions)
- [incident_adx_portalcomments](#BKMK_incident_adx_portalcomments)
- [Incident_Annotation](#BKMK_Incident_Annotation)
- [Incident_Appointments](#BKMK_Incident_Appointments)
- [Incident_AsyncOperations](#BKMK_Incident_AsyncOperations)
- [Incident_BulkDeleteFailures](#BKMK_Incident_BulkDeleteFailures)
- [incident_chats](#BKMK_incident_chats)
- [incident_connections1](#BKMK_incident_connections1)
- [incident_connections2](#BKMK_incident_connections2)
- [Incident_DuplicateBaseRecord](#BKMK_Incident_DuplicateBaseRecord)
- [Incident_DuplicateMatchingRecord](#BKMK_Incident_DuplicateMatchingRecord)
- [Incident_Emails](#BKMK_Incident_Emails)
- [incident_existingcase](#BKMK_incident_existingcase-one-to-many)
- [Incident_Faxes](#BKMK_Incident_Faxes)
- [Incident_IncidentResolutions](#BKMK_Incident_IncidentResolutions)
- [Incident_Letters](#BKMK_Incident_Letters)
- [Incident_MailboxTrackingFolder](#BKMK_Incident_MailboxTrackingFolder)
- [incident_master_incident](#BKMK_incident_master_incident-one-to-many)
- [incident_msdyn_copilottranscripts](#BKMK_incident_msdyn_copilottranscripts)
- [incident_msdyn_ocliveworkitems](#BKMK_incident_msdyn_ocliveworkitems)
- [incident_msdyn_ocsessions](#BKMK_incident_msdyn_ocsessions)
- [incident_msfp_alerts](#BKMK_incident_msfp_alerts)
- [incident_msfp_surveyinvites](#BKMK_incident_msfp_surveyinvites)
- [incident_msfp_surveyresponses](#BKMK_incident_msfp_surveyresponses)
- [incident_OpportunityCloses](#BKMK_incident_OpportunityCloses)
- [incident_OrderCloses](#BKMK_incident_OrderCloses)
- [incident_parent_incident](#BKMK_incident_parent_incident-one-to-many)
- [Incident_Phonecalls](#BKMK_Incident_Phonecalls)
- [incident_PostFollows](#BKMK_incident_PostFollows)
- [incident_PostRegardings](#BKMK_incident_PostRegardings)
- [incident_Posts](#BKMK_incident_Posts)
- [incident_principalobjectattributeaccess](#BKMK_incident_principalobjectattributeaccess)
- [Incident_ProcessSessions](#BKMK_Incident_ProcessSessions)
- [Incident_QueueItem](#BKMK_Incident_QueueItem)
- [incident_QuoteCloses](#BKMK_incident_QuoteCloses)
- [Incident_RecurringAppointmentMasters](#BKMK_Incident_RecurringAppointmentMasters)
- [Incident_ServiceAppointments](#BKMK_Incident_ServiceAppointments)
- [Incident_SocialActivities](#BKMK_Incident_SocialActivities)
- [Incident_SyncErrors](#BKMK_Incident_SyncErrors)
- [Incident_Tasks](#BKMK_Incident_Tasks)
- [knowledgearticle_incidents](#BKMK_knowledgearticle_incidents)
- [lk_phonetocaseprocess_incidentid](#BKMK_lk_phonetocaseprocess_incidentid)
- [msdyn_incident_feedback_context](#BKMK_msdyn_incident_feedback_context)
- [msdyn_incident_msdyn_aicontactsuggestion_sourcerecord](#BKMK_msdyn_incident_msdyn_aicontactsuggestion_sourcerecord)
- [msdyn_incident_msdyn_caseenrichment_caseid](#BKMK_msdyn_incident_msdyn_caseenrichment_caseid)
- [msdyn_incident_msdyn_casesuggestion_suggestedentity](#BKMK_msdyn_incident_msdyn_casesuggestion_suggestedentity)
- [msdyn_incident_msdyn_casesuggestionrequestpayload_caseid](#BKMK_msdyn_incident_msdyn_casesuggestionrequestpayload_caseid)
- [msdyn_incident_msdyn_casetopic_incident_incidentid](#BKMK_msdyn_incident_msdyn_casetopic_incident_incidentid)
- [msdyn_incident_msdyn_federatedarticleincident_IncidentId](#BKMK_msdyn_incident_msdyn_federatedarticleincident_IncidentId)
- [msdyn_incident_msdyn_intententity_objectid](#BKMK_msdyn_incident_msdyn_intententity_objectid)
- [msdyn_incident_msdyn_iotalert_Case](#BKMK_msdyn_incident_msdyn_iotalert_Case)
- [msdyn_incident_msdyn_ocliveworkitem](#BKMK_msdyn_incident_msdyn_ocliveworkitem)
- [msdyn_incident_msdyn_originatingqueue_createdincidentid](#BKMK_msdyn_incident_msdyn_originatingqueue_createdincidentid)
- [msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity](#BKMK_msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity)
- [msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor](#BKMK_msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor)
- [msdyn_incident_msdyn_suggestionrequestpayload](#BKMK_msdyn_incident_msdyn_suggestionrequestpayload)
- [msdyn_nextaction_regarding_incident](#BKMK_msdyn_nextaction_regarding_incident)
- [msdyn_readtracker_poly_incident](#BKMK_msdyn_readtracker_poly_incident)
- [msdyn_relatedentity_msdyn_entityattachment](#BKMK_msdyn_relatedentity_msdyn_entityattachment)
- [msdyn_swarm_incident](#BKMK_msdyn_swarm_incident)
- [msdyn_timetracker_regardingentity_Incident](#BKMK_msdyn_timetracker_regardingentity_Incident)
- [OriginatingCase_Lead](#BKMK_OriginatingCase_Lead)
- [slakpiinstance_incident](#BKMK_slakpiinstance_incident)

### <a name="BKMK_bpf_incident_msdyn_iottocaseprocess"></a> bpf_incident_msdyn_iottocaseprocess

Many-To-One Relationship: [msdyn_iottocaseprocess bpf_incident_msdyn_iottocaseprocess](msdyn_iottocaseprocess.md#BKMK_bpf_incident_msdyn_iottocaseprocess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iottocaseprocess`|
|ReferencingAttribute|`bpf_incidentid`|
|ReferencedEntityNavigationPropertyName|`bpf_incident_msdyn_iottocaseprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_actioncard"></a> incident_actioncard

Many-To-One Relationship: [actioncard incident_actioncard](actioncard.md#BKMK_incident_actioncard)

|Property|Value|
|---|---|
|ReferencingEntity|`actioncard`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_actioncard`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_activity_parties"></a> incident_activity_parties

Many-To-One Relationship: [activityparty incident_activity_parties](activityparty.md#BKMK_incident_activity_parties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`incident_activity_parties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_ActivityPointers"></a> Incident_ActivityPointers

Many-To-One Relationship: [activitypointer Incident_ActivityPointers](activitypointer.md#BKMK_Incident_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_ActivityPointers`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_incident_adx_inviteredemptions"></a> incident_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption incident_adx_inviteredemptions](adx_inviteredemption.md#BKMK_incident_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_adx_portalcomments"></a> incident_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment incident_adx_portalcomments](adx_portalcomment.md#BKMK_incident_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_Annotation"></a> Incident_Annotation

Many-To-One Relationship: [annotation Incident_Annotation](annotation.md#BKMK_Incident_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Incident_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_Appointments"></a> Incident_Appointments

Many-To-One Relationship: [appointment Incident_Appointments](appointment.md#BKMK_Incident_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_AsyncOperations"></a> Incident_AsyncOperations

Many-To-One Relationship: [asyncoperation Incident_AsyncOperations](asyncoperation.md#BKMK_Incident_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_BulkDeleteFailures"></a> Incident_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Incident_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Incident_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_chats"></a> incident_chats

Many-To-One Relationship: [chat incident_chats](chat.md#BKMK_incident_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_connections1"></a> incident_connections1

Many-To-One Relationship: [connection incident_connections1](connection.md#BKMK_incident_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`incident_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_connections2"></a> incident_connections2

Many-To-One Relationship: [connection incident_connections2](connection.md#BKMK_incident_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`incident_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_DuplicateBaseRecord"></a> Incident_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord Incident_DuplicateBaseRecord](duplicaterecord.md#BKMK_Incident_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`Incident_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_DuplicateMatchingRecord"></a> Incident_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord Incident_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Incident_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`Incident_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_Emails"></a> Incident_Emails

Many-To-One Relationship: [email Incident_Emails](email.md#BKMK_Incident_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_existingcase-one-to-many"></a> incident_existingcase

Many-To-One Relationship: [incident incident_existingcase](#BKMK_incident_existingcase-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`existingcase`|
|ReferencedEntityNavigationPropertyName|`incident_existingcase`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_Faxes"></a> Incident_Faxes

Many-To-One Relationship: [fax Incident_Faxes](fax.md#BKMK_Incident_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_IncidentResolutions"></a> Incident_IncidentResolutions

Many-To-One Relationship: [incidentresolution Incident_IncidentResolutions](incidentresolution.md#BKMK_Incident_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`incidentid`|
|ReferencedEntityNavigationPropertyName|`Incident_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_Letters"></a> Incident_Letters

Many-To-One Relationship: [letter Incident_Letters](letter.md#BKMK_Incident_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_MailboxTrackingFolder"></a> Incident_MailboxTrackingFolder

Many-To-One Relationship: [mailboxtrackingfolder Incident_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Incident_MailboxTrackingFolder)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_MailboxTrackingFolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_master_incident-one-to-many"></a> incident_master_incident

Many-To-One Relationship: [incident incident_master_incident](#BKMK_incident_master_incident-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`masterid`|
|ReferencedEntityNavigationPropertyName|`incident_master_incident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_msdyn_copilottranscripts"></a> incident_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript incident_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_incident_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_incident_msdyn_ocliveworkitems"></a> incident_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem incident_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_incident_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_incident_msdyn_ocsessions"></a> incident_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession incident_msdyn_ocsessions](msdyn_ocsession.md#BKMK_incident_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_incident_msfp_alerts"></a> incident_msfp_alerts

Many-To-One Relationship: [msfp_alert incident_msfp_alerts](msfp_alert.md#BKMK_incident_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_incident_msfp_surveyinvites"></a> incident_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite incident_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_incident_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_incident_msfp_surveyresponses"></a> incident_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse incident_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_incident_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_incident_OpportunityCloses"></a> incident_OpportunityCloses

Many-To-One Relationship: [opportunityclose incident_OpportunityCloses](opportunityclose.md#BKMK_incident_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_incident_OrderCloses"></a> incident_OrderCloses

Many-To-One Relationship: [orderclose incident_OrderCloses](orderclose.md#BKMK_incident_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_incident_parent_incident-one-to-many"></a> incident_parent_incident

Many-To-One Relationship: [incident incident_parent_incident](#BKMK_incident_parent_incident-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`parentcaseid`|
|ReferencedEntityNavigationPropertyName|`incident_parent_incident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_Phonecalls"></a> Incident_Phonecalls

Many-To-One Relationship: [phonecall Incident_Phonecalls](phonecall.md#BKMK_Incident_Phonecalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_Phonecalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_PostFollows"></a> incident_PostFollows

Many-To-One Relationship: [postfollow incident_PostFollows](postfollow.md#BKMK_incident_PostFollows)

|Property|Value|
|---|---|
|ReferencingEntity|`postfollow`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_PostFollows`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_PostRegardings"></a> incident_PostRegardings

Many-To-One Relationship: [postregarding incident_PostRegardings](postregarding.md#BKMK_incident_PostRegardings)

|Property|Value|
|---|---|
|ReferencingEntity|`postregarding`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_PostRegardings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_Posts"></a> incident_Posts

Many-To-One Relationship: [post incident_Posts](post.md#BKMK_incident_Posts)

|Property|Value|
|---|---|
|ReferencingEntity|`post`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_Posts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_principalobjectattributeaccess"></a> incident_principalobjectattributeaccess

Many-To-One Relationship: [principalobjectattributeaccess incident_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_incident_principalobjectattributeaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`incident_principalobjectattributeaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_ProcessSessions"></a> Incident_ProcessSessions

Many-To-One Relationship: [processsession Incident_ProcessSessions](processsession.md#BKMK_Incident_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_QueueItem"></a> Incident_QueueItem

Many-To-One Relationship: [queueitem Incident_QueueItem](queueitem.md#BKMK_Incident_QueueItem)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Incident_QueueItem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_QuoteCloses"></a> incident_QuoteCloses

Many-To-One Relationship: [quoteclose incident_QuoteCloses](quoteclose.md#BKMK_incident_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`incident_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_Incident_RecurringAppointmentMasters"></a> Incident_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster Incident_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Incident_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_ServiceAppointments"></a> Incident_ServiceAppointments

Many-To-One Relationship: [serviceappointment Incident_ServiceAppointments](serviceappointment.md#BKMK_Incident_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_Incident_SocialActivities"></a> Incident_SocialActivities

Many-To-One Relationship: [socialactivity Incident_SocialActivities](socialactivity.md#BKMK_Incident_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_SyncErrors"></a> Incident_SyncErrors

Many-To-One Relationship: [syncerror Incident_SyncErrors](syncerror.md#BKMK_Incident_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Incident_Tasks"></a> Incident_Tasks

Many-To-One Relationship: [task Incident_Tasks](task.md#BKMK_Incident_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Incident_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgearticle_incidents"></a> knowledgearticle_incidents

Many-To-One Relationship: [knowledgearticleincident knowledgearticle_incidents](knowledgearticleincident.md#BKMK_knowledgearticle_incidents)

|Property|Value|
|---|---|
|ReferencingEntity|`knowledgearticleincident`|
|ReferencingAttribute|`incidentid`|
|ReferencedEntityNavigationPropertyName|`knowledgearticle_incidents`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lk_phonetocaseprocess_incidentid"></a> lk_phonetocaseprocess_incidentid

Many-To-One Relationship: [phonetocaseprocess lk_phonetocaseprocess_incidentid](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_incidentid)

|Property|Value|
|---|---|
|ReferencingEntity|`phonetocaseprocess`|
|ReferencingAttribute|`incidentid`|
|ReferencedEntityNavigationPropertyName|`incident_phonetocaseprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_feedback_context"></a> msdyn_incident_feedback_context

Many-To-One Relationship: [feedback msdyn_incident_feedback_context](feedback.md#BKMK_msdyn_incident_feedback_context)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`msdyn_contextobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_feedback_context`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_aicontactsuggestion_sourcerecord"></a> msdyn_incident_msdyn_aicontactsuggestion_sourcerecord

Many-To-One Relationship: [msdyn_aicontactsuggestion msdyn_incident_msdyn_aicontactsuggestion_sourcerecord](msdyn_aicontactsuggestion.md#BKMK_msdyn_incident_msdyn_aicontactsuggestion_sourcerecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aicontactsuggestion`|
|ReferencingAttribute|`msdyn_sourcerecord`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_aicontactsuggestion_sourcerecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_caseenrichment_caseid"></a> msdyn_incident_msdyn_caseenrichment_caseid

Many-To-One Relationship: [msdyn_caseenrichment msdyn_incident_msdyn_caseenrichment_caseid](msdyn_caseenrichment.md#BKMK_msdyn_incident_msdyn_caseenrichment_caseid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_caseenrichment`|
|ReferencingAttribute|`msdyn_caseid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_caseenrichment_caseid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_casesuggestion_suggestedentity"></a> msdyn_incident_msdyn_casesuggestion_suggestedentity

Many-To-One Relationship: [msdyn_casesuggestion msdyn_incident_msdyn_casesuggestion_suggestedentity](msdyn_casesuggestion.md#BKMK_msdyn_incident_msdyn_casesuggestion_suggestedentity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_casesuggestion`|
|ReferencingAttribute|`msdyn_suggestedentity`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_casesuggestion_suggestedentity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_casesuggestionrequestpayload_caseid"></a> msdyn_incident_msdyn_casesuggestionrequestpayload_caseid

Many-To-One Relationship: [msdyn_casesuggestionrequestpayload msdyn_incident_msdyn_casesuggestionrequestpayload_caseid](msdyn_casesuggestionrequestpayload.md#BKMK_msdyn_incident_msdyn_casesuggestionrequestpayload_caseid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_casesuggestionrequestpayload`|
|ReferencingAttribute|`msdyn_caseid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_casesuggestionrequestpayload_caseid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_casetopic_incident_incidentid"></a> msdyn_incident_msdyn_casetopic_incident_incidentid

Many-To-One Relationship: [msdyn_casetopic_incident msdyn_incident_msdyn_casetopic_incident_incidentid](msdyn_casetopic_incident.md#BKMK_msdyn_incident_msdyn_casetopic_incident_incidentid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_casetopic_incident`|
|ReferencingAttribute|`msdyn_incidentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_casetopic_incident_incidentid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_federatedarticleincident_IncidentId"></a> msdyn_incident_msdyn_federatedarticleincident_IncidentId

Many-To-One Relationship: [msdyn_federatedarticleincident msdyn_incident_msdyn_federatedarticleincident_IncidentId](msdyn_federatedarticleincident.md#BKMK_msdyn_incident_msdyn_federatedarticleincident_IncidentId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_federatedarticleincident`|
|ReferencingAttribute|`msdyn_incidentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_federatedarticleincident_IncidentId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_intententity_objectid"></a> msdyn_incident_msdyn_intententity_objectid

Many-To-One Relationship: [msdyn_intententity msdyn_incident_msdyn_intententity_objectid](msdyn_intententity.md#BKMK_msdyn_incident_msdyn_intententity_objectid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity`|
|ReferencingAttribute|`msdyn_objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_intententity_objectid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_iotalert_Case"></a> msdyn_incident_msdyn_iotalert_Case

Many-To-One Relationship: [msdyn_iotalert msdyn_incident_msdyn_iotalert_Case](msdyn_iotalert.md#BKMK_msdyn_incident_msdyn_iotalert_Case)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`msdyn_case`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_iotalert_Case`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_ocliveworkitem"></a> msdyn_incident_msdyn_ocliveworkitem

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_incident_msdyn_ocliveworkitem](msdyn_ocliveworkitem.md#BKMK_msdyn_incident_msdyn_ocliveworkitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_issueid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_ocliveworkitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_originatingqueue_createdincidentid"></a> msdyn_incident_msdyn_originatingqueue_createdincidentid

Many-To-One Relationship: [msdyn_originatingqueue msdyn_incident_msdyn_originatingqueue_createdincidentid](msdyn_originatingqueue.md#BKMK_msdyn_incident_msdyn_originatingqueue_createdincidentid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_originatingqueue`|
|ReferencingAttribute|`msdyn_createdincidentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_originatingqueue_createdincidentid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity"></a> msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity

Many-To-One Relationship: [msdyn_suggestioninteraction msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity](msdyn_suggestioninteraction.md#BKMK_msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestioninteraction`|
|ReferencingAttribute|`msdyn_suggestedentity`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestedentity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor"></a> msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor

Many-To-One Relationship: [msdyn_suggestioninteraction msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor](msdyn_suggestioninteraction.md#BKMK_msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestioninteraction`|
|ReferencingAttribute|`msdyn_suggestionfor`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_suggestioninteraction_msdyn_suggestionfor`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_suggestionrequestpayload"></a> msdyn_incident_msdyn_suggestionrequestpayload

Many-To-One Relationship: [msdyn_suggestionrequestpayload msdyn_incident_msdyn_suggestionrequestpayload](msdyn_suggestionrequestpayload.md#BKMK_msdyn_incident_msdyn_suggestionrequestpayload)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionrequestpayload`|
|ReferencingAttribute|`msdyn_suggestionfor`|
|ReferencedEntityNavigationPropertyName|`msdyn_incident_msdyn_suggestionrequestpayload`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_nextaction_regarding_incident"></a> msdyn_nextaction_regarding_incident

Many-To-One Relationship: [msdyn_nextaction msdyn_nextaction_regarding_incident](msdyn_nextaction.md#BKMK_msdyn_nextaction_regarding_incident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nextaction`|
|ReferencingAttribute|`msdyn_regarding`|
|ReferencedEntityNavigationPropertyName|`msdyn_nextaction_regarding_incident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_readtracker_poly_incident"></a> msdyn_readtracker_poly_incident

Many-To-One Relationship: [msdyn_readtracker msdyn_readtracker_poly_incident](msdyn_readtracker.md#BKMK_msdyn_readtracker_poly_incident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_readtracker`|
|ReferencingAttribute|`msdyn_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_readtracker_poly_incident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_relatedentity_msdyn_entityattachment"></a> msdyn_relatedentity_msdyn_entityattachment

Many-To-One Relationship: [msdyn_entityattachment msdyn_relatedentity_msdyn_entityattachment](msdyn_entityattachment.md#BKMK_msdyn_relatedentity_msdyn_entityattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityattachment`|
|ReferencingAttribute|`msdyn_relatedentity`|
|ReferencedEntityNavigationPropertyName|`msdyn_relatedentity_msdyn_entityattachment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_incident"></a> msdyn_swarm_incident

Many-To-One Relationship: [msdyn_swarm msdyn_swarm_incident](msdyn_swarm.md#BKMK_msdyn_swarm_incident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarm`|
|ReferencingAttribute|`msdyn_swarmrelatedrecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_incident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timetracker_regardingentity_Incident"></a> msdyn_timetracker_regardingentity_Incident

Many-To-One Relationship: [msdyn_timetracker msdyn_timetracker_regardingentity_Incident](msdyn_timetracker.md#BKMK_msdyn_timetracker_regardingentity_Incident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timetracker`|
|ReferencingAttribute|`msdyn_regardingentity`|
|ReferencedEntityNavigationPropertyName|`msdyn_timetracker_regardingentity_Incident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_OriginatingCase_Lead"></a> OriginatingCase_Lead

Many-To-One Relationship: [lead OriginatingCase_Lead](lead.md#BKMK_OriginatingCase_Lead)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`originatingcaseid`|
|ReferencedEntityNavigationPropertyName|`OriginatingCase_Lead`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_slakpiinstance_incident"></a> slakpiinstance_incident

Many-To-One Relationship: [slakpiinstance slakpiinstance_incident](slakpiinstance.md#BKMK_slakpiinstance_incident)

|Property|Value|
|---|---|
|ReferencingEntity|`slakpiinstance`|
|ReferencingAttribute|`regarding`|
|ReferencedEntityNavigationPropertyName|`slakpiinstance_incident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [KnowledgeBaseRecord_Incident](#BKMK_KnowledgeBaseRecord_Incident)
- [msdyn_incident_msdyn_customerasset](#BKMK_msdyn_incident_msdyn_customerasset)

### <a name="BKMK_KnowledgeBaseRecord_Incident"></a> KnowledgeBaseRecord_Incident

See [knowledgebaserecord KnowledgeBaseRecord_Incident Many-To-Many Relationship](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Incident)

|Property|Value|
|---|---|
|IntersectEntityName|`incidentknowledgebaserecord`|
|IsCustomizable|True|
|SchemaName|`KnowledgeBaseRecord_Incident`|
|IntersectAttribute|`incidentid`|
|NavigationPropertyName|`KnowledgeBaseRecord_Incident`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_customerasset"></a> msdyn_incident_msdyn_customerasset

See [msdyn_customerasset msdyn_incident_msdyn_customerasset Many-To-Many Relationship](msdyn_customerasset.md#BKMK_msdyn_incident_msdyn_customerasset)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_incident_msdyn_customerasset`|
|IsCustomizable|True|
|SchemaName|`msdyn_incident_msdyn_customerasset`|
|IntersectAttribute|`incidentid`|
|NavigationPropertyName|`msdyn_incident_msdyn_customerasset`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

