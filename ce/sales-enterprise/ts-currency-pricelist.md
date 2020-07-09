---
title: "Troubleshooting issues related to currency and price list (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with currency and price list in Dynamics 365 Sales."
ms.date: 07/06/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Troubleshooting currency and price lists

This article helps you troubleshoot and resolve issues related to currency and price lists.
<!--I fixed spelling in the anchor text here and in the TOC. Also, to be parallel with the other troubleshooting topics, this H2 needs to state a problem. Suggest wording it something like the below. (I removed "existing" because that's implied by "update.") -->
<a name="update_currency_existing-oqoi"> </a>
## Issue: I can't update the currency or price list for an opportunity, quote, order, or invoice

**Problem**

When I change and try to<!--Suggested.--> save the currency or price list for an existing opportunity, quote, order, or invoice that's already associated with a product record or quote record<!--Suggest using the "product record" phrase throughout, to emphasize that it's parallel with the "quote record" in this topic. See the table for a query about these phrases.-->, an error message is displayed.

**Resolution**

The error occurs because the associated product record or quote record is already linked with a price list that was created by using a different transaction currency.

The following error messages will be displayed, depending on the entity<!--What about order and invoice?  -->:

- For an opportunity, the error message is "The currency cannot be changed because the opportunity has opportunity products, quotes, orders, or invoices associated with it. Remove the associated records and then change the currency."

- For a quote, the error message is "The currency cannot be changed because the quote has quote products associated with it. Remove the associated records and then change the currency."

<!--This paragraph is redundant; suggest deleting.
For example, when you try to change and save the currency of an existing opportunity, which is already associated with an Opportunity Product or a Quote record, an error message is displayed - The currency cannot be changed because the opportunity has opportunity products, quotes, orders, or invoices associated with it. Remove the associated records and then change the currency.
-->

To resolve this issue, you must remove the product records or quote records, change the currency, and then add back the product records or quote records.

You can change the currency and price list for the entities in the following states only.

<!--
| Entity | Status | Change currency value? | Change price list value? |
|--------|--------|------------------------|--------------------------|
| **Opportunity** | Open | Yes, but only if there are no associated Opportunity Product, Order, Quote, or Invoice records. | Yes, but this can cause an error with the Opportunity record if the associated Opportunity Product records aren't part of the selected price list. |
|| Won | No	| No |
|| Lost | No | No |
| **Quote** | Draft | Yes, but only if there are no associated Quote Product records. | Yes, but this can cause an error with the Quote record if the associated Quote Product records aren't part of the selected price list. |
|| Active | No | No |
|| Won | No	| No |
|| Close | No | No |
| **Order**	| Active | No | Yes, but this can cause an error with the Order record if the associated Order Products aren't part of the selected price list. |
|| Submitted | No | No |
|| Cancelled | No | No |
|| Fulfilled | No | No |
|| Invoiced | No | No |
| **Invoice** | Active | Yes, but only if there are no associated Quote Product records. | Yes, but this can cause an error with the Order record if the associated Order product(s) are not part of the selected Price List. |
|| Paid |No | No |
|| Cancelled |No | No |
-->
<!--note from editor: You don't really want to have blank cells in a table. The following table redesign takes care of that. What do you think?-->

<table>
<tr><th>Entity</th><th>Status</th><th>Change currency value?</th><th>Change price list value?</th></tr>
<tr><td valign="top" rowspan="3"><b>Opportunity</b></td><td>Open</td><td>Yes, but only if there are no associated Opportunity Product, Order, Quote, or Invoice records.</td><td>Yes, but this can cause an error with the Opportunity record if the associated Opportunity Product records aren't part of the selected price list.</td></tr>
<tr><td>Won</td><td>No</td><td>No</td></tr>
<tr><td>Lost</td><td>No</td><td>No</td></tr>
<tr><td valign="top" rowspan="4"><b>Quote</b></td><td>Draft</td><td>Yes, but only if there are no associated Quote Product records. </td><td>Yes, but this can cause an error with the Quote record if the associated Quote Product records<!--Edit okay? I wondered whether this should be parallel between this reference and the previous column?--> aren't part of the selected price list.</td></tr>
<tr><td>Active</td><td>No</td><td>No</td></tr>
<tr><td>Won</td><td>No</td><td>No</td></tr>
<tr><td>Close</td><td>No</td><td>No</td></tr>
<tr><td valign="top" rowspan="5"><b>Order</b></td><td>Active</td><td>No </td><td>Yes, but this can cause an error with the Order record if the associated Order Product records<!--Edit okay?--> aren't part of the selected price list. </td></tr>
<tr><td>Submitted</td><td>No</td><td>No</td></tr>
<tr><td>Cancelled</td><td>No</td><td>No</td></tr>
<tr><td>Fulfilled</td><td>No</td><td>No</td></tr>
<tr><td>Invoiced</td><td>No</td><td>No</td></tr>
<tr><td valign="top" rowspan="3"><b>Invoice</b></td><td>Active</td><td>Yes, but only if there are no associated Quote Product records. </td><td>Yes, but this can cause an error with the Order<!--Should this be "Invoice"?--> record if the associated Order Product records<!--Edit okay?--> aren't part of the selected price list.</td></tr>
<tr><td>Paid</td><td>No</td><td>No</td></tr>
<tr><td>Cancelled</td><td>No</td><td>No</td></tr>
</table>

**To update the currency or price list**

1. Open the opportunity, quote, order, or invoice for which you want to change the currency or price list.

2. For an opportunity: go to the **Product Line Items** tab, and then delete<!--Suggest using "delete," since that's the term in the UI.--> the products from the list.

    > [!div class="mx-imgBorder"]
    > ![Delete products from the product list in an opportunity form](media/ts-currency-opportunity-product-list.png "Delete products from the product list in an opportunity form")

    For a quote, order, or invoice: On the **Summary** tab, go to the **PRODUCTS** section, and delete the products from the list.

    > [!div class="mx-imgBorder"]
    > ![Delete products from the product list in quote, order, or invoice forms](media/ts-currency-qoi-product-list.png "Delete products from the product list in quote, order, or invoice forms")

3. On the **Summary** tab, change the currency to the value you want, and then save the form. 

4. Add back the product records or quote<!--This procedure hasn't addressed removing quotes, just products. Is that okay?--> records, and then save the form.

> [!NOTE]
> You can change currency by using the entity attribute. To learn more, see [Transaction Currency (currency) entity](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/developer/transaction-currency-currency-entity).

### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  
