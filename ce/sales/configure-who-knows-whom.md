---
title: "Configure who knows whom"
description: "Configure who knows whom to help sellers quickly identify colleagues who can introduce them to leads or contacts."
ms.date: 02/07/2023
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Configure who knows whom

The Who knows whom feature helps your sales organization quickly identify colleagues who can introduce them to leads or contacts, based on their interactions through emails and meetings. Configure the feature to select an email template to use for introductions.  


>[!NOTE]
>- [Basic who knows whom information](who-knows-whom.md#basic-who-knows-whom-information) is available out-of-the-box in all regions for Sales Enterprise users and doesn't require any setup.
>- [Enhanced who knows whom information](who-knows-whom.md#enhanced-who-knows-whom-information) is available for Sales Premium users and is available only in [specific regions](faqs-sales-insights.md#in-which-region-are-the-features-available).
>- For Office 365 data, your organization's data location must be in one of the following locations and not in your region-specific datacenter location:
>    - Global Geography 1 – EMEA (Austria, Finland, France, Ireland, Netherlands)
>    - Global Geography 2 – Asia Pacific (Hong Kong SAR, Japan, Malaysia, Singapore, South Korea).
>    - Global Geography 3 – Americas (Brazil, Chile, United States).    
> To learn more on data center locations, see [Data Center Locations](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide#data-center-locations&preserve-view=true).

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisite

- [Enable premium Sales Insights features](intro-admin-guide-sales-insights.md#enable-and-configure-premium-sales-insights-features).
- [Turn on who knows whom in relationship intelligence](enable-ri.md).  
- [Set up server-side synchronization of email, appointments, contacts, and tasks](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks)
   
## Configure who knows whom 

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**. 
   
3.  Under **Relationship insights**, select **Who Knows Whom**.

4. Select an email template to use for requesting introductions. This email template is used when a seller contacts a colleague to get introduced to a lead or contact. 
    
    The following screenshot shows an example introduction email using the default email template:

    :::image type="content" source="media/wkw_mail_to_introduction.png" alt-text="Screenshot of an example introduction email":::

    [Learn how to create an email template](/powerapps/user/email-template-create).  

6. Select **Save**.
After you enable who knows whom, you must complete the [next steps](#next-steps) for the feature to be fully functional.  

## Next steps

- Work with your Microsoft 365 admin to [provide consent to use Exchange data](provide-consent-office365.md).

    Make sure to get consent within 14 days of turning on the relationship intelligence features. Otherwise, who knows whom will be automatically turned off on the 14th day. However, you'll continue to get the out-of-the-box who knows whom information from Dynamics 365 data.  

- If you'd like roles other than Salesperson and Sales Manager to access the who knows whom information, [grant access to those roles](grant-access-wkw.md).  

- [Add relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md) if your organization is using a custom sales app or a custom form for leads or contacts.

 

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also
[System and application users who can push data to Dataverse](/power-platform/admin/system-application-users)  
[Get introduced to a lead](../sales/who-knows-whom.md)  
[Who knows whom FAQs](faqs-sales-insights.md#who-knows-whom)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

