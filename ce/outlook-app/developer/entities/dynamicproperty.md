---
title: "DynamicProperty Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the DynamicProperty entity."
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
# DynamicProperty Entity Reference

Information about a product property.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/dynamicproperties<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/dynamicproperties(*dynamicpropertyid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/dynamicproperties(*dynamicpropertyid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/dynamicproperties<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/dynamicproperties(*dynamicpropertyid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/dynamicproperties(*dynamicpropertyid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Property<br />
**DisplayCollectionName**: Properties<br />
**SchemaName**: DynamicProperty<br />
**CollectionSchemaName**: DynamicProperties<br />
**LogicalName**: dynamicproperty<br />
**LogicalCollectionName**: dynamicproperties<br />
**EntitySetName**: dynamicproperties<br />
**PrimaryIdAttribute**: dynamicpropertyid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BaseDynamicPropertyId](#BKMK_BaseDynamicPropertyId)
- [BaseDynamicPropertyIdName](#BKMK_BaseDynamicPropertyIdName)
- [DataType](#BKMK_DataType)
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
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [RootDynamicPropertyId](#BKMK_RootDynamicPropertyId)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BaseDynamicPropertyId"></a> BaseDynamicPropertyId

**Description**: Shows the property in the product family that this property is being inherited from.<br />
**DisplayName**: Base Property<br />
**LogicalName**: basedynamicpropertyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: dynamicproperty


### <a name="BKMK_BaseDynamicPropertyIdName"></a> BaseDynamicPropertyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: basedynamicpropertyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_DataType"></a> DataType

**Description**: Select the data type of the property.<br />
**DisplayName**: Data Type<br />
**LogicalName**: datatype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Option Set
- **Value**: 1 **Label**: Decimal
- **Value**: 2 **Label**: Floating Point Number
- **Value**: 3 **Label**: Single Line Of Text
- **Value**: 4 **Label**: Whole Number



### <a name="BKMK_DefaultValueDecimal"></a> DefaultValueDecimal

**Description**: Shows the default value of the property for a decimal data type.<br />
**DisplayName**: Default Decimal Value<br />
**LogicalName**: defaultvaluedecimal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_DefaultValueDouble"></a> DefaultValueDouble

**Description**: Shows the default value of the property for a double data type.<br />
**DisplayName**: Default Double Value<br />
**LogicalName**: defaultvaluedouble<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 5


### <a name="BKMK_DefaultValueInteger"></a> DefaultValueInteger

**Description**: Shows the default value of the property for a whole number data type.<br />
**DisplayName**: Default Whole Number Value<br />
**LogicalName**: defaultvalueinteger<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_DefaultValueOptionSet"></a> DefaultValueOptionSet

**Description**: Shows the default value of the property.<br />
**DisplayName**: Default OptionSet Value<br />
**LogicalName**: defaultvalueoptionset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: dynamicpropertyoptionsetitem


### <a name="BKMK_DefaultValueString"></a> DefaultValueString

**Description**: Shows the default value of the property for a string data type.<br />
**DisplayName**: Default String Value<br />
**LogicalName**: defaultvaluestring<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1024


### <a name="BKMK_Description"></a> Description

**Description**: Type a description for the property.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


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

**Description**: Shows the unique identifier of the property.<br />
**DisplayName**: Property ID<br />
**LogicalName**: dynamicpropertyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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


### <a name="BKMK_IsHidden"></a> IsHidden

**Description**: Defines whether the attribute is hidden or shown.<br />
**DisplayName**: Hidden<br />
**LogicalName**: ishidden<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsReadOnly"></a> IsReadOnly

**Description**: Defines whether the attribute is read-only or if it can be edited.<br />
**DisplayName**: Read-Only<br />
**LogicalName**: isreadonly<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsRequired"></a> IsRequired

**Description**: Defines whether the attribute is mandatory.<br />
**DisplayName**: Required<br />
**LogicalName**: isrequired<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_MaxLengthString"></a> MaxLengthString

**Description**: Shows the maximum allowed length of the property for a string data type.<br />
**DisplayName**: Maximum String Length<br />
**LogicalName**: maxlengthstring<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1024<br />
**MinValue**: 0


### <a name="BKMK_MaxValueDecimal"></a> MaxValueDecimal

**Description**: Shows the maximum allowed value of the property for a decimal data type.<br />
**DisplayName**: Maximum Decimal Value<br />
**LogicalName**: maxvaluedecimal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_MaxValueDouble"></a> MaxValueDouble

**Description**: Shows the maximum allowed value of the property for a double data type.<br />
**DisplayName**: Maximum Double Value<br />
**LogicalName**: maxvaluedouble<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 5


### <a name="BKMK_MaxValueInteger"></a> MaxValueInteger

**Description**: Shows the maximum allowed value of the property for a whole number data type.<br />
**DisplayName**: Maximum Whole Number Value<br />
**LogicalName**: maxvalueinteger<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_MinValueDecimal"></a> MinValueDecimal

**Description**: Shows the minimum allowed value of the property for a decimal data type.<br />
**DisplayName**: Minimum Decimal Value<br />
**LogicalName**: minvaluedecimal<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 2


### <a name="BKMK_MinValueDouble"></a> MinValueDouble

**Description**: Shows the minimum allowed value of the property for a double data type.<br />
**DisplayName**: Minimum Double Value<br />
**LogicalName**: minvaluedouble<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 100000000000<br />
**MinValue**: -100000000000<br />
**Precision**: 5


### <a name="BKMK_MinValueInteger"></a> MinValueInteger

**Description**: Shows the minimum allowed value of the property for a whole number data type.<br />
**DisplayName**: Minimum Whole Number Value<br />
**LogicalName**: minvalueinteger<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_Name"></a> Name

**Description**: Type the name of the property.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: True<br />
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


### <a name="BKMK_OverwrittenDynamicPropertyId"></a> OverwrittenDynamicPropertyId

**Description**: Shows the related overwritten property.<br />
**DisplayName**: Overwritten Property<br />
**LogicalName**: overwrittendynamicpropertyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Precision"></a> Precision

**Description**: Shows the allowed precision of the property for a whole number data type.<br />
**DisplayName**: Precision<br />
**LogicalName**: precision<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 5<br />
**MinValue**: 0


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Choose the product that the property is associated with.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_RootDynamicPropertyId"></a> RootDynamicPropertyId

**Description**: Shows the root property that this property is derived from.<br />
**DisplayName**: Root Property<br />
**LogicalName**: rootdynamicpropertyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Shows the state of the property.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Draft **DefaultStatus**: 0 **InvariantName**: Draft
- **Value**: 2 **Label**: Retired **DefaultStatus**: 2 **InvariantName**: Retired



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Shows whether the property is active or inactive.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 0 **Label**: Draft **State**: 1
- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Retired **State**: 2



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
- [DefaultValueOptionSetName](#BKMK_DefaultValueOptionSetName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
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
**RequiredLevel**: SystemRequired<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_DefaultValueOptionSetName"></a> DefaultValueOptionSetName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: defaultvalueoptionsetname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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
**RequiredLevel**: SystemRequired<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier for the organization<br />
**DisplayName**: Organization Id<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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

- [dynamicproperty_SyncErrors](#BKMK_dynamicproperty_SyncErrors)
- [dynamicproperty_AsyncOperations](#BKMK_dynamicproperty_AsyncOperations)
- [dynamicproperty_MailboxTrackingFolders](#BKMK_dynamicproperty_MailboxTrackingFolders)
- [dynamicproperty_UserEntityInstanceDatas](#BKMK_dynamicproperty_UserEntityInstanceDatas)
- [dynamicproperty_BulkDeleteFailures](#BKMK_dynamicproperty_BulkDeleteFailures)
- [dynamicproperty_PrincipalObjectAttributeAccesses](#BKMK_dynamicproperty_PrincipalObjectAttributeAccesses)
- [dynamicproperty_base_dynamicproperty](#BKMK_dynamicproperty_base_dynamicproperty)
- [Dynamicproperty_DynamicPropertyAssociation](#BKMK_Dynamicproperty_DynamicPropertyAssociation)
- [DynamicProperty_DynamicPropertyInstance](#BKMK_DynamicProperty_DynamicPropertyInstance)
- [DynamicProperty_DynamicPropertyOptionSetItem](#BKMK_DynamicProperty_DynamicPropertyOptionSetItem)
- [msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId](#BKMK_msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId)


### <a name="BKMK_dynamicproperty_SyncErrors"></a> dynamicproperty_SyncErrors

Same as syncerror entity [dynamicproperty_SyncErrors](syncerror.md#BKMK_dynamicproperty_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicproperty_SyncErrors<br />
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


### <a name="BKMK_dynamicproperty_AsyncOperations"></a> dynamicproperty_AsyncOperations

Same as asyncoperation entity [dynamicproperty_AsyncOperations](asyncoperation.md#BKMK_dynamicproperty_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicproperty_AsyncOperations<br />
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


### <a name="BKMK_dynamicproperty_MailboxTrackingFolders"></a> dynamicproperty_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [dynamicproperty_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicproperty_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicproperty_MailboxTrackingFolders<br />
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


### <a name="BKMK_dynamicproperty_UserEntityInstanceDatas"></a> dynamicproperty_UserEntityInstanceDatas

Same as userentityinstancedata entity [dynamicproperty_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_dynamicproperty_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicproperty_UserEntityInstanceDatas<br />
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


### <a name="BKMK_dynamicproperty_BulkDeleteFailures"></a> dynamicproperty_BulkDeleteFailures

Same as bulkdeletefailure entity [dynamicproperty_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicproperty_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicproperty_BulkDeleteFailures<br />
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


### <a name="BKMK_dynamicproperty_PrincipalObjectAttributeAccesses"></a> dynamicproperty_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [dynamicproperty_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicproperty_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicproperty_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_dynamicproperty_base_dynamicproperty"></a> dynamicproperty_base_dynamicproperty

Same as dynamicproperty entity [dynamicproperty_base_dynamicproperty](dynamicproperty.md#BKMK_dynamicproperty_base_dynamicproperty) Many-To-One relationship.

**ReferencingEntity**: dynamicproperty<br />
**ReferencingAttribute**: basedynamicpropertyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: dynamicproperty_base_dynamicproperty<br />
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


### <a name="BKMK_Dynamicproperty_DynamicPropertyAssociation"></a> Dynamicproperty_DynamicPropertyAssociation

Same as dynamicpropertyassociation entity [Dynamicproperty_DynamicPropertyAssociation](dynamicpropertyassociation.md#BKMK_Dynamicproperty_DynamicPropertyAssociation) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyassociation<br />
**ReferencingAttribute**: dynamicpropertyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Dynamicproperty_DynamicPropertyAssociation<br />
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


### <a name="BKMK_DynamicProperty_DynamicPropertyInstance"></a> DynamicProperty_DynamicPropertyInstance

Same as dynamicpropertyinstance entity [DynamicProperty_DynamicPropertyInstance](dynamicpropertyinstance.md#BKMK_DynamicProperty_DynamicPropertyInstance) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyinstance<br />
**ReferencingAttribute**: dynamicpropertyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: DynamicProperty_DynamicPropertyInstance<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_DynamicProperty_DynamicPropertyOptionSetItem"></a> DynamicProperty_DynamicPropertyOptionSetItem

Same as dynamicpropertyoptionsetitem entity [DynamicProperty_DynamicPropertyOptionSetItem](dynamicpropertyoptionsetitem.md#BKMK_DynamicProperty_DynamicPropertyOptionSetItem) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyoptionsetitem<br />
**ReferencingAttribute**: dynamicpropertyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: DynamicProperty_DynamicPropertyOptionSetItem<br />
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


### <a name="BKMK_msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId"></a> msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId

Same as msdyn_fieldcomputation entity [msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId](msdyn_fieldcomputation.md#BKMK_msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldcomputation<br />
**ReferencingAttribute**: msdyn_propertyid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId<br />
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

- [lk_DynamicProperty_createdby](#BKMK_lk_DynamicProperty_createdby)
- [lk_DynamicProperty_createdonbehalfby](#BKMK_lk_DynamicProperty_createdonbehalfby)
- [lk_DynamicProperty_modifiedby](#BKMK_lk_DynamicProperty_modifiedby)
- [lk_DynamicProperty_modifiedonbehalfby](#BKMK_lk_DynamicProperty_modifiedonbehalfby)
- [dynamicproperty_organization](#BKMK_dynamicproperty_organization)
- [dynamicproperty_base_dynamicproperty](#BKMK_dynamicproperty_base_dynamicproperty)
- [DefaultValueOptionSet_DynamicProperty](#BKMK_DefaultValueOptionSet_DynamicProperty)
- [Product_DynamicProperty](#BKMK_Product_DynamicProperty)
- [ProductAssociation_DynamicProperty](#BKMK_ProductAssociation_DynamicProperty)


### <a name="BKMK_lk_DynamicProperty_createdby"></a> lk_DynamicProperty_createdby

See systemuser Entity [lk_DynamicProperty_createdby](systemuser.md#BKMK_lk_DynamicProperty_createdby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicProperty_createdonbehalfby"></a> lk_DynamicProperty_createdonbehalfby

See systemuser Entity [lk_DynamicProperty_createdonbehalfby](systemuser.md#BKMK_lk_DynamicProperty_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicProperty_modifiedby"></a> lk_DynamicProperty_modifiedby

See systemuser Entity [lk_DynamicProperty_modifiedby](systemuser.md#BKMK_lk_DynamicProperty_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicProperty_modifiedonbehalfby"></a> lk_DynamicProperty_modifiedonbehalfby

See systemuser Entity [lk_DynamicProperty_modifiedonbehalfby](systemuser.md#BKMK_lk_DynamicProperty_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_organization"></a> dynamicproperty_organization

See organization Entity [dynamicproperty_organization](organization.md#BKMK_dynamicproperty_organization) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_base_dynamicproperty"></a> dynamicproperty_base_dynamicproperty

See dynamicproperty Entity [dynamicproperty_base_dynamicproperty](dynamicproperty.md#BKMK_dynamicproperty_base_dynamicproperty) One-To-Many relationship.

### <a name="BKMK_DefaultValueOptionSet_DynamicProperty"></a> DefaultValueOptionSet_DynamicProperty

See dynamicpropertyoptionsetitem Entity [DefaultValueOptionSet_DynamicProperty](dynamicpropertyoptionsetitem.md#BKMK_DefaultValueOptionSet_DynamicProperty) One-To-Many relationship.

### <a name="BKMK_Product_DynamicProperty"></a> Product_DynamicProperty

See product Entity [Product_DynamicProperty](product.md#BKMK_Product_DynamicProperty) One-To-Many relationship.

### <a name="BKMK_ProductAssociation_DynamicProperty"></a> ProductAssociation_DynamicProperty

See productassociation Entity [ProductAssociation_DynamicProperty](productassociation.md#BKMK_ProductAssociation_DynamicProperty) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.dynamicproperty?text=dynamicproperty EntityType" />