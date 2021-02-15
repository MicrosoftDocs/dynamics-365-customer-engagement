---
title: "Could not obtain exclusive lock on database &#39;databasename&#39; | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: f993580a-ef2f-4bb1-8da4-d9414ac2ec29
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Could not obtain exclusive lock on database &#39;databasename&#39;

## Cause
  
 [!INCLUDE[pn_Deployment_Manager_long](../includes/pn-deployment-manager-long.md)] requires exclusive locking to certain databases, such as the model database on the [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] configuration database is located, in order to complete an operation. The database referenced in the error message was being used by another process.  
  
 ## Solution
  
 Verify that the database that is referenced in the error message is not being used while you are performing the operation, and then try the operation again.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]