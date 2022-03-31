---
title: "Move the opportunity through different stages | MicrosoftDocs"
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
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Move the opportunity through different stages

An opportunity goes through different stages (aka pipeline phase) as you make progress and get more details about the opportunity. Each stage defines the information you should've collected about the opportunity to methodically progress and increase your chances of winning the deal. 

> [!IMPORTANT]
>- The opportunity stage is stored in the **Pipeline Phase** field and is used in sales charts and dashboards. For example, the funnel chart displays the opportunities in different stages.  
>- If your organization has multiple business process flows for the opportunity entity, the **Pipeline Phase** field stores the last stage change information done on the opportunity record through any business process flow. If you're using multiple business process flows on opportunity, exercise your discretion while using this field.

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson and above <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Move the opportunity to Qualify stage

1. Select **Qualify** in the process bar when you've identified the basic details about the customer: 
    - **Identify Contact**: Select the contact who will be working on the opportunity from the customer's end. 
    
    - **Identify Account**: Select the customer for the opportunity.
    - **Purchase Timeframe**: Select the purchase timeframe of the customer. 
    - **Estimated Budget**: Enter the estimated budget of the customer. This is different from the estimated revenue. Depending on the budget the customer has, you can decide the products that best fits the budget.
    - **Purchase Process**: Select whether the purchase decision is made by an individual or committee.
    - **Identify Decision Maker**: Mark as complete if you've identified the decision maker. More information: [Add stakeholders and decision makers for the opportunity](add-stakeholder.md#add-stakeholders-and-decision-makers-for-the-opportunity)
1. Specify the details and select **Next Stage**. 
    The opportunity moves to the Develop stage of the process.

## Move the opportunity to Develop stage

1. Select **Develop** in the process bar when you've worked out the following details:

    - **Customer Need**: Enter what interests the customer, such as specific product requirements.
    
    - **Proposed Solution**: Enter the plan for what your organization can offer the account, such as product details.
    
    - **Identify Stakeholders**: Select **mark complete** if you've added contacts in the Stakeholders. These are contacts from the customer's end who will be involved in pursuing the opportunity. More information: [Add stakeholders and decision makers for the opportunity](add-stakeholder.md#add-stakeholders-and-decision-makers-for-the-opportunity)
    
    - **Identify Competitors**: Select **mark complete** if you've added the competitor information. More information: [Add competitors for the opportunity](add-stakeholder.md#add-competitors-for-the-opportunity)

2. Specify the details and select Next stage

## Move the opportunity to Propose stage

1. In the **Propose** stage, select **mark complete** to display a check mark next to each of the following steps that you've completed:
    
    - **Identify Sales Team**: Select **mark complete** if you've added the sales team members. More information: [Add sales team for the opportunity](add-stakeholder.md#add-sales-team-for-the-opportunity)
    
    - **Develop Proposal**: Select **mark complete** if you've created a proposal for the opportunity. This optional step indicates that you've included notes about how the account will be approached. You can add the proposal as attachment to the opportunity in the **Files** tab.   
    
    - **Complete Internal Review**: Select **mark complete** if you've completed an internal review of the proposal. 
    
    - **Present Proposal**: Select **mark complete** if you've presented the proposal to the stakeholders. 

2. Specify the details and select **Next stage**.

The next step is to create a quote and send it to your customer. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create a quote and send it to your customer](../sales-enterprise/create-edit-quote-sales.md)

## Move the opportunity to Close stage

When your quote is accepted by the customer and an order is raised, you can move the opportunity to the Close stage. 

1. In the **Close** stage, select **mark complete** to display a check mark next to each of the following steps that you've completed:

    - **Complete Final Proposal:** Select **mark complete** if you've created a final proposal for the opportunity. You can add the proposal as attachment to the opportunity in the **Files** tab.  
    - Present Final Proposal: Select **mark complete** if you've presented the final proposal to the customer. 
    - **Confirm Decision Date:** Select the date by when you're expecting a decision from customer. 
    - **Send Thank You**: Select **mark complete** if you've sent a thank you note to the customer.
    - File De-brief: Select **mark complete** if you've created a de-brief for the opportunity.

2. Select **Finished** when you're done with all the activities.

