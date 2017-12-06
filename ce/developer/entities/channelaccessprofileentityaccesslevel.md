---
title: "ChannelAccessProfileEntityAccessLevel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ChannelAccessProfileEntityAccessLevel entity."
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
# ChannelAccessProfileEntityAccessLevel Entity Reference

Group of privileges used to categorize users to provide appropriate access to entities.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/channelaccessprofileentityaccesslevels<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName||
|DisplayCollectionName||
|DisplayName||
|EntitySetName|channelaccessprofileentityaccesslevels|
|IsBPFEntity|False|
|LogicalCollectionName||
|LogicalName|channelaccessprofileentityaccesslevel|
|OwnershipType|None|
|PrimaryIdAttribute|channelaccessprofileentityaccesslevelid|
|PrimaryNameAttribute||
|SchemaName|ChannelAccessProfileEntityAccessLevel|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ChannelAccessProfileEntityAccessLevelId](#BKMK_ChannelAccessProfileEntityAccessLevelId)
- [EntityAccessLevelDepthMask](#BKMK_EntityAccessLevelDepthMask)


### <a name="BKMK_ChannelAccessProfileEntityAccessLevelId"></a> ChannelAccessProfileEntityAccessLevelId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the entity access level associated with the channel access profile.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|channelaccessprofileentityaccesslevelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_EntityAccessLevelDepthMask"></a> EntityAccessLevelDepthMask

|Property|Value|
|--------|-----|
|Description|System-generated attribute that stores the privileges associated with the role.|
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityaccessleveldepthmask|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ChannelAccessProfileEntityAccessLevelIdUnique](#BKMK_ChannelAccessProfileEntityAccessLevelIdUnique)
- [ChannelAccessProfileId](#BKMK_ChannelAccessProfileId)
- [ComponentState](#BKMK_ComponentState)
- [EntityAccessLevelId](#BKMK_EntityAccessLevelId)
- [IsManaged](#BKMK_IsManaged)
- [OverwriteTime](#BKMK_OverwriteTime)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ChannelAccessProfileEntityAccessLevelIdUnique"></a> ChannelAccessProfileEntityAccessLevelIdUnique

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|channelaccessprofileentityaccesslevelidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ChannelAccessProfileId"></a> ChannelAccessProfileId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the channel access profile.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|channelaccessprofileid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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



### <a name="BKMK_EntityAccessLevelId"></a> EntityAccessLevelId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the entity access level associated with the channel access profile|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityaccesslevelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
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
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the ChannelAccessProfileEntityAccessLevel entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_ChannelAccessProfile_Privilege"></a> ChannelAccessProfile_Privilege

See privilege Entity [ChannelAccessProfile_Privilege](privilege.md#BKMK_ChannelAccessProfile_Privilege) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.channelaccessprofileentityaccesslevel?text=channelaccessprofileentityaccesslevel EntityType" />