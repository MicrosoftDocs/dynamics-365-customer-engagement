---
title: Configure Field Service settings for common scenarios
description: Learn which Dynamics 365 Field Service settings to review together for common scenarios, common configuration mistakes to avoid, and how to troubleshoot settings.
ms.date: 06/24/2026
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.custom: bap-template
---

# Configure Field Service settings for common scenarios

The **Field Service Settings** page contains many options. The following scenarios highlight which settings to review together so that work orders, agreements, and billing behave as you expect. Learn more about description of each individual setting in [Set defaults for work orders, bookings, the schedule board, and agreements](configure-default-settings.md).

## Set up work order costing and billing

If you want work orders to track costs and generate invoices, review these settings on the **Work Order / Booking** tab together:

1. Set **Calculate Price** to *Yes* to keep pricing fields and invoice generation enabled.
1. Set **Calculate Cost** to *Yes* to add cost tracking on work order products and services.
1. Set **Work Order Invoice Creation** to control whether invoices are generated automatically when a work order is set to *Closed - Posted*.
1. If you use tax codes, confirm **Calculate Tax** is set to *Yes*. Learn more in [Set up tax codes](set-up-tax-codes.md).

> [!IMPORTANT]
> Setting **Calculate Price** to *No* removes all pricing fields and disables invoice generation. Only choose *No* if your organization handles billing outside Field Service.

## Automate work orders and invoices from agreements

To automatically generate work orders and invoices from agreements, review the **Agreement** tab:

1. Set **Auto Generate Work Order for Agreement Booking** to *Yes*.
1. Use **Generate Booking Dates X Months in Advance** and **Generate Invoice Dates X Months in Advance** to control how far ahead records are created.
1. Set **Record Generation Timing** to a time outside of business hours so that records aren't generated while dispatchers are actively scheduling.

Learn more in [Set up agreements](set-up-customer-agreements.md).

## Standardize record numbering

To apply consistent, unique numbering to work orders and other entities, opt in to auto-numbering during a period of no activity, then configure a simple format such as `WO-{SEQNUM:6}` on the **Auto-Numbering** dialog. For advanced formats, configure the field in [Power Apps](https://make.powerapps.com).

## Common configuration mistakes

Avoid these common mistakes when you configure Field Service Settings:

- **Opting in to auto-numbering during business hours.** Record creation can fail during the initial opt-in. Enable auto-numbering when there's no activity in the application.
- **Turning off Calculate Price to "hide" pricing.** This action disables invoicing entirely. To hide pricing fields without losing invoicing, customize the form instead.
- **Expecting the default warehouse to populate every work order product.** The **Default Warehouse** value is only applied when a warehouse is required and left blank - it doesn't overwrite warehouses you set manually.
- **Setting Record Generation Timing during the work day.** Agreement-generated work orders can appear in the middle of active scheduling. Choose an off-hours time.
- **Editing advanced auto-number formats in the Field Service dialog.** Formats with placeholders after `{SEQNUM}` must be edited in Power Apps; the dialog only supports simple formats.

## Troubleshooting settings

If settings don't behave as expected, check the related setting before opening a support request:

- **Changes don't appear:** Confirm you selected **Save** on the correct tab. Each tab saves independently.
- **A setting is missing or read-only:** Verify you have the **Field Service - Administrator** security role.
- **Addresses aren't geocoded:** Confirm **Auto Geo Code Addresses** is enabled on the **Other settings** tab.
- **Date window fields are missing on work orders:** Review the **Pre/Post Booking Flexibility Date Field Population** agreement setting.

Learn more in the troubleshooting articles listed in [Related information](#related-information).

## Related information

- [Set defaults for work orders, bookings, the schedule board, and agreements](configure-default-settings.md)

If you run into issues when configuring Field Service settings, see the following troubleshooting articles:

- [A user has no roles](/troubleshoot/dynamics-365/field-service/administration/user-has-no-roles)
- [Can't install Field Service](/troubleshoot/dynamics-365/field-service/administration/cant-install-field-service)
- [Disable automatic geocoding](/troubleshoot/dynamics-365/field-service/administration/disable-auto-geo-code)
- [Date window fields are missing](/troubleshoot/dynamics-365/field-service/administration/date-window-fields-missing)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
