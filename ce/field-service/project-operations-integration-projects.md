---
title: Projects, project contracts, and project tasks
ms.reviewer: v-wendysmith
description: Learn how project management in Field Service helps frontline users create the project structure required to link work orders to projects.
ms.date: 11/05/2026
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
---

# Projects, project contracts, and project tasks

To use the Field Service and Project Operations integration, you need to understand how projects, project contracts, and project tasks relate to each other.

A **project contract** defines the customer-facing commercial agreement. **Project contract lines** divide that agreement into billable components and determine how transactions are processed financially.

A **project** represents the delivery structure. **Project tasks** form the work breakdown structure (WBS) that you use to plan, schedule, estimate, and track the work.

## Project requirements

The requirements for a project differ depending on the project type: customer billable, internal, or investment.

### Customer-billable projects

Use a customer-billable project when work you perform through a work order contributes to a broader customer engagement that you track for cost, revenue, and billing.

You can create and manage customer-billable projects from either Field Service or Project Operations, depending on how your organization prefers to manage the work. This approach gives you flexibility to keep service teams working primarily in Field Service while allowing project-focused users to manage the same engagement from Project Operations.

The project and its contract provide the financial context for the work, while the work order represents the service execution.

To use a project for customer-billable work, verify the following setup.

Customer-billable projects must meet the following criteria:

- The project is associated with a project contract.
- The order type is *Work-based*.

**Project contract setup**

- The project contract contains at least one project-based contract line.
- The project contract line has a defined **Billing method** of either **Time and material** or **Fixed price**.
- The project contract line supports the transaction types that you record on the work order, including material and labor time transactions.

**Customer and legal entity alignment**

- The work order billing account matches the customer associated with the project contract.
- All customers that are associated with the **Project Contract Line Customer** belong to the same legal entity.

For time and material work, approved project transactions can generate corresponding sales values. These approved project transactions can contribute to the billing backlog and be included in customer invoicing.

### Internal projects

Internal projects track work and costs that you don't bill to an external customer, such as internal product development, presales activities, or operational initiatives. They don't have a project contract or contract line requirements. Learn more in [Configure accounting for internal projects](/dynamics365/project-operations/project-accounting/configure-accounting-internal-projects).

Field Service transactions contribute to the project's cost. Sales lines aren't generated as part of the financial records.

### Investment projects

Investment projects support internal capital initiatives such as infrastructure improvements, asset acquisition, research and development, and asset creation. They're designed to accumulate project costs and support the capitalization process rather than customer billing. Learn more in [Enable investment projects in Dynamics 365 Project operations integrated with ERP](/dynamics365/project-operations/project-accounting/project-operations-investment-project). They don't have a project contract or contract line requirements.

Field Service transactions contribute to investment and capitalization accounting.

## Project management in Field Service

While Project Operations provides full project management capabilities, Field Service provides minimal project forms that frontline and operational users can use to create the basic project structure required for work orders to transact against a project.

These capabilities don't replace project planning, scheduling, or execution tools in Project Operations. Instead, they enable Field Service teams to create foundational project records without leaving the application.

By using these forms, Field Service users can create project artifacts, project contracts, contract lines, and projects that establish the financial framework needed for material and labor transactions to flow into Project Operations or Dynamics 365 Finance. After the required project structure is in place, you can link work orders or agreements so that operational activity routes to the correct financial records.

Use Project Operations to manage tasks as it requires a Project Operations license. Scheduling or resource planning capabilities aren't available in Field Service and must be managed in Project Operations.

## Project contract lines

Project contract lines define the commercial and billing structure for customer-billable projects. Field Service work orders provide the execution record. You can [map specific tasks in a project to a contract line](/dynamics365/project-operations/pro/sales/mapping-projects-tasks-contract-line-sales). You can also [manage multiple customers on a project contract line](/dynamics365/project-operations/pro/sales/manage-multiple-customers-contract-line-sales).

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

In the [**Integrated Project Operations with Finance** deployment model](project-operations-integration-deployment-models.md), Project Operations uses dual-write integration to synchronize setup and configuration data between Microsoft Dataverse and Dynamics 365 finance and operations. 

For more information, see [Project Operations setup and configuration data integration](/dynamics365/project-operations/environment/resource-dual-write-setup-integration).

## Next steps

- [Manage project in Field Service](project-operations-integration-manage-projects.md)
- [Project tasks and how they work in the integration](/dynamics365/project-operations/field-service-integration/project-operations-integration-project-task)
- [Create work orders from projects in Project Operations](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order)
- [Create work orders from project tasks in Project Operations](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order-task)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
