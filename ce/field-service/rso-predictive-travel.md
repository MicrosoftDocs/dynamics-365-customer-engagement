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

- Connect to Maps set to Yes in 
- Deploy RSO
- Configure RSO

## Set Travel Time Calculation on Optimization Goal

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-predictive-travel-flag.png)




## Set Range duration to 1 day or less on Optimization Scope

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-predictive-travel-range.png)


## Run RSO

After adding predictive travel to the Optimization Goal and adjusting the Optimization Scope to be less than or equal to 1 day, the next step is to Run RSO either manually, per a schedule, or via a workflow.

Without predicitve travel times

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-predictive-travel-schedule-without.png)

With predicitve travel times - the eastimated travel times are recalculated and the order of the bookings may change to optimze the objectives and constraints of the related RSO Optimization Goal typically to minimize travel times.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-predictive-travel-schedule-with.png)


> [!Note]
> Running RSO with predictive 

## Configuration considerations

- It is recommended to use predictive travel times for automated [overnight scheduling](link) where RSO is run during non working horus for the following working day.

- Predictive travel time can be applied to Optimization Scopes with less than 500 requirements _and_ 500 resources during Early Access. If your Optimization Scope exceeds this threshold RSO will still run but without predictive travel times. If you have more resources or requirements it is recommended to split the scope into smaller scopes and apply predictive travel time to each related Optimization Goal.

- Predit
- RSO only. not available with schedule assistant or manual scheduling
- Custom Map provider

## Additional Notes
- this feature can result in different travel times and different squences of schedules
- performance cost
- not realtime 


