---
title: Not-to-exceed values on work orders - Dynamics 365 Field Service | MicrosoftDocs"
description: Manage cost expectations of your service accounts by setting up not-to-exceed values on work orders.
ms.date: 08/16/2024
ms.topic: how-to
ms.custom: bap-template
author: jshotts
ms.author: jasonshotts
---

# Not-to-exceed values on work orders

Setting financial expectations with customers and vendors is critical for managing the company’s bottom line and maintaining successful relationships. The not-to-exceed capability helps service providers stay within the preapproved price and cost for work orders.

Field Service supports three types of not-to-exceed (NTE) values.

- **Price**: Maximum price a customer accepts without a special approval process. It’s applied to a work order when the order is created with the service provider.
- **Cost**: Maximum cost the service provider accepts without a special approval process. It’s set by the service provider before assigning work to vendors.
- **Price and cost margin**: The price NTE and the cost NTE are set based on the margin defined. This NTE type is used by service providers who expect to make a margin on a set of work.

You can automatically apply them to the work order based on the customer, the incident type, or the location of the work. Service managers and frontline workers can optionally receive a warning when the not-to-exceed value is near or exceeds the limit, notifying the user they need to act.

**Price and cost margin** are always selected before price or cost NTEs. If any **Price and cost margin** NTE is applicable for a work order, **Price** and **Cost** NTEs are never considered for that work order.

NTEs match on the service account first. All other fields have equal priority. If no NTEs exist for a service account, NTEs against billing account are considered next. NTEs with no account mapping are considered last.

The following image shows the high-level work order process.

:::image type="content" source="media/NTE-flow-chart.png" alt-text="Flow chart of a work order process with cost considerations.":::

## Prerequisites

- [Security roles](users-licenses-permissions.md):
  - **Field Service – Administrator**: All permissions to set up, configure, and edit NTE.
  - Other Field Service roles: Read and use permissions for NTE records.
- [**Not-To-Exceed**](configure-default-settings.md#features-settings) setting enabled.
- [**Calculate cost** and/or **Calculate price**](configure-default-settings.md#work-order--booking-settings) enabled, depending on the NTE type you plan to use.

## Create and view not-to-exceed records

Admins can configure NTE records after enabling the capability. After NTE records are created, you can edit or delete them.

:::image type="content" source="media/NTE-list-view.png" alt-text="Screenshot of the list of active NTE values.":::

1. In Field Service, select the **Settings** area.
1. Go to **General** > **Not-to-exceed**.
1. Select **New**.
1. Select the **Type**: [Price](#create-a-price-nte), [Cost](#create-a-cost-nte), or [Price and cost margin](#create-a-price-and-cost-margin-nte). Enter the information.
1. Select **Save**. Add other NTE records if needed.

### Create a price NTE

Specify the amount for the NTE. Typically, the price is discussed with your customer, so it generally maps to a service account. You can specify more fields to narrow the scope of the NTE record.

:::image type="content" source="media/NTE-price.png" alt-text="Screenshot of a price type NTE record.":::

### Create a cost NTE

Define the maximum cost and currency for the NTE. You can specify more fields to narrow the scope of the NTE record.

:::image type="content" source="media/NTE-cost.png" alt-text="Screenshot of a cost type NTE record.":::

### Create a price and cost margin NTE

Specify the total amount and the cost margin of the NTE. This scenario is often used when you work with subcontractors that bill you for the work and you schedule and manage the work for your customers. You can specify more fields to narrow the scope of the NTE record.

:::image type="content" source="media/NTE-price-cost-margin.png" alt-text="Screenshot of a price and cost margin type NTE record.":::

## View not-to-exceed on work order forms

NTE values are listed on [work orders](work-order-experience.md) if the configuration of an NTE record matches a property of a work order. For example, if a work order maps to an incident type or a functional location for which an NTE value is configured.

NTE values on work orders are read-only and they show a warning when the actual cost or price approaches the defined NTE value or surpasses them. However, you can still update and save a work order as usual if the warnings are shown.

## View not-to-exceed on Field Service mobile

Technicians who use the Field Service mobile app can see the not-to-exceed value on the work order. The system shows warning icons to users when they get close to the specified NTE value or if they surpass it.

However, you can still save work orders when ignoring the warning.

## Applied amount on work orders
Using the [Field Service mobile app in offline mode](mobile/work-offline.md) takes the NTE values from the most recent synchronization into account.

## View applied amount on work orders

The work order not-to-exceed's applied amount represents the actual NTE amount applied on the work order. The not-to-exceed source informs you where the defined amount came from. If the applied amount is manually set, the source is set as *user specified*. Without manual edits, the system selects the applicable NTE record and copies its amount into the applied amount on the work order. In this case, the source is set to *system specified* and the work order NTE references the selected NTE record.

If you reset a manually entered NTE amount on the work order form, the source changes back to *system specified*. The applied amount updates to the amount from the system selected NTE.

Work order NTE should be primarily interacted with by the system during NTE selection and by users on the work order form. Customization on work order NTE could interfere with the automated behavior.

## Next steps

- [Create a work order to coordinate and schedule resources and activities](create-work-order.md)
- [Create work order types](create-work-order-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
