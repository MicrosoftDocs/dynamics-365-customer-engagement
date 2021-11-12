---
title: "Best Practices for customizing Dynamics 365 Field Service | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 11/12/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Best Practices for customizing Dynamics 365 Field Service


## Custom scripts - use less, and follow best practices

**Description:** 
System customizers write scripts, typically JavaScript web resources, to execute business logic. 

**Category:** 
Customization

**Issue:**
Oftentimes the custom scripts cause performance issues, errors, and complications when upgrading. 

**Best practices:**

- Minimize scripts running on load
- Do not write scripts that call a lot of data or write multiple scripts that call the same data
- Follow more [script best practices](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/developer/best-practices-sdk?view=op-9-1). 


Resources: 
-	[Best practices (Developer Guide for Dynamics 365 Customer Engagement)](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/developer/best-practices-sdk?view=op-9-1)
-	[Optimize model-driven app form performance in Power Apps](https://docs.microsoft.com/powerapps/maker/model-driven-apps/optimize-form-performance)
-	[Unsupported customizations for Microsoft Dataverse (Dataverse)](https://docs.microsoft.com/powerapps/developer/data-platform/supported-customizations#unsupported-customizations)

## Use asynchronous workflows instead of synchronous

**Description:** 
System customizers write synchronous workflows to perform business logic in "real time" that execute when data is changed in Field Service. 

**Category:** 
Configuration

**Issue:** 
Running workflows synchronously will hurt performance. 

**Best practices:** 
Run workflows asynchronously. 

## Activate Field Service and Resource Scheduling out-of-the-box processes

**Description:**
Field Service and Resource Scheduling ship with many processes that perform necessary business logic.

**Category:**
Configuration & customization

**Issue:** 
Deactivated processes can lead to errors.


**Best practices:** 
Make sure all Field Service and Resource Scheduling processes are in an active state.



## Minimize custom fields

**Description:** 
System customizers add custom fields to entity forms to capture information specific to their industry and business, to run business processes, and to collect information to report on. 

**Category:** 
Configuration

**Issue:** 
Too many custom fields, especially on the first tab of the form, cause performance issues. 

**Best practices:** 
-	Minimize the number of custom fields.
-	Move custom fields to other form tabs. 



## Do not edit or remove out-of-box fields

**Description:** 
Customers edit out-of-the-box fields to accommodate their business needs. 

**Category:**
Configuration

**Issue:**
Editing out-of-the-box calculated fields or editing the option sets of out-of-the-box fields can cause errors, especially when processes depend on those field values.

**Best practices:**

Do not add, edit, remove _option set values_ for the following fields:
-	Work Order
    - System Status
    - Work Location
- Work Order Product
    -	Line status
-	Work Order Service
    - Line status

Do not edit, override, or remove the following calculated fields
-	Bookable Resource Booking
    - Start time
    - Estimated arrival time
    - Actual Arrival time
    - Duration
    - End time
-	Work Order
    - Total amount
    - Subtotal amount
    - Total Estimated Duration


Resources: 
-	[Optimize model-driven app form performance in Power Apps](https://docs.microsoft.com/powerapps/maker/model-driven-apps/optimize-form-performance)


