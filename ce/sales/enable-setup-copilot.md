---
title: Turn on and set up Copilot in Dynamics 365 Sales
description: Learn how to turn on and set up Copilot in Dynamics 365 Sales. Help your sales team can get summaries of their lead and opportunity records, catch up on recent changes, and prepare for meetings.
ms.date: 03/04/2024
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
---

# Turn on and set up Copilot in Dynamics 365 Sales

For orgs in North America, Copilot chat is turned on by default in all the Dynamics 365 sales apps. Effective February 5, 2024, the following features are turned on by default for orgs in North America that have opted in for the 2024 release wave 1 update (early access):

 - [Copilot for email](compose-send-email-copilot.md) 
 - [Copilot in email rich text editor](/power-apps/maker/model-driven-apps/use-copilot-email-assist)
 - [A new experience for the Copilot settings page](#turn-copilot-features-on-or-off-in-sales-hub)
 
[Learn about how to opt in for early access](/power-platform/admin/opt-in-early-access-updates#how-to-get-early-access-updates). 

For orgs in other regions, Copilot chat and Copilot for email features are turned off by default. 

> [!IMPORTANT]
>- If you had previously turned Copilot off, it remains turned off. In this case, Copilot for email is not turned on by default, even if your org is in North America and is opted in for early access.
>- Throughout this article, the term sales apps refers to apps that have lead and opportunity tables and are not part of the [exclusion list](sales-copilot-faq.md#which-applications-are-in-the-exclusion-list-for-copilot-in-dynamics-365-sales).

Read [this FAQ](sales-copilot-faq.md#what-are-the-early-access-changes-related-to-copilot-in-2024-release-wave-1) to understand the changes in the early access preview and how they'll affect you and your sales teams.

Use the instructions in this article to turn Copilot on or off and configure it for your business.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator](security-roles-for-sales.md) |

## Prerequisites

If you're in a region other than North America, provide consent for Copilot to process your data outside of your geographic region, compliance boundary, or national cloud instance. 

- Read the [Copilot data movement](sales-copilot-data-movement.md) article carefully.

- [Turn on data movement across regions](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions).
 
## Turn Copilot features on or off in Sales Hub

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. In the **Set up Copilot in Dynamics 365 Sales** page, select **Try our newest preview features before they're rolled out to everyone** to get all the Copilot preview features automatically.

1. If you didn't provide consent for data movement, select **Go to Power Platform admin center** and follow the [instructions to provide consent](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions).

1. Under **Enable Copilot for**, select a global setting that you want to apply for all Sales apps and then override the setting at the app-level. For example, if you want to enable Copilot only for the Sales Hub app, select **Off** for **All Dynamics 365 Sales apps** and then select **On** only for the Sales Hub app. 

    :::image type="content" source="media/enable-copilot-old.svg" alt-text="Screenshot of the Set up Copilot in Dynamics 365 Sales page in Dynamics 365 Sales Hub."::: 

    The settings page looks different for orgs in North America that have opted in for early access. The new settings page contains an option to turn on Copilot Chat and Email features at the global level for all Sales apps and individually for each Sales app. 

    :::image type="content" source="media/enable-copilot.svg" alt-text="Screenshot of the new settings page in Dynamics 365 Sales Hub.":::  

    The initial setting on the **Set up Copilot in Dynamics 365 Sales** page depends on the setting for the org and the app. For example, if your Power Platform admin turned Copilot on for your org but your Power Apps admin turned it off for the Sales Hub app, the initial setting in the **Set up Copilot in Dynamics 365 Sales** page is set to **Off** for Sales Hub app and **On** for all other Sales apps. 

    <a name="default-setting-copilot"></a>

    The **Default** setting has the following behavior:
    
    - For orgs in North America, Copilot Chat is turned on for all Dynamics 365 Sales apps (with lead and opportunity tables). Copilot for email is turned on only if you've opted in for early access.

    - For orgs in other regions, Copilot is turned on for all Dynamics 365 Sales apps that meet the following conditions:

        - Consent for data movement is provided for the org.

        - The [release channel](/power-apps/maker/model-driven-apps/channel-change) for the app is set to **Monthly release channel**.

        - For Copilot for email, you've [opted in for preview features](copilot-preview-features.md).
    
    - For apps that don't meet the above conditions, the **Default** setting turns Copilot off.

1. Select **Turn audit on** to turn on audit history for the lead and opportunity tables. If auditing is already turned on for the lead and opportunity tables or globally, the **Turn audit on** option isn't displayed.

    - Audit history is required for Copilot to display recent changes to leads and opportunities.
    - If you configure Copilot to [show recent changes from tables other than leads and opportunities](#configure-fields-for-generating-summaries-and-recent-changes-list), turning on auditing turns on audit history for those tables as well. However, if you remove those fields later, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for those tables manually.

1. Select **Publish**.

    The Welcome to Copilot pane opens in the right side pane with a quick tour.


## Configure fields for generating summaries and recent changes list

By default, Copilot uses a set of predefined fields to generate [summaries](copilot-get-information.md#summarize-a-lead-or-opportunity) and a list of [recent changes](copilot-ask-questions.md#get-recent-changes-to-a-lead-or-opportunity) for opportunities and leads. You can add other lead and opportunity fields and fields from related tables to make the summaries and recent changes list more relevant for your business.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. Select **Opportunities** or **Leads**. The following screenshot shows the Opportunity settings page. The Lead settings page is similar.

    :::image type="content" source="media/copilot-summary-settings.svg" alt-text="Screenshot of the Opportunity settings page for record summaries in Copilot.":::

1. To choose fields for generating summaries, select the **Summary** tab. To choose fields for generating the recent changes list, select the **Recent changes** tab.

    The recent changes list is generated from the audit history. If the **Recent changes** tab isn't available, it means that auditing is turned off globally or for the table you selected (leads or opportunities). Select **Turn audit on** in the notification bar to turn on audit history for all the tables in the **Recent changes** tab.

    :::image type="content" source="media/turn-audit-on.svg" alt-text="Screenshot of the Recent changes tab when auditing isn't turned on for any of the tables in the Recent changes tab.":::

1. Select **Add fields**.

1. Select at least 4 fields, up to a maximum of 10.

    The **Save** button is disabled if you select fewer than 4 or more than 10 fields. If you added more than 10 fields, clear the checkbox, or select fields that you don't need and select **Delete**.

    In the **Recent changes** tab, when you add a field from a related table that doesn't have audit history turned on, **Turn audit on** appears in the notification bar. Select it to turn on auditing for the table. If you remove the field later, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for the table manually.

1. Save your changes.

## Configure fields for generating what's new with my sales records list

The **What's new with my sales records** prompt lists the sales records that were updated in the last seven days. The list is generated from the audit history of the lead, opportunity, and account tables. Depending on the record type, Copilot uses different fields to get the list of records updated: 

- For the lead and opportunity records, Copilot uses the fields in the primary table (lead or opportunity) that you've [configured for generating the recent changes list](#configure-fields-for-generating-summaries-and-recent-changes-list). For example, if you've configured four fields from the lead table and six fields from related tables, Copilot monitors changes to only those four fields from the lead table to identify the lead records that are updated.

- For the account records, Copilot lists the following changes:
  - Contacts, leads, and opportunities created for the account in the last seven days.
  - Changes to the fields in the **Quick Find** view of the account table. If you'd like to see changes to other fields, add them to the **Quick Find** view of your account table. [Learn how to add fields to the Quick Find view](/power-apps/maker/model-driven-apps/create-edit-views#how-to-access-the-view-editor-to-create-or-edit-views).


## Grant audit access to your sellers

Copilot generates the list of recent changes for leads and opportunities from the audit history. So, your sellers need access to the audit history and audit summary to view the recent changes.

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com) and select your environment.

1. Select **Settings** > **Users + permissions** > **Security roles**.

1. Select the security role that's assigned to your sellers, and then select the **Miscellaneous Privileges** tab.

1. In the list below the tab, select **Show only unassigned privileges**.

1. Select **Organization** as the **Privilege Level** for the following privileges:

    - **View Audit History**
    - **View Audit Summary**

1. Select **Save + close**.


### See also

- [Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)
- [Copilot data movement](sales-copilot-data-movement.md)  
- [FAQs about Copilot in Dynamics 365 Sales](sales-copilot-faq.md)