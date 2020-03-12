---
title: "Delete an instance  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
ms.assetid: 5903eb35-2625-4c53-8330-a05267055c01
caps.latest.revision: 4
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Delete an instance

[!INCLUDE[applies-to](../includes/cc_applies_to_ce.md)]

You can delete Sandbox instances to recover the licenses and storage space or to prevent them from being used by mistake. In order to delete a Production instance, you must first switch to a Sandbox instance and then delete the Sandbox instance. You can delete a Support instance directly.
  
<a name="BKMK_Delete"></a>   
## Delete an instance  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]  
  
   > [!NOTE]
   > Consider using the less privileged service admin role instead of the global admin role. See [Use the service admin role to manage your tenant](use-service-admin-role-manage-tenant.md).

2. [!INCLUDE[proc_office365_choose_admin_crm](../includes/proc-office365-choose-admin-crm.md)]  
  
3. Choose the **Instances** tab.  
  
4. Select the instance that you want, and then click **Delete**.  
  
   > [!WARNING]
   >  Your data will be lost! Be sure you’ve selected the correct instance.  
  
5. Click **Confirm** to delete the instance.  
  
Deleting an instance doesn’t change the number of your licenses purchased. For example, say you have two instances - one Sandbox and one Production - and you decide to delete your Sandbox instance. After the delete has successfully completed, you’ll see one Production instance and one instance to configure in the **Instance** tab of the **Manage your Dynamics 365 updates** page.  
  

