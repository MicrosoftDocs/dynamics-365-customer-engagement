---
title: Project Operations deployment models
description: Project Operations deployment models shape inventory, invoicing, and accounting in Dynamics 365 Field Service integrations.
ms.date: 11/17/2026
ms.topic: concept-article
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
---

# Project Operations deployment models

The Field Service and Project Operations integration supports different deployment models depending on whether your organization uses Dynamics 365 Finance and Supply Chain Management.  

Before you configure the integration, identify which Project Operations deployment model is installed in your environment. The deployment model determines where inventory, accounting, invoicing, and project financial processing occur.

Field Service remains the application for operational service execution in both supported models. Technicians and dispatchers continue to work with work orders, bookings, time, products, services, and other Field Service records. Project Operations provides the project and financial context for that work, while Finance and Supply Chain Management provide additional accounting and inventory capabilities when they are part of the deployment.

## Supported deployment models

The Field Service and Project Operations integration supports Project Operations Core (Lite) and Project Operations Integrated with ERP.

### Project Operations Core (Lite)

[Project Operations Core (Lite)](/dynamics365/project-operations/pro/project-operations-overview-lite) is a Dataverse-based deployment of Project Operations that doesn't require Dynamics 365 Finance.

Use this deployment when you want to connect Field Service execution with Project Operations capabilities such as project planning, costing, pricing, time, expenses, project financials, and proforma invoicing, while using Field Service or another system for inventory and downstream accounting.

- Field Service manages work orders, scheduling, technician activities, and service inventory.
- Project Operations manages project estimates, financial actuals, approvals, and customer invoicing.
- Field Service remains the system of record for Field Service inventory.
- [Inventory validation and stock movements](inventory-purchasing-returns-overview.md) occur only within Field Service.
- A separate ERP or accounting system can be used for downstream financial processing if required.

### Project Operations integrated with ERP

See [Project Operations integrated with ERP](/dynamics365/project-operations/environment/project-operations-integrated-deployment-overview). Use the integrated deployment when your organization also uses Dynamics 365 Finance and Supply Chain Management and needs project transactions to flow into enterprise financial and inventory processes.

- Field Service manages work orders, scheduling, and service execution.
- Project Operations manages project planning, financial transaction processing, estimates, and actuals.
- Finance manages accounting, project accounting, revenue recognition, and final customer invoicing.
- Supply Chain Management manages inventory validation and inventory transactions.
- Integration between Dataverse and finance and operations apps use dual-write and supporting integration components.

## Deployment model comparison

| Capability | Project Operations Core | Project Operations integrated with ERP |
| --- | --- | --- |
| Field service execution | Field Service | Field Service |
| Project planning and project context | Project Operations | Project Operations |
| Project financials | Project Operations | Project Operations + Finance |
| Field Service inventory system of record | Field Service | Finance / Supply Chain Management |
| Inventory validation | Field Service | Finance / Supply Chain Management |
| Proforma invoice | Project Operations | Project Operations |
| Final customer invoice | External process / ERP as applicable | Finance |
| Accounting and general ledger | External process / ERP | Finance |
| Dual-write required for Finance integration | No | Yes |

## Next steps

- [Install the Field Service and Project Operations integration](project-operations-integration-install.md)
- [Set up Field Service integration with Project Operations](project-operations-integration-setup.md)
- [Inventory in the integration](project-operations-integration-inventory.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]