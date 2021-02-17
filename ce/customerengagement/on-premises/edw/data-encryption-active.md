---
title: "Data encryption will be active after the install or upgrade | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 8ffd2e56-4961-4aa9-ac22-e52455fbfdbf
caps.latest.revision: 8
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Data encryption will be active after the install or upgrade

## Cause
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] uses standard [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] cell level encryption for a set of default entity attributes. These attributes contain sensitive information, such as user names and email passwords. Encrypting such sensitive data can help organizations meet FIPS 140-2 compliance.  
  
 This feature uses an encryption key that will be required in certain circumstances, such as during an organization import as part of redeployment or in some failure recovery scenarios.  
  
> [!WARNING]
>  If you cannot provide the encryption key when it is required, data encryption cannot be activated and the associated data will become inaccessible. Features in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that use the encrypted data, such as Server-side Synchronization, will no longer work. Notice that you cannot delete and re-create the encrypted data.  
  
 ## Solution
  
 We strongly recommended that you make a copy of your data encryption key. This is particularly important for on-premises deployments that may have to reactivate data encryption after a redeployment or failure recovery.  
  
### Copy an organization data encryption key  
  
1.  Sign in to Microsoft Dynamics 365 for Customer Engagement as a user who has the system administrator security role.  
  
2.  Go to **Settings** > **Data Management** > **Data Encryption**.  
  
3.  In the Data Encryption dialog box, select **Show Encryption Key**. In the **Current encryption key** box, select the encryption key and copy it to the clipboard.  

    > [!CAUTION]
    >  If the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website is not configured for HTTPS/TLS, the Data Encryption dialog box will not be displayed. For a more secure deployment, we recommend that you configure the website for HTTPS/TLS. However, if the website is not configured for HTTPS/TLS, use a tool that can be used to modify Dynamics 365 for Customer Engagement database tables, such as [!INCLUDE[pn_ms_SQL_Management_Studio_long](../includes/pn-ms-sql-management-studio-long.md)] or the [!INCLUDE [pn-deployment-web-service](../includes/pn-deployment-web-service.md)], open the configuration database (MSCRM_CONFIG), and in the DeploymentProperties table set DisableSSLCheckForEncryption to 1.  

4.  Paste the encryption key into a text editor, such as Notepad.  
  
5.  As a best practice, save the text file that contains the encryption key on a computer in a secure location on an encrypted hard disk.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]