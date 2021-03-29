---
title: "Appointments included in resource scheduling | MicrosoftDocs"
description: Learn how to include appointments in resource scheduling in Dynamics 365 Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 29/03/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: salehasiddique-msft
ms.author: salsiddi
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Appointments included in resource scheduling

With this improved way of including appointments in resource scheduling, schedulers do not face the issue of bookings and appointments being inconsistent since appointments are included directly without needing corresponding bookings. Schedulers can have accurate availability information in one place and do not have to switch between multiple tools such as Outlook, Service Calendar and Field Service's new schedule board. This increases schedulers’ productivity and reduces avoidable scheduling errors.

## Prerequisites

- Field Service 8.8.40.x+

## Additional details 

This feature adds [Microsoft Dataverse appointments](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/appointment) as an additional data source for resource scheduling. Previously the schedule board and scheduling operations used only [bookings](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/bookableresourcebooking) as a data source. Thus, if you wanted to show appointments on the schedule board or respect them in resource availability, you would first need to create corresponding bookings. This created issues when changes in bookings did not reflect in appointments and vice versa. 

Now Microsoft Dataverse appointments are included directly in resource scheduling, so there is no longer any need to have bookings automatically created for appointments and to face the issue of changes in one not reflecting in the other. 

Dataverse appointments can be created in Dynamics Apps like Customer Service Hub (in Activities), but they could also originate in Outlook, and be synced to Dynamics 365 if [server-side synchronization](https://docs.microsoft.com/en-us/power-platform/admin/server-side-synchronization) has been set up. An Outlook appointment must be manually assigned the special  [Tracked to Dynamics 365](https://docs.microsoft.com/en-us/power-platform/admin/use-outlook-category-track-appointments-emails) category  so it appears as a Dataverse appointment record. 

> [!div class="mx-imgBorder"]
> ![Screenshot of appointments added as a data source.](./media/Appointment00-BlockDiagramResized.png)

<ul>
<li>Appointments will show in read-only mode on the new schedule board, and be considered in scheduling operations from the new schedule board and resource scheduling optimization, in conjunction with bookings.</li>
<li>Scheduling operations will consider appointments as location-agnostic.</li>
<li>If an appointment had related bookings those bookings will not be shown and will not be considered in scheduling operations. </li>
<li>This feature has an organization level setting, which turns on the feature for all resources. You can control individual resources using a resource level setting.</li>
</ul>

## Organization level setting to include appointments in Resource Scheduling


1. Go to **Resource Scheduling** > **Settings** > **Administration** > **Scheduling Parameters** and set **Include Appointments** to Yes.

> [!div class="mx-imgBorder"]
> ![Screenshot of organization level setting.](./media/Appointment01-OrgLevelConfiguration.png)

2. An informational dialog will subsequently appear. Click the **Got it. Let’s enable button.** Save and close. 

> [!div class="mx-imgBorder"]
> ![Screenshot of organization level setting.](./media/Appointment02-Dialog.png)

All resources are automatically opted in the first time you enable the feature. You may opt out resources using the resource level setting, which is visible only if the organization level setting is set to Yes.  

### Including appointments turns off the deprecated configuration to automatically create bookings when an appointment is created

If your organization was configured to automatically create bookings when an appointment is created, the informational dialog will let you know that the system will be turning off this setting, as appointments will be included directly in resource scheduling, without needing related bookings. You should only enable the feature if you do not have custom actions and/or workflows on the related bookings. 

You may further verify that the deprecated configuration has been turned off, by going to **Settings** > **Administration** > **System Settings** > **Calendar** and checking that **Scheduling Engine** is set to **(Default) Scheduling Engine**

> [!div class="mx-imgBorder"]
> ![Screenshot to verify deprecated configuration has been turned off.](./media/Appointment03-DeprecatedFeatureIsOff.png)



[!INCLUDE[footer-include](../includes/footer-banner.md)]
