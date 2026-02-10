---
title: Field Service integration with Project Operations overview
ms.reviewer: wesmith
description: Learn about the integration between Dynamics 365 Field Service and Project Operations.
ms.date: 02/02/2026
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
---

# Field Service integration with Project Operations overview

Service organizations often manage operational execution and financial processes across separate systems and models. Field teams focus on completing repairs, installations, inspections, and maintenance, while project and finance teams require consistent interpretation of labor, materials, and usage for costing, billing, and performance tracking. When these activities are interpreted through disconnected financial models, organizations face added complexity, manual reconciliation, and limited end-to-end visibility.

The connection between Dynamics 365 Field Service and Project Operations solves this problem by using one shared model to understand and process service work. Labor, materials, and service execution captured in Field Service now flow through a single financial engine for consistent costing and billing. This unified approach reduces reconciliation effort, strengthens visibility across service and project-driven work, and enables more predictable financial and operational outcomes.

> [!VIDEO 071bf5ac-f2bc-419a-8681-61159d50b572]

This integration is designed for organizations that use:

- Field Service, Project Operations, Finance, and Supply Chain Management, which deliver full end-to-end service, project, and financial orchestration.

- Field Service, Finance, and Supply Chain Management, without using the Project Operations application. This approach uses a minimal set of Project Operations setup forms embedded within Field Service.

- Field Service, Finance, and Supply Chain Management, without using the Project Operations application. Field Service and Project Operations remain integrated, but users don't need to open the Project Operations app because all essential workflows are available directly in Field Service. A minimal set of Project Operations configuration forms is embedded in Field Service, enabling customers to complete required setup for Project Operations and Finance and Supply Chain Management without switching applications.

## How it works: the integration flow

This diagram shows how Field Service, Project Operations, and Finance activities connect into one continuous process.

:::image type="content" source="media/project-operations-field-service-integration-flow.png" alt-text="Diagram that shows end-to-end flow from Field Service to Project Operations and Finance." lightbox="media/project-operations-field-service-integration-flow-expand.png":::

**Field Service**

Frontline workers create **work orders** for service delivery, each linked to a project in Project Operations, which serves as the financial container. This work order and project association provides the context to interpret cost, revenue, and billing.

When a frontline worker sets an estimated quantity or estimated duration for the work order product or service, the system creates material estimate lines in Project Operations. The estimate must be greater than zero. If Dynamics 365 Finance integration is enabled, the system creates forecast lines in Finance.

When work in the field is complete and the work order product or service line status is set to used, the system calculates applicable pricing and costs for services and products based on the operational data captured on the work order. The usage data is captured as Material Usage Logs (MULs).

**Project Operations**

**Material Usage Logs (MULs)** represent raw consumption of materials and services. They are converted into **project journal lines** (cost and revenue), which are reviewed and approved for financial accuracy.

Once approved, the journal lines generate **project actuals**, the authoritative financial records tied to the project and contract line.

These actuals generate draft **proforma invoices** for review and adjustment. The draft invoices are then confirmed for invoicing.

**Finance**

If Dynamics 365 Finance integration is enabled, the system generates **Project Operations Integration journal lines** to transfer the approved financial data from Project Operations to Finance.

Finance converts these journal lines into subledger records, applies accounting logic, performs revenue recognition, and posts **customer invoices** to the general ledger.

The result is a continuous financial pipeline: from work order to project and contract line to proforma invoice to posted invoice in Finance.

## Next steps

- [Set up Field Service integration with Project Operations](project-operations-integration-setup.md)

- [Deployment models and inventory](project-operations-integration-inventory.md)

- [Company and legal entities](project-operations-integration-company-legal.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
