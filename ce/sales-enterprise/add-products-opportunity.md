---
title: "Add products to an opportunity (Dynamics 365 Sales) | MicrosoftDocs"
description: "Develop your opportunity by defining the products your customers are interested in purchasing."
ms.date: 06/15/2020
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
---

# Add products to an opportunity (Sales Hub)

A way that might help you increase your sales is to add all products that your customer might need. You can add product bundles or product families to make it easier for you to choose products for upsell and cross-sell. The product might already exist in the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] product catalog or it can be a product that you write in. Any products added to an opportunity are automatically associated with quotes generated from the opportunity.


1. From the list of opportunities, open the opportunity to which you want to add products.

2. Go to the **Product Line Items** tab.

3. Select a **Price List**. The price list determines the cost of the product. 
  
    > [!NOTE]
    > By default, you must select a price list to be able to add products to an opportunity; however, your administrator can change your organization settings to make the **Price List** field optional.

4. If you want the estimated revenue of the opportunity to be calculated based on the total number of products, set **Revenue** to **System Calculated**. If you want to use a custom estimated revenue, set it to **User Provided**.

5. In the **Product Line Items** grid, select **Add New Opportunity Product**.

6. In the **New Opportunity Product** form, do the following:  

    1.  **Select Product**: Set the switch to choose whether you want to add an existing product or create a new one:
    
        -  To use an existing product, select **Lookup** to search for and add a product.

            
            > [!NOTE]
            > - When a price list is selected for the opportunity, the products listed in the **Existing Product** field are filtered by the price list. This means that only the products associated with the selected price list are shown in this field. 
            > - When a price list isn't selected, the **Existing product** field shows all active products (not filtered by the price list). You can change the view to look for other products by selecting the **Change View** icon. 
            > - By default, the product lookup will show the most recently used products. The most recently used products aren't filtered based on the selected price list. 
            > - If a price list is selected and you select a product that isn't associated with the price list, you'll see an error. Select a product that's associated with the selected price list.

        -  To add a product, select **Write-In**, and then enter the name of the product.
    
    2.  **Pricing**: Select the pricing option. By default, this is the per unit price that's listed in the product catalog. To override the catalog price, select **Override Price**: When you override the price, you can specify a price that you want to charge for each unit of the product.

    3.  **Quantity**: Enter the quantity of the product or service that will be included.  

    4.  **Manual Discount**: If you want to offer a discount to the product price, enter it here.  
    
    5.  **Tax**: If required, enter the appropriate tax amount.  
   
7. To save this product, and add more products, select **Save and New**.

The **Product Line Items** grid shows all the products that are associated with the opportunity. If you added an existing product from the product catalog, you can change the quantity and discount of the product inline in the **Product Line Items** grid. If you added a write-in product, you can also change the price of the product in addition to the quantity and discount.

You can take the following actions on the products added to the **Product Line Items** grid.

|To                                    |Do This                                                       |
|--------------------------------------|--------------------------------------------------------------|
|Edit the properties of a product.  |Select the product, and on the command bar, select **Edit Properties**. You can change details such as the price, quantity, or discount of the added products. <br/> You can also open the opportunity product record, and view or change the properties of the product inline on the **Product Properties** tab. |
|Delete a product associated with the opportunity. |Select the product, and on the command bar, select **Delete Opportunity Product**. |
|View products within a bundle. | Select the **Chevron** icon ![Chevron icon](media/chevron-icon.png "Chevron icon") for the product bundle. You'll see all the products that are included in the bundle. |
|See and add related products for cross-selling or upselling, or select an accessory or substitute product. | Select a product, and on the command bar, select **Suggestions**. The Suggestions pane shows all the products that are defined as related products for the current product. Select the related products that you want to add, and then select **OK**. |
|Group specific records together by moving a record up or down in the grid. | Select the record, and on the command bar, use the **Up** or **Down** button. |

> [!IMPORTANT]
> If your system administrator has enabled the enhanced "add product" experience for adding products to an opportunity, you'll see a different experience. To learn more, see [Add products to an opportunity by using the enhanced experience](add-products-enhanced-experience.md).

### See also  

[Create or edit an opportunity](../sales-enterprise/create-edit-opportunity-sales.md)  
[Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)   
[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  
[Price calculation for opportunity, quote, order, and invoice records](price-calculation-opportunity-quote-order-invoice-records.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
