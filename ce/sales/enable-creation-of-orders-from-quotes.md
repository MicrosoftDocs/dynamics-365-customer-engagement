---
title: "Enable creation of orders from quotes | MicrosoftDocs"
description: "Quickly create orders from quotes in Dynamics 365 Sales so the relevant data is populated from the quote."
ms.date: 07/21/2020
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
searchScope: 
  - D365-App-msdynce_salespro
  - D365-Entity-salesorder
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Enable creation of orders from quotes

Quotes have important data about the customers and the products they're interested in. When you enable the creation of orders from quotes, it allows sellers to quickly create an order from a quote so that most of the details in the order are prefilled from the quote.  

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sales Professional Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Enable quote creation

1. Make sure you have a Sales Professional Manager or System Administrator role.

2. In the site map, select **Sales Settings**.

3.  Under **Advanced Settings**, select **Quote Settings**.

4.  To enable creation of orders from quotes, set **Enable automatic quote to order generation** to **Enabled**.

    :::image type="content" source="media/enable-quote-to-order-sp.png" alt-text="A screenshot of Sales Professional Settings to enable automatic creation of quote to order.":::

6.  Select **Save**. 
7.  Open a quote, activate it, and verify if the **Create Order** option is available on the command bar. You can now select **Create Order** to create an order based on the quote. 

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Create an order from a quote](create-edit-order-sales.md#create-an-order-from-a-quote)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
