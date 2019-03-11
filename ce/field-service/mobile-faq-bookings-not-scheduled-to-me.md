---
title: "Bookings not scheduled to me are appearing when logged into the mobile app Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/25/2018
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
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

# Bookings not scheduled to me are appearing when logged into the mobile app

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

If you're seeing a list of bookings that aren't scheduled to you, this typically means you're probably logged into the mobile app as a user with Dynamics 365 for Customer Engagement system administrator or Field Service administrator permissions. 

**Dynamics 365 for Customer Engagement system administrators** and **Field Service administrators** have access to all Field Service records, including all bookings scheduled to all resources. Users with the security role **Field Service resource** only have access to work orders scheduled to that resource and related user.

Ensure your mobile user has only the **Field Service resource** security role in **Settings > Security > Users > Manage roles** in the ribbon menu.

![Screenshot of a user in the Enabled users list with the Manage Roles option highlighted](media/Mobile-FAQs-image23.png)  

>[!Note]
> **Pro Tip:** Bookings are scheduled to resources, but user records are used to log into the mobile app. This is made possible because resources can be tied to user records.
