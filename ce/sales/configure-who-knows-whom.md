---
title: Configure who knows whom
description: Configure who knows whom to help sellers quickly identify colleagues who can introduce them to leads or contacts.
ms.date: 07/25/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - bap-template
  - references_regions
---

# Configure who knows whom

The who knows whom feature helps your sales organization quickly identify colleagues who can introduce them to leads or contacts, based on their interactions through emails and meetings. Configure the feature to select an email template to use for introductions.  


>[!NOTE]
>- [Basic who knows whom information](who-knows-whom.md#basic-who-knows-whom-information) is available out-of-the-box in all regions for Sales Enterprise users and doesn't require any setup.
>- [Enhanced who knows whom information](who-knows-whom.md#enhanced-who-knows-whom-information) is available for Sales Premium users and is available only in [specific regions](faq-region-language.md#in-which-countryregion-are-sales-premium-features-available).
>- For Office 365 data, your organization's data location must be one of the following locations and not your region-specific data center location:
>    - Global Geography 1 – EMEA (Austria, Finland, France, Great Britain, Ireland, Netherlands)
>    - Global Geography 2 – Asia Pacific (Hong Kong SAR, Japan, Malaysia, Singapore, South Korea)
>    - Global Geography 3 – Americas (Brazil, Chile, United States)
>
> [Learn more on data center locations](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide#data-center-locations&preserve-view=true).

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Prerequisites

- [Enable premium Sales Insights features](intro-admin-guide-sales-insights.md#enable-and-configure-premium-sales-insights-features).
- [Turn on who knows whom in relationship intelligence](enable-ri.md).  
- [Set up server-side synchronization of email, appointments, contacts, and tasks](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks).

## Configure the who knows whom feature

1. In the lower-left corner of the screen, select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area."), and then select **Sales Insights settings**.

1. Under **Relationship insights**, select **Who Knows Whom**.

1. Select an email template for sellers to use when they contact a colleague to get an introduction.

    The following screenshot shows an example introduction email using the default email template:

    :::image type="content" source="media/wkw_mail_to_introduction.png" alt-text="Screenshot of an example introduction email.":::

    [Learn how to create an email template](/powerapps/user/email-template-create).  

1. Select **Save**.

## Next steps

After you enable who knows whom, you must complete the following steps for the feature to be fully functional.  

- Work with your Microsoft 365 admin to [provide consent to use Exchange data](provide-consent-office365.md).

    Make sure to get consent within 14 days of turning on the relationship intelligence features. Otherwise, who knows whom is automatically turned off on the 14th day. However, you continue to get the out-of-the-box who knows whom information from Dynamics 365 data.  

- If you'd like roles other than Salesperson and Sales Manager to access the who knows whom information, [grant access to those roles](grant-access-wkw.md).  

- [Add relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md) if your organization is using a custom sales app or a custom form for leads or contacts.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[System and application users who can push data to Dataverse](/power-platform/admin/system-application-users)  
[Get introduced to a lead](../sales/who-knows-whom.md)  

[!INCLUDE [footer-include](../includes/footer-banner.md)]
