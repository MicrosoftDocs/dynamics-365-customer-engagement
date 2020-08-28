---
title: "Frequently asked questions for Dynamics 365 Field Service mobile Power App | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 08/27/2020
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

# Frequently asked questions for Dynamics 365 Field Service mobile Power App

## Can I only add and view Field Service entities on Field Service (Dynamics 365)?

Because Field Service (Dynamics 365) is a model-driven app on the Power Platform, any entity can be added; users can only see entities and records that they have the licenses and security to access, regardless of whether it's part of the Field Service app or not.

## Why is the app saying "You're almost there"?

> [!div class="mx-imgBorder"]
> ![Screenshot of the "you're almost there" issue.](./media/mobile-2020-youre-almost-there.png)

If you are getting the error "You're almost there" after signing in to the mobile app, try the following steps:

1. Make sure you have the correct security role (Field Service - Resource) and that the security role is assigned to the Field Service Mobile app.
2. Sign in again, pull down the screen to refresh and wait for at least a few minutes
3. If completing both steps 1 and 2 above do not resolve the issue, [submit a support ticket](https://dynamics.microsoft.com/contact-us/).

## Why doesn't the bookable resource booking form show work order details like **Customer**, **Service**, and **Notes**?

Sometimes you may not see the correct booking form. You may see the following:

> [!div class="mx-imgBorder"]
> ![Screenshot of the wrong from issue.](./media/mobile-2020-faq-wrong-booking-form.png)

If you see something like the previous screenshot, you're viewing the booking form, and *not* the combined booking and work order form.

To solve this issue, make sure the user you're logged in to the mobile app as has the **Field Service - Resource** security role.