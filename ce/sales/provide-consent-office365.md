---
title: Provide consent to collect data from Microsoft 365
description: Provide consent for Dynamics 365 to use data from Microsoft 365 for relationship analytics and who knows whom.
ms.date: 08/11/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Provide consent to collect data from Microsoft 365  

Dynamics 365 Sales uses Microsoft 365 data to generate the following insights based users email interactions and meetings:

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

- The consent provided in the old form for relationship analytics will expire in September 2022 and consent for who knows whom will expire on August 11, 2022. Provide consent in the new form as early as possible to avoid any loss of functionality.

- Both relationship analytics and who knows whom require the same consent so you only need to consent once in the new form.

- The consent provided is applicable to all the Dynamics 365 applications that require permission to access Microsoft 365 data.

- When consent is provided, Dynamics 365 analyzes Exchange emails pertaining to the last one year to provide relationship insights and who knows whom suggestions. The analysis happens in 12 batches, with each batch containing emails for one month. Dynamics 365 can handle up to 8 million emails per month in this process. 

- When you disable the consent, the system can take up to 24 hours to remove data from all apps and up to 30 days to remove backed-up data from Microsoft 365 storage accounts. 


## Provide consent 

If you're a Microsoft 365 administrator, here's how you provide consent:

1. In **Microsoft 365 admin center**, select **Settings** > **Org settings** > **Dynamics 365 Applications**.

    :::image type="content" source="./media/office365-consent-form.png" alt-text="A screenshot of the Microsoft 365 admin center Org settings, with the Dynamics 365 Apps consent form shown.":::
    
3. Read the description carefully and select the **Identifiable insights for other users** option.  
    > [!NOTE]
    > The consent provided is applicable to all the Dynamics 365 applications that require the **Identifiable insights for other users** permission. In the case of Dynamics 365 Sales, this consent is used for both relationship analytics and who knows whom.

    A textbox to enter the security group IDs is displayed. 

4. (Optional) In the textbox, enter the security group IDs of users who want to opt out of sharing their communication and collaboration data.
    
    > [!NOTE]
    > Individual users can opt out too. For more information, see [Turn off data sharing with Dynamics 365 applications](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications)

1. Save the changes.  
    Dynamics 365 applications can now now use the Microsoft 365 data to generate insights.


### See also

[Insights generated from Microsoft 365 data](insights-from-m365.md)  
[Configure relationship analytics and health](configure-relationship-analytics.md)  
[Use relationship analytics to gather KPIs](./relationship-analytics.md)  
[Configure who knows whom](configure-who-knows-whom.md)  
[How to get introduced to leads or contacts](who-knows-whom.md)  