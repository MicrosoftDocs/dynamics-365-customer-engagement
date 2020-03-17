---
title: "New Schedule Board (Preview) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/17/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# New Schedule Board (Preview)

A new and redesigned schedule board is available as a public preview in the April 2020 release of Dynamics 365 Field Service. Learn how to [enable the new schedule board in your environment](https://docs.microsoft.com/dynamics365/field-service/schedule-board#Enable-new-Schedule-Board-preview) below.

The new schedule board has faster performance, improvements to usability, and lays the foundation for new capabilities for multi-day scheduling and intelligent interactions.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-new.png)


### Performance

Dispatchers will find loading the schedule board and common actions like selecting schedule board tabs, dragging and dropping work orders, and rescheduling bookings is much faster and more repsonsive.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-new-accessability.png)



### Usability and accessiblity

The new schedule board is also a PowerApps Component Framework (PCF) control built on the Unified Client Interface making it more flexible, supportable, and accessable. The new schedule board will work better on different sized screens and form factors. New color schemes and ways of depicting travel time make it easierfor dispatchers to see statuses and details.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-new-drag.png)

The image above shows a new "ghost booking" feature that helps dispacthers know if a booking will fit into a schedule before it is even scheduled.

### Foundation for new capabilities

Updates to the new schedule board lay the foundation for future releases that will provide dispatchers insights and recommended actions to improve schedules.

## Prerequisites

> [!Note]
> The new schedule board is released as a public preview in April 2020. It has limited capabilities during the preview period. 

After enabling, it will appear in your envornment alongside the current schedule board. Once the new shcedule board functionality matches the current schedule board, it will replace it. 

Users who perform simple drag and drop scheduling or users who only need to view the schedule board can use the new schedule board during preview. Other users should continue to use the current schedule board.

Public preview April 2020

> [!Note]
> More 



## Enable new Schedule Board preview

log in as a system administrator

Go to **Resource Scheduling app > Settings > Administration > Customize Schedule Board settings**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-new-admin.png)

Go to Controls tab

Choose add control and add **Schedule Board Preview** control.

Enable it for web experience

Select the edit button then enable preview



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-new-enable-preview-pcf-control.png)


**Optional:** choose a default schedule board either the current or new preview one.

Publish changes

Use the toggle button in the top right of the schedule board to switch between the current and preview schedule boards. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-new-enable-preview.png)

## Configuration considerations
Continue to use the current schedule board for common functions like:
- schedule board tab settings
- Map visualization
- days weeks and months view

### Implementing new schedule board
- use for simple scheduling
