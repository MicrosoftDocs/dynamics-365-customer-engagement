---
title: "Create or edit an opportunity in Dynamics 365 for Sales Professional | MicrosoftDocs"
description: "Track a deal that has more probability of turning into a business as an opportunity in Dynamics 365 for Sales Professional."
keywords: ""
ms.date: 04/05/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.x"
ms.assetid: 821221be-8b4d-47e8-88b6-58a664337717
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Create or edit an opportunity in Dynamics 365 for Sales Professional

In Dynamics 365 for Sales Professional, an opportunity is a potential sale, like a lead, but with an opportunity you can forecast revenue, set a potential close date, and factor in a probability for the sale. You can also track contact information and information about the salesperson working on the opportunity.
You must link a new opportunity to an existing account or contact.

If you’re following the sales process from start to finish, you qualify a lead to turn it into an opportunity.

You can create a new opportunity or convert one from a qualified lead without re-entering the data. When you convert a qualified lead to an opportunity, you can access the lead record, which includes activities, from the corresponding opportunity form. The preferred way is to create an opportunity from a lead. More information: [Develop sales from lead to cash](develop-sales-lead-to-cash-sales-professional.md).


To create or edit an opportunity:

1. In the site map, select **Opportunity**.

2. If you’ve qualified a lead to an opportunity, open the opportunity from the list.

    -OR-

    To create a new lead, on the command bar, select **New**.

 3. In the opportunity form, make sure that your potential customer’s important details are captured. Most of the fields will be automatically populated from the lead record:

    -   **Topic**. Interest in the opportunity, such as specific product details.

    -   **Contact**. The contact associated with this opportunity.

    -   **Account**. The account associated with this opportunity.

    -   **Purchase timeframe**. The timeframe of when the account or contact is likely to purchase.

    -   **Budget Amount**. Indicates the lead's potential available budget.

    -   **Probability**. Indicates the likelihood of a sale occurring.

    -   **Purchase Process**. Indicates whether the purchase process involves an individual or a committee.

    -   **Est. Close Date**. An estimated date by which the opportunity is expected to close.

    -   **Est. Revenue**. Opportunities with products added to them have their estimated revenue value calculated based on the base price, volume discounts, manual discounts, taxes, and other pricing modifications. When opportunities are saved, Dynamics 365 for Sales Professional recalculates the estimated revenue value based on any changes to the products or product quantities associated with the opportunity.

        ![Opportunity form](media/opportunity-form.png "Opportunity form")

4.  In the **Stakeholders** section, select **More Commands** ![More Commands button](media/more-commands-button.png "More Commands button"), and then select **New Connection** to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making.

    In the **Lookup Records** dialog box, enter a name or select the Lookup icon to choose from a list of suggestions. When you've entered the name you want, select **Add**. To create a new contact, select **New**. By default, the contact you add is assigned the Stakeholder role. Select the role corresponding to the contact to choose a different role such as **Decision Maker** or **Technical Buyer**.

5.  In the last pane, select the **Sales team** ![Sales team icon](media/sales-team-icon.png "Sales team icon") icon to open the **Sales team** tab. Select the **More Commands** button ![More Commands button](media/more-commands-button.png "More Commands"), and then select **New Connection** to add a member of the sales team (from your organization).

6.  To save your changes, on the command bar, select **Save**.

7.  Add products to your opportunity. For more information, see [Add products to your opportunity](#add-products-to-your-opportunity).

8.  Follow the process bar to move the opportunity to the next stage. In the **Develop Opportunity** stage, enter data for these fields:

    -   **Customer Need**. Enter what interests the opportunity, such as specific product requirements.

    -   **Proposed Solution**. Enter the plan for what your organization can offer the account, such as product details.

    -   **Identify Sales Team**. Select the check box to indicate that you’ve included information about who in your organization will be involved in pursuing the opportunity.

    -   **Develop Proposal**. Select the check box to indicate that you’ve included notes on how the account will be approached (optional).

        ![Develop Opportunity stage in the process bar](media/develop-opportunity-stage-bpf.png "Develop Opportunity stage in the process bar")

9.  In the **Develop Opportunity** stage, select **Next**.

    The next step is to create and send a quote to your customer. 

## Add products to your opportunity

1.  In the list of opportunities, open the opportunity for which you want to add products.

2.  Go to the **Product Line Items** tab.

3.  In the Product Line Items grid, on the command bar, select **Add New**.

4.  In the **Quick Create** form, do the following, and select **Save**:

    -  **Select product**. This field is a toggle that indicates whether you want to add an existing product or create a new one.

        To use an existing product, select the **Lookup** button![Icon for lookup](media/lookup-icon.png) to search for and add a product.

        To create a write-in product, select **Write-In**, and then type the name of the product.

    -  **Select pricing.** Select the pricing option. By default, this uses the price that is listed in the product catalog. To override the price, select **Override Price**. When you override the price, you can specify a price that you want to charge for each unit of the product.

    -  **Enter quantity.** Enter the quantity of the product or service that will be included.

    -  **Enter manual discount.** If you want, you can enter a discount to the
        product.

    -  **Enter tax.** If required, enter the appropriate tax amount.

    The right side of the page shows the total amount and discount based on the number of products added to the opportunity.

5.  If you want the pricing to be automatically calculated based on the products and quantities added, switch the **Revenue** field to **System Calculated**. If not, switch it to **User Provided**.

## Recalculate an opportunity

When you add a product to an opportunity, the opportunity's estimated revenue value is calculated based on the price, discounts, taxes, and other pricing modifications for the product.

To change the estimated revenue value of an opportunity based on any changes to the associated products or product quantities, recalculate the opportunity.

1.  In the list of opportunities, open the opportunity for which you want to recalculate the estimated revenue.

2.  Go to the **Product Line Items** tab, and modify the list of products
    associated with the opportunity.

3.  In the right section, verify that the Revenue field is set to **System Calculated**.

4.  Select **Save**.

5.  On the command bar, select **Recalculate Opportunity**.

6.  Select **Save** or **Save and Close**.

## Close an opportunity

Whether you win a sale or close an opportunity, you probably want to close it. You will have the option to reopen the opportunity later if it becomes a viable sale.

1.  In the list of opportunities, open the opportunity you want to close.

2.  On the command bar, select **Close as Won** or **Close as Lost**.

    ![Close Opportunity dialog box](media/close-opportunity-dialog-box.png "Close Opportunity dialog box")

3.  Enter the details in the dialog box, and select **OK**.

### See also

[Develop sales from lead to cash in Dynamics 365 for Sales Professional](develop-sales-lead-to-cash-sales-professional.md)  
[Overview of Dynamics 365 for Sales Professional](sales-professional-overview.md)  
[Manage tasks, appointments, email, or phone calls in Dynamics 365 for Sales Professional](manage-activities.md)
