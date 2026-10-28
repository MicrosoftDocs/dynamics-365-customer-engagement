---
title: Manage work order requests (preview)
description: Learn how to create and review work order requests made in the rentals integration to determine if they should be approved and create a work order.
ms.date: 10/27/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 10/19/2026
ai-usage: ai-assisted
---

# Manage work order requests in Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Work order requests help you quickly capture service needs without prematurely committing to execution. Finance and operations users and Field Service users can create work order requests. When a work order request is ready for consideration, the user must submit it for review.

A Field Service user reviews the submitted work order request and decides how the work should be carried out. Approving a request automatically creates a work order.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Create a work order request

1. In Field Service, select the **Service** area. Under **Service Delivery**, select **Work Order Requests**.

1. Select **New**.

   :::image type="content" source="media/rentals-work-order-request-new.png" alt-text="Screenshot of a new work order request." lightbox="media/rentals-work-order-request-new.png":::

1. Enter the following information to describe the service request:

   - **Substatus** (optional): Select a substatus that belongs to the request's current status.
   - **Fleet Item**: Select the equipment that needs service.
   - **Work Order Type**: Select the type of work.
   - **Incident Type**: Select an active incident type when required by the **Work Order Type**, the selected **Fleet Item**, or your organization's configuration.
   - **Owning Company**: Select the company for the request. It must match the selected **Fleet Item**, **Service Account**, and **Functional Location** when those records have a company.
   - **Service Account**: Select an active service account. This field is required unless the selected [**Work Order Type** makes it optional](configure-service-account-requirements-work-orders.md).
   - **Functional Location** (optional): Select the service location. Otherwise, the system uses the fleet item's location.
   - **Priority** (optional): Select an active priority.
   - **Description** (optional): Describe the issue or service need.
   - **Due Date** (optional): Enter when the work should be completed.
   - **Price List** (optional): Select the price list for the work order.

1. Select **Save**.

1. Review the information, and then select **Submit** to send the work order request for approval. The status changes to submitted.

## Review work order requests

1. In Field Service, under **Service Delivery**, select **Work Order Requests**.

1. Search for and select a submitted request.

1. Review the request and ensure all required fields are filled in. Save any changes.

1. On the command bar, select **Approve** or **Reject**.

1. If you approve the request, the system automatically creates a work order.

   :::image type="content" source="media/rentals-work-order-requests.png" alt-text="Screenshot of Work order requests with related work orders." lightbox="media/rentals-work-order-requests.png":::

1. Select **Save & Close**.

## Manage approved requests

If you make changes after a work order request is approved and work orders are created, the system doesn't automatically update the work orders or create new ones. You must manually review and adjust the associated work orders as needed.

If you cancel an approved work order request, the system cancels open work orders. Completed, posted, or already canceled work orders aren't changed. However, if you cancel all work orders for an approved work order request, the request status doesn't automatically change. You must manually update the request status if needed.

## Understand the status of work order requests

A work order request status shows the current state of the request and where it is in the service process. After a user submits a work order request, it follows a forward-only lifecycle with system-enforced transitions to keep finance and operations and Field Service consistent. The system doesn't support reverting to a prior status.

When you approve the request, its status is determined by the state of its associated work orders.

|Status    |Description|
|----------|-----------|
|Draft     |A finance and operations or Field Service user is preparing the request and Field Service users can't see it.<br>Or a Field Service user created the request in Field Service, but didn't submit it yet.<br>It can't have any associated work orders. |
|Submitted |A finance and operations user finalized the request and sent it to Field Service for review. Finance and operations users can no longer change the status.<br>Or a Field Service user submitted a draft request that was opened in Field Service.<br>It can't have any associated work orders. |
|Approved  |A Field Service user reviewed and validated the request.<br>One or more work orders are created. |
|Rejected  |A Field Service user declined the request during review.<br>It can't have any associated work orders. |
|Cancelled |A finance and operations or Field Service user withdrew the request due to a customer or business decision.<br>All associated work orders must be cancelled first.|
|Completed |All associated work orders are completed, and the system automatically closes the request.|

## Understand the behavior of work order requests

As work orders progress, Field Service automatically updates the work order request to reflect overall completion.

|Work order state |Work order request status |
|-----------------|--------------------------|
|Any open work orders exist |Approved |
|No open work orders and at least one work order is completed |Completed |
|No open work orders and all work orders are cancelled |Cancelled |

If a work order is reopened after the work order request reaches a terminal state (Completed or Cancelled), the work order request *doesn't* change status.

## Related information

- [View fleet items in Field Service (preview)](rentals-fleet-items.md)
- [Supply Chain Management rental management overview (preview)](/dynamics365/supply-chain/rental-management/rental-management-overview)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
