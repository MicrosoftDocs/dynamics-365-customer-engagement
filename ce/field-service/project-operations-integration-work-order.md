---
title: Link projects to work orders and agreements
description: Learn how to link a project in Dynamics 365 Project Operations to a work order in Dynamics 365 Field Service.
ms.date: 01/29/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
---

# Link projects to work orders and agreements

To ensure accurate financial tracking in Project Operations, link Field Service work orders to an eligible project. This link allows material usage, labor entries, and actual costs to flow into the correct project contract line and billing structure. You can link work orders manually or through agreements. Project linkage must occur before the **Work Order System Status** is *Posted*.

## Prerequisites

- [Project requirements](project-operations-integration-manage-projects.md#project-requirements) are met.
- You have a [Field Service dispatcher or administrator role](security-permissions.md#field-service-security-roles).

## Directly link a project to a work order

1. Open an existing work order or [create a work order](create-work-order.md) in Field Service.

1. On the **General** tab, scroll to the **Related Project Details** section and select the project.

   :::image type="content" source="media/project-operations-integration-work-order-project.png" alt-text="Screenshot of a Field Service work order highlighting the Project field.":::

1. Select **Save & Close**.

## Link a project to an agreement

Agreements generate recurring work orders. When you link an agreement to a project, you ensure consistent financial alignment for recurring or scheduled services. Assign the project before setting the agreement to *Active*.

1. Open an existing agreement or [create an agreement](set-up-customer-agreements.md) in Field Service. The agreement must be in a *Draft* or *Estimate* status.

1. Select the project.

   :::image type="content" source="media/project-operations-field-service-integration-agreement.png" alt-text="Screenshot of a Field Service agreement highlighting the Project field.":::

1. Change the **System Status** to **Active** to activate the agreement.

1. Select **Save & Close**. Any work orders created from the agreement automatically link to the assigned project.

## Change or remove a project from a work order or agreement

You can change or remove a project as long as the work order isn't posted. You might want to change or remove a project if you selected the wrong project.

### Change the project on a work order

When you change the project on a work order, the following updates happen:

- All existing and future project-related estimates and actuals for the work order’s product and service lines reference the new project.
- New usage recorded after the change generates estimates and actuals under the new project and contract line.

To change the project, open the work order in Field Service and change the **Project** field on the **General** tab. Confirm and save.

### Remove the project from a work order

When you remove the project from a work order, the following changes happen:

- The system deletes any existing project estimates for the work order.
- The system reverses any project actuals that you already created.
- The system returns the work order to an unlinked state until you select a new project.

To remove the project, open the work order in Field Service and remove the project from the **Project** field on the **General** tab. Confirm and save. Financial data is no longer linked to the project.

### Change a project on an agreement with work orders

When you update the project on an agreement that already generated work orders, only new work orders inherit the newly selected project lookup. You must manually correct any existing work orders that you created under the previous project.

## View work orders related to projects

To view work orders that are linked to projects, on the **Work Orders** page, select the **Work Orders Linked to Project** view.

:::image type="content" source="media/project-operations-field-service-integration-linked-view.png" alt-text="Screenshot of the Work Orders Linked to Project view.":::

To view work orders that aren't linked to projects, on the **Work Orders** page, select the **Work Orders Without Project** view.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
