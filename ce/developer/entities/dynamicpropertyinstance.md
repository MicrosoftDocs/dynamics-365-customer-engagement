---
title: "DynamicPropertyInstance Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the DynamicPropertyInstance entity."
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
# DynamicPropertyInstance Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Instance of a property with its value.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/dynamicpropertyinstances<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/dynamicpropertyinstances(*dynamicpropertyinstanceid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/dynamicpropertyinstances(*dynamicpropertyinstanceid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/dynamicpropertyinstances<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrieveProductProperties|<xref href="Microsoft.Dynamics.CRM.RetrieveProductProperties?text=RetrieveProductProperties Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveProductPropertiesRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/dynamicpropertyinstances(*dynamicpropertyinstanceid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateProductProperties|<xref href="Microsoft.Dynamics.CRM.UpdateProductProperties?text=UpdateProductProperties Action" />|<xref:Microsoft.Crm.Sdk.Messages.UpdateProductPropertiesRequest>|

## Entity Properties

**DisplayName**: Property Instance<br />
**DisplayCollectionName**: Property Instances<br />
**SchemaName**: DynamicPropertyInstance<br />
**CollectionSchemaName**: DynamicPropertyInstances<br />
**LogicalName**: dynamicpropertyinstance<br />
**LogicalCollectionName**: dynamicpropertyinstances<br />
**EntitySetName**: dynamicpropertyinstances<br />
**PrimaryIdAttribute**: dynamicpropertyinstanceid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Internal Use Only<br />
**DisplayName**: Internal Use Only<br />
**LogicalName**: dmtimportstate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_DynamicPropertyId"></a> DynamicPropertyId

**Description**: Shows the property that this record is associated with.<br />
**DisplayName**: Property ID<br />
**LogicalName**: dynamicpropertyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: dynamicproperty


### <a name="BKMK_DynamicPropertyInstanceid"></a> DynamicPropertyInstanceid

**Description**: Shows the unique identifier of the property instance.<br />
**DisplayName**: Property Instance ID<br />
**LogicalName**: dynamicpropertyinstanceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_DynamicPropertyInstanceIdType"></a> DynamicPropertyInstanceIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: dynamicpropertyinstanceidtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


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


### <a name="BKMK_Name"></a> Name

**Description**: name<br />
**DisplayName**: name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Shows the object that the property is associated with.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: invoicedetail,opportunityproduct,quotedetail,salesorderdetail


### <a name="BKMK_RegardingObjectIdType"></a> RegardingObjectIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


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
**MinValue**: -1


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Shows the currency associated with the record.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


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
**MinValue**: -1


### <a name="BKMK_validationstatus"></a> validationstatus

**Description**: Shows whether the property value is valid.<br />
**DisplayName**: Is Valid<br />
**LogicalName**: validationstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Valid
- **FalseOption Value**: 0 **Label**: Invalid

**DefaultValue**: False


### <a name="BKMK_ValueDecimal"></a> ValueDecimal

**Description**: Shows the decimal value of the property.<br />
**DisplayName**: Decimal Value<br />
**LogicalName**: valuedecimal<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_ValueDouble"></a> ValueDouble

**Description**: Shows the double value of the property.<br />
**DisplayName**: Double Value<br />
**LogicalName**: valuedouble<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 5


### <a name="BKMK_ValueInteger"></a> ValueInteger

**Description**: Shows the integer value of the property.<br />
**DisplayName**: Integer Value<br />
**LogicalName**: valueinteger<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_ValueString"></a> ValueString

**Description**: Shows the string value of the property.<br />
**DisplayName**: String Value<br />
**LogicalName**: valuestring<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1024

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

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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
**Format**: DateOnly


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the record.<br />
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


### <a name="BKMK_DynamicPropertyIdName"></a> DynamicPropertyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: dynamicpropertyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_DynamicPropertyInstanceIdName"></a> DynamicPropertyInstanceIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: dynamicpropertyinstanceidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


### <a name="BKMK_DynamicPropertyInstanceIdYomiName"></a> DynamicPropertyInstanceIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: dynamicpropertyinstanceidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


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


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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

**Description**: Unique identifier of the delegate user who modified the record.<br />
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


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4000


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

- [dynamicpropertyinstance_SyncErrors](#BKMK_dynamicpropertyinstance_SyncErrors)
- [dynamicpropertyinstance_AsyncOperations](#BKMK_dynamicpropertyinstance_AsyncOperations)
- [dynamicpropertyinstance_MailboxTrackingFolders](#BKMK_dynamicpropertyinstance_MailboxTrackingFolders)
- [dynamicpropertyinstance_UserEntityInstanceDatas](#BKMK_dynamicpropertyinstance_UserEntityInstanceDatas)
- [dynamicpropertyinstance_BulkDeleteFailures](#BKMK_dynamicpropertyinstance_BulkDeleteFailures)
- [dynamicpropertyinstance_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses)


### <a name="BKMK_dynamicpropertyinstance_SyncErrors"></a> dynamicpropertyinstance_SyncErrors

Same as syncerror entity [dynamicpropertyinstance_SyncErrors](syncerror.md#BKMK_dynamicpropertyinstance_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyinstance_SyncErrors<br />
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


### <a name="BKMK_dynamicpropertyinstance_AsyncOperations"></a> dynamicpropertyinstance_AsyncOperations

Same as asyncoperation entity [dynamicpropertyinstance_AsyncOperations](asyncoperation.md#BKMK_dynamicpropertyinstance_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyinstance_AsyncOperations<br />
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


### <a name="BKMK_dynamicpropertyinstance_MailboxTrackingFolders"></a> dynamicpropertyinstance_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [dynamicpropertyinstance_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicpropertyinstance_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyinstance_MailboxTrackingFolders<br />
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


### <a name="BKMK_dynamicpropertyinstance_UserEntityInstanceDatas"></a> dynamicpropertyinstance_UserEntityInstanceDatas

Same as userentityinstancedata entity [dynamicpropertyinstance_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_dynamicpropertyinstance_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyinstance_UserEntityInstanceDatas<br />
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


### <a name="BKMK_dynamicpropertyinstance_BulkDeleteFailures"></a> dynamicpropertyinstance_BulkDeleteFailures

Same as bulkdeletefailure entity [dynamicpropertyinstance_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicpropertyinstance_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyinstance_BulkDeleteFailures<br />
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


### <a name="BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses"></a> dynamicpropertyinstance_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [dynamicpropertyinstance_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicpropertyinstance_PrincipalObjectAttributeAccesses<br />
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

See systemuser Entity [Dynamicpropertyinsatance_createdby](systemuser.md#BKMK_Dynamicpropertyinsatance_createdby) One-To-Many relationship.

### <a name="BKMK_lk_Dynamicpropertyinsatanceattribute_createdonbehalfby"></a> lk_Dynamicpropertyinsatanceattribute_createdonbehalfby

See systemuser Entity [lk_Dynamicpropertyinsatanceattribute_createdonbehalfby](systemuser.md#BKMK_lk_Dynamicpropertyinsatanceattribute_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedBy"></a> lk_Dynamicpropertyinsatanceattribute_ModifiedBy

See systemuser Entity [lk_Dynamicpropertyinsatanceattribute_ModifiedBy](systemuser.md#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedBy) One-To-Many relationship.

### <a name="BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy"></a> lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy

See systemuser Entity [lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy](systemuser.md#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy) One-To-Many relationship.

### <a name="BKMK_team_DynamicPropertyInstance"></a> team_DynamicPropertyInstance

See team Entity [team_DynamicPropertyInstance](team.md#BKMK_team_DynamicPropertyInstance) One-To-Many relationship.

### <a name="BKMK_business_unit_dynamicproperyinstance"></a> business_unit_dynamicproperyinstance

See businessunit Entity [business_unit_dynamicproperyinstance](businessunit.md#BKMK_business_unit_dynamicproperyinstance) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_Dynamicpropertyinsatance"></a> TransactionCurrency_Dynamicpropertyinsatance

See transactioncurrency Entity [TransactionCurrency_Dynamicpropertyinsatance](transactioncurrency.md#BKMK_TransactionCurrency_Dynamicpropertyinsatance) One-To-Many relationship.

### <a name="BKMK_OwningUser_Dynamicpropertyinsatance"></a> OwningUser_Dynamicpropertyinsatance

See systemuser Entity [OwningUser_Dynamicpropertyinsatance](systemuser.md#BKMK_OwningUser_Dynamicpropertyinsatance) One-To-Many relationship.

### <a name="BKMK_DynamicProperty_DynamicPropertyInstance"></a> DynamicProperty_DynamicPropertyInstance

See dynamicproperty Entity [DynamicProperty_DynamicPropertyInstance](dynamicproperty.md#BKMK_DynamicProperty_DynamicPropertyInstance) One-To-Many relationship.

### <a name="BKMK_InvoiceDetail_Dynamicpropertyinstance"></a> InvoiceDetail_Dynamicpropertyinstance

See invoicedetail Entity [InvoiceDetail_Dynamicpropertyinstance](invoicedetail.md#BKMK_InvoiceDetail_Dynamicpropertyinstance) One-To-Many relationship.

### <a name="BKMK_OpportunityProduct_Dynamicpropertyinstance"></a> OpportunityProduct_Dynamicpropertyinstance

See opportunityproduct Entity [OpportunityProduct_Dynamicpropertyinstance](opportunityproduct.md#BKMK_OpportunityProduct_Dynamicpropertyinstance) One-To-Many relationship.

### <a name="BKMK_QuoteDetail_Dynamicpropertyinstance"></a> QuoteDetail_Dynamicpropertyinstance

See quotedetail Entity [QuoteDetail_Dynamicpropertyinstance](quotedetail.md#BKMK_QuoteDetail_Dynamicpropertyinstance) One-To-Many relationship.

### <a name="BKMK_SalesOrderDetail_Dynamicpropertyinstance"></a> SalesOrderDetail_Dynamicpropertyinstance

See salesorderdetail Entity [SalesOrderDetail_Dynamicpropertyinstance](salesorderdetail.md#BKMK_SalesOrderDetail_Dynamicpropertyinstance) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.dynamicpropertyinstance?text=dynamicpropertyinstance EntityType" />