---
title: "Calendar table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Calendar table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Calendar table/entity reference (Microsoft Dynamics 365)

Calendar used by the scheduling system to define when an appointment or activity is to occur.

> [!NOTE]
> The Microsoft Dynamics 365 Calendar table extends the [Microsoft Dataverse Calendar table](/power-apps/developer/data-platform/reference/entities/calendar).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [calendar_bookableresources](#BKMK_calendar_bookableresources)
- [calendar_equipment](#BKMK_calendar_equipment)
- [calendar_services](#BKMK_calendar_services)

### <a name="BKMK_calendar_bookableresources"></a> calendar_bookableresources

Many-To-One Relationship: [bookableresource calendar_bookableresources](bookableresource.md#BKMK_calendar_bookableresources)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`calendarid`|
|ReferencedEntityNavigationPropertyName|`calendar_bookableresources`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_calendar_equipment"></a> calendar_equipment

Many-To-One Relationship: [equipment calendar_equipment](equipment.md#BKMK_calendar_equipment)

|Property|Value|
|---|---|
|ReferencingEntity|`equipment`|
|ReferencingAttribute|`calendarid`|
|ReferencedEntityNavigationPropertyName|`calendar_equipment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_calendar_services"></a> calendar_services

Many-To-One Relationship: [service calendar_services](service.md#BKMK_calendar_services)

|Property|Value|
|---|---|
|ReferencingEntity|`service`|
|ReferencingAttribute|`calendarid`|
|ReferencedEntityNavigationPropertyName|`calendar_services`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.calendar?displayProperty=fullName>
