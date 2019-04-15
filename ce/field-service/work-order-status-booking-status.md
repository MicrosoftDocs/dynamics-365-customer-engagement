---
title: "Work Order and Booking Statuses | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/15/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Work Order System Statuses and Booking Statuses


### Relationship between Work Order System Status and Booking Status



### Scenarios:

1. Estimate Work Order Sub-status
2. Delayed Booking Status
3. Follow up Work Order Sub-status

## Prerequisites

- understand that work orders and booking have difference statuses
- Work Order statuses should never be edited and instead work order sub statuses should be

> [!Note]
> Work Order System Statuses should NEVER be edited because system jobs and plug-ins rely on these statuses. Instead, administrators should create custom Work Order Substatuses that relate to Work Order System Statuses.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Estimate Work Order Sub-status
## Delayed Booking Status
## Follow up Work Order Sub-status

## Configuration considerations
## Additional Notes
