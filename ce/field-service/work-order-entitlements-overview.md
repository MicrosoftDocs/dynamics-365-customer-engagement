---
title: Entitlements for work orders overview
description: Learn about entitlements for work orders in Dynamics 365 Field Service.
ms.date: 07/10/2024
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: lmasieri
ms.author: lmasieri
---

# Entitlements for work orders overview

Entitlements for work orders allow field service organizations to dynamically apply price lists and discounts to work order products and services based on work order attributes and date range factors. Entitlements for work orders parallel how organizations might offer case entitlements in Dynamics 365 Customer Service. Entitlements can't change the cost of a product or service, only the price.

Entitlements can be applied to work orders based on:

- Billing account
- Service account
- Specific products and services
- Specific customer assets
- Customer asset categories
- Incident types

Entitlements for work orders don't support quantity-based and limit-based entitlements. For example, it's not possible to create an entitlement for 10 work orders or free service for the first hour.

## Entitlement applications

You can also create an entitlement with an entitlement application, which adds more constraints on when an entitlement should apply to work order products and services. Entitlement applications include:

- **Service Account:** If the service account here matches the work order service account, then the entitlement is applied to all work order products and services.

- **Customer Asset:** If the customer asset value here matches the customer asset on the work order product or service, then the entitlement is applied to that work order product or service.

- **Asset Category:** If the asset category value here matches the asset category on the work order product or service, then the entitlement is applied to that work order product or service.

- **Incident Type:** If the incident type here matches the work order incident type on the work order product or service, then the entitlement is applied to that work order product or service.

Entitlement applications use AND logic. This means that if you specify a service account and an incident type then both need to be present on the work order to apply.

## Multiple entitlements

You can apply multiple entitlements to a single work order product or service. Entitlements can be applied based on different work order and work order product and service attributes. For example, an entitlement can apply based on a work order billing account or a customer asset category. To learn how to create an entitlement for both of these scenarios, go to [Create entitlements for work orders](work-order-entitlements.md).

In such cases, all applicable entitlements show as options in the **Entitlement** lookup field for the work order. However, the system selects one entitlement by default. The system first looks at the **Entitlement Prioritization** values of all applicable entitlements and selects the one with the highest priority (1 being the highest priority). Any priority value is greater than a blank priority value.

If no priority values exist or priority values are equal, the system selects the most specific entitlement. For example, an entitlement is set up based on a billing account. A second entitlement is set up based on a billing account and a customer asset category. In this case, the second entitlement is selected because it's more specific, since it contains two factors.

You can manually override or disable an entitlement.

For simpler scenarios, administrators can use the relationship between work order types, incident types, and price lists. Selecting an incident type can populate a work order type, and populating a work order type can populate a price list on the work order. Configure these scenarios during the [incident type](configure-incident-types.md) and [work order type](create-work-order-types.md) setup. Adding a price list to a work order populates the price lists on work order products and services by default, but can be manually edited as needed.

## Next steps

- [Create entitlements for work orders](work-order-entitlements.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
