---
title: "Manage opportunities in Dynamics 365 for Sales, Business edition | Microsoft Docs"
description: "Track a deal that you're ready to close by using the opportunity record in Dynamics 365 for Sales, Business edition"
keywords: "Deal; Opportunity; sales transaction"
author: shubhadaj
ms.author: shujoshi
manager: sakudes
applies_to: "Dynamics 365 (online)"
ms.date: 07/15/2017
ms.service: dynamics-365
ms.topic: article
ms.assetid: e203546f-2215-485a-8c52-34e81b90794b
ms.reviewer: 
---
# Manage opportunities in [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)], Business edition

In [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)], an [opportunity](javascript:toggleInline('26866')) is a potential sale, like a lead, but with an opportunity you can forecast revenue, set a potential close date, and factor in a probability for the sale. You must link a new opportunity to an existing account or contact.  

## Create and convert opportunities

You can create a new opportunity, or convert one from a qualified lead without re-entering the data. When you convert a qualified lead to an opportunity, you can access the lead record, which includes activities, from the corresponding opportunity form. The preferred way is to create an opportunity from a lead.

In an opportunity you can track contact information, the salesperson working on the opportunity, the probability of closing the sale, and the projected closing date of the sale.

## Recalculate opportunities

When you add a product to an opportunity, the opportunity's estimated revenue value is calculated based on the price, discounts, taxes, and other pricing modifications for the product.

## Add sales transactions

You can start a sales transaction, such as a quote or invoice, from within the opportunity record. The advantage of starting sales transactions in this manner is that much of the information is automatically entered based on the opportunity data. You can also view any sales transaction records from within the opportunity record to track the overall sales process and expected revenue.

## Create or edit an opportunity

If you’re following the sales process from start to finish, you qualify a lead to turn it into an opportunity. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Develop sales from lead to cash (Sales)](https://www.microsoft.com/en-us/dynamics/crm-customer-center/nurture-sales-from-lead-to-order-sales.aspx)  

1.  Go to **Sales** &gt; **Opportunity**

2.  If you’ve qualified a lead to an opportunity, open the opportunity from the list.

3.  To create a new lead, on the command bar, click **New**.

    In the opportunity form, make sure that your potential customer’s important details are captured. Most of the fields will be automatically populated from the lead record.

-   Topic. Interest of the opportunity, such as specific product details.

-   Contact. The contact associated with this opportunity.

-   Account. The account associated with this opportunity.

-   Purchase timeframe. The timeframe by when the account or contact is likely to purchase.

-   Budget Amount.

-   Probability. Indicates the likelihood of a sale occurring.

-   Purchase Process. Indicates whether the purchase process involves and individual or a committee.

-   Est. Close Date. An estimated date by which the opportunity is expected to close.

-   Est. Revenue. Opportunities with products added to them have their estimated revenue value calculated based on the base price, volume discounts, manual discounts, taxes, and other pricing modifications. When opportunities are saved, [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] recalculates the estimated revenue value based on any changes to the products or product quantities associated with the opportunity.

1.  In the **Stakeholders** section, click the “+” sign to add a stakeholder (key contact at the account). A stakeholder is a person at the account who will be involved in decision-making.

    In the box that appears, type a name, or click the Lookup icon to see a list of suggestions. When you have entered the desired name, press the Enter key.

2.  Repeat this step in the **Sales Team** section to add a member of the sales team (from your organization).

3.  To save your changes, on the command bar, **Save**.

4.  Add products to your opportunity. For more information, see the section

5.  Follow the process bar to move the opportunity to the next stage. In the **Develop Opportunity** stage, enter data for these fields:

- **Customer Need**. Enter what interests the opportunity, such as specific product requirements.

- **Proposed Solution**. Enter the plan for what your organization can offer the account, such as product details.

- **Identify Sales** **Team**. Select the check box to indicate that you’ve included information about who in your organization will be involved in pursuing the opportunity.

- **Develop Proposal**. Select the check box to indicate you’ve included notes on how the account will be approached (optional).

 ![Develop Opportunity stage in the process bar](media/develop-opportunity-stage.png "Develop Opportunity stage in the process bar")  

1.  In the **Develop Opportunity** stage, click **Next**.

    The next step is to create and send a quote to your customer. More information. Create and send a quote to your customer.

## Add products to your opportunity

To add products to the opportunity, click the **Product Line Items** tab.

1.  In the list of opportunities, open the opportunity for which you want to add products.

2.  Go to the **Product Line Items** tab.

3.  In the Product Line Items grid, on the command bar, click **Add New**.

4.  In the **Quick Create** form, do the following, and click Save:

    1. **Select Product**. Toggle the field to indicate whether you want to add an existing product or create a new one.

        To use an existing product, click the **Lookup** button ![Icon for lookup](media/lookup-icon.png "Icon for lookup")to search for and add a product.  

        To create a write-in product, click Write-In, and then type the name of the product.

    2. **Pricing.** Select the pricing option. By default, this uses the price that is listed in the product catalog. To override the price, click Override Price. When you override the price, you can specify a price that you want to charge for each unit of the product.

    3. **Quantity.** Enter the quantity of the product or service that will be included.

    4. **Manual Discount.** If you want, you can enter a discount to the product.

    5. **Tax. If required,** enter the appropriate tax amount.

> The right side of the page shows the total amount and discount based on the number of products added to the opportunity.

1.  If you want the pricing to be automatically calculated based on the products and quantities added, toggle the **Revenue** field to **System Calculated**. If not, toggle it to **User Provided**.

## Recalculate an opportunity

To change the estimated revenue value of an opportunity based on any changes to the associated products or product quantities, recalculate the opportunity.

1.  In the list of opportunities, open the opportunity for which you want to recalculate the estimated revenue.

2.  Go to the **Product Line Items** tab, and modify the list of products associated with the opportunity.

3.  In the right section, verify that the Revenue field is set to **System Calculated**.

4.  Click **Save**.

5.  On the command bar, click **Recalculate Opportunity**.

6.  Click **Save** or **Save and Close**.

## Close an opportunity

Whether you win a sale or close an opportunity, you probably want to [close](javascript:toggleInline('25769')) it.  You will have the option to reopen the opportunity later if it becomes a viable sale.  

1.  In the list of opportunities, open the opportunity you want to close.

2.  On the command bar, click **Close as Won** or **Close as Lost**.

3.  Enter the details in the dialog box, and click **OK**.

