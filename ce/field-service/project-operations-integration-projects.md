---
title: Projects, project contracts, and project tasks
ms.reviewer: v-wendysmith
description: Learn how project management in Field Service helps frontline users create the project structure required to link work orders to projects.
ms.date: 08/04/2026
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
---

# Projects, project contracts, and project tasks

To use the Field Service and Project Operations integration, it's helpful to understand how projects, project contracts, and project tasks relate to one another.

A **project contract** defines the customer-facing commercial agreement, while **project contract lines** divide that agreement into billable components and determine how transactions are processed financially.

A **project** represents the delivery structure, and **project tasks** form the work breakdown structure (WBS) that you use to plan, schedule, estimate, and track the work.

## Project management in Field Service

While Project Operations provides full project management capabilities, Field Service provides minimal project forms that frontline and operational users can use to create the basic project structure required for work orders to transact against a project. 

These capabilities don't replace project planning, scheduling, or execution tools in Project Operations. Instead, they enable Field Service teams to create foundational project records without leaving the application.

By using these forms, Field Service users can create project artifacts, project contracts, contract lines, and projects that establish the financial framework needed for material and labor transactions to flow into Project Operations or Dynamics 365 Finance. After the required project structure is in place, you can link work orders or agreements so that operational activity routes to the correct financial records.

Use Project Operations to manage tasks as it requires a Project Operations license. Scheduling or resource planning capabilities aren't available in Field Service and must be managed in Project Operations.

## Project requirements

To link a work order or agreement to a project, you need an eligible project. Field Service forms enable you to create the minimal project structure that is required. These requirements ensure financial consistency and allow Field Service transactions, such as material usage and labor services, to flow into Project Operations or Dynamics 365 Finance.

An eligible project must meet the following criteria:

- The project is associated with a project contract.
- The order type is *Work-based*.
- The project contract contains at least one project-based contract line with a defined **Billing method** (Time and material or Fixed price).
- The work order billing account matches the customer that is defined on the associated project contract customer line.
- All customers that are associated with the **Project Contract Line Customer** belong to the same legal entity.
- The project contract line supports the transaction types that are recorded on the work order, including material and labor time transactions.
- The project's actual finish date is blank or is set to a future date.

> [!NOTE]
> The **Project** lookup field on a work order in Field Service displays projects that are associated with project-based contract lines that include the work order billing account on the related project contract customer line.

## Project contract lines

Project contract lines define the commercial and billing structure for project work. Field Service work orders provide the execution record. You can [map specific tasks in a project to a contract line](/dynamics365/project-operations/pro/sales/mapping-projects-tasks-contract-line-sales). You can also [manage multiple customers on a project contract line](/dynamics365/project-operations/pro/sales/manage-multiple-customers-contract-line-sales).

When a Field Service transaction flows to Project Operations, the system uses the project, project task, transaction class, and contract line setup to determine how to process the transaction.

### Project contract line fields that affect Field Service transactions

The following fields appear on the project contract line form.

|Field  |Why it matters  |
|---------|---------|
|**Billing Method** | Determines whether transactions create only cost actuals or both cost and unbilled sales actuals. <br> - Use **Time and Material** so that approved transactions create cost actuals and unbilled sales actuals. <br> - Use **Fixed Price** so that approved transactions create cost actuals only. Billing is handled through milestones or progress-based billing. |
|**Project** | Identifies the project to which the contract line applies.  |
|**Included Tasks** | Determines whether the contract line applies to all project tasks or only selected project tasks. <br> - Use **All Project Tasks** when the same contract line applies across the project. <br> - Use **Selected Project Tasks Only** when specific tasks need their own billing treatment, contract line, biller, funding source, or commercial arrangement. This option is the recommended pattern for task-based billing. |
|**Include Time**  | Determines whether labor transactions resolve to the contract line. |
|**Include material** | Determines whether expense transactions can resolve to the contract line. |
|**Include Expense** | Determines whether expense transcations resolve to the contract line when expenses are enabled. |
|**Contract Line Customer**| Supports billing to the appropriate customer or biller, where applicable. |
|**Not-to-exceed Limit** | Applies a contractual cap for Time and Material contract lines. |

## Project Operations and finance and operations

In the [**Integrated Project Operations with Finance** deployment model](project-operations-integration-inventory.md), Project Operations uses dual-write integration to synchronize setup and configuration data between Microsoft Dataverse and Dynamics 365 finance and operations. 

For more information, see [Project Operations setup and configuration data integration](/dynamics365/project-operations/environment/resource-dual-write-setup-integration).

## Next steps

- [Manage project in Field Service](project-operations-integration-manage-projects.md)
- [Project tasks and how they work in the integration](/dynamics365/project-operations/field-service-integration/project-operations-integration-project-task)
- [Create work orders from projects in Project Operations](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order)
- [Create work orders from project tasks in Project Operations](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order-task)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
