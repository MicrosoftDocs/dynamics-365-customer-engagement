---
title: "Case (Incident)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Case (Incident)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Case (Incident)  entity reference

Service request case associated with a contract.

**Added by**: Service Solution


## Messages

|Message|SDK class or method|
|-|-|
|ApplyRoutingRule|<xref:Microsoft.Crm.Sdk.Messages.ApplyRoutingRuleRequest>|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CalculateTotalTimeIncident|<xref:Microsoft.Crm.Sdk.Messages.CalculateTotalTimeIncidentRequest>|
|CloseIncident|<xref:Microsoft.Crm.Sdk.Messages.CloseIncidentRequest>|
|CloseQuote|<xref:Microsoft.Crm.Sdk.Messages.CloseQuoteRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Merge|<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Incidents|
|DisplayCollectionName|Cases|
|DisplayName|Case|
|EntitySetName|incidents|
|IsBPFEntity|False|
|LogicalCollectionName|incidents|
|LogicalName|incident|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|incidentid|
|PrimaryNameAttribute|title|
|SchemaName|Incident|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|--------|-----|
|Description|This attribute is used for Sample Service Business Processes.|
|DisplayName|Activities Complete|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activitiescomplete|
|RequiredLevel|None|
|Type|Boolean|

#### ActivitiesComplete Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_ActualServiceUnits"></a> ActualServiceUnits

|Property|Value|
|--------|-----|
|Description|Type the number of service units that were actually required to resolve the case.|
|DisplayName|Actual Service Units|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualserviceunits|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_BilledServiceUnits"></a> BilledServiceUnits

|Property|Value|
|--------|-----|
|Description|Type the number of service units that were billed to the customer for the case.|
|DisplayName|Billed Service Units|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|billedserviceunits|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_BlockedProfile"></a> BlockedProfile

|Property|Value|
|--------|-----|
|Description|Details whether the profile is blocked or not.|
|DisplayName|Blocked Profile|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|blockedprofile|
|RequiredLevel|None|
|Type|Boolean|

#### BlockedProfile Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_CaseOriginCode"></a> CaseOriginCode

|Property|Value|
|--------|-----|
|Description|Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.|
|DisplayName|Origin|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|caseorigincode|
|RequiredLevel|None|
|Type|Picklist|

#### CaseOriginCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Phone||
|2|Email||
|3|Web||
|2483|Facebook||
|3986|Twitter||



### <a name="BKMK_CaseTypeCode"></a> CaseTypeCode

|Property|Value|
|--------|-----|
|Description|Select the type of case to identify the incident for use in case routing and analysis.|
|DisplayName|Case Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|casetypecode|
|RequiredLevel|None|
|Type|Picklist|

#### CaseTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Question||
|2|Problem||
|3|Request||



### <a name="BKMK_CheckEmail"></a> CheckEmail

|Property|Value|
|--------|-----|
|Description|This attribute is used for Sample Service Business Processes.|
|DisplayName|Check Email|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|checkemail|
|RequiredLevel|None|
|Type|Boolean|

#### CheckEmail Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_ContractDetailId"></a> ContractDetailId

|Property|Value|
|--------|-----|
|Description|Choose the contract line that the case should be logged under to make sure the customer is charged correctly.|
|DisplayName|Contract Line|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|contractdetailid|
|RequiredLevel|None|
|Targets|contractdetail|
|Type|Lookup|


### <a name="BKMK_ContractId"></a> ContractId

|Property|Value|
|--------|-----|
|Description|Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.|
|DisplayName|Contract|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|contractid|
|RequiredLevel|None|
|Targets|contract|
|Type|Lookup|


### <a name="BKMK_ContractServiceLevelCode"></a> ContractServiceLevelCode

|Property|Value|
|--------|-----|
|Description|Select the service level for the case to make sure the case is handled correctly.|
|DisplayName|Service Level|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|contractservicelevelcode|
|RequiredLevel|None|
|Type|Picklist|

#### ContractServiceLevelCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Gold||
|2|Silver||
|3|Bronze||



### <a name="BKMK_CustomerContacted"></a> CustomerContacted

|Property|Value|
|--------|-----|
|Description|Tells whether customer service representative has contacted the customer or not.|
|DisplayName|Customer Contacted|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|customercontacted|
|RequiredLevel|None|
|Type|Boolean|

#### CustomerContacted Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|--------|-----|
|Description|Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.|
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerid|
|RequiredLevel|SystemRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customer Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_CustomerSatisfactionCode"></a> CustomerSatisfactionCode

|Property|Value|
|--------|-----|
|Description|Select the customer's level of satisfaction with the handling and resolution of the case.|
|DisplayName|Satisfaction|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customersatisfactioncode|
|RequiredLevel|None|
|Type|Picklist|

#### CustomerSatisfactionCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Very Dissatisfied||
|2|Dissatisfied||
|3|Neutral||
|4|Satisfied||
|5|Very Satisfied||



### <a name="BKMK_DecrementEntitlementTerm"></a> DecrementEntitlementTerm

|Property|Value|
|--------|-----|
|Description|Shows whether terms of the associated entitlement should be decremented or not.|
|DisplayName|Decrement Entitlement Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|decremententitlementterm|
|RequiredLevel|None|
|Type|Boolean|

#### DecrementEntitlementTerm Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 1



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the case to assist the service team in reaching a resolution.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|--------|-----|
|Description|The primary email address for the entity.|
|DisplayName|Email Address|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntitlementId"></a> EntitlementId

|Property|Value|
|--------|-----|
|Description|Choose the entitlement that is applicable for the case.|
|DisplayName|Entitlement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|entitlementid|
|RequiredLevel|None|
|Targets|entitlement|
|Type|Lookup|


### <a name="BKMK_EntityImage"></a> EntityImage

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|The default image for the entity.|
|DisplayName|Entity Image|
|IsPrimaryImage|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


### <a name="BKMK_ExistingCase"></a> ExistingCase

|Property|Value|
|--------|-----|
|Description|Select an existing case for the customer that has been populated. For internal use only.|
|DisplayName|Existing Case|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|existingcase|
|RequiredLevel|None|
|Targets|incident|
|Type|Lookup|


### <a name="BKMK_FirstResponseByKPIId"></a> FirstResponseByKPIId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|First Response By KPI|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|firstresponsebykpiid|
|RequiredLevel|None|
|Targets|slakpiinstance|
|Type|Lookup|


### <a name="BKMK_FirstResponseSent"></a> FirstResponseSent

|Property|Value|
|--------|-----|
|Description|Indicates if the first response has been sent.|
|DisplayName|First Response Sent|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|firstresponsesent|
|RequiredLevel|None|
|Type|Boolean|

#### FirstResponseSent Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_FirstResponseSLAStatus"></a> FirstResponseSLAStatus

|Property|Value|
|--------|-----|
|Description|Shows the status of the initial response time for the case according to the terms of the SLA.|
|DisplayName|First Response SLA Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|firstresponseslastatus|
|RequiredLevel|None|
|Type|Picklist|

#### FirstResponseSLAStatus Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|In Progress||
|2|Nearing Noncompliance||
|3|Succeeded||
|4|Noncompliant||



### <a name="BKMK_FollowupBy"></a> FollowupBy

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date by which a customer service representative has to follow up with the customer on this case.|
|DisplayName|Follow Up By|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|followupby|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_FollowUpTaskCreated"></a> FollowUpTaskCreated

|Property|Value|
|--------|-----|
|Description|This attribute is used for Sample Service Business Processes.|
|DisplayName|Follow up Task Created|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|followuptaskcreated|
|RequiredLevel|None|
|Type|Boolean|

#### FollowUpTaskCreated Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IncidentId"></a> IncidentId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the case.|
|DisplayName|Case|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|incidentid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_IncidentStageCode"></a> IncidentStageCode

|Property|Value|
|--------|-----|
|Description|Select the current stage of the service process for the case to assist service team members when they review or transfer a case.|
|DisplayName|Case Stage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|incidentstagecode|
|RequiredLevel|None|
|Type|Picklist|

#### IncidentStageCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_InfluenceScore"></a> InfluenceScore

|Property|Value|
|--------|-----|
|Description|Will contain the Influencer score coming from NetBreeze.|
|DisplayName|Influence Score|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|influencescore|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_IsDecrementing"></a> IsDecrementing

|Property|Value|
|--------|-----|
|Description|For system use only.|
|DisplayName|Decrementing|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isdecrementing|
|RequiredLevel|None|
|Type|Boolean|

#### IsDecrementing Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_IsEscalated"></a> IsEscalated

|Property|Value|
|--------|-----|
|Description|Indicates if the case has been escalated.|
|DisplayName|Is Escalated|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isescalated|
|RequiredLevel|None|
|Type|Boolean|

#### IsEscalated Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_KbArticleId"></a> KbArticleId

|Property|Value|
|--------|-----|
|Description|Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.|
|DisplayName|Knowledge Base Article|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|kbarticleid|
|RequiredLevel|None|
|Targets|kbarticle|
|Type|Lookup|


### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Contains the date time stamp of the last on hold time.|
|DisplayName|Last On Hold Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastonholdtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_MasterId"></a> MasterId

|Property|Value|
|--------|-----|
|Description|Choose the primary case the current case was merged into.|
|DisplayName|Master Case|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|masterid|
|RequiredLevel|None|
|Targets|incident|
|Type|Lookup|


### <a name="BKMK_MessageTypeCode"></a> MessageTypeCode

|Property|Value|
|--------|-----|
|Description|Shows whether the post originated as a public or private message.|
|DisplayName|Received As|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|messagetypecode|
|RequiredLevel|None|
|Type|Picklist|

#### MessageTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Public Message||
|1|Private Message||



### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_ParentCaseId"></a> ParentCaseId

|Property|Value|
|--------|-----|
|Description|Choose the parent case for a case.|
|DisplayName|Parent Case|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parentcaseid|
|RequiredLevel|None|
|Targets|incident|
|Type|Lookup|


### <a name="BKMK_PrimaryContactId"></a> PrimaryContactId

|Property|Value|
|--------|-----|
|Description|Select a primary contact for this case.|
|DisplayName|Contact|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|primarycontactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|--------|-----|
|Description|Select the priority so that preferred customers or critical issues are handled quickly.|
|DisplayName|Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|prioritycode|
|RequiredLevel|None|
|Type|Picklist|

#### PriorityCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|High||
|2|Normal||
|3|Low||



### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Contains the id of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ProductId"></a> ProductId

|Property|Value|
|--------|-----|
|Description|Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.|
|DisplayName|Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|productid|
|RequiredLevel|None|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_ProductSerialNumber"></a> ProductSerialNumber

|Property|Value|
|--------|-----|
|Description|Type the serial number of the product that is associated with this case, so that the number of cases per product can be reported.|
|DisplayName|Serial Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|productserialnumber|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ResolveBy"></a> ResolveBy

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date by when the case must be resolved.|
|DisplayName|Resolve By|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resolveby|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ResolveByKPIId"></a> ResolveByKPIId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Resolve By KPI|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resolvebykpiid|
|RequiredLevel|None|
|Targets|slakpiinstance|
|Type|Lookup|


### <a name="BKMK_ResolveBySLAStatus"></a> ResolveBySLAStatus

|Property|Value|
|--------|-----|
|Description|Shows the status of the resolution time for the case according to the terms of the SLA.|
|DisplayName|Resolve By SLA Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resolvebyslastatus|
|RequiredLevel|None|
|Type|Picklist|

#### ResolveBySLAStatus Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|In Progress||
|2|Nearing Noncompliance||
|3|Succeeded||
|4|Noncompliant||



### <a name="BKMK_ResponseBy"></a> ResponseBy

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|For internal use only.|
|DisplayName|First Response By|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|responseby|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ResponsibleContactId"></a> ResponsibleContactId

|Property|Value|
|--------|-----|
|Description|Choose an additional customer contact who can also help resolve the case.|
|DisplayName|Responsible Contact|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|responsiblecontactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_RouteCase"></a> RouteCase

|Property|Value|
|--------|-----|
|Description|Tells whether the incident has been routed to queue or not.|
|DisplayName|Route Case|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|routecase|
|RequiredLevel|None|
|Type|Boolean|

#### RouteCase Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 1



### <a name="BKMK_SentimentValue"></a> SentimentValue

|Property|Value|
|--------|-----|
|Description|Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.|
|DisplayName|Sentiment Value|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sentimentvalue|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_ServiceStage"></a> ServiceStage

|Property|Value|
|--------|-----|
|Description|Select the stage, in the case resolution process, that the case is in.|
|DisplayName|Service Stage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|servicestage|
|RequiredLevel|None|
|Type|Picklist|

#### ServiceStage Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Identify||
|1|Research||
|2|Resolve||



### <a name="BKMK_SeverityCode"></a> SeverityCode

|Property|Value|
|--------|-----|
|Description|Select the severity of this case to indicate the incident's impact on the customer's business.|
|DisplayName|Severity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|severitycode|
|RequiredLevel|None|
|Type|Picklist|

#### SeverityCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) that you want to apply to the case record.|
|DisplayName|SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|slaid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SocialProfileId"></a> SocialProfileId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the social profile with which the case is associated.|
|DisplayName|Social Profile|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|socialprofileid|
|RequiredLevel|None|
|Targets|socialprofile|
|Type|Lookup|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Contains the id of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be edited unless they are reactivated.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Resolved|5|Resolved|
|2|Canceled|6|Canceled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the case's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|In Progress|0|
|2|On Hold|0|
|3|Waiting for Details|0|
|4|Researching|0|
|5|Problem Solved|1|
|6|Canceled|2|
|1000|Information Provided|1|
|2000|Merged|2|



### <a name="BKMK_SubjectId"></a> SubjectId

|Property|Value|
|--------|-----|
|Description|Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.|
|DisplayName|Subject|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subjectid|
|RequiredLevel|None|
|Targets|subject|
|Type|Lookup|


### <a name="BKMK_TicketNumber"></a> TicketNumber

|Property|Value|
|--------|-----|
|Description|Shows the case number for customer reference and searching capabilities. This cannot be modified.|
|DisplayName|Case Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|ticketnumber|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Title"></a> Title

|Property|Value|
|--------|-----|
|Description|Type a subject or descriptive name, such as the request, issue, or company name, to identify the case in Microsoft Dynamics 365 views.|
|DisplayName|Case Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|title|
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.|
|DisplayName|Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AccountId](#BKMK_AccountId)
- [AccountIdName](#BKMK_AccountIdName)
- [AccountIdYomiName](#BKMK_AccountIdYomiName)
- [ContactId](#BKMK_ContactId)
- [ContactIdName](#BKMK_ContactIdName)
- [ContactIdYomiName](#BKMK_ContactIdYomiName)
- [ContractDetailIdName](#BKMK_ContractDetailIdName)
- [ContractIdName](#BKMK_ContractIdName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedByExternalPartyName](#BKMK_CreatedByExternalPartyName)
- [CreatedByExternalPartyYomiName](#BKMK_CreatedByExternalPartyYomiName)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [EntitlementIdName](#BKMK_EntitlementIdName)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [EscalatedOn](#BKMK_EscalatedOn)
- [ExchangeRate](#BKMK_ExchangeRate)
- [FirstResponseByKPIIdName](#BKMK_FirstResponseByKPIIdName)
- [KbArticleIdName](#BKMK_KbArticleIdName)
- [MasterIdName](#BKMK_MasterIdName)
- [Merged](#BKMK_Merged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByExternalParty](#BKMK_ModifiedByExternalParty)
- [ModifiedByExternalPartyName](#BKMK_ModifiedByExternalPartyName)
- [ModifiedByExternalPartyYomiName](#BKMK_ModifiedByExternalPartyYomiName)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [NumberOfChildIncidents](#BKMK_NumberOfChildIncidents)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ParentCaseIdName](#BKMK_ParentCaseIdName)
- [PrimaryContactIdName](#BKMK_PrimaryContactIdName)
- [PrimaryContactIdYomiName](#BKMK_PrimaryContactIdYomiName)
- [ProductIdName](#BKMK_ProductIdName)
- [ResolveByKPIIdName](#BKMK_ResolveByKPIIdName)
- [ResponsibleContactIdName](#BKMK_ResponsibleContactIdName)
- [ResponsibleContactIdYomiName](#BKMK_ResponsibleContactIdYomiName)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [SocialProfileIdName](#BKMK_SocialProfileIdName)
- [SubjectIdName](#BKMK_SubjectIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the account with which the case is associated.|
|DisplayName|Account|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountid|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_AccountIdName"></a> AccountIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|accountidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the contact associated with the case.|
|DisplayName|Contact|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactid|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_ContactIdName"></a> ContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContactIdYomiName"></a> ContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContractDetailIdName"></a> ContractDetailIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contractdetailidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContractIdName"></a> ContractIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contractidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who created the record.|
|DisplayName|Created By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridname|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridyominame|
|MaxLength|450|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_EntitlementIdName"></a> EntitlementIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entitlementidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_timestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_url|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_EscalatedOn"></a> EscalatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Indicates the date and time when the case was escalated.|
|DisplayName|Escalated On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|escalatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_FirstResponseByKPIIdName"></a> FirstResponseByKPIIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|firstresponsebykpiidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_KbArticleIdName"></a> KbArticleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|kbarticleidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MasterIdName"></a> MasterIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|masteridname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Merged"></a> Merged

|Property|Value|
|--------|-----|
|Description|Tells whether the incident has been merged with another incident.|
|DisplayName|Internal Use Only|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|merged|
|RequiredLevel|None|
|Type|Boolean|

#### Merged Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who modified the record.|
|DisplayName|Modified By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_NumberOfChildIncidents"></a> NumberOfChildIncidents

|Property|Value|
|--------|-----|
|Description|Number of child incidents associated with the incident.|
|DisplayName|Child Cases|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|numberofchildincidents|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|--------|-----|
|Description|Shows the duration in minutes for which the case was on hold.|
|DisplayName|On Hold Time (Minutes)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|onholdtime|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ParentCaseIdName"></a> ParentCaseIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentcaseidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PrimaryContactIdName"></a> PrimaryContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|primarycontactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PrimaryContactIdYomiName"></a> PrimaryContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|primarycontactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProductIdName"></a> ProductIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|productidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ResolveByKPIIdName"></a> ResolveByKPIIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|resolvebykpiidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ResponsibleContactIdName"></a> ResponsibleContactIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|responsiblecontactidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ResponsibleContactIdYomiName"></a> ResponsibleContactIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|responsiblecontactidyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|--------|-----|
|Description|Last SLA that was applied to this case. This field is for internal use only.|
|DisplayName|Last SLA applied|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAName"></a> SLAName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SocialProfileIdName"></a> SocialProfileIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|socialprofileidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SubjectIdName"></a> SubjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|subjectidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [Incident_ActivityPointers](#BKMK_Incident_ActivityPointers)
- [Incident_SyncErrors](#BKMK_Incident_SyncErrors)
- [incident_activity_parties](#BKMK_incident_activity_parties)
- [Incident_DuplicateMatchingRecord](#BKMK_Incident_DuplicateMatchingRecord)
- [Incident_DuplicateBaseRecord](#BKMK_Incident_DuplicateBaseRecord)
- [Incident_AsyncOperations](#BKMK_Incident_AsyncOperations)
- [Incident_MailboxTrackingFolder](#BKMK_Incident_MailboxTrackingFolder)
- [Incident_ProcessSessions](#BKMK_Incident_ProcessSessions)
- [Incident_BulkDeleteFailures](#BKMK_Incident_BulkDeleteFailures)
- [incident_principalobjectattributeaccess](#BKMK_incident_principalobjectattributeaccess)
- [Incident_Appointments](#BKMK_Incident_Appointments)
- [Incident_Emails](#BKMK_Incident_Emails)
- [Incident_Faxes](#BKMK_Incident_Faxes)
- [Incident_Letters](#BKMK_Incident_Letters)
- [Incident_Phonecalls](#BKMK_Incident_Phonecalls)
- [Incident_Tasks](#BKMK_Incident_Tasks)
- [Incident_RecurringAppointmentMasters](#BKMK_Incident_RecurringAppointmentMasters)
- [Incident_SocialActivities](#BKMK_Incident_SocialActivities)
- [incident_connections1](#BKMK_incident_connections1)
- [incident_connections2](#BKMK_incident_connections2)
- [Incident_QueueItem](#BKMK_Incident_QueueItem)
- [Incident_Annotation](#BKMK_Incident_Annotation)
- [slakpiinstance_incident](#BKMK_slakpiinstance_incident)
- [Incident_ServiceAppointments](#BKMK_Incident_ServiceAppointments)
- [incident_actioncard](#BKMK_incident_actioncard)
- [Incident_IncidentResolutions](#BKMK_Incident_IncidentResolutions)
- [incident_PostFollows](#BKMK_incident_PostFollows)
- [incident_existingcase](#BKMK_incident_existingcase)
- [incident_master_incident](#BKMK_incident_master_incident)
- [incident_parent_incident](#BKMK_incident_parent_incident)
- [OriginatingCase_Lead](#BKMK_OriginatingCase_Lead)
- [knowledgearticle_incidents](#BKMK_knowledgearticle_incidents)
- [lk_phonetocaseprocess_incidentid](#BKMK_lk_phonetocaseprocess_incidentid)
- [incident_OpportunityCloses](#BKMK_incident_OpportunityCloses)
- [incident_OrderCloses](#BKMK_incident_OrderCloses)
- [incident_QuoteCloses](#BKMK_incident_QuoteCloses)


### <a name="BKMK_Incident_ActivityPointers"></a> Incident_ActivityPointers

**Added by**: System Solution Solution

Same as the [Incident_ActivityPointers](activitypointer.md#BKMK_Incident_ActivityPointers) many-to-one relationship for the [activitypointer](activitypointer.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Incident_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_SyncErrors"></a> Incident_SyncErrors

**Added by**: System Solution Solution

Same as the [Incident_SyncErrors](syncerror.md#BKMK_Incident_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_incident_activity_parties"></a> incident_activity_parties

**Added by**: System Solution Solution

Same as the [incident_activity_parties](activityparty.md#BKMK_incident_activity_parties) many-to-one relationship for the [activityparty](activityparty.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|partyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|incident_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_DuplicateMatchingRecord"></a> Incident_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as the [Incident_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Incident_DuplicateMatchingRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Incident_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_DuplicateBaseRecord"></a> Incident_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as the [Incident_DuplicateBaseRecord](duplicaterecord.md#BKMK_Incident_DuplicateBaseRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Incident_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_AsyncOperations"></a> Incident_AsyncOperations

**Added by**: System Solution Solution

Same as the [Incident_AsyncOperations](asyncoperation.md#BKMK_Incident_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Incident_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_MailboxTrackingFolder"></a> Incident_MailboxTrackingFolder

**Added by**: System Solution Solution

Same as the [Incident_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Incident_MailboxTrackingFolder) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_MailboxTrackingFolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Incident_ProcessSessions"></a> Incident_ProcessSessions

**Added by**: System Solution Solution

Same as the [Incident_ProcessSessions](processsession.md#BKMK_Incident_ProcessSessions) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Incident_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_BulkDeleteFailures"></a> Incident_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [Incident_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Incident_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Incident_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_incident_principalobjectattributeaccess"></a> incident_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as the [incident_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_incident_principalobjectattributeaccess) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|incident_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_Appointments"></a> Incident_Appointments

**Added by**: System Solution Solution

Same as the [Incident_Appointments](appointment.md#BKMK_Incident_Appointments) many-to-one relationship for the [appointment](appointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Incident_Emails"></a> Incident_Emails

**Added by**: System Solution Solution

Same as the [Incident_Emails](email.md#BKMK_Incident_Emails) many-to-one relationship for the [email](email.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Incident_Faxes"></a> Incident_Faxes

**Added by**: System Solution Solution

Same as the [Incident_Faxes](fax.md#BKMK_Incident_Faxes) many-to-one relationship for the [fax](fax.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Incident_Letters"></a> Incident_Letters

**Added by**: System Solution Solution

Same as the [Incident_Letters](letter.md#BKMK_Incident_Letters) many-to-one relationship for the [letter](letter.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Incident_Phonecalls"></a> Incident_Phonecalls

**Added by**: System Solution Solution

Same as the [Incident_Phonecalls](phonecall.md#BKMK_Incident_Phonecalls) many-to-one relationship for the [phonecall](phonecall.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_Phonecalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Incident_Tasks"></a> Incident_Tasks

**Added by**: System Solution Solution

Same as the [Incident_Tasks](task.md#BKMK_Incident_Tasks) many-to-one relationship for the [task](task.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Incident_RecurringAppointmentMasters"></a> Incident_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as the [Incident_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Incident_RecurringAppointmentMasters) many-to-one relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Incident_SocialActivities"></a> Incident_SocialActivities

**Added by**: System Solution Solution

Same as the [Incident_SocialActivities](socialactivity.md#BKMK_Incident_SocialActivities) many-to-one relationship for the [socialactivity](socialactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_incident_connections1"></a> incident_connections1

**Added by**: System Solution Solution

Same as the [incident_connections1](connection.md#BKMK_incident_connections1) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incident_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_incident_connections2"></a> incident_connections2

**Added by**: System Solution Solution

Same as the [incident_connections2](connection.md#BKMK_incident_connections2) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incident_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_QueueItem"></a> Incident_QueueItem

**Added by**: System Solution Solution

Same as the [Incident_QueueItem](queueitem.md#BKMK_Incident_QueueItem) many-to-one relationship for the [queueitem](queueitem.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_Annotation"></a> Incident_Annotation

**Added by**: System Solution Solution

Same as the [Incident_Annotation](annotation.md#BKMK_Incident_Annotation) many-to-one relationship for the [annotation](annotation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_slakpiinstance_incident"></a> slakpiinstance_incident

**Added by**: System Solution Solution

Same as the [slakpiinstance_incident](slakpiinstance.md#BKMK_slakpiinstance_incident) many-to-one relationship for the [slakpiinstance](slakpiinstance.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|slakpiinstance_incident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_ServiceAppointments"></a> Incident_ServiceAppointments

Same as the [Incident_ServiceAppointments](serviceappointment.md#BKMK_Incident_ServiceAppointments) many-to-one relationship for the [serviceappointment](serviceappointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_incident_actioncard"></a> incident_actioncard

**Added by**: System Solution Solution

Same as the [incident_actioncard](actioncard.md#BKMK_incident_actioncard) many-to-one relationship for the [actioncard](actioncard.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incident_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Incident_IncidentResolutions"></a> Incident_IncidentResolutions

Same as the [Incident_IncidentResolutions](incidentresolution.md#BKMK_Incident_IncidentResolutions) many-to-one relationship for the [incidentresolution](incidentresolution.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|incidentid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Incident_IncidentResolutions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_incident_PostFollows"></a> incident_PostFollows

**Added by**: System Solution Solution

Same as the [incident_PostFollows](postfollow.md#BKMK_incident_PostFollows) many-to-one relationship for the [postfollow](postfollow.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|postfollow|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|incident_PostFollows|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_incident_existingcase"></a> incident_existingcase

Same as the [incident_existingcase](incident.md#BKMK_incident_existingcase) many-to-one relationship for the [incident](incident.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|existingcase|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incident_existingcase|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_incident_master_incident"></a> incident_master_incident

Same as the [incident_master_incident](incident.md#BKMK_incident_master_incident) many-to-one relationship for the [incident](incident.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|masterid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|incident_master_incident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_incident_parent_incident"></a> incident_parent_incident

Same as the [incident_parent_incident](incident.md#BKMK_incident_parent_incident) many-to-one relationship for the [incident](incident.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|parentcaseid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|incident_parent_incident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_OriginatingCase_Lead"></a> OriginatingCase_Lead

Same as the [OriginatingCase_Lead](lead.md#BKMK_OriginatingCase_Lead) many-to-one relationship for the [lead](lead.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|originatingcaseid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|OriginatingCase_Lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_knowledgearticle_incidents"></a> knowledgearticle_incidents

Same as the [knowledgearticle_incidents](knowledgearticleincident.md#BKMK_knowledgearticle_incidents) many-to-one relationship for the [knowledgearticleincident](knowledgearticleincident.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticleincident|
|ReferencingAttribute|incidentid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|knowledgearticle_incidents|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_phonetocaseprocess_incidentid"></a> lk_phonetocaseprocess_incidentid

Same as the [lk_phonetocaseprocess_incidentid](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_incidentid) many-to-one relationship for the [phonetocaseprocess](phonetocaseprocess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonetocaseprocess|
|ReferencingAttribute|incidentid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incident_phonetocaseprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_incident_OpportunityCloses"></a> incident_OpportunityCloses

**Added by**: Sales Solution

Same as the [incident_OpportunityCloses](opportunityclose.md#BKMK_incident_OpportunityCloses) many-to-one relationship for the [opportunityclose](opportunityclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incident_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_incident_OrderCloses"></a> incident_OrderCloses

**Added by**: Sales Solution

Same as the [incident_OrderCloses](orderclose.md#BKMK_incident_OrderCloses) many-to-one relationship for the [orderclose](orderclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incident_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_incident_QuoteCloses"></a> incident_QuoteCloses

**Added by**: Sales Solution

Same as the [incident_QuoteCloses](quoteclose.md#BKMK_incident_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incident_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_incidentbase_createdby](#BKMK_lk_incidentbase_createdby)
- [lk_incidentbase_createdonbehalfby](#BKMK_lk_incidentbase_createdonbehalfby)
- [lk_incidentbase_modifiedby](#BKMK_lk_incidentbase_modifiedby)
- [lk_incidentbase_modifiedonbehalfby](#BKMK_lk_incidentbase_modifiedonbehalfby)
- [system_user_incidents](#BKMK_system_user_incidents)
- [team_incidents](#BKMK_team_incidents)
- [business_unit_incidents](#BKMK_business_unit_incidents)
- [processstage_incident](#BKMK_processstage_incident)
- [manualsla_cases](#BKMK_manualsla_cases)
- [sla_cases](#BKMK_sla_cases)
- [incident_customer_accounts](#BKMK_incident_customer_accounts)
- [contact_as_responsible_contact](#BKMK_contact_as_responsible_contact)
- [incident_customer_contacts](#BKMK_incident_customer_contacts)
- [contact_as_primary_contact](#BKMK_contact_as_primary_contact)
- [contract_cases](#BKMK_contract_cases)
- [contract_detail_cases](#BKMK_contract_detail_cases)
- [entitlement_cases](#BKMK_entitlement_cases)
- [incident_existingcase](#BKMK_incident_existingcase)
- [incident_master_incident](#BKMK_incident_master_incident)
- [incident_parent_incident](#BKMK_incident_parent_incident)
- [kbarticle_incidents](#BKMK_kbarticle_incidents)
- [product_incidents](#BKMK_product_incidents)
- [slakpiinstance_incident_firstresponsebykpi](#BKMK_slakpiinstance_incident_firstresponsebykpi)
- [slakpiinstance_incident_resolvebykpi](#BKMK_slakpiinstance_incident_resolvebykpi)
- [socialprofile_cases](#BKMK_socialprofile_cases)
- [subject_incidents](#BKMK_subject_incidents)
- [TransactionCurrency_Incident](#BKMK_TransactionCurrency_Incident)


### <a name="BKMK_lk_incidentbase_createdby"></a> lk_incidentbase_createdby

**Added by**: System Solution Solution

See the [lk_incidentbase_createdby](systemuser.md#BKMK_lk_incidentbase_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_incidentbase_createdonbehalfby"></a> lk_incidentbase_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_incidentbase_createdonbehalfby](systemuser.md#BKMK_lk_incidentbase_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_incidentbase_modifiedby"></a> lk_incidentbase_modifiedby

**Added by**: System Solution Solution

See the [lk_incidentbase_modifiedby](systemuser.md#BKMK_lk_incidentbase_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_incidentbase_modifiedonbehalfby"></a> lk_incidentbase_modifiedonbehalfby

**Added by**: System Solution Solution

See the [lk_incidentbase_modifiedonbehalfby](systemuser.md#BKMK_lk_incidentbase_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_system_user_incidents"></a> system_user_incidents

**Added by**: System Solution Solution

See the [system_user_incidents](systemuser.md#BKMK_system_user_incidents) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_team_incidents"></a> team_incidents

**Added by**: System Solution Solution

See the [team_incidents](team.md#BKMK_team_incidents) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_business_unit_incidents"></a> business_unit_incidents

**Added by**: System Solution Solution

See the [business_unit_incidents](businessunit.md#BKMK_business_unit_incidents) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_processstage_incident"></a> processstage_incident

**Added by**: System Solution Solution

See the [processstage_incident](processstage.md#BKMK_processstage_incident) one-to-many relationship for the [processstage](processstage.md) entity.

### <a name="BKMK_manualsla_cases"></a> manualsla_cases

**Added by**: System Solution Solution

See the [manualsla_cases](sla.md#BKMK_manualsla_cases) one-to-many relationship for the [sla](sla.md) entity.

### <a name="BKMK_sla_cases"></a> sla_cases

**Added by**: System Solution Solution

See the [sla_cases](sla.md#BKMK_sla_cases) one-to-many relationship for the [sla](sla.md) entity.

### <a name="BKMK_incident_customer_accounts"></a> incident_customer_accounts

**Added by**: System Solution Solution

See the [incident_customer_accounts](account.md#BKMK_incident_customer_accounts) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_contact_as_responsible_contact"></a> contact_as_responsible_contact

**Added by**: System Solution Solution

See the [contact_as_responsible_contact](contact.md#BKMK_contact_as_responsible_contact) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_incident_customer_contacts"></a> incident_customer_contacts

**Added by**: System Solution Solution

See the [incident_customer_contacts](contact.md#BKMK_incident_customer_contacts) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_contact_as_primary_contact"></a> contact_as_primary_contact

**Added by**: System Solution Solution

See the [contact_as_primary_contact](contact.md#BKMK_contact_as_primary_contact) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_contract_cases"></a> contract_cases

See the [contract_cases](contract.md#BKMK_contract_cases) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_contract_detail_cases"></a> contract_detail_cases

See the [contract_detail_cases](contractdetail.md#BKMK_contract_detail_cases) one-to-many relationship for the [contractdetail](contractdetail.md) entity.

### <a name="BKMK_entitlement_cases"></a> entitlement_cases

See the [entitlement_cases](entitlement.md#BKMK_entitlement_cases) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_incident_existingcase"></a> incident_existingcase

See the [incident_existingcase](incident.md#BKMK_incident_existingcase) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_incident_master_incident"></a> incident_master_incident

See the [incident_master_incident](incident.md#BKMK_incident_master_incident) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_incident_parent_incident"></a> incident_parent_incident

See the [incident_parent_incident](incident.md#BKMK_incident_parent_incident) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_kbarticle_incidents"></a> kbarticle_incidents

**Added by**: System Solution Solution

See the [kbarticle_incidents](kbarticle.md#BKMK_kbarticle_incidents) one-to-many relationship for the [kbarticle](kbarticle.md) entity.

### <a name="BKMK_product_incidents"></a> product_incidents

**Added by**: Product Management Solution

See the [product_incidents](product.md#BKMK_product_incidents) one-to-many relationship for the [product](product.md) entity.

### <a name="BKMK_slakpiinstance_incident_firstresponsebykpi"></a> slakpiinstance_incident_firstresponsebykpi

**Added by**: System Solution Solution

See the [slakpiinstance_incident_firstresponsebykpi](slakpiinstance.md#BKMK_slakpiinstance_incident_firstresponsebykpi) one-to-many relationship for the [slakpiinstance](slakpiinstance.md) entity.

### <a name="BKMK_slakpiinstance_incident_resolvebykpi"></a> slakpiinstance_incident_resolvebykpi

**Added by**: System Solution Solution

See the [slakpiinstance_incident_resolvebykpi](slakpiinstance.md#BKMK_slakpiinstance_incident_resolvebykpi) one-to-many relationship for the [slakpiinstance](slakpiinstance.md) entity.

### <a name="BKMK_socialprofile_cases"></a> socialprofile_cases

**Added by**: System Solution Solution

See the [socialprofile_cases](socialprofile.md#BKMK_socialprofile_cases) one-to-many relationship for the [socialprofile](socialprofile.md) entity.

### <a name="BKMK_subject_incidents"></a> subject_incidents

**Added by**: System Solution Solution

See the [subject_incidents](subject.md#BKMK_subject_incidents) one-to-many relationship for the [subject](subject.md) entity.

### <a name="BKMK_TransactionCurrency_Incident"></a> TransactionCurrency_Incident

**Added by**: System Solution Solution

See the [TransactionCurrency_Incident](transactioncurrency.md#BKMK_TransactionCurrency_Incident) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Incident entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_KnowledgeBaseRecord_Incident"></a> KnowledgeBaseRecord_Incident

See the [KnowledgeBaseRecord_Incident](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Incident) many-to-many relationship for the [knowledgebaserecord](knowledgebaserecord.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
