---
title: Create or edit sales orders
description: Use orders to track details of the products or services that your customers want to place an order for.
ms.date: 07/29/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-quote
  - D365-Entity-salesorder
  - D365-Entity-invoice
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Create or edit sales orders

Use orders to track details of the products or services that your customers want to place an order for.

## License and role requirements

| Requirement type | You must have |
|------------------|---------------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br> More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br> More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## When to create an order

Create an order when the customer is ready to buy your products or services. In Dynamics 365 Sales, an order can originate from a customer's acceptance of a quote, or you can place an order without an accepted quote, depending on the situation.

One way that can help you increase your sales is to add all products that your customer might need to your order. Dynamics 365 Sales may also offer product bundles or product families to make it easier for you to choose products for upsell and cross-sell. If you've already prepared a quote for your customer, you can create an order from that quote.

<a name="bkmk1"></a>

## Create an order from a quote

Typically, you convert a quote that you have won into an order. Start with an active quote. Note that after a quote is accepted, you won't be able to revise it.

1. Select the Site map icon :::image type="icon" source="media/site-map-icon.png" alt-text="Screenshot of Site map icon" border="false":::, and then select **Quotes**.

2. Select the quote you want to create an order for.
3. On the command bar, select **Activate Quote**.
4. After the quote is activated, select **Create Order** on the command bar.
    > [!NOTE]
    > In the Sales Professional app, the **Create Order** option is available only if your administrator has [enabled creation of orders from quotes](enable-creation-of-orders-from-quotes.md)
5. In the **Create Order** dialog box, the **Date Won** field is set to the current date. Select a different date if required.
6. Add a description, and select **OK**.
   The order is created and all products from the quote are added to the order. The price list and currency are also copied from the quote to the order.

   Depending on whether you've enabled [sales order processing integration](developer/enable-sales-order-processing-integration.md), the **Prices Locked** field is set as follows:
     - If the integration is disabled, the **Prices Locked** field is set to **Yes**.

     - If the integration is enabled, the **Prices Locked** field is set to the default value specified for the `ispricelocked` column in the Order table. If you haven't updated the column, the **Prices Locked** field is set to **No**. More information: [Lock or unlock the price for an order or invoice](lock-unlock-price-order-invoice.md)


## Create an order

You can create an order that is based on your communication with a customer instead of an accepted quote.

1. Select the Site map icon :::image type="icon" source="media/site-map-icon.png" alt-text="Screenshot of Site map icon" border="false":::, and then select **Orders**.

2. Select **New**.
3. On the **Order** form, enter data in the following required fields:
   - **Name**. You must enter a name with a length of 100 characters or fewer. The information should be meaningful and unique. By default, these records are sorted by Name in the records list.
   - **Price List** and **Currency**: Select the price list and the currency that will be used to calculate the product prices.
    > [!NOTE]
    >- By default, selecting a price list is required to be able to add products to an order. However, your administrator can change your organization settings to make the Price list field optional. 
    >- Your base record and all its line items must use the same currency. For example, if your order has the currency set to U.S Dollars, you must use the same currency for the price list items that you add to the order. You can't change the currency of the base record (in this case, an order), unless you remove all the line items associated with the record.
   - **Prices Locked**. This field is read-only. You can change it after you save the order. For more information, see [Lock or unlock the price for an order or invoice](lock-unlock-price-order-invoice.md).

4. In the **Sales Information** section, in **Potential Customer**, select the customer you're creating this order for.
  
5. On the command bar, select **Save** to create the order record.  
  
6. To add products from your opportunity to your order, select the **More options** icon ![More commands icon](media/more-commands-button.png "More commands icon") and then choose **Get Products**, select your opportunity, and select **OK**.  
  
    -OR-
    To manually add other products, in the **Products** section, select **Add Product**. For more information, see [Add products to Quote, invoice, or order records](add-product-quote-order-invoice.md). If your administrator has configured the enhanced experience for adding products, you'll see the **Add Products** button. For more information about adding products using the enhanced experience, see [Find and add multiple products to quotes, orders, or invoices](add-products-qoi-enhanced.md). 
   > [!NOTE]
   >- You need to enter the tax amount when you add a product to a quote, order, or invoice. Dynamics 365 Sales does not automatically calculate tax for individual products. However, the total tax is calculated automatically based on the sum of the tax amounts for all of the individual products in a quote, order, or invoice.

7. In the **Shipping Information** area, enter shipping details.
8. In the **Addresses** area, enter shipping and billing addresses.
9. Select **Save** in the lower-right corner of the screen.

> [!NOTE]
>- You close an order by either fulfilling the order or canceling the order. Products or services that are shipped are fulfilled. You should cancel orders for any products or services that are not shipped.
>- If you've modified the maximum character limit for the Description attribute in the Order entity, ensure that you make a corresponding change in the Order Close entity as well. This is necessary to prevent potential errors or data truncation when the system copies the Description from the Order entity to the Order Close entity.
>- You can't set the status of multiple orders to fulfilled at one go.
>- You can't update or change an order after it's closed, or if it's partially or completely fulfilled.


<a name="bkmk3"></a>
## Typical next steps
:::image type="content" source="media/orange-right-arrow-button.png" alt-text="Screenshot of Right arrow button"::: [Create or edit an invoice](create-edit-invoice-sales.md)

:::image type="content" source="media/home-button.png" alt-text="Screenshot of Home button"::: [Learn about the sales process, nurturing sales from lead to order](nurture-sales-from-lead-order-sales.md)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Print quote, invoice, or other records](print-records.md)
[Sales transactions in Dynamics 365 Sales](sales-transactions.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]