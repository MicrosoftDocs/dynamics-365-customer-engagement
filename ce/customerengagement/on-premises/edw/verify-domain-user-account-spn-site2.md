---
title: "Verify domain user account SPN for the service or website2 | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 43c84bc9-ab01-4f4a-86ba-aff4d47ca527
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Verify domain user account SPN for the service or website

## Cause 1
  
 Verify the following conditions:  
  
-   The user account name specified is valid and the password is correct. Additionally, the user account logon must use one of the following formats:  
  
    -   Domain\user  
  
    -   user@domain.com  
  
-   The user account is a domain user in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  
  
-   The user account is not a local system account.  
  
-   The credentials specified in the XML Setup configuration file or on the **Specify Service Accounts** page in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Setup are valid. For information on permissions for service accounts, see [Minimum permissions required for Microsoft Dynamics CRM Setup and services](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699825(v=crm.8)).  
  
## Cause 2
  
 We recommend that you verify that the service principal name (SPN) associated with the domain user account specified is registered with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. This is a warning and Setup can continue.  

## Cause 3

 Using the same account specified for the Application Service as the user running Setup can cause unexpected behavior.  

 ## Solution 1 and 2
  
 Verify and correct the domain user issues as necessary. 

 Use the setspn tool to verify that the SPN is registered with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], and if necessary, register the SPN. For more information about setspn, see [Setspn](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc731241(v=ws.10)).  
    
 ## Solution 3
  
 We strongly recommend that you specify an account that is not also the user who is running Setup.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]