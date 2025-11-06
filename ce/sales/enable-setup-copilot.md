---
title: Turn on and set up Copilot in Dynamics 365 Sales
description: Learn how to turn on and set up Copilot in Dynamics 365 Sales to improve sales productivity and effectiveness. 
ms.date: 05/16/2025
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
  - ignite-2024
---

# Turn on and set up Copilot in Dynamics 365 Sales

<a name="default-setting-copilot"></a>

If you turned off Copilot in Dynamics 365 Sales, it remains turned off. Otherwise, Copilot is turned on by default for:

- Organizations in [regions where an Azure OpenAI Service endpoint is available](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features).  
- Organizations that [provide consent for data movement across regions](/power-platform/admin/geographical-availability-copilot#turn-on-copilots-and-generative-ai-features) and [select the monthly release channel](/power-apps/maker/model-driven-apps/channel-change) for the sales app.

For all other organizations, an admin must provide consent for cross-region data movement in the Power Platform admin center and then turn on Copilot in the Sales Hub app. This article provides instructions for providing consent for data movement and turning Copilot on or off.

Even if your organization is in a region where an Azure OpenAI Service endpoint is available, we suggest enabling cross-region data movement as a fallback option. This helps avoid interruption to Copilot service in case of an Open AI service outage in your region.

Throughout this article, the term "sales app" refers to apps that have lead and opportunity tables and aren't on the [exclusion list](sales-copilot-faq.md#are-there-any-applications-where-copilot-in-dynamics-365-sales-cant-be-used).

## Prerequisites

- Make sure that your organization is in one of the [regions where Copilot in Dynamics 365 Sales is available](https://releaseplans.microsoft.com/availability-reports/?report=copilotproductreport).

- Make sure that your region has an Azure OpenAI Service endpoint. Check the list of [regions where data is processed for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features). If it doesn't, you must [provide consent for data movement](#provide-consent-for-data-movement) in the Power Platform admin center.

- Make sure that your organization's [data loss prevention policies allow the connectors that Copilot requires](sales-copilot-faq.md#copilot-isnt-working-what-should-i-do).

- Make sure that your tenant admin has [turned on Copilot in Dynamics 365 Sales in Power Platform Admin Center](/power-platform/admin/copilot/copilot-hub#turn-on-ai-capabilities-in-dynamics-365-sales).

## Provide consent for data movement

If your organization is in a region where an Azure OpenAI Service endpoint isn't available, you must provide consent for data movement across regions to use Copilot in Dynamics 365 Sales. You may also provide consent for Bing search so that your sellers can get the latest news about their accounts. Sellers can [turn off Bing search](use-sales-copilot.md#turn-off-bing-search) if they don't want Copilot to use it.

[Turn on data movement and Bing search for Copilot and generative AI features](/power-platform/admin/geographical-availability-copilot?branch=main#turn-on-data-movement-bing-search-and-m365-for-copilots-and-generative-ai-features).

## Turn Copilot features on or off in Sales Hub

Turning on Copilot features enables the chat and embedded Copilot experiences in sales apps.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

     :::image type="content" source="media/enable-copilot.png" alt-text="Screenshot of the Copilot settings page in Dynamics 365 Sales Hub." lightbox="media/enable-copilot.png":::  

    <a name="turn-audit-on"></a>

1. To turn on audit history for the lead, opportunity, and account tables, select **Turn audit on**.

    If auditing is already turned on for these tables or globally, the **Turn audit on** option isn't displayed.

    Audit history is required for Copilot to display recent changes to leads, opportunities, and accounts. If you configure Copilot to [show recent changes from other tables](copilot-configure-summary-fields.md), turning on auditing turns on audit history for those tables as well. However, if you remove those summary fields later, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for those tables manually.

1. Under **All apps**, select a global setting to apply to all sales apps.

    The **Default** setting applies the [default behavior](#default-setting-copilot). 

    You can override the global setting at the app level. For example, to turn on Copilot only for the Sales Hub app, select **Off** for **All apps**, and then under **Individual apps**, select **On** only for the Sales Hub app.

    The initial setting depends on the setting for both the organization and the app. For example, if your Power Platform admin turned Copilot on for your organization, but your Power Apps admin turned it off for the Sales Hub app, the initial setting is **Off** for the Sales Hub app and **On** for all other sales apps.

1. To get all Copilot preview features automatically, select **Try our newest preview features before they're rolled out to everyone**.

1. Select **Save**.

## Add the Copilot page site map entry to a sales app

The full-screen Copilot page is based on a URL custom control and not a table form. If your custom model-driven app uses a solution that's based on a table form, the full-screen Copilot page doesn't appear in the list of solutions. You must add the custom control to the site map manually.  

Follow the instructions in [Add pages to your app's site map](add-custom-site-map.md). Select **URL** and enter or paste the following URL:

`/main.aspx?&pagetype=control&controlName=PowerApps.Copilot`

## Next steps

- [Configure fields for generating summaries and recent changes](copilot-configure-summary-fields.md)
- [Configure fields for generating what's new with my sales records list](copilot-configure-whatsnew-field.md)
- [Configure Copilot to use specific SharePoint folders](copilot-sharepoint-config.md)

## Related information

- [Ask questions of Copilot in Dynamics 365 Sales](use-sales-copilot.md)
- [Move data across regions for Copilot and generative AI features](/power-platform/admin/geographical-availability-copilot)
- [FAQ about Copilot in Dynamics 365 Sales](sales-copilot-faq.md)
