---
title: "Territory table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Territory table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Territory table/entity reference (Microsoft Dynamics 365)

Territory represents sales regions.

> [!NOTE]
> The Microsoft Dynamics 365 Territory table extends the [Microsoft Dataverse Territory table](/power-apps/developer/data-platform/reference/entities/territory).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [territory_accounts](#BKMK_territory_accounts)
- [Territory_DuplicateBaseRecord](#BKMK_Territory_DuplicateBaseRecord)
- [Territory_DuplicateMatchingRecord](#BKMK_Territory_DuplicateMatchingRecord)

### <a name="BKMK_territory_accounts"></a> territory_accounts

Many-To-One Relationship: [account territory_accounts](account.md#BKMK_territory_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`account`|
|ReferencingAttribute|`territoryid`|
|ReferencedEntityNavigationPropertyName|`territory_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Territory_DuplicateBaseRecord"></a> Territory_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord Territory_DuplicateBaseRecord](duplicaterecord.md#BKMK_Territory_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`Territory_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Territory_DuplicateMatchingRecord"></a> Territory_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord Territory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Territory_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`Territory_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Customized relationships

### Customized One-to-Many relationships

- [Territory_AsyncOperations](#BKMK_Territory_AsyncOperations)
- [Territory_BulkDeleteFailures](#BKMK_Territory_BulkDeleteFailures)
- [territory_principalobjectattributeaccess](#BKMK_territory_principalobjectattributeaccess)
- [Territory_ProcessSessions](#BKMK_Territory_ProcessSessions)
- [territory_connections2](#BKMK_territory_connections2)

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
|AssociatedMenuConfiguration|Behavior: `UseCollectionName`<br />Order: `110`|

#### <a name="BKMK_territory_connections2"></a> territory_connections2

Changes from [territory_connections2 (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/territory#BKMK_territory_connections2)

|Property|Value|
|---|---|
|AssociatedMenuConfiguration|Order: `100`|


### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.territory?displayProperty=fullName>
