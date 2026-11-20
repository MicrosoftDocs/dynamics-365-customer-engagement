---
title: Inventory with the Field Service and Project Operations integration
description: Learn how the different deployment models impact inventory in the Dynamics 365 Project Operations integration with Field Service.
ms.date: 11/05/2026
ms.topic: concept-article
author: vhorvathms
ms.author: vhorvath
ms.reviewer: wesmith
---

# Inventory with the Field Service and Project Operations integration

When an admin enables the Field Service and Project Operations integration, Project Operations becomes the system that financially interprets work order activity. Field Service remains the system for operational execution. How the integration handles inventory and accounting depends on your [Project Operations deployment model](project-operations-integration-deployment-models.md).

## Inventory with Project Operations Core

When you use Project Operations Core without Finance, Field Service remains the system of record for Field Service inventory.

- Field Service manages inventory availability.
- Field Service inventory validation continues to apply.
- Field Service manages inventory transfers, adjustments, and other inventory processes.
- Technicians record product usage from the work order.
- Project Operations financially interprets the material usage against the associated project.

This model is appropriate when Field Service is responsible for operational inventory or when you use another ERP system outside the Microsoft Finance and Supply Chain Management integration.

## Inventory with Project Operations integrated with ERP

When the integration includes Dynamics 365 Finance and Supply Chain Management, inventory ownership moves to Finance and Supply Chain Management.

- Finance and Supply Chain Management become the system of record for inventory. 
- Field Service inventory management capabilities are disabled or hidden.
- Inventory availability is validated against Finance and Supply Chain Management.
- Technicians continue to record product usage in Field Service.
- Product usage is captured for downstream project, inventory, and financial processing.
- Finance and Supply Chain Management process final inventory and accounting transactions.

In the integrated model, Field Service no longer exposes inventory-management experiences such as product inventory, transfers, and adjustments. You can still view warehouse information where applicable, but you manage inventory changes through Finance and Supply Chain Management.

## Estimated materials and material usage logs

When a technician enters an estimated quantity for a work order product, the integration creates the corresponding material estimate in Project Operations. In environments integrated with Finance, this information can also create downstream demand forecast information. Project teams can see expected material usage before actual consumption is recorded.

When a technician records materials or services on a work order as used, the system automatically creates a material usage log (MUL). Project Operations creates the appropriate project financial transactions. In an integrated Finance deployment, the resulting approved financial and inventory information continues into Finance and Supply Chain Management for downstream processing.

Technicians continue to work in Field Service while the associated project, inventory, and financial systems process the transaction in the background.

## Serialized and batch-controlled products

With the Project Operations integrated with ERP model, serialized and batch-controlled inventory follows the Dynamics 365 Supply Chain Management tracking-dimension framework. In Supply Chain Management, serial and batch numbers govern how inventory transactions are validated, posted, and traced across operational and financial systems. This approach ensures full traceability from Field Service usage through Project Operations and into Finance.

Key behaviors in serialized and batch-controlled inventory include:

- Serial number and batch number fields appear on the work order product in Field Service when you configure the item with tracking dimensions in Finance.
- Technicians capture the required tracking information when recording product usage.
- These values automatically flow into the Material Usage Log.
- Finance enforces tracking requirements based on the product’s tracking dimension group, such as requiring serial or batch numbers at issue, receipt, or warehouse processes.
- For serialized products, quantity is automatically restricted to 1, ensuring identity-level accuracy and traceability.

These capabilities ensure that serialized and batch-controlled inventory maintains end-to-end traceability throughout the Field Service → Project Operations → Finance lifecycle.

## Next steps

- [Install the Field Service and Project Operations integration](project-operations-integration-install.md)
- [Set up Field Service integration with Project Operations](project-operations-integration-setup.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
