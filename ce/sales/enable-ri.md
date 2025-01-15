---
title: Enable and configure relationship intelligence
description: Enable relationship intelligence in Dynamics 365 Sales Premium to provide relationship health and who knows whom information to your sellers.
ms.date: 01/10/2025
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - bap-template
  - references_regions
---
# Enable relationship intelligence  

Enable relationship intelligence in Dynamics 365 Sales Premium to give your sales team important insights based on their interactions with customers. Relationship analytics KPIs, customer relationship health scores to know which customers need attention, and who knows whom suggestions for introductions to leads help your sellers be more effective.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisite

- Ensure that [advanced Sales Insights features are enabled](intro-admin-guide-sales-insights.md#enable-and-configure-premium-sales-insights-features). 

- If you want Dynamics 365 Sales to use emails and meetings from Exchange to generate insights, [enable server-side synchronization for Exchange](configure-email.md). Otherwise, insights are generated only using emails and data stored in Dynamics 365.


## Enable and configure relationship intelligence

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
     
3.  Under **Relationship insights**, select **Overview**.  
    :::image type="content" source="media/enable-ri-overview.png" alt-text="A screenshot of the Overview page to enable the relationship intelligence features":::

1. Under **Get started with Relationship Intelligence**, select **Enable**.
    The relationship intelligence features&mdash;relationship analytics and who knows whom&mdash;are turned on by default.  
    >[!NOTE]
    >If you turn off Relationship Analytics, you won't see the scores. However, relevant health data is still collected.

1. Select the security roles of users who need access to relationship insights.  
1. (Optional) Select **Options** next to **Relationship Health** to configure ranges for grading opportunities based on health scores.
1. (Optional) Select **Options** next to **Who knows whom** to select an email template to use for introductions. 
1. Save the changes.
1. [Add Relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md) if your organization is using a custom sales app or a custom form for lead or contact.


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
