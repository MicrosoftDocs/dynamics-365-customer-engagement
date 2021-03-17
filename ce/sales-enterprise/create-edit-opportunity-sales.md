---
title: "Create or edit opportunities (Dynamics 365 Sales) | MicrosoftDocs"
description: "An opportunity is a deal you're ready to win. Create an opportunity record for a lead who's ready to buy."
ms.date: 02/10/2021
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-opportunity
  - D365-Entity-lead
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Create or edit opportunities (Sales Hub)

An opportunity is a lead who is now almost ready to buy&mdash;in other words, a deal that you're ready to win. 

With an opportunity, you can forecast sales revenue, set a potential close date, and factor in a probability for the sale to occur. 

When you create an opportunity, you must specify an existing account or contact record. When you add a price list to an opportunity, it helps in automatically calculating pricing of the proposed products that the opportunity is interested in purchasing.

At this point in the sales process, you're most likely in either the **Develop** or **Propose** stage. More information: [Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md) 

## Ways to create opportunities

You can create a new opportunity that didn't originate from a lead, or you can convert qualified leads to opportunities without reentering the data, and then you can track opportunities through the sales cycle.
When you convert a qualified lead to an account, contact, or opportunity, you can access the lead record, which
includes activities and notes, from the corresponding opportunity form. You can also access the lead information if you create a new opportunity and link it to a lead record. You can't convert an opportunity to a lead; you can only close opportunities.

Here are the different ways in which you can create an opportunity:

- Qualify or convert a lead. More information: [Qualify a lead and convert it to an opportunity](../sales-enterprise/qualify-lead-convert-opportunity-sales.md)
- Import opportunity records. More information: [Import data](/powerapps/user/import-data)
- Create an opportunity by using the Quick create option on the command bar. More information: [Create a new record](/powerapps/user/create-a-record)
- Create an opportunity from the Opportunities list. More information: [Create an opportunity](#create-sales-hub)


<a name="create-sales-hub"></a>

1. In the site map, select **Opportunities**.

2. If you've qualified a lead to an opportunity, open the opportunity from the list.

    OR
    
    To create a new opportunity, on the command bar, select **+ New**.

    > [!NOTE]
    > If your system administrator has set the Kanban view as the default, you'll see the Kanban view instead of the list view. More information: [Work with opportunities in the kanban view](opportunity-kanban-view.md) 

3. In the opportunity form, make sure that your potential customer's important details are captured. If you've qualified a lead to an opportunity, most of the fields will be automatically populated from the lead record.

   - **Est. Close Date**: An estimated date by which the opportunity is expected to close. 
  
   - **Est. Revenue**: A field calculated for opportunities that have products added to them. Estimated revenue is calculated based on base price, volume discounts, manual discounts, taxes, and other pricing modifications. When opportunities are saved, [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] recalculates the estimated revenue based on any changes to the products or product quantities associated with the opportunity. 
   
       > [!NOTE]
       > Only the products associated with the same price list as the parent opportunity are considered for system-calculated revenue. 

   - **Status**: The status the opportunity is in. 

   - **Owner**: Indicates the owner of the opportunity. You can assign the opportunity to another user or team. To change the owner, you can select a different user or team in this field or use the **Assign** button on the command bar to assign it to another user or team. More information: [Assign or share records](/powerapps/user/assign-or-share-records)

   - **Topic**: What the customer is interested in that created the opportunity, such as specific product details.
 
   - **Contact**: The contact associated with this opportunity. The contact that you select here is added as a stakeholder for this opportunity. For more information on stakeholders, see Step 5.  
 
   - **Account**: The account associated with this opportunity.

   - **Currency**: Choose the currency for the opportunity. This is the currency the opportunity amount is calculated in.

     > [!NOTE]
     > 
     > Your base record and all its line items must use the same currency. For example, if your opportunity has the currency set to U.S Dollars, you must use the same currency for the price list items that you add to the opportunity. You can't change the currency of the base record (in this case, an opportunity), unless you remove all the list items associated with the record.
     > Similarly, all the records created from an opportunity, such as a quote, order or invoice must use the same currency as the opportunity.

   - **Purchase Timeframe**: The timeframe by when the account or contact is likely to make the purchase.
 
   - **Budget Amount**: Enter a value to indicate the lead's potential available budget. 
 
   - **Purchase Process**: Whether the purchase process involves an individual or a committee.

   
4. Select **Save** to enable other sections on the form.

5. In the **Stakeholders** section, select the **More Commands** button ![More Commands button](media/more-button-stakeholders-grid.png "More Commands button"), and then select **+ New Connection** to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making.

   In the **Lookup Records** dialog box, enter a name or select the Lookup icon to choose from a list of suggestions. When you have entered the name you want, select **Add**. To create a new contact, select **+ New**. By default, the contact you add is assigned the Stakeholder role. Select the role corresponding to the contact to select a different role such as Decision Maker or Technical Buyer. 

6. If other people in your organization are working on this sale, be sure to add them as sales team members. In the **Sales Team** section, select the **More Commands** button ![More Commands button](media/more-button-stakeholders-grid.png "More Commands button"), and then select **+ New Connection** to add a member of the sales team (from your organization). 


    > [!NOTE]
    > The "+ New" button on Connection sub-grids are supported only for the out-of-box "Stakeholders" and "Sales Team" views on the Opportunity entity. For any other Connection sub-grid or "Stakeholders" or "Sales Team" sub-grids that are based on custom views, the "+ New" button doesn't appear on the sub-grid. In such case, navigate to the Connection Associated view for the record and use the **Connect** button to create a new connection. More information: [How are stakeholders and sales team members tracked for opportunities?](stakeholders-sales-team-members.md)


7. In the **Competitors** section, select **Add Existing Competitor** to add a competitor who's competing with your organization for this opportunity.

8. To save your changes, on the command bar, select **Save**.

9. Add products to your opportunity. [!include[proc-more-information](../includes/proc-more-information.md)] [Add products to an opportunity](add-products-opportunity.md), [Add products to an opportunity using the enhanced experience](add-products-enhanced-experience.md)

10. Follow the process bar to move the opportunity to the next stage. In the **Develop** stage, enter data for the following fields:

    - **Customer Need**: Enter what interests the customer, such as specific product requirements.
    
    - **Proposed Solution**: Enter the plan for what your organization can offer the account, such as product details.
    
    - **Identify Stakeholders**: Select **mark complete** to indicate that you've included information about who will be involved in pursuing the opportunity.
    
    - **Identify Competitors**: Select **mark complete** to indicate that you've included information about competitors.

11. In the **Propose** stage, select **mark complete** to display a check mark next to each of the following steps that you've completed:
    
    - **Identify Sales Team**  
    
    - **Develop Proposal** (This optional step indicates that you've included notes about how the account will be approached.)  
    
    - **Complete Internal Review**  
    
    - **Present Proposal**  

The next step is to create a quote and send it to your customer. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create a quote and send it to your customer](../sales-enterprise/create-edit-quote-sales.md)


> [!IMPORTANT]
> The **Pipeline Phase** field of the Opportunity entity has been used in sales charts and dashboards to show the current phase in the sales pipeline for the opportunity. This field is populated by the stage change information on the business process flow for the Opportunity entity.
> Because [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] supports multiple business process flows for the Opportunity entity, the **Pipeline Phase** field will be populated with the last stage change information done on any business process flow on the opportunity record. If you're using multiple business process flows on opportunity, exercise your discretion while using this field. [!include[proc-more-information](../includes/proc-more-information.md)] [Business process flows overview](../customize/business-process-flows-overview.md)


> [!TIP]
> - To analyze your data and convert it into actionable items that help you drive more sales, you can export it to Microsoft Excel. More information: [Export data to Excel](/powerapps/user/export-data-excel)
> - For information on how to resolve the common errors that you might get while you close an opportunity, see [Troubleshooting the Opportunity entity](ts-opportunities.md).
  
  
## Typical next steps  

 ![Right arrow button](../sales-enterprise/media/orange-right-arrow-button.png "Right arrow button") [Create or edit a quote](../sales-enterprise/create-edit-quote-sales.md)  
  
 ![Home button](../sales-enterprise/media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  
  
### See also 

[Add products to an opportunity](add-products-opportunity.md)  
[Add products to an opportunity using the enhanced experience](add-products-enhanced-experience.md)  
[Recalculate an opportunity](recalculate-opportunity.md)  
[Close an opportunity](close-opportunity-won-lost-sales.md)  
[Work with opportunities in the Kanban view](opportunity-kanban-view.md)  
[Troubleshooting the Opportunity entity](ts-opportunities.md)  
[Boost sales with Versium Predict](../versium-predict/versium-predict.md)   
[Insights, powered by InsideView](../insights-insideview/insights-powered-by-insideview.md)   
[Print quote, invoice, or other records](print-records.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]