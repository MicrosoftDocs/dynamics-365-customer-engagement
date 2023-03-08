---
title: Not-to-exceed values on work orders - Dynamics 365 Field Service | MicrosoftDocs"
description: Manage cost expectations of your service accounts by setting up not-to-exceed values on work orders.
ms.date: 02/28/2023
ms.topic: how-to
ms.custom: bap-template
author: jshotts
ms.author: jasonshotts
search.app: 
  - D365CE
  - D365FS
---

# Not-to-exceed values on work orders

Setting financial expectations with customers and vendors is critical for managing the company’s bottom line and maintaining successful relationships. The not-to-exceed capability helps service providers stay within the pre-approved price and cost for work orders.

Different types of not-to-exceed (NTE) values are available. You can automatically apply them to the work order based on the customer, the incident type, or the location of the work.

- [Price](#price): Maximum price a customer accepts without a special approval process. It’s applied to a work order when the order is created with the service provider.
- [Cost](#cost): Maximum cost the service provider accepts without a special approval process. It’s set by the service provider before assigning work to vendors.
- [Price and cost margin](#price-and-cost-margin) sets the price NTE and calculates the cost NTE based on the margin defined. This NTE type is used by service providers who expect to make a margin on a set of work.

Service managers and frontline workers can optionally receive a warning when the not-to-exceed value is near or exceeds the limit, notifying the user they need to act.

A high-level work order process is outlined below.

:::image type="content" source="media/NTE-flow-chart.png" alt-text="Flow chart of a work order process with cost considerations.":::

## Prerequisites

- [Security roles](view-user-accounts-security-roles.md):
  - Field Service – Administrator: All permissions to set up, configure, and edit NTE.
  - Other Field Service roles: Read and use permissions for NTE records.
- [Enable cost calculation or price calculation](configure-default-settings.md#work-order--booking-settings), depending on the NTE type you plan to use.

## Activate not-to-exceed

An admin must [enable the NTE capability in Field Service Settings](configure-default-settings.md#work-order--booking-settings) before they can specify the logic for the NTE records.

## NTE types

Field Service supports three types of NTE. Create NTE records in any combination of types to match your business scenarios.

### Price

Specify the amount for the NTE. Typically, the price is discussed with your customer, so it generally maps to a service account. You can specify more fields to narrow the scope of the NTE record.

:::image type="content" source="media/NTE-price.png" alt-text="Screenshot of a price type NTE record.":::

### Cost

Define the maximum cost and currency for the NTE. You can specify more fields to narrow the scope of the NTE record.

:::image type="content" source="media/NTE-cost.png" alt-text="Screenshot of a cost type NTE record.":::

### Price and cost margin

Specify the total amount and the cost margin of the NTE. This scenario is often used when you work with subcontractors that bill you for the work and you schedule and manage the work for your customers. You can specify more fields to narrow the scope of the NTE record.

:::image type="content" source="media/NTE-price-cost-margin.png" alt-text="Screenshot of a price and cost margin type NTE record.":::

## Create and view not-to-exceed records

Admins can configure NTE records in the Settings area after activating the capability.

:::image type="content" source="media/NTE-list-view.png" alt-text="Screenshot of the list of active NTE values.":::

1. Open the **Settings** area.
1. Go to **General** > **Not-to-exceed**.
1. Choose one of the following options:
   - **New** to create an NTE record.
   - **Delete** to remove an NTE record.
   - Select an existing NTE record to **edit** its properties.

## Application of NTE configuration/Logic of applying NTE

NTEs of type Price and Cost Margin are always selected before NTEs of type Price or Cost. If any Price and Cost Margin NTE is applicable for a work order, Price and Cost NTEs will never be considered for that work order.

NTEs match on the service account first. All other fields have equal priority. If no NTEs exist for a service account, NTEs against billing account are considered next. NTEs with no account mapping are considered last.

## View not-to-exceed on work order forms

NTE values are listed on [work orders](field-service-architecture.md) if the configuration of an NTE record matches a property of a work order. For example, if a work order maps to an incident type or a functional location for which an NTE value is configured.

NTE values on work order are read-only and they'll show a warning when the actual cost or price approaches the defined NTE value or surpasses them. However, you can still update and save work order as usual if the warnings are shown.

### View NTE values

1. Open the **Service** area.
1. Go to **Work Orders**.
1. Open a work order and go to the **Settings** tab.

:::image type="content" source="media/NTE-work-order.png" alt-text="Screenshot of a work order showing NTE values in the Settings tab.":::

## Not-to-exceed on Field Service mobile

Technicians that use the Field Service Mobile app can see the not-to-exceed value on the work order. The system shows warning icons to users when they get close to the specified NTE value or if they surpass it.

However, you can still save work orders when ignoring the warning.

Using the [Field Service Mobile application in offline mode](mobile-power-app-system-offline.md) takes the NTE values from the most recent synchronization into account.

## Next steps

- [Create a work order to coordinate and schedule resources and activities](create-work-order.md)
- [Create work order types (Field Service)](create-work-order-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
