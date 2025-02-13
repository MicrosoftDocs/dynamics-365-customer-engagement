---
title: "Property (DynamicProperty) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Property (DynamicProperty) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Property (DynamicProperty) table/entity reference (Microsoft Dynamics 365)

Information about a product property.

## Messages

The following table lists the messages for the Property (DynamicProperty) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: False |`POST` /dynamicproperties<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: False |`DELETE` /dynamicproperties(*dynamicpropertyid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: False |`GET` /dynamicproperties(*dynamicpropertyid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /dynamicproperties<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /dynamicproperties(*dynamicpropertyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: False |`PATCH` /dynamicproperties(*dynamicpropertyid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /dynamicproperties(*dynamicpropertyid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Property (DynamicProperty) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Property** |
| **DisplayCollectionName** | **Properties** |
| **SchemaName** | `DynamicProperty` |
| **CollectionSchemaName** | `DynamicProperties` |
| **EntitySetName** | `dynamicproperties`|
| **LogicalName** | `dynamicproperty` |
| **LogicalCollectionName** | `dynamicproperties` |
| **PrimaryIdAttribute** | `dynamicpropertyid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BaseDynamicPropertyId](#BKMK_BaseDynamicPropertyId)
- [DataType](#BKMK_DataType)
- [DefaultAttributeValue](#BKMK_DefaultAttributeValue)
- [DefaultValueDecimal](#BKMK_DefaultValueDecimal)
- [DefaultValueDouble](#BKMK_DefaultValueDouble)
- [DefaultValueInteger](#BKMK_DefaultValueInteger)
- [DefaultValueOptionSet](#BKMK_DefaultValueOptionSet)
- [DefaultValueString](#BKMK_DefaultValueString)
- [Description](#BKMK_Description)
- [DMTImportState](#BKMK_DMTImportState)
- [DynamicPropertyId](#BKMK_DynamicPropertyId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsHidden](#BKMK_IsHidden)
- [IsReadOnly](#BKMK_IsReadOnly)
- [IsRequired](#BKMK_IsRequired)
- [MaxLengthString](#BKMK_MaxLengthString)
- [MaxValueDecimal](#BKMK_MaxValueDecimal)
- [MaxValueDouble](#BKMK_MaxValueDouble)
- [MaxValueInteger](#BKMK_MaxValueInteger)
- [MinValueDecimal](#BKMK_MinValueDecimal)
- [MinValueDouble](#BKMK_MinValueDouble)
- [MinValueInteger](#BKMK_MinValueInteger)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OverwrittenDynamicPropertyId](#BKMK_OverwrittenDynamicPropertyId)
- [Precision](#BKMK_Precision)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RootDynamicPropertyId](#BKMK_RootDynamicPropertyId)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_BaseDynamicPropertyId"></a> BaseDynamicPropertyId

|Property|Value|
|---|---|
|Description|**Shows the property in the product family that this property is being inherited from.**|
|DisplayName|**Base Property**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`basedynamicpropertyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|dynamicproperty|

### <a name="BKMK_DataType"></a> DataType

|Property|Value|
|---|---|
|Description|**Select the data type of the property.**|
|DisplayName|**Data Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`datatype`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`dynamicproperty_datatypecode`|

#### DataType Choices/Options

|Value|Label|
|---|---|
|0|**Option Set**|
|1|**Decimal**|
|2|**Floating Point Number**|
|3|**Single Line Of Text**|
|4|**Whole Number**|

### <a name="BKMK_DefaultAttributeValue"></a> DefaultAttributeValue

|Property|Value|
|---|---|
|Description|**Default Value**|
|DisplayName|**Default Value**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`defaultattributevalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_DefaultValueDecimal"></a> DefaultValueDecimal

|Property|Value|
|---|---|
|Description|**Shows the default value of the property for a decimal data type.**|
|DisplayName|**Default Decimal Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultvaluedecimal`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_DefaultValueDouble"></a> DefaultValueDouble

|Property|Value|
|---|---|
|Description|**Shows the default value of the property for a double data type.**|
|DisplayName|**Default Double Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultvaluedouble`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|

### <a name="BKMK_DefaultValueInteger"></a> DefaultValueInteger

|Property|Value|
|---|---|
|Description|**Shows the default value of the property for a whole number data type.**|
|DisplayName|**Default Whole Number Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultvalueinteger`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_DefaultValueOptionSet"></a> DefaultValueOptionSet

|Property|Value|
|---|---|
|Description|**Shows the default value of the property.**|
|DisplayName|**Default OptionSet Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultvalueoptionset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|dynamicpropertyoptionsetitem|

### <a name="BKMK_DefaultValueString"></a> DefaultValueString

|Property|Value|
|---|---|
|Description|**Shows the default value of the property for a string data type.**|
|DisplayName|**Default String Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultvaluestring`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type a description for the property.**|
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
|Description|**Shows the unique identifier of the property.**|
|DisplayName|**Property ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyid`|
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

### <a name="BKMK_IsHidden"></a> IsHidden

|Property|Value|
|---|---|
|Description|**Defines whether the attribute is hidden or shown.**|
|DisplayName|**Hidden**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ishidden`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`dynamicproperty_ishidden`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsReadOnly"></a> IsReadOnly

|Property|Value|
|---|---|
|Description|**Defines whether the attribute is read-only or if it can be edited.**|
|DisplayName|**Read-Only**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isreadonly`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`dynamicproperty_isreadonly`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsRequired"></a> IsRequired

|Property|Value|
|---|---|
|Description|**Defines whether the attribute is mandatory.**|
|DisplayName|**Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isrequired`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`dynamicproperty_isrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_MaxLengthString"></a> MaxLengthString

|Property|Value|
|---|---|
|Description|**Shows the maximum allowed length of the property for a string data type.**|
|DisplayName|**Maximum String Length**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`maxlengthstring`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1024|
|MinValue|0|

### <a name="BKMK_MaxValueDecimal"></a> MaxValueDecimal

|Property|Value|
|---|---|
|Description|**Shows the maximum allowed value of the property for a decimal data type.**|
|DisplayName|**Maximum Decimal Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`maxvaluedecimal`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_MaxValueDouble"></a> MaxValueDouble

|Property|Value|
|---|---|
|Description|**Shows the maximum allowed value of the property for a double data type.**|
|DisplayName|**Maximum Double Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`maxvaluedouble`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|

### <a name="BKMK_MaxValueInteger"></a> MaxValueInteger

|Property|Value|
|---|---|
|Description|**Shows the maximum allowed value of the property for a whole number data type.**|
|DisplayName|**Maximum Whole Number Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`maxvalueinteger`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_MinValueDecimal"></a> MinValueDecimal

|Property|Value|
|---|---|
|Description|**Shows the minimum allowed value of the property for a decimal data type.**|
|DisplayName|**Minimum Decimal Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`minvaluedecimal`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_MinValueDouble"></a> MinValueDouble

|Property|Value|
|---|---|
|Description|**Shows the minimum allowed value of the property for a double data type.**|
|DisplayName|**Minimum Double Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`minvaluedouble`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|

### <a name="BKMK_MinValueInteger"></a> MinValueInteger

|Property|Value|
|---|---|
|Description|**Shows the minimum allowed value of the property for a whole number data type.**|
|DisplayName|**Minimum Whole Number Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`minvalueinteger`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type the name of the property.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
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

### <a name="BKMK_OverwrittenDynamicPropertyId"></a> OverwrittenDynamicPropertyId

|Property|Value|
|---|---|
|Description|**Shows the related overwritten property.**|
|DisplayName|**Overwritten Property**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwrittendynamicpropertyid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_Precision"></a> Precision

|Property|Value|
|---|---|
|Description|**Shows the allowed precision of the property for a whole number data type.**|
|DisplayName|**Precision**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`precision`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|5|
|MinValue|0|

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|---|---|
|Description|**Choose the product that the property is associated with.**|
|DisplayName|**Regarding**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjecttypecode`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_RootDynamicPropertyId"></a> RootDynamicPropertyId

|Property|Value|
|---|---|
|Description|**Shows the root property that this property is derived from.**|
|DisplayName|**Root Property**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`rootdynamicpropertyid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Shows the state of the property.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`dynamicproperty_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Draft**<br />DefaultStatus: 0<br />InvariantName: `Draft`|
|2|Label: **Retired**<br />DefaultStatus: 2<br />InvariantName: `Retired`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Shows whether the property is active or inactive.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`dynamicproperty_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Draft**<br />State:1<br />TransitionData: None|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Retired**<br />State:2<br />TransitionData: None|

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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|organization|

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

- [DefaultValueOptionSet_DynamicProperty](#BKMK_DefaultValueOptionSet_DynamicProperty)
- [dynamicproperty_base_dynamicproperty](#BKMK_dynamicproperty_base_dynamicproperty-many-to-one)
- [dynamicproperty_organization](#BKMK_dynamicproperty_organization)
- [lk_DynamicProperty_createdby](#BKMK_lk_DynamicProperty_createdby)
- [lk_DynamicProperty_createdonbehalfby](#BKMK_lk_DynamicProperty_createdonbehalfby)
- [lk_DynamicProperty_modifiedby](#BKMK_lk_DynamicProperty_modifiedby)
- [lk_DynamicProperty_modifiedonbehalfby](#BKMK_lk_DynamicProperty_modifiedonbehalfby)
- [Product_DynamicProperty](#BKMK_Product_DynamicProperty)
- [ProductAssociation_DynamicProperty](#BKMK_ProductAssociation_DynamicProperty)

### <a name="BKMK_DefaultValueOptionSet_DynamicProperty"></a> DefaultValueOptionSet_DynamicProperty

One-To-Many Relationship: [dynamicpropertyoptionsetitem DefaultValueOptionSet_DynamicProperty](dynamicpropertyoptionsetitem.md#BKMK_DefaultValueOptionSet_DynamicProperty)

|Property|Value|
|---|---|
|ReferencedEntity|`dynamicpropertyoptionsetitem`|
|ReferencedAttribute|`dynamicpropertyoptionsetvalueid`|
|ReferencingAttribute|`defaultvalueoptionset`|
|ReferencingEntityNavigationPropertyName|`dynamicpropertyoptionsetvalueid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_dynamicproperty_base_dynamicproperty-many-to-one"></a> dynamicproperty_base_dynamicproperty

One-To-Many Relationship: [dynamicproperty dynamicproperty_base_dynamicproperty](#BKMK_dynamicproperty_base_dynamicproperty-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`dynamicproperty`|
|ReferencedAttribute|`dynamicpropertyid`|
|ReferencingAttribute|`basedynamicpropertyid`|
|ReferencingEntityNavigationPropertyName|`basedynamicpropertyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_dynamicproperty_organization"></a> dynamicproperty_organization

One-To-Many Relationship: [organization dynamicproperty_organization](organization.md#BKMK_dynamicproperty_organization)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicProperty_createdby"></a> lk_DynamicProperty_createdby

One-To-Many Relationship: [systemuser lk_DynamicProperty_createdby](systemuser.md#BKMK_lk_DynamicProperty_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicProperty_createdonbehalfby"></a> lk_DynamicProperty_createdonbehalfby

One-To-Many Relationship: [systemuser lk_DynamicProperty_createdonbehalfby](systemuser.md#BKMK_lk_DynamicProperty_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicProperty_modifiedby"></a> lk_DynamicProperty_modifiedby

One-To-Many Relationship: [systemuser lk_DynamicProperty_modifiedby](systemuser.md#BKMK_lk_DynamicProperty_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicProperty_modifiedonbehalfby"></a> lk_DynamicProperty_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_DynamicProperty_modifiedonbehalfby](systemuser.md#BKMK_lk_DynamicProperty_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Product_DynamicProperty"></a> Product_DynamicProperty

One-To-Many Relationship: [product Product_DynamicProperty](product.md#BKMK_Product_DynamicProperty)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_ProductAssociation_DynamicProperty"></a> ProductAssociation_DynamicProperty

One-To-Many Relationship: [productassociation ProductAssociation_DynamicProperty](productassociation.md#BKMK_ProductAssociation_DynamicProperty)

|Property|Value|
|---|---|
|ReferencedEntity|`productassociation`|
|ReferencedAttribute|`productassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_productassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [dynamicproperty_AsyncOperations](#BKMK_dynamicproperty_AsyncOperations)
- [dynamicproperty_base_dynamicproperty](#BKMK_dynamicproperty_base_dynamicproperty-one-to-many)
- [dynamicproperty_BulkDeleteFailures](#BKMK_dynamicproperty_BulkDeleteFailures)
- [Dynamicproperty_DynamicPropertyAssociation](#BKMK_Dynamicproperty_DynamicPropertyAssociation)
- [DynamicProperty_DynamicPropertyInstance](#BKMK_DynamicProperty_DynamicPropertyInstance)
- [DynamicProperty_DynamicPropertyOptionSetItem](#BKMK_DynamicProperty_DynamicPropertyOptionSetItem)
- [dynamicproperty_MailboxTrackingFolders](#BKMK_dynamicproperty_MailboxTrackingFolders)
- [dynamicproperty_PrincipalObjectAttributeAccesses](#BKMK_dynamicproperty_PrincipalObjectAttributeAccesses)
- [dynamicproperty_SyncErrors](#BKMK_dynamicproperty_SyncErrors)

### <a name="BKMK_dynamicproperty_AsyncOperations"></a> dynamicproperty_AsyncOperations

Many-To-One Relationship: [asyncoperation dynamicproperty_AsyncOperations](asyncoperation.md#BKMK_dynamicproperty_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicproperty_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicproperty_base_dynamicproperty-one-to-many"></a> dynamicproperty_base_dynamicproperty

Many-To-One Relationship: [dynamicproperty dynamicproperty_base_dynamicproperty](#BKMK_dynamicproperty_base_dynamicproperty-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicproperty`|
|ReferencingAttribute|`basedynamicpropertyid`|
|ReferencedEntityNavigationPropertyName|`dynamicproperty_base_dynamicproperty`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicproperty_BulkDeleteFailures"></a> dynamicproperty_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure dynamicproperty_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicproperty_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicproperty_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Dynamicproperty_DynamicPropertyAssociation"></a> Dynamicproperty_DynamicPropertyAssociation

Many-To-One Relationship: [dynamicpropertyassociation Dynamicproperty_DynamicPropertyAssociation](dynamicpropertyassociation.md#BKMK_Dynamicproperty_DynamicPropertyAssociation)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyassociation`|
|ReferencingAttribute|`dynamicpropertyid`|
|ReferencedEntityNavigationPropertyName|`Dynamicproperty_DynamicPropertyAssociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_DynamicProperty_DynamicPropertyInstance"></a> DynamicProperty_DynamicPropertyInstance

Many-To-One Relationship: [dynamicpropertyinstance DynamicProperty_DynamicPropertyInstance](dynamicpropertyinstance.md#BKMK_DynamicProperty_DynamicPropertyInstance)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyinstance`|
|ReferencingAttribute|`dynamicpropertyid`|
|ReferencedEntityNavigationPropertyName|`DynamicProperty_DynamicPropertyInstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_DynamicProperty_DynamicPropertyOptionSetItem"></a> DynamicProperty_DynamicPropertyOptionSetItem

Many-To-One Relationship: [dynamicpropertyoptionsetitem DynamicProperty_DynamicPropertyOptionSetItem](dynamicpropertyoptionsetitem.md#BKMK_DynamicProperty_DynamicPropertyOptionSetItem)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyoptionsetitem`|
|ReferencingAttribute|`dynamicpropertyid`|
|ReferencedEntityNavigationPropertyName|`DynamicProperty_DynamicPropertyOptionSetItem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicproperty_MailboxTrackingFolders"></a> dynamicproperty_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder dynamicproperty_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicproperty_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicproperty_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicproperty_PrincipalObjectAttributeAccesses"></a> dynamicproperty_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess dynamicproperty_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicproperty_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`dynamicproperty_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicproperty_SyncErrors"></a> dynamicproperty_SyncErrors

Many-To-One Relationship: [syncerror dynamicproperty_SyncErrors](syncerror.md#BKMK_dynamicproperty_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicproperty_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

