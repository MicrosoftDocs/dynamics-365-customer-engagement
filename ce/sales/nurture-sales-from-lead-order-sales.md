---
title: Nurture sales from lead to order
description: Use the out-of-the-box sales process to close more deals and improve customer satisfaction.
ms.date: 03/31/2023
ms.topic: overview
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
ms.custom: bap-template
ms.custom: 
  - dyn365-sales
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-opportunity
  - D365-Entity-lead
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Understand the sales process

A sales process includes a set of repeatable steps that sellers follow to engage with a prospective customer from the early stage of awareness to closing a sale. You can achieve more consistent sales interactions by following the sales process as it takes you through each stage, from creating a lead to closing the opportunity and recording the sale. You also end up with a more complete history that you can refer to later, if you plan to work with your customer again in the future or if your customer needs support.

Your sales process begins with a lead—someone who is interested in the products or services you provide. Your leads might be automatically generated or they might come from other sources, such as website opt-in pages, email queries, or business cards that you gather at trade shows.

Also, the specific process stages and terminology used by organizations vary based on factors such as, industry, sales strategies, product offerings, or the types of customers they target. Though the actual processes are different, a typical sales process resembles a flow shown in the following diagram:

> [!div class="mx-imgBorder"]
> ![A typical process of sales](media/sales-process.png "A typical process of sales")

Each stage typically maps to a specific sales record type. For example, during the qualifying stage, sellers are generally working with a lead. A lead represents someone with an interest in what you are selling. The goal of a lead is to qualify and advance it to the next stage in the sales process, such as the develop stage.

Let's look at an example on how this sales processes is used to implement a sales lifecycle solution in an organization. The following image shows what a sales lifecycle might look like from start to end:

:::image type="content" source="media/sales-process-start-end.png" alt-text="A typical process of sales from start to end" lightbox="media/sales-process-start-end.png":::

Your sales process begins with a lead—someone who is interested in the products or services you provide. Your leads might be automatically generated, or they might come from other sources, such as website opt-in pages, email queries, or business cards you gather at trade shows.

1. **Qualify**: Great job! You've got your lead…now what? If your lead isn't already in Dynamics 365 Sales, start by creating your lead in the system.  
    After you've determined that your lead is interested in your solution and has the appropriate purchasing power, qualify your lead. Qualifying a lead in  Dynamics 365 Sales converts it to an opportunity.  
    More information:   
    - [Create or edit a lead](create-edit-lead-sales.md)   
    - [Qualify a lead and convert it to an opportunity](qualify-lead-convert-opportunity-sales.md)
2. **Develop**: The opportunity record is used to develop the details of the deal. Details such as the products and services they are interested in, estimated revenue, and timelines are added to the opportunity.   
    More information: [Create or edit an opportunity](create-edit-opportunity-sales.md)   
3. **Propose**: Now it's time to present your proposal to your potential customer.   
    More information: [Create or edit a quote](create-edit-quote-sales.md)   
4. **Close**: When the customer agrees to the quote, an order is generated. The quote and opportunity associated with the order are closed.  
    More information:
    - [Create or edit an order](../sales-enterprise/create-edit-order-sales.md)    
    - [Close an opportunity as won or lost](../sales-enterprise/close-opportunity-won-lost-sales.md)   
5. **Fulfill**: After the order is fulfilled, an invoice is generated to bill the customer.   
    More information: [Create or edit an invoice](../sales-enterprise/create-edit-invoice-sales.md)  
    
> [!NOTE]
> Your [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] system might look different because it was customized. This walkthrough guides you through the basic sales process, but your organization might offer further training for your system.

### See Also   
[Overview of Sales](../sales-enterprise/user-guide.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
