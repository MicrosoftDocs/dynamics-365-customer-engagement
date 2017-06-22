---
title: "Clear server-side cacher for a portal in Dynamics 365 | MicrosoftDocs"
description: "Forcefully clear server-side cache for a portal."
ms.custom: ""
ms.date: 06/21/2017
ms.service: crm-online
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
As a portal administrator, you can clear the server-side cache for the entire portal so that the updated data from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] is immediately reflected on the portal. Updates from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] are communicated to the portal in asynchronous mode, so there might be a lag for the data in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] to be updated on the portal. This functionality allows you to force the portal to refresh its cache immediately, if this delay is interfering with portal configuration.

To clear server-side cache:
1.	Log into the portal as an administrator.
2.	Navigate to the URL as follows: `<portal_path>/_services/about`
3.	Click **Clear Cache**. The server-side cache will be deleted, and the data is reloaded from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].
    ![Clear portal cache](media/clear-portal-cache.png "Clear portal cache") 