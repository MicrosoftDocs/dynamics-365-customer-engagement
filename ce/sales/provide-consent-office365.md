---
title: Provide consent to collect data from Microsoft 365
description: Provide consent for Dynamics 365 to use data from Microsoft 365 for relationship analytics and who knows whom.
ms.date: 11/04/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Provide consent to collect data from Microsoft 365  

Dynamics 365 Sales uses Microsoft 365 data to generate the following insights based on users' email interactions and meetings:

- [Relationship analytics KPIs and health score](relationship-analytics.md)
- [Who knows whom suggestions](who-knows-whom.md)

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise, and Microsoft 365 <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Microsoft 365 administrator <br> |


## Things to consider

Before you provide consent, review the following information:

- Both relationship analytics and who knows whom require the same consent. You only need to consent once. For more information about the different consent types, see [Consent required to use Microsoft 365 data](ms365-consent-types.md).

- The consent applies to all the Dynamics 365 applications that require permission to access Microsoft 365 data.

- When consent is provided, Dynamics 365 analyzes Exchange emails pertaining to the last one year to provide relationship insights and who knows whom suggestions. The analysis is done in 12 batches, with each batch containing emails from one month. Dynamics 365 can handle up to 8 million emails per batch in this process. The live data is then processed after every 24 hours.

- When you withdraw consent, the system can take up to 24 hours to remove data from all apps and up to 30 days to remove backed-up data from Microsoft 365 storage accounts.  
- After you provide consent, all users in the tenant are automatically opted in to share their data, unless they've manually [turned off data sharing](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications). If you withdraw consent later, all users will be automatically opted out.  


## Provide consent  

1. In **Microsoft 365 admin center**, select **Settings** > **Org settings** > **Dynamics 365 Applications**.

    :::image type="content" source="./media/office365-consent-form.png" alt-text="A screenshot of the Microsoft 365 admin center Org settings, with the Dynamics 365 Apps consent form shown.":::
    
3. Select **Identifiable insights for other users**.  
    > [!NOTE]
    > The consent applies to all the Dynamics 365 applications that require the **Identifiable insights for other users** permission. Dynamics 365 Sales uses this consent for both relationship analytics and who knows whom.
    
1. (Optional) In the textbox that appears, enter the security group IDs of users who want to opt out of sharing their Exchange data. For example, opt out groups such as C-suite, M&A, finance, and so on.
    :::image type="content" source="media/admin-opt-out.PNG" alt-text="A screenshot of the opt out textbox to provide security IDs":::

1. Save the changes.
    The user opt-in is automatically turned on for all tenant users unless they've manually [turned off data sharing](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications).

     

### See also

[Consent required to use Microsoft 365 data](ms365-consent-types.md)  
[Insights generated from Microsoft 365 data](insights-from-m365.md)  
[Configure relationship analytics and health](configure-relationship-analytics.md)  
[Use relationship analytics to gather KPIs](./relationship-analytics.md)  
[Configure who knows whom](configure-who-knows-whom.md)  
[How to get introduced to leads or contacts](who-knows-whom.md)  