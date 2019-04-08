---
title: "Schedule with travel time | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/08/2019
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

# Schedule with travel time


## Prerequisites
- connect to maps
- geocoding
- resources with locations
- requirements with locations
  - work location is on site

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## instructions

- Add travel when manually scheduling
  - show travel time on schedule board
  - actual travel duration
- Use travel time with schedule assistant
- travel time with resource scheduling optimization
  - leave time to travel home

- consider traffic
  - display traffic on the schedule board
  - real time traffic is not supported
  - bing maps api cna use histroical information

## Configuration considerations
- travel charge
- real time location travel time
## Additional Notes
- consider processes to support what happens if travel time is long and technician is running late
- travel time is only driving time, not walking or flying
- historical travel time is currently not included
- can use other map services for travel time calculations
