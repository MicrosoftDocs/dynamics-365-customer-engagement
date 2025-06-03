---
title: "Social Profile (SocialProfile) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Social Profile (SocialProfile) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Social Profile (SocialProfile) table/entity reference (Microsoft Dynamics 365 Customer Service)

This entity is used to store social profile information of its associated account and contacts on different social channels.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Social Profile (SocialProfile) table extends the [Microsoft Dynamics 365 Social Profile (SocialProfile) table](/dynamics365/developer/reference/entities/socialprofile).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_octwitterhandleid](#BKMK_msdyn_octwitterhandleid)
- [msdyn_sourceid](#BKMK_msdyn_sourceid)
- [msdyn_wechatopenid](#BKMK_msdyn_wechatopenid)

### <a name="BKMK_msdyn_octwitterhandleid"></a> msdyn_octwitterhandleid

|Property|Value|
|---|---|
|Description|**Lookup for Twitter Handle entity.**|
|DisplayName|**Twitter Handle Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_octwitterhandleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_octwitterhandle|

### <a name="BKMK_msdyn_sourceid"></a> msdyn_sourceid

|Property|Value|
|---|---|
|Description|**Source Id field of social profile entity for Apple Business Messages channel.**|
|DisplayName|**Source Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_wechatopenid"></a> msdyn_wechatopenid

|Property|Value|
|---|---|
|Description|**Open ID field of social profile entity for WeChat channel.**|
|DisplayName|**WeChat Open ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wechatopenid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_octwitterhandle_socialprofile_octwitterhandleid"></a> msdyn_msdyn_octwitterhandle_socialprofile_octwitterhandleid

One-To-Many Relationship: [msdyn_octwitterhandle msdyn_msdyn_octwitterhandle_socialprofile_octwitterhandleid](msdyn_octwitterhandle.md#BKMK_msdyn_msdyn_octwitterhandle_socialprofile_octwitterhandleid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandle`|
|ReferencedAttribute|`msdyn_octwitterhandleid`|
|ReferencingAttribute|`msdyn_octwitterhandleid`|
|ReferencingEntityNavigationPropertyName|`msdyn_octwitterhandleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.socialprofile?displayProperty=fullName>
