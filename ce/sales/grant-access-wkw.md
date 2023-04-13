---
title: Grant access to who knows whom information
description: Configure who knows whom to help sellers quickly identify colleagues who can introduce them to leads or contacts
ms.date: 03/03/2023
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Grant access to who knows whom information

By default, the Salesperson and Sales Manager roles have permissions to view the who knows whom information in the contact and lead pages. As an administrator, you can grant access to other roles if they too would benefit from the who knows whom information.  

> [!NOTE]
> The who knows whom widget will appear for all users who can view the Sales Insights view in the contact and lead pages. Users who don't have the permissions will see a message that they don't have sufficient privileges.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## To grant access

1. In the Sales Hub app, select **Settings** in the upper-right corner and select **Advanced Settings**.
1. On the **Business Management** page, select **Settings** > **System** > **Security**.
1. Select **Security Roles**.
1. Select the security role that you want to grant access for.
1. In the **Custom Entities** tab, provide read permissions to the following entities:

   ```wkwcolleaguesforcompany```  
   ```wkwcolleaguesforcontact```  
   ```wkwconfig```  

    :::image type="content" source="media/wkw-access.png" alt-text="Entities to be granted access for who knows whom.":::
1. Save the changes.

### See also

[View who knows whom](who-knows-whom.md#view-who-knows-whom)
