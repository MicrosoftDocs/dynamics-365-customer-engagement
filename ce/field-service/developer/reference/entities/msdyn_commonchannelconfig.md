---
title: "Common Channel Config (msdyn_commonchannelconfig) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Common Channel Config (msdyn_commonchannelconfig) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Common Channel Config (msdyn_commonchannelconfig) table/entity reference (Microsoft Dynamics 365 Field Service)



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Common Channel Config (msdyn_commonchannelconfig) table extends the [Microsoft Dynamics 365 Common Channel Config (msdyn_commonchannelconfig) table](/dynamics365/developer/reference/entities/msdyn_commonchannelconfig).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_livechatconfig_msdyn_commonchannelconfigid_msdyn_commonchannelconfig](#BKMK_msdyn_livechatconfig_msdyn_commonchannelconfigid_msdyn_commonchannelconfig)
- [msdyn_occustommessagingchannel_msdyn_commonchannelconfigid_msdyn_commonchannelconfig](#BKMK_msdyn_occustommessagingchannel_msdyn_commonchannelconfigid_msdyn_commonchannelconfig)
- [msdyn_ocvoicechannelsetting_msdyn_commonchannelconfigid_msdyn_commonchannelconfig](#BKMK_msdyn_ocvoicechannelsetting_msdyn_commonchannelconfigid_msdyn_commonchannelconfig)

### <a name="BKMK_msdyn_livechatconfig_msdyn_commonchannelconfigid_msdyn_commonchannelconfig"></a> msdyn_livechatconfig_msdyn_commonchannelconfigid_msdyn_commonchannelconfig

Many-To-One Relationship: [msdyn_livechatconfig msdyn_livechatconfig_msdyn_commonchannelconfigid_msdyn_commonchannelconfig](msdyn_livechatconfig.md#BKMK_msdyn_livechatconfig_msdyn_commonchannelconfigid_msdyn_commonchannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatconfig`|
|ReferencingAttribute|`msdyn_commonchannelconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_livechatconfig_msdyn_commonchannelconfigid_msdyn_commonchannelconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_occustommessagingchannel_msdyn_commonchannelconfigid_msdyn_commonchannelconfig"></a> msdyn_occustommessagingchannel_msdyn_commonchannelconfigid_msdyn_commonchannelconfig

Many-To-One Relationship: [msdyn_occustommessagingchannel msdyn_occustommessagingchannel_msdyn_commonchannelconfigid_msdyn_commonchannelconfig](msdyn_occustommessagingchannel.md#BKMK_msdyn_occustommessagingchannel_msdyn_commonchannelconfigid_msdyn_commonchannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustommessagingchannel`|
|ReferencingAttribute|`msdyn_commonchannelconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_occustommessagingchannel_msdyn_commonchannelconfigid_msdyn_commonchannelconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_msdyn_commonchannelconfigid_msdyn_commonchannelconfig"></a> msdyn_ocvoicechannelsetting_msdyn_commonchannelconfigid_msdyn_commonchannelconfig

Many-To-One Relationship: [msdyn_ocvoicechannelsetting msdyn_ocvoicechannelsetting_msdyn_commonchannelconfigid_msdyn_commonchannelconfig](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_ocvoicechannelsetting_msdyn_commonchannelconfigid_msdyn_commonchannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannelsetting`|
|ReferencingAttribute|`msdyn_commonchannelconfigid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicechannelsetting_msdyn_commonchannelconfigid_msdyn_commonchannelconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

