---
title: "Appointment table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Appointment table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Appointment table/entity reference

Commitment representing a time interval with start/end times and duration.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Appointment table extends [Appointment table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment) and [Appointment table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/appointment).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Appointment table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment) and [Appointment table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/appointment) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [OptionalAttendees](#BKMK_OptionalAttendees)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [requiredattendees](#BKMK_requiredattendees)

### <a name="BKMK_OptionalAttendees"></a> OptionalAttendees

Changes from [OptionalAttendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_OptionalAttendees):

|Property|Value|
|---|---|
|Targets|entitlement|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|bookableresourcebooking|


### <a name="BKMK_requiredattendees"></a> requiredattendees

Changes from [requiredattendees (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/appointment#BKMK_requiredattendees):

|Property|Value|
|---|---|
|Targets|entitlement|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.appointment?displayProperty=fullName>
