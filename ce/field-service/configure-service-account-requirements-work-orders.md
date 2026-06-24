---
title: Configure service account requirements for work orders
description: Learn how to configure whether Service Account is required for work orders by Work Order Type in Dynamics 365 Field Service.
ms.date: 06/24/2026
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
ms.custom: bap-template
---

# Configure service account requirements for work orders

Service Account identifies the account receiving service for a work order. Many Field Service processes use Service Account to provide service address, billing defaults, price list, tax settings, service territory, work instructions, customer assets, and other account-specific context.

Some service processes use a different primary context. For example, B2C service might center on an individual contact, internal maintenance might center on an internal team or functional location, and integrations might represent customer context through a project, company, party, or external system reference.

Use Work Order Type settings to configure whether Service Account is required.

## When to require Service Account

Require Service Account when the work order process depends on account-derived context.

Examples:

- B2B onsite service
- Account-specific billing defaults
- Service territory derived from an account
- Work instructions stored on the account
- Customer assets associated with an account location
- Entitlements, agreements, or reporting that depend on account context

## When to allow work orders without Service Account

Allow work orders without Service Account when the work order type supports service scenarios where another record or process provides the primary context.

Examples:

- B2C service for individual customers
- Internal maintenance
- Project-centered work
- Functional-location-centered work
- Integrations where the servicing context can come from a party, company, project, or external system
- Mixed work order types that can include a Service Account for some work orders and omit it for others

## Configure a work order type

1. In Field Service, change to the **Settings** area.
1. Under **Work Orders**, select **Work Order Types**.
1. Create or open a work order type.
1. Set whether **Service Account** is required.
1. Select **Save & Close**.

## Create a work order without Service Account

1. Create a work order.
1. Select a Work Order Type where Service Account isn't required.
1. Leave Service Account blank.
1. Enter the remaining details required by your process, such as service location, contact, price list, billing context, service territory, functional location, project, or instructions.
1. Save the work order.

## Important considerations

- If Service Account is selected, Field Service can use account-derived context such as service address, billing defaults, territory, tax settings, work instructions, and related customer information.
- If Service Account isn't selected, provide the required service, billing, location, scheduling, and integration context through the work order fields and related records that apply to the scenario.
- Review forms, business rules, flows, integrations, reports, and custom plug-ins that reference Service Account.
- Require Service Account for work order types that rely on agreements, entitlements, customer assets, or billing rules that require account context.

## Troubleshooting

### I can't save a work order without Service Account

Confirm that the selected Work Order Type allows work orders without Service Account. Also check custom business rules, Power Automate flows, plug-ins, or required form fields that might require Service Account.

### Account-derived fields aren't populated

If Service Account is blank, the work order can't inherit details from an account. Enter those details manually or configure your process to derive them from another source.

### My integration needs customer or company context

Update the integration to check the selected Work Order Type and handle work orders with or without Service Account. Make sure the integration receives any required customer, company, location, billing, tax, project, or party context from the appropriate field or related record.

## Next steps

- [Create a work order](create-work-order.md)
- [Create a work order type](create-work-order-types.md)
- [Create work orders using Power Automate](create-work-order-flow.md)
- [Create work orders using the Dataverse Web API](create-work-order-api-example.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
