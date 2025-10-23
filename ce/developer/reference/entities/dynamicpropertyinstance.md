---
title: "Property Instance (DynamicPropertyInstance) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Property Instance (DynamicPropertyInstance) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Property Instance (DynamicPropertyInstance) table/entity reference (Microsoft Dynamics 365)

Instance of a property with its value.

## Messages

The following table lists the messages for the Property Instance (DynamicPropertyInstance) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: False |`POST` /dynamicpropertyinstances<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: False |`DELETE` /dynamicpropertyinstances(*dynamicpropertyinstanceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: False |`GET` /dynamicpropertyinstances(*dynamicpropertyinstanceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /dynamicpropertyinstances<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrieveProductProperties`<br />Event: False |**RetrieveProductProperties function** |<xref:Microsoft.Crm.Sdk.Messages.RetrieveProductPropertiesRequest>|
| `Update`<br />Event: False |`PATCH` /dynamicpropertyinstances(*dynamicpropertyinstanceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `UpdateProductProperties`<br />Event: False |**UpdateProductProperties action** |<xref:Microsoft.Crm.Sdk.Messages.UpdateProductPropertiesRequest>|
| `Upsert`<br />Event: False |`PATCH` /dynamicpropertyinstances(*dynamicpropertyinstanceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Property Instance (DynamicPropertyInstance) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Property Instance** |
| **DisplayCollectionName** | **Property Instances** |
| **SchemaName** | `DynamicPropertyInstance` |
| **CollectionSchemaName** | `DynamicPropertyInstances` |
| **EntitySetName** | `dynamicpropertyinstances`|
| **LogicalName** | `dynamicpropertyinstance` |
| **LogicalCollectionName** | `dynamicpropertyinstances` |
| **PrimaryIdAttribute** | `dynamicpropertyinstanceid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [DMTImportState](#BKMK_DMTImportState)
- [DynamicPropertyId](#BKMK_DynamicPropertyId)
- [DynamicPropertyInstanceid](#BKMK_DynamicPropertyInstanceid)
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
|---|---|
|Description|**Internal Use Only**|
|DisplayName|**Internal Use Only**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`dmtimportstate`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_DynamicPropertyId"></a> DynamicPropertyId

|Property|Value|
|---|---|
|Description|**Shows the property that this record is associated with.**|
|DisplayName|**Property ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|dynamicproperty|

### <a name="BKMK_DynamicPropertyInstanceid"></a> DynamicPropertyInstanceid

|Property|Value|
|---|---|
|Description|**Shows the unique identifier of the property instance.**|
|DisplayName|**Property Instance ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyinstanceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**name**|
|DisplayName|**name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|IsValidForForm|False|
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

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|---|---|
|Description|**Shows the object that the property is associated with.**|
|DisplayName|**Regarding**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|invoicedetail, opportunityproduct, quotedetail, salesorderdetail|

### <a name="BKMK_RegardingObjectIdType"></a> RegardingObjectIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjectidtype`|
|RequiredLevel|None|
|Type|EntityName|

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Shows the currency associated with the record.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

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

### <a name="BKMK_validationstatus"></a> validationstatus

|Property|Value|
|---|---|
|Description|**Shows whether the property value is valid.**|
|DisplayName|**Is Valid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`validationstatus`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`dynamicpropertyinstance_isvalid`|
|DefaultValue|False|
|True Label|Valid|
|False Label|Invalid|

### <a name="BKMK_ValueDecimal"></a> ValueDecimal

|Property|Value|
|---|---|
|Description|**Shows the decimal value of the property.**|
|DisplayName|**Decimal Value**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`valuedecimal`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_ValueDouble"></a> ValueDouble

|Property|Value|
|---|---|
|Description|**Shows the double value of the property.**|
|DisplayName|**Double Value**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`valuedouble`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|

### <a name="BKMK_ValueInteger"></a> ValueInteger

|Property|Value|
|---|---|
|Description|**Shows the integer value of the property.**|
|DisplayName|**Integer Value**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`valueinteger`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_ValueString"></a> ValueString

|Property|Value|
|---|---|
|Description|**Shows the string value of the property.**|
|DisplayName|**String Value**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`valuestring`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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
|Targets||

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

- [business_unit_dynamicproperyinstance](#BKMK_business_unit_dynamicproperyinstance)
- [DynamicProperty_DynamicPropertyInstance](#BKMK_DynamicProperty_DynamicPropertyInstance)
- [Dynamicpropertyinsatance_createdby](#BKMK_Dynamicpropertyinsatance_createdby)
- [InvoiceDetail_Dynamicpropertyinstance](#BKMK_InvoiceDetail_Dynamicpropertyinstance)
- [lk_Dynamicpropertyinsatanceattribute_createdonbehalfby](#BKMK_lk_Dynamicpropertyinsatanceattribute_createdonbehalfby)
- [lk_Dynamicpropertyinsatanceattribute_ModifiedBy](#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedBy)
- [lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy](#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy)
- [OpportunityProduct_Dynamicpropertyinstance](#BKMK_OpportunityProduct_Dynamicpropertyinstance)
- [Owner_dynamicproperyinstance](#BKMK_Owner_dynamicproperyinstance)
- [OwningUser_Dynamicpropertyinsatance](#BKMK_OwningUser_Dynamicpropertyinsatance)
- [QuoteDetail_Dynamicpropertyinstance](#BKMK_QuoteDetail_Dynamicpropertyinstance)
- [SalesOrderDetail_Dynamicpropertyinstance](#BKMK_SalesOrderDetail_Dynamicpropertyinstance)
- [team_DynamicPropertyInstance](#BKMK_team_DynamicPropertyInstance)
- [TransactionCurrency_Dynamicpropertyinsatance](#BKMK_TransactionCurrency_Dynamicpropertyinsatance)

### <a name="BKMK_business_unit_dynamicproperyinstance"></a> business_unit_dynamicproperyinstance

One-To-Many Relationship: [businessunit business_unit_dynamicproperyinstance](businessunit.md#BKMK_business_unit_dynamicproperyinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_DynamicProperty_DynamicPropertyInstance"></a> DynamicProperty_DynamicPropertyInstance

One-To-Many Relationship: [dynamicproperty DynamicProperty_DynamicPropertyInstance](dynamicproperty.md#BKMK_DynamicProperty_DynamicPropertyInstance)

|Property|Value|
|---|---|
|ReferencedEntity|`dynamicproperty`|
|ReferencedAttribute|`dynamicpropertyid`|
|ReferencingAttribute|`dynamicpropertyid`|
|ReferencingEntityNavigationPropertyName|`dynamicpropertyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Dynamicpropertyinsatance_createdby"></a> Dynamicpropertyinsatance_createdby

One-To-Many Relationship: [systemuser Dynamicpropertyinsatance_createdby](systemuser.md#BKMK_Dynamicpropertyinsatance_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_InvoiceDetail_Dynamicpropertyinstance"></a> InvoiceDetail_Dynamicpropertyinstance

One-To-Many Relationship: [invoicedetail InvoiceDetail_Dynamicpropertyinstance](invoicedetail.md#BKMK_InvoiceDetail_Dynamicpropertyinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`invoicedetail`|
|ReferencedAttribute|`invoicedetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoicedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_Dynamicpropertyinsatanceattribute_createdonbehalfby"></a> lk_Dynamicpropertyinsatanceattribute_createdonbehalfby

One-To-Many Relationship: [systemuser lk_Dynamicpropertyinsatanceattribute_createdonbehalfby](systemuser.md#BKMK_lk_Dynamicpropertyinsatanceattribute_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedBy"></a> lk_Dynamicpropertyinsatanceattribute_ModifiedBy

One-To-Many Relationship: [systemuser lk_Dynamicpropertyinsatanceattribute_ModifiedBy](systemuser.md#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedBy)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy"></a> lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy

One-To-Many Relationship: [systemuser lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy](systemuser.md#BKMK_lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_OpportunityProduct_Dynamicpropertyinstance"></a> OpportunityProduct_Dynamicpropertyinstance

One-To-Many Relationship: [opportunityproduct OpportunityProduct_Dynamicpropertyinstance](opportunityproduct.md#BKMK_OpportunityProduct_Dynamicpropertyinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunityproduct`|
|ReferencedAttribute|`opportunityproductid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunityproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Owner_dynamicproperyinstance"></a> Owner_dynamicproperyinstance

One-To-Many Relationship: [owner Owner_dynamicproperyinstance](owner.md#BKMK_Owner_dynamicproperyinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_OwningUser_Dynamicpropertyinsatance"></a> OwningUser_Dynamicpropertyinsatance

One-To-Many Relationship: [systemuser OwningUser_Dynamicpropertyinsatance](systemuser.md#BKMK_OwningUser_Dynamicpropertyinsatance)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`dynamicpropertyinstanceid`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_QuoteDetail_Dynamicpropertyinstance"></a> QuoteDetail_Dynamicpropertyinstance

One-To-Many Relationship: [quotedetail QuoteDetail_Dynamicpropertyinstance](quotedetail.md#BKMK_QuoteDetail_Dynamicpropertyinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`quotedetail`|
|ReferencedAttribute|`quotedetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quotedetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_SalesOrderDetail_Dynamicpropertyinstance"></a> SalesOrderDetail_Dynamicpropertyinstance

One-To-Many Relationship: [salesorderdetail SalesOrderDetail_Dynamicpropertyinstance](salesorderdetail.md#BKMK_SalesOrderDetail_Dynamicpropertyinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorderdetail`|
|ReferencedAttribute|`salesorderdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorderdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_DynamicPropertyInstance"></a> team_DynamicPropertyInstance

One-To-Many Relationship: [team team_DynamicPropertyInstance](team.md#BKMK_team_DynamicPropertyInstance)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_Dynamicpropertyinsatance"></a> TransactionCurrency_Dynamicpropertyinsatance

One-To-Many Relationship: [transactioncurrency TransactionCurrency_Dynamicpropertyinsatance](transactioncurrency.md#BKMK_TransactionCurrency_Dynamicpropertyinsatance)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`dynamicpropertyinstanceid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [dynamicpropertyinstance_AsyncOperations](#BKMK_dynamicpropertyinstance_AsyncOperations)
- [dynamicpropertyinstance_BulkDeleteFailures](#BKMK_dynamicpropertyinstance_BulkDeleteFailures)
- [dynamicpropertyinstance_MailboxTrackingFolders](#BKMK_dynamicpropertyinstance_MailboxTrackingFolders)
- [dynamicpropertyinstance_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses)
- [dynamicpropertyinstance_SyncErrors](#BKMK_dynamicpropertyinstance_SyncErrors)

### <a name="BKMK_dynamicpropertyinstance_AsyncOperations"></a> dynamicpropertyinstance_AsyncOperations

Many-To-One Relationship: [asyncoperation dynamicpropertyinstance_AsyncOperations](asyncoperation.md#BKMK_dynamicpropertyinstance_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyinstance_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyinstance_BulkDeleteFailures"></a> dynamicpropertyinstance_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure dynamicpropertyinstance_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicpropertyinstance_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyinstance_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyinstance_MailboxTrackingFolders"></a> dynamicpropertyinstance_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder dynamicpropertyinstance_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicpropertyinstance_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyinstance_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses"></a> dynamicpropertyinstance_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess dynamicpropertyinstance_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyinstance_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyinstance_SyncErrors"></a> dynamicpropertyinstance_SyncErrors

Many-To-One Relationship: [syncerror dynamicpropertyinstance_SyncErrors](syncerror.md#BKMK_dynamicpropertyinstance_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyinstance_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

