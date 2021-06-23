---
title: "Dynamics 365 for phones and IFD | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 7c6a34c6-f67b-4b31-b5c6-f66f8d0c2db2
caps.latest.revision: 7
ms.author: matp
author: Mattp123
manager: kvivek
---
# Dynamics 365 for phones and IFD



By default, Windows Integrated Authentication (WIA) is enabled in [!INCLUDE[pn_adfs_windows_server_2012R2_long](../includes/pn-adfs-windows-server-2012r2-long.md)]. WIA is used for authentication requests that occur within the organization’s internal network (intranet) for any application that uses a browser for its authentication.  
  
 WIA is not supported for [!INCLUDE[pn_Microsoft_Dynamics_CRM_Mobile](../includes/pn-microsoft-dynamics-crm-mobile.md)] running on [!INCLUDE[pn_windows_phone](../includes/pn-windows-phone.md)] 8.1. If you have deployed [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-op-edition.md)] with [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)], you will need to run a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] script on your [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server to fall back to forms-based authentication for [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] on [!INCLUDE[pn_windows_phone](../includes/pn-windows-phone.md)] 8.1. For the script and more information on this issue, see [Configuring intranet forms-based authentication for devices that do not support WIA](/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/dn727110(v=ws.11)).  
  
## See Also  
 [User Guide (Dynamics 365 for phones and tablets)](../basics/dynamics-365-phones-tablets-users-guide-onprem.md)   
 [Configure IFD for Microsoft Dynamics 365](configure-ifd-for-dynamics-365.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]