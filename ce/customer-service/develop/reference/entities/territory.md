---
title: "Territory table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Territory table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Territory table/entity reference (Microsoft Dynamics 365 Customer Service)

Territory represents sales regions.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Territory table extends the [Microsoft Dynamics 365 Territory table](/dynamics365/developer/reference/entities/territory).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_territory_msdyn_resourcerequirement_Territory](#BKMK_msdyn_territory_msdyn_resourcerequirement_Territory)
- [msdyn_territory_msdyn_resourceterritory_Territory](#BKMK_msdyn_territory_msdyn_resourceterritory_Territory)

### <a name="BKMK_msdyn_territory_msdyn_resourcerequirement_Territory"></a> msdyn_territory_msdyn_resourcerequirement_Territory

Many-To-One Relationship: [msdyn_resourcerequirement msdyn_territory_msdyn_resourcerequirement_Territory](msdyn_resourcerequirement.md#BKMK_msdyn_territory_msdyn_resourcerequirement_Territory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`msdyn_territory`|
|ReferencedEntityNavigationPropertyName|`msdyn_territory_msdyn_resourcerequirement_Territory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_territory_msdyn_resourceterritory_Territory"></a> msdyn_territory_msdyn_resourceterritory_Territory

Many-To-One Relationship: [msdyn_resourceterritory msdyn_territory_msdyn_resourceterritory_Territory](msdyn_resourceterritory.md#BKMK_msdyn_territory_msdyn_resourceterritory_Territory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`msdyn_territory`|
|ReferencedEntityNavigationPropertyName|`msdyn_territory_msdyn_resourceterritory_Territory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Customized relationships

### Customized One-to-Many relationships

- [Territory_AsyncOperations](#BKMK_Territory_AsyncOperations)
- [Territory_BulkDeleteFailures](#BKMK_Territory_BulkDeleteFailures)
- [territory_principalobjectattributeaccess](#BKMK_territory_principalobjectattributeaccess)
- [Territory_ProcessSessions](#BKMK_Territory_ProcessSessions)

#### <a name="BKMK_Territory_AsyncOperations"></a> Territory_AsyncOperations

Changes from [Territory_AsyncOperations (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/territory#BKMK_Territory_AsyncOperations)

|Property|Value|
|---|---|
|IsCustomizable|False|

#### <a name="BKMK_Territory_BulkDeleteFailures"></a> Territory_BulkDeleteFailures

Changes from [Territory_BulkDeleteFailures (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/territory#BKMK_Territory_BulkDeleteFailures)

|Property|Value|
|---|---|
|IsCustomizable|False|

#### <a name="BKMK_territory_principalobjectattributeaccess"></a> territory_principalobjectattributeaccess

Changes from [territory_principalobjectattributeaccess (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/territory#BKMK_territory_principalobjectattributeaccess)

|Property|Value|
|---|---|
|IsCustomizable|False|

#### <a name="BKMK_Territory_ProcessSessions"></a> Territory_ProcessSessions

Changes from [Territory_ProcessSessions (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/territory#BKMK_Territory_ProcessSessions)

|Property|Value|
|---|---|
|IsCustomizable|False|


### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.territory?displayProperty=fullName>
