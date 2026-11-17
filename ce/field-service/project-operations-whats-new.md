---
title: What's new in the Field Service integration with Project Operations
ms.reviewer: v-wendysmith
description: Learn what's new in the Dynamics 365 Field Service and Dynamics 365 Project Operations integration.
ms.date: 11/16/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
---

# What's new in the Field Service integration with Project Operations

This article summarizes feature updates, bug fixes, and other improvements.

## November 16, 2026

The Dynamics 365 Field Service and Project Operations Integration package version 3.0.3606.9 contains the following updates.

### Features

- [**Capture project expenses directly from work orders**](project-operations-integration-create-expense.md) in both Field Service web and mobile apps.

- [**Track costs for non-billable field work.**](project-operations-integration-projects.md) Connect Field Service work orders to internal and investment projects so that you capture labor, material, expense, and other costs against that project for centralized cost tracking.

- [**View work order financial performance with Cost Summary**](project-operations-integration-cost-summary.md). Cost Summary gives field teams a clearer view of how project-related work is performing by bringing estimated and actual costs, sales, and project task progress together in one place. Teams can quickly compare what was planned with what was actually delivered across products, services, and expenses.

- [**Create work order projects from Project Operations material estimates**](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order). Material estimates created in a project plan automatically create connected work order products on the related Field Service work order.

- [**Choose whether work order services flow as time or material transactions.**](project-operations-integration-setup.md#configure-work-order-services) A new administrator-level setting controls how work order services contribute to project financials.

- [**Support multiple warehouse assignments for a bookable resource**](project-operations-integration-setup.md#set-up-warehouse-associations). Manage inventory across multiple locations. This capability is supported in the Project Operations integrated with ERP deployment model, where Field Service works with Finance and Supply Chain Management through dual-write.

- [**Support multiple payers across work order lines**](project-operations-integration-work-order-multi-payer.md). Determine the billing responsibility at the individual work order line level rather than requiring every transaction on the work order to follow the same payer.

- [**Add resource requirements to a project task**](project-operations-integration-resource-requirements.md). Keep project staffing and Field Service scheduling aligned. When a project task includes resource assignments and planned effort, that demand is represented on the related work order with the same role, resource, duration, and scheduling window. You can schedule the same demand from either application and receive consistent availability and booking results. When multiple assignments exist, dispatchers can select the specific requirement they want to schedule.

- [**Automatically complete a linked project task when a work order is completed**](project-operations-integration-setup.md#set-up-auto-complete-project-tasks).

- [**Migrate legacy work orders to the Field Service and Project Operations integration**](/dynamics365/guidance/migrate/migrate-legacy-work-orders)

## July 20, 2026

The Dynamics 365 Field Service and Project Operations Integration package version 2.1.3488.3 includes the following updates.

### Features

- Task-level work order association enables direct linkage between individual project tasks and work orders. You can create work orders directly from project tasks, associate existing work orders with tasks, remove or reassign work orders as project scope evolves, and view project and task context directly in Field Service.

- Project-driven scheduling behavior. When a work order is linked to a project task, the task’s planned start and end dates are applied to the work order as the time promised window. This approach provides guidance for scheduling without enforcing restrictions. Scheduling constraints from the project are advisory. Field Service doesn't enforce these constraints, but provides warnings if execution falls outside the expected project boundaries.

- Project task dependencies are configured in the project work breakdown structure using the **Depends on** field on each task. Project Operations supports multiple dependency types, with finish-to-start as the default. These dependencies appear on the work order and help visualize the sequence of activities.

- Time entry is integrated with Project Operations. Labor captured in Field Service through time entries flows into a Project Operations project and follows Project Operations rules for time approval, pricing, and financial processing. Once approved, these time entries create both cost and unbilled sales actuals. When the time entry is associated with a project task, the approved hours also update the project task’s effort completed hours.

## April 30, 2026

The Dynamics 365 Field Service and Project Operations Integration package version 1.1.3384.2 includes the following updates.

### Features

- Improved financial record traceability. Actuals and estimates show links to the related work order and specific work order lines and the agreement if the work came from an agreement.

  :::image type="content" source="media/project-operations-field-service-actuals.png" alt-text="Screenshot of Field Service Actuals screen, Field Service tab.":::

- Clearer inventory experience in the integrated Project Operations with Finance model. In this model, since inventory is managed in Dynamics 365 Supply Chain Management and not Field Service, Field Service hides inventory features. For example, Product Inventory, Transfers, and Adjustments no longer appear. You can still view inventory in Field Service through [warehouses](/dynamics365/field-service/inventory-purchasing-returns-overview#warehouses-and-product-inventory), but you can't change it.

- Expanded project lookup for all billing customers, not just the default project contract billing customer. All customers listed on the associated project-based contract line are available in the project lookup.

### Bug fixes

- Aligned transaction types with Project Operations so that only relevant and supported transaction types are available in Field Service. In some existing environments, previously available options might still be visible.

- Improved error messages and system monitoring. Work order line error messages are more detailed and actionable to help users quickly identify and fix the issue.

- Reduced multi-currency restrictions for work orders. Additional multi-currency options are supported.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
