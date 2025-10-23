---
title: "Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table/entity reference (Microsoft Dynamics 365 Customer Service)

Entity that holds the configuration data for a channel provider based on Channel Integration Framework v1.0

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table extends the [Microsoft Dynamics 365 Channel Integration Framework v1.0 Provider (msdyn_ciprovider) table](/dynamics365/developer/reference/entities/msdyn_ciprovider).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_ciprovider_msdyn_channel"></a> msdyn_msdyn_ciprovider_msdyn_channel

Many-To-One Relationship: [msdyn_channel msdyn_msdyn_ciprovider_msdyn_channel](msdyn_channel.md#BKMK_msdyn_msdyn_ciprovider_msdyn_channel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channel`|
|ReferencingAttribute|`msdyn_channelproviderid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ciprovider_msdyn_channel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

