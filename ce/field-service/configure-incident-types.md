---
title: Create work order templates with incident types
description: Configure incident types in Dynamics 365 Field Service to prefill work orders with products, services, service tasks, and characteristics.
ms.date: 07/31/2026
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wendysmith
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 08/07/2026
ai-usage: ai-assisted
---

# Create work order templates with incident types

Create incident types to use as templates for common work orders. The more detail you define on an incident type—such as products, services, service tasks, and characteristics—the more of the work order is filled in automatically when you apply the incident type. Learn more in [Work order incident type overview](incident-type-overview.md).

## Prerequisites

- The [service tasks](set-up-service-task-types.md), [products](create-product-or-service.md), and [services](create-product-or-service.md) for the incident type are created.

- You have the **Field Service - Administrator** security role.

## Create an incident type from a work order form

Capture a work order quickly as a template.

1. In Field Service, change to the **Service** area.

1. Open a work order, select the **Incident type** field, and select **New**.

1. Enter an **Incident Type Name** and an optional **Description**.

   :::image type="content" source="media/work-order-create-from-incident-type.svg" alt-text="Screenshot of the Create incident type form.":::

1. Select other tabs and update other values as needed.

1. Select **Save & Close**.

## Create an incident type from scratch

Create incident types from the incident types form.

1. In Field Service, change to the **Settings** area.

1. Under **Work Orders**, select **Incident Types**.

1. Select **New**.

1. On the **General** tab, provide a **Name** and an optional **Description**.

   :::image type="content" source="media/work-order-incident-type-general.png" alt-text="Screenshot of a new incident type.":::

1. On the **Details** tab, set the values.

   - **Default Work Order Type**: The type of work that applies when a user chooses this incident type.

     > [!NOTE]
     > You can add a default price list to a work order type. Incident types that use that work order type also use the related price list, which saves time filling in price data.

   - **Estimated Duration**: The duration of work for this incident type. If related service tasks have a duration, the incident type duration is the sum of the service task durations. A work order duration is the sum of all incident durations. You can only set an estimated duration if you don't add any service tasks or if the added service tasks have no duration set.

   - **Copy Incident Items to Agreement**: This setting only applies to incident types that are used as part of [customer agreements](set-up-customer-agreements.md). It specifies if the system copies agreement items like service tasks, products, services, or characteristics to an agreement that uses this incident type.

     - **Yes**: If the agreement is a contractual commitment and the scope of work must not change.
     - **No**: If you want agreement-generated work orders to stay aligned with your latest operational procedures.  

     Learn more in [Agreements and incident types](incident-type-overview.md#agreements-and-incident-types).

1. Select **Save**.

1. Add related records:

   - [Add incident type products](#add-incident-type-products)
   - [Add incident type services](#add-incident-type-services)
   - [Add incident type service tasks](#add-incident-type-service-tasks)
   - [Add incident type characteristics](#add-incident-type-characteristics)
   - [Add incident type resolutions](#add-incident-type-resolutions)

1. Optionally, [link knowledge articles](field-service-km-link.md#link-related-entities-to-knowledge-articles). Learn more: [Knowledge management overview](field-service-km-overview.md).

### Add incident type products

Add [products](create-product-or-service.md) that field technicians need to complete the incident type.

1. Open an incident type.

1. On the **Products** tab, select **New Incident Type Product**.

1. Enter the following information:

   - **Name**: A name for the product line item.

   - **Product**: An existing product or create a new one.

   - **Quantity**: The number of units to add to the work order for this incident type.

   - **Description** (optional): A description of the product line item that appears on the customer invoice.

   - **Internal Description** (optional): A description with details for the field technician.

   - **Line Order**: If you have multiple products, set a numeric value that defines the order in which products show on the work order product list.

   :::image type="content" source="media/work-order-incident-types-product.png" alt-text="Screenshot of an incident type product.":::

1. Select **Save and Close**. Add more products as needed.

### Add incident type services

Add [services](create-product-or-service.md) that field technicians provide.

1. Open an incident type.

1. On the **Services** tab, select **New Incident Type Service**.

1. Enter the following information:

   - **Name**: A name for the service line item.

   - **Service**: An existing service or create a new one.

   - **Unit**: The quantity or measurement for the service.

   - **Duration**: How long the service takes the technician.

   - **Description** (optional): A description of the service line item that appears on the customer invoice.

   - **Internal Description** (optional): A description with details for the field technician.

   - **Line Order**: If you have multiple services, set a numeric value that defines the order in which services show on the work order service list.

1. Select **Save and Close**. Add more services as needed.

### Add incident type service tasks

[Service tasks](set-up-service-task-types.md) guide field technicians through a checklist of tasks.

1. Open an incident type.

1. On the **Service Tasks** tab, select **New Incident Type Service Task**.

1. Enter the following information:

   - **Name**: A name for the service task line item.

   - **Task Type**: An existing task type or create a new one.

   - **Estimated Duration**: How long the service task takes the technician.

   - **Line Order**: If you have multiple service tasks, set a numeric value that defines the order in which service tasks show on the work order services list. The order of service tasks is important to reflect steps in a process that should be followed.

   - **Description** (optional): A description of the service task line item.

   :::image type="content" source="media/work-order-incident-types-service-task.png" alt-text="Screenshot of a new incident type service task.":::

1. Select **Save and Close**. Add more service tasks as needed.

### Add incident type characteristics

[Characteristics](set-up-characteristics.md) are skills or attributes related to resources that help schedulers find the right technician for the job. For example, knowledge of the Spanish language or access to a specific building.

> [!TIP]
> If you want to use **Requirement Groups** with **Incident Types** for multi-resource scheduling, don't add characteristics to the incident type. Instead, add required characteristics to the requirement group template. Learn more in [Requirement groups for work orders](multi-resource-scheduling-requirement-groups.md).

1. Open an incident type.

1. On the **Characteristics** tab, select **New Incident Type Characteristic**.

1. Enter the following information:

   - **Characteristic**: An existing characteristic or create a new one.

   - **Rating Value**: The characteristic level of a resource. If you leave this field blank, all rating levels are acceptable if the resource has the matching characteristic.

1. Select **Save and Close**. Add more characteristics as needed.

### Add incident type resolutions

Resolutions let technicians document whether the incident was completed.

1. Open an incident type.

1. On the **Resolution** tab, select **New Incident Type Resolution**.

1. Choose a **Resolution** or create a new one.

1. Select **Save and Close**.

## Example: Incident type auto-population

The following example shows how an incident type called "HVAC Annual Inspection" auto-populates a work order with related records.

When you add this incident type to a work order, the system automatically creates:

**Products (2):**

| Product | Quantity | Type |
|---|---|---|
| Air Filter | 1 | Inventory |
| Coolant Fluid | 2 liters | Inventory |

**Services (1):**

| Service | Duration |
|---|---|
| HVAC Inspection Service | 2 hours |

**Service tasks (3):**

| Task | Estimated duration |
|---|---|
| Check airflow | 20 minutes |
| Test thermostat calibration | 30 minutes |
| Inspect ductwork | 30 minutes |

The work order's estimated duration updates to reflect the sum of service task durations (1 hour 20 minutes), plus the service duration (2 hours).

> [!TIP]
> For incident type auto-population to work correctly, make sure that all products have a status of *Active*, the work order's price list includes the products and services, and users have Create privileges on work order product, work order service, and work order service task tables.

## Add an incident type to a work order

Use the incident type to fill in detail according to its configuration by adding it to a work order.

1. [Create a new work order](create-work-order.md).

1. In the **Incident Type** field, choose the incident type and then select **Save**.

   Related work order products, services, service tasks, and characteristics are added in the background.

   The **Estimate Information** reflects the incident product quantity specified in the incident type.

1. Go to **Related** > **Characteristics** to find the requirement characteristics.

   The duration and characteristics are passed to the related **Resource Requirement** for scheduling. So when you book the work order, filters are already set for these attributes.

1. Schedule the work order or save and close. When the work order is scheduled, the field technician receives the booked work order along with the incident and related details.

## Add multiple incident types to a work order

You can add multiple incident types to a work order. For example, a machine has multiple issues or multiple machines need to be worked on. The same dispatched resource can perform all incidents. Adding multiple incidents to a work order adds to the duration and existing service tasks, products, services, and characteristics.

1. Open an existing work order.

1. To add another incident, go to **Related** > **Incidents** and select **New Work Order Incident**.

1. Select an incident type.

   The work order is updated with the related records of the newly added incident type. The order of the service tasks reflects the order in which incidents are added.

   To book a work order with multiple incidents, the schedule assistant and Resource Scheduling Optimization look for a single resource to complete all incidents. With the schedule assistant, you can edit these filters at the time of scheduling as needed. If the same characteristic in different rating levels is required, the system looks for the best rated resource.

1. Select **Save & Close**.

> [!TIP]
> To change the incident type on a work order, remove the products, services, and service tasks. Then, delete the **Work Order Incident** record. Create a new work order incident with a different incident type. You can manage work order incidents from **Work Order** > **Related** > **Incidents**.

## Relate a customer asset to an incident

Relate [customer assets](assets.md) to incidents to inform field technicians which asset needs attention and to build a service history. You can relate all incidents to the same asset or relate each incident to different customer assets as needed.

To relate a customer asset to an incident, add the asset to an existing work order.

1. Open an existing work order.

1. Search for and select the **Primary asset**. By default, this field only shows customer assets related to the work order service account.

   :::image type="content" source="media/work-order-incident-type-customer-asset.png" alt-text="Screenshot of the customer asset entity with related work orders highlighted.":::

   > [!TIP]
   > The lookup view references the *Customer Asset Lookup View*. In Power Apps, open the work order form and select *Primary Incident Customer Asset*. To use a different view, create a new view and select it as the **Default view** in the **Properties** pane.
   >
   > :::image type="content" source="media/customer-asset-lookup-view.png" alt-text="Screenshot of the Customer Asset Lookup View field properties in Power Apps.":::

## Schedule incidents for multiple resources

To assign multiple resources to an incident, relate the incident type to a requirement group template. Scheduling requirement groups for work orders ensures each resource arrives on site at the same time. Learn more in [Requirement groups for work orders](multi-resource-scheduling-requirement-groups.md).

When you use incidents with requirement groups:

- You can't add characteristics to the incident type or the work order. Add required characteristics in the requirement group template.
- The work order assigned to a requirement group can only have one incident.

> [!TIP]
> If multiple resources need to perform a work order, use requirement group templates instead of multiple incident types. Suppose you have a work order with two incident types, each requiring different characteristics. The system looks for a single resource to fulfill the job. The scheduler needs to perform extra steps to schedule it so two different resources arrive at the same time. If you use a requirement group template, the schedule assistant simultaneously searches for both a single resource with both characteristics or two resources each with one characteristic to arrive at the same time.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
