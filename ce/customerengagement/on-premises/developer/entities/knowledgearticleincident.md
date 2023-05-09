---
title: "KnowledgeArticleIncident entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the KnowledgeArticleIncident entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# KnowledgeArticleIncident entity reference

Association between an knowledge article and incident.

**Added by**: Service Solution


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|KnowledgeArticleIncidents|
|DisplayCollectionName|Knowledge Article Incidents|
|DisplayName|Knowledge Article Incident|
|EntitySetName|knowledgearticleincidents|
|IsBPFEntity|False|
|LogicalCollectionName|knowledgearticleincidents|
|LogicalName|knowledgearticleincident|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|knowledgearticleincidentid|
|PrimaryNameAttribute|knowledgearticleidname|
|SchemaName|KnowledgeArticleIncident|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IncidentId](#BKMK_IncidentId)
- [IsSentToCustomer](#BKMK_IsSentToCustomer)
- [KnowledgeArticleId](#BKMK_KnowledgeArticleId)
- [KnowledgeArticleIncidentId](#BKMK_KnowledgeArticleIncidentId)
- [KnowledgeUsage](#BKMK_KnowledgeUsage)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
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


### <a name="BKMK_IncidentId"></a> IncidentId

|Property|Value|
|--------|-----|
|Description|Choose the Incident id for the knowledge article.|
|DisplayName|Incident|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|incidentid|
|RequiredLevel|None|
|Targets|incident|
|Type|Lookup|


### <a name="BKMK_IsSentToCustomer"></a> IsSentToCustomer

|Property|Value|
|--------|-----|
|Description|This should be set to Yes when the user emails the article link to a customer. |
|DisplayName|Sent To Customer|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|issenttocustomer|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### IsSentToCustomer Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_KnowledgeArticleId"></a> KnowledgeArticleId

|Property|Value|
|--------|-----|
|Description|Choose the Knowledge Article.|
|DisplayName|Knowledge Article|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|knowledgearticleid|
|RequiredLevel|None|
|Targets|knowledgearticle|
|Type|Lookup|


### <a name="BKMK_KnowledgeArticleIncidentId"></a> KnowledgeArticleIncidentId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Knowledge Article for the incident.|
|DisplayName|KnowledgeArticle Incident|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|knowledgearticleincidentid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_KnowledgeUsage"></a> KnowledgeUsage

|Property|Value|
|--------|-----|
|Description|Knowledge Usage.|
|DisplayName|Knowledge Usage |
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|knowledgeusage|
|RequiredLevel|None|
|Type|Picklist|

#### KnowledgeUsage Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Reference||
|2|Solution||
|3|Source||



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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Knowledge Article Incident|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Knowledge Article Incident|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Choices/Options

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
- [ExchangeRate](#BKMK_ExchangeRate)
- [IncidentIdName](#BKMK_IncidentIdName)
- [KnowledgeArticleIdName](#BKMK_KnowledgeArticleIdName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
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
|RequiredLevel|SystemRequired|
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


### <a name="BKMK_IncidentIdName"></a> IncidentIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|incidentidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_KnowledgeArticleIdName"></a> KnowledgeArticleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|knowledgearticleidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


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
|RequiredLevel|ApplicationRequired|
|Targets||
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
|RequiredLevel|ApplicationRequired|
|Targets||
|Type|Lookup|


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

- [KnowledgeArticleIncident_SyncErrors](#BKMK_KnowledgeArticleIncident_SyncErrors)
- [knowledgearticleincident_AsyncOperations](#BKMK_knowledgearticleincident_AsyncOperations)
- [knowledgearticleincident_MailboxTrackingFolders](#BKMK_knowledgearticleincident_MailboxTrackingFolders)
- [knowledgearticleincident_ProcessSession](#BKMK_knowledgearticleincident_ProcessSession)
- [knowledgearticleincident_BulkDeleteFailures](#BKMK_knowledgearticleincident_BulkDeleteFailures)
- [knowledgearticleincident_principalobjectattributeaccess](#BKMK_knowledgearticleincident_principalobjectattributeaccess)


### <a name="BKMK_KnowledgeArticleIncident_SyncErrors"></a> KnowledgeArticleIncident_SyncErrors

**Added by**: System Solution Solution

Same as the [KnowledgeArticleIncident_SyncErrors](syncerror.md#BKMK_KnowledgeArticleIncident_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|KnowledgeArticleIncident_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_knowledgearticleincident_AsyncOperations"></a> knowledgearticleincident_AsyncOperations

**Added by**: System Solution Solution

Same as the [knowledgearticleincident_AsyncOperations](asyncoperation.md#BKMK_knowledgearticleincident_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|knowledgearticleincident_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_knowledgearticleincident_MailboxTrackingFolders"></a> knowledgearticleincident_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as the [knowledgearticleincident_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_knowledgearticleincident_MailboxTrackingFolders) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|knowledgearticleincident_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_knowledgearticleincident_ProcessSession"></a> knowledgearticleincident_ProcessSession

**Added by**: System Solution Solution

Same as the [knowledgearticleincident_ProcessSession](processsession.md#BKMK_knowledgearticleincident_ProcessSession) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|knowledgearticleincident_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_knowledgearticleincident_BulkDeleteFailures"></a> knowledgearticleincident_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [knowledgearticleincident_BulkDeleteFailures](bulkdeletefailure.md#BKMK_knowledgearticleincident_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|knowledgearticleincident_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_knowledgearticleincident_principalobjectattributeaccess"></a> knowledgearticleincident_principalobjectattributeaccess

**Added by**: System Solution Solution

Same as the [knowledgearticleincident_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_knowledgearticleincident_principalobjectattributeaccess) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|knowledgearticleincident_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_knowledgearticleincident_createdby](#BKMK_lk_knowledgearticleincident_createdby)
- [lk_knowledgearticleincident_createdonbehalfby](#BKMK_lk_knowledgearticleincident_createdonbehalfby)
- [lk_knowledgearticleincident_modifiedby](#BKMK_lk_knowledgearticleincident_modifiedby)
- [lk_knowledgearticleincident_modifiedonbehalfby](#BKMK_lk_knowledgearticleincident_modifiedonbehalfby)
- [user_knowledgearticleincident](#BKMK_user_knowledgearticleincident)
- [team_knowledgearticleincident](#BKMK_team_knowledgearticleincident)
- [knowledgearticle_incidents](#BKMK_knowledgearticle_incidents)
- [incident_knowledgearticles](#BKMK_incident_knowledgearticles)
- [transactioncurrency_knowledgearticleincident](#BKMK_transactioncurrency_knowledgearticleincident)


### <a name="BKMK_lk_knowledgearticleincident_createdby"></a> lk_knowledgearticleincident_createdby

**Added by**: System Solution Solution

See the [lk_knowledgearticleincident_createdby](systemuser.md#BKMK_lk_knowledgearticleincident_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_knowledgearticleincident_createdonbehalfby"></a> lk_knowledgearticleincident_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_knowledgearticleincident_createdonbehalfby](systemuser.md#BKMK_lk_knowledgearticleincident_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_knowledgearticleincident_modifiedby"></a> lk_knowledgearticleincident_modifiedby

**Added by**: System Solution Solution

See the [lk_knowledgearticleincident_modifiedby](systemuser.md#BKMK_lk_knowledgearticleincident_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_knowledgearticleincident_modifiedonbehalfby"></a> lk_knowledgearticleincident_modifiedonbehalfby

**Added by**: System Solution Solution

See the [lk_knowledgearticleincident_modifiedonbehalfby](systemuser.md#BKMK_lk_knowledgearticleincident_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_user_knowledgearticleincident"></a> user_knowledgearticleincident

**Added by**: System Solution Solution

See the [user_knowledgearticleincident](systemuser.md#BKMK_user_knowledgearticleincident) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_team_knowledgearticleincident"></a> team_knowledgearticleincident

**Added by**: System Solution Solution

See the [team_knowledgearticleincident](team.md#BKMK_team_knowledgearticleincident) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_knowledgearticle_incidents"></a> knowledgearticle_incidents

See the [knowledgearticle_incidents](incident.md#BKMK_knowledgearticle_incidents) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_incident_knowledgearticles"></a> incident_knowledgearticles

**Added by**: System Solution Solution

See the [incident_knowledgearticles](knowledgearticle.md#BKMK_incident_knowledgearticles) one-to-many relationship for the [knowledgearticle](knowledgearticle.md) entity.

### <a name="BKMK_transactioncurrency_knowledgearticleincident"></a> transactioncurrency_knowledgearticleincident

**Added by**: System Solution Solution

See the [transactioncurrency_knowledgearticleincident](transactioncurrency.md#BKMK_transactioncurrency_knowledgearticleincident) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
