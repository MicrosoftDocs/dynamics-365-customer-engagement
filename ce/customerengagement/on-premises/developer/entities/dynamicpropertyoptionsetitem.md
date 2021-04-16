---
title: "DynamicPropertyOptionSetItem Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the DynamicPropertyOptionSetItem entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# DynamicPropertyOptionSetItem Entity Reference

Item with a name and value in a property option set type.

**Added by**: Product Management Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/dynamicpropertyoptionsetitems<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/dynamicpropertyoptionsetitems(*dynamicpropertyoptionsetvalueid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/dynamicpropertyoptionsetitems(*dynamicpropertyoptionsetvalueid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/dynamicpropertyoptionsetitems<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/dynamicpropertyoptionsetitems(*dynamicpropertyoptionsetvalueid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|DynamicPropertyOptionSetItems|
|DisplayCollectionName|Property Option Set Items|
|DisplayName|Property Option Set Item|
|EntitySetName|dynamicpropertyoptionsetitems|
|IsBPFEntity|False|
|LogicalCollectionName|dynamicpropertyoptionsetitems|
|LogicalName|dynamicpropertyoptionsetitem|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|dynamicpropertyoptionsetvalueid|
|PrimaryNameAttribute|dynamicpropertyoptionname|
|SchemaName|DynamicPropertyOptionSetItem|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [DMTImportState](#BKMK_DMTImportState)
- [DynamicPropertyId](#BKMK_DynamicPropertyId)
- [DynamicPropertyIdName](#BKMK_DynamicPropertyIdName)
- [DynamicPropertyOptionDescription](#BKMK_DynamicPropertyOptionDescription)
- [DynamicPropertyOptionName](#BKMK_DynamicPropertyOptionName)
- [DynamicPropertyOptionSetValueId](#BKMK_DynamicPropertyOptionSetValueId)
- [DynamicPropertyOptionSetValueSequenceNumber](#BKMK_DynamicPropertyOptionSetValueSequenceNumber)
- [DynamicPropertyOptionValue](#BKMK_DynamicPropertyOptionValue)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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
|Description|Shows the property that uses this option set item.|
|DisplayName|Property ID|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|dynamicpropertyid|
|RequiredLevel|ApplicationRequired|
|Targets|dynamicproperty|
|Type|Lookup|


### <a name="BKMK_DynamicPropertyIdName"></a> DynamicPropertyIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|dynamicpropertyidname|
|MaxLength|200|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_DynamicPropertyOptionDescription"></a> DynamicPropertyOptionDescription

|Property|Value|
|--------|-----|
|Description|Type additional information about the property option set item.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|dynamicpropertyoptiondescription|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DynamicPropertyOptionName"></a> DynamicPropertyOptionName

|Property|Value|
|--------|-----|
|Description|Type the name of the property option set item.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|dynamicpropertyoptionname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_DynamicPropertyOptionSetValueId"></a> DynamicPropertyOptionSetValueId

|Property|Value|
|--------|-----|
|Description|Shows the unique identifier of the property option set item.|
|DisplayName|Property Option Set ID|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|dynamicpropertyoptionsetvalueid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_DynamicPropertyOptionSetValueSequenceNumber"></a> DynamicPropertyOptionSetValueSequenceNumber

|Property|Value|
|--------|-----|
|Description|Internal Use Only|
|DisplayName|Internal Use Only|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|dynamicpropertyoptionsetvaluesequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_DynamicPropertyOptionValue"></a> DynamicPropertyOptionValue

|Property|Value|
|--------|-----|
|Description|Shows the value of the property option set item.|
|DisplayName|Value|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|dynamicpropertyoptionvalue|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


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
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
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


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
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

- [dynamicpropertyoptionsetitem_SyncErrors](#BKMK_dynamicpropertyoptionsetitem_SyncErrors)
- [dynamicpropertyoptionsetitem_AsyncOperations](#BKMK_dynamicpropertyoptionsetitem_AsyncOperations)
- [dynamicpropertyoptionsetitem_MailboxTrackingFolders](#BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders)
- [dynamicpropertyoptionsetitem_BulkDeleteFailures](#BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures)
- [dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses)
- [DefaultValueOptionSet_DynamicProperty](#BKMK_DefaultValueOptionSet_DynamicProperty)


### <a name="BKMK_dynamicpropertyoptionsetitem_SyncErrors"></a> dynamicpropertyoptionsetitem_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [dynamicpropertyoptionsetitem_SyncErrors](syncerror.md#BKMK_dynamicpropertyoptionsetitem_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyoptionsetitem_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicpropertyoptionsetitem_AsyncOperations"></a> dynamicpropertyoptionsetitem_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [dynamicpropertyoptionsetitem_AsyncOperations](asyncoperation.md#BKMK_dynamicpropertyoptionsetitem_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyoptionsetitem_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders"></a> dynamicpropertyoptionsetitem_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [dynamicpropertyoptionsetitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyoptionsetitem_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures"></a> dynamicpropertyoptionsetitem_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [dynamicpropertyoptionsetitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyoptionsetitem_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses"></a> dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_DefaultValueOptionSet_DynamicProperty"></a> DefaultValueOptionSet_DynamicProperty

Same as dynamicproperty entity [DefaultValueOptionSet_DynamicProperty](dynamicproperty.md#BKMK_DefaultValueOptionSet_DynamicProperty) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicproperty|
|ReferencingAttribute|defaultvalueoptionset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|DefaultValueOptionSet_DynamicProperty|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_DynamicPropertyOptionSetItem_createdby](#BKMK_lk_DynamicPropertyOptionSetItem_createdby)
- [lk_DynamicPropertyOptionSetItem_createdonbehalfby](#BKMK_lk_DynamicPropertyOptionSetItem_createdonbehalfby)
- [lk_DynamicPropertyOptionSetItem_modifiedby](#BKMK_lk_DynamicPropertyOptionSetItem_modifiedby)
- [lk_DynamicPropertyOptionSetItem_modifiedonbehalfby](#BKMK_lk_DynamicPropertyOptionSetItem_modifiedonbehalfby)
- [DynamicPropertyOptionSetItem_organization](#BKMK_DynamicPropertyOptionSetItem_organization)
- [DynamicProperty_DynamicPropertyOptionSetItem](#BKMK_DynamicProperty_DynamicPropertyOptionSetItem)
- [DynamicPropertyOptionSetItem_TransactionCurrency](#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency)


### <a name="BKMK_lk_DynamicPropertyOptionSetItem_createdby"></a> lk_DynamicPropertyOptionSetItem_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_DynamicPropertyOptionSetItem_createdby](systemuser.md#BKMK_lk_DynamicPropertyOptionSetItem_createdby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicPropertyOptionSetItem_createdonbehalfby"></a> lk_DynamicPropertyOptionSetItem_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_DynamicPropertyOptionSetItem_createdonbehalfby](systemuser.md#BKMK_lk_DynamicPropertyOptionSetItem_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicPropertyOptionSetItem_modifiedby"></a> lk_DynamicPropertyOptionSetItem_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_DynamicPropertyOptionSetItem_modifiedby](systemuser.md#BKMK_lk_DynamicPropertyOptionSetItem_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicPropertyOptionSetItem_modifiedonbehalfby"></a> lk_DynamicPropertyOptionSetItem_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_DynamicPropertyOptionSetItem_modifiedonbehalfby](systemuser.md#BKMK_lk_DynamicPropertyOptionSetItem_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_DynamicPropertyOptionSetItem_organization"></a> DynamicPropertyOptionSetItem_organization

**Added by**: System Solution Solution

See organization Entity [DynamicPropertyOptionSetItem_organization](organization.md#BKMK_DynamicPropertyOptionSetItem_organization) One-To-Many relationship.

### <a name="BKMK_DynamicProperty_DynamicPropertyOptionSetItem"></a> DynamicProperty_DynamicPropertyOptionSetItem

See dynamicproperty Entity [DynamicProperty_DynamicPropertyOptionSetItem](dynamicproperty.md#BKMK_DynamicProperty_DynamicPropertyOptionSetItem) One-To-Many relationship.

### <a name="BKMK_DynamicPropertyOptionSetItem_TransactionCurrency"></a> DynamicPropertyOptionSetItem_TransactionCurrency

**Added by**: System Solution Solution

See transactioncurrency Entity [DynamicPropertyOptionSetItem_TransactionCurrency](transactioncurrency.md#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.dynamicpropertyoptionsetitem?text=dynamicpropertyoptionsetitem EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]