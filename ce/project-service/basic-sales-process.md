---
title: Sales processes 
description: This topic provides information about the basic sales processes for Project Service. 
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 12/26/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Sales processes

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

The sales processes that are used in a project-based organization differ from those that are used in a product-based organization. This is because the sales cycles for project organizations are longer and require customized estimation techniques to analyze and create quotes for each deal. Project Service Automation (PSA) uses some of the same functionality that is used in the sales process for Dynamics 365 for Sales. This functionality includes:

- Tracking the sales process with a lead entity.
- Tracking qalifying leads as opportunities. The sales process can also start with opportunity.
- Accessing all related artifacts for an opportunity, including the sales team, stakeholders, probability, rating, sales stages, and business processes.
- Creating multiple quotes for an opportunity. 
- Marking a quote **Closed as Won** to create a sales order. PSA customizes the sales order and calls it a project contract.


The following flow chart shows a typical sales process in a project-based organization.

> ![Sales process in a project-based organization](media/basic-guide-1.png)

## Estimating a sale
The value of a sale can be estimated based on previously delivered projects and the complexity of projects. For projects that involve extensions to previous projects or where the vendor’s expertise is high and well-known work templates are used, you can use a simpler estimation process. More complex projects usually have a longer purchase process. This means that there are more stages in the sales estimation process. Early on, the sales team, with the input of account managers and subject matter experts (SMEs), begins to create a high-level estimate for each distinct component of work that is quoted. These are represented by quote lines. 

You can create a high-level estimate of the quote which will eventually be replaced by a more detailed estimate that is based on a project plan that you create using the standardized project templates. These templates help you to build a schedule and determine monetary values on the quote and it's components (quote lines).

You can create multiple quotes for a project that are grouped under a single opportunity entity type. Eventually, one of these quotes is marked **Closed as Won**, and a project contract or statement of work (SOW) is created. An SOW is usually created as a Microsoft Word document. A project contract holds the contracted value for each component (contract line) that is accepted by the customer for delivery. All invoices sent to the customer over the course of the project’s delivery reference the project contract, or SOW.

You can also create alternate quotes under one opportunity entity type or set up winning a quote to create a project contract. If you do this, you can attach a Word document that represents the SOW to the project contract record. 

> ![Closing a quote to create a project contract](media/basic-guide-2.png)

## Configure the sales process
You can use business process flows in Microsoft Dynamics 365 to configure your sales process. This provides your sales staff with a guided, visual interface to advance deals through the stages that are typical for your company. 
For example, your company might have the following six stages in the sales process: 

- Qualify
- Estimate
- Internal review
- Contract
- Deliver
- Close

These six stages are represented by chevrons you click to expand in each opportunity entity type you create. 

![Business process configuration in Dynamics 365](media/basic-guide-3.png)
 
Your organization may use different entities to represent the same deal as it evolves. Early in the sales process, a deal is represented by the entity type, **Opportunity**. As time passes and more details emerge, you may use high-level estimates to create one or more quotes. If one of these quotes is reviewed by internal and customer stakeholders, the entity, **Quote** represents the deal. 
After the customer accepts the quote, a **Project contract** or **SOW** represents the deal. To support this, business process flows are structured so that each stage in the process is linked to a different database table.

The **Qualify** stage in the sales process can be backed by an **Opportunity** entity. The **Estimate** and **Internal Review** stages can be backed by a **Quote** entity, and the **Contract**, **Delivery**, and **Close** stages can be backed by a **Project Contract** entity. 

As you advance through the stages, you are prompted to create the appropriate entity record to assist and guide you through the process. The stages can be conditional. For example, if you require an internal review of a quote only if the quote uses a custom price list, you can configure that into the appropriate stage of the business process. That stage is shown only for quotes that use a custom price list. For all other deals and quotes, the **Estimate** stage is shown as preceding the **Contract** stage.

> [!NOTE]
> PSA has specific pages for the **Opportunity**, **Quote**, **Order**, and **Invoice** entities. You must create project service opportunities, quotes, orders, and invoices using the project information pages for these entities. If you use another page to create a record, you won't be able to open the record from the **Project Information** page. If you want to open a record with the **Project Information** page, you must delete the record and recreate it using the **Project Information** page. Business logic on the **Project information** page for each of these entity types ensures that the **Type** field of the record is set correctly, and all of the mandatory concepts are properly initialized.

> ![Project information for a new order](media/basic-guide-4.png)
 
## Differences between PSA and Dynamics 365 for Sales
Although the Project Service sales process uses the basic capabilities of the sales process in Microsoft Dynamics 365 for Sales, it does have some key differences because of variations in the business practices of project-based companies. These differences include: 

- **Project quote**: In PSA, a quote is closed after a project contract is created from a quote, while in Dynamics 365 for Sales, you can keep a quote open after you have won. The reason for this difference is that a match between a quote and a project contract is better for project-based organizations. 
- **Activation and revisions**: Activation and revisions are not supported for project quotes in PSA. In Dynamics 365 for Sales, a quote can be locked to prevent additional edits.
- **Closing a quote as Closed or Won**: In PSA, when a project quote is closed as **Won** or **Lost**, the opportunity remains open. All other quotes on the opportunity are closed as **Lost**. In Dynamics 365 for Sales, when a quote is closed as **Won** or **Lost**, the user is prompted to take an action on the opportunity. Depending on the user input, the underlying opportunity may be closed or left open.

## Track revisions to quotes and project plans in the sales cycle
In PSA, you can’t track revisions to a quote. Instead, you must mark the existing quote as **Closed as Lost** and then create a new quote. You can copy a quote or clone a project-based quote using PSA.

## Track comments and approvals of quotes and project contracts
You can manage the review and approval of quotes and project contracts by using the record wall and posts in Dynamics 365. Your organization can create custom workflows and plug-ins to assign, redirect, escalate, and manage notifications of review and approval work items.
