---
title: Field Service integration with Project Operations overview
description: Field Service integration with Project Operations streamlines service delivery, project costing, approvals, and billing. Discover the supported integration flow.
ms.date: 11/19/2026
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
---

# Field Service integration with Project Operations overview

The integration between Dynamics 365 Field Service and Dynamics 365 Project Operations connects service execution with project planning and financial management. It enables organizations to manage work orders, resource scheduling, and technician activities in Field Service while using Project Operations to manage project estimates, costs, revenue, and financial actuals.

The integration supports both service-led and project-led business processes. Work orders can originate in Field Service or be created from projects and project tasks in Project Operations.
To support service-led organizations, the integration also extends the Field Service application with simplified forms for creating and managing projects, project contracts, and contract lines.

This approach allows service teams to establish the financial structure for their work without having to switch between applications.

When the integration is enabled, Project Operations becomes the financial layer for project-linked work orders. Native Field Service invoicing is suppressed for these work orders, and billing follows the applicable Project Operations financial process.

Organizations can optionally integrate Project Operations with Dynamics 365 Finance and Supply Chain Management to support downstream financial processing, inventory management, procurement, and accounting.

> [!VIDEO 071bf5ac-f2bc-419a-8681-61159d50b572]

## Who can use this integration?

This integration is designed for organizations that use:

|Apps  |Comments  |
|---------|---------|
|Field Service, Project Operations, Finance, and Supply Chain Management  | Delivers full end-to-end service, project, and financial orchestration. |
|Field Service, Finance, and Supply Chain Management (with Project Operations serving as the integration layer). | Manage projects without switching applications by using a minimal set of Project Operations configuration forms embedded in Field Service. Only the user who installs the integration must have a Project Operations license. |
|Field Service and Project Operations (without using Finance and Supply Chain Management) | Supports project-based service and financial alignment under a project in Project Operations. This approach can be used for integration to other ERP solutions or for direct execution and management purposes. |

## Key components

### Dynamics 365 Field Service

Field Service manages service execution, including work orders, service agreements, incident types, work order products and services, resource requirements, scheduling, and technician activities.

Technicians use Field Service to record materials consumed, time worked, expenses incurred, and the progress of service activities.

The integration also provides simplified project management forms in Field Service, allowing service teams to create the foundational project and contract records required for financial processing.

### Dynamics 365 Project Operations

Project Operations manages project planning and financial processes, including projects, project contracts, contract lines, project tasks, resource assignments, estimates, actuals, approvals, and proforma invoicing.

Project Operations provides the financial structure for work performed in Field Service. When a work order is associated with a project or project task, the integration connects service transactions to the appropriate project financial records and billing arrangements.

### Shared services

Field Service and Project Operations use shared Microsoft Dataverse tables and platform capabilities, including Universal Resource Scheduling.

These shared capabilities support common resource information and scheduling infrastructure. Integration-specific functionality connects project resource assignments with Field Service resource requirements and bookings.

### Dynamics 365 Finance and Supply Chain Management (optional)

In the Project Operations Integrated with ERP deployment model, Dynamics 365 Finance supports accounting, financial postings, and final customer invoicing. Supply Chain Management supports inventory management, procurement, fulfillment, and related supply chain processes.

## Next steps

- [Install the Field Service and Project Operations integration](project-operations-integration-install.md)
- [Set up Field Service integration with Project Operations](project-operations-integration-setup.md)
- [Field Service and Project Operations integration architecture](project-operations-integration-architecture.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
