---
title: "Not all base and extensionbase tables were merged | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 53d1006e-162a-4fb1-b494-35e781363af0
caps.latest.revision: 7
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Not all base and extensionbase tables were merged

## Cause
  
 As part of the upgrade, Setup will merge all \<entityname>base and \<entityname>extensionbase tables in the organization database specified for upgrade. However, the merge was unable to complete and some tables might not have been merged.  
  
 ## Solution
  
 Review the setup log to help determine the cause of the problem. For example, an issue can occur when there are a large number of customizations that cause the total number of columns in both the base and exensionbase tables to exceed 1024 when merged.  
  
 For more information about base and exensionbase table merge, see [Run the base and extension table merge as a separate operation](/previous-versions/dynamicscrm-2013/implementation-guide/dn531088(v=crm.6)).
 



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]