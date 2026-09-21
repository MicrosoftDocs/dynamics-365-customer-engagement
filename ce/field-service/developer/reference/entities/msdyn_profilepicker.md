---
title: "Profile Picker (msdyn_profilepicker) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Profile Picker (msdyn_profilepicker) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Profile Picker (msdyn_profilepicker) table/entity reference (Microsoft Dynamics 365 Field Service)



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Profile Picker (msdyn_profilepicker) table extends the [Microsoft Dynamics 365 Profile Picker (msdyn_profilepicker) table](/dynamics365/developer/reference/entities/msdyn_profilepicker).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_channelinstanceid](#BKMK_msdyn_channelinstanceid)
- [msdyn_channelinstanceidIdType](#BKMK_msdyn_channelinstanceidIdType)

### <a name="BKMK_msdyn_channelinstanceid"></a> msdyn_channelinstanceid

|Property|Value|
|---|---|
|Description|**Profile Picker Associated with the Live Chat Config**|
|DisplayName|**Channel Instance Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channelinstanceid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_livechatconfig, msdyn_occustommessagingchannel, msdyn_ocvoicechannelsetting|

### <a name="BKMK_msdyn_channelinstanceidIdType"></a> msdyn_channelinstanceidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channelinstanceididtype`|
|RequiredLevel|None|
|Type|EntityName|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_ChannelType"></a> msdyn_ChannelType

Changes from [msdyn_ChannelType (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_profilepicker#BKMK_msdyn_ChannelType)

#### msdyn_ChannelType Choices/Options

|Value|Label|
|---|---|
|19241000|**Microsoft Teams**|
|192300000|**WhatsApp**|
|192310000|**LINE**|
|192320000|**WeChat**|
|192330000|**Facebook**|
|192340000|**SMS**|
|192350001|**Twitter**|
|192350002|**Custom**|
|192360000|**Live chat**|
|192370000|**Voice**|
|192380000|**Video**|
|192390000|**Co-browse**|
|192400000|**Screen sharing**|
|192440000|**Voice call**|
|192450000|**Apple Messages for Business**|
|192450001|**Google's Business Messages**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_profilepicker_msdyn_channelinstanceid_msdyn_livechatconfig](#BKMK_msdyn_profilepicker_msdyn_channelinstanceid_msdyn_livechatconfig)
- [msdyn_profilepicker_msdyn_channelinstanceid_msdyn_occustommessagingchannel](#BKMK_msdyn_profilepicker_msdyn_channelinstanceid_msdyn_occustommessagingchannel)
- [msdyn_profilepicker_msdyn_channelinstanceid_msdyn_ocvoicechannelsetting](#BKMK_msdyn_profilepicker_msdyn_channelinstanceid_msdyn_ocvoicechannelsetting)

### <a name="BKMK_msdyn_profilepicker_msdyn_channelinstanceid_msdyn_livechatconfig"></a> msdyn_profilepicker_msdyn_channelinstanceid_msdyn_livechatconfig

One-To-Many Relationship: [msdyn_livechatconfig msdyn_profilepicker_msdyn_channelinstanceid_msdyn_livechatconfig](msdyn_livechatconfig.md#BKMK_msdyn_profilepicker_msdyn_channelinstanceid_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatconfig`|
|ReferencedAttribute|`msdyn_livechatconfigid`|
|ReferencingAttribute|`msdyn_channelinstanceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_channelinstanceid_msdyn_livechatconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_profilepicker_msdyn_channelinstanceid_msdyn_occustommessagingchannel"></a> msdyn_profilepicker_msdyn_channelinstanceid_msdyn_occustommessagingchannel

One-To-Many Relationship: [msdyn_occustommessagingchannel msdyn_profilepicker_msdyn_channelinstanceid_msdyn_occustommessagingchannel](msdyn_occustommessagingchannel.md#BKMK_msdyn_profilepicker_msdyn_channelinstanceid_msdyn_occustommessagingchannel)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occustommessagingchannel`|
|ReferencedAttribute|`msdyn_occustommessagingchannelid`|
|ReferencingAttribute|`msdyn_channelinstanceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_channelinstanceid_msdyn_occustommessagingchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_profilepicker_msdyn_channelinstanceid_msdyn_ocvoicechannelsetting"></a> msdyn_profilepicker_msdyn_channelinstanceid_msdyn_ocvoicechannelsetting

One-To-Many Relationship: [msdyn_ocvoicechannelsetting msdyn_profilepicker_msdyn_channelinstanceid_msdyn_ocvoicechannelsetting](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_profilepicker_msdyn_channelinstanceid_msdyn_ocvoicechannelsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannelsetting`|
|ReferencedAttribute|`msdyn_ocvoicechannelsettingid`|
|ReferencingAttribute|`msdyn_channelinstanceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_channelinstanceid_msdyn_ocvoicechannelsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

