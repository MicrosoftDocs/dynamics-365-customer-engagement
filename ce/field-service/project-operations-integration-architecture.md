---
title: Field Service integration with Project Operations architecture
description: Field Service integration with Project Operations connects project planning, service execution, scheduling, and financial processing. Explore the architecture.
ms.date: 11/19/2026
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
---

# Field Service integration with Project Operations architecture

The following diagram illustrates how Field Service, Project Operations, and shared services work together to connect project planning, service execution, resource scheduling, and financial management. It also shows the optional integration with Finance and Supply Chain Management.

:::image type="content" source="media/project-operations-integration-architecture.png" alt-text="Screenshot of Field Service and Project Operations integration architecture flow." lightbox="media/project-operations-integration-architecture.png":::

## How the integration works

The integration connects project setup, resource planning, service execution, and financial processing. Work can originate in Field Service or Project Operations, depending on the organization's business processes.

### Project and contract setup

Projects establish the financial and delivery structure for service work.

Project contracts and contract lines define the commercial arrangements, including billing methods, transaction eligibility, and the customers responsible for payment.

By using the integration, you can create projects in Field Service or Project Operations.

- [Create projects in Field Service](project-operations-integration-manage-projects.md) where you can create projects, project contracts, and project contract lines.
- [Create projects in Project Operations](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order-task) where you can create projects, project tasks, work breakdown structures, resource assignments, and project estimates.

The integration supports three project types: customer billable, internal, and investment. Learn more in [Project requirements](project-operations-integration-projects.md).

### Work order and project relationships

The integration supports two common business processes: service-led and project-led work.

| Aspect | Service-led work | Project-led work |
| --- | --- | --- |
| Where work starts | Service teams create work orders directly in Field Service. | Project managers plan work in Project Operations and create or associate work orders with project tasks. |
| Project relationship | Work orders are associated with eligible projects. A project can have multiple work orders, and you can link agreements to projects so generated work orders inherit the relationship. | Work orders are associated with individual project tasks. A project task can be associated with one work order, and a work order with one project task. |
| Typical scenarios | Repairs, maintenance, inspections, and other service activities where the work order drives execution. | Installations, modernization projects, equipment upgrades, and other activities that require coordinated project planning and field execution. |

### Resource planning and scheduling

Field Service and Project Operations share Universal Resource Scheduling capabilities, but project resource assignments, work order resource requirements, and bookings represent different parts of the planning and execution process.

In Project Operations, project managers define project tasks, planned effort, and resource assignments. When a project task is connected to a Field Service work order, the integration can use project assignment information to support work order resource requirements.

In Field Service, workers manage work order resource requirements, scheduling, and bookings.

- Dispatchers use the schedule board and other supported scheduling tools to assign resources to work orders.

- Technicians execute the work against their Field Service bookings.

This integration connects project planning with field execution while allowing each application to manage its respective planning and scheduling responsibilities.

### Field Service execution

Technicians continue to perform their work in Field Service, including through the Field Service mobile application.

During execution, technicians can:

- Review assigned work orders and bookings
- Record materials and services used
- Capture time entries
- Submit work-related expenses
- Update work order and booking statuses
- Complete service activities

When work orders are associated with projects or project tasks, supported transactions retain the project context needed for financial processing.

The integration connects the operational information recorded in Field Service with the corresponding financial records in Project Operations.

### Estimates and financial actuals

The integration supports the flow of estimated and actual service transactions between Field Service and Project Operations.

- **Material estimates**: Estimated work order products and eligible work order services can generate material estimates in Project Operations according to the configured work order service behavior. In the Project Operations Integrated with ERP deployment model, eligible estimates can also generate project forecast lines in Finance.

- **Material usage log**: When a supported work order product or service is marked as *Used*, the integration creates a Material Usage Log in Project Operations. These logs follow the configured approval process before generating project financial actuals. The resulting financial records are associated with the appropriate project and contract line.

- **Labor**: Technicians capture time entries in Field Service. Submitted time entries flow to Project Operations for pricing and approval. Once approved, time entries generate applicable project financial actuals. Approval status is synchronized back to Field Service.

  When the work order is associated with a project task, approved time entries can also update project task progress, including completed effort and percent complete.

- **Expenses**: Technicians can capture work-related expenses in Field Service. Supported expenses flow into Project Operations for review, approval, and financial processing. Approved expenses generate applicable project financial actuals.

- **Financial actuals**: Project Operations uses the project, project task, transaction type, and contract line configuration to determine how supported service transactions are financially processed.

  - For **Time and Material** billing, eligible transactions can generate both cost and unbilled sales actuals.

  - For **Fixed Price** billing, service transactions generally generate cost actuals, while customer billing follows the configured fixed-price billing process.

These records provide financial traceability between Field Service work orders and project financial activity.

### Financial processing and invoicing

Field Service includes native work order invoicing capabilities. However, for project-linked work orders that use the Field Service and Project Operations integration, the standard Field Service invoicing process is suppressed.

This behavior prevents competing invoicing processes and ensures that project-related billing follows the configured Project Operations financial structure. Although invoicing no longer uses the native Field Service work order invoicing process, service users can access supported project financial and invoicing forms within Field Service.

### Finance and Supply Chain Management integration (optional)

When you integrate Project Operations with Finance, the integration extends the financial process beyond Dataverse into the ERP. Project Operations uses dual-write for applicable setup and configuration data synchronization between Dataverse and finance and operations applications.

Project Operations Integration journal lines process eligible financial transactions for downstream processing in Finance.

Supply Chain Management supports the inventory, procurement, and fulfillment processes required for service execution, based on the configured integration capabilities.

This architecture separates service execution from financial accounting and inventory ownership while maintaining the relationships needed to track costs, materials, and project activity across applications.

## Next steps

- [Install the Field Service and Project Operations integration](project-operations-integration-install.md)
- [Set up Field Service integration with Project Operations](project-operations-integration-setup.md)
- [Field Service and Project Operations integration overview](project-operations-integration.md)
- [Deployment models in Project Operations](project-operations-integration-deployment-models.md)
- [Inventory in the integration](project-operations-integration-inventory.md)
- [Work order services in the integration](project-operations-integration-work-order-services.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
