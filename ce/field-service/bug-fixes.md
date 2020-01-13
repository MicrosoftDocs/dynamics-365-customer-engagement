---
title: "Bug fixes for Dynamics 365 Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/05/2019
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

# Bug fixes

In this article, you'll find an ongoing list of bug fixes for Dynamics 365 Field Service, Resource Scheduling (RS), Field Service Mobile, Resource Scheduling Optimization (RSO), and Connected Field Service (CFS). For information about other updates to Field Service, visit the [Dynamics 365 Release Plans](https://docs.microsoft.com/dynamics365/release-plans/). 

## Dynamics 365 Field Service

### Version 8.8.8.50

- Improve error messages when the user attempting an action is missing "Field Service Setting" read privilege.
- Form logic always turns Incident Type to not required based on Work Order Type, regardless of field settings.
- Bookings are not shared consistently to all resources on multi-booking Work Orders.
- Deleting and recreating a Booking associated with a Work Order changes the shared users of Booking.
- TypeError: Cannot read property 'getDefaultView' when Requested by Contact field removed from RMA form.
- Agreement Invoice Product Currency Set to Base Currency - should be set to Agreement's Pricelist Currency.
- See this blog post for more information.

### Version 8.8.7.47

-	Removal of Territory from Work Order is not removed from non-primary related requirements.
-	Inappropriate command buttons shown for Opportunity, Quote, and Order Product and Service-based Lines Sub Grids.
-	Field Service Resource privilege exception on create and save of Time Off Request.
  
### Previous versions of Field Service

To see older bug fixes, see the following links to blog posts:  

- [8.8.3.533](https://cloudblogs.microsoft.com/dynamics365/it/2019/09/10/enhancements-and-bug-fixes-for-field-service-version-8-8-3-533/)
- [8.8.2.160](https://cloudblogs.microsoft.com/dynamics365/it/2019/08/11/enhancements-and-bug-fixes-for-field-service-version-8-8-2-160/)
- [8.8.1.45](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/07/enhancements-and-bug-fixes-for-field-service-version-8-8-1-45/)
- [8.8.0.88](https://cloudblogs.microsoft.com/dynamics365/it/2019/06/10/release-notes-for-field-service-version-8-8-0-88/)
- [8.7.0.105](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/06/release-notes-for-field-service-version-8-7-0-105/)
- [8.6.0.274](https://cloudblogs.microsoft.com/dynamics365/it/2019/04/06/release-notes-for-field-service-version-8-6-0-274/)
- [8.5.0.345](https://cloudblogs.microsoft.com/dynamics365/it/2019/03/07/release-notes-for-field-service-version-8-5-0-345/)
- [8.4.0.338](https://cloudblogs.microsoft.com/dynamics365/it/2019/02/11/release-notes-for-field-service-version-8-4-0-338/)
- [8.3.0.255](https://cloudblogs.microsoft.com/dynamics365/it/2018/12/21/release-notes-for-field-service-version-8-update-release-3/)
- [8.2.0.286](https://cloudblogs.microsoft.com/dynamics365/it/2018/11/08/release-notes-for-field-service-version-8-update-release-2/)
 
- [7.5.13.73](https://cloudblogs.microsoft.com/dynamics365/it/2019/09/10/enhancements-and-bug-fixes-for-field-service-version-7-5-13-73/)
- [7.5.12.53](https://cloudblogs.microsoft.com/dynamics365/it/2019/08/06/enhancements-and-bug-fixes-for-field-service-version-7-5-12-53/)
- [7.5.11.102](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/07/enhancements-and-bug-fixes-for-field-service-version-7-5-11-102/)
- [7.5.10.235](https://cloudblogs.microsoft.com/dynamics365/it/2019/06/10/release-notes-for-field-service-version-7-5-10-235/)
- [7.5.9.91](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/06/release-notes-for-field-service-version-7-5-9-91/)
- [7.5.8.93](https://cloudblogs.microsoft.com/dynamics365/it/2019/04/06/release-notes-for-field-service-version-7-5-8-93/)
- [7.5.7.87](https://cloudblogs.microsoft.com/dynamics365/it/2019/03/07/release-notes-for-field-service-version-7-5-7-87/)
- [7.5.6.97](https://cloudblogs.microsoft.com/dynamics365/it/2019/02/04/release-notes-for-field-service-version-7-5-6-97/)
- [7.5.5.48](https://cloudblogs.microsoft.com/dynamics365/it/2018/12/05/release-notes-for-field-service-version-7-update-release-11/)
- [7.5.4.51](https://cloudblogs.microsoft.com/dynamics365/it/2018/11/08/release-notes-for-field-service-version-7-update-release-10/)
- [7.5.0.60](https://cloudblogs.microsoft.com/dynamics365/it/2018/05/08/release-notes-for-field-service-and-project-service-automation-update-release-5-2/)
- [7.4.1.31](https://cloudblogs.microsoft.com/dynamics365/it/2018/04/03/release-notes-for-field-service-and-project-service-automation-update-release-5/)
- [7.4.0.74](https://cloudblogs.microsoft.com/dynamics365/it/2018/02/22/release-notes-for-field-service-and-project-service-automation-update-release-4/)
- - [7.2.0.43](https://cloudblogs.microsoft.com/dynamics365/it/2017/12/05/release-notes-for-field-service-and-project-service-automation-update-release-2/)
- - [7.1.0.33](https://cloudblogs.microsoft.com/dynamics365/it/2017/10/18/release-notes-for-october-update-for-field-service-and-project-service-automation/)
 
- [6.2.3.24](https://cloudblogs.microsoft.com/dynamics365/it/2018/01/26/release-notes-for-field-service-and-project-service-automation-update-5/)
- [6.2.2.13](https://cloudblogs.microsoft.com/dynamics365/it/2017/10/31/dynamics-365-for-field-service-and-project-service-automation-update-4/)
- [6.2.1.38](https://cloudblogs.microsoft.com/dynamics365/it/2017/07/14/dynamics-365-for-field-service-and-project-services-automation-update-3/)
- [6.2](https://cloudblogs.microsoft.com/dynamics365/it/2017/05/19/dynamics-365-for-field-service-and-project-services-automation-february-2017-updates/)


  

## Resource Scheduling (RS) 

[!INCLUDE[urs-bug-fixes.md](../shared/urs/urs-bug-fixes.md)]
  

## Resource Scheduling Optimization (RSO)

### Version 3.0.19316.2

- ConsiderTravelTime parameter for SA API msdyn_SearchResourceAvailability is not working as expected
   - Create a resource requirement with 4 hours duration, and location = Onsite 
   - Create a resource A with 4 hours available hour on his calendar, make sure there is few mins travel time between the location between resource and requirement
   - Use msdyn_SearchResourceAvailability with ConsiderTravelTime parameter set to false, and to find availability for this requirement 
- Before: no potential bookable slot returned; now there is potential bookable slot return from resource A since resource A has enough available hours 
- RSO Booking Details -> Operation Details field doesn't show message anymore if RSO application user missing FS-admin security role
- Booking status form showing false Scheduling Method when first time open after setup fresh RSO environment
- Fixed upgrade issue from RSO v3.0.18341.1 to latest in-market version

### Previous versions of Resource Scheduling Optimization

To see older bug fixes, see the following links to blog posts: 

- [3.0.19263.1](https://cloudblogs.microsoft.com/dynamics365/it/2019/10/03/whats-new-in-dynamics-365-resource-scheduling-optimization-version-3-0-19263-1/)
- [3.0.19109.3](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/whats-new-for-dynamics365-resource-scheduling-optimization-v3-0-update-release/)
- [2.8](https://cloudblogs.microsoft.com/dynamics365/it/2018/10/16/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-8-release/)
- [2.7](https://cloudblogs.microsoft.com/dynamics365/it/2018/08/16/whats-new-in-the-dynamics-365-resource-scheduling-optimization-version-2-7-release/)
- [2.6](https://cloudblogs.microsoft.com/dynamics365/it/2018/05/09/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-6-release/)

