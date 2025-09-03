---
title: "Queue table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Queue table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Queue table/entity reference (Microsoft Dynamics 365 Customer Service)

A list of records that require action, such as accounts, activities, and cases.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Queue table extends the [Microsoft Dynamics 365 Queue table](/dynamics365/developer/reference/entities/queue).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_queuetype"></a> msdyn_queuetype

Changes from [msdyn_queuetype (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/queue#BKMK_msdyn_queuetype)

#### msdyn_queuetype Choices/Options

|Value|Label|
|---|---|
|192350002|**Voice**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_proactive_engagement_config_queue_queue"></a> msdyn_proactive_engagement_config_queue_queue

Many-To-One Relationship: [msdyn_proactive_engagement_config msdyn_proactive_engagement_config_queue_queue](msdyn_proactive_engagement_config.md#BKMK_msdyn_proactive_engagement_config_queue_queue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config`|
|ReferencingAttribute|`msdyn_queue`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_queue_queue`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.queue?displayProperty=fullName>
