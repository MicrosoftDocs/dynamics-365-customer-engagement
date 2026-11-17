---
title: Manage multiple payers on a work order
description: Manage multi-payer work orders in Field Service by using billing override to products, services, time entries, and expenses in Field Service.
ms.date: 11/13/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
---

# Manage multiple payers on a work order

In Field Service, you can manage work involving multiple payers under a single work order while ensuring that each transaction is attributed to the appropriate payer for billing. The work order must be linked to a project which contains the project tasks to use for billing.

For example, a technician visits a customer to repair equipment. During the visit, some repairs are the customer's responsibility, while others are covered by the equipment manufacturer. In this scenario, the customer pays for the standard repairs, while the manufacturer pays for the work covered under its warranty.
By default, Field Service associates the products, services, time entries, and expenses with the project task linked to the work order. However, when multiple parties are responsible for payment, individual transactions might need to be associated with different project tasks to ensure charges are attributed to the appropriate payer.

In Field Service, you can select a different project task for individual work order products, services, time entries, and expenses without changing the project task associated with the work order. You override the set project task for billing purposes by selecting the appropriate project task, but it doesn't change the project task on the work order itself.

## Use billing override in Field Service

1. In Field Service, open the work order product, service, time entry, or expense that involves multiple payers.

1. For work order product or service, select the **Other** tab.

1. In **Billing Override**, select the project task that corresponds to the appropriate payer for this transaction.

   :::image type="content" source="media/project-operations-integration-work-order-billing-override.png" alt-text="Screenshot of a work order product showing the Billing Override field on the Other tab." lightbox="media/project-operations-integration-work-order-billing-override.png":::

1. Select **Save & Close**.

> [!NOTE]
> Billing override is available only in Field Service and supports selecting another task within the same project. Project Operations uses the selected task and the task-based billing rules to determine the applicable project contract line.

## Scenario: Bill multiple parties for work completed under one work order

A service provider maintains equipment for a customer. During a service visit, a technician identifies two repairs that need to be completed. The customer is responsible for paying for one repair, while the equipment manufacturer is responsible for the other repair under its warranty agreement.

Both repairs are completed during the same visit and recorded under a single work order. However, because different parties are responsible for payment, the transactions need to be associated with different project contract lines.

### Configure task-based billing in Project Operations

To support this scenario, the service provider configures two project tasks in Project Operations, each associated with a different project contract line and payer.

| Project task | Project contract line | Payer |
| --- | --- | --- |
| Customer repairs | Customer repair services | Customer |
| Manufacturer repairs | Manufacturer repair services | Manufacturer |

Project Operations uses task-based billing to determine which project contract line applies to transactions associated with each task. Learn more in [Map projects and tasks to a project contract line](/dynamics365/project-operations/pro/sales/mapping-projects-tasks-contract-line-sales).

### Apply billing override in Field Service

The technician completes both repairs under a single work order associated with the *Customer repairs* project task.

By default, transactions use the project task associated with the work order. To ensure the manufacturer is billed for its portion of the repairs, the service provider sets the **Billing Override** to *Manufacturer repairs* on the applicable transactions in Field Service.

| Transaction | Billing Override | Project task used for billing |
| --- | --- | --- |
| Work order product: Customer-paid replacement part | None | Customer repairs (Work Order Task) |
| Work order service: Manufacturer-covered repair | Manufacturer repairs | Manufacturer repairs (Billing Override Task) |
| Time entry: Manufacturer-covered repair labor | Manufacturer repairs | Manufacturer repairs (Billing Override Task) |
| Expense: Manufacturer-covered repair expense | Manufacturer repairs | Manufacturer repairs (Billing Override Task) |

When the transactions are processed in Project Operations, the configured task-based billing rules determine the applicable project contract lines and associated payers.

In this example:

- The customer-paid replacement part is associated with the *Customer repair services* contract line.
- The manufacturer-covered repair transactions are associated with the *Manufacturer repair services* contract line.

The service provider is able to manage repairs involving multiple payers under a single work order while ensuring that transactions are attributed to the appropriate project tasks for billing.

[!INCLUDE[footer-include](../includes/footer-banner.md)]