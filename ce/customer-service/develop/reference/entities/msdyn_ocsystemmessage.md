---
title: "Message (msdyn_ocsystemmessage) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Message (msdyn_ocsystemmessage) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Message (msdyn_ocsystemmessage) table/entity reference (Microsoft Dynamics 365 Customer Service)

Stores the system messages sent to the message receiver for various events.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Message (msdyn_ocsystemmessage) table extends the [Microsoft Dynamics 365 Message (msdyn_ocsystemmessage) table](/dynamics365/developer/reference/entities/msdyn_ocsystemmessage).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_widgetid"></a> msdyn_widgetid

|Property|Value|
|---|---|
|Description|**Unique identifier for Chat Widget associated with System Message.**|
|DisplayName|**Widget**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_widgetid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_livechatconfig|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_streamsource"></a> msdyn_streamsource

Changes from [msdyn_streamsource (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocsystemmessage#BKMK_msdyn_streamsource)

#### msdyn_streamsource Choices/Options

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
|192450000|**Apple Messages for Business**|
|192450001|**Google's Business Messages**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_livechatconfig_msdyn_ocsystemmessage"></a> msdyn_livechatconfig_msdyn_ocsystemmessage

One-To-Many Relationship: [msdyn_livechatconfig msdyn_livechatconfig_msdyn_ocsystemmessage](msdyn_livechatconfig.md#BKMK_msdyn_livechatconfig_msdyn_ocsystemmessage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatconfig`|
|ReferencedAttribute|`msdyn_livechatconfigid`|
|ReferencingAttribute|`msdyn_widgetid`|
|ReferencingEntityNavigationPropertyName|`msdyn_widgetid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate"></a> msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate

Many-To-One Relationship: [msdyn_ocoutboundconfiguration msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate](msdyn_ocoutboundconfiguration.md#BKMK_msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundconfiguration`|
|ReferencingAttribute|`msdyn_messagetemplate`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

