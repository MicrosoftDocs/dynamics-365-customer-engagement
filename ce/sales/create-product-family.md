---
title: Set up product families | MicrosoftDocs
description: Make it easier for sales agents to find products and services in a product catalog by creating a product family and classifying similar products
ms.date: 08/09/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-product
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---

# Set up product families

Make it easier for sales agents to find products and services in a product catalog by creating a product family and classifying similar products.

> [!NOTE]
> Product families are only supported for Sales Enterprise and Sales Premium.

## What is a product family?

A product family lets you group and categorize products, making it easier for you to manage them.

With product families, you can:

- Categorize your products in whichever way is most meaningful to your organization.
- Create child products and product bundles within a product family. (Product bundles allow you to sell multiple items together.)
- Create as many levels of product families as you want by creating a family within a family.

:::image type="content" source="media/v7-product-hierarchy.png" alt-text="Screenshot of hierarchy of families and products in Dynamics 365 Sales.":::

> [!NOTE]
> The product family that you use for creating a product, bundle, or another product family becomes the parent family.

## Create a product family (Sales Hub)

1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]

2. Select the site map :::image type="icon" source="media/site-map-icon.png" border="false":::, then select **App Settings**.

3. Under **Product catalog**, select **Families and Products**.

4. To create a family, on the command bar, select **Add Family**.

    -OR-

    To create a child product family under an existing family, select the family, and select **Add Family**. The selected family becomes the parent family of the new family you're creating.

    :::image type="content" source="media/add-family.png" alt-text="Screenshot of Add Family option in the product catalog.":::

5. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]

   > [!NOTE]
   > The **Valid From** and **Valid To** fields define the duration that a product is valid for. There's no business logic associated with these fields except that the **Valid To** date must be later than the **Valid From** date. If required, you can implement your own business logic in these fields with a workflow, plug-in, or by using the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)]. For example, you could run a scheduled job to automatically retire last season's products using the date selected in the **Valid To** field.

6. Select **Save**.

7. In the list of products, families, and bundles, open the family that you just created.

8. On the **Product Properties** tab, select the **Add New Property** button, and add the required properties. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use properties to describe a product](use-properties-describe-product.md)

## Typical next steps

:::image type="icon" source="media/walkthrough-orange-right-arrow.png" border="false"::: [Use properties to describe a product](use-properties-describe-product.md)

:::image type="icon" source="media/walkthrough-orange-right-arrow.png" border="false"::: [Create a product](create-product-sales.md)

:::image type="icon" source="media/walkthrough-home.png" border="false"::: [Classify products and bundles into product families](create-product-bundles-sell-multiple-items-together.md)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information  
 [Set up a product catalog](set-up-product-catalog-walkthrough.md)   
 [Clone a product](clone-product.md)<br>
 [Change the parent of a product (reparenting)](change-product-parent.md)  

[Set up a product catalog](set-up-product-catalog-walkthrough.md)  
[Clone a product](clone-product.md)<br>
[Change the parent of a product (reparenting)](change-product-parent.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]