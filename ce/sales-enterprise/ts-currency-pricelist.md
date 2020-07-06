---
title: "Troubleshooting issues related to currecny and price list (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with currecny and price list in Dynamics 365 Sales."
ms.date: 07/06/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Troubleshooting currency and pricelist

This article helps you troubleshoot and resolve issues related to currecny and price list.

<a name="update_currency_exisitng-oqoi"> </a>
## Update currency for an existing opportunity, quote, order, and invoice

**Problem**

When I change and save the currency or price list of an existing opportunity, quote, order, or invoice, which is already associated a product or quote record, an error message is displayed.

**Resolution**

The error occurs due to the associated product or quote record is already linked with a price list which is created with different transaction currency.

The following are the examples of error messages and change depending on the entity:

- For opportunity, the error message is - *The currency cannot be changed because the opportunity has opportunity products, quotes, orders, or invoices associated with it. Remove the associated records and then change the currency*.

- For quote, the error message is – *The currency cannot be changed because the quote has quote products associated with it. Remove the associated records and then change the currency*.

For example, when you try to change and save the currency of an existing opportunity, which is already associated with an Opportunity Product or a Quote record, an error message is displayed - The currency cannot be changed because the opportunity has opportunity products, quotes, orders, or invoices associated with it. Remove the associated records and then change the currency. 

To resolve this issue, you must remove the product or quote records, change the currency, and then add back the product or quote records.

You can change the currency and price list for the entities in the following states only.

| Entity | Status | Change currency value? | Change price list value? |
|--------|--------|------------------------|--------------------------|
| **Opportunity** | Open | Yes, but only if there are no associated Opportunity Product, Order, Quote, or Invoice record. | Yes, but this can cause error with Opportunity record, if the associated Opportunity Product record(s) is not part of the selected Price List. |
|| Won | No	| No |
|| Lost | No | No |
| **Quote** | Draft | Yes, but only if there are no associated Quote Product record. | Yes, but this can cause an error with Quote record, if the associated Quote product(s) are not part of the selected Price List. |
|| Active | No | No |
|| Won | No	| No |
|| Close | No | No |
| **Order**	| Active | No | Yes, but this can cause an error with Order record, if the associated Order product(s) are not part of the selected Price List. |
|| Submitted | No | No |
|| Cancelled | No | No |
|| Fulfilled | No | No |
|| Invoiced | No | No |
| **Invoice** | Active | Yes, but only if there are no associated Quote Product record. | Yes, but this can cause error with Order record, if the associated Order product(s) are not part of the selected Price List. |
|| Paid |No | No |
|| Cancelled |No | No |

Follow these steps:

1. Open the opportunity, quote, order, or invoice for which you want to change the currency or price list.

2. For opportunity, go to the **Product Line Items** tab and remove the products from the list.

    > [!div class="mx-imgBorder"]
    > ![Remove products from the product list in opportunity form](media/ts-currency-opportunity-product-list.png "Remove products from the product list in opportunity form")

    For quote, order, or invoice, in the **Summary** tab, go to the **PRODUCTS** section and remove the products from the list.

    > [!div class="mx-imgBorder"]
    > ![Remove products from the product list in quote, order, or invoice form](media/ts-currency-qoi-product-list.png "Remove products from the product list in quote, order, or invoice form")

3. In the **Summary** tab, change the currency as required and save the form. 

4. Add back the product or quote records and save the form.

>[!NOTE]
>You can change the currency using the entity attribute. To learn more, see [Transaction Currency (currency) entity](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/developer/transaction-currency-currency-entity).

### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  
