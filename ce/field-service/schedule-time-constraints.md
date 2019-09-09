---
title: "Schedule with time constraints | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 08/29/2019
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

# Schedule within time constraints

When scheduling a work order, case, quote, or any entity enabled for scheduling, you can set date and time parameters to control when the requirement is booked.

This includes scheduling the requirement:
- between two defined dates. Example: between 9/10/2019 and 9/15/2019

On the Work Order form you can add date and time values in the preference section:

**Time from promised** and **Time to promised** -

**Date window start** and **Date window end** - 

**Time window start** and **Time window end** 

These fields are passed along to the related resource requirement 

Booking rules

time zone

## Prerequisites
> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Configuration considerations
- booking lock options
- SLAs
- Fulfillment preferences
- From date and to date on booking setup metadata
## Additional Notes
- cannot handle scenario where customer is only available mon, wed, fri 9-12pm. can add this as a note or use a booking rule, but this only applies to Schedule board
- could have date window start/end mon-fri and use time windows for 9-5. if not scheduled by end of the week use workflow to make it next week.