---
title: "One or more organizations can't be upgraded | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: e633cad0-3cfd-4327-85dd-25859c47b802
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# One or more organizations can't be upgraded

## Cause 1
  
 The version of the organization isn't supported for upgrade.  
  
 ## Cause 2
  
 The organization is not in a state that can be upgraded.  
  
 ## Solution 1
  
 We recommend that you apply the latest update. Then, in the Organizations area of [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)], update each organization. Alternatively, you can use the [Update-CrmOrganization](/powershell/module/microsoft.crm.powershell/update-crmorganization?view=dynamics365ce-ps) [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet or use the methods that are described in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)]. Find the latest updates: [Dynamics 365 for Customer Engagement on-premise cumulative updates](https://support.microsoft.com/help/3142345/microsoft-dynamics-365-onpremise-cumulative-updates)  
  
 **Solution 2**  
  
 Start [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] and verify whether the organization that you’re trying to upgrade is disabled. You must enable the organization before you can upgrade it.  
  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]