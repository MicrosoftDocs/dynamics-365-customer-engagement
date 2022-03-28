---
title: Provide consent to collect data from Exchange Online
description: Provide consent for Dynamics 365 to use data from Exchange Online in relationship analytics.
ms.date: 03/03/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Provide consent to collect data from Exchange Online  

> [!IMPORTANT]
> If your organization is an existing relationship intelligence customer and you've provided consent in **Microsoft 365 admin center** > **Settings** > **Org settings** > **Dynamics 365 Sales Insights – Analytics**, the consent is valid until September 2022. After that, you'll need to provide consent as described in this article. We recommend that you provide consent as early as possible.

Relationship analytics and health scores that include insights from Exchange Online are more accurate than those that include only data from Dynamics 365. However, an Office 365 administrator must provide consent for Dynamics 365 to collect information from your organization's Exchange server.  

When provided, the application analyzes the Exchange emails data pertaining to two years, including the current year.  

> [!TIP]
> For more information on how relationship analytics uses Office 365 data, see [Use relationship analytics to gather KPIs](./relationship-analytics.md).

If you're an Office 365 administrator, here's how to provide consent:

1. In **Microsoft 365 admin center**, select **Settings** > **Org settings** > **Dynamics 365 Applications**.

    :::image type="content" source="./media/office365-consent-form.png" alt-text="A screenshot of the Microsoft 365 admin center Org settings, with the Dynamics 365 Apps consent form shown.":::
    
3. Read the description carefully and select the **Insights for other users** option. 

    > [!NOTE]
    > The consent provided is applicable to all the Dynamics 365 applications that require **Insights for other users** permission.  
      
    Relationship analytics can now connect to the Exchange server to fetch data.

### See also

[Configure relationship analytics and health](configure-relationship-analytics.md)