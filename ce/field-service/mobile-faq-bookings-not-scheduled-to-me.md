---
title: "Bookings not scheduled to me are showing when logged into the mobile app Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/03/2018
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

# Bookings not scheduled to me are showing when logged into the mobile app

This typically means you are logging into the mobile app with a user who has system administrator or Field Service—administrator security roles.

**System administrators** and **Field Service—administrators** have access to all Field Service records including all bookings scheduled to all resources. In contrast, users with the security role **Field Service—resource** only have access to work orders scheduled to that resource and related user.

Ensure your mobile user has only the **Field Service—resource** security role in **Settings > Security > Users > Manage roles**

![Mobile FAQs image23](media/Mobile-FAQs-image23.png)  

>[!Note]
> **Pro Tip:** Bookings are scheduled to Resources, but User records are used to log into the mobile app. This is made possible because Resources can be tied to User records.
