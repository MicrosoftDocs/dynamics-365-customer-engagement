---
title: "DynamicProperty Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the DynamicProperty entity."
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
# DynamicProperty Entity Reference

Information about a product property.

**Added by**: Product Management Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/dynamicproperties<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/dynamicproperties(*dynamicpropertyid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/dynamicproperties(*dynamicpropertyid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/dynamicproperties<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/dynamicproperties(*dynamicpropertyid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/dynamicproperties(*dynamicpropertyid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|DynamicProperties|
|DisplayCollectionName|Properties|
|DisplayName|Property|
|EntitySetName|dynamicproperties|
|IsBPFEntity|False|
|LogicalCollectionName|dynamicproperties|
|LogicalName|dynamicproperty|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|dynamicpropertyid|
|PrimaryNameAttribute|name|
|SchemaName|DynamicProperty|

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

|Property|Value|
|--------|-----|
|Description|Shows the property in the product family that this property is being inherited from.|
|DisplayName|Base Property|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|basedynamicpropertyid|
|RequiredLevel|None|
|Targets|dynamicproperty|
|Type|Lookup|


### <a name="BKMK_BaseDynamicPropertyIdName"></a> BaseDynamicPropertyIdName

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
|LogicalName|basedynamicpropertyidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DataType"></a> DataType

|Property|Value|
|--------|-----|
|Description|Select the data type of the property.|
|DisplayName|Data Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|datatype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### DataType Options

|Value|Label|
|-----|-----|
|0|Option Set|
|1|Decimal|
|2|Floating Point Number|
|3|Single Line Of Text|
|4|Whole Number|



### <a name="BKMK_DefaultValueDecimal"></a> DefaultValueDecimal

|Property|Value|
|--------|-----|
|Description|Shows the default value of the property for a decimal data type.|
|DisplayName|Default Decimal Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultvaluedecimal|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_DefaultValueDouble"></a> DefaultValueDouble

|Property|Value|
|--------|-----|
|Description|Shows the default value of the property for a double data type.|
|DisplayName|Default Double Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultvaluedouble|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_DefaultValueInteger"></a> DefaultValueInteger

|Property|Value|
|--------|-----|
|Description|Shows the default value of the property for a whole number data type.|
|DisplayName|Default Whole Number Value|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultvalueinteger|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_DefaultValueOptionSet"></a> DefaultValueOptionSet

|Property|Value|
|--------|-----|
|Description|Shows the default value of the property.|
|DisplayName|Default OptionSet Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultvalueoptionset|
|RequiredLevel|None|
|Targets|dynamicpropertyoptionsetitem|
|Type|Lookup|


### <a name="BKMK_DefaultValueString"></a> DefaultValueString

|Property|Value|
|--------|-----|
|Description|Shows the default value of the property for a string data type.|
|DisplayName|Default String Value|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultvaluestring|
|MaxLength|1024|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type a description for the property.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


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
|Description|Shows the unique identifier of the property.|
|DisplayName|Property ID|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|dynamicpropertyid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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


### <a name="BKMK_IsHidden"></a> IsHidden

|Property|Value|
|--------|-----|
|Description|Defines whether the attribute is hidden or shown.|
|DisplayName|Hidden|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ishidden|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsHidden Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsReadOnly"></a> IsReadOnly

|Property|Value|
|--------|-----|
|Description|Defines whether the attribute is read-only or if it can be edited.|
|DisplayName|Read-Only|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isreadonly|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsReadOnly Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsRequired"></a> IsRequired

|Property|Value|
|--------|-----|
|Description|Defines whether the attribute is mandatory.|
|DisplayName|Required|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isrequired|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsRequired Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_MaxLengthString"></a> MaxLengthString

|Property|Value|
|--------|-----|
|Description|Shows the maximum allowed length of the property for a string data type.|
|DisplayName|Maximum String Length|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|maxlengthstring|
|MaxValue|1024|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MaxValueDecimal"></a> MaxValueDecimal

|Property|Value|
|--------|-----|
|Description|Shows the maximum allowed value of the property for a decimal data type.|
|DisplayName|Maximum Decimal Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|maxvaluedecimal|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_MaxValueDouble"></a> MaxValueDouble

|Property|Value|
|--------|-----|
|Description|Shows the maximum allowed value of the property for a double data type.|
|DisplayName|Maximum Double Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|maxvaluedouble|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_MaxValueInteger"></a> MaxValueInteger

|Property|Value|
|--------|-----|
|Description|Shows the maximum allowed value of the property for a whole number data type.|
|DisplayName|Maximum Whole Number Value|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|maxvalueinteger|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MinValueDecimal"></a> MinValueDecimal

|Property|Value|
|--------|-----|
|Description|Shows the minimum allowed value of the property for a decimal data type.|
|DisplayName|Minimum Decimal Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|minvaluedecimal|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_MinValueDouble"></a> MinValueDouble

|Property|Value|
|--------|-----|
|Description|Shows the minimum allowed value of the property for a double data type.|
|DisplayName|Minimum Double Value|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|minvaluedouble|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_MinValueInteger"></a> MinValueInteger

|Property|Value|
|--------|-----|
|Description|Shows the minimum allowed value of the property for a whole number data type.|
|DisplayName|Minimum Whole Number Value|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|minvalueinteger|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type the name of the property.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|True|
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


### <a name="BKMK_OverwrittenDynamicPropertyId"></a> OverwrittenDynamicPropertyId

|Property|Value|
|--------|-----|
|Description|Shows the related overwritten property.|
|DisplayName|Overwritten Property|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overwrittendynamicpropertyid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Precision"></a> Precision

|Property|Value|
|--------|-----|
|Description|Shows the allowed precision of the property for a whole number data type.|
|DisplayName|Precision|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|precision|
|MaxValue|5|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the product that the property is associated with.|
|DisplayName|Regarding|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

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
|LogicalName|regardingobjectidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_RootDynamicPropertyId"></a> RootDynamicPropertyId

|Property|Value|
|--------|-----|
|Description|Shows the root property that this property is derived from.|
|DisplayName|Root Property|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|rootdynamicpropertyid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Shows the state of the property.|
|DisplayName|Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Draft|0|Draft|
|2|Retired|2|Retired|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Shows whether the property is active or inactive.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|0|Draft|1|
|1|Active|0|
|2|Retired|2|



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


### <a name="BKMK_DefaultValueOptionSetName"></a> DefaultValueOptionSetName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultvalueoptionsetname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


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


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

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

- [dynamicproperty_SyncErrors](#BKMK_dynamicproperty_SyncErrors)
- [dynamicproperty_AsyncOperations](#BKMK_dynamicproperty_AsyncOperations)
- [dynamicproperty_MailboxTrackingFolders](#BKMK_dynamicproperty_MailboxTrackingFolders)
- [dynamicproperty_BulkDeleteFailures](#BKMK_dynamicproperty_BulkDeleteFailures)
- [dynamicproperty_PrincipalObjectAttributeAccesses](#BKMK_dynamicproperty_PrincipalObjectAttributeAccesses)
- [dynamicproperty_base_dynamicproperty](#BKMK_dynamicproperty_base_dynamicproperty)
- [Dynamicproperty_DynamicPropertyAssociation](#BKMK_Dynamicproperty_DynamicPropertyAssociation)
- [DynamicProperty_DynamicPropertyInstance](#BKMK_DynamicProperty_DynamicPropertyInstance)
- [DynamicProperty_DynamicPropertyOptionSetItem](#BKMK_DynamicProperty_DynamicPropertyOptionSetItem)
- [msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId](#BKMK_msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId)


### <a name="BKMK_dynamicproperty_SyncErrors"></a> dynamicproperty_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [dynamicproperty_SyncErrors](syncerror.md#BKMK_dynamicproperty_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicproperty_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicproperty_AsyncOperations"></a> dynamicproperty_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [dynamicproperty_AsyncOperations](asyncoperation.md#BKMK_dynamicproperty_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicproperty_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicproperty_MailboxTrackingFolders"></a> dynamicproperty_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [dynamicproperty_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicproperty_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicproperty_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicproperty_BulkDeleteFailures"></a> dynamicproperty_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [dynamicproperty_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicproperty_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicproperty_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicproperty_PrincipalObjectAttributeAccesses"></a> dynamicproperty_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [dynamicproperty_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicproperty_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicproperty_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicproperty_base_dynamicproperty"></a> dynamicproperty_base_dynamicproperty

Same as dynamicproperty entity [dynamicproperty_base_dynamicproperty](dynamicproperty.md#BKMK_dynamicproperty_base_dynamicproperty) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicproperty|
|ReferencingAttribute|basedynamicpropertyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|dynamicproperty_base_dynamicproperty|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Dynamicproperty_DynamicPropertyAssociation"></a> Dynamicproperty_DynamicPropertyAssociation

Same as dynamicpropertyassociation entity [Dynamicproperty_DynamicPropertyAssociation](dynamicpropertyassociation.md#BKMK_Dynamicproperty_DynamicPropertyAssociation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyassociation|
|ReferencingAttribute|dynamicpropertyid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Dynamicproperty_DynamicPropertyAssociation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_DynamicProperty_DynamicPropertyInstance"></a> DynamicProperty_DynamicPropertyInstance

Same as dynamicpropertyinstance entity [DynamicProperty_DynamicPropertyInstance](dynamicpropertyinstance.md#BKMK_DynamicProperty_DynamicPropertyInstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyinstance|
|ReferencingAttribute|dynamicpropertyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|DynamicProperty_DynamicPropertyInstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_DynamicProperty_DynamicPropertyOptionSetItem"></a> DynamicProperty_DynamicPropertyOptionSetItem

Same as dynamicpropertyoptionsetitem entity [DynamicProperty_DynamicPropertyOptionSetItem](dynamicpropertyoptionsetitem.md#BKMK_DynamicProperty_DynamicPropertyOptionSetItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyoptionsetitem|
|ReferencingAttribute|dynamicpropertyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|DynamicProperty_DynamicPropertyOptionSetItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId"></a> msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId

**Added by**: Project Service Automation Solution

Same as msdyn_fieldcomputation entity [msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId](msdyn_fieldcomputation.md#BKMK_msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldcomputation|
|ReferencingAttribute|msdyn_propertyid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_dynamicproperty_msdyn_fieldcomputation_PropertyId|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

**Added by**: System Solution Solution

See systemuser Entity [lk_DynamicProperty_createdby](systemuser.md#BKMK_lk_DynamicProperty_createdby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicProperty_createdonbehalfby"></a> lk_DynamicProperty_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_DynamicProperty_createdonbehalfby](systemuser.md#BKMK_lk_DynamicProperty_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicProperty_modifiedby"></a> lk_DynamicProperty_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_DynamicProperty_modifiedby](systemuser.md#BKMK_lk_DynamicProperty_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_DynamicProperty_modifiedonbehalfby"></a> lk_DynamicProperty_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_DynamicProperty_modifiedonbehalfby](systemuser.md#BKMK_lk_DynamicProperty_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_organization"></a> dynamicproperty_organization

**Added by**: System Solution Solution

See organization Entity [dynamicproperty_organization](organization.md#BKMK_dynamicproperty_organization) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_base_dynamicproperty"></a> dynamicproperty_base_dynamicproperty

See dynamicproperty Entity [dynamicproperty_base_dynamicproperty](dynamicproperty.md#BKMK_dynamicproperty_base_dynamicproperty) One-To-Many relationship.

### <a name="BKMK_DefaultValueOptionSet_DynamicProperty"></a> DefaultValueOptionSet_DynamicProperty

See dynamicpropertyoptionsetitem Entity [DefaultValueOptionSet_DynamicProperty](dynamicpropertyoptionsetitem.md#BKMK_DefaultValueOptionSet_DynamicProperty) One-To-Many relationship.

### <a name="BKMK_Product_DynamicProperty"></a> Product_DynamicProperty

See product Entity [Product_DynamicProperty](product.md#BKMK_Product_DynamicProperty) One-To-Many relationship.

### <a name="BKMK_ProductAssociation_DynamicProperty"></a> ProductAssociation_DynamicProperty

See productassociation Entity [ProductAssociation_DynamicProperty](productassociation.md#BKMK_ProductAssociation_DynamicProperty) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.dynamicproperty?text=dynamicproperty EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]