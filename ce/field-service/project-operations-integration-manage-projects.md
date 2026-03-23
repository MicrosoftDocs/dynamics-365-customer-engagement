---
title: Manage projects in Field Service
ms.reviewer: wesmith
description: Learn how to manage projects in Dynamics 365 Field Service with the Dynamics 365 Project Operations integration.
ms.date: 01/29/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
---

# Manage projects in Field Service

Field Service provides minimal project-related forms that allow frontline and operational users to set up the basic project structure required for work orders to transact against a project. These lightweight capabilities aren't intended to replace full project planning or execution tools in Project Operations. Instead, they ensure that Field Service teams can continue their workflow without switching applications to create foundational project records.

By using these forms, Field Service users can create the essential project artifacts, project contracts, contract lines, and projects that establish the financial framework needed for material usage, labor (services), and actuals to flow into Project Operations or Finance. When the required project structure exists, you can link work orders or agreements so that all operational activity routes to the correct financial records.

Project management scheduling, task breakdown, or resource planning isn't required (or available) in Field Service. Use Project Operations to use those capabilities.

This article provides the steps needed to create an eligible project in Field Service.

## Prerequisites

- The [Field Service and Project Operations integration is installed](project-operations-integration-setup.md).
- You have a [Field Service administrator role](security-permissions.md#field-service-security-roles).
- You understand your organization’s [Project Operations deployment model](project-operations-integration-inventory.md#deployment-models-and-inventory-ownership).

## Project requirements

To link a work order or agreement to a project, an eligible project must exist. Field Service forms enable you to create the minimal but required project structure. These requirements ensure financial consistency and allow Field Service transactions—such as material usage and labor services—to flow properly into Project Operations or Finance.

- A project contract where the order type is work-based.
- A project-based contract line with a defined **Billing method** (time and materials or fixed price) and  **Includes materials** set to *Yes*.
- A project associated with the contract and contract line.
- The billing account and currency match those on the work order.
- The contract line includes materials.
- The actual finish date is blank or set in the future.

To manage internal projects in Field Service, create a customer account and create a contract for that customer. Make sure the contract line is fixed price.

## Create a project

1. In Field Service, select the **Projects** area.

1. Select **Projects**, and then select **New Project**.

1. Enter the project name and any other information.

   :::image type="content" source="media/project-operations-integration-project.png" alt-text="Screenshot of Field Service Project screen.":::

1. Select **Save & Close**.

## Create a project contract and contract lines

1. In Field Service, select the **Sales** area.

1. Select **Project Contracts**, and then select **New**.

1. Fill out the required fields. Learn more in [Header details for project-based contracts](/dynamics365/project-operations/sales/project-contract-settings).

1. Select **Save**.

   :::image type="content" source="media/project-operations-integration-project-contract.png" alt-text="Screenshot of Field Service Project Contracts screen.":::

1. Select the **Contract Lines** tab.

1. Under **Project-based Lines**, select **Add New Contract Line**.

1. Fill out the required fields, including the project. Learn more in [Project contract lines overview](/dynamics365/project-operations/pro/sales/manage-contract-values-project-based-sales).

1. Select **Save & Close**. The contract and contract line now serve as the financial container for work performed against the project.

1. Select the **Project Price Lists** tab, and then select **Add New Project Price List**.

1. Select the price list, and then select **Save & Close**.

A frontline worker can assign the project to work orders or agreements.

## View material usage logs

A material usage log shows the list of materials or parts that a field technician uses while completing a job. For example, if someone installs a replacement part during a repair, that part and its cost appear on the log. It helps you track what materials were consumed so you can charge the customer correctly and update inventory.

The system automatically creates a material usage log when a technician records materials or services on a work order as used. Learn more in [Record material usage on projects and project tasks](/dynamics365/project-operations/material/material-usage-log). You can view all material usage logs by selecting **Projects** > **Material Usage Logs**.

If [**Auto-Approve Project Approval** was enabled](project-operations-integration-setup.md#enable-the-integration) during setup, the system automatically approves material usage logs, creates an **Approved** project approval record, and generates actuals. Skip to [Create invoices](#view-actuals-and-create-invoices).

If **Auto-Approve Project Approval** is *No*, the material usage logs must be submitted for approval.

1. In Field Service, select the **Projects** area. Then, select **Material Usage Logs**.

1. Find and select the billable items to submit for approval, and then select **Submit**. The system automatically creates a project approval record. This record must be approved before actuals are generated.

## Approve billable items

If **Auto-Approve Project Approval** is *No*, review and approve the submitted Material Usage Logs.

1. In Field Service, select the **Projects** area. Then, select **Approvals**.

1. Find and select the submitted items. Then select **Approve**. The system generates actuals.

## View actuals and create invoices

After approval, the system creates actuals in Project Operations. These actuals link to the project and associate to the correct contract line. Use the actuals to create a draft invoice.

1. In Field Service, select the **Sales** area.

1. Select **Actuals**.

1. Find and select the actuals for your project contract. Then, select **Ready to invoice**. The system creates a draft Proforma invoice showing what is to be billed.

If your organization is using the Integrated Project Operations with Finance model, the system also creates [Project Operations Integration Journal Lines](/dynamics365/project-operations/project-accounting/project-operations-integration-journal) that transfer the approved financial data to Finance.

## Review and confirm invoices

If your organization is using the Project Operations Core (Lite) without Finance model, review, [edit if necessary, and confirm the invoice](/dynamics365/project-operations/pro/proforma-invoicing/create-manual-proforma-invoice-sales#edit-a-draft-invoice).

If your organization is using the Integrated Project Operations with Finance model, the [invoice is finalized in Finance](/dynamics365/project-operations/invoicing/post-project-invoices).

## Next steps

- [Link projects to work orders](project-operations-integration-work-order.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
