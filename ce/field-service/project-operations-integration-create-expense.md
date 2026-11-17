---
title: Manage project expenses in Field Service
description: Learn how to create, submit, and recall expenses in Dynamics 365 Field Service with the Dynamics 365 Project Operations integration.
ms.date: 11/05/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
---

# Manage project expenses in Field Service

Technicians often incur expenses while completing service work, such as travel, lodging, meals, permit fees, or emergency part purchases. Technicians can capture these service-related expenses directly from the work order in Field Service web and mobile apps, ensuring accurate tracking and integration with Project Operations for financial management and project cost tracking.

If technicians create expenses while offline, expenses automatically sync when connectivity is restored. All expenses follow the standard Project Operations approval process, where project approvers can review, approve, or reject them.

## Create an expense record

1. In Field Service, open the work order, and then select the **Expenses** tab.

1. Select **New Expense**.

   :::image type="content" source="media/project-operations-integration-expense-create.png" alt-text="Screenshot of the Quick Create: Expense dialog." lightbox="media/project-operations-integration-expense-create.png":::

1. Fill in the required details, such as the expense type, amount, and any relevant notes.

1. Select **Save**. Enter other expenses as needed, and then select **Save & Close**.

## Submit an expense for approval

You can edit the expenses while they're in draft status. To submit an expense for approval, select the expense record, and then select **Submit**. A project approver admin must review and [approve the submitted expense](project-operations-integration-manage-projects.md#approve-billable-items) before it is finalized.

:::image type="content" source="media/project-operations-integration-expense-submit.png" alt-text="Screenshot of the Expenses screen with the Submit button highlighted.":::

## Recall a submitted expense

If you submitted an expense by mistake or need to make changes to a submitted expense, you can recall it. You can't recall an approved expense.

To recall an expense, open the expense record, and then select **Recall**. The recall request must be approved before the expense becomes editable again. After the recall is approved, you can update the expense and resubmit it.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
