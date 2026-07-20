---
title: Projects, project contracts, and project tasks
ms.reviewer: v-wendysmith
description: Project management in Field Service helps frontline users create essential project structures to link to work orders.
ms.date: 07/16/2026
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
---

# Projects, project contracts, and project tasks

To work with the Field Service and Project Operations integration, it's helpful to understand the concepts and relationships of projects.

The **project contract** defines the customer-facing commercial agreement, while **project contract lines** divide that agreement into billable components and define how work is financially interpreted.

A **project** represents the delivery structure, and **project tasks** form the work breakdown structure (WBS) used to plan, schedule, estimate, and track the work.

## Project management in Field Service

While Project Operations provides the full project management capabilities, Field Service provides minimal project-related forms that frontline and operational users can use to set up the basic project structure required for work orders to transact against a project. These lightweight capabilities aren't intended to replace full project planning or execution tools in Project Operations. Instead, they ensure that Field Service teams can continue their workflow without switching applications to create foundational project records.

By using these forms, Field Service users can create the essential project artifacts, project contracts, contract lines, and projects that establish the financial framework needed for material usage, labor (services), and actuals to flow into Project Operations or Finance. When the required project structure exists, you can link work orders or agreements so that all operational activity routes to the correct financial records.

Use Project Operations for project task management as it requires a Project Operations license. Project management scheduling or resource planning isn't required (or available) in Field Service so use Project Operations for those capabilities.

## Project requirements

To link a work order or agreement to a project, an eligible project must exist. Field Service forms enable you to create the minimal but required project structure. These requirements ensure financial consistency and allow Field Service transactions—such as material usage and labor services—to flow properly into Project Operations or Finance.

An eligible project must meet the following criteria:

- The project is associated with a project contract where the order type is *Work-based*.
- The project contract has a project-based contract line with a defined **Billing method** (time and materials or fixed price).
- The work order billing account matches a customer defined on the associated project contract customer line.
- All customers associated with the **Project Contract Line Customer** belong to the same legal entity.
- The project contract line is configured to support the transaction types being recorded on the work order, including materials and/or labor time.
- The project's actual finish date is blank or set in the future.

> [!NOTE]
> The **Project** lookup field on the work order in Field Service displays projects associated with project-based contract lines that contain the work order billing account on a related project contract customer line.

## Project contract lines

Project contract lines define the commercial and billing structure for project work. Field Service work orders provide the execution context. You can [map specific tasks in a prject to a contract line](/dynamics365/project-operations/pro/sales/mapping-projects-tasks-contract-line-sales). You can also [manage multiple customers on a project contract line](/dynamics365/project-operations/pro/sales/manage-multiple-customers-contract-line-sales).

When a Field Service transaction flows to Project Operations, the system uses the project, project task, transaction class, and contract line setup to determine how to process the transaction.

### Project contract line fields that affect Field Service transactions

The following fields appear on the project contract line form.

|Field  |Why it matters  |
|---------|---------|
|**Billing Method** | Determines whether transactions create cost only or both cost and unbilled sales actuals. <br> - Use **Time and Material** so that approved transactions create cost actuals and unbilled sales actuals. <br> - Use **Fixed Price** so that approved transactions create cost actuals only. Billing is handled through milestones or progress-based billing. |
|**Project** | Identifies the project that the contract line applies to.  |
|**Included Tasks** | Determines whether the contract line applies to all project tasks or only selected tasks. <br> - Use **All Project Tasks** when the same contract line applies across the project. <br> - Use **Selected Project Tasks Only** when specific tasks need their own billing treatment, contract line, biller, funding source, or commercial arrangement. This option is the recommended pattern for task-based billing. |
|**Include Time**  | Determines whether labor transactions can resolve to the contract line. |
|**Include material** | Determines whether material transactions can resolve to the contract line. |
|**Include Expense** | Determines whether expenses can resolve to the contract line, if expenses are enabled. |
|**Contract Line Customer**| Supports billing to the appropriate customer or biller, where applicable. |
|**Not-to-exceed Limit** | Applies a contractual cap for Time and Material contract lines. |

## Next steps

- [Manage project in Field Service](project-operations-integration-manage-projects.md)
- [Project tasks and how they work in the integration](/dynamics365/project-operations/field-service-integration/project-operations-integration-project-task)
- [Create work orders from projects in Project Operations](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order)
- [Create work orders from project tasks in Project Operations](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order-task)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
