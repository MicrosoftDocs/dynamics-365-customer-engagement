---
title: Overview of case management
description: Learn about case management in Dynamics 365 Customer Service and compare classic case forms with the case canvas.
ms.date: 11/17/2026
ms.topic: overview
ai-usage: ai-assisted
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
searchScope: 
  - D365-App-customerservicehub
  - D365-Entity-incident
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Customer Service
---

# Overview of case management

Use case management to track a customer issue from the first report to resolution. Keep the customer's information, interactions, and the work already completed together so that service representatives can continue helping the customer, even when the case changes owners or channels.

## Choose a case form experience

Dynamics 365 Customer Service offers classic case forms and the case canvas (preview). Choose the experience that fits how your team reviews and works on cases.

Use classic forms for established workflows and Power Apps form customizations. Choose from the default case forms and the enhanced quick and full case forms. Use the case canvas, a record page in Copilot Service workspace, to review case context and a suggested follow-up before taking your next step.

| Experience | Business value and when to use it | Enable and customize | Features and representative guidance |
|---|---|---|---|
| Classic case forms, including enhanced forms. | Retain your established form-based workflows and customizations. Enhanced forms support case creation and updates, customer details, related cases, and attachments. | [Enable enhanced case forms](case-enh-config.md) and [add Power Apps components to case forms](case-powerapps-comp.md). | [Work with cases](../use/customer-service-hub-user-guide-create-a-case.md) and [use enhanced case forms](../use/enh-casemgmt-csw.md). |
| Case canvas (preview). | Review the summary, activity history, case information, and suggested response to plan your next step, especially when you take over a case. | [Manage canvases in CRM Canvas Designer](../../canvas-designer/manage-canvases.md). | [Explore the case canvas and its workflows](../use/use-case-canvas.md). |

Both experiences provide case information and activity history. The case canvas emphasizes reviewing that context alongside a suggested follow-up. Check the workflows your team needs before choosing the canvas; the two experiences don't necessarily expose the same actions.

Maintain classic-form customizations and canvas customizations separately. Before rolling out the case canvas, review your team's workflows and retain access to classic forms where needed. To configure account and contact insights separately from the Case canvas, learn more in [Set up and configure insights](../../canvas-designer/set-up-configure-insights.md).


## Case management capabilities

Create a case to track a customer-reported issue from intake through investigation and resolution. Use the following components to organize case information, route work to the appropriate representative, and manage support:

* **Cases:** Track a single service incident that requires an answer or resolution. Associate multiple cases with the same customer as needed.

* **Activities:** Record customer interactions, such as phone calls. Associate multiple activities with a case.

* **Entitlements:** Specify the amount of support a customer is entitled to receive, similar to a support contract.

* **Knowledge articles:** Find information in the knowledge base to help resolve cases.

* **Queues:** Organize activities and cases that are waiting to be processed.

* **Copilot-generated case summaries:** Review key case information to understand the issue and resolve it more efficiently. Summaries include information such as the case title, customer, subject, product, priority, case type, and description.

* **Service-level agreements (SLAs):** Define and track service expectations, such as how quickly to respond to a customer after a case is opened.

* **Record creation and update rules:** Apply rules to different activity types to automatically create Dynamics 365 records.

* **Routing rules:** Automatically route cases to a specific queue or user.

* **Business process flows:** Guide representatives through the stages and steps needed to resolve a case.

Track metrics on incoming case types, and use that information to create queues, routing rules, and flows that help your team triage cases efficiently.

## Related information

[Set up record routing](set-up-record-routing.md)  
[Create cases](../use/customer-service-hub-user-guide-create-a-case.md)  
[Automatically create or update records](automatically-create-update-records.md)  
[Use Copilot to resolve cases faster](../use/copilot-use-summary.md)  
