---
title: "Create a price list (Dynamics 365 for Project Service Automation) | MicrosoftDocs"
ms.custom:
  - dyn365-projectservice
ms.date: 09/15/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "project-service-automation"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: 199642fd-f706-498f-b8ae-8823d79d6172
caps.latest.revision: 12
ms.author: krbjoran
manager: shellyha
---
# Create a price list (Project Service Automation)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Price lists provide a template your account managers can use for creating quotes and projects, and for establishing the costs of a project. They provide a line item list of roles and expenses, and the price you will charge for each. You can create multiple price lists so that you can maintain separate price structures for different regions you sell your products in or for different sales channels. It’s a good idea to create at least one price list for every currency you plan to bill your customers in.  
  
 To create financial estimates for the work to be delivered, make sure every project has a backing cost and sales price list. Set up a default cost and sales pricelist that applies to all projects created in your organization.  
  
 Price lists rely on roles and expense categories, so before you create a price list, make sure you’ve already configured the roles and expense categories you want to use while creating the price list.  
  
1.  Go to **Project Service > Price Lists**.  
  
2.  Click **New**.  
  
3.  In **Context**, select whether this price list is for **Cost**, **Purchase**, or **Sales**.  
  
4.  In **Name**, enter a name for the price list.  
  
5.  In **Currency**, select the currency you’re going to use for billing or costing.  
  
6.  In **Time Unit**, specify the period of time the price applies to, such as day or hour.  
  
7.  Fill in the **Start Date**, **End Date**, and **Description** as needed.  
  
8.  Click **Save** to create the record so you can continue editing it.  
  
9. To add a role price to the price list, click **+** under **Role prices**.  
  
10. In the **Role Price** pane, fill in the details, and then click **Save**. Continue adding role prices as necessary. When you’re done, click **Save** at the bottom right corner of the screen.  
  
11. To add an expense category price to the price list, click **+** under **Category prices**.  
  
12. In the **Transaction Category Price** pane, fill in the details, and then click **Save**. Continue adding category prices as necessary. When you’re done, click **Save** at the bottom right corner of the screen.  
  
13. To add price list items to the price list, click **+** under **Price List Items**.  
  
14. In the **Price List Item** pane, fill in the details, and then click **Save**. Continue adding price list items as necessary. When you’re done, click **Save** at the bottom right corner of the screen.  
  
15. To add territory relationships to the price list, click **+** under **Territory Relationships**.  
  
16. In the **New Connection** window, fill in the details, and then click **Save**. Continue adding territory relationships as necessary. When you’re done, click **Save** at the bottom right corner of the screen.  
  
### See Also  
 [Configure Project Service Automation](../project-service/configure.md)
