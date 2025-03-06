---
title: "Entitlement table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Entitlement table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Entitlement table/entity reference (Microsoft Dynamics 365 Customer Service)

Defines the amount and type of support a customer should receive.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Entitlement table extends the [Microsoft Dynamics 365 Entitlement table](/dynamics365/developer/reference/entities/entitlement).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_entitlement_msdyn_bookingalerts"></a> entitlement_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert entitlement_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_entitlement_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`entitlement_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

