---
title: Deployment models and inventory
ms.reviewer: wesmith
description: Learn how the different deployment models impact inventory and invoicing in the Dynamics 365 Project Operations integration with Field Service.
ms.date: 01/12/2026
ms.topic: concept-article
author: vhorvathms
ms.author: vhorvath
---

# Deployment models and inventory

When an admin enables the Field Service and Project Operations integration, Project Operations becomes the system that financially interprets work order activity. Field Service remains the system for operational execution. How inventory and accounting are handled depends on your Project Operations deployment model.

## Deployment models and inventory ownership

- [**Project Operations Core (Lite) without Finance**](/dynamics365/project-operations/pro/project-operations-overview-lite): In this model, Project Operations manages project financials and invoicing. Field Service remains the system of record for inventory. [Inventory validation and stock movements](inventory-purchasing-returns-overview.md) occur only within Field Service.

- [**Integrated Project Operations with Finance**](/dynamics365/project-operations/environment/resource-dual-write-overview): In this model, Finance becomes the system of record for inventory and accounting. Field Service inventory management is disabled. Inventory availability is validated against Finance. All financial postings and final invoicing are processed through Finance.

In both deployment models, operational users continue working in Field Service creating work orders, recording labor, and capturing material usage. Project Operations, and Finance when applicable, handle financial interpretation, inventory validation, and invoicing in the background.

## Serialized inventory tracking

With the integrated Project Operations with Finance model, serialized and batch-controlled inventory follows the Dynamics 365 Supply Chain Management tracking-dimension framework. In Supply Chain Management, serial and batch numbers govern how inventory transactions are validated, posted, and traced across operational and financial systems. This approach ensures full traceability from Field Service usage through Project Operations and into Finance.

Key behaviors in serialized and batch-controlled inventory include:

- Serial number and batch number fields appear on the work order product in Field Service when the item is configured with tracking dimensions in Finance.
- These values automatically flow into the Material Usage Log when a technician records usage.
- Finance enforces tracking requirements based on the product’s tracking dimension group, such as requiring serial or batch numbers at issue, receipt, or warehouse processes.
- For serialized products, quantity is automatically restricted to 1, ensuring identity-level accuracy and traceability.

These capabilities ensure that serialized and batch-controlled inventory maintains end-to-end traceability throughout the Field Service → Project Operations → Finance lifecycle.

## Next steps

- [Set up Field Service integration with Project Operations](project-operations-integration-setup.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
