---
title: Enable and configure Sales Copilot
description: Learn how to turn on and configure Sales Copilot so that your sales team can get summaries of their contact and lead records, catch up on updates, and prepare for meetings.
ms.date: 09/15/2023
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

# Enable and configure Sales Copilot

Sales Copilot is enabled by default in all sales apps for tenants in North America. If your tenant is in a different region, or to change the Sales Copilot features that your sellers can use in their apps, follow the instructions in this article:

- [Enable or disable Sales Copilot features in Dynamics 365 apps](#enable-or-disable-sales-copilot-features-in-dynamics-365-apps)
- [Configure record summary fields](#configure-record-summary-fields)
- [Configure record catch up fields](#configure-record-catch-up-fields)
- [Grant audit access to your sellers](#grant-audit-access-to-your-sellers)

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator](security-roles-for-sales.md)|

## Enable or disable Sales Copilot features in Dynamics 365 apps

Select the Sales Copilot features that you want your sales teams to use in each of your organization's Dynamics 365 apps and custom apps, if any. You can enable Sales Copilot only from the Sales Hub app.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Sales Copilot (preview)**.

1. If you're setting up Sales Copilot for the first time, select **Set up Copilot**. If you already set up Sales Copilot, select **Manage apps**.

1. In the list of your organization's Dynamics 365 apps on the right side of the page, select **Compose** and **Chat** to enable or disable the following Sales Copilot features in each app:

    - **Compose**: These features help sellers get [email summaries](view-copy-email-summary.md) and [content suggestions when they compose or respond to emails](compose-send-email-copilot.md).
    - **Chat**: These features allow sellers to [chat with Sales Copilot](use-sales-copilot.md) to get contextual insights and suggestions like summarizing an opportunity or lead or helping them prepare for a meeting.

1. Select **Confirm**.

The Copilot icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) appears in the right navigation bar.

## Configure record summary fields

By default, Sales Copilot uses the first seven fields in the default lead and opportunity view to [generate summaries](use-sales-copilot.md#summarize-an-opportunity-or-a-lead). To have it generate summaries and catch ups from the fields that are most relevant for your business, create a view. You can create different views for summaries and catch ups.

1. In the Sales Hub app, [create a system view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view) that contains the fields you want Sales Copilot to use for summaries and catch up.

1. Go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Sales Copilot (preview)**.

1. In the **Record summary** settings, select a view for each record type.

    The first seven fields in the view are listed in the **Fields** column. Sales Copilot [generates summaries](use-sales-copilot.md#summarize-an-opportunity-or-a-lead) from these fields.

    :::image type="content" source="media/copilot-record-summary-settings.svg" alt-text="Screenshot of the Record summary settings in Sales Copilot.":::

> [!IMPORTANT]
> If you later update or remove fields in a selected view, you need to force Sales Copilot to recognize your changes. In the **Sales Copilot (preview)** settings, select a different view. Save, and then select the updated view. Make sure the updated fields are listed in the **Fields** column, and then save again.

## Configure record catch up fields

Sales Copilot uses the 10 most recent updates in the record audit history to generate catch ups. Make sure auditing is turned on, and give your sellers access to view the audit history and audit summary.

1. In the **Sales Copilot (preview)** settings, select **Record catch up**.

1. Select **Turn audit on**.

1. Select a view for each record type.

    :::image type="content" source="media/copilot-record-catchup-settings.svg" alt-text="Screenshot of the Record catch up settings in Sales Copilot.":::

1. Select **Save**.

## Grant audit access to your sellers

Sales Copilot generates lead and opportunity catch-up information from the audit history, so your sellers need access to the audit history and audit summary to view catch ups.

1. In Sales Hub, in the upper-right corner of the page, select **Settings** > **Security** > **Security Roles**.

    Or, open the [Power Platform admin center](https://admin.powerplatform.microsoft.com), select your environment > **Settings** > **Users + permissions** > **Security roles**.

1. Select the security role that's assigned to your sellers, and then select the **Miscellaneous Privileges** tab.

1. In the list below the tab, select **Show only unassigned privileges**.

1. Select **Organization** as the **Privilege Level** for the following privileges:

    - **View Audit History**
    - **View Audit Summary**

1. Select **Save + close**.

## See also

[Use Sales Copilot](use-sales-copilot.md)
