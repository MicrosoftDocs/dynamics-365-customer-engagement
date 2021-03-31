---
title: "Data encryption  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: f88f7c87-2ee2-42f3-8101-7271f6731cf9
caps.latest.revision: 28
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin
---
# Enhance security by encrypting your data

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Dynamics 365 Customer Engagement (on-premises) uses standard [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] cell level encryption for a set of default entity attributes that contain sensitive information, such as user names and email passwords. This feature can help organizations meet FIPS 140-2 compliance.  
  
 For Customer Engagement (on-premises),  all new and upgraded organizations use data encryption by default. Data encryption can’t be turned off.  
  
 Customer Engagement (on-premises) users who have the system administrator security role can change the encryption key at any time. 

<a name="BKMK_changeEncKey"></a>   
## Change an organization encryption key  
  
1. [!INCLUDE[proc_settings_datamanagement](../includes/proc-settings-datamanagement.md)]  
  
2. Click **Data Encryption**.  
  
3. In the **Change Encryption Key** box type the new encryption key and then select **Change**.  
  
4. Select **OK** in the confirmation message and then click **Close** to exit the Data Encryption page.  
  
5. We recommend that you copy the key to a safe place. [Copy your organization data encryption key](../admin/data-encryption.md#BKMK_copy_your_org_enc_key)  
  
<a name="BKMK_copy_your_org_enc_key"></a>   
## Copy your organization data encryption key  
 We strongly recommend that you make a copy of your data encryption key.  
  
1. Sign in to Customer Engagement (on-premises) as a user with the system administrator security role.  
  
2. [!INCLUDE[proc_settings_datamanagement](../includes/proc-settings-datamanagement.md)]  
  
3. Click **Data Encryption**.  
  
4. In the **Data Encryption** dialog box, select **Show Encryption Key**, in the **Current encryption key box** select the encryption key, and copy it to the clipboard.  
  
5. Paste the encryption key in to a text editor, such as Notepad.  
  
   > [!WARNING]
   >  By default, Customer Engagement (on-premises) generates a passphrase that is a random collection of Unicode characters. Therefore, you must save the system-generated passphrase by using an application and file that supports Unicode characters. Some text editors, such as Notepad use ANSI coding by default. Before you save the passphrase using Notepad, select **Save As**, and then in the **Encoding** list, select **Unicode**.  
  
6. As a best practice, save the text file that contains the encryption key on a computer in a secure location on an encrypted hard drive.  
  
### See also  
 [SQL Server Encryption](/sql/relational-databases/security/encryption/sql-server-encryption)   
 [FIPS 140 Evaluation](/windows/security/threat-protection/fips-140-validation)   
 [Manage Your Data](../admin/manage-your-data.md)   
 [Manage configuration data](manage-configuration-data.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]