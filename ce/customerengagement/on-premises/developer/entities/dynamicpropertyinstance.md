---
title: "Property Instance (DynamicPropertyInstance)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Property Instance (DynamicPropertyInstance)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Property Instance (DynamicPropertyInstance)  entity reference

Instance of a property with its value.

**Added by**: Product Management Solution


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrieveProductProperties|<xref:Microsoft.Crm.Sdk.Messages.RetrieveProductPropertiesRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateProductProperties|<xref:Microsoft.Crm.Sdk.Messages.UpdateProductPropertiesRequest>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|DynamicPropertyInstances|
|DisplayCollectionName|Property Instances|
|DisplayName|Property Instance|
|EntitySetName|dynamicpropertyinstances|
|IsBPFEntity|False|
|LogicalCollectionName|dynamicpropertyinstances|
|LogicalName|dynamicpropertyinstance|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|dynamicpropertyinstanceid|
|PrimaryNameAttribute|name|
|SchemaName|DynamicPropertyInstance|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [DMTImportState](#BKMK_DMTImportState)
- [DynamicPropertyId](#BKMK_DynamicPropertyId)
- [DynamicPropertyInstanceid](#BKMK_DynamicPropertyInstanceid)
- [DynamicPropertyInstanceIdType](#BKMK_DynamicPropertyInstanceIdType)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdType](#BKMK_RegardingObjectIdType)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [validationstatus](#BKMK_validationstatus)
- [ValueDecimal](#BKMK_ValueDecimal)
- [ValueDouble](#BKMK_ValueDouble)
- [ValueInteger](#BKMK_ValueInteger)
- [ValueString](#BKMK_ValueString)


### <a name="BKMK_DMTImportState"></a> DMTImportState

|Property|Value|
|--------|-----|
|Description|Internal Use Only|
|DisplayName|Internal Use Only|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|dmtimportstate|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_DynamicPropertyId"></a> DynamicPropertyId

|Property|Value|
|--------|-----|
|Description|Shows the property that this record is associated with.|
|DisplayName|Property ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dynamicpropertyid|
|RequiredLevel|SystemRequired|
|Targets|dynamicproperty|
|Type|Lookup|


### <a name="BKMK_DynamicPropertyInstanceid"></a> DynamicPropertyInstanceid

|Property|Value|
|--------|-----|
|Description|Shows the unique identifier of the property instance.|
|DisplayName|Property Instance ID|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|dynamicpropertyinstanceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_DynamicPropertyInstanceIdType"></a> DynamicPropertyInstanceIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dynamicpropertyinstanceidtype|
|RequiredLevel|None|
|Type|EntityName|


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
|Description|name|
|DisplayName|name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
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
|IsValidForUpdate|False|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description|Shows the object that the property is associated with.|
|DisplayName|Regarding|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|invoicedetail,opportunityproduct,quotedetail,salesorderdetail|
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdType"></a> RegardingObjectIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidtype|
|RequiredLevel|None|
|Type|EntityName|


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
|Description|Shows the currency associated with the record.|
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


### <a name="BKMK_validationstatus"></a> validationstatus

|Property|Value|
|--------|-----|
|Description|Shows whether the property value is valid.|
|DisplayName|Is Valid|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|validationstatus|
|RequiredLevel|None|
|Type|Boolean|

#### validationstatus Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Valid||
|0|Invalid||

**DefaultValue**: 0



### <a name="BKMK_ValueDecimal"></a> ValueDecimal

|Property|Value|
|--------|-----|
|Description|Shows the decimal value of the property.|
|DisplayName|Decimal Value|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|valuedecimal|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ValueDouble"></a> ValueDouble

|Property|Value|
|--------|-----|
|Description|Shows the double value of the property.|
|DisplayName|Double Value|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|valuedouble|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_ValueInteger"></a> ValueInteger

|Property|Value|
|--------|-----|
|Description|Shows the integer value of the property.|
|DisplayName|Integer Value|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|valueinteger|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ValueString"></a> ValueString

|Property|Value|
|--------|-----|
|Description|Shows the string value of the property.|
|DisplayName|String Value|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|valuestring|
|MaxLength|1024|
|RequiredLevel|None|
|Type|String|

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
- [DynamicPropertyIdName](#BKMK_DynamicPropertyIdName)
- [DynamicPropertyInstanceIdName](#BKMK_DynamicPropertyInstanceIdName)
- [DynamicPropertyInstanceIdYomiName](#BKMK_DynamicPropertyInstanceIdYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
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
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DynamicPropertyIdName"></a> DynamicPropertyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dynamicpropertyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DynamicPropertyInstanceIdName"></a> DynamicPropertyInstanceIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dynamicpropertyinstanceidname|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DynamicPropertyInstanceIdYomiName"></a> DynamicPropertyInstanceIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dynamicpropertyinstanceidyominame|
|MaxLength|4000|
|RequiredLevel|None|
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
|RequiredLevel|None|
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
|Targets||
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

**Added by**: Sales Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidyominame|
|MaxLength|4000|
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

- [dynamicpropertyinstance_SyncErrors](#BKMK_dynamicpropertyinstance_SyncErrors)
- [dynamicpropertyinstance_AsyncOperations](#BKMK_dynamicpropertyinstance_AsyncOperations)
- [dynamicpropertyinstance_MailboxTrackingFolders](#BKMK_dynamicpropertyinstance_MailboxTrackingFolders)
- [dynamicpropertyinstance_BulkDeleteFailures](#BKMK_dynamicpropertyinstance_BulkDeleteFailures)
- [dynamicpropertyinstance_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses)


### <a name="BKMK_dynamicpropertyinstance_SyncErrors"></a> dynamicpropertyinstance_SyncErrors

**Added by**: System Solution Solution

Same as the [dynamicpropertyinstance_SyncErrors](syncerror.md#BKMK_dynamicpropertyinstance_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyinstance_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicpropertyinstance_AsyncOperations"></a> dynamicpropertyinstance_AsyncOperations

**Added by**: System Solution Solution

Same as the [dynamicpropertyinstance_AsyncOperations](asyncoperation.md#BKMK_dynamicpropertyinstance_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyinstance_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicpropertyinstance_MailboxTrackingFolders"></a> dynamicpropertyinstance_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as the [dynamicpropertyinstance_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicpropertyinstance_MailboxTrackingFolders) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyinstance_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicpropertyinstance_BulkDeleteFailures"></a> dynamicpropertyinstance_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [dynamicpropertyinstance_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicpropertyinstance_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyinstance_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses"></a> dynamicpropertyinstance_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as the [dynamicpropertyinstance_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyinstance_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Dynamicpropertyinsatance_createdby](#BKMK_Dynamicpropertyinsatance_createdby)
- [lk_Dynamicpropertyinsatanceattribute_createdonbehalfby](#BKMK_lk_Dynamicpropertyinsatanceattribute_createdonbehalfby)
- [lk_Dynamicpropertyinsatanceattribute_ModifiedBy](#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedBy)
- [lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy](#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy)
- [team_DynamicPropertyInstance](#BKMK_team_DynamicPropertyInstance)
- [business_unit_dynamicproperyinstance](#BKMK_business_unit_dynamicproperyinstance)
- [TransactionCurrency_Dynamicpropertyinsatance](#BKMK_TransactionCurrency_Dynamicpropertyinsatance)
- [OwningUser_Dynamicpropertyinsatance](#BKMK_OwningUser_Dynamicpropertyinsatance)
- [DynamicProperty_DynamicPropertyInstance](#BKMK_DynamicProperty_DynamicPropertyInstance)
- [InvoiceDetail_Dynamicpropertyinstance](#BKMK_InvoiceDetail_Dynamicpropertyinstance)
- [OpportunityProduct_Dynamicpropertyinstance](#BKMK_OpportunityProduct_Dynamicpropertyinstance)
- [QuoteDetail_Dynamicpropertyinstance](#BKMK_QuoteDetail_Dynamicpropertyinstance)
- [SalesOrderDetail_Dynamicpropertyinstance](#BKMK_SalesOrderDetail_Dynamicpropertyinstance)


### <a name="BKMK_Dynamicpropertyinsatance_createdby"></a> Dynamicpropertyinsatance_createdby

**Added by**: System Solution Solution

See the [Dynamicpropertyinsatance_createdby](systemuser.md#BKMK_Dynamicpropertyinsatance_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_Dynamicpropertyinsatanceattribute_createdonbehalfby"></a> lk_Dynamicpropertyinsatanceattribute_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_Dynamicpropertyinsatanceattribute_createdonbehalfby](systemuser.md#BKMK_lk_Dynamicpropertyinsatanceattribute_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedBy"></a> lk_Dynamicpropertyinsatanceattribute_ModifiedBy

**Added by**: System Solution Solution

See the [lk_Dynamicpropertyinsatanceattribute_ModifiedBy](systemuser.md#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedBy) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy"></a> lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy

**Added by**: System Solution Solution

See the [lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy](systemuser.md#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_team_DynamicPropertyInstance"></a> team_DynamicPropertyInstance

**Added by**: System Solution Solution

See the [team_DynamicPropertyInstance](team.md#BKMK_team_DynamicPropertyInstance) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_business_unit_dynamicproperyinstance"></a> business_unit_dynamicproperyinstance

**Added by**: System Solution Solution

See the [business_unit_dynamicproperyinstance](businessunit.md#BKMK_business_unit_dynamicproperyinstance) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_TransactionCurrency_Dynamicpropertyinsatance"></a> TransactionCurrency_Dynamicpropertyinsatance

**Added by**: System Solution Solution

See the [TransactionCurrency_Dynamicpropertyinsatance](transactioncurrency.md#BKMK_TransactionCurrency_Dynamicpropertyinsatance) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### <a name="BKMK_OwningUser_Dynamicpropertyinsatance"></a> OwningUser_Dynamicpropertyinsatance

**Added by**: System Solution Solution

See the [OwningUser_Dynamicpropertyinsatance](systemuser.md#BKMK_OwningUser_Dynamicpropertyinsatance) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_DynamicProperty_DynamicPropertyInstance"></a> DynamicProperty_DynamicPropertyInstance

See the [DynamicProperty_DynamicPropertyInstance](dynamicproperty.md#BKMK_DynamicProperty_DynamicPropertyInstance) one-to-many relationship for the [dynamicproperty](dynamicproperty.md) entity.

### <a name="BKMK_InvoiceDetail_Dynamicpropertyinstance"></a> InvoiceDetail_Dynamicpropertyinstance

**Added by**: Sales Solution

See the [InvoiceDetail_Dynamicpropertyinstance](invoicedetail.md#BKMK_InvoiceDetail_Dynamicpropertyinstance) one-to-many relationship for the [invoicedetail](invoicedetail.md) entity.

### <a name="BKMK_OpportunityProduct_Dynamicpropertyinstance"></a> OpportunityProduct_Dynamicpropertyinstance

**Added by**: Sales Solution

See the [OpportunityProduct_Dynamicpropertyinstance](opportunityproduct.md#BKMK_OpportunityProduct_Dynamicpropertyinstance) one-to-many relationship for the [opportunityproduct](opportunityproduct.md) entity.

### <a name="BKMK_QuoteDetail_Dynamicpropertyinstance"></a> QuoteDetail_Dynamicpropertyinstance

**Added by**: Sales Solution

See the [QuoteDetail_Dynamicpropertyinstance](quotedetail.md#BKMK_QuoteDetail_Dynamicpropertyinstance) one-to-many relationship for the [quotedetail](quotedetail.md) entity.

### <a name="BKMK_SalesOrderDetail_Dynamicpropertyinstance"></a> SalesOrderDetail_Dynamicpropertyinstance

**Added by**: Sales Solution

See the [SalesOrderDetail_Dynamicpropertyinstance](salesorderdetail.md#BKMK_SalesOrderDetail_Dynamicpropertyinstance) one-to-many relationship for the [salesorderdetail](salesorderdetail.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
