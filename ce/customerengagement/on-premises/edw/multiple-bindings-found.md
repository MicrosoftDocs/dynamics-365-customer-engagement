---
title: "Multiple bindings found | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 842c1140-d3c5-48bc-9470-0a60e91247ba
caps.latest.revision: 5
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Multiple bindings found
[!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] must run on a website that has a single binding. Although IIS supports multiple HTTP and HTTPS bindings, there is a limitation in using additional bindings with [!INCLUDE[pn_WCF_long](../includes/pn-wcf-long.md)]. Multiple IIS bindings, such as a website with two HTTPS or two HTTP bindings, are not supported for running [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
 Before you install or upgrade, you must remove the additional bindings from the website used for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] or select a different website.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]