---

title: Review invocing backlog on projects and project contracts
description: This topic provides information about how to review time, expenses, and product backlog, and mark them as ready for invoicing in Dynamics 365 for Project Service Auotmation (PSA).
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 03/11/2019
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Microsoft Dynamics 365 for Customer Engagement for Project Service 2.x and Microsoft Dynamics 365 for Customer Engagement for Project Service 3.x
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Review invoicing backlog

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

When a transaction is ready to have an invoice created and processed, the transaction should be marked as **Ready to invoice**.  
This topic described the types of transactions that can be created in Dynamics 365 for Project Service Automation (PSA).  

### Review time and material billing backlog
When a time or expense entry is submitted and approved for a project, PSA creates a project actual. If the project and the transaction class combination map to a contract line for a time and material project, the approved entry will result in two actuals:

- Cost actual 
- Unbilled sales actual

Unbilled sales actuals represent the billing backlog and their billing status must be marked as **Ready to Invoice**. When a project invoice is created, unbilled sales actuals that are marked as **Ready to Invoice** are copied over as invoice line details.  
To review the time and material billing backlog, go to **Sales** \> **Billing** \> **Time and Material Billing Backlog**. Select all of the unbilled sales actuals that are ready to invoice and then click **Ready to Invoice**. The billing status of these actuals changes to **Ready to Invoice**.
> ![Review time and material billing backlog](media/TMBacklog.png)

### Review product billing backlog
In PSA, when a project contract has product-based contract lines, these lines are considered for invoicing whenever an invoice is created for the project contract. Any product with contract lines that are marked as **Ready to Invoice** will be copied over to the project invoice as project invoice lines.

To review the product billing backlog, go to **Sales** \> **Billing** \> **Product Billing Backlog**. Select all of the product-based  contract lines that are ready to invoice and then click **Ready to Invoice**. The billing status of these lines changes to **Ready to Invoice**.

> ![Review product billing backlog](media/ProductBacklog.png)

### Review billing milestones on fixed-price contracts 
Each project contract line that has a fixed-price billing method must define contract milestones. These contract milestones must be marked as **Ready to Invoice** to be invoiced. 

To review billing milestones, go to **Sales** \> **Billing** \> **Fixed Price Milestones**. Select the milestones that are ready to be invoiced, and then click **Ready to invoice**. The billing status of these milestones changes to **Ready to Invoice**
.
> ![Review Fixed Price Milestones](media/FPBacklog.png)




