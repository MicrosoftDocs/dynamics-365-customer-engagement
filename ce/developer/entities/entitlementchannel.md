---
title: "EntitlementChannel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the EntitlementChannel entity."
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
# EntitlementChannel Entity Reference

Defines the amount and type of support for a channel.

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/entitlementchannels<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/entitlementchannels(*entitlementchannelid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/entitlementchannels(*entitlementchannelid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/entitlementchannels<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/entitlementchannels(*entitlementchannelid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|EntitlementChannels|
|DisplayCollectionName|Entitlement Channels|
|DisplayName|Entitlement Channel|
|EntitySetName|entitlementchannels|
|IsBPFEntity|False|
|LogicalCollectionName|entitlementchannels|
|LogicalName|entitlementchannel|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|entitlementchannelid|
|PrimaryNameAttribute|name|
|SchemaName|EntitlementChannel|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Channel](#BKMK_Channel)
- [EntitlementChannelId](#BKMK_EntitlementChannelId)
- [EntitlementId](#BKMK_EntitlementId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [RemainingTerms](#BKMK_RemainingTerms)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalTerms](#BKMK_TotalTerms)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_Channel"></a> Channel

|Property|Value|
|--------|-----|
|Description|Select a channel for which you are defining the entitlement terms.|
|DisplayName|Name|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|channel|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### Channel Options

|Value|Label|
|-----|-----|
|1|Phone|
|2|Email|
|3|Web|
|2483|Facebook|
|3986|Twitter|



### <a name="BKMK_EntitlementChannelId"></a> EntitlementChannelId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Entitlement Channel|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|entitlementchannelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_EntitlementId"></a> EntitlementId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Entitlement associated with Entitlement Channel.|
|DisplayName|Entitlement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|entitlementid|
|RequiredLevel|ApplicationRequired|
|Targets|entitlement|
|Type|Lookup|


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


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Entitlement Channel Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|None|
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
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|ownerid|
|RequiredLevel|None|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_RemainingTerms"></a> RemainingTerms

|Property|Value|
|--------|-----|
|Description|Type the total number of entitlement terms that are left.|
|DisplayName|Remaining Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|remainingterms|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


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


### <a name="BKMK_TotalTerms"></a> TotalTerms

|Property|Value|
|--------|-----|
|Description|Type the total number of entitlement terms.|
|DisplayName|Total Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalterms|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the incident.|
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
- [EntitlementIdName](#BKMK_EntitlementIdName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateOnly|
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
|RequiredLevel|None|
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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the incident with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateOnly|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization with which the entitlement channel is associated.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
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
|RequiredLevel|ApplicationRequired|
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

- [entitlementchannel_SyncErrors](#BKMK_entitlementchannel_SyncErrors)
- [entitlementchannel_AsyncOperations](#BKMK_entitlementchannel_AsyncOperations)
- [entitlementchannel_MailboxTrackingFolders](#BKMK_entitlementchannel_MailboxTrackingFolders)
- [entitlementchannel_UserEntityInstanceDatas](#BKMK_entitlementchannel_UserEntityInstanceDatas)
- [entitlementchannel_BulkDeleteFailures](#BKMK_entitlementchannel_BulkDeleteFailures)
- [entitlementchannel_PrincipalObjectAttributeAccesses](#BKMK_entitlementchannel_PrincipalObjectAttributeAccesses)
- [entitlementchannel_connections1](#BKMK_entitlementchannel_connections1)
- [entitlementchannel_connections2](#BKMK_entitlementchannel_connections2)
- [entitlementchannel_Annotations](#BKMK_entitlementchannel_Annotations)
- [entitlementchannel_ProcessSession](#BKMK_entitlementchannel_ProcessSession)
- [entitlementchannel_DuplicateBaseRecord](#BKMK_entitlementchannel_DuplicateBaseRecord)
- [entitlementchannel_DuplicateMatchingRecord](#BKMK_entitlementchannel_DuplicateMatchingRecord)


### <a name="BKMK_entitlementchannel_SyncErrors"></a> entitlementchannel_SyncErrors

Same as syncerror entity [entitlementchannel_SyncErrors](syncerror.md#BKMK_entitlementchannel_SyncErrors) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementchannel_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementchannel_AsyncOperations"></a> entitlementchannel_AsyncOperations

Same as asyncoperation entity [entitlementchannel_AsyncOperations](asyncoperation.md#BKMK_entitlementchannel_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementchannel_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementchannel_MailboxTrackingFolders"></a> entitlementchannel_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [entitlementchannel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_entitlementchannel_MailboxTrackingFolders) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementchannel_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementchannel_UserEntityInstanceDatas"></a> entitlementchannel_UserEntityInstanceDatas

Same as userentityinstancedata entity [entitlementchannel_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_entitlementchannel_UserEntityInstanceDatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementchannel_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementchannel_BulkDeleteFailures"></a> entitlementchannel_BulkDeleteFailures

Same as bulkdeletefailure entity [entitlementchannel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_entitlementchannel_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementchannel_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementchannel_PrincipalObjectAttributeAccesses"></a> entitlementchannel_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [entitlementchannel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_entitlementchannel_PrincipalObjectAttributeAccesses) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementchannel_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementchannel_connections1"></a> entitlementchannel_connections1

Same as connection entity [entitlementchannel_connections1](connection.md#BKMK_entitlementchannel_connections1) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementchannel_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementchannel_connections2"></a> entitlementchannel_connections2

Same as connection entity [entitlementchannel_connections2](connection.md#BKMK_entitlementchannel_connections2) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementchannel_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementchannel_Annotations"></a> entitlementchannel_Annotations

Same as annotation entity [entitlementchannel_Annotations](annotation.md#BKMK_entitlementchannel_Annotations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementchannel_Annotations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementchannel_ProcessSession"></a> entitlementchannel_ProcessSession

Same as processsession entity [entitlementchannel_ProcessSession](processsession.md#BKMK_entitlementchannel_ProcessSession) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementchannel_ProcessSession|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementchannel_DuplicateBaseRecord"></a> entitlementchannel_DuplicateBaseRecord

Same as duplicaterecord entity [entitlementchannel_DuplicateBaseRecord](duplicaterecord.md#BKMK_entitlementchannel_DuplicateBaseRecord) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementchannel_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementchannel_DuplicateMatchingRecord"></a> entitlementchannel_DuplicateMatchingRecord

Same as duplicaterecord entity [entitlementchannel_DuplicateMatchingRecord](duplicaterecord.md#BKMK_entitlementchannel_DuplicateMatchingRecord) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementchannel_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_entitlementchannel_createdby](#BKMK_lk_entitlementchannel_createdby)
- [lk_entitlementchannel_createdonbehalfby](#BKMK_lk_entitlementchannel_createdonbehalfby)
- [lk_entitlementchannel_modifiedby](#BKMK_lk_entitlementchannel_modifiedby)
- [lk_entitlementchannel_modifiedonbehalfby](#BKMK_lk_entitlementchannel_modifiedonbehalfby)
- [user_entitlementchannel](#BKMK_user_entitlementchannel)
- [team_entitlementchannel](#BKMK_team_entitlementchannel)
- [entitlement_entitlementchannel_EntitlementId](#BKMK_entitlement_entitlementchannel_EntitlementId)
- [entitlementchannel_organization](#BKMK_entitlementchannel_organization)
- [TransactionCurrency_entitlementchannel](#BKMK_TransactionCurrency_entitlementchannel)


### <a name="BKMK_lk_entitlementchannel_createdby"></a> lk_entitlementchannel_createdby

See systemuser Entity [lk_entitlementchannel_createdby](systemuser.md#BKMK_lk_entitlementchannel_createdby) One-To-Many relationship.

### <a name="BKMK_lk_entitlementchannel_createdonbehalfby"></a> lk_entitlementchannel_createdonbehalfby

See systemuser Entity [lk_entitlementchannel_createdonbehalfby](systemuser.md#BKMK_lk_entitlementchannel_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_entitlementchannel_modifiedby"></a> lk_entitlementchannel_modifiedby

See systemuser Entity [lk_entitlementchannel_modifiedby](systemuser.md#BKMK_lk_entitlementchannel_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_entitlementchannel_modifiedonbehalfby"></a> lk_entitlementchannel_modifiedonbehalfby

See systemuser Entity [lk_entitlementchannel_modifiedonbehalfby](systemuser.md#BKMK_lk_entitlementchannel_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_entitlementchannel"></a> user_entitlementchannel

See systemuser Entity [user_entitlementchannel](systemuser.md#BKMK_user_entitlementchannel) One-To-Many relationship.

### <a name="BKMK_team_entitlementchannel"></a> team_entitlementchannel

See team Entity [team_entitlementchannel](team.md#BKMK_team_entitlementchannel) One-To-Many relationship.

### <a name="BKMK_entitlement_entitlementchannel_EntitlementId"></a> entitlement_entitlementchannel_EntitlementId

See entitlement Entity [entitlement_entitlementchannel_EntitlementId](entitlement.md#BKMK_entitlement_entitlementchannel_EntitlementId) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_organization"></a> entitlementchannel_organization

See organization Entity [entitlementchannel_organization](organization.md#BKMK_entitlementchannel_organization) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_entitlementchannel"></a> TransactionCurrency_entitlementchannel

See transactioncurrency Entity [TransactionCurrency_entitlementchannel](transactioncurrency.md#BKMK_TransactionCurrency_entitlementchannel) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.entitlementchannel?text=entitlementchannel EntityType" />