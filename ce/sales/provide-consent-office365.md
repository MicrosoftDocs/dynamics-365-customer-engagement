---
title: Provide consent to collect data from Exchange Online
description: Provide consent for Dynamics 365 to use data from Exchange Online in relationship analytics.
ms.date: 07/06/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Provide consent to collect data from Exchange Online  

Dynamics 365 Sales uses Microsoft 365 data to generate the following insights based users email interactions and meetings:

- Relationship analytics KPIs and health score
- Who knows whom suggestions

Previously, the consent for these capabilities were provided from **Microsoft 365 admin center** > **Settings** > **Org settings** > **Dynamics 365 Sales Insights - Analytics** and **Dynamics 365 Sales Insights - Connection graph** respectively. The consent to use Microsoft 365 data is now consolidated and is applicable for all Dynamics 365 applications. So, you must provide your consent again in the new form as described in this article.

## Things to consider

Before you provide the consent, review the following information:

- The consent provided in the old form for relationship analytics is valid until September 2022 and the consent for who knows whom is valid until July 31, 2022. After that, you'll need to provide consent as described in this article. After the consent is provided, Dynamics 365 Sales will need time to recalculate the who knows whom suggestions. So, we recommend that you provide the consent as soon as possible to ensure a smooth transition.  

- The consent provided is applicable to all the Dynamics 365 applications that require permission to access Microsoft 365 data.

- When consent is provided, Dynamics 365 analyzes Exchange emails from the last one year.  

- When you disable the consent, the system can take up to 24 hours to remove data from all apps and up to 30 days to remove backed-up data from Microsoft 365 storage accounts. 

## Provide consent

If you're an Office 365 administrator, here's how to provide consent:

1. In **Microsoft 365 admin center**, select **Settings** > **Org settings** > **Dynamics 365 Applications**.

    :::image type="content" source="./media/office365-consent-form.png" alt-text="A screenshot of the Microsoft 365 admin center Org settings, with the Dynamics 365 Apps consent form shown.":::
    
3. Read the description carefully and select the **Insights for other users** option. 

    > [!NOTE]
    > The consent provided is applicable to all the Dynamics 365 applications that require **Insights for other users** permission.  
      
    Relationship analytics and who knows whom can now use the Exchange data to generate insights.

## Opt out security groups of sharing data

You may want to opt out certain security groups of sharing their communication and collaboration data with Dynamics 365.

To opt out security groups:

1. Go to the **Microsoft 365 admin center**.

2. Select **Settings** > **Org settings** > **Dynamics 365 Sales Insights – Connection Graph**.

    > [!div class="mx-imgBorder"]
    > ![Enable and save the connection graph](media/sales-insights-addon-admincenter-connection-graph-enable.png "Screenshot of connection graph settings")

3.  Read the description carefully and then select the **Enable Dynamics 365 Sales Insights - Connection Graph for your entire organization** option.

4. Add the ID of security groups that you want to opt out. 

5. Select **Save**.

>[!NOTE]
> Users can opt out of the connection graph if they don't want sales insights to analyze their communication and collaboration data. More information: [Opt out of the connection graph](who-knows-whom.md#opt-out-of-the-connection-graph)

### See also

[Use relationship analytics to gather KPIs](relationship-analytics.md)
[How to get introduced to leads or contacts](who-knows-whom.md)