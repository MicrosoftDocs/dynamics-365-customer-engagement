---
title: Monitor work order financial processing
description: Learn how to monitor the financial processing of work order products and services in Dynamics 365 Field Service with the Dynamics 365 Project Operations integration.
ms.date: 01/29/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
---

# Monitor work order financial processing

The Project Operations integration provides two dashboards that help you monitor and troubleshoot issues related to processing financial information for work orders linked to projects. As a Field Service administrator, use the dashboards to identify issues so you can fix them.

## Prerequisites

- The [Field Service and Project Operations integration is installed](project-operations-integration-setup.md).
- You have a [Field Service administrator role](security-permissions.md#field-service-security-roles).

## View the dashboards

1. In Field Service, select the **Service** area, and then select **Dashboards**.

1. Change the view to one of the following dashboards:

   - **Work Order Products – Monitoring Dashboard**: shows work order products with issues.

   - **Work Order Services – Monitoring Dashboard**: shows work order services with issues.

     :::image type="content" source="media/project-operations-integration-dashboard.png" alt-text="Example of the Work Order Products - Monitoring Dashboard in the Project Operations integration.":::

Both dashboards contain the following sections:

- **Material Usage Log Validation**: Lists products or services that are missing a material usage log record.

- **Project Approval Validation**: Lists products or services that are missing a Project Approval record.

- **Actuals Validation**: Lists products or services that are missing Actuals records.

- **Background Job Monitoring**: Lists work order revision lines that failed to create or update a material usage log or estimate lines.

A material usage log's *submission* creates the Project Approval record, and the Project Approval's *approval* generates the Actuals.

If a work order product or service is missing information, the dashboard lists it only in the first section where an issue occurred. For example, if a work order product is missing a material usage log, that means it's also missing a project approval and actuals. The dashboard lists the product only in the **Material Usage Log Validation** section because that's when the issue first occurred.

In another example, if a work order service is missing a project approval, the dashboard lists the service only in the **Project Approval Validation** section. That condition means it has a material usage log, but is missing a project approval and actuals.

## Work order line revisions

Work order line revisions provide a snapshot of a work order product or service at a specific point in time. They help ensure all changes to a work order product or service are captured and converted into the appropriate estimate lines or actuals in the order they are received.

When you create or update a work order product or service and the change affects an estimate or actual, the system creates a revision line. Each revision line contains its type (estimate or actual) and a revision number.

A recurring cloud flow runs every minute to process all active revision lines. If multiple revision lines exist for the same work order product or work order service, the system uses the revision line with the highest revision number to generate the correct estimate lines, actuals, or both. If an error occurs, the system records the error details in the revision line, and displays that revision line on the dashboard for resolution. The revision lines with issues remain inactive until you address the issue. Once the estimate lines or actuals are successfully generated, the system deletes the revision lines.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
