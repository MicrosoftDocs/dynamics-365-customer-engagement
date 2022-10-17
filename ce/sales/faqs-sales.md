---
title: Frequently asked questions about Dynamics 365 Sales
description: Find answers to frequently asked questions about Dynamics 365 Sales Enterprise.
ms.date: 10/17/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Frequently asked questions about Dynamics 365 Sales

## Licenses

### What's the difference between Sales Premium and Sales Insights?  

Sales Premium, like Sales Enterprise, is a type of license. Sales Insights is an add-in for Dynamics 365 Sales. Sales Premium includes all Sales Enterprise capabilities and premium Sales Insights capabilities. Sales Enterprise includes basic Sales Insights capabilities. For a detailed comparison of the capabilities in each license, go to the **Compare Dynamics 365 Sales plans** section on the [Pricing](https://dynamics.microsoft.com/sales/pricing/) page.  

### Where can I find the comparison chart for Dynamics 365 Sales licenses?  

The following license options are available for Dynamics 365 Sales:

- Sales Premium
- Sales Enterprise
- Sales Professional

For a detailed comparison of the capabilities available with each license, go to the **Compare Dynamics 365 Sales plans** section on the [Pricing](https://dynamics.microsoft.com/sales/pricing/) page.

### Can I use the Sales Hub app with the Sales Professional license?

No, the Sales Hub app is only for the Sales Enterprise and Sales Premium customers. Though this app may be visible in Sales Professional environments, the users aren't entitled to use it. Sales Professional users are entitled to use only the Sales Professional app. We recommend that you [hide](/power-apps/maker/model-driven-apps/deactivate-app) or [delete](/power-apps/maker/model-driven-apps/delete-model-driven-app) the Sales Hub app to avoid any accidental usage.

### Where can I find the Sales Professional and Sales Insights documentation?

We've merged the documentation for Sales Enterprise, Sales Professional, and Sales Insights into this unified Sales documentation. The license and role requirements section at the top of an article indicates whether the content applies to the license you have. Any bookmarks you have should automatically redirect to the corresponding pages in the new unified documentation.

## Entity: Activity

### Why are the Follow and Unfollow buttons displayed together on the command bar?

This is by design. The **Follow** and **Unfollow** buttons are displayed together on the command bar no matter which state the selected record is in, followed or not followed.

### If the SchedulingEngine feature is enabled for appointments, why am I redirected to the default tab in an appointment when I save it from a non-default tab?

This is by design. When you save an appointment from a non-default tab, you're redirected to the default environment when the appointment is saved.

### If the SchedulingEngine feature is enabled for appointments, why are appointments saved automatically even if the system administrator has added a custom script to stop automatic saving?

This is by design. Even if a custom script prevents the default save option for appointments, the system overrides the script and saves the appointments automatically.

### If the SchedulingEngine feature is enabled for appointments, why does the **Open Record Set** button disappear when an appointment is saved?

The **Open Record Set** button disappears when you select **Save** but reappears when you refresh the page. For more information, go to [Open Record Set](/powerapps/user/navigation#record-set-navigation).

### Why are synchronized appointments from Outlook shown as unsaved in Dynamics 365?

This is by design. Disable the automatic save option in Dynamics 365 to show synchronized appointments from Outlook as saved in Dynamics 365.

### Why can't I see the What's new functionality in Unified Interface?

This is by design. The What's new functionality is only available in the legacy web client. The equivalent in Unified Interface is to insert the Timeline control (with posts enabled) on the dashboard:

1. In your app, select **Settings** ![Settings.](media/settings-icon.png), and then select **Advanced Settings**.

   The **Business Management** page opens in a new browser tab.

1. On the navigation bar, select **Settings**, and then under **Customization**, select **Customizations**.

1. Select **Customize the System**.

1. Under **Components** in the solution explorer, select **Dashboards**.

1. Select and open the dashboard to which you want to add the Timeline control.

1. On the toolbar at the top of the page, select **Timeline**.

1. Update the **Timeline Control Properties** as required, and then select **OK**.

1. Save the dashboard, and then publish the customization.

## Entity: Lead

<a name="what-is-the-difference-between-duplicate-detection-capability-of-power-platform-and-duplicate-detection-of-leads-in-dynamics-365-sales"></a>

### What's the difference between the duplicate detection capability in Power Platform and duplicate detection of leads in Dynamics 365 Sales?

Power Platform detects duplicates by comparing the matchcode that's created for each record. For more information, go to [Detect duplicate data so you can fix or remove it](/power-platform/admin/detect-duplicate-data).

Dynamics 365 Sales detects duplicates with an AI model that compares leads using fuzzy logic and the matchcode that's generated for each lead.

The following table shows an example of the two methods for detecting duplicates.

| Rule type | Applied for |  
|-----------|------------|
| Fuzzy logic | - Similar lead name and company name<br>- Similar lead name and the same email domain |
| Matchcode | - Email address<br>- Phone number |

For more information, go to [Enable duplicate lead detection](enable-duplicate-lead-detection.md).

## Entity: Opportunity

### Why can't I edit Est. Revenue in the Opportunity form?

To edit **Est. Revenue** in the **Opportunity** form, **Revenue** must be set as **User Provided** and the opportunity must be in an **Open** state.

:::image type="content" source="media/faqs-est-revenue.png" alt-text="Screenshot of an opportunity record with Revenue highlighted.":::

## Entities: Opportunity, Quote, Invoice, and Order

In this section, we use the entity **Opportunity** to frame the questions. However, the questions also apply to quotes, invoices, and orders.

### If I select a view other than Opportunity Product Inline Edit View for the Opportunity Product in the legacy web client, why can't I make inline edits or see grid actions like move up, move down, and lock icons?

This is by design in the legacy web client. The inline edit view is available in Unified Interface. To verify whether a grid can be edited, go to **Grid control properties**.

:::image type="content" source="media/faqs-grid-control-properties.png" alt-text="Screenshot of the properties settings for the grid control.":::

   > [!NOTE]
   >
   > - In Unified Interface, the behavior of the grid columns **Price Per Unit** and **Quantity** as editable or non-editable is independent of the view that's selected.  
   > - An editable grid doesn't guarantee that all columns are editable; it depends on the **Pricing**.

<a name="amt-not-calculated"></a>

### Why isn't the amount calculated automatically in opportunity, quote, order, and invoice records?

**Est. Revenue** and **Total Amount** are updated when the opportunity is refreshed&mdash;when you open the record or select **Refresh** on the command bar&mdash;or when you select **Recalculate Opportunity** on the command bar. Your organization must be using system pricing calculation. Make sure that **Use system pricing calculation** in **System Settings** is set to **Yes**. For more information, go to [System Settings dialog box - Sales tab](system-settings-sales-tab.md).

<a name="fields-locked"></a>

### Why are some fields editable while some are locked in the Product subgrid in opportunity, quote, order, and invoice records?

There are certain restrictions on inline editing, based on the type of product in the subgrid:

- If it's an individual (unbundled) product and it exists in the product catalog, all fields except **Quantity** and **Discount** are locked for editing.

- If it's an individual product and it exists in the product catalog as a write-in, all fields except **Product Name**, **Quantity**, and **Discount** are locked for editing.

- If it's a product bundle or an optional item in a bundle, all fields except **Quantity** and **Discount** are locked for editing.

- If it's a required product in a bundle, all fields are locked for editing.

## Entities: Opportunity Product, Quote Product, Order Product, and Invoice Product

In this section, we use the entity **Opportunity Product** to frame the questions. However, the questions also apply to **Quote Product**, **Order Product**, and **Invoice Product**.

### Why can't I update the owning business unit for opportunity products?

There's no direct relationship between business units and opportunity products. The owning business unit for opportunity products are automatically inherited from the parent opportunity. So, you can't update the owning business unit at the opportunity product-level.

### How can I set the default Pricing to Override Price on the Opportunity Product form?

To set the value of the default **Pricing** as **Override Price** on the **Opportunity Product** form:

1. Go to **Settings** > **Customizations** > **Customize the System**.
1. Select **Entities** > **Opportunity Product** > **Fields**.
1. Select **ispriceoverridden**, and then set **Default Value** to **Override Price**.
1. Save and publish the customizations.

:::image type="content" source="media/faqs-pricing-change-order-product-form.png" alt-text="Screenshot of customization settings on the Opportunity Product form.":::

## Entities: Order and Invoice

In this section, we use the entity **Order** to frame the questions. However, the questions also apply to invoices.

### How can I change the default value for Prices Locked in the Order form?

You can change the default value for **Prices Locked** in the **Order** form through customizations or the inline editable grid:

1. Go to **Settings** > **Customizations** > **Customize the System**.
1. Select **Entities** > **Order** > **Fields**.
1. Select **ispricelocked**, and then set **Default Value** to **No**.
1. Save and publish the customizations.

### For a particular Order form, how can I change the state of Prices Locked?

To change the state of **Prices Locked**, select the **Lock** icon on the inline editable grid.

In the legacy web client:

:::image type="content" source="media/faqs-edit-pricing-for-product.png" alt-text="Screenshot of editing the pricing for a product in the legacy web client.":::

In Unified Interface:

:::image type="content" source="media/faqs-edit-pricing-for-product-uci.png" alt-text="Screenshot of editing the pricing for a product in Unified Interface.":::

### Why can't I change the values in the Price Per Unit column in the Products grid?

The **Prices Locked** (**ispricelocked**) setting controls whether the prices specified on the **Order** form can be changed.

The following tables show the interaction between **Prices Locked** and **Price Per Unit** on editable and non-editable grids in the **Products** subgrid and **Order** product form.

For existing products:

| **Prices Locked** | **Price Per Unit** (editable grid) | **Price Per Unit** (non-editable grid) | **Order** product form |
|-------------|-------------|-------------|-------------|
| Yes | Non-editable | Non-editable | Non-editable |
| No and **Pricing** is **Override Price** | Editable | Non-editable | Editable |
| No and **Pricing** is **Use Default** | Non-editable | Non-editable | Non-editable |

For write-in products:

| **Prices Locked** | **Price Per Unit** (editable grid) | **Price Per Unit** (non-editable grid) | **Order** product form |
|-------------|-------------|-------------|-------------|
| Yes | Non-editable | Non-editable | Non-editable |
| No | Editable | Non-editable | Editable |

### How does changing the product price in Pricelist affect Price Per Unit on the Order product form?

The following table shows the effect of changing the product price in **Pricelist** on the **Price Per Unit** of the **Order** product form.

| Entity state | IsPriceLocked | Pricing | Does **Price Per Unit** change? |
|------------|-------------|-------|----------------------------------------------------------------------|
| Editable | Yes | Default or Override | No |
| Editable | No | Default | Yes |
| Editable | No | Override | No |
| ReadOnly | Yes or No | Default or Override | No |

## Forecasting

### Who owns the forecast?

The user who owns a specific level in the forecast hierarchy owns the forecast. The forecast manager or administrator selects the field that should be used to assign an owner to each level in the forecast hierarchy when they create a forecast. A user field is selected by default based on the forecast template:

- For **Org chart forecast**, the **User** field is selected.
- For **Territory forecast**, the **Manager** field is selected.
  
If you select a field other than the default, a column is created in the forecast grid. For example, if you select **Manager** as the user lookup field for an org chart forecast, the **Manager** field is added to the forecast grid.

To view the forecast owner:

1. In the Sales Hub app, select **App Settings**.
1. Under **Performance management**, select **Forecast configuration**.
1. Select a forecast configuration, and then select the **Permissions** step.
1. Verify the **User lookup field** to determine who owns the forecasts in the selected forecast configuration.

    :::image type="content" source="media/user-security-field.png" alt-text="Screenshot of the User lookup field in the Permissions tab.":::

    For example, in an org chart forecast, if you select **User** as the owner, each user in the hierarchy owns the hierarchy under them. In a territory-based forecast, a user could own more than one hierarchy if they own multiple territories.  

    In the following illustration, the managers own all the forecasts in their hierarchy and individual sellers own their specific forecasts:

    :::image type="content" source="media/forecast-hierarchy-owner.png" alt-text="Screenshot illustrating the forecast owner at different levels in the forecast hierarchy.":::

### How do I change the forecast calculation for lost opportunities?

By default, the forecast calculation is based on the actual revenue for lost opportunities. To change it to estimated revenue, go to the **Layout** step of the forecast configuration, and select **Est. Revenue** in the **Amount** field. For more information, go to [Choose layout and columns](choose-layout-and-columns-forecast.md).

### What are the configurations that I can edit once a forecast is published?  

You can edit the following configurations for a forecast once it's published:

- On the [General](define-general-properties-scheduling-forecast.md) page, you can edit the forecast title and the default underlying records view.

- On the [Permissions](provide-permissions-forecast.md) page, you can add security roles and provide them with permission to view or edit the forecast.

- On the [Layout](choose-layout-and-columns-forecast.md) page, you can edit column titles, descriptions, and whether or not they show up on the grid.

- On the [Drill-down](configure-manage-drill-downs.md) page, you can add, delete, or update drill-downs.

- On the [Snapshots](/dynamics365/ai/sales/manage-snapshots-forecast) page, you can enable or disable daily snapshots for the forecast.

- On the [Advanced](forecast-configure-advanced-settings.md) page, you can enable or disable auto-hide parent row and multi-currency selection, and customize access to edit fields in the underlying records grid.

When you save and publish the configuration, the changes are applied immediately to the forecast. If you update data (simple columns and adjust fields), these changes may take up to two hours to reflect in the forecast.

### Can I manually set the forecast category of an opportunity as Won or Lost?
  
Technically, you can. The **Opportunity** form and editable grids, other than the grid in the forecast, allow the selection of **Won** or **Lost** as forecast categories.

However, manually setting the forecast category will interfere with your forecast and rollup values, and isn't an ideal practice. For example, if you manually set the value of an opportunity to **Won** without closing the opportunity, the opportunity might not even show up in the forecast. By default, forecasts are configured to show an opportunity as **Won** only when the actual revenue and actual close date are available.

The best practice is to close the opportunity as **Won** or **Lost** and have the forecast category automatically updated. For more information, go to [Close opportunities as won or lost](close-opportunity-won-lost-sales.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
