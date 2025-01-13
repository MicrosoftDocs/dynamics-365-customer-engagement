---
title: Configure relationship analytics and health
description: Configure relationship analytics to help sales teams monitor customer relationship health and risks in Dynamics 365 Sales.
ms.date: 01/10/2025
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - bap-template
  - references_regions
---

# Configure relationship analytics and health

Configure relationship analytics to configure parameters that would determine the customer relationship health. These configurations are only supported for Sales Premium customers.

> [!NOTE]
>- [Basic relationship analytics](relationship-analytics-overview.md#basic-relationship-insights) is available out-of-the-box in all regions for Sales Enterprise users and doesn't require any setup.
>- [Enhanced relationship analytics](relationship-analytics-overview.md#enhanced-relationship-insights) is available for Sales Premium users and is available only in [specific regions](faq-region-language.md#in-which-countryregion-are-sales-premium-features-available).

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


>[!IMPORTANT]
>This feature is intended to help sellers or sales managers enhance their team's performance. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with users. This also includes adequately notifying users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with users may be monitored, recorded, or stored.

## Prerequisite

[Enable relationship analytics](enable-ri.md)


## Configure relationship analytics

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**. 
   
1. Under **Relationship insights**, select **Analytics and Health**.  
        :::image type="content" source="./media/si-admin-relationship-analytics-enable-in-organization.png" alt-text="A screenshot of the Relationship analytics and health settings page.":::

1. Turn on the toggle to be able to enable the relationship intelligence features.

1. Under **Enable for**, select the security roles that you want to enable relationship analytics for.  

1. Turn on **Relationship Analytics** to show the relationship health score and analysis in opportunities, views, and charts.

    >[!NOTE]
    >You can turn off this option if you don't want to show the score. However, relevant health data is still collected.

1. Select **Options** next to the toggle for **Relationship Analytics**.

1. In the **Relationship analytics and health** page, set the range of health scores to grade opportunities. To change the default values, point to the minimum value in the range and select the up or down arrow or type a new value.

    When the health score is calculated, the opportunities in your organization's pipeline are graded as Good, Fair, or Poor, according to the ranges you defined. Grading can take up to 24 hours.

    If you change a grade's minimum value, the adjacent grade's maximum value changes automatically with it. For example, if you change the minimum value for Good to *50*, the maximum value for Fair changes to *49*.

1. Select **Save**.
    Relationship analytics is now enabled and configured for your organization.

For more information about how to view the analytics, see [Use relationship analytics to gather KPIs](../sales/relationship-analytics.md).


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[System and application users who can push data to Dataverse](/power-platform/admin/system-application-users)  
[Add Relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md)  
[Sales Insights and privacy](embedded-intelligence-privacy.md)  
[View and export KPI data](view-export-KPI-data.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
