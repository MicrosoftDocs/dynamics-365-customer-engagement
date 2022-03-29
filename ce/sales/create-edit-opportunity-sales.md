---
title: "Create or edit opportunities (Dynamics 365 Sales) | MicrosoftDocs"
description: "An opportunity is a deal you're ready to win. Create an opportunity record for a lead who's ready to buy."
ms.date: 03/29/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-opportunity
  - D365-Entity-lead
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Create or edit opportunities 

Create an opportunity when your lead is almost ready to buy. Use one of the following methods to create an opportunity:

- Convert a qualified lead into an opportunity. In this case,
    - Information from the lead record is copied to the opportunity.
    - The lead and opportunity records are linked. 
- Create a new opportunity from scratch if it didn't originate from a lead.  

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson and above <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Qualify and convert a lead

If the opportunity originated from an existing lead, quality the lead and convert it to an opportunity. More information: [Qualify a lead and convert it to an opportunity](qualify-lead-convert-opportunity-sales.md)

## Create an opportunity

Create an opportunity with the details you have. You can update the opportunity as you progress through the different stages of the opportunity - Qualify, Develop, Propose, and Close.  

<a name="create-sales-hub"></a>

1. In the Sales Hub site map, select **Opportunities**.

2. On the command bar, select **+ New**.

3. In the **Summary** tab, capture important details about the opportunity. The following list describes fields that require explanation:

    - **Topic**: Specify a brief summary of the opportunity. Include details such as the product, quantity, and customer name. A well-written topic helps your stakeholders spot the opportunity by just glancing through the opportunity list.  **Example:** 125 CRM licenses for Contoso inc. 
    
   - **Currency**: Select the currency to use for calculating values in the opportunity.

     > [!NOTE]
     > Your base record and all its line items must use the same currency. For example, if your opportunity has the currency set to U.S Dollars, you must use the same currency for the price list items that you add to the opportunity. You can't change the currency of the base record (in this case, an opportunity), unless you remove all the list items associated with the record.
     > Similarly, all the records created from an opportunity, such as a quote, order or invoice must use the same currency as the opportunity. 

1. Select the pull-down menu at the top-right corner of the opportunity and specify the following details:
    
    :::image type="content" source="media/opportunity-est-values.png" alt-text="A screenshot of the estimated close date field."::: 

    1. If you're not ready to add products to the opportunity yet but want to capture the estimated revenue, specify it in the **Est. Revenue** field. 
        > [!NOTE]
        > When you're ready to add products, you can choose to auto-calculate the revenue based on the products added, price list, discounts and so on. 
    1. Specify the estimated close date in the **Est. Close Date** field.
    1. To change the owner of the opportunity, update the **Owner** field. 
   
4. Select **Save**.

## Add stakeholders and decision makers for the opportunity

A stakeholder can be a decision maker or any person who will be working with you on the opportunity from the customer's end. Other stakeholder categories include Champion, End User, Economic Buyer, Influencer, and Technical Buyer.

1. Open the opportunity.
1. In the Summary tab, scroll down to the **Stakeholders** section.
    > [!NOTE]
    > If you'd selected a user in the Contact field, that user is automatically added to the **Stakeholders** section.
2. Select **+ New Connection** and then select the stakeholder's record from the contacts list.
    The user is added as a stakeholder by default. 
3. To convert a stakeholder to any other stakeholder category (for example, decision maker), select the stakeholder record and then select **Edit**.
1. In the **As this role** field, remove Stakeholder and select a role that best fits the contact. For example, select Decision Maker if the contact is a decision maker for the opportunity. 
1. Go back to the opportunity and verify that the stakeholder's role is updated. 


## Add sales team for the opportunity

If multiple users and teams from your organization are working on an opportunity, add them as the Sales team for the opportunity.

1. Open the opportunity.
1. In the Summary tab, scroll down to the **Sales Team** section.
1. Select **+ New Connection** and then add users or teams in your organization who are involved in the opportunity. 

    > [!NOTE]
    > The **+ New connection** button on Connection sub-grids are supported only for the out-of-box "Stakeholders" and "Sales Team" views on the Opportunity entity. For any other Connection sub-grid or "Stakeholders" or "Sales Team" sub-grids that are based on custom views, the "+ New" button doesn't appear on the sub-grid. In such case, navigate to the Connection Associated view for the record and use the **Connect** button to create a new connection. More information: [How are stakeholders and sales team members tracked for opportunities?](stakeholders-sales-team-members.md)

## Add competitors for the opportunity

Add the organizations that are competing with you for the opportunity as competitors for the opportunity. 

1. Open the opportunity.
1. In the Summary tab, scroll down to the **Competitors** section.
1. Select **Add Existing Competitor** to add a competitor.

## Add products to the opportunity

After you understand the customer's need, identify the products from your catalog that best fits the need. You can then add those products to the opportunity. More information:
    - [Add products to an opportunity by using the enhanced experience](add-products-enhanced-experience.md)
    - [Add products to an opportunity](add-products-opportunity.md)


## Move the opportunity through different stages

An opportunity goes through different stages as you make progress and get more details about the opportunity. Each stage defines the information you should've collected about the opportunity to methodically progress and increase your chances of winning the deal. 

- [Move the opportunity to Qualify stage](#move-the-opportunity-to-qualify-stage)
- [Move the opportunity to Develop stage](#move-the-opportunity-to-develop-stage)
- [Move the opportunity to Propose stage](#move-the-opportunity-to-propose-stage)

> [!NOTE]
> Information in this section refers to the out-of-the-box business process for opportunities. If your organization has defined different stages and information to collect at each stage, talk to your administrator for more information.  

### Move the opportunity to Qualify stage

1. Select **Qualify** in the process bar when you've identified the basic details about the customer: 
    - **Identify Contact**: Select the contact who will be working on the opportunity from the customer's end. 
    - **Identify Account**: Select the customer for the opportunity.
    - **Purchase Timeframe**: Select the purchase timeframe of the customer. 
    - **Estimated Budget**: Enter the estimated budget of the customer.
    - **Purchase Process**: Select whether the purchase decision is made by an individual or committee.
    - **Identify Decision Maker**: Mark as complete if you've identified the decision maker.
1. Specify the details and select **Next Stage**. 
    The opportunity moves to the Develop stage of the process.

### Move the opportunity to Develop stage

1. Select **Develop** in the process bar when you've worked out the following details:

    - **Customer Need**: Enter what interests the customer, such as specific product requirements.
    
    - **Proposed Solution**: Enter the plan for what your organization can offer the account, such as product details.
    
    - **Identify Stakeholders**: Select **mark complete** if you've added contacts in the Stakeholders table in the Summary tab. These are contacts from the customer's end who will be involved in pursuing the opportunity.
    
    - **Identify Competitors**: Select **mark complete** if you've added the competitor information in the Competitors table in the Summary tab. 

2. Specify the details and select Next stage

### Move the opportunity to Propose stage

11. In the **Propose** stage, select **mark complete** to display a check mark next to each of the following steps that you've completed:
    
    - **Identify Sales Team**: Select **mark complete** if you've added the sales team members in the Sales Team table in the Summary tab. 
    
    - **Develop Proposal**: Select **mark complete** if you've created a proposal for the opportunity. This optional step indicates that you've included notes about how the account will be approached.  
    
    - **Complete Internal Review**: Select **mark complete** if you've completed an internal review of the proposal. 
    
    - **Present Proposal**: Select **mark complete** if you've presented the proposal to the stakeholders. 

2. Specify the details and select **Next stage**.

The next step is to create a quote and send it to your customer. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create a quote and send it to your customer](../sales-enterprise/create-edit-quote-sales.md)


> [!IMPORTANT]
> The **Pipeline Phase** field of the Opportunity entity has been used in sales charts and dashboards to show the current phase in the sales pipeline for the opportunity. This field is populated by the stage change information on the business process flow for the Opportunity entity.
> Because [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] supports multiple business process flows for the Opportunity entity, the **Pipeline Phase** field will be populated with the last stage change information done on any business process flow on the opportunity record. If you're using multiple business process flows on opportunity, exercise your discretion while using this field. [!include[proc-more-information](../includes/proc-more-information.md)] [Business process flows overview](/power-automate/business-process-flows-overview)


> [!TIP]
> - To analyze your data and convert it into actionable items that help you drive more sales, you can export it to Microsoft Excel. More information: [Export data to Excel](/powerapps/user/export-data-excel)
> - For information on how to resolve the common errors that you might get while you close an opportunity, see [Troubleshooting the Opportunity entity](ts-opportunities.md).
  
  
## Typical next steps  

 ![Right arrow button](media/orange-right-arrow-button.png "Right arrow button") [Create or edit a quote](create-edit-quote-sales.md)  
  
 ![Home button](media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](nurture-sales-from-lead-order-sales.md)  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
  
### See also 

[Import opportunity records](/powerapps/user/import-data)
[Create an opportunity by using the Quick create option on the command bar](/powerapps/user/create-a-record)
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
