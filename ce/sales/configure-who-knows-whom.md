---
title: "Configure who knows whom"
description: "Configure who knows whom to help sellers quickly identify colleagues within their organization who can introduce them to leads or contacts."
ms.date: 05/13/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# Configure who knows whom 

The Who knows whom feature helps sellers to quickly identify colleagues who can introduce them to leads or contacts, based on their email interactions. 

>[!NOTE]
>- To know whether the Who knows whom feature is available in your region, see [In which region are the features available?](faqs-sales-insights.md#in-which-region-are-the-features-available).
>- For Office 365 data, your organization's data location must be in one of the following locations and not in your region-specific datacenter location:
>    - Global Geography 1 – EMEA (Austria, Finland, France, Ireland, Netherlands)
>    - Global Geography 2 – Asia Pacific (Hong Kong, Japan, Malaysia, Singapore, South Korea).
>    - Global Geography 3 – Americas (Brazil, Chile, United States).    
> To learn more on data center locations, see [Data Center Locations](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide#data-center-locations&preserve-view=true).

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Turn on the who knows whom feature

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**. 
     
3.  Under **Relationship insights**, select **Overview**.

    >[!NOTE]
    >If you don't see **Relationship insights**, make sure the advanced Sales Insights features are turned on. To learn more, see [Install and configure premium Sales Insights features](./intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features).

1. Turn on the toggle under **Get started with Relationship Intelligence** to enable the relationship intelligence features such as relationship analytics and who knows whom.
1. Turn on **Who Knows Whom**.
    > [!div class="mx-imgBorder"]
    > ![Enable who knows whom](media/si-admin-who-knows-whom-enable.png "Enable who knows whom")

5. (Optional) Select the email template to use when a seller wants to contact a colleague to get introduced to a lead or contact. By default, the who knows whom introduction emails template is selected.
    
    The following screenshot shows an example introduction email:

    :::image type="content" source="media/wkw_mail_to_introduction.png" alt-text="Screenshot of an example introduction email":::
    > [!NOTE]
    > For instructions on creating a new email template, go to [Create email templates](/powerapps/user/email-template-create) 

6. Select **Save**.
    Who knows whom requires a consent from the Microsoft 365 administrator to use Exchange data. If the consent hasn't been given, the following message is displayed: 
    
    `Who knows whom is enabled but not active. Aggregated insights for users consent required for office data.`

    For more information about the consent and where to provide it, see [Provide consent for collecting data from Office 365](./provide-consent-office365.md).  

    > [!NOTE]
    > After the consent is provided, Dynamics 365 will analyze Exchange emails pertaining to the last two years.  


**Next steps:**

- If your organization is using a custom sales app or a custom form for lead or contact, add the [Who Knows Whom widget](add-ri-widgets-to-custom-form.md) to your app. The widget makes the who knows whom information available to sellers.


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Get introduced to a lead](../sales/who-knows-whom.md)  
[Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features)  
[Who knows whom FAQs](faqs-sales-insights.md#who-knows-whom)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
