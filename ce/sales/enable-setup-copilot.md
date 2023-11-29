---
title: Enable and configure Copilot in Dynamics 365 Sales
description: Learn how to turn on and configure Copilot so that your sales team can get summaries of their contact and lead records, catch up on recent changes, and prepare for meetings.
ms.date: 11/28/2023
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

Copilot is enabled by default in all sales apps for orgs in North America. If your org is in a different region, or to change the Copilot features that your sellers can use in their apps, follow the instructions in this article.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisite

Before you enable Copilot in Dynamics 365 Sales, you must provide consent for Copilot to process your data outside of your geographic region, compliance boundary, or national cloud instance. Ensure to complete the following actions:
 
- Read the information in the [copilot data movement article](sales-copilot-data-movement.md) carefully.

- Follow the steps in the [Power Platform documentation](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions) to enable data movement across regions.


## Enable or disable Copilot features in Dynamics 365 apps

Select the Copilot features that you want your sales teams to use in each of your organization's Dynamics 365 apps and custom apps, if any. You can enable Copilot only from the Sales Hub app.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. In the **Set up Copilot in Dynamics 365 Sales** page, turn on **Try our newest preview features before they're rolled out to everyone** to get all the Copilot preview features automatically.  

   :::image type="content" source="media/enable-copilot.png" alt-text="Screenshot of the Set up Copilot in Dynamics 365 Sales page with the apps listed. ":::

    If you haven't provided the consent for data movement, select **Go to Power Platform admin center** and follow the instructions in the [Power Platform documentation](/power-platform/admin/geographical-availability-copilot) to provide consent.  

    > [!NOTE]
    > For some regions, you may see the consent terms in the **Set up Copilot in Dynamics 365 Sales** page. By selecting **Publish**, you provide consent for Copilot to process your data outside of your region. For these regions, consent in the Power Platform admin center isn't required.  
 
1. Select **Turn audit on** to turn on audit history for the lead and opportunity tables. Audit history is required for Copilot to generate recent changes for leads and opportunities. If you [configure Copilot](#configure-fields-for-generating-summaries-and-recent-changes-list) to generate recent changes from fields other than the lead and opportunity tables, this setting turns on audit history for those tables as well. However, if you remove the fields later on from the configuration, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for those tables manually.

1. Select **Publish**.

    The Welcome to Copilot pane opens in the right side with a quick tour. 

1. Go to **Change area** in the lower-left corner of the page and select **Sales** to verify that the Copilot icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) appears in the right navigation bar.

## Configure fields for generating summaries and recent changes list

By default, Copilot uses a set of predefined fields to generate [summaries](use-sales-copilot.md#summarize-an-opportunity-or-a-lead) and [recent changes list](use-sales-copilot.md#catch-up-with-an-opportunity-or-lead) for your opportunities and leads. To have it generate summaries and recent changes from the fields that are most relevant for your business, add the fields to your configuration. You can add a different set of fields for summaries and recent changes list from the lead and opportunity tables and other related tables.


1. Go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. Select **Opportunities** or **Leads**. The following screenshot shows the Opportunity settings page. The Lead settings page is similar.

    :::image type="content" source="media/copilot-summary-settings.svg" alt-text="Screenshot of the Opportunity settings page for record summarization in Copilot.":::

1. Select the **Summary** tab to configure fields for generating summaries. Select the **Recent changes** tab to configure fields for generating the recent changes list.  
    
    > [!NOTE]
    > If you haven't turned on audit history in the Set up Copilot page, the fields in the **Recent changes** tab are disabled. Select **Turn audit on** in the notification bar to turn on audit history.  

1. Select **Add fields** to add fields from the opportunity/lead table or other related tables. You can add a minimum of 4 fields and a maximum of 10 fields. The **Save** button is disabled if this requirement isn't met.

    If you've added more than 10 fields, clear the checkbox for fields or select the fields that you don't need and then select **Delete**. 

    > [!NOTE]
    > When you add a field from the related table, the audit history for the related table is turned on automatically. If you remove the field later on, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for the related table manually.

1. Save the changes.

## Grant audit access to your sellers

Copilot generates the list of recent changes for leads and opportunities from the audit history. So, your sellers need access to the audit history and audit summary to view the recent changes.

1. Open the [Power Platform admin center](https://admin.powerplatform.microsoft.com), select your environment > **Settings** > **Users + permissions** > **Security roles**.

1. Select the security role that's assigned to your sellers, and then select the **Miscellaneous Privileges** tab.

1. In the list below the tab, select **Show only unassigned privileges**.

1. Select **Organization** as the **Privilege Level** for the following privileges:

    - **View Audit History**
    - **View Audit Summary**

1. Select **Save + close**.

## See also

[Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)
