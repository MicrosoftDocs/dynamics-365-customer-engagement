---
title: "Schedule Board Tab Settings | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/11/2019
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
ms.author: LXHeinze
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Schedule Board Tab Settings

Schedule board tab settings allow you to define the layout and functions of schedule board tabs.

There are three ways to access a particular schedule board's tab settings:  

1. double click the name of the schedule board tab 
2. while viewing the schedule board tab, click the gear icon in the top right of the schedule board
3. while viewing the schedule board tab, choose the **settings icon > Open Tab Settings**

> [!div class="mx-imgBorder"]
> ![Screenshot of accessing schedule board tab settings](./media/schedule-board-tab-settings-access.png)


**Name:** this field dictates the name displayed at the top of the schedule board

**Shared With:** decides which users can view the schedule board tab
- Everyone
- Specific People - after choosing this option, you can select the specific people to share the schedule board with by doing an Advanced Find of the **Schedule Board Settings** entity and sharing the related schedule board record with the specific users  
- Just Me

> [!Note]
> Users with **Field Service - Administrator**, **Field Service - Dispatcher**, and **Field Service - Resource** security roles can edit schedule board tab settings of schedule boards they create or are shared with them specifically meaning the **Shared With** field = Everyone or Specific People AND the schedule board is shared with their user.

> [!div class="mx-imgBorder"]
> ![Screenshot of Tab settings - map settings](./media/tab-settings-map-settings.png)


**Open Default Settings:** Lets you choose the default tab settings when new Schedule Boards are created. When values in a particular Schedule Board Tab Setting display **< Default View >**, this means the value is coming from the default tab settings. As in the image below, when the **Open Default Settings** button is selected, the **< Default View >** values are replaced by the actual values and you are now editing default schedule board tab settings.


> [!div class="mx-imgBorder"]
> ![Screenshot of Default Tab settings](./media/schedule-board-tab-settings-default.png)

**Reset to Default:** Selecting this button will reset the current tab setting values to the values outlined in the default settings.

## General

### Map Settings

The Map Settings section allows you specify the placement of the map and the views displayed when selecting or hovering over map records.

 
**Map View Tab Placement**

When set to **Filter Pane**, the map will be placed on the left-hand side. This allows schedulers to see both the map and the details of the selected record at the same time.

> [!div class="mx-imgBorder"]
> ![Screenshot of Map View Tab Placement – Filter Pane](./media/map-view-tab-placement-filter-pane.png)
 
When set to **Details Pane**, the map will be placed on the right-hand side. This allows schedulers to see both the filter pane and the map at the same time. 
 
> [!div class="mx-imgBorder"]
> ![Screenshot of Map View Tab Placement – Details Pane](./media/map-view-tab-placement-details-pane.png)
 
**Requirement Map Filter View**

This view dictates the resource requirement records displayed on the map. The setting lists public views related to the Resource Requirement entity for selection. Resource requirements need to have a latitude and longitude to display it on the map. Again, as a best practice copy the default view and apply changes to the copy.


**Resource Tooltips View**

This view dictates the fields displayed in a tooltip that appears when a scheduler hovers over a resource map pin. The setting lists views that are based on the Bookable Resource entity, only public views are available for selection. Even though you can change existing views, it is a better practice to copy the default view and apply changes to the copy.

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource Tooltips View](./media/resource-tooltips-view.png)

**Resource Details View**

This view dictates the fields displayed in the details pane when a resource map pin is selected. The details pane is on the right-hand side of the schedule board and may have to be expanded. The setting lists public views related to the Bookable Resource entity for selection. 

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource Details View](./media/resource-details-view.png)


**Organizational Unit Tooltips View**

This view dictates the fields displayed in a tooltip that appears when a scheduler hovers over a organizational unit map pin. The setting lists public views related to the Organizational Unit entity for selection. Even though you can change existing views, it is a better practice to copy the default view and apply changes to the copy.

> [!div class="mx-imgBorder"]
> ![Screenshot of Organizational Unit Tooltips View](./media/organizational-unit-tooltips-view.png)


**Organizational Unit Details View**

This view dictates the fields displayed in the details pane when an organizational unit map pin is selected. The details pane is on the right-hand side of the schedule board and may have to be expanded. The setting lists public views related to the Organizational Unit entity for selection.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of Organizational Unit Details View](./media/organizational-unit-details-view.png)
 

### Custom Web Resource

Web resources represent files that can be used to extend the Microsoft Dynamics 365 web application such as html files, JavaScript, and Silverlight applications. This section allows you to utilize web resources from the schedule board, which can help dispatchers perform more functions and increase utilization. 

**Tab Name:** The chosen web resource will be displayed in the details pane on the right-hand side of the schedule board. A new tab with the name entered here will appear next to the alerts tab. In the example image below, "Web Resource" was entered for the tab name.

**Web Resource:** Select a web resource from your dynamics 365 organization.

> [!div class="mx-imgBorder"]
> ![Screenshot of Organizational Unit Details View](./media/schedule-board-tab-settings-web-resource.png)

### Schedule Board Colors

The colors chosen in this section only apply to the Days, Weeks, and Months views of the schedule board and represent resources' utilization. Utilization is calculated as the hours booked compared to working hours for the schedule board time range. 

In the image below is a Days view of the schedule board where each resource works 12 hours each day and the range is 2 days. 
> [!div class="mx-imgBorder"]
> ![Screenshot of schedule board colors](./media/schedule-board-tab-settings-schedule-board-colors.png)

### Schedule Assistant

**Search For:** This setting decides the default value for the Search for field in the schedule assistant filter pane. Set to **All resources** to search for all applicable resources in the system that meet the schedule assistant filters for the requirement. Set to **Resources visible on board** to search for resources that meet the schedule assistant filters for that requirement AND meet the current schedule board resource filters (are visible on the schedule board the schedule assistant was triggered from). This schedule assistant filter value can still be manually changed by the dispatcher at the time of scheduling. If a scheduler is responsible for a specific schedule board and specific resources, then the **Resources visible on board** is recommended because this ensures the scheduler cannot schedule requirements to other resources he or she is not responsible for. For smaller organizations or organizations with less rigid resource and line of business divisions, the **All resources** setting will allow schedulers to search across all applicable resources across the entire organization. 

**Unavailable Resources:** This setting decides how unavailable resources appear when the schedule assistant is triggered. Set to **Unavailable resources do not appear** to have resources that do not meet schedule assistant filter criteria to temporarily be removed from the view of available resources to schedule to. Set to **Unavailable resources appear dimmed (when searching for resources visible on board)** to have resources that do not meet schedule assistant filter criteria to remain on the schedule board but appear dimmed. For schedule boards with many resources, using the **Unavailable resources do not appear** setting can reduce the need to scroll and make it easier for scheduler to compare available resources.

**Book Based On:** Though booking an on site requirement (typically a work order) will always have a total duration = travel time + requirement duration, this setting changes the schedule assistant visualization to make it easier to understand when travel time starts and when the estimated arrival time is. Set to **Start of Travel** to visualize the booking start as when travel begins. Set to **Estimated Arrival** to visualize the booking start as when the resource is estimated to arrive on site. One consideration is whether the scheduler is communicating with the customer in real time over the phone because customers are typically more interested in when the resource will arrive at their location, and therefore administrators should make it easier for the scheduler to communicate this time by selecting the **Estimated Arrival**.

## Additional Notes
- moving schedule board tab settings to other orgs 