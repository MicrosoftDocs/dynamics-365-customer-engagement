---
title: "There is a problem with the account specified to run the Microsoft Dynamics 365 for Customer Engagement service | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 9cc64bc6-d542-4700-888d-219b5c35dac7
caps.latest.revision: 10
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# There is a problem with the account specified to run the Microsoft Dynamics 365 for Customer Engagement service
Review the message in the [!INCLUDE [pn-environment-diagnostics-wizard](../includes/pn-environment-diagnostics-wizard.md)] and select the cause and associated solution that is most appropriate.  
  
 ## Cause 1
  
 The account specified for the service displayed in the [!INCLUDE [pn-environment-diagnostics-wizard](../includes/pn-environment-diagnostics-wizard.md)] message is not valid.  
  
 ## Solution 1
  
-   Verify that the user account name is valid and the password is correct. Additionally, the user account logon must use one of the following formats.  
  
    -   Domain\user  
  
    -   user@domain.com  
  
-   Verify that the user account is a domain user in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  
  
-   Verify that the user account is not a local system account.  
  
-   Verify that the credentials specified in the XML Setup configuration file or on the **Specify Service Accounts** page in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Setup are valid. For more information, see [Minimum permissions required for Microsoft Dynamics CRM Setup, services, and components](https://go.microsoft.com/fwlink/p/?LinkID=306136).  
  
 ## Cause 2
  
 Setup has detected that the specified user account is the same account that is running Setup.  
  
 ## Solution 2
  
 Using the account specified for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service described in Setup can cause unexpected behavior. We strongly recommend that you specify an account that is not also the user who is running Setup.  
  
 ## Cause 3
  
 The account specified for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service displayed in the [!INCLUDE [pn-environment-diagnostics-wizard](../includes/pn-environment-diagnostics-wizard.md)] message doesn’t have permission to use performance counters. The service needs this permission to function correctly. By default, the Performance Log Users and Administrators groups on the local computer have this permission.  
  
 ## Solution 3
  
 Add the service account to the **Performance Log Users** local group or specify an account that already has this permission. Alternatively, you can use the Network Service account.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]