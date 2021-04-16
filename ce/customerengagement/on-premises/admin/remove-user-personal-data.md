---
title: "Remove user personal data  | MicrosoftDocs"
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
ms.assetid: b7faefff-25e2-44a5-8dd9-49bf1a1677c6
caps.latest.revision: 19
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Remove user personal data

After a user is deleted by the global admin from the Microsoft 365 admin center, the user's personal data can be removed from all tenant instances. A user is deleted from the Microsoft 365 admin center when:

1. The user leaves the company. In this scenario, the user record remains in the tenant’s Active Directory for 30 days before the record is deleted.

   -Or-

2. The user requests their personal data be deleted. The user record is deleted immediately.

Once the user record is deleted from Active Directory, Dynamics 365 Customer Engagement (on-premises) system admins can remove the user's personal data from all instances.

## Remove user personal data via User form

When the user record is deleted from Active Directory, the following message is displayed on the User form:

"This user’s information is no longer managed by Office 365. You can update this record to comply with the GDPR by removing or replacing all personal data."

To remove personal data:

1. Click **Settings** > **Security** > **Users**.
2. Select **Disabled Users** view.
3. Select a user.
5. Remove personal data, and then click **Save**.

## Remove user personal data via Excel Import/Export

1. Click **Settings** > **Security** > **Users**.
2. Select **Disabled Users** view.
3. Create an Excel template with all the user personal data columns that you want to update.  
4. Click on **Download File**.
5. Open the downloaded Excel file, make your updates, and then save the file.
6. Return to the **Disabled Users** view window and click **Import Data**.
7. Choose your updated Excel in the Upload data file dialog box.
8. Make all the necessary changes on the **Map Fields** window.
9. Click **Next** and **Submit**.

## Remove user personal data using Web services

You can also update the data for a disabled user using the Web API or Organization service. The user information is stored in the [SystemUser](/powerapps/developer/common-data-service/reference/entities/systemuser) entity, and you can update data in any of the [writeable attributes](/powerapps/developer/common-data-service/reference/entities/systemuser#writable-attributes) in the SystemUser entity. For examples about updating data in a record, see: 

- [Update and delete entities using the Web API](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api)
- [Use the Entity class for create, update and delete](/powerapps/developer/data-platform/org-service/entity-operations-update-delete)

### See also



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]