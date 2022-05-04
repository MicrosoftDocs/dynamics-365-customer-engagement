---
title: Configure relationship analytics and health
description: Configure relationship analytics to help sales teams monitor customer relationship health and risks in Dynamics 365 Sales.
ms.date: 03/28/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Configure relationship analytics and health

Your organization's sales teams can use the relationship analytics in Dynamics 365 Sales to monitor the health and risks of their customer relationships. Graphical representations of KPIs and activity histories are available for any contact, opportunity, lead, or account. Detailed analytics about customer interactions, patterns, and trends are based on interaction data from Dynamics 365 and Office. With more accurate and complete relationship information, sales teams can more effectively identify customers who need their attention.

Relationship analytics appears on Sales Insights opportunity record forms. Relationship health appears on opportunity record forms, list views, and charts.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


>[!IMPORTANT]
>This feature is intended to help sellers or sales managers enhance their team’s performance. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with users. This also includes adequately notifying users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with users may be monitored, recorded, or stored.

## Turn on and configure relationship analytics and health

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
1. Under **Relationship insights**, select **Analytics and health**.

    >[!NOTE]
    >If you don't see **Analytics and health**, make sure the advanced Sales Insights features are turned on. To learn more, see [Install and configure premium Sales Insights features](./intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features).

1. Turn on **Relationship analytics and health**.

1. Under **Data Sources**, select **Exchange Online** ​to include emails from Exchange Online in KPI calculations and analytics.

    >[!NOTE]
    >- Your Office 365 administrator must give consent to use Office 365 data before relationship analytics can include Exchange Online emails. If consent hasn't been given, a message displays stating the same. Work with your Office 365 administrator to get consent. For more information, see [Provide consent for collecting data from Office 365](./provide-consent-office365.md).  
    >- The application analyzes the Exchange emails data pertaining to two years, including the current year.  

    :::image type="content" source="./media/si-admin-relationship-analytics-enable-in-organization.png" alt-text="A screenshot of the Relationship analytics and health settings page.":::

1. To show the relationship health score in opportunities, views, and charts, turn on **Relationship Health**.

    >[!NOTE]
    >You can turn this option off if you don't want to show the score. However, relevant health data is still collected.

    :::image type="content" source="./media/relationship-analytics-relationship-health-enable.png" alt-text="A screenshot of the Relationship analytics and health settings page, with the Relationship Health option shown.":::

1. Under **Activity influence**, adjust the sliders according to the relative importance of common activities in calculating the relationship health score.  

    :::image type="content" source="./media/relationship-analytics-relationship-health-adjust-activity.png" alt-text="A screenshot of the Relationship analytics and health settings page, with the Activity influence settings shown.":::

1. In **Communication Frequency**, select how often your organization expects sales teams to communicate with customers.

    The value you select influences the expectation of more recent frequent communications in the health score. Less frequent communication reduces the expectation. More frequent communication increases it.

    :::image type="content" source="./media/relationship-analytics-communication-frequency.png" alt-text="A screenshot of the Relationship analytics and health settings page, with the Communication Frequency option shown.":::

1. Under **Health score grading**, set the range of health scores to grade opportunities. To change the default values, point to the minimum value in the range and select the up or down arrow or type a new value.

    When the health score is calculated, the opportunities in your organization's pipeline are graded as Good, Fair, or Poor, according to the ranges you defined. Grading can take up to 24 hours.

    If you change a grade's minimum value, the adjacent grade's maximum value changes automatically with it. For example, if you change the minimum value for Good to *50*, the maximum value for Fair changes to *49*.

    :::image type="content" source="./media/relationship-analytics-health-score-grading.png" alt-text="A screenshot of the Relationship analytics and health settings page, with the Health score grading settings shown.":::

1. Select **Save**.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Use relationship analytics to gather KPIs](../sales/relationship-analytics.md)  
[Add Relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md)  
[GDPR for Sales Insights](embedded-intelligence-gdpr.md)  
[View and export KPI data (GDPR)](view-export-KPI-data-gdpr.md)  
[Relationship analytics and health FAQ](faqs-sales-insights.md#relationship-analytics-and-health)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
