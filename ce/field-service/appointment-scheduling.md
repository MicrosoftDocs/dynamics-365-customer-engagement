---
title: "Appointments included in resource scheduling | MicrosoftDocs"
description: Learn how to include appointments in resource scheduling in Dynamics 365 Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/29/2021
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

With this improved way of including appointments in resource scheduling, schedulers do not face the issue of bookings and appointments being inconsistent since appointments are included directly without needing corresponding bookings. Schedulers can have accurate availability information in one place and do not have to switch between multiple tools such as Outlook, Service Calendar, and Field Service's new schedule board. This increases schedulers’ productivity and reduces avoidable scheduling errors.

## Prerequisites

- Field Service 8.8.40.x+
- Resource scheduling optimization (RSO) 3.3.0.105+, only if there is a requirement for appointments to be supported in RSO-related scheduling operations

## More details 

This April Wave 1 2021 feature adds [Microsoft Dataverse appointments](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/appointment) as an additional data source for resource scheduling. Previously the schedule board and scheduling operations used only [bookings](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/bookableresourcebooking) as a data source. Thus, if you wanted to show appointments on the schedule board or respect them in resource availability, you would first need to create corresponding bookings. This created issues when changes in bookings did not reflect in appointments and vice versa. 

Now Microsoft Dataverse appointments are included directly in resource scheduling, so there is no longer any need to have bookings automatically created for appointments and to face the issue of changes in one not reflecting in the other. 

Dataverse appointments can be created in Dynamics Apps like Customer Service Hub (in Activities), but they could also originate in Outlook, and be synced to Dynamics 365 if [server-side synchronization](https://docs.microsoft.com/en-us/power-platform/admin/server-side-synchronization) has been set up. An Outlook appointment must be manually assigned the special  [Tracked to Dynamics 365](https://docs.microsoft.com/en-us/power-platform/admin/use-outlook-category-track-appointments-emails) category  so it appears as a Dataverse appointment record. 

> [!div class="mx-imgBorder"]
> ![Screenshot of appointments added as a data source.](./media/Appointment00-BlockDiagramResized.png)

<ul>
<li>Appointments will show in read-only mode on the new schedule board, and be considered in scheduling operations from the new schedule board and resource scheduling optimization.</li>
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

## Resource level setting to include appointments in Resource Scheduling

The resource level setting will only show if the organization level setting is enabled,that is, if **Include Appointments** in **Resource Scheduling** > **Settings** > **Administration** > **Scheduling Parameters** is set to Yes. 
To control individual resources, go to the **Scheduling** tab on the resource form and change the **Include Appointments** field. 

> [!div class="mx-imgBorder"]
> ![Screenshot of resource level setting.](./media/Appointment04-ResourceLevelConfiguration.png)

## View appointments on the new schedule board

Appointments will be visible on the new schedule board for the Required Attendees and the Owner as long as they are set up as bookable resources. They are supported in all views of the new schedule board, namely the hourly, daily, weekly, and monthly views. Appointments show in a read-only format and cannot be moved on the new schedule board. The legend shows the colors for various appointment statuses. The below image shows how appointments display in hourly view. Hovering on an appointment shows more details in a card. 

> [!div class="mx-imgBorder"]
> ![Screenshot of schedule board with appointments.](./media/Appointment05-ScheduleBoard.png)

## Scheduling operations that respect appointments

Appointments with statuses Busy and Completed will be considered as unavailable by scheduling operations. 

For customers with resource scheduling optimization, appointments will be respected in both non-interactive and interactive optimizations. Non-interactive optimizations are triggered when an optimization schedule is run. Interactive optimizations are triggered from the new schedule board, from **Optimize Schedule** (by right-clicking on a resource), and the **Suggest resources (Preview)**, and **Book resources (Preview)** buttons that appear when a requirement is selected in the bottom grid. 
For customers without resource scheduling optimization, Schedule Assistant is expected to launch in October Wave 2 2021. Meanwhile, the Schedule Assistant APIs for both requirements and requirement groups do support appointments should customers want to leverage these for a custom web app or a Dynamics 365 portal or a Power Apps canvas app to support appointment scheduling scenarios. 

## Customize appointment colors 

The new schedule board uses the colors defined in [Dataverse Appointment](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/appointment) entity  metadata. Customizing the **Color** metadata of each of the **StatusCode** option set values will change the Appointment colors that show on the new schedule board.  

## Hide canceled appointments

If you do not wish to see canceled appointments on the new schedule board, note that the **Hide Canceled** tab-level setting accessible from the old schedule board will hide both canceled bookings and canceled appointments on the new schedule board. 
Go to the old schedule board using the toggle in the top right. Open the tab and select the gear icon in the top right of the schedule board. Check the **Hide Canceled** checkbox, and toggle back to the new schedule board. 

> [!div class="mx-imgBorder"]
> ![Screenshot of Hide Canceled tab setting in old schedule board.](./media/Appointment06-HideCanceledAppointment.png)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
