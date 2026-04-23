---
title: What's new in the Field Service integration with Project Operations
ms.reviewer: v-wendysmith
description: Learn what's new in the Dynamics 365 Field Service and Dynamics 365 Project Operations integration.
ms.date: 04/30/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
---

# What's new in the Field Service integration with Project Operations

This article summarizes feature updates, bug fixes, and other improvements.

## April 30, 2026

The Dynamics 365 Field Service and Project Operations Integration package version 1.1.3384.2 contains the following updates.

### Features

- Improved financial record traceability. Actuals and estimates show links to the related work order and specific work order lines and the agreement if the work came from an agreement.

- Clearer inventory experience in the integrated Project Operations with Finance model. In this model, since inventory is managed in Dynamics 365 Supply Chain Management and not Field Service, Field Service hides inventory features. For example, Product Inventory, Transfers, and Adjustments no longer appear. You can still view inventory in Field Service through [warehouses](/dynamics365/field-service/inventory-purchasing-returns-overview#warehouses-and-product-inventory), but you can't change it.

### Bug fixes

- Aligned transaction types with Project Operations so that only relevant and supported transaction types are available in Field Service. In some existing environments, previously available options might still be visible.

- Improved error messages and system monitoring. Work order line error messages are more detailed and actionable to help users quickly identify and fix the issue.

- Reduced multi-currency restrictions for work orders. Additional multi-currency options are supported.

- Expanded project lookup for all billing customers, not just the default project contract billing customer. All customers listed on the associated project-based contract line are available in the project lookup.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
