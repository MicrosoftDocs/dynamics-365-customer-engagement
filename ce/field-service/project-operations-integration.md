---
title: Field Service integration with Project Operations overview
ms.reviewer: v-wendysmith
description: Field Service integration with Project Operations streamlines service delivery, project costing, approvals, and billing. Discover the supported integration flow.
ms.date: 11/06/2026
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
---

# Field Service integration with Project Operations overview

Service organizations often manage field execution and financial processes across separate systems, custom integrations, or disconnected operating models. Field teams focus on completing repairs, installations, inspections, and maintenance. Project and finance teams need consistent interpretation of labor, materials, and usage for costing, billing, and performance tracking. Without a standard connection between field execution and project financials, organizations face added complexity, manual reconciliation, and limited end-to-end visibility.

The integration between Microsoft Dynamics 365 Field Service and Dynamics 365 Project Operations provides a supported mechanism for connecting field execution with project financials. This integration uses out-of-the-box product capabilities to connect work orders, project tasks, labor, materials, and financial transactions.  

By using this integration, service work captured in Field Service can flow into Project Operations and downstream financial processes by using a consistent Microsoft product model. This integration helps organizations reduce custom integration effort, improve consistency across costing and billing, strengthen visibility across service and project-driven work, and support more predictable financial and operational outcomes.

> [!VIDEO 071bf5ac-f2bc-419a-8681-61159d50b572]

## Who can use this integration?

This integration is designed for organizations that use:

|Apps  |Comments  |
|---------|---------|
|Field Service, Project Operations, Finance, and Supply Chain Management  | Delivers full end-to-end service, project, and financial orchestration. |
|Field Service, Finance, and Supply Chain Management (without using Project Operations) | Manage projects without switching applications by using a minimal set of Project Operations configuration forms embedded in Field Service. Only the user who installs the integration must have a Project Operations license. |
|Field Service and Project Operations (without using Finance and Supply Chain Management) | Supports project-based service and financial alignment under a project in Project Operations. This approach can be used for integration to other ERP solutions or for direct execution and management purposes. |

## Integration flow overview

This diagram shows how Field Service, Project Operations, and Finance activities connect into one continuous process.

:::image type="content" source="media/project-operations-field-service-integration-flow.png" alt-text="Screenshot of the integration flow diagram showing Field Service to Finance." lightbox="media/project-operations-field-service-integration-flow-expand.png":::

## Field Service

Frontline workers create **work orders** for service delivery, each linked to a project in Project Operations, which serves as the financial container. This work order and project association provides the context to interpret cost, revenue, and billing.

When a frontline worker sets an estimated quantity or estimated duration for the work order product or service, the system creates material estimate lines in Project Operations. The estimate must be greater than zero. If Dynamics 365 Finance integration is enabled, the system creates forecast lines in Finance.

When work in the field is complete and the work order product or service line status is set to **Used**, the system calculates applicable pricing and costs for services and products based on the operational data captured on the work order. The usage data is captured as Material Usage Logs (MULs).

After technicians enter and submit time in Field Service for work associated with a project or project task, the **time entries** flow into Project Operations. These entries follow Project Operations pricing and approval workflows. Once approved, the approval status syncs back to Field Service.

## Project Operations

 Project managers can create work orders linked to a project or project task from Project Operations. Scheduling and execution remains in Field Service.

**Material Usage Logs (MULs)** represent raw consumption of materials and services. They're converted into **project journal lines** (cost and revenue), which are reviewed and approved for financial accuracy.

Once approved, the journal lines generate **project actuals**, the authoritative financial records tied to the project and contract line.

These actuals generate draft **Proforma invoices** for review and adjustment. The draft invoices are then confirmed for invoicing.

Time entries in Field Service and Project Operations are reviewed for the project. Only approved entries generate financial actuals and update task progress. Estimates and actuals show the associated work order for traceability.

## Finance

If Dynamics 365 Finance integration is enabled, the system generates **Project Operations Integration journal lines** to transfer the approved financial data, including approved time entries, from Project Operations to Finance.

Finance converts these journal lines into subledger records, applies accounting logic, performs revenue recognition, and posts **customer invoices** to the general ledger.

The result is a continuous financial pipeline: from work order to project and contract line, to proforma invoice, to posted invoice in Finance.

## Next steps

- [Set up Field Service integration with Project Operations](project-operations-integration-setup.md)

- [Deployment models in Project Operations](project-operations-integration-deployment-models.md)

- [Inventory in the integration](project-operations-integration-inventory.md)

- [Company and legal entities](project-operations-integration-company-legal.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
