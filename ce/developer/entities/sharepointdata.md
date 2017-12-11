---
title: "SharePointData Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SharePointData entity."
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
# SharePointData Entity Reference

SharePoint's Data Corresponding to a user , Record , Location and Page


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/sharepointdatacollection(*sharepointdataid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/sharepointdatacollection<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/sharepointdatacollection(*sharepointdataid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SharePointData|
|DisplayCollectionName|SharePoint Data|
|DisplayName|SharePoint Data|
|EntitySetName|sharepointdatacollection|
|IsBPFEntity|False|
|LogicalCollectionName|sharepointdatacollection|
|LogicalName|sharepointdata|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|sharepointdataid|
|PrimaryNameAttribute||
|SchemaName|SharePointData|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Data](#BKMK_Data)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [SharePointDataId](#BKMK_SharePointDataId)


### <a name="BKMK_Data"></a> Data

|Property|Value|
|--------|-----|
|Description|SharePoint Data Serialized|
|DisplayName|SharePoint Data|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|data|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_SharePointDataId"></a> SharePointDataId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the SharePoint data record.|
|DisplayName|SharePoint data ID|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sharepointdataid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
- [IsValid](#BKMK_IsValid)
- [Location](#BKMK_Location)
- [LocationName](#BKMK_LocationName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [NextPageToken](#BKMK_NextPageToken)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OverwriteTime](#BKMK_OverwriteTime)
- [PageNumber](#BKMK_PageNumber)
- [PreviousPageToken](#BKMK_PreviousPageToken)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [UserId](#BKMK_UserId)
- [UserName](#BKMK_UserName)
- [UserYomiName](#BKMK_UserYomiName)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the SharePoint Data.|
|DisplayName|Created By|
|IsValidForForm|False|
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
|Description|Date and time when the SharePoint Data was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the SharePoint Data.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
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


### <a name="BKMK_IsValid"></a> IsValid

|Property|Value|
|--------|-----|
|Description|Is valid|
|DisplayName|Is Valid|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isvalid|
|RequiredLevel|None|
|Type|Boolean|

#### IsValid Options

|Value|Label|
|-----|-----|
|1|Valid Data|
|0|Invalid Data|

**DefaultValue**: False



### <a name="BKMK_Location"></a> Location

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the SharePoint Data.|
|DisplayName|Location|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|location|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_LocationName"></a> LocationName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|locationname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the SharePoint Data.|
|DisplayName|Modified By|
|IsValidForForm|False|
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
|Description|Date and time when the Sharepoint Data was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the SharePoint Data.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
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


### <a name="BKMK_NextPageToken"></a> NextPageToken

|Property|Value|
|--------|-----|
|Description|Next Page Token of the SharePoint document.|
|DisplayName|Next Page Token|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|nextpagetoken|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the SharePoint Data.|
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


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|For internal use only.|
|DisplayName|Record Overwrite Time|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|overwritetime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_PageNumber"></a> PageNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pagenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_PreviousPageToken"></a> PreviousPageToken

|Property|Value|
|--------|-----|
|Description|Previous Page Token of the SharePoint document.|
|DisplayName|Previous Page Token|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|previouspagetoken|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Regarding Object Id.|
|DisplayName|Regarding Object Id.|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UserId"></a> UserId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the SharePoint data.|
|DisplayName|User Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|userid|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_UserName"></a> UserName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|username|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UserYomiName"></a> UserYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|useryominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_SharePointData_createdonbehalfby](#BKMK_lk_SharePointData_createdonbehalfby)
- [lk_SharePointData_createdby](#BKMK_lk_SharePointData_createdby)
- [lk_SharePointData_modifiedonbehalfby](#BKMK_lk_SharePointData_modifiedonbehalfby)
- [organization_sharepointdata](#BKMK_organization_sharepointdata)
- [lk_sharepointdata_user](#BKMK_lk_sharepointdata_user)
- [lk_SharePointData_modifiedby](#BKMK_lk_SharePointData_modifiedby)
- [sharepointdata_sharepointdocumentlocation](#BKMK_sharepointdata_sharepointdocumentlocation)


### <a name="BKMK_lk_SharePointData_createdonbehalfby"></a> lk_SharePointData_createdonbehalfby

See systemuser Entity [lk_SharePointData_createdonbehalfby](systemuser.md#BKMK_lk_SharePointData_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_SharePointData_createdby"></a> lk_SharePointData_createdby

See systemuser Entity [lk_SharePointData_createdby](systemuser.md#BKMK_lk_SharePointData_createdby) One-To-Many relationship.

### <a name="BKMK_lk_SharePointData_modifiedonbehalfby"></a> lk_SharePointData_modifiedonbehalfby

See systemuser Entity [lk_SharePointData_modifiedonbehalfby](systemuser.md#BKMK_lk_SharePointData_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_sharepointdata"></a> organization_sharepointdata

See organization Entity [organization_sharepointdata](organization.md#BKMK_organization_sharepointdata) One-To-Many relationship.

### <a name="BKMK_lk_sharepointdata_user"></a> lk_sharepointdata_user

See systemuser Entity [lk_sharepointdata_user](systemuser.md#BKMK_lk_sharepointdata_user) One-To-Many relationship.

### <a name="BKMK_lk_SharePointData_modifiedby"></a> lk_SharePointData_modifiedby

See systemuser Entity [lk_SharePointData_modifiedby](systemuser.md#BKMK_lk_SharePointData_modifiedby) One-To-Many relationship.

### <a name="BKMK_sharepointdata_sharepointdocumentlocation"></a> sharepointdata_sharepointdocumentlocation

See sharepointdocumentlocation Entity [sharepointdata_sharepointdocumentlocation](sharepointdocumentlocation.md#BKMK_sharepointdata_sharepointdocumentlocation) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.sharepointdata?text=sharepointdata EntityType" />