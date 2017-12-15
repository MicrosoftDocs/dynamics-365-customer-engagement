---
title: "SdkMessageRequestField Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SdkMessageRequestField entity."
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
# SdkMessageRequestField Entity Reference

For internal use only.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/sdkmessagerequestfields(*sdkmessagerequestfieldid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/sdkmessagerequestfields<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SdkMessageRequestFields|
|DisplayCollectionName|Sdk Message Request Fields|
|DisplayName|Sdk Message Request Field|
|EntitySetName|sdkmessagerequestfields|
|IsBPFEntity|False|
|LogicalCollectionName|sdkmessagerequestfields|
|LogicalName|sdkmessagerequestfield|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|sdkmessagerequestfieldid|
|PrimaryNameAttribute||
|SchemaName|SdkMessageRequestField|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ClrParser](#BKMK_ClrParser)
- [IntroducedVersion](#BKMK_IntroducedVersion)
- [Name](#BKMK_Name)
- [Optional](#BKMK_Optional)
- [ParameterBindingInformation](#BKMK_ParameterBindingInformation)
- [Parser](#BKMK_Parser)
- [PublicName](#BKMK_PublicName)
- [SdkMessageRequestFieldId](#BKMK_SdkMessageRequestFieldId)


### <a name="BKMK_ClrParser"></a> ClrParser

|Property|Value|
|--------|-----|
|Description|Common language runtime (CLR)-based parser for the SDK message request field.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|clrparser|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IntroducedVersion"></a> IntroducedVersion

|Property|Value|
|--------|-----|
|Description|Version in which the component is introduced.|
|DisplayName|Introduced Version|
|FormatName|VersionNumber|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|introducedversion|
|MaxLength|48|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the SDK message request field.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|256|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_Optional"></a> Optional

|Property|Value|
|--------|-----|
|Description|Information about whether SDK message request field is optional.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|optional|
|RequiredLevel|None|
|Type|Boolean|

#### Optional Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ParameterBindingInformation"></a> ParameterBindingInformation

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parameterbindinginformation|
|MaxLength|128|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Parser"></a> Parser

|Property|Value|
|--------|-----|
|Description|Parser for the SDK message request field.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parser|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PublicName"></a> PublicName

|Property|Value|
|--------|-----|
|Description|Public name of the SDK message request field.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|publicname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SdkMessageRequestFieldId"></a> SdkMessageRequestFieldId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the SDK message request field entity.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sdkmessagerequestfieldid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomizationLevel](#BKMK_CustomizationLevel)
- [FieldMask](#BKMK_FieldMask)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
- [Position](#BKMK_Position)
- [SdkMessageRequestFieldIdUnique](#BKMK_SdkMessageRequestFieldIdUnique)
- [SdkMessageRequestId](#BKMK_SdkMessageRequestId)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Component State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|componentstate|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ComponentState Options

|Value|Label|
|-----|-----|
|0|Published|
|1|Unpublished|
|2|Deleted|
|3|Deleted Unpublished|



### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the SDK message request field.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the SDK message request field was created.|
|DisplayName||
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the sdkmessagerequestfield.|
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


### <a name="BKMK_CustomizationLevel"></a> CustomizationLevel

|Property|Value|
|--------|-----|
|Description|Customization level of the SDK message request field.|
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customizationlevel|
|MaxValue|255|
|MinValue|-255|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_FieldMask"></a> FieldMask

|Property|Value|
|--------|-----|
|Description|Indicates how field contents are used during message processing. 1 - Primary entity, 2- Secondary entity|
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fieldmask|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|Information that specifies whether this component is managed.|
|DisplayName|State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismanaged|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsManaged Options

|Value|Label|
|-----|-----|
|1|Managed|
|0|Unmanaged|

**DefaultValue**: False



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the SDK message request field.|
|DisplayName|Modified By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the SDK message request field was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the sdkmessagerequestfield.|
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


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization with which the SDK message request field is associated.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


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


### <a name="BKMK_Position"></a> Position

|Property|Value|
|--------|-----|
|Description|Position of the Sdk message request field|
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|position|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_SdkMessageRequestFieldIdUnique"></a> SdkMessageRequestFieldIdUnique

|Property|Value|
|--------|-----|
|Description|Entity identifier of the SDK message request field.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sdkmessagerequestfieldidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SdkMessageRequestId"></a> SdkMessageRequestId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the message request with which the SDK message request field is associated.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sdkmessagerequestid|
|RequiredLevel|None|
|Targets|sdkmessagerequest|
|Type|Lookup|


### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated solution.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|solutionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|supportingsolutionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName||
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


### <a name="BKMK_userentityinstancedata_sdkmessagerequestfield"></a> userentityinstancedata_sdkmessagerequestfield

Same as userentityinstancedata entity [userentityinstancedata_sdkmessagerequestfield](userentityinstancedata.md#BKMK_userentityinstancedata_sdkmessagerequestfield) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_sdkmessagerequestfield|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [organization_sdkmessagerequestfield](#BKMK_organization_sdkmessagerequestfield)
- [createdby_sdkmessagerequestfield](#BKMK_createdby_sdkmessagerequestfield)
- [lk_sdkmessagerequestfield_modifiedonbehalfby](#BKMK_lk_sdkmessagerequestfield_modifiedonbehalfby)
- [modifiedby_sdkmessagerequestfield](#BKMK_modifiedby_sdkmessagerequestfield)
- [lk_sdkmessagerequestfield_createdonbehalfby](#BKMK_lk_sdkmessagerequestfield_createdonbehalfby)
- [messagerequest_sdkmessagerequestfield](#BKMK_messagerequest_sdkmessagerequestfield)


### <a name="BKMK_organization_sdkmessagerequestfield"></a> organization_sdkmessagerequestfield

See organization Entity [organization_sdkmessagerequestfield](organization.md#BKMK_organization_sdkmessagerequestfield) One-To-Many relationship.

### <a name="BKMK_createdby_sdkmessagerequestfield"></a> createdby_sdkmessagerequestfield

See systemuser Entity [createdby_sdkmessagerequestfield](systemuser.md#BKMK_createdby_sdkmessagerequestfield) One-To-Many relationship.

### <a name="BKMK_lk_sdkmessagerequestfield_modifiedonbehalfby"></a> lk_sdkmessagerequestfield_modifiedonbehalfby

See systemuser Entity [lk_sdkmessagerequestfield_modifiedonbehalfby](systemuser.md#BKMK_lk_sdkmessagerequestfield_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_modifiedby_sdkmessagerequestfield"></a> modifiedby_sdkmessagerequestfield

See systemuser Entity [modifiedby_sdkmessagerequestfield](systemuser.md#BKMK_modifiedby_sdkmessagerequestfield) One-To-Many relationship.

### <a name="BKMK_lk_sdkmessagerequestfield_createdonbehalfby"></a> lk_sdkmessagerequestfield_createdonbehalfby

See systemuser Entity [lk_sdkmessagerequestfield_createdonbehalfby](systemuser.md#BKMK_lk_sdkmessagerequestfield_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_messagerequest_sdkmessagerequestfield"></a> messagerequest_sdkmessagerequestfield

See sdkmessagerequest Entity [messagerequest_sdkmessagerequestfield](sdkmessagerequest.md#BKMK_messagerequest_sdkmessagerequestfield) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.sdkmessagerequestfield?text=sdkmessagerequestfield EntityType" />