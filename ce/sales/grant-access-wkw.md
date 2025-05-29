---
title: Grant access to who knows whom information
description: Learn how to configure who knows whom in Dynamics 365 Sales to help sellers quickly identify colleagues who can introduce them to leads or contacts.
ms.date: 01/28/2025
ms.custom: bap-template
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Grant access to who knows whom information

The Salesperson and Sales Manager roles have permissions to view who knows whom information in the contact and lead pages by default. Administrators can grant access to other roles.  

The who knows whom widget appears for all users who can open the Sales Insights view in contact and lead pages. Users who don't have sufficient privileges to view who knows whom information see a message to that effect.  

## Grant access

[!INCLUDE [Lightbox tip](~/../shared-content/shared/lightbox-tip.md)]

1. In the sales app, go to **Settings** > **Advanced Settings**.
1. Go to **System** > **Security**.
1. Select **Security roles**.
1. Open the security role that you want to grant access to.
1. In the **Tables** tab, select **Show all tables** from the list. 
1. Provide read permissions to the following tables:

   ```wkwcolleaguesforcompany```  
   ```wkwcolleaguesforcontact```  
   ```wkwconfig``` 

1. Save the changes.

## Related information

[View who knows whom](who-knows-whom.md#view-who-knows-whom)

