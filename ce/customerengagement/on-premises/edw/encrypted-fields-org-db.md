---
title: "Encrypted fields in the organization database | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 05315101-e80a-4bf7-bb1e-92e1c01fb4e9
caps.latest.revision: 8
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Encrypted fields in the organization database

## Cause
  
 There are encrypted fields in the organization database. However, the data encryption feature isn't activated.  
  
## Solution
  
 After the import is complete, activate data encryption. To activate data encryption, follow these steps:  
  
1.  Sign in to Microsoft Dynamics 365 for Customer Engagement as a user who has the system administrator security role.  
  
2.  Go to **Settings** > **Data Management** > **Data Encryption**.  
  
    > [!CAUTION]
    >  If the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website is not configured for HTTPS/TLS, the Data Encryption dialog box will not be displayed. For a more secure deployment, we recommend that you configure the website for HTTPS/TLS. However, if the website is not configured for HTTPS/TLS, use a tool that can be used to modify Dynamics 365 for Customer Engagement database tables, such as [!INCLUDE[pn_ms_SQL_Management_Studio_long](../includes/pn-ms-sql-management-studio-long.md)] or the [!INCLUDE [pn-deployment-web-service](../includes/pn-deployment-web-service.md)], open the configuration database (MSCRM_CONFIG), and in the DeploymentProperties table set DisableSSLCheckForEncryption to 1.  

3.  In the Data Encryption dialog box, notice that the **Encryption status** label indicates that data encryption is **Inactive**. To activate data encryption:  
  
    1.  Enter the encryption key that was used to encrypt the data in the **Activate Encryption Key** box. Notice that you can copy the encryption key from its source location onto the Windows clipboard and paste the key into the **Activate Encryption Key** box.  
  
    2.  Select **Activate**.  
  
    3.  Select **OK** to close the confirmation dialog box.  
  
    > [!WARNING]
    >  If you cannot provide the encryption key, data encryption cannot be activated and the associated data will become inaccessible. Features in Microsoft Dynamics 365 for Customer Engagement that use the encrypted data, such as Server-side Synchronization, will no longer work. Notice that you cannot delete and re-create the encrypted data.  
  
 For more information, see [Enhance security by encrypting your data](../admin/data-encryption.md).



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]