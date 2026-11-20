---
title: Work order services in Field Service and Project Operations
description: Work order services help connect field execution with project costing and billing. Learn how to convert labor and materials into accurate project transactions.
ms.date: 11/17/2026
ms.topic: concept-article
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
---

# Work order services in Field Service and Project Operations

Field Service and Project Operations support different ways of planning and executing service work. Some organizations plan labor from the project plan and use work orders primarily for field execution. Other organizations manage most of the service scope directly from the work order and need technician activity to flow into Project Operations for costing and billing.

To support the different approaches, the integration allows you to configure how work order services are converted into project estimates and actuals when work orders are associated with projects. An administrator [configures the conversion type for the organization](project-operations-integration-setup.md#configure-work-order-services).

> [!IMPORTANT]
> Organizations should carefully evaluate configuration changes after transactions have already been generated to avoid inconsistencies between estimates and actuals.

## Work order service conversion type

The **Work Order Service Conversion Type** setting controls how work order services contribute to project estimates and actuals.

| Option | Description | When to use |
|--------|-------------|-------------|
| **Material based Estimates and Actuals (default)**| Generate material-based estimates and, when marked *Used*, material usage logs that produce project actuals after approval. | For organizations that want work order services to contribute to material-based financial estimates and actuals. This option preserves the existing default behavior. |
| **Time based Estimates and Actuals**| Generate time-based estimates and, when marked *Used*, time usage transactions that produce project actuals after approval. | For organizations that want work order services to represent labor estimates and actual costs. When integrated with Dynamics 365 Finance, time-based estimates can also contribute to financial forecasting without requiring a separate project task solely to estimate that labor. |
| **Time based Estimates Only** | Generate time-based estimates but doesn't automatically generate time entries or actuals. | For organizations who want to estimate labor through work order services but capture actual labor separately, such as through technician time entries or booking-based time entry generation. |
| **None** | Work order services doesn't automatically generate estimates, time entries, material usage logs, or actuals through the integration. | For organizations that have their own customizations in place if financial transactions are required. Organizations must implement their own customizations or use another supported transaction capture process. |

> [!IMPORTANT]
> Work order service estimates don't update project task estimates. When work order services are configured to use **Time based Estimates and Actuals**, labor estimates entered on the work order are reflected in the work order's estimates and at the overall project level in Project Operations. They don't create or update labor estimates on individual project tasks, even when the work order is linked to a project task.
>
> For organizations that plan labor at the project task level, estimated labor should continue to be managed through the project plan in Project Operations. Work orders can still be used to schedule and execute field activities, while the project plan remains the source for task-level labor estimates.

## Booking timestamps and work order services

The integration doesn't prevent organizations from using automatic booking-time entry generation alongside time-based work order services conversion.

However, when both methods are used to capture the same labor, duplicate time entries or actual transactions might occur.

For example, if a technician completes a booking and the corresponding work order services is marked *Used*, both processes could generate time transactions for the same work.

Organizations should configure their time capture processes to avoid recording the same labor more than once.

## Update existing work order services

When an existing work order service is updated, the integration reconciles the associated estimates and transactions according to the **Work Order Service Conversion Type**.

For **Material based Estimates and Actuals** or **Time based Estimates and Actuals**, the integration updates previously created material usage logs or time entries as needed, even if the configuration has changed since those records were created.

For example, if a work order service previously generated time entries and the configuration is later changed to Material Estimates and Actuals, the integration continues to update its existing time entries. The integration doesn't create new material usage logs.

## Delete work order services

For **Material based Estimates and Actuals** or **Time based Estimates and Actuals**, deleting a work order service removes its related integration-generated estimates and transaction records, with associated actuals reversed as applicable.

For **Time Estimates Only**, the integration removes associated estimate lines.

For **None**, the integration performs no conversion-related cleanup, so organizations can manage any custom transaction processing independently.

## Next steps

[Configure the conversion type for the organization](project-operations-integration-setup.md#configure-work-order-services)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
