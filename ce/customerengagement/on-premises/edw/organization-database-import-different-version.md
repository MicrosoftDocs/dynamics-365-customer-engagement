---
title: "The organization database selected for import is a different version | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 4c7e07f9-4b8e-4113-99dd-88b1d8920427
caps.latest.revision: 5
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# The organization database selected for import is a different version

## Cause
  
 The organization database selected for import is a different version than the current deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. This is an indication that the organization database that you are importing and the deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] have different versions or updates applied. For example, this warning can occur when an update has been applied to the deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], but not the database.  
  
 Because the versions do not match, the Import Wizard might not be able to successfully import the organization, or the organization might not function as expected after the import is completed.  
  
## Solution  
  
 This is a warning message and the import operation can continue. However, after the import of the organization is complete, we recommend that you reapply the updates, which might have been applied to the deployment. Doing this makes sure that the organization has the same level of update as the deployment.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]