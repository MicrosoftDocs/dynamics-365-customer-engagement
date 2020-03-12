---
title: "Frequently asked questions (Dynamics 365 Sales) | MicrosoftDocs"
description: "Frequently asked questions for Dynamics 365 Sales"
ms.date: 10/01/2019
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shubhadaj
---

# Frequently asked questions

## Entity: Opportunity

**Question**:<br>When can I edit the **Est.Revenue** value in the **Opportunity** form?

**Answer**:<br>To edit the value of estimated **Revenue** in the **Opportunity** form, the **Revenue** must be configured as **User Provided** and the opportunity must be in an **Open** state. 

   > [!div class="mx-imgBorder"]
   > ![Edit estimated revenue](media/faqs-est-revenue.png "Edit estimated revenue")


## Entities: Opportunity, Quote, Invoice, and Order

> [!NOTE]
> In this section, we use the entity **Opportunity** to frame the questions. However, these questions are also true for these other entities: **Quote**, **Invoice**, and **Order**.

**Question**:<br>Why does a view other than **Opportunity Product Inline Edit View** lose the inline editing functionality and why can't I see grid actions such as move up, move down, and lock icons in the legacy web client if a view other than **Opportunity Product Inline Edit View** is selected for the **Opportunity Product** subgrid in the **Opportunity** form?

**Answer**:<br>This is known and by-design behavior in Web Client. However, this behavior is changed in Unified Interface. We recommend that you use Unified Interface to experience the inline edit view. To verify if a grid is editable, go to **Grid control properties**.

   > [!div class="mx-imgBorder"]
   > ![Properties settings for grid control](media/faqs-grid-control-properties.png "Properties settings for grid control")

   > [!NOTE]
   > - In Unified Interface, the behavior of the grid columns **Price Per Unit** and **Quantity** as editable or non-editable is independent of the view that is selected.  
   > - An editable grid doesn’t guarantee that all columns are editable; it depends on the **Pricing**.

## Entities: Opportunity Product, Quote Product, Order Product, and Invoice Product 

> [!NOTE]
> In this section, we use the entity **Opportunity Product** to frame the questions. However, these questions are also true for these other entities: **Quote Product**, **Order Product**, and **Invoice Product**.

**Question**:<br>How can I configure the value of the default **Pricing** to **Override Price** on the **Opportunity Product** form?

**Answer**:<br>To configure the value of the default **Pricing** as **Override Price** in the **Opportunity Product** form: 
1. Go to **Settings** > **Customizations** > **Customize the System**.
2. Select **Entities** > **Opportunity Product** > **Fields**.
3. Select the **ispriceoverridden** field and configure the **Default Value** to **Override Price**.
4. Save and publish the customizations.

  > [!div class="mx-imgBorder"]
  > ![Change pricing on order form](media/faqs-pricing-change-order-product-form.png "Change pricing on order form")
 
## Entities: Order and Invoice

> [!NOTE]
> In this section, we use the entity **Order** to frame the questions. However, these questions are also true for the entity **Invoice**.

**Question**:<br>How can I change the default value for the **Prices Locked** field in the **Order** form?

**Answer**:<br>You can change the default value for the **Prices Locked** field in the **Order** form through customizations or the inline editable grid:
  1. Go to **Settings** > **Customizations** > **Customize the System**.
  2. Select **Entities** > **Order** > **Fields**.
  3. Select the **ispricelocked** field and configure the **Default Value** to **No**.
  4. Save and publish the customizations.

**Question**:<br>For a particular **Order** form, how can I change the state of **Prices Locked** field?

**Answer**:<br> You can change the state for the **Prices Locked** field through inline editable grid. Select the **Lock** icon on the editable grid and the state of the **Prices Locked** field changes accordingly. 

In Web Client: 
  > [!div class="mx-imgBorder"]
  > ![Edit pricing for a product](media/faqs-edit-pricing-for-product.png "Edit pricing for a product")

In Unified Interface:
  > [!div class="mx-imgBorder"]
  > ![Edit pricing for a product in Unified Interface](media/faqs-edit-pricing-for-product-uci.png "Edit pricing for a product in Unified Interface")

**Question**:<br>When can I change the values in **Pricing Per Unit** column in the **Products** grid?

**Answer**:<br>The **Prices Locked** (ispricelocked) field controls the prices specified on the **Order** form and locks them from any further updates.<br>

These tables define the behavior of **PricePerUnit** in the **Products** subgrid and **Order** product form:<br> 

**For existing product**:
 
|Configuration| In editable grid – **PricePerUnit** column value| In non-editable grid – **PricePerUnit** column value| **Order** product form|
|-------------|-------------|-------------|-------------|
|**Prices Locked** is Yes|Non-editable|Non-editable|Non-editable|
|**Prices Locked** is No and **Pricing** is Override Price|Editable|Non-editable|Editable|
|**Prices Locked** is No and **Pricing** is Use Default|Non-editable|Non-editable|Non-editable|

**For write-in product**:

|Configuration| In editable grid – **PricePerUnit** column value| In non-editable grid – **PricePerUnit** column value| **Order** product form|
|-------------|-------------|-------------|-------------|
|**Prices Locked** is Yes|Non-editable|Non-editable|Non-editable|
|**Prices Locked** is No|Editable|Non-editable|Editable|
   
**Question**:<br>What is the result of changing the product price in **Pricelist** on the **PricePerUnit** of the **Order** product form?

**Answer**:<br>The following table defines the effect of changing the product price in **Pricelist** on the **PricePerUnit** of the **Order** product form:

|Entity state|IsPriceLocked|Pricing|Is the value of **PricePerUnit** on the **Order** product form changed?|
|------------|-------------|-------|----------------------------------------------------------------------|
|Editable|Yes|Default or Override|No|
|Editable|No|Default|Yes|
|Editable|No|Override|No|
|ReadOnly|Yes or No|Default or Override|No|
