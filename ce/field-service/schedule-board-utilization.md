---
title: "Resource Utilization on the Schedule Board | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 07/01/2019
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
ms.author: dabur
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Resource utilization on the schedule board

It is important for dispatchers and service managers 
Each resource's utilization is displayed on the schedule board

## Prerequisites

> [!Note]
>



Utilisation % is derived from:
Total Booked Hours / Total Work Hours Available

Total Booked Hours = The sum of the hours booked to that resource
Total Work Hours Available = The sum of the Work Hours available to that resource

Behaviour

In the Schedule Board, the utilisation value changes with the timeframe defined in the View Mode:

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

This is because the View Mode timeframe changes the Total Work Hours Available that are visible on the schedule board.

Examples

Example 1: 
In the Hourly View, the Total Work Hours Available will be the sum of the hours seen on the Schedule Board as you scroll from the far left to the far right. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)
 
In the example above, Erik works a 12 hour shift from 9AM to 9PM, this shift is repeated for 5 days shown as the user scrolls from left to right across the schedule board.
Therefore, Erik’s Total Work Hours Available in this Hourly View are 12 * 5 = 60.
If Erik is booked a single 6 hour Work Order, then his Utilisation is 6 / 60 = 10%, as shown in his resource card.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


If the duration of that Work Order is increased to 12 hours, then his Utilisation is 12 / 60 = 20%, as shown in his resource card below.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


Example 2:
In the Daily View, as per Example 1, the Total Work Hours Available will be the sum of the hours seen on the Schedule Board.
In this case we see 10 days, so Erik’s Total Work Hours Available are 12 * 10 = 120
Erik already has a 12 hour booking for one day, so his Utilisation % is 12 / 120 = 10%
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)



## Configuration considerations
## Additional Notes