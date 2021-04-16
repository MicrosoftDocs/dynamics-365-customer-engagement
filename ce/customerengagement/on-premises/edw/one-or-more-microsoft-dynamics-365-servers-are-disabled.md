---
title: "One or more Microsoft Dynamics 365 Servers are disabled | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: b1bc0700-82dd-4680-8671-93a87afb4dd3
caps.latest.revision: 5
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# One or more Microsoft Dynamics 365 Servers are disabled

## Cause
  
 The operation can’t be completed because one or more [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] servers are in a disabled state.  
  
 ## Solution
  
 Start [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)], and, in the **Servers** area, enable each [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] that is disabled. Alternatively, you can use the [Enable-CrmServer](/powershell/module/microsoft.crm.powershell/enable-crmserver?view=dynamics365ce-ps) [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet or the methods that are described in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)].  
  



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]