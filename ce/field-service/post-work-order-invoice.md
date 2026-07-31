---
title: Post a work order and generate an invoice
description: Learn how to post a work order and generate an invoice for used products and services in Dynamics 365 Field Service.
ms.date: 06/26/2026
author: vhorvathms
ms.author: vhorvath
ms.topic: how-to
ms.custom: bap-template
---

# Post a work order and generate an invoice

When a technician completes a work order in the field and a dispatcher or back-office service manager reviews and approves it, they close and post the work order to finalize it for billing. Posting the work order transitions it into a financial state where you can no longer edit it. This process finalizes the work order and triggers the configured invoice and financial processing. Use these transactions to create the customer invoice based on the work order's price list, billing type, and recorded usage.

> [!NOTE]
> System configurations in [Field Service Settings](configure-default-settings.md) affect both invoice and actuals creation. Review these settings before you post your first work order.

## Post a work order

You need the **Field Service - Administrator** or **Field Service - Dispatcher** security role to post a work order.

1. In Field Service, change to the **Service** area.

1. In the **Scheduling** section, select **Work Orders**.

1. Open the completed work order you want to post. You can only post work orders that have a system status of **Completed**.

1. Confirm that all related bookings are in a **Completed** or **Canceled** booking status.

1. Review the used products and services in the **Products and services** section. Confirm the quantities, durations, and billing values are accurate, including **Quantity to Bill** for products and **Duration to Bill** for services. Only lines with a **Line Status** of *Used* are billed. Review the **Estimate Subtotal** and **Subtotal** values.

1. Confirm the work order has the correct [price list](create-price-list.md) and billing information so the system can calculate costs.

1. Change the **System Status** to **Posted**, and then select **Save**.

The system processes the work order and performs the following actions automatically.

## What posting triggers

When you change a work order's system status to *Posted*, several processes run:

- **Invoice generation**: The system creates an invoice record linked to the work order's [billing account](accounts.md). The system generates the invoice from the information on the work order, including products, services, and service tasks.
- **Actuals creation**: The system generates *Actuals* records that capture time and cost data related to work order bookings. The system creates sales actuals for billed products and services after you confirm the generated invoice.
- **Closed By and Closed On**: The system populates the **Closed By** and **Closed On** fields on the work order.

> [!NOTE]
> Posting doesn't adjust inventory. For inventory-type products, the system deducts the used quantity from the specified warehouse earlier, when the technician sets a work order product's **Line Status** to *Used*. Learn more in [Overview of inventory, purchasing, and returns](inventory-purchasing-returns-overview.md).

## How invoice lines map to work order products and services

The invoice that the system generates reflects the products and services used from the work order. The following table shows how work order line items map to invoice line items.

| Work order line item | Invoice line detail | Billing basis |
|---|---|---|
| Work order product (Line Status = *Used*) | Invoice product line | **Quantity to Bill** &times; unit price from the price list |
| Work order service (Line Status = *Used*) | Invoice service line | **Duration to Bill** &times; hourly rate from the price list |
| Travel charge (if configured) | Invoice product line | Travel charge amount based on [travel charge settings](travel-charges.md) |

Only items with a **Line Status** of *Used* appear on the invoice. Items with a status of *Estimated* aren't included.

The invoice uses the price list assigned to the work order. If an [entitlement](work-order-entitlements.md) applies, the system calculates any discount or coverage before generating the invoice line amounts.

## Review and confirm an invoice

After posting a work order, review the generated invoice.

1. Open the posted work order.

1. In the **Related** tab, select **Invoices** to find the generated invoice.

1. Open the invoice and review the line items. Verify the products, services, quantities, and amounts are correct.

1. When you're satisfied with the invoice, confirm it to finalize the billing record.

## Finance integration options

Dynamics 365 Field Service supports multiple approaches for connecting service execution with downstream financial and ERP processes:

- **Dynamics 365 Finance with Project Operations**: Organizations can use the [Dynamics 365 Project Operations](project-operations-integration.md) integration to connect Field Service transactions with project financials, including estimates, actuals, costs, billable transactions, and invoicing. This option can be used with Dynamics 365 Finance or as the project financial layer before integrating with another ERP system.
- **Dynamics 365 Business Central**: Organizations using Business Central can use the available integration to connect Field Service invoices and inventory transactions with their accounting processes.
- **Third-party ERP systems**: Organizations can also integrate Field Service directly with another ERP system by using [Power Automate](/power-automate/getting-started) and Dataverse APIs. The integration design can use work order transactions, invoices, or other Field Service data based on the organization’s financial architecture and system-of-record requirements.

Learn more in [Overview of integrations](field-service-integration-overview.md).

## Troubleshoot common posting issues

| Issue | Possible cause | Resolution |
|---|---|---|
| Work order doesn't change to *Posted* status | Not all bookings are completed or canceled | Open each booking and set the status to **Completed** or **Canceled** |
| Invoice isn't generated after posting | Invoice generation is turned off in Field Service Settings | Go to **Settings** > **Field Service Settings** > **Work Order / Booking** and verify the invoice creation setting |
| Invoice amounts are incorrect | Price list is missing or products aren't in the price list | Verify the work order has a valid price list and that all used products and services are included in it |
| Inventory levels aren't updated | Product type isn't set to *Inventory* | Open the product record and verify the **Field Service Product Type** is set to **Inventory** |
| Actuals records are missing | Field Service Settings aren't configured for actuals creation | Check [Field Service Settings](configure-default-settings.md) for actuals configuration |

## Next steps

- [Work order lifecycle and system statuses](work-order-status-booking-status.md)
- [Create products or services for work orders](create-product-or-service.md)
- [Overview of inventory, purchasing, and returns](inventory-purchasing-returns-overview.md)
- [Overview of integrations](field-service-integration-overview.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
