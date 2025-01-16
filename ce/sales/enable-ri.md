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

> [!NOTE]
>- [Basic relationship analytics](relationship-analytics-overview.md#basic-relationship-insights) is available out-of-the-box in all regions for Sales Enterprise users and doesn't require any setup.
>- [Enhanced relationship analytics](relationship-analytics-overview.md#enhanced-relationship-insights) is available for Sales Premium users and is available only in [specific regions](faq-region-language.md#in-which-countryregion-are-sales-premium-features-available).

> [!IMPORTANT]
> This feature is intended to help sellers or sales managers enhance their team's performance. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with users. This also includes adequately notifying users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with users may be monitored, recorded, or stored.

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
    The relationship intelligence features&mdash;relationship analytics and who knows whom&mdash;are turned on as well.  
    >[!NOTE]
    >If you turn off Relationship Analytics, you won't see the scores. However, relevant health data is still collected.

1. Save the changes.  
    Relationship intelligence features are enabled.

1. Select **Options** under each feature to configure the settings.
    - [Configure relationship analytics and health](#configure-relationship-analytics-and-health)
    - [Configure who knows whom](#configure-who-knows-whom)

## Configure relationship analytics and health

Configure relationship analytics to define parameters that would determine the customer relationship health. These configurations are only supported for Sales Premium customers.

1. Select **Analytics and health** under **Relationship insights** or select **Options** under **Who knows whom** on the **Get started with Relationship Intelligence** page.

1. Under **Activity influence**, update the numbers to indicate the relative importance of different activity types in determining relationship health. Provide a value between 3 and 9. Lower the value, higher the importance of the activity type. For example, if you would like to rank the activities in the following order of importance: Email, Phone call, and Appointment, you can set the values as 3,4, and 5 respectively.

    :::image type="content" source="./media/relationship-analytics-relationship-health-adjust-activity.png" alt-text="A screenshot of the Relationship analytics and health settings page.":::

1. In **Communication Frequency**, select how often your organization expects sales teams to communicate with customers.

    The value you select influences the expectation of more recent frequent communications in the health score. Less frequent communication reduces the expectation. More frequent communication increases it.

1. Under **Health score grading**, set the range of health scores to grade opportunities. To change the default values, point to the minimum value in the range and select the up or down arrow or type a new value.

    When the health score is calculated, the opportunities in your organization's pipeline are graded as Good, Fair, or Poor, according to the ranges you defined. Grading can take up to 24 hours.

    If you change a grade's minimum value, the adjacent grade's maximum value changes automatically with it. For example, if you change the minimum value for Good to *50*, the maximum value for Fair changes to *49*.

1. Select **Save**.
    Relationship analytics is now enabled and configured for your organization. 

For more information about how to view the analytics, see [Use relationship analytics to gather KPIs](../sales/relationship-analytics.md).

## Configure who knows whom

The who knows whom feature helps your sales organization quickly identify colleagues who can introduce them to leads or contacts, based on their interactions through emails and meetings. Configure the feature to select an email template to use for introductions.

1. Select **Who knows whom** under **Relationship insights** or select **Options** under **Who knows whom** on the **Get started with Relationship Intelligence** page.

1. Select an email template to use for introductions. The email template is used when a salesperson requests an introduction to a lead or contact from a colleague. 

    The following screenshot shows an example introduction email using the default email template:

    :::image type="content" source="media/wkw_mail_to_introduction.png" alt-text="Screenshot of an example introduction email.":::

    [Learn how to create an email template](/powerapps/user/email-template-create).  

1. Select **Save**.

## Next steps

[Add Relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md) if your organization is using a custom sales app or a custom form for lead or contact.


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
