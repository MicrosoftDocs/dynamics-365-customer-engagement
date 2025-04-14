---
title: Use trades to group services
description: Learn how to configure and use trades in Dynamics 365 Field Service.
ms.date: 04/10/2025
ms.reviewer: mhart
ms.topic: how-to
ms.custom: bap-template
author: jshotts
ms.author: jasonshotts
---

# Use trades to group services

Trades are the types of services your organization provides to your customers. In Field Service, use trades to group [incident types](configure-incident-types.md) together. Configure trades and trade coverages to simplify the creation of [work orders](create-work-order.md) and the services that are provided in a functional location or for a service account, or for accounts at locations. Using trades adds another layer of details to create reports and filter charts on reports.

Trade coverage defines which trades are covered for an account or a location to ensure the right level of service is provided. For example, if a location doesn’t have AC (air conditioning), it shouldn’t be possible to create an incident related to the AC system for that location. The same logic applies to accounts if the service contract doesn’t include HVAC (heating, ventilation, and air conditioning) maintenance.

## Prerequisites

- To use trades, an administrator must enable [**Trades**](configure-default-settings.md#features-settings).
- To use trade coverages, an administrator must enable [**Trades** and **Trade Coverages**](configure-default-settings.md#features-settings).

## Create trades

Before you can map incident types to a trade, an admin must define the trades that are available for your business.

1. Go to **Settings** > **General** > **Trades**.
1. Select **New**.
1. **Name** the trade and **Save** it.

   :::image type="content" source="media/trades-list.png" alt-text="Screenshot of a list of trades.":::

## Map trades to incident types

To group incident types by trade and create reports based on trades, an admin must configure the mapping. An incident type can map to one trade only.

1. Go to **Settings** > **Work Orders** > **Incident Types**.
1. Open the incident type record you want to map to a trade.
1. On the **Details** tab, choose the value in the **Trade** field.

   :::image type="content" source="media/trades-incident-type.png" alt-text="Screenshot of an incident type record with a mapped trade.":::

## Configure trade coverages

Choose coverage and exclusions to define the account or functional location that a trade covers or doesn't cover.

1. Go to **Settings** > **General** > **Trade coverages**.
1. Select **New**.
1. Choose the **Type** for the trade.

   - **Coverage** defines the account or functional location that a trade covers.
   - **Exclusion** removes trade coverage for the account or functional location.

1. Choose a trade and select an account, a functional location, or both.
1. **Save** the trade coverage.

   :::image type="content" source="media/trade-coverages-list.png" alt-text="Screenshot with list of trade coverages.":::

Alternatively, you can go to your **Accounts** page and on the **Trade Coverages** tab, configure trade coverage from there. That way you can see trade coverage with your service accounts and the trade coverage is automatically mapped to the right account. The **Trade Coverages** tab is available for certain accounts such as Customer.

### Trade coverage example

Trade coverage

|Account  |Trade |Location  |Type|
|---------|---------|---------|---|
|Contoso    | Plumbing        |   -      | Coverage |
|Contoso     | HVAC        |  Washington       | Coverage |
| -    |  Plumbing         | California      | Coverage |
| -    |   Roofing       |  Nevada      | Coverage |
|Contoso    | Roofing       |   Nevada      | Exclusion |

Work order

|     Account              |     Trade       |     Location         |     Validation     |     Reason                                                                                                       |
|--------------------------|-----------------|----------------------|--------------------|------------------------------------------------------------------------------------------------------------------|
|     Contoso              |     Plumbing    |     Arizona          |     Covered        |     Plumbing for Contoso isn't restricted to a functional location.                                             |
|     Contoso              |     Roofing     |     Washington       |     Not covered    |     Roofing for Contoso has no trade coverage defined.                                                           |
|     Contoso              |     HVAC        |     Seattle          |     Covered        |     HVAC for Contoso is covered in Washington state and Seattle is in Washington state.                        |
|     Northwind Traders    |     Plumbing    |     San Francisco    |     Covered        |     Plumbing is covered regardless of the service account in California and San Francisco is in California.    |
|     Northwind Traders    |     Roofing     |     Los Angeles      |     Not covered    |     Roofing, regardless of the service account, is only covered in Nevada. Los Angeles is in California.       |
|     Contoso    |     Roofing     |     Las Vegas     |     Not covered    |     Roofing for Contoso has an exclusion defined for Nevada. Las Vegas is in Nevada.       |

## Next steps

- [Create a work order to coordinate and schedule resources and activities](create-work-order.md)
- [Create work order types (Field Service)](create-work-order-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
