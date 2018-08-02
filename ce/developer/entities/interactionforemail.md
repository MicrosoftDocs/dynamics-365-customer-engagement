---
title: "InteractionForEmail Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the InteractionForEmail entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# InteractionForEmail Entity Reference




## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/interactionforemails<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|InteractionForEmails|
|DisplayCollectionName|Interactions for Email|
|DisplayName|Interaction for Email|
|EntitySetName|interactionforemails|
|IsBPFEntity|False|
|LogicalCollectionName|interactionforemails|
|LogicalName|interactionforemail|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|interactionforemailid|
|PrimaryNameAttribute|name|
|SchemaName|InteractionForEmail|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InteractedComponentText](#BKMK_InteractedComponentText)
- [InteractionForEmailId](#BKMK_InteractionForEmailId)
- [InteractionLocation](#BKMK_InteractionLocation)
- [InteractionRepliedBy](#BKMK_InteractionRepliedBy)
- [InteractionReplyId](#BKMK_InteractionReplyId)
- [InteractionUserAgent](#BKMK_InteractionUserAgent)
- [name](#BKMK_name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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


### <a name="BKMK_InteractedComponentText"></a> InteractedComponentText

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Email Interaction Component Related Text|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|interactedcomponenttext|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_InteractionForEmailId"></a> InteractionForEmailId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Interaction for Email|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|interactionforemailid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_InteractionLocation"></a> InteractionLocation

|Property|Value|
|--------|-----|
|Description|Shows the location for an Interaction|
|DisplayName|Location for an Interaction|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|interactionlocation|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_InteractionRepliedBy"></a> InteractionRepliedBy

|Property|Value|
|--------|-----|
|Description|Shows the Name who replied to email if interaction is reply|
|DisplayName|Name who replied to email if interaction is reply|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|interactionrepliedby|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_InteractionReplyId"></a> InteractionReplyId

|Property|Value|
|--------|-----|
|Description|InteractionReplyId|
|DisplayName|InteractionReplyId|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|interactionreplyid|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_InteractionUserAgent"></a> InteractionUserAgent

|Property|Value|
|--------|-----|
|Description|Shows the User Agent for an Interaction if available|
|DisplayName|User Agent for an Interaction|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|interactionuseragent|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_name"></a> name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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
|Description|Unique identifier of the user or team who owns the record.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Interaction for Email|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Interaction for Email|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the InteractionForEmail with respect to the base currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [EmailActivityId](#BKMK_EmailActivityId)
- [EmailInteractionReplyId](#BKMK_EmailInteractionReplyId)
- [EmailInteractionTime](#BKMK_EmailInteractionTime)
- [ExchangeRate](#BKMK_ExchangeRate)
- [InteractionType](#BKMK_InteractionType)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


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
|RequiredLevel|SystemRequired|
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
|Description|Unique identifier of the delegate user who created the record.|
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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_EmailActivityId"></a> EmailActivityId

|Property|Value|
|--------|-----|
|Description|Email Activity Id.|
|DisplayName|Email Activity Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailactivityid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_EmailInteractionReplyId"></a> EmailInteractionReplyId

|Property|Value|
|--------|-----|
|Description|Email Activity Id.|
|DisplayName|Email Activity Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailinteractionreplyid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_EmailInteractionTime"></a> EmailInteractionTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the Interaction date and time of the an email.|
|DisplayName|Interaction date and time of the an email|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailinteractiontime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the InteractionForEmail with respect to the base currency.|
|DisplayName|ExchangeRate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_InteractionType"></a> InteractionType

|Property|Value|
|--------|-----|
|Description|Shows the type of Interaction.|
|DisplayName|Interaction Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|interactiontype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### InteractionType Options

|Value|Label|
|-----|-----|
|0|EmailOpen|
|1|LinkOpen|
|2|AttachmentOpen|
|3|EmailReply|



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


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
|RequiredLevel|SystemRequired|
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
|Description|Unique identifier of the delegate user who modified the record.|
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
|RequiredLevel|SystemRequired|
|Type|String|


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
|Description||
|DisplayName||
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

- [interactionforemail_BulkOperations](#BKMK_interactionforemail_BulkOperations)
- [interactionforemail_CampaignActivities](#BKMK_interactionforemail_CampaignActivities)
- [interactionforemail_CampaignResponses](#BKMK_interactionforemail_CampaignResponses)
- [interactionforemail_IncidentResolutions](#BKMK_interactionforemail_IncidentResolutions)
- [interactionforemail_ServiceAppointments](#BKMK_interactionforemail_ServiceAppointments)
- [interactionforemail_OpportunityCloses](#BKMK_interactionforemail_OpportunityCloses)
- [interactionforemail_OrderCloses](#BKMK_interactionforemail_OrderCloses)
- [interactionforemail_QuoteCloses](#BKMK_interactionforemail_QuoteCloses)
- [interactionforemail_msdyn_bookingalerts](#BKMK_interactionforemail_msdyn_bookingalerts)
- [interactionforemail_msdyn_approvals](#BKMK_interactionforemail_msdyn_approvals)
- [interactionforemail_ActivityPointers](#BKMK_interactionforemail_ActivityPointers)
- [interactionforemail_AsyncOperations](#BKMK_interactionforemail_AsyncOperations)


### <a name="BKMK_interactionforemail_BulkOperations"></a> interactionforemail_BulkOperations

Same as bulkoperation entity [interactionforemail_BulkOperations](bulkoperation.md#BKMK_interactionforemail_BulkOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_BulkOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_CampaignActivities"></a> interactionforemail_CampaignActivities

Same as campaignactivity entity [interactionforemail_CampaignActivities](campaignactivity.md#BKMK_interactionforemail_CampaignActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_CampaignActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_CampaignResponses"></a> interactionforemail_CampaignResponses

Same as campaignresponse entity [interactionforemail_CampaignResponses](campaignresponse.md#BKMK_interactionforemail_CampaignResponses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_CampaignResponses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_IncidentResolutions"></a> interactionforemail_IncidentResolutions

Same as incidentresolution entity [interactionforemail_IncidentResolutions](incidentresolution.md#BKMK_interactionforemail_IncidentResolutions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_IncidentResolutions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_ServiceAppointments"></a> interactionforemail_ServiceAppointments

Same as serviceappointment entity [interactionforemail_ServiceAppointments](serviceappointment.md#BKMK_interactionforemail_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_OpportunityCloses"></a> interactionforemail_OpportunityCloses

Same as opportunityclose entity [interactionforemail_OpportunityCloses](opportunityclose.md#BKMK_interactionforemail_OpportunityCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_OrderCloses"></a> interactionforemail_OrderCloses

Same as orderclose entity [interactionforemail_OrderCloses](orderclose.md#BKMK_interactionforemail_OrderCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_QuoteCloses"></a> interactionforemail_QuoteCloses

Same as quoteclose entity [interactionforemail_QuoteCloses](quoteclose.md#BKMK_interactionforemail_QuoteCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_msdyn_bookingalerts"></a> interactionforemail_msdyn_bookingalerts

Same as msdyn_bookingalert entity [interactionforemail_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_interactionforemail_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_msdyn_approvals"></a> interactionforemail_msdyn_approvals

Same as msdyn_approval entity [interactionforemail_msdyn_approvals](msdyn_approval.md#BKMK_interactionforemail_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|interactionforemail_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_interactionforemail_ActivityPointers"></a> interactionforemail_ActivityPointers

Same as activitypointer entity [interactionforemail_ActivityPointers](activitypointer.md#BKMK_interactionforemail_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|new_interactionforemail_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_interactionforemail_AsyncOperations"></a> interactionforemail_AsyncOperations

Same as asyncoperation entity [interactionforemail_AsyncOperations](asyncoperation.md#BKMK_interactionforemail_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|new_interactionforemail_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_interactionforemail_createdby](#BKMK_lk_interactionforemail_createdby)
- [lk_interactionforemail_createdonbehalfby](#BKMK_lk_interactionforemail_createdonbehalfby)
- [lk_interactionforemail_modifiedby](#BKMK_lk_interactionforemail_modifiedby)
- [lk_interactionforemail_modifiedonbehalfby](#BKMK_lk_interactionforemail_modifiedonbehalfby)
- [user_interactionforemail](#BKMK_user_interactionforemail)
- [team_interactionforemail](#BKMK_team_interactionforemail)
- [business_unit_interactionforemail](#BKMK_business_unit_interactionforemail)
- [TransactionCurrency_InteractionForEmail](#BKMK_TransactionCurrency_InteractionForEmail)


### <a name="BKMK_lk_interactionforemail_createdby"></a> lk_interactionforemail_createdby

See systemuser Entity [lk_interactionforemail_createdby](systemuser.md#BKMK_lk_interactionforemail_createdby) One-To-Many relationship.

### <a name="BKMK_lk_interactionforemail_createdonbehalfby"></a> lk_interactionforemail_createdonbehalfby

See systemuser Entity [lk_interactionforemail_createdonbehalfby](systemuser.md#BKMK_lk_interactionforemail_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_interactionforemail_modifiedby"></a> lk_interactionforemail_modifiedby

See systemuser Entity [lk_interactionforemail_modifiedby](systemuser.md#BKMK_lk_interactionforemail_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_interactionforemail_modifiedonbehalfby"></a> lk_interactionforemail_modifiedonbehalfby

See systemuser Entity [lk_interactionforemail_modifiedonbehalfby](systemuser.md#BKMK_lk_interactionforemail_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_interactionforemail"></a> user_interactionforemail

See systemuser Entity [user_interactionforemail](systemuser.md#BKMK_user_interactionforemail) One-To-Many relationship.

### <a name="BKMK_team_interactionforemail"></a> team_interactionforemail

See team Entity [team_interactionforemail](team.md#BKMK_team_interactionforemail) One-To-Many relationship.

### <a name="BKMK_business_unit_interactionforemail"></a> business_unit_interactionforemail

See businessunit Entity [business_unit_interactionforemail](businessunit.md#BKMK_business_unit_interactionforemail) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_InteractionForEmail"></a> TransactionCurrency_InteractionForEmail

See transactioncurrency Entity [TransactionCurrency_InteractionForEmail](transactioncurrency.md#BKMK_TransactionCurrency_InteractionForEmail) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.interactionforemail?text=interactionforemail EntityType" />