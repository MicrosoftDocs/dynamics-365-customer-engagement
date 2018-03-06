---
title: "Remove deactivated or disabled customizations | MicrosoftDocs"
description: "Deactivated or disabled customizations should be removed from a solution to improve solution management and to decrease the risk of utilizing or managing an outdated component."
ms.date: 02/05/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
	- "Dynamics 365 (online)"
ms.assetid: 22d5fc9d-d4d1-43ef-9a2d-1a64f770161f
author: "jowells1"
ms.author: "jowells"
manager: "michu"
---
# Remove deactivated or disabled customizations

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]
- [!include[](../../includes/pn-crm-8-1-0-both.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Maintainability, Supportability

**Impact potential**: Low

<a name='symptoms'></a>

## Symptoms

Deactivated or disabled customizations should be removed from a solution to improve solution management and to decrease the risk of utilizing or managing an outdated component.

<a name='guidance'></a>

## Guidance

Ensure that each solution component that is deactivated, or disabled, has been done so intentionally.  If so and will no longer be utilized, consider removing it from the solution to prevent confusion for users and system customizers. These components include:

- SDK Message Processing Steps
- Processes
- Record Creation and Update Rules
- SLAs

As well as Entity components such as:

- Forms
- Views
- Business Rules

![Deactivated Processes](../media/deactivated-processes.png)

<a name='seealso'></a>

### See also

[Create custom business logic through processes](../../customize/guide-staff-through-common-tasks-processes.md)<br />
[Events in forms and grids in Customer Engagement](../../developer/clientapi/events-forms-grids.md)<br />