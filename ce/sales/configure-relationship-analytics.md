---
title: Configure relationship analytics and health
description: Configure relationship analytics to help sales teams monitor customer relationship health and risks in Dynamics 365 Sales.
ms.date: 08/19/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Configure relationship analytics and health

Configure relationship analytics to specify whether you want to use Exchange data for enhanced insights. You can also configure parameters that would determine the customer relationship health. These configurations are only supported for Sales Premium customers.

> [!NOTE]
> No specific configuration is required for basic relationship intelligence; it's enabled by default. For more information, see [Basic relationship insights](relationship-analytics-overview.md#basic-relationship-insights).

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


>[!IMPORTANT]
>This feature is intended to help sellers or sales managers enhance their team’s performance. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with users. This also includes adequately notifying users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with users may be monitored, recorded, or stored.

## Prerequisite

- [Enable relationship analytics](enable-ri.md)


## Configure relationship analytics

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**. 
   
3. Under **Relationship insights**, select **Analytics and Health**.  
        :::image type="content" source="./media/si-admin-relationship-analytics-enable-in-organization.png" alt-text="A screenshot of the Relationship analytics and health settings page.":::
    When you enable the relationship analytics feature, exchange integration is also automatically enabled. However, the integration won't work until your Microsoft 365 admin provides consent for Dynamics 365 to collect the data.  

1. Turn off **Exchange Online** if you don't want to include emails and meetings from Exchange Online in KPI calculations and analytics. In this case,  relationship analytics will be generated from emails and data stored in Dynamics 365.


1. Turn on **Relationship Health** to show the relationship health score in opportunities, views, and charts.

    >[!NOTE]
    >You can turn off this option if you don't want to show the score. However, relevant health data is still collected.

    :::image type="content" source="./media/relationship-analytics-relationship-health-enable.png" alt-text="A screenshot of the Relationship Health option in the Relationship analytics and health settings page.":::

1. Under **Activity influence**, adjust the sliders according to the relative importance of common activities in calculating the relationship health score.  

    :::image type="content" source="./media/relationship-analytics-relationship-health-adjust-activity.png" alt-text="A screenshot of the Relationship analytics and health settings page, with the Activity influence settings shown.":::

1. In **Communication Frequency**, select how often your organization expects sales teams to communicate with customers.

    The value you select influences the expectation of more recent frequent communications in the health score. Less frequent communication reduces the expectation. More frequent communication increases it.

1. Under **Health score grading**, set the range of health scores to grade opportunities. To change the default values, point to the minimum value in the range and select the up or down arrow or type a new value.

    When the health score is calculated, the opportunities in your organization's pipeline are graded as Good, Fair, or Poor, according to the ranges you defined. Grading can take up to 24 hours.

    If you change a grade's minimum value, the adjacent grade's maximum value changes automatically with it. For example, if you change the minimum value for Good to *50*, the maximum value for Fair changes to *49*.

1. Select **Save**.
    Relationship analytics is now enabled and configured for your organization. 

For more information about how to view the analytics, see [Use relationship analytics to gather KPIs](../sales/relationship-analytics.md).


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[System and application users who can push data to Dataverse](/power-platform/admin/system-application-users)  
[Add Relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md)  
[GDPR for Sales Insights](embedded-intelligence-gdpr.md)  
[View and export KPI data (GDPR)](view-export-KPI-data-gdpr.md)  
[Relationship analytics and health FAQ](faqs-sales-insights.md#relationship-analytics-and-health)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
