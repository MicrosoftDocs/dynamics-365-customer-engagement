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

Accessing Schedule Board tab settings- To get to these settings, either double-click the schedule board title tab or select Open Tab Settings from the board’s settings.

who can access schedule board tab settings?

Name:

Shared With:

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
 

**Resource Tooltips View**

This view dictates the fields displayed in a tooltip that appears when a scheduler hovers over a resource map pin. The setting lists views that are based on the Bookable Resource entity, only public views are available for selection. Even though you can change existing views, it is a better practice to copy the default view and apply changes to the copy.

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource Tooltips View](./media/resource-tooltips-view.png)

**Organizational Unit Tooltips View**

This view dictates the fields displayed in a tooltip that appears when a scheduler hovers over a organizational unit map pin. The setting lists public views related to the Organizational Unit entity for selection. Even though you can change existing views, it is a better practice to copy the default view and apply changes to the copy.

> [!div class="mx-imgBorder"]
> ![Screenshot of Organizational Unit Tooltips View](./media/organizational-unit-tooltips-view.png)
 

**Requirement Filter View**

This view dictates the resource requirement records displayed on the map. The setting lists public views related to the Resource Requirement entity for selection. Resource requirements need to have a latitude and longitude to display it on the map. Again, as a best practice copy the default view and apply changes to the copy.

affected by territory filter

**Resource Details View**

This view allows a dispatcher to specify the resource attributes that should be shown in the details pane on the right-hand side of the schedule board. The setting lists public views related to the Bookable Resource entity for selection. The details pane is populated when you select a resource pin on the map.

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource Details View](./media/resource-details-view.png)
 

**Organizational Unit Details View**

This view allows a dispatcher to specify the organizational unit attributes that should be shown in the details pane. The setting lists views that are based on the Organizational Unit entity, only public views are available for selection. The details pane is populated when you select an organizational unit on the map.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of Organizational Unit Details View](./media/organizational-unit-details-view.png)
 



## Prerequisites




## Configuration considerations
## Additional Notes
- moving schedule board tab settings to other orgs 