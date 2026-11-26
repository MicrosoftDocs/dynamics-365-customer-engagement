---
title: "Channel Profile (msdyn_channelprofile) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Channel Profile (msdyn_channelprofile) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Channel Profile (msdyn_channelprofile) table/entity reference (Microsoft Dynamics 365 Field Service)

Channel profile configuration for omnichannel

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Channel Profile (msdyn_channelprofile) table extends the [Microsoft Dynamics 365 Channel Profile (msdyn_channelprofile) table](/dynamics365/developer/reference/entities/msdyn_channelprofile).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [msdyn_enableagentaffinity](#BKMK_msdyn_enableagentaffinity)
- [msdyn_streamsource](#BKMK_msdyn_streamsource)

### <a name="BKMK_msdyn_enableagentaffinity"></a> msdyn_enableagentaffinity

Changes from [msdyn_enableagentaffinity (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_channelprofile#BKMK_msdyn_enableagentaffinity)

|Property|Value|
|---|---|
|GlobalChoiceName|new_msdyn_channelprofile_msdyn_enableagentaffinity|


### <a name="BKMK_msdyn_streamsource"></a> msdyn_streamsource

Changes from [msdyn_streamsource (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_channelprofile#BKMK_msdyn_streamsource)

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
|192440000|**Voice call**|
|192450000|**Apple Messages for Business**|
|192450001|**Google's Business Messages**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_channelprofileaiagent_msdyn_channelprofileid_msdyn_channelprofile"></a> msdyn_channelprofileaiagent_msdyn_channelprofileid_msdyn_channelprofile

Many-To-One Relationship: [msdyn_channelprofileaiagent msdyn_channelprofileaiagent_msdyn_channelprofileid_msdyn_channelprofile](msdyn_channelprofileaiagent.md#BKMK_msdyn_channelprofileaiagent_msdyn_channelprofileid_msdyn_channelprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelprofileaiagent`|
|ReferencingAttribute|`msdyn_channelprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelprofileaiagent_msdyn_channelprofileid_msdyn_channelprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

