---
title: "Recurring Appointment (RecurringAppointmentMaster) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Recurring Appointment (RecurringAppointmentMaster) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Recurring Appointment (RecurringAppointmentMaster) table/entity reference

The Master appointment of a recurring appointment series.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Recurring Appointment (RecurringAppointmentMaster) table extends [Recurring Appointment (RecurringAppointmentMaster) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster) and [Recurring Appointment (RecurringAppointmentMaster) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/recurringappointmentmaster).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Recurring Appointment (RecurringAppointmentMaster) table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster) and [Recurring Appointment (RecurringAppointmentMaster) table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/recurringappointmentmaster) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [OptionalAttendees](#BKMK_OptionalAttendees)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RequiredAttendees](#BKMK_RequiredAttendees)

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_OptionalAttendees):

|Property|Value|
|---|---|
|Targets|equipment|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|bookableresourcebooking|


### <a name="BKMK_RequiredAttendees"></a> RequiredAttendees

Changes from [RequiredAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/recurringappointmentmaster#BKMK_RequiredAttendees):

|Property|Value|
|---|---|
|Targets|equipment|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.recurringappointmentmaster?displayProperty=fullName>
