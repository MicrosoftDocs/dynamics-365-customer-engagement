---
title: "Add products to quotes, orders, or invoices (Dynamics 365 Sales) | MicrosoftDocs"
description: "Include details about the products that your customer is interested in purchasing in your quote, order, or invoice in Dynamics 365 Sales."
ms.date: 05/10/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-quote
  - D365-Entity-invoice
  - D365-Entity-quotedetail
  - D365-Entity-salesorderdetail
  - D365-Entity-invoicedetail
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Add products to quotes, orders, or invoices

You can add products or product bundles to a quote, order, or invoice record. The product can be an existing product in the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] product catalog or an ad hoc product that you add as a write-in product. 

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|



## Add a product

If you've created a quote from an opportunity, the products added to the opportunity are automatically added to the quote. You can add more products or remove the existing ones. You can also add products from a different opportunity by selecting **Get products** from the command bar.

The process for adding a product to a quote record is the same as adding a product to an order or an invoice. This topic explains how to add products to a quote record.

1. From the list of quotes, open the quote record you want to add the product to. 

2. In the **Products** section of the **Summary** tab, add products to the quote using one of the following methods:
    - To add products from an opportunity, select the **More commands** button :::image type="icon" source="media/more-commands-icon.png" border="false"::: > **Get products** and select the opportunity.  
       Products from the selected opportunity are added to the quote.
  
    - To find and add products manually, select **Add product**.

        1. In the **Quick Create: Quote Product form**, do the following: 
    
        1.	In the **Select Product** drop-down list, select whether you want to add an existing product or create a new one:
    
            - In the **Existing Product** field, select **Lookup** to search for and add a product. Also, select a unit of measurement for the product.
    
              > [!NOTE]
              > - When a price list is selected for the opportunity, the products listed in the **Existing Product** field are filtered by the price list. This means that only the product associated with the selected price list are shown in this field. In this case, the default view is set to **Products in Parent Price List** view. You can't set a custom view as the default view. Even if you do, the Products lookup will automatically set it back to **Products in Parent Price List** view.
              > - When a price list isn't selected, the **Existing product** field shows all active products (not filtered by the price list). You can change the view to look for other products by selecting the **Change View** icon. 
              > - By default, the product lookup will show the most recently used products. The most recently used products are not filtered based on the selected price list. 
              > - If a price list is selected, and you select a product that isn’t associated with the price list, you'll see an error. Select a product that's associated with the selected price list.
    
            - To create a product, select **Write-In**, and then enter the name of the product. 
              > [!IMPORTANT]
              > To add a write-in product to orders and invoices, ensure that the **Prices Locked** field is set to **No**. If it's set to **Yes**, you won't be able to add write-in products because prices of write-in products are considered as overridden. **More information**: [Lock or unlock the price for an order or invoice](lock-unlock-price-order-invoice.md), [Sales transactions in Dynamics 365 Sales](sales-transactions.md)  
              
    
        2.	Fill in details in the **Pricing** section:
    
            - **Price Overridden**: If you’re adding an existing product from the product catalog, select whether you want to use the default pricing that is listed in the product catalog or override the price. For a write-in product, this field is set to **Override** Price. 
    
            - **Price Per Unit**: If you’re adding a write-in product, enter the price to be charged per unit for the product.
    
            - **Quantity**: Enter the quantity of the product or service that will be included. 
    
            - **Manual Discount**: If you want to offer a discount to the product price, enter it here. 
    
            - **Tax**. If required, enter the appropriate tax amount. 
    
    4. To save this product, and add more products, select **Save and New**.

The **Products** grid shows all the products that are associated with the quote. After you add a product, you can change the unit, price, quantity, and discount of the product inline in the **Products** grid. For a write-in product, you can also change the price of the product in addition to the quantity and discount. 

Here are the actions you can take on the products in the Products grid:

|To                                    |Do This                                                           |
|--------------------------------------|------------------------------------------------------------------|
|Edit properties of a product  |Select a product, and on the command bar, select **Edit**. You can change details such as the price, quantity, or discount of the added products. <br/> You can also open the quote product, order product, or invoice product record, and view or change the properties of the product inline on the **Product Properties** tab. |
|Delete a product associated with the quote |Select the product, and on the command bar, select the **More commands** button :::image type="icon" source="media/more-commands-icon.png" border="false"::: > **Delete Quote Product**. |
|View products within a bundle | Select the **Chevron** icon ![Chevron icon.](media/chevron-icon.png "Chevron icon") for the product bundle. You’ll see all the products that are included in the bundle. |
|See and add related products for cross-selling or upselling or to select an accessory or substitute product | Select a product, and on the command bar, select **Suggestions**. The **Suggestions** pane shows all the products that are defined as related products for the current product. Select the related products that you want to add, and then select **OK**. |
|See specific records together by moving a record up or down in the grid | Select a record, and on the command bar, use the **Move Up** or **Move Down** button. |

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also  
 [Create or edit a quote](../sales-enterprise/create-edit-quote-sales.md)  
 [Create or edit an order](../sales-enterprise/create-edit-order-sales.md)  
 [Create or edit an invoice](../sales-enterprise/create-edit-invoice-sales.md)  
 [Price calculation for opportunity, quote, order, and invoice records](price-calculation-opportunity-quote-order-invoice-records.md)   
[Troubleshoot issues with products](/troubleshoot/dynamics-365/sales/troubleshoot-products-issues)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
