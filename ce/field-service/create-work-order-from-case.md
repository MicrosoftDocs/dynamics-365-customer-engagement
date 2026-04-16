---
title: Create a work order from a case
description: Learn how to create a work order from a case in Dynamics 365 Field Service using the Case to Work Order business process flow.
ms.date: 02/27/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: puneetsingh
ms.custom: bap-template
---

# Create a work order from a case

A work order in Dynamics 365 Field Service can be created from a case using the **Case to Work Order Business Process** flow. The business process flow guides you through the stages of evaluating a case and generating a work order to address the reported issue.

## Prerequisites

- A Dynamics 365 Field Service environment with the **Case to Work Order Business Process** flow enabled.
- A **Field Service - Dispatcher** or **Field Service - Administrator** security role.

## Set up the case

1. In the Field Service app, select the **Service** area and go to **Service Delivery** > **Cases**.

1. Open an existing case or create a new one and add all the necessary details.

1. On the case form, in the **Field Service** tab, set the **Incident Type** field. The incident type determines the service tasks, products, and services that automatically populate on the work order.

1. Optionally, set the **Functional Location** field if the case is associated with a specific location.

## Create the work order using the business process flow

1. On the case form, locate the **Convert to Work Order** option at the top of the form. If it doesn't appear, select the process switcher by selecting **⋮** at the top, go to **Process** > **Switch Process** > **Case to Work Order Business Process**.

1. Complete the required fields in the **Case** stage and select **Next Stage** to advance.

1. In the **Work Order** stage, select **Create** to generate a new work order linked to the case.

1. On the new work order form, verify or fill in the required fields:

   - **Service Account**: Populated from the case's customer account.
   - **Work Order Type**: Select a work order type from the list or [create a new work order type](create-work-order-types.md).
   - **Price List**: Select a price list from the list or [create a new price list](create-price-list.md).
   - **System Status**: Set to **Unscheduled** by default.
   - **Taxable**: Choose whether the work order is taxable.

1. The following fields carry over from the case to the work order:

   - The case's **Incident Type** maps to the work order's **Primary Incident Type**.
   - The case's **Description** maps to the work order's **Instructions**.
   - The case's **Functional Location** maps to the work order's **Functional Location**.

1. Select **Save** or **Save and Close**.

## Next steps

- [Schedule a work order](universal-resource-scheduling-for-field-service.md)
- [Create work order types](create-work-order-types.md)
- [Set up booking statuses](set-up-booking-statuses.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
