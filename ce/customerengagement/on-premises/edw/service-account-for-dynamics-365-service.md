---
title: "Verify the service account for a Microsoft Dynamics 365 for Customer Engagement service | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: bf391b1b-88b1-4157-a054-4fde0643d93d
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Verify the service account for a Microsoft Dynamics 365 for Customer Engagement service

If this is an **error**, the following information applies.  
  
## Cause
  
 This error occurs when the user account specified does not exist, is incorrectly specified, or the password for the user account is incorrect.  
  
## Solution
  
 Verify the following conditions:  
  
-   The user account name specified is valid and the password is correct. Additionally, the user account logon must use one of the following formats:  
  
    -   Domain\user  
  
    -   user@domain.com  
  
-   The user account is a domain user in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  
  
-   The user account is not a local system account.  
  
-   The credentials specified in the XML Setup configuration file or on the Specify Service Accounts page in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Setup are valid. For information on permissions for service accounts, see [Minimum permissions required for Microsoft Dynamics CRM Setup and services](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699825(v=crm.8)).  
  
 If this is a **warning**, the following information applies.  
  
## Cause
  
 Using the account specified for the service can cause unexpected behavior.  
  
 ## Solution
  
 We strongly recommend that you specify a user account that is not also used for another service, is not a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user, or is not the user who is running Setup.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]