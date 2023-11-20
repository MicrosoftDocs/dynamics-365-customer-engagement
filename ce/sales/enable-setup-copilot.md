---
title: Enable and configure Copilot in Dynamics 365 Sales
description: Learn how to turn on and configure Copilot so that your sales team can get summaries of their contact and lead records, catch up on updates, and prepare for meetings.
ms.date: 11/10/2023
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

1. In the **Set up Copilot in Dynamics 365 Sales** page, turn on **Try our newest preview features before they're rolled out to everyone** to get all the Copilot preview features automatically.

1. In the **Enable Copilot for** section, select **All Dynamics 365 Sales apps** to enable Copilot for all apps in your organization. Or, select **Manage apps** to enable Copilot for specific apps.

   :::image type="content" source="media/enable-copilot.png" alt-text="Screenshot of the Set up copilot pane with the apps listed. ":::  

1. Select **Publish**.

The Copilot icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) appears in the right navigation bar.

## Configure record summary fields

By default, Copilot uses the first seven fields in the default lead and opportunity view to [generate summaries](copilot-get-information.md#summarize-a-lead-or-opportunity). To have it generate summaries and catch ups from the fields that are most relevant for your business, create a view. You can create different views for summaries and catch ups.

1. In the Sales Hub app, [create a system view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view) that contains the fields you want Copilot to use for summaries and catch up.

1. Go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. In the **Record summary** settings, select a view for each record type.

    The first seven fields in the view are listed in the **Fields** column. Copilot [generates summaries](use-sales-copilot.md#summarize-a-lead-or-opportunity) from these fields.

    :::image type="content" source="media/copilot-record-summary-settings.svg" alt-text="Screenshot of the Record summary settings in Copilot.":::

1. Save the changes.

> [!IMPORTANT]
> If you later update or remove fields in a selected view, you need to force Copilot to recognize your changes. In the **Copilot** settings, select a different view. Save, and then select the updated view. Make sure the updated fields are listed in the **Fields** column, and then save again.

## Configure record catch up fields

Copilot uses the 10 most recent updates in the record's audit history to generate catch ups. You can configure a view with fields that you want to catch up on and have Copilot use it for generating catch up summary. Make sure auditing is turned on, and give your sellers access to view the audit history and audit summary.

1. In the **Copilot** settings, select **Record catch up**.

1. Select **Turn audit on**.

1. Select a view for each record type.

    :::image type="content" source="media/copilot-record-catchup-settings.svg" alt-text="Screenshot of the Record catch up settings in Copilot.":::

1. Save the changes.

## Grant audit access to your sellers

Copilot generates lead and opportunity catch-up information from the audit history, so your sellers need access to the audit history and audit summary to view catch ups.

1. Open the [Power Platform admin center](https://admin.powerplatform.microsoft.com), select your environment > **Settings** > **Users + permissions** > **Security roles**.

1. Select the security role that's assigned to your sellers, and then select the **Miscellaneous Privileges** tab.

1. In the list below the tab, select **Show only unassigned privileges**.

1. Select **Organization** as the **Privilege Level** for the following privileges:

    - **View Audit History**
    - **View Audit Summary**

1. Select **Save + close**.

## Add the Copilot page to custom apps (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

The Copilot page is available in the Sales Hub app by default. If you have a custom app and would like to use Copilot in the full-screen view, add the Copilot page to the sitemap in your custom app.

1. Ensure that the [Copilot preview feature flag](copilot-preview-features.md#enable-all-preview-features-for-copilot) is turned on.

1. On the Apps page, select the ellipses on your custom app and select **OPEN IN APP DESIGNER**. In the following example, the custom app Sales SandBox is opened.
    :::image type="content" source="media/faq-sa-open-app-designer.png" alt-text="Screenshot of app designer":::
1. Open the site map designer. Select the pencil icon corresponding to the Site Map section.
    :::image type="content" source="media/faq-sa-open-site-map-designer.png" alt-text="Screenshot of the sitemap designer.":::
1. Select the area in which you want to add the work list entry and then select **Add** > **Subarea**.
1. Select the new subarea and go to the **Properties** tab and enter the following values:
   - Select **Type** as **URL**.
   - Enter the **URL value** as */main.aspx?&pagetype=control&controlName=PowerApps.Copilot*.
   - Enter the **Title (1033)** as **Copilot**.
   - Select the **Icon** as Default icon to use the default Copilot icon. 
   - Enter the ID field with a unique ID value. For example, copilotpage.
1. Save and publish the sitemap. 
    Sellers can now access the Copilot page from your custom app.

### See also

[Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)
