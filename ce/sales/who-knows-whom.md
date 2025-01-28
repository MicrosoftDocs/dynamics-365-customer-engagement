---
title: Who knows whom in Dynamics 365 Sales
description: Learn how to use the who knows whom feature in Dynamics 365 Sales to quickly identify colleagues who can introduce you to a lead or contact.
ms.date: 07/25/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - bap-template
  - references_regions

---

# Use who knows whom to connect with leads and contacts  

The who knows whom feature in Dynamics 365 Sales helps you to quickly identify colleagues who can introduce you to a lead or contact.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise or Dynamics 365 Sales Premium<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## What is who knows whom?

Sales representatives often interact with leads they have never met. If only you knew someone who knows the lead, an introduction could increase the chances of a positive outcome. That's where who knows whom comes in. Who knows whom suggests colleagues who have interacted with the lead through emails or meetings. It even helps you quickly email your colleagues to request an introduction.

For Sales Enterprise users, who knows whom is based on emails and meetings in Dynamics 365. For Sales Premium users, it's based on Exchange data, provided your administrator has [set up integration with Exchange](configure-who-knows-whom.md). If you don't want Dynamics 365 to collect your Exchange data, you can [opt out of data sharing](#turn-off-data-sharing-with-dynamics-365-applications).

### Basic who knows whom information

For Sales Enterprise users, the who knows whom information is populated based on emails and meeting data in Dynamics 365. This information is available out-of-the-box in all regions and doesn't require any setup.  

### Enhanced who knows whom information

For Sales Premium users, the information is populated based on Exchange data, provided your administrator has [configured the integration](configure-who-knows-whom.md). If you don't want Dynamics 365 to collect your Exchange data, you can [opt out](#turn-off-data-sharing-with-dynamics-365-applications) of data sharing.  

> [!NOTE]
> If you opt in for [April 2025 early access](/power-platform/admin/opt-in-early-access-updates), you can connect to Exchange only using [server-side synchronization](configure-email.md). If you previously enabled the [Exchange integration](configure-relationship-analytics.md#configure-relationship-analytics) through relationship intelligence settings, it won't work for early access. Until server-side synchronization is set up, who knows whom only uses emails from Dynamics 365.

## View who knows whom  

[!INCLUDE [Lightbox tip](~/../shared-content/shared/lightbox-tip.md)]

The **Who Knows Whom** widget shows up to five people in your organization who have communicated with a lead or contact through calls and emails. It also shows you how strong their connection is. The widget is available in the **Sales Insights** form and in the main **Contact** and **Lead** form.

1. In the Sales Hub app, select a lead or a contact.

    :::image type="content" source="media/wkw-widget.png" alt-text="Screenshot of the Who Knows Whom widget." lightbox="media/wkw-widget.png":::

    If you see a message that you don't have sufficient privileges, ask your admin to give you the [necessary permissions](grant-access-wkw.md).

1. Select the icon in the upper-right corner of the **Who Knows Whom** widget to switch between graph and list views.
1. Based on the connection strength, identify a colleague who can introduce you to the lead and select **Get introduced**.

   > [!Note]
   > If you don't see the **Get introduced** button, ask your administrator to [set up server-side synchronization](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks).

1. Refine the template email and send it.

## Turn off data sharing with Dynamics 365 applications

You can opt out if you don't want Dynamics 365 to collect and analyze your Exchange data. Your Office 365 organization must be in one of the [EMEA or Asia Pacific global geographies](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide&preserve-view=true) to opt out of who knows whom data collection.

1. Sign in to your [Microsoft work account](https://myprofile.microsoft.com/).

2. Select **Settings & Privacy**, and then select the **Privacy** tab.

3. In the **Services** section, select the arrow next to **Dynamics 365 applications**.  

4. Turn off **Include my data in Dynamics 365 applications**.

## Related information

[Configure who knows whom](configure-who-knows-whom.md)


[!INCLUDE [footer-include](../includes/footer-banner.md)]
