---
title: Lock or unlock the price for an order or invoice 
description: Define whether the prices on orders and invoices in Dynamics 365 Sales will be locked.
ms.date: 08/01/2023
author: lavanyakr01
ms.author: lavanyakr
ms.topic: how-to 
ms.custom: bap-template 
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-salesorder
  - D365-Entity-pricelevel
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Lock or unlock the price for an order or invoice (Sales Hub) 

After you've finalized an order or invoice for a specific price, you can lock the price to prevent it from being updated when the price list is updated. Conversely, you can enable current pricing to update the price on the order or invoice when the price list is updated.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Lock prices or use current pricing

1. In the site map, select **Orders** or **Invoices**.

2. Open the order or invoice you want to edit.

3. To lock prices, on the command bar, select the More Commands icon ![More Commands icon.](media/more-commands-icon.png "More Commands icon"), and then select **Lock Pricing**.
    
    When you lock the price, the following happens:

      - The **Prices Locked** field in the order or invoice is set to **Yes**.

      -  The **Price Per Unit** field is locked for all the products in the order or invoice and is disabled for editing.
      - You won't be able to add write-in products to the order or invoice as you need to specify the price for write-in products.
      - Though you can change the price list of the order or invoice, the prices of the products are not updated based on that price list.
      - You can continue to add products to the quote at the default price, but you won't be able to edit the price.  
 
4. To unlock prices and use current pricing, on the command bar, select the More Commands icon ![More Commands icon.](media/more-commands-icon.png "More Commands icon"), and then select **Use Current Pricing**.

    When you use current pricing, the following happens:

    - The **Prices Locked** field in the order or invoice is set to **No**.

    - The **Price Per Unit** field is unlocked for all the products in the order or invoice and becomes editable. You can choose to use the default price or override the price.
    - When you open or edit the quote or invoice, the price of the line items is automatically updated to reflect any changes in the price list.
    - If the price of a line item has been overridden in the order or invoice, it’s unaffected by any changes to the price list. 


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Create or edit orders](create-edit-order-sales.md)  
[Create or edit invoices](create-edit-invoice-sales.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
