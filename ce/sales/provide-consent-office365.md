---
title: Provide consent to collect data from Microsoft 365
description: Provide consent for Dynamics 365 to use data from Microsoft 365.
ms.date: 03/03/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Provide consent to collect data from Microsoft 365  

> [!IMPORTANT]
> If your organization is an existing relationship intelligence customer and you've provided consent in **Microsoft 365 admin center** > **Settings** > **Org settings** > **Dynamics 365 Sales Insights – Analytics**, the consent is valid until September 2022. After that, you'll need to provide consent as described in this article. We recommend that you provide consent as early as possible to avoid any loss of functionality.

The Relationship analytics and who knows whom capabilities in Dynamics 365 Sales include insights based on email interactions from Exchange Online. 

To enable Dynamics 365 to collect information from your organization's Exchange server, your Office 365 administrator must provide consent to use Exchange data.  

> [!NOTE]
> When the consent is provided, Dynamics 365 analyzes Exchange emails pertaining to last two years.  

If you're Microsoft 365 administrator, here's how you provide consent:

1. In **Microsoft 365 admin center**, select **Settings** > **Org settings** > **Dynamics 365 Applications**.

    :::image type="content" source="./media/office365-consent-form.png" alt-text="A screenshot of the Microsoft 365 admin center Org settings, with the Dynamics 365 Apps consent form shown.":::
    
3. Read the description carefully and select the **Insights for other users** option. 

    > [!IMPORTANT]
    > The consent provided is applicable to all the Dynamics 365 applications that require **Insights for other users** permission.  
4. Save the changes.  
    Dynamics 365 applications can access the exchange data.

## Opt out security groups or users

As a Microsoft 365 admin, you can opt out certain security groups and users of sharing their communication and collaboration data.

<<Steps>>

### See also

[Insights generated from Microsoft 365 data](insights-from-m365.md)
[Configure relationship analytics and health](configure-relationship-analytics.md)
[Use relationship analytics to gather KPIs](./relationship-analytics.md)
[Configure who knows whom](configure-who-knows-whom.md)
[How to get introduced to leads or contacts](who-knows-whom.md)
