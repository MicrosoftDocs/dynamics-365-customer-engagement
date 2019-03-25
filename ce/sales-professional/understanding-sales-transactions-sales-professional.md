Sales transactions in Dynamics 365 for Sales Professional
=========================================================

In Dynamics 365 for Sales Professional, a sale typically starts with a draft
quote. When the quote is ready, it is activated and sent to the customer for
revisions before it is accepted, and then when you’re shipping the products
offered in the quote, an invoice is generated from the quote.

Quotes and invoices in the Sales app are the same item in different states of
transition. You can use tools and templates to create and print quotes and
invoices.

You can start a sales transaction, such as a quote or invoice, from within the
opportunity record. The advantage of starting sales transactions in this manner
is that much of the information is automatically entered based on the
opportunity data. You can also view any sales transaction records from within
the opportunity record to track the overall sales process and expected revenue.

Understanding Quote Stages
--------------------------

When you create a new quote, it is automatically set to Draft, and the revision
ID is set to 0.

Before a quote it sent to a customer, it must be set Active. Activating a quote
makes it read-only so your versions matches the customer's version. If you
revise it, the revision ID will increase by one.

When you close a quote, you have three choices: Lost, Canceled, or Revised. If
you revise it, a new quote is created, set to Draft status, and you can start
over. If you do not revise it, the quote is closed.

Differences between Current Pricing and Prices Locked in invoices
-----------------------------------------------------------------

Dynamics 365 for Sales has two kinds of pricing behavior on invoices: **Use
Current Pricing** and **Prices Locked**.

The **Use Current Pricing** comes directly from the product catalog; If you
change the price of a product there, then it will change in all open invoices
that include the product.

**Prices Locked** locks the price for a product in an open invoice. Even if the
price changes in the product catalog, that invoice will remain at the agreed
price.

### See Also

Create and manage quotes in Dynamics 365 for Sales Professional  
Create and manage invoices in Dynamics 365 for Sales Professional  
Overview of Dynamics 365 for Sales Professional
