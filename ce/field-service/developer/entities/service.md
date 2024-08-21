---
title: "Service table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Service table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Service table/entity reference

Activity that represents work done to satisfy a customer's need.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Service table extends the [Microsoft Dynamics 365 Service table](/dynamics365/developer/entities//service).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_bookingalert_service_serviceid"></a> msdyn_bookingalert_service_serviceid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_service_serviceid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_service_serviceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

