---
title: Turn on and set up Copilot in Dynamics 365 Sales
description: Learn how to turn on and set up Copilot in Dynamics 365 Sales so that your sales team can get summaries of their contact and lead records, catch up on recent changes, and prepare for meetings.
ms.date: 12/01/2023
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

<!-- EDITOR'S NOTES: 
- Line 53: Can you please change the screenshot to include all the settings you describe in this section? It cuts off without showing some of them.
- Line 127: The screenshot is really blurry. Can you please replace it with a clearer one? And please highlight the ellipsis button, too.
- Line 131: The screenshot is really blurry. Can you please replace it with a clearer one?
- sure
-->

# Turn on and set up Copilot in Dynamics 365 Sales

Copilot is turned by default in all Sales apps for tenants in North America. If your tenant is in a different region, or to change the Copilot features that your sellers can use in their apps, follow the instructions in this article.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator](security-roles-for-sales.md) |

## Prerequisites

Provide consent for Copilot to process your data outside of your geographic region, compliance boundary, or national cloud instance. Your consent is required for Copilot to work in your organization.

- Read the [Copilot data movement](sales-copilot-data-movement.md) article carefully.

- [Turn on data movement across regions](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions).

## Turn Copilot features in Dynamics 365 apps on or off

In the Sales Hub app, you can select the Copilot features that you want your sales teams to use in each of your organization's Dynamics 365 apps and custom apps.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. In the **Set up Copilot in Dynamics 365 Sales** page, select **Try our newest preview features before they're rolled out to everyone** to get all the Copilot preview features automatically.

   :::image type="content" source="media/enable-copilot.png" alt-text="Screenshot of the Set up Copilot in Dynamics 365 Sales page in Dynamics 365 Sales Hub.":::

1. If you haven't provided consent for data movement, select **Go to Power Platform admin center** and follow the [instructions to provide consent](/power-platform/admin/geographical-availability-copilot).

    In some regions, you might see the consent terms in the **Set up Copilot in Dynamics 365 Sales** page. By selecting **Publish**, you provide consent for Copilot to process your data outside of your region. For these regions, separate consent in the Power Platform admin center isn't required.

1. Select **Turn audit on** to turn on audit history for the lead and opportunity tables. If auditing is already turned on for the lead and opportunity tables or globally, the **Turn audit on** option isn't displayed.

    - Audit history is required for Copilot to display recent changes to leads and opportunities.
    - If you configure Copilot to [show recent changes from tables other than leads and opportunities](#configure-fields-for-generating-summaries-and-recent-changes-list), turning on auditing turns on audit history for those tables as well. However, if you remove those fields later, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for those tables manually.

1. Select **Publish**.

    The Welcome to Copilot pane opens in the right side pane with a quick tour.

## Configure fields for generating summaries and recent changes list

By default, Copilot uses a set of predefined fields to generate [summaries](use-sales-copilot.md#summarize-an-opportunity-or-a-lead) and a list of [recent changes](use-sales-copilot.md#view-recent-changes-to-an-opportunity-or-lead) for opportunities and leads. You can add other lead and opportunity fields and fields from related tables to make the summaries and recent changes list more relevant for your business.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. Select **Opportunities** or **Leads**. The following screenshot shows the Opportunity settings page. The Lead settings page is similar.

    :::image type="content" source="media/copilot-summary-settings.svg" alt-text="Screenshot of the Opportunity settings page for record summaries in Copilot.":::

1. To choose fields for generating summaries, select the **Summary** tab. To choose fields for generating the recent changes list, select the **Recent changes** tab.

    The recent changes list is generated from the audit history. If the **Recent changes** tab isn't available, it means that auditing is turned off globally or for the table you selected (leads or opportunities). Select **Turn audit on** in the notification bar to turn on audit history for all the tables in the **Recent changes** tab.

    :::image type="content" source="media/turn-audit-on.svg" alt-text="Screenshot of the Recent changes tab when auditing isn't turned on for any of the tables in the Recent changes tab.":::

1. Select **Add fields**.

1. Select at least 4 fields, up to a maximum of 10.

    The **Save** button is unavailable if you select fewer than 4 or more than 10 fields. If you added more than 10 fields, clear the checkbox, or select fields that you don't need and select **Delete**.

    In the **Recent changes** tab, when you add a field from a related table that doesn't have audit history turned on, **Turn audit on** appears in the notification bar. Select it to turn on auditing for the table. If you remove the field later, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for the table manually.

1. Save your changes.

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

## Add the Copilot page to custom apps (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

The Copilot page is available in the Sales Hub app by default. If you have a custom app and would like to use Copilot in the full-screen view, add the Copilot page to the sitemap in your custom app. The following example uses the Sales Sandbox custom app.

1. Make sure that the [Copilot preview feature flag](copilot-preview-features.md#enable-all-preview-features-for-copilot) is turned on.

1. On the Dynamics 365 Apps page, select the ellipses on your custom app tile and select **OPEN IN APP DESIGNER**.

    :::image type="content" source="media/faq-sa-open-app-designer.png" alt-text="Screenshot of the Sales Sandbox custom app on the App page and in App Designer.":::

1. Open the site map designer. Select the pencil icon for the Site Map section.

    :::image type="content" source="media/faq-sa-open-site-map-designer.png" alt-text="Screenshot of the Sales Sandbox custom app in Sitemap Designer.":::

1. Select the area in which you want to add the work list entry, and then select **Add** > **Subarea**.

1. Select the new subarea, go to the **Properties** tab, and enter the following values:

   - Select **Type** as **URL**.
   - Enter the **URL value** as */main.aspx?&pagetype=control&controlName=PowerApps.Copilot*.
   - Enter the **Title (1033)** as *Copilot*.
   - Select the default **Icon** to use the default Copilot icon.
   - Enter a unique ID; for example, *copilotpage*.

1. Save and publish the sitemap.

Sellers can now access the Copilot page in your custom app.

### See also

- [Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)
