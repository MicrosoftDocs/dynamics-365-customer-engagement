---
title: Turn on and set up Copilot in Dynamics 365 Sales
description: Learn how to turn on and set up Copilot in Dynamics 365 Sales to improve sales productivity and effectiveness. 
ms.date: 10/03/2024
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
---

# Turn on and set up Copilot in Dynamics 365 Sales

<a name="default-setting-copilot"></a>

Copilot in Dynamics 365 Sales is turned on by default for the following orgs:

- Orgs in [regions where an Open AI Service endpoint is available](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features). 

- Orgs that have [provided consent for data movement across regions](/power-platform/admin/geographical-availability-copilot#turn-on-copilots-and-generative-ai-features) and set the [release channel](/power-apps/maker/model-driven-apps/channel-change) for the sales app to **Monthly release channel**.

For all the other orgs, an admin must provide consent in the Power Platform admin center and then turn on Copilot in the Sales Hub app. This article provides instructions for turning Copilot on or off, providing consent for data movement, and configuring Copilot for your business.

> [!IMPORTANT]
>- If you had previously turned Copilot off, it remains turned off. 
>- Throughout this article, the term sales apps refers to apps that have lead and opportunity tables and are not part of the [exclusion list](sales-copilot-faq.md#are-there-any-applications-where-copilot-in-dynamics-365-sales-cant-be-used)

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator](security-roles-for-sales.md) |

For more information about the licensing requirements for Copilot in Dynamics 365 Sales, see [licensing FAQs](/power-platform/admin/powerapps-flow-licensing-faq#licensing-for-copilot-chat-and-form-fill-assistance-in-model-driven-apps)

## Prerequisites

- Verify whether your org is in a region where Copilot in Dynamics 365 Sales is available. For a list of regions where Copilot is available, see the [Copilot international availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotproductreport).
- Verify whether your [region has an Azure OpenAI Service endpoint](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features). If not, you must provide the following [consent in the Power Platform admin center](/power-platform/admin/geographical-availability-copilot#turn-on-copilots-and-generative-ai-features):
  - Consent for data movement across regions to use Copilot in Dynamics 365 Sales.  
  - Consent for Copilot to use Bing search so that your sellers can get the latest news about their accounts.

## Turn Copilot features on or off in Sales Hub

Turning on Copilot features turns on the chat and embedded Copilot experiences in the Sales apps.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

     :::image type="content" source="media/enable-copilot.png" alt-text="Screenshot of the  settings page in Dynamics 365 Sales Hub." lightbox="media/enable-copilot.png":::  

1. Select **Turn audit on** to turn on audit history for the lead, opportunity, and account tables. If auditing is already turned on for these tables or globally, the **Turn audit on** option isn't displayed.

    - Audit history is required for Copilot to display recent changes to leads, opportunities, and accounts.
    - If you configure Copilot to [show recent changes from tables other than lead, opportunity, and account tables](copilot-configure-summary-fields.md), turning on auditing turns on audit history for those tables as well. However, if you remove those fields later, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for those tables manually.

1. If your org is in a region where Azure Open AI Service endpoint isn't available but you didn't provide the consent for data movement, select **Go to Power Platform admin center** and follow the [instructions to provide consent](/power-platform/admin/geographical-availability-copilot#turn-on-copilots-and-generative-ai-features-1).

1. Under **All apps**, select a global setting that you want to apply to all Sales apps and then override the setting at the app-level. For example, if you want to enable Copilot only for the Sales Hub app, select **Off** for **All apps** and then select **On** only for the Sales Hub app under **Individual apps** > **Sales Hub**.

    The initial setting on the **Set up Copilot in Dynamics 365 Sales** page depends on the setting for the org and the app. For example, if your Power Platform admin turned Copilot on for your org but your Power Apps admin turned it off for the Sales Hub app, the initial setting in the **Set up Copilot in Dynamics 365 Sales** page is set to **Off** for Sales Hub app and **On** for all other Sales apps.

    The **Default** setting applies the [default behavior](#default-setting-copilot) explained at the beginning of this article.
1. Select **Try our newest preview features before they're rolled out to everyone** to get all the Copilot preview features automatically.
1. Turn on **Email (preview)** to get the [Copilot email experience](compose-send-email-copilot.md). This option is enabled only after you turn on the **Try our newest preview features before they're rolled out to everyone** option.
1. Select **Save**.

<a name="add-glossary"></a>
## Train Copilot to understand your business terms (preview)

You can train Copilot in Dynamics 365 Sales to understand your business terms by adding a glossary. The glossary helps Copilot understand your business terms and their context, and respond to your requests more accurately. For example, if you have a custom field called **custom revenue** in the **opportunity** table, you can add a glossary term to help Copilot understand that **opportunity revenue** refers to the **custom revenue** column in the **opportunity** table.

> [!NOTE]
> The glossary feature is currently available only in English.

**To add glossary terms:**

1. Open [Copilot Studio](copilotstudio.microsoft.com) and select your Dynamics 365 Sales environment.

1. Open **Sales Copilot Power Virtual Agents Bot** under **Agent** section.
1. Select **SalesSpecificQnA** under **Knowledge** section.
       :::image type="content" source="media/Natural_chat_Glossary.png" alt-text="Screenshot of the glossary configuration page in Copilot Studio.":::
1. Select the **Glossary** section and enter the term and description and click **Next** to add the term. [See some sample terms and descriptions](#sample-term-and-description).
1. Select **Save** after you have added all the terms.
   The updated glossary terms are available after 15 minutes in the Copilot chat experience in Dynamics 365 Sales.

### Sample term and description

| Scenarios  | Term  | Description |
|-----------------------|---------|-----------------------|
| **Acronym** | VP | ‘VP’ refers to ‘Vice President’ value in ‘JobTitle’ column in ‘Contact’ table |
| **Custom ownership** (Specify your ownership instead of using the record owner id) | activity owner  | activity owner is identified by 'PartyId' column in 'ActivityParty' table.  |
| **Custom field** (Use a custom field instead of the OOB system columns or table) | opportunity revenue  | opportunity revenue refers to ‘custom revenue’ column in ‘opportunity' table  |
| **Complex rules/filter** (Define your tailored rules and guidelines) | overdue task  | ‘overdue task’ refers to ‘state code’ column with value ‘open’ in ‘task’ table and ‘scheduled end date’ column in ‘task’ table with value less than today.  |

## Add the Copilot page site map entry to custom sales app

When you create a custom model-driven app, you can choose a default solution to create a site map for it. However, you can choose solutions that are based on table forms only. The full-screen Copilot page is based on a URL custom control and doesn't appear in the list of solutions. You must add it to the site map manually.  

Add the Copilot page to your site map by following the instructions in [add site map entry to your custom app](add-custom-site-map.md) and enter or paste the following URL:

`/main.aspx?&pagetype=control&controlName=PowerApps.Copilot`

## Next steps

- [Configure fields for generating summaries and recent changes list](copilot-configure-summary-fields.md)
- [Configure fields for generating what's new with my sales records list](copilot-configure-whatsnew-field.md)
- [Configure Copilot to use specific SharePoint locations](copilot-sharepoint-config.md)


## Related information

- [Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)
- [Copilot data movement](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features)  
- [FAQs about Copilot in Dynamics 365 Sales](sales-copilot-faq.md)
