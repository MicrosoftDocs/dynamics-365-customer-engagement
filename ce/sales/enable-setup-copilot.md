---
title: Turn on and set up Copilot in Dynamics 365 Sales
description: Learn how to turn on and set up Copilot in Dynamics 365 Sales to improve sales productivity and effectiveness. 
ms.date: 01/28/2025
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
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

For all other organizations, an admin must provide consent for cross-region data movement in the Power Platform admin center and then turn on Copilot in the Sales Hub app. This article provides instructions for providing consent for data movement, turning Copilot on or off, and training Copilot to understand your business-specific terms.

Throughout this article, the term "sales app" refers to apps that have lead and opportunity tables and aren't on the [exclusion list](sales-copilot-faq.md#are-there-any-applications-where-copilot-in-dynamics-365-sales-cant-be-used).

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator](security-roles-for-sales.md) |

Learn more about the licensing requirements for Copilot in Dynamics 365 Sales in [Licensing for Copilot chat and form fill assistance in model-driven apps](/power-platform/admin/powerapps-flow-licensing-faq#licensing-for-copilot-chat-and-form-fill-assistance-in-model-driven-apps).

## Prerequisites

- Make sure that your organization is in one of the [regions where Copilot in Dynamics 365 Sales is available](https://releaseplans.microsoft.com/availability-reports/?report=copilotproductreport).

- Make sure that your region has an Azure OpenAI Service endpoint. Check the list of [regions where data is processed for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features). If it doesn't, you must [provide consent for data movement](#provide-consent-for-data-movement) in the Power Platform admin center.

- Make sure that your organization's [data loss prevention policies allow the connectors that Copilot requires](sales-copilot-faq.md#copilot-isnt-working-what-should-i-do).  

## Provide consent for data movement

If your organization is in a region where an Azure OpenAI Service endpoint isn't available, you must provide consent for data movement across regions to use Copilot in Dynamics 365 Sales. You may also provide consent for Bing search so that your sellers can get the latest news about their accounts. Sellers can [turn off Bing search](use-sales-copilot.md#turn-off-bing-search) if they don't want Copilot to use it.

[Turn on data movement and Bing search for Copilot and generative AI features](/power-platform/admin/geographical-availability-copilot?branch=main#turn-on-data-movement-bing-search-and-m365-for-copilots-and-generative-ai-features).

## Turn Copilot features on or off in Sales Hub

Copilot features are the chat and embedded Copilot experiences in sales apps.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

     :::image type="content" source="media/enable-copilot.png" alt-text="Screenshot of the Copilot settings page in Dynamics 365 Sales Hub." lightbox="media/enable-copilot.png":::  

    <a name="turn-audit-on"></a>

1. To turn on audit history for the lead, opportunity, and account tables, select **Turn audit on**.

    If auditing is already turned on for these tables or globally, the **Turn audit on** option isn't displayed.

    Audit history is required for Copilot to display recent changes to leads, opportunities, and accounts. If you configure Copilot to [show recent changes from other tables](copilot-configure-summary-fields.md), turning on auditing turns on audit history for those tables as well. However, if you remove those summary fields later, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for those tables manually.

1. Under **All apps**, select a global setting to apply to all sales apps.

    The **Default** setting applies the [default behavior](#default-setting-copilot) explained at the beginning of this article.

    You can override the global setting at the app level. For example, to turn on Copilot only for the Sales Hub app, select **Off** for **All apps**, and then under **Individual apps**, select **On** only for the Sales Hub app.

    The initial setting depends on the setting for both the organization and the app. For example, if your Power Platform admin turned Copilot on for your organization, but your Power Apps admin turned it off for the Sales Hub app, the initial setting is **Off** for the Sales Hub app and **On** for all other sales apps.

1. To get all Copilot preview features automatically, select **Try our newest preview features before they're rolled out to everyone**.

1. Select **Save**.

<a name="add-glossary"></a>

## Train Copilot to understand your business terms (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]
[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

You can add domain-specific terms and acronyms to a glossary to train Copilot in Dynamics 365 Sales to understand your business terms. Let's say that you have a custom field called **Estd Revenue** in the **Opportunity** table that stores the estimated revenue for an opportunity. You can add a glossary term to help Copilot understand that when sellers ask about "opportunity revenue," they're referring to the **Estd Revenue** column in the **Opportunity** table.

> [!NOTE]
> The glossary feature is available only in English.

1. Open [Copilot Studio](https://copilotstudio.microsoft.com) and select your Dynamics 365 Sales environment.

1. Select **Agents** > **Sales Copilot Power Virtual Agents Bot**.

1. Select the **Knowledge** tab, and then select **SalesSpecificQnA**.

1. Under **Build your data glossary**, enter a term and description. [Sample terms and descriptions](#sample-terms-and-descriptions) are provided in the following section.

   :::image type="content" source="media/Natural_chat_Glossary.png" alt-text="Screenshot of the glossary configuration page in Copilot Studio.":::

1. To add the term to the glossary, select **Next**.

1. Select **Save** when you're finished adding terms.

Allow 15 minutes for new or updated glossary terms to become available in the Copilot chat experience in Dynamics 365 Sales.

### Sample terms and descriptions

The following table provides sample terms and descriptions that you can add to the glossary to help Copilot understand your business terms. Terms and descriptions are case-insensitive.

| Scenario | Term  | Description |
|----------|-------|-------------|
| Acronym | VP | "VP" refers to "Vice President" value in "JobTitle" column in "Contact" table |
| Custom ownership (the record owner isn't the activity owner) | activity owner | "activity owner" is identified by "partyid" column in "activityparty" table |
| Custom field (a table uses a custom field instead of the out-of-the-box system fields) | opportunity revenue | "opportunity revenue" refers to "Estd revenue" column in "Opportunity" table |
| Complex rules or filters | overdue task | "overdue task" refers to "state code" column with value "open" in "Task" table and "scheduled end date" column with value less than today in "Task" table |

## Add the Copilot page site map entry to a sales app

When you create a custom model-driven app, you can choose a default solution to create a site map for it, if the solution is based on a table form. Because the full-screen Copilot page is based on a URL custom control, not a table form, it doesn't appear in the list of solutions. You must add it to the site map manually.  

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
