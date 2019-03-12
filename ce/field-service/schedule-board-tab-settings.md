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
> Users with Field Service - Administrator, Field Service - Dispatcher, and Field Service - Resource security roles can edit schedule board tab settings of schedule boards they create or are shared with them specifically meaning the shared with = everyone or specific people AND the schedule board is shared with their user.

who can access schedule board tab settings?

fs admin cannot edit sb tab setttings of tabs they did not create even if shared with everyone

fs admin, dispatchers, and resource role users can only edit sb tab settings of tabs they create or are shared with them specifically (meaning shared with = everyone or specific people AND the board is shared with their user)

system administrators can view and edit all sb tab settings for all non private (boards where shared with is not "Just Me") schedule board tabs


Open Default settings

Reset to Default

## General

### Map Settings

The Map Settings section allows you specify the placement of the map and the views displayed when selecting or hovering over map records.

> [!div class="mx-imgBorder"]
> ![Screenshot of Tab settings - map settings](./media/tab-settings-map-settings.png)
 
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
 




## Configuration considerations
- map requirements affected by territory filter


## Additional Notes
- moving schedule board tab settings to other orgs 