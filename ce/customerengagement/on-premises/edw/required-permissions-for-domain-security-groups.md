---
title: "Required permissions for domain security groups | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 8d967f0d-bba9-40b2-96dd-cdb7c01279bc
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Required permissions for domain security groups

## Cause
  
 Setup cannot continue because you do not have the required permissions on one or more of the following domain security groups or the organizational unit where these groups are located or will be created.  
  
-   PrivUserGroup  
  
-   SQLAccessGroup  
  
-   ReportingGroup  
  
-   PrivReportingGroup  
  
 ## Solution
  
 Verify, and if it is necessary, grant the minimum permissions that are required by Setup on the security groups and organizational unit where the groups will be created or where the groups are already located. The following permissions must be set to "allow" and applied to "this object only" on each domain security group listed earlier and the organizational unit where the groups will exist.  
  
-   Create all child objects (if you create the groups)  
  
-   Modify  
  
-   Read  
  
-   Read All Properties  
  
-   Write All Properties  
  
 For more information about granting permissions on security groups, see the Windows Server Help.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]