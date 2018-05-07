---
title: "Clear the server-side cache for a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to force the portal to refresh its cache immediately."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: A625CF6A-0E04-496D-9EF7-C06383860C65
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Clear the server-side cache for a portal

As a portal administrator, you can clear the server-side cache for the entire portal so that updated data from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] is immediately reflected on the portal. Updates from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] are communicated to the portal in asynchronous mode, so there might be a lag between the time data is updated in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] and the time that updated data appears on the portal. To eliminate this delay&mdash;for example, when it interferes with portal configuration&mdash;you can force the portal to refresh its cache immediately.

To clear the server-side cache

1.	Sign in to the portal as an administrator.

2.	Navigate to the URL as follows: `<portal_path>/_services/about`

3.	Select **Clear Cache**. 

The server-side cache is deleted, and data is reloaded from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. Note that clearing the portal server-side cache will temporararily cause poor portal performance while data is being reloaded from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].
        
![Clear the portal cache](media/clear-portal-cache.png "Clear the portal cache")
