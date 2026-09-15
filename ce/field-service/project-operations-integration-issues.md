---
title: Known issues and limitations
ms.reviewer: wesmith
description: Learn about the known issues and limitations with the Field Service and Project Operations integration.
ms.date: 08/25/2026
ms.topic: article
author: vhorvathms
ms.author: vhorvath
---

# Known issues and limitations

## Limitations

- The integration doesn't support **Discount amounts**, but it supports **Discount percentages**. The integration converts existing **Discount amounts** that Field Service created before the integration to **Discount percentages**. Due to rounding, converted values might vary slightly.
- The integration doesn't support **Estimated discounts**.
- The integration doesn't support fee synchronization from Field Service to Project Operations. Although Project Operations supports fees, the integration doesn't transfer them.
- The integration doesn't support migration from the legacy finance and operations integration.
- The integration doesn't support linking an agreement to a project task. For more information, see [link agreements to projects](project-operations-integration-work-order.md#link-a-project-to-an-agreement).
- The mobile offline profiles that the integration installs are active regardless of whether the [Field Service Integration with Project Operations toggle](project-operations-integration-setup.md#enable-the-integration) is enabled or not. These profiles override the out-of-the-box profiles.
- If the technician updating the work order product or work order service doesn't already have an associated *BookableResource*, the system automatically creates one to support integration and ensure accurate tracking of generated actuals. To maintain data accuracy, consider proactively [creating a BookableResource](set-up-bookable-resources.md) for each user who creates or updates work order lines. If you're using an environment that is integrated with finance and operations, add the Company field on the *BookableResource*.
- By design, work order services use the [*Material* transaction class](/dynamics365/project-operations/actuals/businesstransactions) and appear in Finance as *Item* transactions.
- Project Operations doesn't support project [production orders](/dynamics365/business-central/production-about-production-orders) in an integrated Project Operations with Finance environment. However, consumption of bill of material items or finished goods through standard inventory scenarios is still supported.
- Manage project tasks in Project Operations as it requires a Project Operations license.
- Manage labor estimates through the Project Operations task grid.
- The summary section of the **Work Orders** page in Field Service doesn't reflect time entries.
- Hourly rate information is concealed on the *BookableResource* record within Field Service.
- Time off requests aren't synchronized between Field Service and Project Operations.

## Known issues

### Unable to approve Material Usage Log for stocked products

When you approve material usage records for stocked products, you might receive an error. This error occurs because Project Operations makes an asynchronous call to a virtual table, which leads to a failure when retrieving Project On-Hand inventory data. 

For more information, see [Configuring the asynchronous threshold for approval sets](/dynamics365/project-operations/approvals/approval-sets#configuring-the-asynchronous-threshold-for-approval-sets).

To resolve the issue, complete the following steps:

1. In Project Operations, go to the **Settings** area.

1. Select **Parameters** and open the only record.

1. Under the **Modern Approvals** section, enter a value greater than zero in the **Background Approval Threshold** field and then save the record.

1. Approve the Material Usage Logs.

All future Material Usage Logs are automatically approved if the **Auto-Approve Project Approval** setting is enabled.

### Cost Actuals might occasionally differ from Cost Journal Lines

If you're using the [Integrated Project Operations deployment model](project-operations-integration-inventory.md), updates to Cost Actuals can originate from Finance, resulting in extended amounts that differ from their parallel Cost Journal Lines. 

This difference is expected and results from costing parameters in Finance that require adjustments to Actuals. For example, weighted averages or first-in, first-out (FIFO) costs can be different from the more static cost on a price list. Learn more in [Inventory cost for material usage](/dynamics365/project-operations/procurement/stock-material-reservation#inventory-cost-for-material-usage).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
