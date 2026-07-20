---
title: Set up projects with work orders in the Field Service and Project Operations integration
ms.reviewer: v-wendysmith
description: Learn common scenarios for using the integration between Dynamics 365 Field Service and Project Operations. Understand key concepts, setup guidance, and recommended patterns for work orders, projects, and project contract lines.
ms.date: 07/06/2026
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
---

# Project setup with work orders

Field Service and Project Operations work together to connect project planning, field execution, and project financials. In this integration, projects provide the financial and delivery structure, while work orders represent the field work performed by technicians.

A single project can have many related work orders. You can create work orders manually, generate them from project tasks, or generate them from an agreement. When technicians capture time, materials, or other supported transactions on those work orders, the transactions can flow to Project Operations and resolve to the correct project, project task, and contract line.

The project contract and contract line setup determines how those transactions are processed financially.

## Before you start

Before creating work orders for a project or project task, consider the following questions:

- Should work orders link to the overall project or to specific project tasks?

- Does all field work follow the same billing structure?

- Do different tasks, phases, customers, billers, or funding sources require separate contract lines?

- Should you include labor, materials, expenses, or fees?

- Should transactions create cost only or both cost and unbilled sales actuals?

## Scenario 1: One project with many work orders

This scenario is for customers with one project but multiple field execution activities, and all work follows the same billing structure.

### Customer situation

A customer has a project that requires multiple field visits. Each visit is a Field Service work order, but all work belongs to the same project. All work follows the same billing structure.

For example, a customer has an equipment installation project. The project includes site preparation, installation, inspection, and closeout work. Each visit is a separate work order, but all work rolls up to the same project.

### Recommended setup

Create one project contract and one project contract line for the project.

Set up the contract line with:

- **Project**: Selected project
- **Included Tasks**: *All Project Tasks* or blank
- **Include Time**: Yes
- **Include Materials**: Yes
- **Include Expense**: Optional, if expenses are enabled
- **Billing Method**: *Time and Material* or *Fixed Price*, based on the commercial model

### Field Service execution pattern

Create multiple work orders and link each work order to the same project.

If you need task-level visibility, link each work order to the relevant project task.

### Result

Each work order can produce Field Service transactions, such as technician time and material usage. Those transactions flow to Project Operations and resolve to the project contract line.

This process helps you manage many field visits while maintaining one project financial structure.

## Scenario 2: Agreement-generated work orders linked to a project

This scenario is for customers that have recurring field work, scheduled service, maintenance programs, or long-running service delivery that should roll into a project.

### Customer situation 

A customer has recurring or scheduled field service work that should be tied to a project.

For example, a customer has a maintenance, rollout, or recurring service agreement where work orders are generated on a schedule. The customer wants all generated work orders to contribute time and material transactions to the same project.

### Recommended setup 

Create a project and project contract line that represents the recurring field service engagement.

Set up the contract line with:

- **Project**: Selected project
- **Included Tasks**: *All Project Tasks* or blank, if all agreement work uses the same billing setup 
- **Include Time**: Yes
- **Include Materials**: Yes
- **Include Expense**: Optional, if expenses are enabled
- **Billing Method**: *Time and Material* or *Fixed Price*

### Field Service execution pattern 

Link the agreement to the project.

When the agreement generates work orders, the generated work orders carry the project context.

If the agreement work needs to be separated by phase, asset, location, task, biller, or billing rule, use project tasks and task-based contract line setup.

### Result 

Agreement-generated work orders send transactions to Project Operations without each work order needing to define the commercial structure independently.

The project and contract line provide the financial structure. The agreement provides the recurring Field Service execution pattern.

## Scenario 3: Project tasks drive Field Service execution

This scenario is for the customer who wants project task planning, scheduling, and progress tracking connected to Field Service execution, but doesn't need separate billing treatment by task.

### Customer situation 

A customer wants project planning to drive Field Service execution.

For example, a project manager creates project tasks for installation, configuration, inspection, and customer signoff. Each task requires field execution, so you create work orders from or link work orders to those tasks.

### Recommended setup 

Create a project contract line with:

- **Project**: Selected project
- **Included Tasks**: *All Project Tasks* or blank, if billing is the same across all tasks
- **Include Time**: Yes
- **Include Materials**: Yes
- **Include Expense**: Optional, if expenses are enabled
- **Billing Method**: *Time and Material* or *Fixed Price*

### Field Service execution pattern 

Create work orders from project tasks or link work orders to project tasks.

A project might consist of several tasks, with each task linked to a work order as needed to support the organization's field service execution process.

### Result 

Work orders carry project task context. Time and material transactions from the work order can update the project and support task-level execution visibility.

If the contract line uses *All Project Tasks* or is blank, the task is used for tracking and reporting, while billing still resolves to the same contract line.

## Scenario 4: Task-based billing for multiple billers or billing arrangements

This scenario is for customers who need different billing treatment by task, phase, asset, location, customer, biller, or funding source, but each task can still receive the full set of Field Service transactions from the work order.

### Customer situation

A customer has one project, but different parts of the project need to be billed to different customers, billers, funding sources, or contract lines.

For example, a project includes work across multiple locations, assets, or phases. Each task group represents a different billing responsibility. Field Service work orders are linked to the applicable project task, and all supported transactions from the work order should follow the billing setup for that task.

### Recommended setup

Set up [task-based billing](/dynamics365/project-operations/field-service-integration/project-operations-integration-project-task) in Project Operations.

Create multiple project contract lines for the same project. Each contract line should use:

- **Project**: Same project
- **Included Tasks**: *Selected Project Tasks Only*
- **Include Time**: Yes, if labor from the work order should be included
- **Include Materials**: Yes, if materials from the work order should be included
- **Include Expense**: Yes, if expenses from the work order should be included
- **Include Fee**: Yes, if fees are in scope
- **Billing Method**: *Time and Material* or *Fixed Price*, based on the billing arrangement
- **Contract Line Customer**: Set based on the customer or biller responsible for that portion of the work, where applicable

Then associate the correct project tasks to each contract line on the **Task Billing Setup** tab.

### Field Service execution pattern

Link each work order to the specific project task that represents the work being performed.

A single work order linked to that task can include multiple transaction types, such as:

- Technician time
- Materials or products
- Expenses, if enabled
- Other supported project transaction classes

The project task doesn't limit the work order to one transaction type. Instead, the task helps Project Operations determine which contract line should receive the transactions.

### Result

Field Service transactions resolve by using the project, task, and transaction class.

For example:

- All included transaction classes from work orders linked to Task A resolve to Contract Line A.
- All included transaction classes from work orders linked to Task B resolve to Contract Line B.
- If **Include Time** is set to *Yes*, time from that task can resolve to that contract line.
- If **Include Materials** is set to *Yes*, materials from that task can resolve to that contract line.
- If **Include Expense** is set to *Yes*, expenses from that task can resolve to that contract line.
- If a transaction class isn't included on the contract line, that transaction type doesn't resolve to that contract line.

## Scenario 5: Different billing treatment for labor and materials

This scenario is for customers who want Field Service labor and materials to flow from the same work orders but follow different billing rules and don't use project tasks.

### Customer situation

The customer has one project and many work orders, but labor and materials shouldn't be billed the same way.

For example, labor is included in a fixed project fee, but parts are billed separately as they're used. Field technicians still capture both time and materials on work orders.

### Recommended setup

Create separate contract lines by transaction class.

#### Contract line 1: Labor

- **Project**: Selected project
- **Included Tasks**: *All Project Tasks* or blank, if this labor treatment applies across the project
- **Include Time**: Yes
- **Include Materials**: No
- **Include Expense**: No, unless expenses should also follow this contract line
- **Billing Method**: *Fixed Price* or *Time and Material*, based on the labor agreement

#### Contract line 2: Materials

- **Project**: Same project
- **Included Tasks**: *All Project Tasks* or blank, if this material treatment applies across the project
- **Include Time**: No
- **Include Materials**: Yes
- **Include Expense**: No, unless expenses should also follow this contract line
- **Billing Method**: *Fixed Price* or *Time and Material*, based on the material agreement

### Field Service execution pattern

Create work orders against the project.

Technicians capture:

- Time entries
- Work order products or material usage

### Result

Time resolves to the labor contract line because **Include Time** is set to *Yes* on the labor contract line.

Materials resolve to the materials contract line because **Include Materials** is set to *Yes* on the materials contract line.

The billing method on each contract line determines whether the transaction creates cost only or both cost and unbilled sales actuals.

## Scenario 6: Fixed price project with Field Service execution costs

This scenario is for customers who need Field Service execution costs on a project, but customer billing is based on a fixed price agreement instead of billing each labor, material, or expense transaction.

### Customer situation

A customer has a fixed price project, but the work is delivered through multiple Field Service work orders.

For example, a customer pays a fixed amount for an equipment upgrade, site modernization, or installation project. The work requires multiple technician visits, labor, materials, and inspections. Technicians still need to capture time and materials, but the customer isn't billed based on each transaction.

### Recommended setup

Create a project contract line with:

- **Billing Method**: *Fixed Price*
- **Project**: Selected project
- **Included Tasks**: *All Project Tasks* or leave blank if the fixed price billing applies across the project
- **Include Time**: Yes
- **Include Materials**: Yes
- **Include Expense**: Optional, if expenses are enabled

### Field Service execution pattern

Create or link multiple work orders to the project or project tasks.

Technicians continue to capture Field Service transactions as part of normal execution, such as:

- Time entries
- Materials or products
- Expenses, if enabled

### Result

Approved Field Service transactions flow to Project Operations and resolve to the fixed price contract line.

Because the contract line is fixed price:

- Time creates cost actuals only.
- Materials create cost actuals only.
- Expenses create cost actuals only, if expenses are enabled.
- Unbilled sales actuals aren't created from the individual Field Service transactions.
- Customer billing is handled through fixed price milestones or progress-based billing.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
