---
title: "Deployment Web service domain user account | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: a9ec9bc9-d94d-4859-be9b-0de2fd93556a
caps.latest.revision: 7
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Deployment Web service domain user account
  
## Cause (error situation)
  
 This error occurs when the user account specified does not exist, is incorrectly specified, or the password for the user account is incorrect.  
  
 For example, this error can occur when you incorrectly specify a value in the DeploymentServiceAccount node of the Setup XML configuration file.  
  
```  
<DeploymentServiceAccount type="DomainUser">  
<ServiceAccountLogin>domain\user</ServiceAccountLogin>  
<ServiceAccountPassword>password</ServiceAccountPassword>  
</DeploymentServiceAccount>  
```  
  
## Solution
  
 Verify the following conditions:  

<!--from editor: On the review page, user@domain.com appears with the asterisks and not in italics. I haven't been able to correct this.-->

-   The user account name specified is valid and the password is correct. Additionally, the user account login must use one of the following formats.  
  
    -   *Domain\user*  
         
    -   *user&commat;domain.com*  
  
-   The user account is not a local system account.  
  
-   The credentials specified in the XML Setup configuration file or on the **Specify Service Accounts** page in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Setup are valid. For information on permissions for service accounts, see [Minimum permissions required for Microsoft Dynamics CRM Setup, services, and components](https://go.microsoft.com/fwlink/p/?LinkID=306136).  
  
-   The user account is a domain user in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  
  
If this is a warning, the following information applies.  
  
## Cause (warning situation)
  
  If this is a warning, we recommend that you verify that the service principal name (SPN) associated with the domain user account specified is registered with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. This is a warning and Setup can continue.  
  
 ## Solution
  
 Use the setspn tool to verify that the SPN is registered with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] and, if necessary, register the SPN. For more information about setspn, see [Setspn](https://technet.microsoft.com/library/cc731241\(WS.10\).aspx).  
  



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]