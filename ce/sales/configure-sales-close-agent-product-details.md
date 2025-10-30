---
title: Configure product details for Sales Close Agent
description: Define the products and value propositions that the Sales Close Agent uses to engage with customers.
ms.date: 11/07/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure product details for Sales Close Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

You must configure the products you want to sell in the product catalog, as the agent uses these products to engage with customers. If no products are available, you can quickly create them from the agent configuration page, and they are added to both the agent and your application’s product catalog. The agent displays pricing based on the default price list specified in the product record; therefore, each product record must include a price.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Best practices

Before you enter or configure the products, review the following best practices:  

- Keep product names short and customer friendly. If the product catalog in Dynamics 365 Sales doesn't contain customer-friendly names in the standard **Product Name** field, you can add an alternative field&mdash;either standard or custom that stores the preferred product name for communications. The agent’s configuration UI allows you to select this field, ensuring outreach and customer-facing emails use the most appropriate product naming without requiring changes to core catalog data.  
- Validate that price and URL fields are complete before publishing. The agent retrieves product page links from the **ProductURL** field in the **Product** table, which might not be exposed on the standard product form, and obtains pricing from the **Amount** field in the **Price List** table referenced as the **Default Price List** for each product, ensuring accurate and consistent product information for automated customer engagement.  
- For complex pricing such as discounts and bundles, the agent doesn’t support dynamic discounting&mdash;stick to base prices.

## Add products and value propositions

1. [Open the Sales Close Agent settings page](open-sales-close-agent-settings.md).  
1. Under the **General** settings section, select **Agent profile**.  
    :::image type="content" source="media/sca-general-products-settings-page.png" alt-text="Screenshot of the Sales Close Agent product settings page.":::  
1. In the **Products** page, from the **Product** drop down list, select the products.  
    The products listed here are configured in your product catalog. To add product in product catalog, see [Add a product](add-product-quote-order-invoice.md#add-a-product).  
    If no products are listed in your product catalog, you can quickly create them and add them to the list, see [Quickly create product records](#quickly-create-product-records). Also, you can use bulk import of products using the **Bulk import** option in **Advance settings**. For more information, see [Import data (all record types) from multiple sources](power-platform/admin/import-data-all-record-types). However, ensure that the products have the name, price, and URL included in the bulk import file.  
    If any product has missing information such as price or URL, [update this information](#update-missing-product-information) for agent to communicate properly with customer.  
1. In the **Value proposition of your product** section, enter the value proposition.  
    The product value proposition specifies why a customer should choose your product instead of your competitor’s. It focuses on what makes your product unique such as the benefits, features, and results it offers.  
    The value proposition serves the following purposes:  
    - It helps craft personalized follow-up messages that highlight the benefits of the products or services.  
    - It can also be used to train or inform the agent about the product domain and the values offered, enabling the agent to provide more relevant and informed responses during customer interactions.  
1. In the **What should we use to search your product knowledge?** section, select up to three fields for which the agent uses to match and retrieve relevant knowledge sources such as product documentation, specs, or manuals during conversations with customers. Ensure that you have proper knowledge inputs in the [knowledge sources]() section.  
    For example, if you configure **Product**, **Product ID**, and **Product Type**, the agent performs search by:  
    - Matching the product name in knowledge sources such as **Surface Laptop 6** in a spec sheet.  
    - Precise matching of product ID with multiple variants exists such as **SL6-512GB-PLAT**.  
    - Using the product type for category-level documents such as laptop guides or comparison charts.  
1. In the **Where do you store customer friendly product name?** section, select the field name in which you store the customer friendly product name for agent to use in email communications.  

## Quickly create product records

When no products are available in your product catalog, you can quickly create them from the agent configuration page. This helps you to set up the agent faster without navigating away from the configuration page. For complete product setup, you can later update the product records in the [product catalog](add-product-quote-order-invoice.md#add-a-product).  
Follow these steps to quickly create product records:  

1. In the **Products** page, select **Quick create product record**.  
    :::image type="content" source="media/sca-general-products-settings-page-quick-create-product.png" alt-text="Screenshot of the Sales Close Agent product page with quick create product record.":::  
1. In the **Create products record(s)** dialog box, enter product name, price, and the product page URL.  
    This information is essential for agents to determine precise pricing, link to purchase pages, and identify products during conversations.  
    >[!NOTE]
    >You can only add up to 10 products to the agent.  

    :::image type="content" source="media/sca-general-products-settings-page-create-product-records.png" alt-text="Screenshot of the Sales Close Agent create product records dialog box.":::  

1. Select **Add** and repeat the previous step to add more products.  
    :::image type="content" source="media/sca-general-products-settings-page-product-records-added.png" alt-text="Screenshot of the Sales Close Agent product records added.":::  
1. Select **Create**.  
Products are added to the agent and to your application’s product catalog.

## Update missing product information

If any product has missing information, it's listed in red. Follow these steps to update the missing information:  

1. In the **Products** page, select **Add missing info**.  
    :::image type="content" source="media/sca-general-products-settings-add-missing-info.png" alt-text="Screenshot of the Sales Close Agent product with add missing info option.":::  
1. In the **Update fields** dialog box, enter the missing information.  
    :::image type="content" source="media/sca-general-products-settings-update-missing-info-dialog-box.png" alt-text="Screenshot of the Sales Close Agent update missing info dialog box.":::

1. Select **Update** to save the changes.
    >[!NOTE]
    >The **Update** option is enabled only after all the missing information is provided.  

The missing product information is updated for the agent and in the product catalog.

## Next step

[Configure target customers for Sales Close Agent](configure-sales-close-agent-target-customers.md)

## Related information

[Set up and configure the Sales Close Agent (preview)](configure-sales-close-agent.md)
