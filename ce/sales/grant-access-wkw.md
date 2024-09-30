---
title: Grant access to who knows whom information
description: Learn how to configure who knows whom in Dynamics 365 Sales to help sellers quickly identify colleagues who can introduce them to leads or contacts.
ms.date: 03/03/2023
ms.custom: bap-template
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Grant access to who knows whom information

The Salesperson and Sales Manager roles have permissions to view who knows whom information in the contact and lead pages by default. Administrators can grant access to other roles.  

The who knows whom widget appears for all users who can open the Sales Insights view in contact and lead pages. Users who don't have sufficient privileges to view who knows whom information see a message to that effect.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Grant access

[!INCLUDE [Lightbox tip](~/../shared-content/shared/lightbox-tip.md)]

1. In the Sales Hub app, select **Settings** in the upper-right corner, and then select **Advanced Settings**.
   > [!NOTE]
   > The **Advanced Settings** page is moving from the web client to an Unified Interface app. If your organization has enabled the public preview of the **Advanced settings redirection** feature, you’ll see the settings open in the Power Platform Environment Settings app. Find more information about the app and navigation path in [Advanced settings in the new experience](advanced-settings-new-experience.md).
1. On the **Business Management** page, select **Settings** > **System** > **Security**.
1. Select **Security Roles**.
1. Select the security role that you want to grant access to.
1. In the **Custom Entities** tab, provide read permissions to the following entities:

   ```wkwcolleaguesforcompany```  
   ```wkwcolleaguesforcontact```  
   ```wkwconfig```  

    :::image type="content" source="media/wkw-access.png" alt-text="Screenshot of entities to be granted access to who knows whom information." lightbox="media/wkw-access.png":::

1. Save the changes.

## Related information

[View who knows whom](who-knows-whom.md#view-who-knows-whom)

