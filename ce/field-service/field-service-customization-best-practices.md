---
title: "Best practices for customizing Dynamics 365 Field Service  | MicrosoftDocs"
description: Learn about how to get the most out of your Dynamics 365 Field Service customizations.
ms.date: 11/15/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-field-service
ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Best practices for customizing Dynamics 365 Field Service

Oftentimes system administrators choose to customize the Field Service app to meet their business needs. Follow these best practices to avoid performance, usability, and supportability issues.

## Custom scripts: use fewer, and follow best practices

System customizers write scripts, typically JavaScript web resources, to execute business logic. However, custom scripts can cause performance issues, errors, and complications when upgrading.

To avoid these issues: 

- Minimize scripts running on load.
- Don't write scripts that call a lot of data or write multiple scripts that call the same data.
- Follow more [script best practices](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk).

For more information, see these resources:

- [Best practices (Developer Guide for Dynamics 365 Customer Engagement)](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk)
- [Optimize model-driven app form performance in Power Apps](/powerapps/maker/model-driven-apps/optimize-form-performance)
- [Unsupported customizations for Microsoft Dataverse (Dataverse)](/powerapps/developer/data-platform/supported-customizations#unsupported-customizations)

## Use asynchronous workflows instead of synchronous

System customizers often write synchronous workflows to perform business logic in real time that executes when data is changed in Field Service. However, running workflows synchronously will hurt performance.

To avoid performance issues, run workflows asynchronously.

## Activate Field Service and Resource Scheduling out-of-the-box processes

Field Service and Resource Scheduling ship with many processes that perform necessary business logic.

Deactivated processes can lead to errors.

To avoid issues, make sure all Field Service and Resource Scheduling processes are in an active state.

## Minimize custom fields

System customizers add custom fields to entity forms to capture information specific to their industry and business, to run business processes, and to collect information to report on. However, too many custom fields, especially on the first tab of the form, cause performance issues.

To avoid performance issues:

- Minimize the number of custom fields.
- Move custom fields from the first form tab to other form tabs.

## Don't edit or remove out-of-box fields

Customers edit out-of-the-box fields to accommodate their business needs. However, editing out-of-the-box calculated fields or editing the option sets of out-of-the-box fields can cause errors, especially when processes depend on those field values.

To avoid errors, don't add, edit, or remove _option set values_ for the following fields:
- Work Order
 - System Status
 - Work Location
- Work Order Product
  - Line status
- Work Order Service
  - Line status

Don't edit, override, or remove the following calculated fields:
- Bookable Resource Booking
  - Start time
  - Estimated arrival time
  - Actual Arrival time
  - Duration
  - End time
- Work Order
  - Total amount
  - Subtotal amount
  - Total Estimated Duration

For more information, see this article: [Optimize model-driven app form performance in Power Apps](/powerapps/maker/model-driven-apps/optimize-form-performance)
