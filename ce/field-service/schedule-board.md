---
title: "New Schedule Board (Preview) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2020
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

// Use podcast video for details: https://msit.microsoftstream.com/video/e2244efa-a845-4351-8acd-52ca80497789?channelId=0bf6f71a-b361-4d7b-9668-62ff5207b60d

Will exist alongside current schedule board until feature parity is reached in which case it will replace it.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-new.png)

Benefits:
- performance 
- usability and accessability 
- Foundation for new capabilities for multi-day scheduling and intelligent interactions

### Performance

(load times, drag and drop)

eventing

### Usability and accessiblity

- better support for different sized form factors
- new color scheme, booking and travel representation
- ghost booking - know if fit before scheduling

unified interface

### Foundation for new capabilities

## Prerequisites

Public preview April 2020

> [!Note]
> More 



## Enable new Schedule Board preview

log in as a system administrator

Go to **Resource Scheduling app > Settings > Administration > Customize Schedule Board settings**

Go to Controls tab

Choose add control and add **Schedule Board Preview** control.

Enable it for web experience

Select the edit button then enable preview


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

## Additional Notes

pcf Control

react fabric office fabric components

### Implementing new schedule board
- use for simple scheduling
