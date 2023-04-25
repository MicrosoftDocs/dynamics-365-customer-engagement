---
title: Dynamics 365 Field Service (Preview) overview
description: Learn how to create work orders in Outlook.
ms.date: 04/24/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Create a new work order in Outlook

Once opened, the add-in will show a list of suggested actions. One of these actions is the "Create a work order" action.

## Work order fields

- [System Status](https://learn.microsoft.com/en-us/dynamics365/field-service/work-order-status-booking-status) (required, defaulted to *Unscheduled*)
- Priority
- Service Account (required)
- Work Order Type (required)
- Primary Incident Type 
- Price List (required)
- Description
- Time From Promised
- Time To Promised

To cancel, click the back button.

To learn more about these fields, view the Dynamics 365 Field Service documentation...

## Save the work order to D365 Field Service

Pressing the **Save** button will create the work order. A confirmation banner will display indicating the work order has been successfully created. 
Screenshot of work order confirmation

> [!WARNING]
> Data will not be saved until the *Save* button is clicked 

Once saved in Outlook, the work order is created and automatically synced with Dynamics 365 Field Service. 
Screenshot of Dynamics 365 Field Service

## Edit the created work order

If any data is incorrectly filled, the work order can be edited from the next screen...
Screenshot of Dynamics 365 Field Service