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

## General

### Map Settings

Map settings provides the user a way to specify various details views and panels of the s006301hedule board. To get to these settings, either double-click the schedule board title tab or select Open Tab Settings from the board’s settings.
> [!div class="mx-imgBorder"]
> ![Screenshot of Tab settings - map settings](./media/tab-settings-map-settings.png)
 
Map View Tab Placement
When setting Map View Tab Placement to Filter Pane, the map will be placed on the left-hand side, allowing a scheduler to see both the map and the details of the selected object.

> [!div class="mx-imgBorder"]
> ![Screenshot of Map View Tab Placement – Filter Pane](./media/map-view-tab-placement-filter-pane.png)
 
When setting Map View Tab Placement to Details Pane, the map will be placed on the right-hand side, allowing a scheduler to see both the filter and the map at the same time.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of Map View Tab Placement – Details Pane](./media/map-view-tab-placement-details-pane.png)
 

Resource Tooltips View
This view allows a dispatcher to specify the resource attributes that should be shown in the resource tooltip on the map. The setting lists views that are based on the Bookable Resource entity, only public views are available for selection. Even though you can change existing views, it is better practice to copy the default view and apply changes to the copy. The tooltip appears when you hover over a resource pin on the map.

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource Tooltips View](./media/resource-tooltips-view.png)

Organizational Unit Tooltips View
This view allows a dispatcher to specify the organizational unit attributes that should be shown in the respective tooltip on the map. The setting lists views that are based on the Organizational Unit entity, only public views are available for selection. Even though you can change existing views, it is better practice to copy the default view and apply changes to the copy. The tooltip appears when you hover over an organizational unit pin on the map.

> [!div class="mx-imgBorder"]
> ![Screenshot of Organizational Unit Tooltips View](./media/organizational-unit-tooltips-view.png)
 

Requirement Filter View
This view controls which resource requirement records are shown on the map. The setting allows you to pick every view that is based on the Resource Requirement entity. Only public views are available for selection, resource requirements need to have a latitude and longitude to display it on the map. Again, as a best practice copy the default view and apply changes to the copy.
Resource Details View
This view allows a dispatcher to specify the resource attributes that should be shown in the details pane. The setting lists views that are based on the Bookable Resource entity, only public views are available for selection. The details pane is populated when you select a resource pin on the map.

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource Details View](./media/resource-details-view.png)
 

Organizational Unit Details View
This view allows a dispatcher to specify the organizational unit attributes that should be shown in the details pane. The setting lists views that are based on the Organizational Unit entity, only public views are available for selection. The details pane is populated when you select an organizational unit on the map.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of Organizational Unit Details View](./media/organizational-unit-details-view.png)
 



## Prerequisites
> [!Note]
>



## Configuration considerations
## Additional Notes