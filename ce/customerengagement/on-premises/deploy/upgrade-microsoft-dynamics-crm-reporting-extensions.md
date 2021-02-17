---
title: "Upgrade Microsoft Dynamics 365 Reporting Extensions | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 46ee23c4-f2d5-4744-83c0-e05f21385346
caps.latest.revision: 18
ms.author: matp
author: Mattp123
manager: kvivek
---
# Upgrade Microsoft Dynamics 365 Reporting Extensions



Dynamics 365 Reporting Extensions aren’t supported for in-place upgrade. To upgrade to the new version, you must first uninstall the existing version.  
  
 To upgrade Dynamics 365 Reporting Extensions, do the following:  
  
1.  Meet all requirements as specified under [Microsoft Dynamics 365 Reporting Extensions requirements](microsoft-dynamics-365-reporting-requirements.md).  
  
2.  Uninstall the existing version of Dynamics 365 Reporting Extensions.  
  
3.  Before you run the new version of Dynamics 365 Reporting Extensions [!INCLUDE[pn_Setup](../includes/pn-setup.md)], upgrade Dynamics 365 Server. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Upgrade from Microsoft Dynamics 2015 Server](upgrade-from-microsoft-dynamics-365-server.md)  
  
4.  At the computer where Dynamics 365 Reporting Extensions were installed, log on to your domain as a user who has administrator-level privileges.  
  
5.  In the `..\Server\amd64\SrsDataConnector` folder where the Dynamics 365 Server installation media is located, double-click **SetupSrsDataConnector.exe**.  
  
6.  Follow the instructions on the screen. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Install Microsoft Dynamics 365 Reporting Extensions](install-microsoft-dynamics-365-reporting-extensions.md)  
  
## See Also  
 [Upgrade Dynamics 365 Server](upgrade-from-microsoft-dynamics-365-server.md) </br> 
 [After the upgrade](after-the-upgrade.md)   




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]