---

title: Review invocing backlog on Projects and / or Project Contracts
description: Process description of how to review time, expense, product backlog and mark them as ready for invoicing 
author: Rupa Mantravadi
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 2/25/2018
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

In the latest version PSA, transactions that need to invoiced should be marked as "Ready to invoice" before invoicing can pick them up and create an invoice.  

Here’s a description of this process for the differnt types of transactions that can be created in Project Service application.  
### Review time and material billing backlog
Whenever a time or expense entry submitted for a project is approved, Project Service creates "project actuals". Project Actuals are entries in the Actuals entity. Each time or expense entry for a project will always result in at least one cost actual. If the project and the transaction class combination maps to a time and material project contract line, the approved time or expense entry will result in 2 actuals:

a cost actual and

an unbilled sales actual.



These unbilled sales actuals must then be marked as "Ready to invoice" i.e thier status must be set to "Ready to invoice". When a project invoice is created, the Unbilled Sales actuals that are marked as "Ready to invoice" are copied over as invoice line details.  
In order to review your Time and Material invoice backlog and mark unbilled sales actuals as "ready to invoice", navigate to Sales->Billing -> Time and Material Billing backlog. Select all the unbilled sales actuals that are ready to invoice and then click the ribbon action "Ready to invoice". The billing status of these actuals changes to "Ready to invoice".

### Review product billing backlog
When a project contract in Project service has a product-based contract line, these lines are considered for invoicing whenever an invoice is created for that project contract. Any product - based contract line that is marked as "Ready to invoice" will be copied over to the Project invoice as Project Invoice lines.

### Review billing milestones on fixed price contracts 
This method books the resource for a percentage of capacity for the specified from and to dates. For example, if a resource's calendar is set to work 8 hours per day, 5 days a week, setting a start and end date that covers 5 working days and at 50% capacity would book the resource for 20 hours. The individual bookings per day are spread equally across the period, for example 4 hours per day in this example. The booking is done without regard to the resource’s remaining capacity. If the resource is already booked during that period on other projects, the 20 hours is booked as additional hours, potentially leading to overbookings.

## Creating Project Invoices

### Manual
Project Invoices can be created one by one for each Project Contract or in bulk from the Project Contracts list page.
For bulk creation, from the Project Contracts list page, you can select one or more project contracts. Then click on "Create Invoice Select all the project contracts for which you need to create an invoice.
There is a warning message indicating that there could be a delay in creating invoices and the process. Click ok on the warning message. Invoice creation proceeds in the background and picks up all transactions that are in the status "ready to invoice" for each project contract. This includes time, expense, milestones and product-based contract lines.  Navigate to Sales->Billing->Invoices to see the invoices that were created. There will be one invoice created for each project contract
For creating invoices one by one for each project contract, navigate to the project contract list page, open a project contract and click on "Create invoice". Invoice creation proceeds in the background and picks up all transactions that are in the status "ready to invoice" for the specific project contract. This includes time, expense, milestones and product-based contract lines. 

### Automatedcreating a project invoice  

