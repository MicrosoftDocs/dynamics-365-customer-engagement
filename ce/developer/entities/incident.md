---
title: "Incident Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Incident entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Incident Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Service request case associated with a contract.

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|ApplyRoutingRule|<xref href="Microsoft.Dynamics.CRM.ApplyRoutingRule?text=ApplyRoutingRule Action" />|<xref:Microsoft.Crm.Sdk.Messages.ApplyRoutingRuleRequest>|
|Assign|PATCH [*org URI*]/api/data/v9.0/incidents(*incidentid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CalculateTotalTimeIncident|<xref href="Microsoft.Dynamics.CRM.CalculateTotalTimeIncident?text=CalculateTotalTimeIncident Function" />|<xref:Microsoft.Crm.Sdk.Messages.CalculateTotalTimeIncidentRequest>|
|CloseIncident|<xref href="Microsoft.Dynamics.CRM.CloseIncident?text=CloseIncident Action" />|<xref:Microsoft.Crm.Sdk.Messages.CloseIncidentRequest>|
|CloseQuote|<xref href="Microsoft.Dynamics.CRM.CloseQuote?text=CloseQuote Action" />|<xref:Microsoft.Crm.Sdk.Messages.CloseQuoteRequest>|
|Create|POST [*org URI*]/api/data/v9.0/incidents<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/incidents(*incidentid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Merge|<xref href="Microsoft.Dynamics.CRM.Merge?text=Merge Action" />|<xref:Microsoft.Crm.Sdk.Messages.MergeRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/incidents(*incidentid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/incidents<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref href="Microsoft.Dynamics.CRM.Rollup?text=Rollup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/incidents(*incidentid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/incidents(*incidentid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Case<br />
**DisplayCollectionName**: Cases<br />
**SchemaName**: Incident<br />
**CollectionSchemaName**: Incidents<br />
**LogicalName**: incident<br />
**LogicalCollectionName**: incidents<br />
**EntitySetName**: incidents<br />
**PrimaryIdAttribute**: incidentid<br />
**PrimaryNameAttribute**: title<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
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
- [msdyn_IncidentType](#BKMK_msdyn_IncidentType)
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

**Description**: This attribute is used for Sample Service Business Processes.<br />
**DisplayName**: Activities Complete<br />
**LogicalName**: activitiescomplete<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ActualServiceUnits"></a> ActualServiceUnits

**Description**: Type the number of service units that were actually required to resolve the case.<br />
**DisplayName**: Actual Service Units<br />
**LogicalName**: actualserviceunits<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_BilledServiceUnits"></a> BilledServiceUnits

**Description**: Type the number of service units that were billed to the customer for the case.<br />
**DisplayName**: Billed Service Units<br />
**LogicalName**: billedserviceunits<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_BlockedProfile"></a> BlockedProfile

**Description**: Details whether the profile is blocked or not.<br />
**DisplayName**: Blocked Profile<br />
**LogicalName**: blockedprofile<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_CaseOriginCode"></a> CaseOriginCode

**Description**: Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.<br />
**DisplayName**: Origin<br />
**LogicalName**: caseorigincode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Phone
- **Value**: 2 **Label**: Email
- **Value**: 3 **Label**: Web
- **Value**: 2483 **Label**: Facebook
- **Value**: 3986 **Label**: Twitter



### <a name="BKMK_CaseTypeCode"></a> CaseTypeCode

**Description**: Select the type of case to identify the incident for use in case routing and analysis.<br />
**DisplayName**: Case Type<br />
**LogicalName**: casetypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Question
- **Value**: 2 **Label**: Problem
- **Value**: 3 **Label**: Request



### <a name="BKMK_CheckEmail"></a> CheckEmail

**Description**: This attribute is used for Sample Service Business Processes.<br />
**DisplayName**: Check Email<br />
**LogicalName**: checkemail<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ContractDetailId"></a> ContractDetailId

**Description**: Choose the contract line that the case should be logged under to make sure the customer is charged correctly.<br />
**DisplayName**: Contract Line<br />
**LogicalName**: contractdetailid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contractdetail


### <a name="BKMK_ContractId"></a> ContractId

**Description**: Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.<br />
**DisplayName**: Contract<br />
**LogicalName**: contractid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contract


### <a name="BKMK_ContractServiceLevelCode"></a> ContractServiceLevelCode

**Description**: Select the service level for the case to make sure the case is handled correctly.<br />
**DisplayName**: Service Level<br />
**LogicalName**: contractservicelevelcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Gold
- **Value**: 2 **Label**: Silver
- **Value**: 3 **Label**: Bronze



### <a name="BKMK_CustomerContacted"></a> CustomerContacted

**Description**: Tells whether customer service representative has contacted the customer or not.<br />
**DisplayName**: Customer Contacted<br />
**LogicalName**: customercontacted<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_CustomerId"></a> CustomerId

**Description**: Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.<br />
**DisplayName**: Customer<br />
**LogicalName**: customerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Customer<br />
**Targets**: account,contact


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

**Description**: <br />
**DisplayName**: Customer Type<br />
**LogicalName**: customeridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_CustomerSatisfactionCode"></a> CustomerSatisfactionCode

**Description**: Select the customer's level of satisfaction with the handling and resolution of the case.<br />
**DisplayName**: Satisfaction<br />
**LogicalName**: customersatisfactioncode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Very Dissatisfied
- **Value**: 2 **Label**: Dissatisfied
- **Value**: 3 **Label**: Neutral
- **Value**: 4 **Label**: Satisfied
- **Value**: 5 **Label**: Very Satisfied



### <a name="BKMK_DecrementEntitlementTerm"></a> DecrementEntitlementTerm

**Description**: Shows whether terms of the associated entitlement should be decremented or not.<br />
**DisplayName**: Decrement Entitlement Terms<br />
**LogicalName**: decremententitlementterm<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the case to assist the service team in reaching a resolution.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EmailAddress"></a> EmailAddress

**Description**: The primary email address for the entity.<br />
**DisplayName**: Email Address<br />
**LogicalName**: emailaddress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EntitlementId"></a> EntitlementId

**Description**: Choose the entitlement that is applicable for the case.<br />
**DisplayName**: Entitlement<br />
**LogicalName**: entitlementid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: entitlement


### <a name="BKMK_EntityImage"></a> EntityImage

**Description**: The default image for the entity.<br />
**DisplayName**: Entity Image<br />
**LogicalName**: entityimage<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Image<br />
**IsPrimaryImage**: False<br />
**MaxHeight**: 144<br />
**MaxWidth**: 144


### <a name="BKMK_ExistingCase"></a> ExistingCase

**Description**: Select an existing case for the customer that has been populated. For internal use only.<br />
**DisplayName**: Existing Case<br />
**LogicalName**: existingcase<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: incident


### <a name="BKMK_FirstResponseByKPIId"></a> FirstResponseByKPIId

**Description**: For internal use only.<br />
**DisplayName**: First Response By KPI<br />
**LogicalName**: firstresponsebykpiid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: slakpiinstance


### <a name="BKMK_FirstResponseSent"></a> FirstResponseSent

**Description**: Indicates if the first response has been sent.<br />
**DisplayName**: First Response Sent<br />
**LogicalName**: firstresponsesent<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_FirstResponseSLAStatus"></a> FirstResponseSLAStatus

**Description**: Shows the status of the initial response time for the case according to the terms of the SLA.<br />
**DisplayName**: First Response SLA Status<br />
**LogicalName**: firstresponseslastatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: In Progress
- **Value**: 2 **Label**: Nearing Noncompliance
- **Value**: 3 **Label**: Succeeded
- **Value**: 4 **Label**: Noncompliant



### <a name="BKMK_FollowupBy"></a> FollowupBy

**Description**: Enter the date by which a customer service representative has to follow up with the customer on this case.<br />
**DisplayName**: Follow Up By<br />
**LogicalName**: followupby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_FollowUpTaskCreated"></a> FollowUpTaskCreated

**Description**: This attribute is used for Sample Service Business Processes.<br />
**DisplayName**: Follow up Task Created<br />
**LogicalName**: followuptaskcreated<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_IncidentId"></a> IncidentId

**Description**: Unique identifier of the case.<br />
**DisplayName**: Case<br />
**LogicalName**: incidentid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_IncidentStageCode"></a> IncidentStageCode

**Description**: Select the current stage of the service process for the case to assist service team members when they review or transfer a case.<br />
**DisplayName**: Case Stage<br />
**LogicalName**: incidentstagecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_InfluenceScore"></a> InfluenceScore

**Description**: Will contain the Influencer score coming from NetBreeze.<br />
**DisplayName**: Influence Score<br />
**LogicalName**: influencescore<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_IsDecrementing"></a> IsDecrementing

**Description**: For system use only.<br />
**DisplayName**: Decrementing<br />
**LogicalName**: isdecrementing<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsEscalated"></a> IsEscalated

**Description**: Indicates if the case has been escalated.<br />
**DisplayName**: Is Escalated<br />
**LogicalName**: isescalated<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_KbArticleId"></a> KbArticleId

**Description**: Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.<br />
**DisplayName**: Knowledge Base Article<br />
**LogicalName**: kbarticleid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: kbarticle


### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

**Description**: Contains the date time stamp of the last on hold time.<br />
**DisplayName**: Last On Hold Time<br />
**LogicalName**: lastonholdtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_MasterId"></a> MasterId

**Description**: Choose the primary case the current case was merged into.<br />
**DisplayName**: Master Case<br />
**LogicalName**: masterid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: incident


### <a name="BKMK_MessageTypeCode"></a> MessageTypeCode

**Description**: Shows whether the post originated as a public or private message.<br />
**DisplayName**: Received As<br />
**LogicalName**: messagetypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Public Message
- **Value**: 1 **Label**: Private Message



### <a name="BKMK_msdyn_IncidentType"></a> msdyn_IncidentType

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Incident Type associated with Case.<br />
**DisplayName**: Incident Type<br />
**LogicalName**: msdyn_incidenttype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_incidenttype


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_ParentCaseId"></a> ParentCaseId

**Description**: Choose the parent case for a case.<br />
**DisplayName**: Parent Case<br />
**LogicalName**: parentcaseid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: incident


### <a name="BKMK_PrimaryContactId"></a> PrimaryContactId

**Description**: Select a primary contact for this case.<br />
**DisplayName**: Contact<br />
**LogicalName**: primarycontactid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_PriorityCode"></a> PriorityCode

**Description**: Select the priority so that preferred customers or critical issues are handled quickly.<br />
**DisplayName**: Priority<br />
**LogicalName**: prioritycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: High
- **Value**: 2 **Label**: Normal
- **Value**: 3 **Label**: Low



### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Contains the id of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProductId"></a> ProductId

**Description**: Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.<br />
**DisplayName**: Product<br />
**LogicalName**: productid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_ProductSerialNumber"></a> ProductSerialNumber

**Description**: Type the serial number of the product that is associated with this case, so that the number of cases per product can be reported.<br />
**DisplayName**: Serial Number<br />
**LogicalName**: productserialnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ResolveBy"></a> ResolveBy

**Description**: Enter the date by when the case must be resolved.<br />
**DisplayName**: Resolve By<br />
**LogicalName**: resolveby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ResolveByKPIId"></a> ResolveByKPIId

**Description**: For internal use only.<br />
**DisplayName**: Resolve By KPI<br />
**LogicalName**: resolvebykpiid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: slakpiinstance


### <a name="BKMK_ResolveBySLAStatus"></a> ResolveBySLAStatus

**Description**: Shows the status of the resolution time for the case according to the terms of the SLA.<br />
**DisplayName**: Resolve By SLA Status<br />
**LogicalName**: resolvebyslastatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: In Progress
- **Value**: 2 **Label**: Nearing Noncompliance
- **Value**: 3 **Label**: Succeeded
- **Value**: 4 **Label**: Noncompliant



### <a name="BKMK_ResponseBy"></a> ResponseBy

**Description**: For internal use only.<br />
**DisplayName**: First Response By<br />
**LogicalName**: responseby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ResponsibleContactId"></a> ResponsibleContactId

**Description**: Choose an additional customer contact who can also help resolve the case.<br />
**DisplayName**: Responsible Contact<br />
**LogicalName**: responsiblecontactid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_RouteCase"></a> RouteCase

**Description**: Tells whether the incident has been routed to queue or not.<br />
**DisplayName**: Route Case<br />
**LogicalName**: routecase<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_SentimentValue"></a> SentimentValue

**Description**: Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.<br />
**DisplayName**: Sentiment Value<br />
**LogicalName**: sentimentvalue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Double<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_ServiceStage"></a> ServiceStage

**Description**: Select the stage, in the case resolution process, that the case is in.<br />
**DisplayName**: Service Stage<br />
**LogicalName**: servicestage<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Identify
- **Value**: 1 **Label**: Research
- **Value**: 2 **Label**: Resolve



### <a name="BKMK_SeverityCode"></a> SeverityCode

**Description**: Select the severity of this case to indicate the incident's impact on the customer's business.<br />
**DisplayName**: Severity<br />
**LogicalName**: severitycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the case record.<br />
**DisplayName**: SLA<br />
**LogicalName**: slaid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_SocialProfileId"></a> SocialProfileId

**Description**: Unique identifier of the social profile with which the case is associated.<br />
**DisplayName**: Social Profile<br />
**LogicalName**: socialprofileid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: socialprofile


### <a name="BKMK_StageId"></a> StageId

**Description**: Contains the id of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be edited unless they are reactivated.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Resolved **DefaultStatus**: 5 **InvariantName**: Resolved
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 6 **InvariantName**: Canceled



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the case's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: In Progress **State**: 0
- **Value**: 2 **Label**: On Hold **State**: 0
- **Value**: 3 **Label**: Waiting for Details **State**: 0
- **Value**: 4 **Label**: Researching **State**: 0
- **Value**: 5 **Label**: Problem Solved **State**: 1
- **Value**: 6 **Label**: Canceled **State**: 2
- **Value**: 1000 **Label**: Information Provided **State**: 1
- **Value**: 2000 **Label**: Merged **State**: 2



### <a name="BKMK_SubjectId"></a> SubjectId

**Description**: Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.<br />
**DisplayName**: Subject<br />
**LogicalName**: subjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: subject


### <a name="BKMK_TicketNumber"></a> TicketNumber

**Description**: Shows the case number for customer reference and searching capabilities. This cannot be modified.<br />
**DisplayName**: Case Number<br />
**LogicalName**: ticketnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_Title"></a> Title

**Description**: Type a subject or descriptive name, such as the request, issue, or company name, to identify the case in Microsoft Dynamics 365 views.<br />
**DisplayName**: Case Title<br />
**LogicalName**: title<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648

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
- [msdyn_IncidentTypeName](#BKMK_msdyn_IncidentTypeName)
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

**Description**: Unique identifier of the account with which the case is associated.<br />
**DisplayName**: Account<br />
**LogicalName**: accountid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_AccountIdName"></a> AccountIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: accountidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_AccountIdYomiName"></a> AccountIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: accountidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ContactId"></a> ContactId

**Description**: Unique identifier of the contact associated with the case.<br />
**DisplayName**: Contact<br />
**LogicalName**: contactid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: contact


### <a name="BKMK_ContactIdName"></a> ContactIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: contactidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ContactIdYomiName"></a> ContactIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: contactidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ContractDetailIdName"></a> ContractDetailIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: contractdetailidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ContractIdName"></a> ContractIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: contractidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

**Description**: Shows the external party who created the record.<br />
**DisplayName**: Created By (External Party)<br />
**LogicalName**: createdbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: customeridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: customeridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 450


### <a name="BKMK_EntitlementIdName"></a> EntitlementIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entitlementidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_timestamp<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_url<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_EntityImageId"></a> EntityImageId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_EscalatedOn"></a> EscalatedOn

**Description**: Indicates the date and time when the case was escalated.<br />
**DisplayName**: Escalated On<br />
**LogicalName**: escalatedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_FirstResponseByKPIIdName"></a> FirstResponseByKPIIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: firstresponsebykpiidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_KbArticleIdName"></a> KbArticleIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: kbarticleidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_MasterIdName"></a> MasterIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: masteridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Merged"></a> Merged

**Description**: Tells whether the incident has been merged with another incident.<br />
**DisplayName**: Internal Use Only<br />
**LogicalName**: merged<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

**Description**: Shows the external party who modified the record.<br />
**DisplayName**: Modified By (External Party)<br />
**LogicalName**: modifiedbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_IncidentTypeName"></a> msdyn_IncidentTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_incidenttypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_NumberOfChildIncidents"></a> NumberOfChildIncidents

**Description**: Number of child incidents associated with the incident.<br />
**DisplayName**: Child Cases<br />
**LogicalName**: numberofchildincidents<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

**Description**: Shows the duration in minutes for which the case was on hold.<br />
**DisplayName**: On Hold Time (Minutes)<br />
**LogicalName**: onholdtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ParentCaseIdName"></a> ParentCaseIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentcaseidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_PrimaryContactIdName"></a> PrimaryContactIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: primarycontactidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_PrimaryContactIdYomiName"></a> PrimaryContactIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: primarycontactidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ProductIdName"></a> ProductIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: productidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ResolveByKPIIdName"></a> ResolveByKPIIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: resolvebykpiidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ResponsibleContactIdName"></a> ResponsibleContactIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: responsiblecontactidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ResponsibleContactIdYomiName"></a> ResponsibleContactIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: responsiblecontactidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

**Description**: Last SLA that was applied to this case. This field is for internal use only.<br />
**DisplayName**: Last SLA applied<br />
**LogicalName**: slainvokedid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: slainvokedidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SLAName"></a> SLAName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: slaname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SocialProfileIdName"></a> SocialProfileIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: socialprofileidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SubjectIdName"></a> SubjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: subjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [bpf_incident_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](#BKMK_bpf_incident_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b)
- [Incident_ActivityPointers](#BKMK_Incident_ActivityPointers)
- [Incident_SyncErrors](#BKMK_Incident_SyncErrors)
- [incident_activity_parties](#BKMK_incident_activity_parties)
- [Incident_DuplicateMatchingRecord](#BKMK_Incident_DuplicateMatchingRecord)
- [Incident_DuplicateBaseRecord](#BKMK_Incident_DuplicateBaseRecord)
- [Incident_AsyncOperations](#BKMK_Incident_AsyncOperations)
- [Incident_MailboxTrackingFolder](#BKMK_Incident_MailboxTrackingFolder)
- [userentityinstancedata_incident](#BKMK_userentityinstancedata_incident)
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
- [incident_topic](#BKMK_incident_topic)
- [incident_OpportunityCloses](#BKMK_incident_OpportunityCloses)
- [incident_OrderCloses](#BKMK_incident_OrderCloses)
- [incident_QuoteCloses](#BKMK_incident_QuoteCloses)
- [incident_msdyn_bookingalerts](#BKMK_incident_msdyn_bookingalerts)
- [incident_msdyn_approvals](#BKMK_incident_msdyn_approvals)
- [bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b](#BKMK_bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b)
- [msdyn_incident_msdyn_workorder_ServiceRequest](#BKMK_msdyn_incident_msdyn_workorder_ServiceRequest)


### <a name="BKMK_bpf_incident_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b"></a> bpf_incident_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b

Same as msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b entity [bpf_incident_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_bpf_incident_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b<br />
**ReferencingAttribute**: bpf_incidentid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_incident_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: incident
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_ActivityPointers"></a> Incident_ActivityPointers

Same as activitypointer entity [Incident_ActivityPointers](activitypointer.md#BKMK_Incident_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Incident_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_SyncErrors"></a> Incident_SyncErrors

Same as syncerror entity [Incident_SyncErrors](syncerror.md#BKMK_Incident_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_incident_activity_parties"></a> incident_activity_parties

Same as activityparty entity [incident_activity_parties](activityparty.md#BKMK_incident_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: partyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: incident_activity_parties<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_DuplicateMatchingRecord"></a> Incident_DuplicateMatchingRecord

Same as duplicaterecord entity [Incident_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Incident_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Incident_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_DuplicateBaseRecord"></a> Incident_DuplicateBaseRecord

Same as duplicaterecord entity [Incident_DuplicateBaseRecord](duplicaterecord.md#BKMK_Incident_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Incident_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_AsyncOperations"></a> Incident_AsyncOperations

Same as asyncoperation entity [Incident_AsyncOperations](asyncoperation.md#BKMK_Incident_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Incident_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_MailboxTrackingFolder"></a> Incident_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [Incident_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Incident_MailboxTrackingFolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_MailboxTrackingFolder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_userentityinstancedata_incident"></a> userentityinstancedata_incident

Same as userentityinstancedata entity [userentityinstancedata_incident](userentityinstancedata.md#BKMK_userentityinstancedata_incident) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_incident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_ProcessSessions"></a> Incident_ProcessSessions

Same as processsession entity [Incident_ProcessSessions](processsession.md#BKMK_Incident_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Incident_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_BulkDeleteFailures"></a> Incident_BulkDeleteFailures

Same as bulkdeletefailure entity [Incident_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Incident_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Incident_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incident_principalobjectattributeaccess"></a> incident_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [incident_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_incident_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: incident_principalobjectattributeaccess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_Appointments"></a> Incident_Appointments

Same as appointment entity [Incident_Appointments](appointment.md#BKMK_Incident_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Incident_Emails"></a> Incident_Emails

Same as email entity [Incident_Emails](email.md#BKMK_Incident_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Incident_Faxes"></a> Incident_Faxes

Same as fax entity [Incident_Faxes](fax.md#BKMK_Incident_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Incident_Letters"></a> Incident_Letters

Same as letter entity [Incident_Letters](letter.md#BKMK_Incident_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Incident_Phonecalls"></a> Incident_Phonecalls

Same as phonecall entity [Incident_Phonecalls](phonecall.md#BKMK_Incident_Phonecalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_Phonecalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Incident_Tasks"></a> Incident_Tasks

Same as task entity [Incident_Tasks](task.md#BKMK_Incident_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Incident_RecurringAppointmentMasters"></a> Incident_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [Incident_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_Incident_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_Incident_SocialActivities"></a> Incident_SocialActivities

Same as socialactivity entity [Incident_SocialActivities](socialactivity.md#BKMK_Incident_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_incident_connections1"></a> incident_connections1

Same as connection entity [incident_connections1](connection.md#BKMK_incident_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incident_connections2"></a> incident_connections2

Same as connection entity [incident_connections2](connection.md#BKMK_incident_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_QueueItem"></a> Incident_QueueItem

Same as queueitem entity [Incident_QueueItem](queueitem.md#BKMK_Incident_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_QueueItem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_Annotation"></a> Incident_Annotation

Same as annotation entity [Incident_Annotation](annotation.md#BKMK_Incident_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_Annotation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_slakpiinstance_incident"></a> slakpiinstance_incident

Same as slakpiinstance entity [slakpiinstance_incident](slakpiinstance.md#BKMK_slakpiinstance_incident) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: regarding<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: slakpiinstance_incident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_ServiceAppointments"></a> Incident_ServiceAppointments

Same as serviceappointment entity [Incident_ServiceAppointments](serviceappointment.md#BKMK_Incident_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: RemoveLink
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_incident_actioncard"></a> incident_actioncard

Same as actioncard entity [incident_actioncard](actioncard.md#BKMK_incident_actioncard) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_actioncard<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Incident_IncidentResolutions"></a> Incident_IncidentResolutions

Same as incidentresolution entity [Incident_IncidentResolutions](incidentresolution.md#BKMK_Incident_IncidentResolutions) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: incidentid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Incident_IncidentResolutions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_incident_PostFollows"></a> incident_PostFollows

Same as postfollow entity [incident_PostFollows](postfollow.md#BKMK_incident_PostFollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: incident_PostFollows<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incident_existingcase"></a> incident_existingcase

Same as incident entity [incident_existingcase](incident.md#BKMK_incident_existingcase) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: existingcase<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_existingcase<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incident_master_incident"></a> incident_master_incident

Same as incident entity [incident_master_incident](incident.md#BKMK_incident_master_incident) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: masterid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: incident_master_incident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incident_parent_incident"></a> incident_parent_incident

Same as incident entity [incident_parent_incident](incident.md#BKMK_incident_parent_incident) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: parentcaseid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: incident_parent_incident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_OriginatingCase_Lead"></a> OriginatingCase_Lead

Same as lead entity [OriginatingCase_Lead](lead.md#BKMK_OriginatingCase_Lead) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: originatingcaseid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: OriginatingCase_Lead<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_knowledgearticle_incidents"></a> knowledgearticle_incidents

Same as knowledgearticleincident entity [knowledgearticle_incidents](knowledgearticleincident.md#BKMK_knowledgearticle_incidents) Many-To-One relationship.

**ReferencingEntity**: knowledgearticleincident<br />
**ReferencingAttribute**: incidentid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: knowledgearticle_incidents<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_lk_phonetocaseprocess_incidentid"></a> lk_phonetocaseprocess_incidentid

Same as phonetocaseprocess entity [lk_phonetocaseprocess_incidentid](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_incidentid) Many-To-One relationship.

**ReferencingEntity**: phonetocaseprocess<br />
**ReferencingAttribute**: incidentid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_phonetocaseprocess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incident_topic"></a> incident_topic

Same as topic entity [incident_topic](topic.md#BKMK_incident_topic) Many-To-One relationship.

**ReferencingEntity**: topic<br />
**ReferencingAttribute**: incidentid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: incident_topic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incident_OpportunityCloses"></a> incident_OpportunityCloses

Same as opportunityclose entity [incident_OpportunityCloses](opportunityclose.md#BKMK_incident_OpportunityCloses) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_OpportunityCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_incident_OrderCloses"></a> incident_OrderCloses

Same as orderclose entity [incident_OrderCloses](orderclose.md#BKMK_incident_OrderCloses) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_OrderCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_incident_QuoteCloses"></a> incident_QuoteCloses

Same as quoteclose entity [incident_QuoteCloses](quoteclose.md#BKMK_incident_QuoteCloses) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_QuoteCloses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_incident_msdyn_bookingalerts"></a> incident_msdyn_bookingalerts

Same as msdyn_bookingalert entity [incident_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_incident_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_msdyn_bookingalerts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_incident_msdyn_approvals"></a> incident_msdyn_approvals

Same as msdyn_approval entity [incident_msdyn_approvals](msdyn_approval.md#BKMK_incident_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incident_msdyn_approvals<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b"></a> bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b

Same as msdyn_bpf_989e9b1857e24af18787d5143b67523b entity [bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_989e9b1857e24af18787d5143b67523b<br />
**ReferencingAttribute**: bpf_incidentid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_incident_msdyn_bpf_989e9b1857e24af18787d5143b67523b<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: incident
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_incident_msdyn_workorder_ServiceRequest"></a> msdyn_incident_msdyn_workorder_ServiceRequest

Same as msdyn_workorder entity [msdyn_incident_msdyn_workorder_ServiceRequest](msdyn_workorder.md#BKMK_msdyn_incident_msdyn_workorder_ServiceRequest) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_servicerequest<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_incident_msdyn_workorder_ServiceRequest<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

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
- [lk_externalparty_incident_createdby](#BKMK_lk_externalparty_incident_createdby)
- [lk_externalparty_incident_modifiedby](#BKMK_lk_externalparty_incident_modifiedby)
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
- [msdyn_msdyn_incidenttype_incident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_incident_IncidentType)


### <a name="BKMK_lk_incidentbase_createdby"></a> lk_incidentbase_createdby

See systemuser Entity [lk_incidentbase_createdby](systemuser.md#BKMK_lk_incidentbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_incidentbase_createdonbehalfby"></a> lk_incidentbase_createdonbehalfby

See systemuser Entity [lk_incidentbase_createdonbehalfby](systemuser.md#BKMK_lk_incidentbase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_incidentbase_modifiedby"></a> lk_incidentbase_modifiedby

See systemuser Entity [lk_incidentbase_modifiedby](systemuser.md#BKMK_lk_incidentbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_incidentbase_modifiedonbehalfby"></a> lk_incidentbase_modifiedonbehalfby

See systemuser Entity [lk_incidentbase_modifiedonbehalfby](systemuser.md#BKMK_lk_incidentbase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_system_user_incidents"></a> system_user_incidents

See systemuser Entity [system_user_incidents](systemuser.md#BKMK_system_user_incidents) One-To-Many relationship.

### <a name="BKMK_team_incidents"></a> team_incidents

See team Entity [team_incidents](team.md#BKMK_team_incidents) One-To-Many relationship.

### <a name="BKMK_business_unit_incidents"></a> business_unit_incidents

See businessunit Entity [business_unit_incidents](businessunit.md#BKMK_business_unit_incidents) One-To-Many relationship.

### <a name="BKMK_processstage_incident"></a> processstage_incident

See processstage Entity [processstage_incident](processstage.md#BKMK_processstage_incident) One-To-Many relationship.

### <a name="BKMK_manualsla_cases"></a> manualsla_cases

See sla Entity [manualsla_cases](sla.md#BKMK_manualsla_cases) One-To-Many relationship.

### <a name="BKMK_sla_cases"></a> sla_cases

See sla Entity [sla_cases](sla.md#BKMK_sla_cases) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_incident_createdby"></a> lk_externalparty_incident_createdby

See externalparty Entity [lk_externalparty_incident_createdby](externalparty.md#BKMK_lk_externalparty_incident_createdby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_incident_modifiedby"></a> lk_externalparty_incident_modifiedby

See externalparty Entity [lk_externalparty_incident_modifiedby](externalparty.md#BKMK_lk_externalparty_incident_modifiedby) One-To-Many relationship.

### <a name="BKMK_incident_customer_accounts"></a> incident_customer_accounts

See account Entity [incident_customer_accounts](account.md#BKMK_incident_customer_accounts) One-To-Many relationship.

### <a name="BKMK_contact_as_responsible_contact"></a> contact_as_responsible_contact

See contact Entity [contact_as_responsible_contact](contact.md#BKMK_contact_as_responsible_contact) One-To-Many relationship.

### <a name="BKMK_incident_customer_contacts"></a> incident_customer_contacts

See contact Entity [incident_customer_contacts](contact.md#BKMK_incident_customer_contacts) One-To-Many relationship.

### <a name="BKMK_contact_as_primary_contact"></a> contact_as_primary_contact

See contact Entity [contact_as_primary_contact](contact.md#BKMK_contact_as_primary_contact) One-To-Many relationship.

### <a name="BKMK_contract_cases"></a> contract_cases

See contract Entity [contract_cases](contract.md#BKMK_contract_cases) One-To-Many relationship.

### <a name="BKMK_contract_detail_cases"></a> contract_detail_cases

See contractdetail Entity [contract_detail_cases](contractdetail.md#BKMK_contract_detail_cases) One-To-Many relationship.

### <a name="BKMK_entitlement_cases"></a> entitlement_cases

See entitlement Entity [entitlement_cases](entitlement.md#BKMK_entitlement_cases) One-To-Many relationship.

### <a name="BKMK_incident_existingcase"></a> incident_existingcase

See incident Entity [incident_existingcase](incident.md#BKMK_incident_existingcase) One-To-Many relationship.

### <a name="BKMK_incident_master_incident"></a> incident_master_incident

See incident Entity [incident_master_incident](incident.md#BKMK_incident_master_incident) One-To-Many relationship.

### <a name="BKMK_incident_parent_incident"></a> incident_parent_incident

See incident Entity [incident_parent_incident](incident.md#BKMK_incident_parent_incident) One-To-Many relationship.

### <a name="BKMK_kbarticle_incidents"></a> kbarticle_incidents

See kbarticle Entity [kbarticle_incidents](kbarticle.md#BKMK_kbarticle_incidents) One-To-Many relationship.

### <a name="BKMK_product_incidents"></a> product_incidents

See product Entity [product_incidents](product.md#BKMK_product_incidents) One-To-Many relationship.

### <a name="BKMK_slakpiinstance_incident_firstresponsebykpi"></a> slakpiinstance_incident_firstresponsebykpi

See slakpiinstance Entity [slakpiinstance_incident_firstresponsebykpi](slakpiinstance.md#BKMK_slakpiinstance_incident_firstresponsebykpi) One-To-Many relationship.

### <a name="BKMK_slakpiinstance_incident_resolvebykpi"></a> slakpiinstance_incident_resolvebykpi

See slakpiinstance Entity [slakpiinstance_incident_resolvebykpi](slakpiinstance.md#BKMK_slakpiinstance_incident_resolvebykpi) One-To-Many relationship.

### <a name="BKMK_socialprofile_cases"></a> socialprofile_cases

See socialprofile Entity [socialprofile_cases](socialprofile.md#BKMK_socialprofile_cases) One-To-Many relationship.

### <a name="BKMK_subject_incidents"></a> subject_incidents

See subject Entity [subject_incidents](subject.md#BKMK_subject_incidents) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_Incident"></a> TransactionCurrency_Incident

See transactioncurrency Entity [TransactionCurrency_Incident](transactioncurrency.md#BKMK_TransactionCurrency_Incident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_incident_IncidentType"></a> msdyn_msdyn_incidenttype_incident_IncidentType

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_incident_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_incident_IncidentType) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Incident entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_KnowledgeBaseRecord_Incident"></a> KnowledgeBaseRecord_Incident

See knowledgebaserecord Entity [KnowledgeBaseRecord_Incident](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Incident) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.incident?text=incident EntityType" />