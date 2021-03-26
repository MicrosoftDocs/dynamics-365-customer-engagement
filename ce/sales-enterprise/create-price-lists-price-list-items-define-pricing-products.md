---
title: "Define product pricing with price lists and price list items (Dynamics 365 Sales) | MicrosoftDocs"
description: "Define what to charge for your products or services in Dynamics 365 Sales."
ms.date: 02/10/2021
ms.service:
  - "dynamics-365-sales"
ms.topic: get-started-article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-pricelevel
  - D365-Entity-productpricelevel
  - D365-Entity-product
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Define product pricing with price lists and price list items (Sales Hub)

Price lists tell your sales agents what to charge for your products or services. You can create multiple price lists so that you can maintain separate price structures for different regions you sell your products in or for different sales channels.  
  
Price lists tie the unit, product, and pricing details together, so before you create a price list, make sure the units and products are in place.  
 

## Create a price list and price list items and add default price list for a territory (Sales Hub)

1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
2. At the bottom of the site map, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**. 
  
3. In the **Product Catalog** area, select **Price Lists**. 

    ![Price list in site map](media/site-map-product-catalog.png "Price list in site map")
  
4. To create a new price list, select **New**.  
  
    -OR-  
  
    To edit a price list, open a price list from the list.  
  
5. In the price list form, fill in your information, and then select **Save**. 

    a.  **Name**. Type a descriptive name for the price list. For example, if you're creating a price list for retail, mention that.

    b.  **Start Date**/**End Date**. Select the start date and end date for the price list. For example, if this is a promotional price list that’s effective only for the promotional period, select that period.

    c.  **Currency**. Select the currency you’re creating the price list for. You can have different price list for different currencies.

    > [!div class="mx-imgBorder"]
    > ![General tab in price list form](media/price-list-form.png "General tab in price list form")
  
6.	To add price per unit for a product, create and add price list items.

    a.	In the **Price List** form, select the **Price List Items** tab, and then select **Add New Price List Item**.

    > [!div class="mx-imgBorder"]
    > ![Add New Price List Item button on the Price List Items tab](media/price-list-form-price-list-items-tab.png "Add New Price List Item button on the Price List Items tab")
 
    b.  In the **Price List Item** form, fill in the information, and select **Save**:

       -  **Product**. Select the product for which you’re creating this price list.

       -  **Unit**. Select the unit for the product you’re creating this price list for.

       -  **Currency**. The currency defined for the price list is automatically populated.

       -  **Discount List**. If you want to offer a discount on the products, select a discount list to the price list item. 

       -  **Quantity Selling Option**. select whether the product or service can be ordered in whole, partial, or both types of quantities. This information is used in the Quantity field of Quote Product, Order Product, and Invoice Product records. 

       > [!div class="mx-imgBorder"]
       > ![Price list item form](media/price-list-item-form.png "Price list item form")

    c.  In the **Price List item** form, on the **Pricing information** tab, fill in the following information, and select **Save & Close**:

       -  **Pricing Method**. select an option that determines how the pricing will be calculated. It could be a certain amount, or a percentage of the current or standard cost. The available options are as follows: 
          -  **Currency Amount**. Use this to ignore a product's list price in the product catalog and to enter a different price manually for this price list.  
          
          -  **Percent of List**. Use this to calculate a product's price in the price list as a percentage of the list price of the associated product.  
        
          -  **Percent Markup - Current Cost**. Use this to add a percent markup on top of the current cost of the product.   

          - **Percent Markup - Standard Cost**. Use this to add a percent markup on top of the standard cost of the product.

          -  **Percent Margin - Current Cost**. Use this for the price offered in the price list to yield a percentage margin of the current cost of the product. 

          -  **Percent Margin - Standard Cost**. Use this for the price offered in the price list to yield a percentage margin of the standard cost of the product.

       -  **Amount**. If you selected **Currency Amount** as the pricing method, type the amount at which the product will be sold.

       -  **Percentage**. If you selected any value other than **Currency Amount** as the pricing method, type the percentage for the pricing method that you want.

       -  **Rounding Policy**. If you selected a pricing method other than **Currency Amount**, you can set up a rounding policy. For example, if you want per unit prices to be in the form of $0.99, you can select a rounding policy where all prices per unit automatically have a price that ends in 99 cents. To do this, you select the rounding policy to round up the price, and then set the price to end in a certain amount, such as 99 cents.

          -  **None**. Prices are not rounded.

          -  **Up**. Prices are rounded up to the nearest rounding amount.

          -  **Down**. Prices are rounded down to the nearest rounding amount.
    
          -  **To Nearest**. Prices are rounded to the nearest rounding amount.

       -  **Rounding Option**. Select **Ends in** or **Multiple of** if you want the price to end in a certain amount or multiples of a certain amount.

       -  **Rounding Amount**. Enter the amount.

            > [!div class="mx-imgBorder"]
            > ![Pricing information tab on the price list form](media/pricing-information-tab-price-list-item-form.png "Pricing information tab on the price list form")

        More information: [Price calculation for opportunity, quote, order, and invoice records](price-calculation-opportunity-quote-order-invoice-records.md)
 
7.  You can also associate default price lists for territories so that the sales reps working with accounts on contacts in certain territories have the price list selected by default. 

    a.  In the price list record, select the **Territory Relationship** tab.

    b.	In the **Territories** section, select **Add New Connection**.

    c.	In the **New Connection** form, enter the following, and select **Save & Close**: 
    
    -  **Name**. Select the Lookup button and select a territory.
      
    -  **As this role**. Select a connection role that is associated with the territory record type.

         > [!div class="mx-imgBorder"]
         > ![Add territory as connection](media/add-territory-as-connection.png "Add territory as connection")
 
    d.	In the price list record, select **Save & Close**.
  
      > [!NOTE]
      >  You must create at least one price list for each of the currencies that your organization does business in.  


## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Publish a product or bundle to make it available for selling](publish-product-bundle-make-available-selling.md)  
  
 ![Home button](../sales-enterprise/media/walkthrough-home.png "Home button") [Set up a product catalog: Walkthrough](../sales-enterprise/set-up-product-catalog-walkthrough.md)  
  
### See also  
 [System Settings dialog box - Sales tab](/power-platform/admin/system-settings-dialog-box-sales-tab)   
 [Classify products and bundles into product families](../sales-enterprise/create-product-bundles-sell-multiple-items-together.md)  
[Price calculation for opportunity, quote, order, and invoice records](price-calculation-opportunity-quote-order-invoice-records.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]