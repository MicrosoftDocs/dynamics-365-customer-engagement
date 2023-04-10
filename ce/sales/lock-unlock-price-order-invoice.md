---
title: "Lock or unlock the price for an order or invoice in Dynamics 365 Sales | MicrosoftDocs"
description: "Define whether the prices on orders and invoices in Dynamics 365 Sales will be locked."
ms.date: 10/25/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
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

To determine whether your order or invoice is using Prices Locked, see the **Prices Locked** field on Order or Invoice form. If the **Prices Locked** field is set to **No**, **Use Current Pricing** is enabled. This field is read-only. 

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Lock prices or use current pricing

1. In the site map, select **Orders** or **Invoices**.

2. Open the order or invoice you want.

3. To lock prices, on the command bar, select the More Commands icon ![More Commands icon.](media/more-commands-icon.png "More Commands icon"), and then select **Lock Pricing**.
 
     -OR-
    
    To enable current pricing, on the command bar, select the More Commands icon ![More Commands icon.](media/more-commands-icon.png "More Commands icon"), and then select **Use Current Pricing**.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Create or edit orders](create-edit-order-sales.md)  
[Create or edit invoices](create-edit-invoice-sales.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
