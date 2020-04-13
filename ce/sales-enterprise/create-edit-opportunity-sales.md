---
title: "Create or edit opportunities (Dynamics 365 Sales) | MicrosoftDocs"
description: "An opportunity is a deal you're ready to win. Create an opportunity record for a lead who's ready to buy."
ms.date: 02/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Create or edit opportunities (Sales and Sales Hub)

An opportunity is a lead who is now almost ready to buy&mdash;in other words, a deal that you're ready to win.  
  
 At this point in the sales process, you're most likely in either the **Develop** or **Propose** stage. [!include[proc-more-information](../includes/proc-more-information.md)] [Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md) 
  
## Create an opportunity (Sales Hub)

If you're following the sales process from start to finish, you *qualify* a lead to turn it into an *opportunity*. [!include[proc-more-information](../includes/proc-more-information.md)] [Qualify a lead and convert it to an opportunity](../sales-enterprise/qualify-lead-convert-opportunity-sales.md)

1. In the site map, select **Opportunities**.

2. If you've qualified a lead to an opportunity, open the opportunity from the list.

    OR
    
    To create a new opportunity, on the command bar, select **+ New**.

    > [!NOTE]
    > If your system administrator has set the Kanban view as the default, you'll see the Kanban view instead of the list view. More information: [Work with opportunities in the kanban view](opportunity-kanban-view.md) 

3. In the opportunity form, make sure that your potential customer's important details are captured. If you've qualified a lead to an opportunity, most of the fields will be automatically populated from the lead record.
 
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
 
   - **Est. Close Date**: An estimated date by which the opportunity is expected to close. 
  
   - **Est. Revenue**: A field calculated for opportunities that have products added to them. Estimated revenue is calculated based on base price, volume discounts, manual discounts, taxes, and other pricing modifications. When opportunities are saved, [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] recalculates the estimated revenue based on any changes to the products or product quantities associated with the opportunity. 
   
       > [!NOTE]
       > Only the products associated with the same price list as the parent opportunity are considered for system-calculated revenue. 
   
4. Select **Save** to enable other sections on the form.

5. In the **Stakeholders** section, select the **More Commands** button ![More Commands button](media/more-button-stakeholders-grid.png "More Commands button"), and then select **+ New Connection** to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making. 

   In the **Lookup Records** dialog box, enter a name or select the Lookup icon to choose from a list of suggestions. When you have entered the name you want, select **Add**. To create a new contact, select **+ New**. By default, the contact you add is assigned the Stakeholder role. Select the role corresponding to the contact to select a different role such as Decision Maker or Technical Buyer. 

6. If other people in your organization are working on this sale, be sure to add them as sales team members. In the **Sales Team** section, select the **More Commands** button ![More Commands button](media/more-button-stakeholders-grid.png "More Commands button"), and then select **+ New Connection** to add a member of the sales team (from your organization).


    > [!NOTE]
    > The "+ New" button on Connection sub-grids are supported only for the out-of-box "Stakeholders" and "Sales Team" views on the Opportunity entity. For any other Connection sub-grid or "Stakeholders" or "Sales Team" sub-grids that are based on custom views, the "+ New" button doesn't appear on the sub-grid. In such case, navigate to the Connection Associated view for the record and use the **Connect** button to create a new connection. 


7. In the **Competitors** section, select **Add Existing Competitor** to add a competitor who's competing with your organization for this opportunity.

8. To save your changes, on the command bar, select **Save**.

9. Add products to your opportunity. [!include[proc-more-information](../includes/proc-more-information.md)] [Add products to an opportunity](add-products-opportunity.md), [Add products to an opportunity using the enhanced experience](add-products-enhanced-experience.md)

10.    Follow the process bar to move the opportunity to the next stage. In the **Develop** stage, enter data for the following fields:
    
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


## Create an opportunity (Sales)

If you're following the sales process from start to finish, you qualify a lead to turn it into an opportunity. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  

If you want to create an opportunity without first creating a lead, do the following:  
  
1. [!INCLUDE[proc_sales_opportunities](../includes/proc-sales-opportunities.md)]  
  
2. Select **New**.  
  
3. In the **Summary** area, enter the company and contact information for the opportunity.  
  
4. In the **Details** area of the **Opportunity** form, enter information about your opportunity's industry and preferred contact method.  
  
5. Add any notes and activities (for example, phone calls or emails) related to this opportunity. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Keep track of notes, tasks, calls, or email with activities](../basics/work-with-activities.md)  
  
6. In the **Stakeholders** section, select the **Add Connection record** button ![Add Connection record button](media/add-connection-record-button.png "Add Connection record button") to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making. 

   In the Lookup box, enter a name or select the Lookup icon to choose from a list of suggestions. To create a new contact, select **+ New**. By default, the contact you add is assigned the Stakeholder role. Select the role corresponding to the contact to select a different role such as Decision Maker or Technical Buyer.   
  
7. If other people in your organization are working on this sale, be sure to add them as sales team members. In the **Sales Team** section, select the **Add Connection record** button ![Add Connection record button](media/add-connection-record-button.png "Add Connection record button"), and then select **+ New Connection** to add a member of the sales team (from your organization).  
  
8. To add competitors, in the **Competitors** area, select **+**.  
  
9. To add products, in the **Products** area, select **+**.  
  
10. To add a quote, in the **Quotes** area, select **+**. [!include[proc-more-information](../includes/proc-more-information.md)] [Create or edit a quote](../sales-enterprise/create-edit-quote-sales.md)  
  
11. Select **Save** in the lower-right corner of the screen. 
  

> [!IMPORTANT]
> The **Pipeline Phase** field of the Opportunity entity has been used in sales charts and dashboards to show the current phase in the sales pipeline for the opportunity. This field is populated by the stage change information on the business process flow for the Opportunity entity.
> Because [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] supports multiple business process flows for the Opportunity entity, the **Pipeline Phase** field will be populated with the last stage change information done on any business process flow on the opportunity record. If you're using multiple business process flows on opportunity, exercise your discretion while using this field. [!include[proc-more-information](../includes/proc-more-information.md)] [Business process flows overview](../customize/business-process-flows-overview.md)

For information on how to resolve the common errors that you may get while you close an opportunity, see the [troubleshooting guide](troubleshooting.md).
  
## Ways to create opportunities  

Need a faster way to enter opportunities? Try one of these:  

-   [Quick create-Enter new records-fast!](../basics/quick-create-enter-data-fast.md)  
  
-   [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)  
  
## Typical next steps  

 ![Right arrow button](../sales-enterprise/media/orange-right-arrow-button.png "Right arrow button") [Create or edit a quote](../sales-enterprise/create-edit-quote-sales.md)  
  
 ![Home button](../sales-enterprise/media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  
  
### See also 

[Add products to an opportunity](add-products-opportunity.md)  
[Add products to an opportunity using the enhanced experience](add-products-enhanced-experience.md)  
[Recalculate an opportunity](recalculate-opportunity.md)  
[Close an opportunity](close-opportunity-won-lost-sales.md)  
[Work with opportunities in the Kanban view](opportunity-kanban-view.md)  
[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  
[Boost sales with Versium Predict](../versium-predict/versium-predict.md)   
[Insights, powered by InsideView](../insights-insideview/insights-powered-by-insideview.md)   
[Print quote, invoice, or other records](print-records.md)