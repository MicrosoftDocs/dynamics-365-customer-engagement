---
title: "Resource scheduling optimization version history | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 07/20/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Resource scheduling optimization version history

## 3.1.3.17

- Fixed bug where 'Created On' field in optimization panel of resource scheduling optimization schedule board does not respect date format of user setting. 
- Fixed issue where optimization request status was not set correctly when resource scheduling optimization is run as a simulation. 


## 3.0.19316.2

- ConsiderTravelTime parameter for SA API msdyn_SearchResourceAvailability is not working as expected. Use the following steps to understand the impact of this bug fix:
  - Create a resource requirement with four hours duration, and location set to **Onsite**. 
  - Create a resource A with four hours available hour on their calendar; make sure there are a few minutes travel time between the location between resource and requirement.
  - Use msdyn_SearchResourceAvailability with the ConsiderTravelTime parameter set to false, and to find availability for this requirement. Before this, no potential bookable slot was returned; now there is potential bookable slot returned from resource A since resource A has enough available hours.
- Resource scheduling optimization booking details: **Operation Details** field doesn't show message anymore if user is missing the Field Service - Administrator security role.
- Booking status form showing false scheduling method the first time resource scheduling optimization is opened after initial setup.
- Fixed upgrade issue from resource scheduling optimization v3.0.18341.1 to latest in-market version.

## 3.0.19263.1

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/10/03/whats-new-in-dynamics-365-resource-scheduling-optimization-version-3-0-19263-1/)

## 3.0.19109.3

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/whats-new-for-dynamics365-resource-scheduling-optimization-v3-0-update-release/)

## 2.8

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/10/16/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-8-release/)

## 2.7

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/08/16/whats-new-in-the-dynamics-365-resource-scheduling-optimization-version-2-7-release/)

## 2.6

[2.6](https://cloudblogs.microsoft.com/dynamics365/it/2018/05/09/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-6-release/)
