---
title: Product and price list FAQs
description: Get answers to frequently asked questions about product and price list.
ms.date: 03/15/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Product and price list FAQs

This article answers frequently asked questions about product and price list in Dynamics 365 Sales, Sales premium, and Sales professional.

## Why can't I make inline edits or see grid actions like move up or move down in the Product subgrid?

If you select a view other than **Opportunity Product Inline Edit View** in the legacy web client, you can't make inline edits or see grid actions like move up, move down, and lock icons. This is by design. The inline edit view is available in Unified Interface. To verify whether a grid can be edited, go to **Grid control properties**.

:::image type="content" source="media/faqs-grid-control-properties.png" alt-text="Screenshot of the properties settings for the grid control.":::

> [!NOTE]
>
> - In Unified Interface, the behavior of the grid columns **Price Per Unit** and **Quantity** as editable or non-editable is independent of the view that's selected.
> - An editable grid doesn't guarantee that all columns are editable; it depends on the **Pricing**.

<a name="fields-locked"></a>
## Why are some fields editable while some are locked in the product subgrid?

There are certain restrictions on inline editing, based on the type of product in the Products subgrid for opportunity, quote, order, and invoice:

- If it's an individual (unbundled) product and it exists in the product catalog, all fields except **Quantity** and **Discount** are locked for editing.
- If it's an individual product and it exists in the product catalog as a write-in, all fields except **Product Name**, **Quantity**, and **Discount** are locked for editing.
- If it's a product bundle or an optional item in a bundle, all fields except **Quantity** and **Discount** are locked for editing.
- If it's a required product in a bundle, all fields are locked for editing.

## How can I set the default pricing to override price on the product form?

To set the value of the default **Pricing** as **Override Price** on the opportunity, quote, order, or invoice product form, follow these steps:

1. Go to **Settings** > **Customizations** > **Customize the System**.
1. Select **Entities** > **Opportunity Product** > **Fields**.

> [!NOTE]
> For quote, order, and invoice, select **Quote Product**, **Order Product**, and **Invoice Product** forms respectively.

1. Select **ispriceoverridden**, and then set **Default Value** to **Override Price**.
1. Save and publish the customizations.

:::image type="content" source="media/faqs-pricing-change-order-product-form.png" alt-text="Screenshot of customization settings on the Opportunity Product form.":::

## Why can't I update the owning business unit for opportunity products?

There's no direct relationship between business units and opportunity products. The owning business unit for opportunity products is automatically inherited from the parent opportunity. So, you can't update the owning business unit at the opportunity product-level.

<a name="change-prices-locked"></a>
## How do I change the default value for Prices Locked?

You can change the default value for **Prices Locked** in the **Order** or **Invoice** form through customizations or the inline editable grid:

1. Go to **Settings** > **Customizations** > **Customize the System**.
1. Select **Entities** > **Order** or **Invoice** > **Fields**.
1. Select **ispricelocked**, and then set **Default Value** to **No**.
1. Save and publish the customizations.

## How do I change the state of Prices Locked?

To change the state of **Prices Locked**, select the **Lock** icon on the inline editable grid.

**In the legacy web client:**

:::image type="content" source="media/faqs-edit-pricing-for-product.png" alt-text="Screenshot of editing the pricing for a product in the legacy web client.":::

**In Unified Interface:**

:::image type="content" source="media/faqs-edit-pricing-for-product-uci.png" alt-text="Screenshot of editing the pricing for a product in Unified Interface.":::

## Why can't I change the values in the Price Per Unit column in the Products grid?

The **Prices Locked** (**ispricelocked**) setting controls whether the prices specified on the **Order** or **Invoice** form can be changed.

The following tables show the interaction between **Prices Locked** and **Price Per Unit** on editable and non-editable grids in the **Products** subgrid and **Order** product form.

**For existing products:**

| **Prices Locked** | **Price Per Unit** (editable grid) | **Price Per Unit** (non-editable grid) | **Order** product form |
|-------------|-------------|-------------|-------------|
| Yes | Non-editable | Non-editable | Non-editable |
| No and **Pricing** is **Override Price** | Editable | Non-editable | Editable |
| No and **Pricing** is **Use Default** | Non-editable | Non-editable | Non-editable |

**For write-in products:**

| **Prices Locked** | **Price Per Unit** (editable grid) | **Price Per Unit** (non-editable grid) | **Order** product form |
|-------------|-------------|-------------|-------------|
| Yes | Non-editable | Non-editable | Non-editable |
| No | Editable | Non-editable | Editable |

## How does changing the product price in Price list affect Price Per Unit on the Order product form?


The following table shows the effect of changing the product price in **Price list** on the **Price Per Unit** of the **Order** product form.

| Entity state | IsPriceLocked | Pricing | Does **Price Per Unit** change? |
|--------------|---------------|---------|---------------------------------|
| Editable | Yes | Default or Override | No |
| Editable | No | Default | Yes |
| Editable | No | Override | No |
| ReadOnly | Yes or No | Default or Override | No |