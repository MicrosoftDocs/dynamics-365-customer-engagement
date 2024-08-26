---
title: "Calendar Rule (CalendarRule) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Calendar Rule (CalendarRule) table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Calendar Rule (CalendarRule) table/entity reference (Microsoft Dynamics 365)

Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.

> [!NOTE]
> The Microsoft Dynamics 365 Calendar Rule (CalendarRule) table extends the [Microsoft Dataverse Calendar Rule (CalendarRule) table](/power-apps/developer/data-platform/reference/entities/calendarrule).


## Messages

The following table lists the messages for the Calendar Rule (CalendarRule) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier of the service with which the calendar rule is associated.**|
|DisplayName|**Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`serviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|service|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_service_calendar_rules"></a> service_calendar_rules

One-To-Many Relationship: [service service_calendar_rules](service.md#BKMK_service_calendar_rules)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.calendarrule?displayProperty=fullName>
