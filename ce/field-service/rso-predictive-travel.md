---
title: "Predictive travel times | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 07/27/2020
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

# Enable predictive travel times

// https://msit.microsoftstream.com/video/e705a1ff-0400-a521-da10-f1eacde0b7de?channelId=0bf6f71a-b361-4d7b-9668-62ff5207b60d

## Prerequisites
Connect to Maps
Deploy RSO

> [!Note]
>


## Set Travel Time Calculation on Optimization Goal


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-predictive-travel-range.png)

## Set Range duration to 1 day or less on Optimization Scope


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-predictive-travel-flag.png)

## Run RSO

## Configuration considerations
- Scope under nder 500 requirements and 500 resources 
- overnight scheduling is recommended
- compatible with SRO but not recommended
- RSO only. not available with schedule assistant or manual scheduling
- Custom Map provider

## Additional Notes
- this feature can result in different travel times and different squences of schedules
- performance cost
- not realtime 


