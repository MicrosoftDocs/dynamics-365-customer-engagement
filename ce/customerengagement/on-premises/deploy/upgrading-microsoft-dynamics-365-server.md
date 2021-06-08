---
title: "Upgrading Dynamics 365 Server | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 17c454d2-27be-47e6-a894-db1afc8e4d8f
caps.latest.revision: 18
ms.author: matp
author: Mattp123
manager: kvivek
---
# Upgrading Dynamics 365 Server

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

This section provides best practices guidelines and procedures to install [!INCLUDE[pn_crm_server_2016_legacy](../includes/pn-crm-server-2016-legacy.md)] in a deployment that already has the previous version of [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)] Server installed.  
  
## Upgrade options  
 There are three different upgrade options:  
  
-   **Migrate by using a new instance of [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)]**. We recommend this option for upgrading Dynamics 365 Server. Although this option requires a different computer for the new version of Dynamics 365 Server and a different instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], it provides the least amount of potential downtime for [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)] because the previous [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)] deployment can remain functioning until the upgrade is completed and verified.  
  
-   **Migrate by using the same instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]**. This option requires a different computer for the new version of Dynamics 365 Server, but will upgrade in-place the configuration and default organization databases using the same instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. If issues occur during the upgrade, you must roll back to the previous deployment to avoid significant downtime.  
  
-   **In-place upgrade**. Although this option doesn’t require a different computer for the new version of Dynamics 365 Server or a different instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], it poses the greatest risk if upgrade issues occur because a roll back and reinstall of the previous deployment will be required to avoid potential downtime.
  
## See also
[Upgrade from Microsoft Dynamics 2015 Server](upgrade-from-microsoft-dynamics-365-server.md)

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]