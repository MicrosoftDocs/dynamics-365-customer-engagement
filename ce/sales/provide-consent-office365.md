---
title: Provide consent to collect data from Microsoft 365
description: Provide consent for Dynamics 365 to use data from Microsoft 365 for relationship analytics and who knows whom.
ms.date: 08/16/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Provide consent to collect data from Microsoft 365  

Dynamics 365 Sales uses Microsoft 365 data to generate the following insights based on users email interactions and meetings:

- Relationship analytics KPIs and health score
- Who knows whom suggestions

Previously, the consent for these capabilities were provided from **Microsoft 365 admin center** > **Settings** > **Org settings** > **Dynamics 365 Sales Insights - Analytics** and **Dynamics 365 Sales Insights - Connection graph** respectively. The consent to use Microsoft 365 data is now consolidated and is applicable for all Dynamics 365 applications.  

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise, and Microsoft 365 <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Microsoft 365 administrator <br> |


## Things to consider

Before you provide consent in the new form, review the following information:

- Both relationship analytics and who knows whom require the same consent so you only need to consent once in the new form.

- The consent provided is applicable to all the Dynamics 365 applications that require permission to access Microsoft 365 data.

- When consent is provided, Dynamics 365 analyzes Exchange emails from the last one year to provide relationship insights and who knows whom suggestions.  

- When you disable the consent, the system can take up to 24 hours to remove data from all apps and up to 30 days to remove backed-up data from Microsoft 365 storage accounts. 


## Provide consent 

If you're a Microsoft 365 administrator, here's how you provide consent:

1. In **Microsoft 365 admin center**, select **Settings** > **Org settings** > **Dynamics 365 Applications**.

    :::image type="content" source="./media/office365-consent-form.png" alt-text="A screenshot of the Microsoft 365 admin center Org settings, with the Dynamics 365 Apps consent form shown.":::
    
3. Read the description carefully and select the **Identifiable insights for other users** option.  
    > [!NOTE]
    > The consent provided is applicable to all the Dynamics 365 applications that require the **Identifiable insights for other users** permission. Dynamics 365 Sales uses this consent for both relationship analytics and who knows whom.
    
1. (Optional) In the textbox that appears, enter the security group IDs of users who want to opt out of sharing their communication and collaboration data.
    :::image type="content" source="media/admin-opt-out.PNG" alt-text="A screenshot of the opt out textbox to provide security IDs":::

    > [!NOTE]
    > Individual users can opt out too. For more information, see [Turn off data sharing with Dynamics 365 applications](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications).

1. Save the changes.  
    Dynamics 365 applications can now now use the Microsoft 365 data to generate insights.

## Opt out security groups of sharing data

You can opt out security groups of users who don't want to share their communication and collaboration data. For example, opt out users or groups such as C-suite, M&A, finance, and so on.

To opt out, follow the steps in [provide consent](#provide-consent). 

### See also

[Insights generated from Microsoft 365 data](insights-from-m365.md)  
[Configure relationship analytics and health](configure-relationship-analytics.md)  
[Use relationship analytics to gather KPIs](./relationship-analytics.md)  
[Configure who knows whom](configure-who-knows-whom.md)  
[How to get introduced to leads or contacts](who-knows-whom.md)  