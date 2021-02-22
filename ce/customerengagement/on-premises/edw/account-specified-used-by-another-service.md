---
title: "The account specified for the service is a member of the PrivUserGroup and is used by another service | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 3df0d9f1-9d56-4565-b948-bf52ed303226
caps.latest.revision: 2
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# The account specified for the service is a member of the PrivUserGroup and is used by another service

## Cause
  
 The account specified for the service described in Setup is a member of the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] PrivUserGroup and is being used or specified to be used by another service.  
  
 ## Solution
  
 For a more secure deployment, we recommend that you specify a separate least-privileged domain user account.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]