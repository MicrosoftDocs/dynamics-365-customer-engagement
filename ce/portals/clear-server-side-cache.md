---
title: "Clear the server-side cache for a portal | MicrosoftDocs"
description: "Instructions to force the portal to refresh its cache immediately."
ms.custom: 
  - dyn365-portal
ms.date: 12/03/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: A625CF6A-0E04-496D-9EF7-C06383860C65
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# Clear the server-side cache for a portal

<<<<<<< HEAD
As a portal administrator, you can clear the server-side cache for the entire portal so that updated data from Dynamics 365 is immediately reflected on the portal. Updates from Dynamics 365 are communicated to the portal in asynchronous mode, so there might be a lag between the time data is updated in Dynamics 365 and the time that updated data appears on the portal. To eliminate this delay&mdash;for example, when it interferes with portal configuration&mdash;you can force the portal to refresh its cache immediately.
=======
As a portal administrator, you can clear the server-side cache for the entire portal so that updated data from Dynamics 365 is immediately reflected on the portal. Updates from Dynamics 365 are communicated to the portal in asynchronous mode, so there might be a lag between the time data is updated and the time that updated data appears on the portal. To eliminate this delay&mdash;for example, when it interferes with portal configuration&mdash;you can force the portal to refresh its cache immediately.
>>>>>>> 4c9cd9f49bfd32b1dacbbac975fffb89f4dfc869

> [!NOTE]
> The SLA for cache refresh (data transfer between Dynamics 365 and portal) is 15 minutes.

To clear the server-side cache

1.	Sign in to the portal as an administrator.

2.	Navigate to the URL as follows: `<portal_path>/_services/about`

3.	Select **Clear Cache**. 

The server-side cache is deleted, and data is reloaded from Dynamics 365. Note that clearing the portal server-side cache will temporararily cause poor portal performance while data is being reloaded from Dynamics 365.
        
![Clear the portal cache](media/clear-portal-cache.png "Clear the portal cache")
