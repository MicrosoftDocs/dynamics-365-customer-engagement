---
title: "Operating Hour (msdyn_operatinghour) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Operating Hour (msdyn_operatinghour) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Operating Hour (msdyn_operatinghour) table/entity reference (Microsoft Dynamics 365 Customer Service)

Stores all the operating hours that are configured for an organization.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Operating Hour (msdyn_operatinghour) table extends the [Microsoft Dynamics 365 Operating Hour (msdyn_operatinghour) table](/dynamics365/developer/reference/entities/msdyn_operatinghour).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_operatinghour_msdyn_livechatconfig](#BKMK_msdyn_msdyn_operatinghour_msdyn_livechatconfig)
- [msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid](#BKMK_msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid)
- [msdyn_msdyn_operatinghour_msdyn_smsnumber_operatinghours](#BKMK_msdyn_msdyn_operatinghour_msdyn_smsnumber_operatinghours)
- [msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid](#BKMK_msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid)

### <a name="BKMK_msdyn_msdyn_operatinghour_msdyn_livechatconfig"></a> msdyn_msdyn_operatinghour_msdyn_livechatconfig

Many-To-One Relationship: [msdyn_livechatconfig msdyn_msdyn_operatinghour_msdyn_livechatconfig](msdyn_livechatconfig.md#BKMK_msdyn_msdyn_operatinghour_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatconfig`|
|ReferencingAttribute|`msdyn_operatinghourid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_operatinghour_msdyn_livechatconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid"></a> msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid

Many-To-One Relationship: [msdyn_ocsmschannelsetting msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid](msdyn_ocsmschannelsetting.md#BKMK_msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsmschannelsetting`|
|ReferencingAttribute|`msdyn_operatinghourid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_operatinghour_msdyn_ocsmschannelsetting_operatinghoursid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_operatinghour_msdyn_smsnumber_operatinghours"></a> msdyn_msdyn_operatinghour_msdyn_smsnumber_operatinghours

Many-To-One Relationship: [msdyn_smsnumber msdyn_msdyn_operatinghour_msdyn_smsnumber_operatinghours](msdyn_smsnumber.md#BKMK_msdyn_msdyn_operatinghour_msdyn_smsnumber_operatinghours)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsnumber`|
|ReferencingAttribute|`msdyn_operatinghourid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_operatinghour_msdyn_smsnumber_operatinghours`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid"></a> msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid

Many-To-One Relationship: [msdyn_ocvoicechannelsetting msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannelsetting`|
|ReferencingAttribute|`msdyn_operatinghoursid`|
|ReferencedEntityNavigationPropertyName|`msdyn_operatinghour_msdyn_ocvoicechannelsetting_operatinghoursid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

