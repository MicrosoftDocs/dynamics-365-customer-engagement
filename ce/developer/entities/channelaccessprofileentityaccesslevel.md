---
title: "ChannelAccessProfileEntityAccessLevel table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the ChannelAccessProfileEntityAccessLevel table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# ChannelAccessProfileEntityAccessLevel table/entity reference

Group of privileges used to categorize users to provide appropriate access to entities.

## Messages

The following table lists the messages for the ChannelAccessProfileEntityAccessLevel table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `RetrieveMultiple`<br />Event: True |`GET` /channelaccessprofileentityaccesslevels<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|

## Properties

The following table lists selected properties for the ChannelAccessProfileEntityAccessLevel table.

|Property|Value|
| --- | --- |
| **SchemaName** | `ChannelAccessProfileEntityAccessLevel` |
| **EntitySetName** | `channelaccessprofileentityaccesslevels`|
| **LogicalName** | `channelaccessprofileentityaccesslevel` |
| **PrimaryIdAttribute** | `channelaccessprofileentityaccesslevelid` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ChannelAccessProfileEntityAccessLevelId](#BKMK_ChannelAccessProfileEntityAccessLevelId)
- [EntityAccessLevelDepthMask](#BKMK_EntityAccessLevelDepthMask)

### <a name="BKMK_ChannelAccessProfileEntityAccessLevelId"></a> ChannelAccessProfileEntityAccessLevelId

|Property|Value|
|---|---|
|Description|**Unique identifier of the entity access level associated with the channel access profile.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`channelaccessprofileentityaccesslevelid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_EntityAccessLevelDepthMask"></a> EntityAccessLevelDepthMask

|Property|Value|
|---|---|
|Description|**System-generated attribute that stores the privileges associated with the role.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityaccessleveldepthmask`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

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
|---|---|
|Description|**For internal use only.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`channelaccessprofileentityaccesslevelidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ChannelAccessProfileId"></a> ChannelAccessProfileId

|Property|Value|
|---|---|
|Description|**Unique identifier of the channel access profile.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`channelaccessprofileid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

### <a name="BKMK_EntityAccessLevelId"></a> EntityAccessLevelId

|Property|Value|
|---|---|
|Description|**Unique identifier of the entity access level associated with the channel access profile**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityaccesslevelid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.channelaccessprofileentityaccesslevel?displayProperty=fullName>
