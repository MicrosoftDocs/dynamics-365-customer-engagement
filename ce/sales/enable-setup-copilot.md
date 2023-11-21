---
title: Enable and configure Copilot in Dynamics 365 Sales
description: Learn how to turn on and configure Copilot so that your sales team can get summaries of their contact and lead records, catch up on updates, and prepare for meetings.
ms.date: 11/01/2023
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
---

# Enable and configure Copilot in Dynamics 365 Sales

Copilot is enabled by default in all sales apps for orgs in North America. If your org is in a different region, or to change the Copilot features that your sellers can use in their apps, follow the instructions in this article:

- [Enable or disable Copilot features in Dynamics 365 apps](#enable-or-disable-copilot-features-in-dynamics-365-apps)
- [Configure record summary fields](#configure-record-summary-fields)
- [Configure record catch up fields](#configure-record-catch-up-fields)
- [Grant audit access to your sellers](#grant-audit-access-to-your-sellers)

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisite

Before you enable Copilot in Dynamics 365 Sales, you must provide consent for Copilot to process your data outside of your geographic region, compliance boundary, or national cloud instance. 
Read the information in the [copilot data movement article](sales-copilot-data-movement.md) carefully and then follow the steps in the [Power Platform documentation](/power-platform/admin/geographical-availability-copilot).


## Enable or disable Copilot features in Dynamics 365 apps

Select the Copilot features that you want your sales teams to use in each of your organization's Dynamics 365 apps and custom apps, if any. You can enable Copilot only from the Sales Hub app.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. In the Set up Copilot in Dynamics 365 Sales page, select **All Dynamics 365 Sales apps** to enable it for all the Dynamics 365 apps in your organization. Or, select **Manage apps** to select the individual apps that you want to enable it for.  

   :::image type="content" source="media/enable-copilot.png" alt-text="Screenshot of the Set up Copilot in Dynamics 365 Sales page with the apps listed. ":::

    If you haven't provided the consent for data movement, you'll see the **Go to Power Platform admin center** button. Select the button and follow the instructions in the [Power Platform documentation](/power-platform/admin/geographical-availability-copilot) to provide consent.
 
1. Select **Turn audit on** to enable Copilot to use the audit history to generate recent changes.
1. Select **Publish**.

    The Welcome to Copilot pane opens in the right side with a quick tour. 

1. Go to **Change area** in the lower-left corner of the page and select **Sales** to verify that the Copilot icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) appears in the right navigation bar.

## Configure fields for opportunity summary and catch up

By default, Copilot uses a set of predefined fields to [generate summaries](use-sales-copilot.md#summarize-an-opportunity-or-a-lead) and [catchups](use-sales-copilot.md#catch-up-with-an-opportunity-or-lead). To have it generate summaries and catch ups from the fields that are most relevant for your business, add the fields to your configuration. You can add different set of fields for summaries and catch ups.


1. Go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. Select **Opportunities**.

    :::image type="content" source="media/copilot-summary-settings.png" alt-text="Screenshot of the Opportunity settings page for record summarization in Copilot.":::

1. Select the **Summary** tab to configure fields for generating summaries. Select the **Catchup** tab to configure fields for generating catch ups or recent changes.  

1. Select **Add fields** to add fields from either the Opportunity table or related tables. You can add up to 10 fields.  
    If you've added more than 10 fields, clear the checkbox for fields that you don't need. If you've selected more than 10 fields, the top 10 fields are used for generating summaries.
1. Save the changes.

## Configure fields for lead summary and catch up

By default, Copilot uses a set of predefined fields to [generate summaries](use-sales-copilot.md#summarize-an-opportunity-or-a-lead) and [catchups](use-sales-copilot.md#catch-up-with-an-opportunity-or-lead). To have it generate summaries and catch ups from the fields that are most relevant for your business, add the fields to your configuration. You can add different set of fields for summaries and catch ups.


1. Go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. Select **Leads**.

    :::image type="content" source="media/copilot-summary-settings.png" alt-text="Screenshot of the Opportunity settings page for record summarization in Copilot.":::

1. Select the **Summary** tab to configure fields for generating summaries. Select the **Catchup** tab to configure fields for generating catch ups or recent changes.  

1. Select **Add fields** to add fields from either the Lead table or related tables. You can add up to 10 fields.  
    If you've added more than 10 fields, clear the checkbox for fields that you don't need. If you've selected more than 10 fields, the top 10 fields are used for generating summaries.
1. Save the changes.

## Grant audit access to your sellers

Copilot compiles the list of recent changes for leads and opportunities from the audit history. So, your sellers need access to the audit history and audit summary to view the recent changes.

1. Open the [Power Platform admin center](https://admin.powerplatform.microsoft.com), select your environment > **Settings** > **Users + permissions** > **Security roles**.

1. Select the security role that's assigned to your sellers, and then select the **Miscellaneous Privileges** tab.

1. In the list below the tab, select **Show only unassigned privileges**.

1. Select **Organization** as the **Privilege Level** for the following privileges:

    - **View Audit History**
    - **View Audit Summary**

1. Select **Save + close**.

## See also

[Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)
