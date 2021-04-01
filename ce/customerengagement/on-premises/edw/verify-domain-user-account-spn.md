---
title: "Verify domain user account SPN for the service or website1 | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 5ef8e438-71a5-4142-ac83-36ea92c49bdc
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Verify domain user account SPN for the service or website

If this is an **error**, the following information applies.  
  
## Cause 1
  
 This error occurs when the user account specified does not exist, is incorrectly specified, or the password for the user account is incorrect.  
  
 For example, this error can occur when you incorrectly specify a value in the DeploymentServiceAccount node of the Setup XML configuration file.  
  
```  
<DeploymentServiceAccount type="DomainUser">  
<ServiceAccountLogin>domain\user</ServiceAccountLogin>  
<ServiceAccountPassword>password</ServiceAccountPassword>  
</DeploymentServiceAccount>  
```  

## Cause 2
  
 We recommend that you verify that the service principal name (SPN) associated with the domain user account specified is registered with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. This is a warning and Setup can continue.  
  
## Solution 1
  
 Verify the following conditions:  
  
-   The user account name specified is valid and the password is correct. Additionally, the user account logon must use one of the following formats:  
  
    -   Domain\user  
  
    -   user@domain.com  
  
-   The user account is not a local system account.  
  
-   The credentials specified in the XML Setup configuration file or on the **Specify Service Accounts** page in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Setup are valid. For information on permissions for service accounts, see [Minimum permissions required for Microsoft Dynamics CRM Setup and services](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699825(v=crm.8)).  
  
-   The user account is a domain user in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain as the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  


If this is a **warning**, the following information applies.  
  
## Solution 2
  
 Use the setspn tool to verify that the SPN is registered with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], and if necessary, register the SPN. For more information about setspn, see [Setspn](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc731241(v=ws.10)).



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]