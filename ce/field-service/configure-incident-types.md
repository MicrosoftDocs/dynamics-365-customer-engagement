---
title: Create work order templates with incident types
description: Learn how to configure incident types in Dynamics 365 Field Service.
ms.date: 11/11/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---

# Create work order templates with incident types

Create incident types to use as templates for common work orders. Learn more in [Work order incident type overview](incident-type-overview.md).

## Prerequisites

- The [service tasks](set-up-service-task-types.md), [products](create-product-or-service.md), and [services](create-product-or-service.md) for the incident type are created.

- You have the **Field Service - Administrator** security role.

## Create an incident type from a work order form

Capture a work order quickly as a template.

1. In Field Service, change to the **Service** area.

1. Open a work order and select the **Incident type** field and select **New Incident Type**.

1. Provide an **Incident Type Name** and an optional **Description**.

   :::image type="content" source="media/work-order-create-from-incident-type.svg" alt-text="Screenshot of the Create incident type form.":::

1. Select other tabs and update other values as needed.

1. Select **Save & Close**.

## Create an incident type from scratch

Create incident types from the incident types form.

1. In Field Service, change to the **Settings** area.

1. Under **Work Orders**, select **Incident Types**.

1. Select **New**.

1. On the **General** tab, provide a **Name** and an optional **Description**.

   :::image type="content" source="media/work-order-incident-type-general.svg" alt-text="Screenshot of a new incident type.":::

1. On the **Details** tab, set the values.

   :::image type="content" source="media/work-order-incident-type-details.svg" alt-text="Screenshot of incident type entity showing the details tab.":::

   - **Default Work Order Type**: The work order type that applies to a work order when a user chooses this incident type.

     > [!NOTE]
     > You can add a default price list to a work order type. Incident types using that work order type also use the related price list, which saves time filling in price data.

   - **Estimated Duration**: The duration for this incident type. If related service tasks have a duration, the incident type duration is the sum of the service task durations. A work order duration is the sum of all incident durations. You can only set an estimated duration, if no service task gets added or the added service tasks have no duration set.

   - **Copy Incident Items to Agreement**: This setting only applies to incident types that are used as part of [customer agreements](set-up-customer-agreements.md). It specifies if the system copies agreement items like service tasks, products, services, or characteristics to an agreement that uses this incident type. Considerations:

     - An incident in an agreement can differ from the incident you use for individual work orders. For example, normally the incident requires 60 minutes to complete. For the agreement, you negotiated with the customer 2 hours of a service. Rather than creating a second incident type for the agreement, set **Copy Incident Items to Agreement** to **No**. Add the incident to the agreement and manually add the required service tasks, product, and services. Set this option to **Yes** and the incident items are added to the agreement and you make slight variations from there. Using the same incident type can help with reporting.

     - Add incidents to agreements for recurring work to generate work orders with related work order incidents. However, incident types can be updated as processes and procedures change. Since agreements can span multiple months or years, changes on the incident types can result in different work being performed than originally intended. Set the option to **Yes** if the incident should remain the same throughout the agreement life span by copying the incident details to the agreement at the time of agreement activation. Set to **No** to use the latest incident type details when the [agreement generates work orders](configure-default-settings.md#agreement-settings).

1. Select **Save**.

1. Add related records:

   - [Link knowledge articles](field-service-km-link.md#link-related-entities-to-knowledge-articles)
   - [Add incident type products](#add-incident-type-products)
   - [Add incident type services](#add-incident-type-services)
   - [Add incident type service tasks](#add-incident-type-service-tasks)
   - [Add incident type characteristics](#add-incident-type-characteristics)
   - [Add incident type resolutions](#add-incident-type-resolutions)

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

   :::image type="content" source="media/work-order-incident-types-product.svg" alt-text="Screenshot of an incident type product.":::

1. Select **Save and Close**.

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

   :::image type="content" source="media/work-order-incident-types-service.svg" alt-text="Screenshot of a new incident type service entity.":::

1. Select **Save and Close**.

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

   :::image type="content" source="media/work-order-incident-types-service-task.svg" alt-text="Screenshot of a new incident type service task.":::

1. Select **Save and Close**.

### Add incident type characteristics

[Characteristics](set-up-characteristics.md) are skills or attributes related to resources that help schedulers find the right technician for the job. For example, knowledge of the Spanish language or access to a specific building.

> [!TIP]
> If you want to use **Requirement Groups** with **Incident Types** for multi-resource scheduling, don't add characteristics to the incident type. Instead, add required characteristics to the requirement group template. For more information, go to [Requirement groups for work orders](multi-resource-scheduling-requirement-groups.md).

1. Open an incident type.

1. On the **Characteristics** tab, select **New Incident Type Characteristic**.

1. Enter the following information:

   - **Characteristic**: An existing characteristic or create a new one.

   - **Rating Value**: The required level of proficiency. If left blank, all proficiency levels are acceptable if the resource has the matching characteristic.

1. Select **Save and Close**.

### Add incident type resolutions

Resolutions let technicians document whether the incident was completed.

1. Open an incident type.

1. On the **Resolution** tab, select **New Incident Type Resolution**.

1. Choose a **Resolution** or create a new one.

1. Select **Save and Close**.

## Add an incident type to a work order

Use the incident type to fill in detail according to its configuration by adding it to a work order.

1. [Create a new work order](create-work-order.md).

1. In the **Incident Type** field, choose the incident type.

   Related work order products, services, service tasks, and characteristics are added in the background.

   The **Estimate Information** reflects the incident product quantity specified in the incident type.

1. Go to **Related** > **Characteristics** to find the requirement characteristics.

   The duration and characteristics are passed to the related **Resource Requirement** for scheduling. So when you book the work order, filters are already set for these attributes.

1. Save the work order and schedule it to provide the field technician with the relevant details.

After the work order is scheduled, the field technician receives the booked work order along with the incident and related details.

## Add multiple incident types to a work order

You can add multiple incident types to a work order. For example, a machine has multiple issues or multiple machines need to be worked on. The same dispatched resource can perform all incidents. Adding multiple incidents to a work order adds to the duration and existing service tasks, products, services, and characteristics.

1. Open an existing work order.

1. To add another incident, go to **Related** > **Incidents** and select **New Work Order Incident**.

1. Select an incident type.

   The work order is updated with the related records of the newly added incident type. The order of the service tasks reflects the order in which incidents are added.

   To book a work order with multiple incidents, the schedule assistant and Resource Scheduling Optimization look for a single resource to complete all incidents. With the schedule assistant, these filters can be edited at the time of scheduling as needed. If the same characteristic in different proficiency levels is required, the system looks for the most proficient resource.

1. Select **Save**.

> [!TIP]
> To change the incident type on a work order, delete the **Work Order Incident** first. Then, create a new work order incident with a different incident type. You can manage work order incidents on the **Work Order** > **Related** > **Incidents**.

## Relate a customer asset to an incident

You can relate [customer assets](assets.md) to incidents to inform field technicians which asset needs attention and build a service history. You can have all incidents related to the same asset or even have each incident related to different customer assets as needed.

To relate a customer asset to an incident, add the asset to an existing work order.

1. Open an existing work order.

1. Search for and select the **Primary asset**. This field only shows customer assets related to the work order service account by default.

   :::image type="content" source="media/work-order-incident-type-customer-asset.svg" alt-text="Screenshot of the customer asset entity with related work orders highlighted.":::

   > [!TIP]
   > The lookup view references the *Customer Asset Lookup View*. To use a different view, you need to customize the system. Create a new view and select it in the *Additional Properties* section of the *Field Properties* for the *Primary Incident Customer Asset* on the *Work Order* form.
   >
   > :::image type="content" source="media/customer-asset-lookup-view.png" alt-text="Screenshot of the Customer Asset Lookup View field properties.":::

## Schedule incidents for multiple resources

To assign multiple resources to an incident, relate the incident type to a requirement group template. Scheduling requirement groups for work orders ensures each resource arrives on site at the same time. For more information, go to [Requirement groups for work orders](multi-resource-scheduling-requirement-groups.md).

When using incidents with requirement groups:

- You can't add characteristics to the incident type or the work order. Add required characteristics in the requirement group template.
- The work order assigned to a requirement group can only have one incident.

> [!TIP]
> If a work order should be performed by multiple resources, we recommended using requirement group templates instead of multiple incident types. Let's say you have a work order with two incident types, each requiring different skills. The system will look for a single resource to fulfill the job. The scheduler would need to perform extra steps to schedule it so two different resources arrive at the same time. If you use a requirement group template, the schedule assistant will simultaneously search for both a single resource with both skills or two resources each with one skill to arrive at the same time.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
