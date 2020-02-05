---
title: "New event management experience (Dynamics 365 Marketing) | Microsoft Docs"
description: "Add custom marketing forms to event registrations."
ms.date: 02/03/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Early access: Marketing forms for event registration

> [!IMPORTANT]
> This is an early access feature, which means that it's currently available only on opted-in instances. You can opt in for early access on any instance, but we recommend that you do so only on trial, test, or sandbox instances, which will give you a chance to learn the new functionality before it shows up on your production instances later this year.
>
> For instructions on how to opt in and enable early access, see [Opt in to early access updates](https://docs.microsoft.com/power-platform/admin/opt-in-early-access-updates). For more information about the 2020 release wave 1 schedule, and for answers to frequently asked questions about the early access program, see [2020 release wave 1 features available for early access](https://docs.microsoft.com/en-us/dynamics365-release-plan/2020wave1/features-ready-early-access).
>
>We encourage all customers to provide feedback related to early access features on the [Dynamics 365 Marketing Forum](https://community.dynamics.com/365/marketing/f/dynamics-365-for-marketing-forum), your Microsoft contact or partner, and/or through [Microsoft Support](https://docs.microsoft.com/power-platform/admin/get-help-support).

The event management application now allows you to use marketing forms for event registrations. You can create forms with a wide variety of fields, embed forms on your website, and use the forms you create for event registration.

> [!NOTE]
> For the early access version of this feature, forms are limited to free events and allow registration of one person at a time (instead of multiple people together).

## Create a marketing form for event registration

1. Go to **Marketing** > **Internet marketing** > **Marketing forms** to go to the list of all forms currently available on your instance.
2. Select **New** in the command bar.
3. Choose the **Event Registration Form** template.
4. The template will load into the form designer.

      ![Delivered email interactions](./media/export-journey-interactions.png "Delivered email interactions")

## Export a .CSV file

1. Go to **Insights** and select the interaction category you want to export (e.g., **Delivered emails**).

2. Select the **Export to CSV** button in the right top corner of a selected table.

3. That’s it! The .CSV file is automatically downloaded with the same columns and data as the table you selected to export.

      ![Exported data to .CSV file](media/export-journey-csv.png "Exported data to .CSV file")

> [!IMPORTANT]
> You cannot download different categories of interactions (e.g., **Sent** + **Delivered** + **Blocked** + **Delivery failed**) all at once into one file.