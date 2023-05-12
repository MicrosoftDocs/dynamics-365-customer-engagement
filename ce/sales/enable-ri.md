---
title: Enable relationship intelligence
description: Enable relationship intelligence in Dynamics 365 Sales Premium to provide relationship analytics and who knows whom information to your sellers.
ms.date: 08/19/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---
# Enable relationship intelligence  

Enable relationship intelligence in Dynamics 365 Sales Premium to give your sales team important insights based on their interactions with customers. Relationship analytics KPIs, customer relationship health scores to know which customers need attention, and who knows whom suggestions for introductions to leads help your sellers be more effective.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisite

- Ensure that advanced Sales Insights features are turned on. To learn more, see [Install and configure premium Sales Insights features](./intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features).

## Enable relationship intelligence

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
     
3.  Under **Relationship insights**, select **Overview**.  
    :::image type="content" source="media/enable-ri-overview.png" alt-text="A screenshot of the Overview page to enable the relationship intelligence features":::

1. Under **Get started with Relationship Intelligence**, select **Enable**.
    The relationship intelligence features&mdash;relationship analytics and who knows whom&mdash;are turned on by default.  


1. Select the security roles of users whose Exchange data will be used to generate relationship insights.  
    The security role selection only applies to Exchange data. Data and emails stored in Dynamics 365 will be used to generate insights by default.

    > [!NOTE]
    >- If you don't want to collect Exchange data at all, you can [turn off exchange integration](configure-relationship-analytics.md) 
 
1. Save the changes.  
    Relationship intelligence features are enabled but you must complete the [next steps](#next-steps), for the features to be fully functional. 


## Next steps

- Work with your Microsoft 365 admin to [provide consent to use Exchange data](provide-consent-office365.md).

    - Until the consent is provided, a banner is displayed on the Relationship insights **Overview** page to notify the pending action.  
    :::image type="content" source="media/enable-ri-overview-banner.png" alt-text="A screenshot highlighting the message banner when the consent isn't provided":::

    - Make sure to get the consent within 14 days of turning on the relationship intelligence features. Otherwise, who knows whom and Exchange integration for relationship analytics will be automatically turned off on the 14th day.  

- Select **Options** in the respective feature section to configure the feature. For more information on what you can configure, see:
    - [Configure relationship analytics and health](configure-relationship-analytics.md)
    - [Configure who knows whom](configure-who-knows-whom.md) 
- [Add Relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md) if your organization is using a custom sales app or a custom form for lead or contact.



[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
