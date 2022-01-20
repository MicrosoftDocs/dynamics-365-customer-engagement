---
title: "This organization name is not valid | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: a399aac4-9b6b-41fe-9089-1a01f1fefeae
caps.latest.revision: 2
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# This organization name is not valid

## Cause
  
 There is a problem with the unique name of the organization database that you selected to create or import. This error occurs when either of the following situations is true:  
  
-   The organization name is invalid. The organization name must comply with the following naming conventions:  
  
    -   Must be only "A-Z", "a-z", "0-9", or "\_" (underscore) characters.  
  
    -   Cannot be blank or an empty string.  
  
    -   Cannot be more than 30 characters long.  
  
    -   Cannot start with 0-9 or underscore "\_" characters.  
  
-   The unique name of the organization database already exists in the current deployment. The unique name of an organization cannot already exist in the system.  
  
## Solution
  
 Select the needed solution.  
  
-   You must select an organization database with a name that complies with the naming convention described previously.  
  
-   If you are creating a new organization database, enter a different organization name and then continue with the operation. If you are trying to import an organization, you cannot import an organization that has the same unique name as that of another organization in the deployment.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]