---
title: "Create a product family (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Make it easier for sales agents to find products and services in a product catalog by creating a product family and classifying similar products in it in Dynamics 365 for Sales."
keywords: "Product family"
ms.date: 04/01/2018
ms.service: crm-online
ms.custom: Make it easier for sales agents to find products and services in a product catalog by creating a product family and classifying similar products in it in Dynamics 365 for Sales.
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: c5844aaf-a77f-4097-bfb5-1022ad53dcea
author: shubhadaj
ms.author: shujoshi
manager: brycho
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 25
topic-status: Drafting
---

# Create a product family (Sales)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Make it easier for sales agents to find products and services in a product catalog by creating a product family and classifying similar products in it. A product family lets you group and categorize products, making it easier for you to manage them.  
  
 With product families, you can:  
  
-   Categorize your products in whichever way is most meaningful for your organization.  
  
-   Create child products and product bundles within a product family. Product bundles allow you to sell multiple items together.  
  
-   Create as many levels of product families as you want by creating a family within a family.  
  
 ![Hierarchy of families and products in Dynamics 365](../sales-enterprise/media/v7-product-hierarchy.png "Hierarchy of families and products in Dynamics 365")  
  
> [!NOTE]
>  The product family that you use for creating a product, bundle, or another product family becomes the parent family. You can't change the parent family for the child products, bundles, or families. In the preceding example, "Televisions" is the parent family for "LED TVs" and "Plasma TVs," and you can't change these to have a different parent family.  
  
1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_prod_catalog](../includes/proc-settings-prod-catalog.md)]  
  
3.  In the **Product Catalog** area, select **Families & Products**.  
  
4.  To create a family, select **Add Family**.  
  
     -OR-  
  
     To create a child product family under an existing family, select the family, and select **Add Family**. The selected family becomes the parent family of the new family you're creating.  
  
     If you want to see your current product family levels, see [View product hierarchy](../sales-enterprise/view-product-hierarchy.md).  
  
5. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
    > [!NOTE]
    >  The **Valid From** and **Valid To** fields define the duration that a product is valid for. There's no business logic associated with these fields except that the **Valid To** date must be later than the **Valid From** date. If required, you can implement your own business logic in these fields with a workflow, plug-in, or by using the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)]. For example, you could run a scheduled job to automatically retire last season's products using the date selected in the **Valid To** field.  
  
6.  Select **Save**.  
  
7.  In the list of products, families, and bundles, open the family that you just created.  
  
8.  In the **Product Properties** section, select the **Add Properties** button ![Add properties button](../sales-enterprise/media/add-properties-button.png "Add properties button"), and add the required properties. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use properties to describe a product](../sales-enterprise/use-properties-describe-product.md)  
  
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Use properties to describe a product](../sales-enterprise/use-properties-describe-product.md)  
  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Create a product](../sales-enterprise/create-product-sales.md)  
  
 ![Home button](../sales-enterprise/media/walkthrough-home.png "Home button") [Classify products and bundles into product families](../sales-enterprise/create-product-bundles-sell-multiple-items-together.md)  
  
### See also  
 [Set up a product catalog: Walkthrough](../sales-enterprise/set-up-product-catalog-walkthrough.md)   
 [Clone a product](../sales-enterprise/clone-product.md)
