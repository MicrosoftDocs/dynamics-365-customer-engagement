---
title: Use trades to group services
description: Learn how to configure and use trades in Dynamics 365 Field Service.
ms.date: 10/10/2022
ms.reviewer: mhart
ms.topic: article
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Use Trades to group services

Trades let you group [incident types](configure-incident-types.md) in your preferred way. Configure trades and trade coverages to simplify the creation of [work orders](create-work-order.md) and the services that are provided in a functional location or for a service account, or for accounts at locations. Using trades adds another layer of details to create reports and filter charts on reports.

## Activate Trade for your org

An admin must enable the capability before creating trades and trade coverages.
  
1. Go to **Settings** > **General** > **Field Service Settings** > **Work Order/Booking** tab.
2. Set **Trade** to **On**.
3. New settings options **Trades** and **Trade** coverages appear in the **General** section.

## Create trades

Before you can map incident types to a trade, an admin must define the trades that are available for your business.

1. Go to **Settings** > **General** > **Trades**.
2. Select **New**.
3. **Name** the trade and **Save** it.

:::image type="content" source="media/trades-list.png" alt-text="Screenshot of a list of trades.":::

## Map trades to incident types

Group incident types by trade and create reports based on trades, an admin must configure the mapping. An incident type can map to one trade only.

1. Go to **Settings** > **Work Orders** > **Incident Types**.
2. Open the incident type record you want to map to a trade
3. On the **Details** tab, choose the value in the **Trade** field.

:::image type="content" source="media/trades-incident-type.png" alt-text="Screenshot of an incident type record with a mapped trade.":::

## Configure trade coverages

Trade coverage defines which trades are covered for an account or a location to ensure the right level of service is provided. For example, if a location doesn’t have air conditioning, it shouldn’t be possible to create an incident related to the AC (air conditioning) system for that location. The same logic applies to accounts if the service contract doesn’t include HVAC (heating, ventilation, and air conditioning) maintenance.

1. Go to **Settings** > **General** > **Trade coverages**.
2. Select **New**.
3. Choose a trade and select an account, a functional location, or both.
4. **Save** the trade coverage.

:::image type="content" source="media/trade-coverages-list.png" alt-text="Screenshot with list of trade coverages.":::

Alternatively, you can also show Trade Coverage as a related entity to your Accounts and configure trade coverage from there. That way you can see trade coverage in conjunction with your service accounts and the trade coverage is automatically mapped to the right account.

## Validation of work orders

Depending on the configuration of trade coverages, new work orders will check if the selected account or functional location are covered.
If trade coverage is set to not cover a trade, a warning will show on the work order. However, you can still save the work order. If no trade coverage is defined, no warnings will show.
The validation interprets service accounts and hierarchies in functional locations.

:::image type="content" source="media/trades-work-order-validated.png" alt-text="Screenshot of a work order with a trade validation.":::

> [!NOTE]
> If no trade coverage is defined for a trade, the system assumes that the trade is covered for all parameters. Work order won’t show any warnings if trade coverage isn’t defined.

### Trade coverage example

Trade coverage

|Account  |Trade |Location  |
|---------|---------|---------|
|Contoso    | Plumbing        |   -      |
|Contoso     | HVAC        |  Washington       |
| -    |  Plumbing         | California      |
| -    |   Roofing       |  Nevada      |

Work order

|     Account              |     Trade       |     Location         |     Validation     |     Reason                                                                                                       |
|--------------------------|-----------------|----------------------|--------------------|------------------------------------------------------------------------------------------------------------------|
|     Contoso              |     Plumbing    |     Arizona          |     Covered        |     Plumbing for Contoso is not restricted to a functional location.                                             |
|     Contoso              |     Roofing     |     Washington       |     Not covered    |     Roofing for Contoso has no trade coverage defined.                                                           |
|     Contoso              |     HVAC        |     Seattle          |     Covered        |     HAVC for Contoso is covered in Washington state and Seattle is in Washington state.                        |
|     Northwind Traders    |     Plumbing    |     San Francisco    |     Covered        |     Plumbing is covered regardless of the service account in California and San Francisco is in California.    |
|     Northwind Traders    |     Roofing     |     Los Angeles      |     Not covered    |     Roofing, regardless of the service account, is only covered in Nevada. Los Angeles is in California.       |
