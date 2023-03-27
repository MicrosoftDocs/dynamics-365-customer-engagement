---
title: Create work order templates with incident types
description: Learn about configuring incident types in Dynamics 365 Field Service.
ms.date: 09/27/2022
ms.topic: article
author: jshotts
ms.author: jasonshotts
search.app: 
  - D365CE
  - D365FS
---

# Create work order templates with incident types

Incident types act as service templates that allow users to quickly [create work orders](create-work-order.md) for the most common types of jobs that your organization performs. Incident types are also used to define specific work order issues and recommended resolutions. They can provide other details like duration, service tasks, products, and more.

Where **work order types** define the general [category of a work order](create-work-order-types.md) (for instance: inspection, repair, or maintenance), **incident types** define the specific request of a work order and add more details to the work order type.

For example, an incident type can be:

- A specific error code on a machine ("Error code 0048").
- A common customer complaint or request ("The building temperature is too high").
- A specific procedure ("Perform stress test").

Organizations benefit from using incident types because they codify issues, procedures, and resolutions, and help standardize processes across geographies and business lines. Incident types ensure all field technicians are performing the same actions to resolve work orders. If you discover better procedures, update the incident type, and it's immediately available to the entire organization.

Incident types are also helpful for reporting. They let you discover trends for specific issues. Rather than reporting on work order types to understand the number of repair work orders, an incident type lets you report on the number of power failures for a specific asset category.

Other important incident type features include:

- Add multiple incident types per work order to define multiple issues or procedures that need to be completed.

- Relate incident types to a customer asset to build service history.

- Relate incident types to requirement group templates to specify requirements for a work order and schedule it to multiple resources.

## Prerequisites

Because incident types represent a grouping of [service tasks](set-up-service-task-types.md), [products](create-product-or-service.md), and [services](create-product-or-service.md), we recommend you create these records first.

The service tasks, products, and services can be associated to multiple incident types. For example, "Put on safety equipment" is a service task that needs to be completed frequently. Create this service task once and associate it to the relevant incident types. There will then be one list of unique service tasks that are added to incident types, which create **Incident Type Service Task** records. The same is true for products, services, and characteristics.

You need the *Field Service - Administrator* security role to create incident types.

## Create an incident type from a work order form

Capture a work order quickly as a template.

1. In Field Service, change to the **Service** area.

1. Open a work order record and select **Create Incident Type** in the command bar.

1. Provide an **Incident Type Name** and an optional **Description**.

   :::image type="content" source="media/work-order-create-from-incident-type.png" alt-text="Screenshot of the create incident type form.":::

1. Update other values as needed. Remove related records that you don't want to copy. The estimated duration is read-only if the value is derived from related tasks.

1. Select **Create Incident Type** to save the template.

## Create an incident type from scratch

Create incident types from the incident types form.

1. In Field Service, change to the **Settings** area.

1. In the **Work Orders** section, select **Incident Types**.

1. Select **New**.

1. On the **General** tab, provide a **Name** and an optional **Description**.

   :::image type="content" source="media/work-order-incident-type-general.png" alt-text="Screenshot of a new incident type.":::

1. On the **Details** tab, set the values.

   :::image type="content" source="media/work-order-incident-type-details.png" alt-text="Screenshot of incident type entity showing the details tab.":::

   - **Default Work Order Type**: The work order type that applies to a work order when a user chooses this incident type.

     > [!NOTE]
     > You can add a default price list to a work order type. Incident types using that work order type also use the related price list, which saves time filling in price data.

   - **Estimated Duration**: The duration for this incident type. If related service tasks have a duration, the incident type duration is the sum of the service task durations. A work order duration is the sum of all incident durations. You can only set an estimated duration, if no service task gets added or the added service tasks have no duration set.

   - **Copy Incident Items to Agreement**: This setting only applies to incident types that are used as part of [customer agreements](set-up-customer-agreements.md). It specifies if the system copies agreement items like service tasks, products, services, or characteristics to an agreement that uses this incident type. Considerations:

     - An incident in an agreement can differ from the incident you use for individual work orders. For example, normally the incident requires 60 minutes to complete. For the agreement, you negotiated with the customer 2 hours of a service. Rather than creating a second incident type for the agreement, set **Copy Incident Items to Agreement** to **No**. Add the incident to the agreement and manually add the required service tasks, product, and services. Set this option to **Yes** and the incident items will be added to the agreement and you make slight variations from there. Using the same incident type can help with reporting.

     - Add incidents to agreements for recurring work to generate work orders with related work order incidents. However, incident types can be updated as processes and procedures change. Since agreements can span multiple months or years, changes on the incident types can result in different work being performed than originally intended. Set the option to **Yes** if the incident should remain the same throughout the agreement life span by copying the incident details to the agreement at the time of agreement activation. Set to **No** to use the latest incident type details when the [agreement generates work orders](configure-default-settings.md#agreement-settings).

1. Select **Save** to create the *Incident Type* record.

1. Add related records:

   - [Add incident type products](#add-incident-type-products)
   - [Add incident type services](#add-incident-type-services)
   - [Add incident type service tasks](#add-incident-type-service-tasks)
   - [Add incident type characteristics](#add-incident-type-characteristics)
   - [Add incident type resolutions](#add-incident-type-resolutions)

### Add incident type products

Add [products](create-product-or-service.md) that field technicians need to complete the incident type.

:::image type="content" source="media/work-order-incident-types-product.png" alt-text="Screenshot of an incident type product.":::

1. Open an *Incident Type* record.

1. On the **Products** tab, select **New Incident Type Product**.

1. Choose a **Product** or create a new one.

1. For **Quantity**, enter the number of units that will be added to the work order for this incident type.

1. Enter a **Name** for the product line item. Because the **Description** field can be communicated to the customer and appear on an invoice, there's also an **Internal Description** to provide details for the field technician.

1. For multiple products, you can set the **Line Order**. It's a numeric value that defines the order in which products show on the work order product list.

1. Select **Save** to apply your changes to the incident type.

### Add incident type services

Add [services](create-product-or-service.md) that field technicians provide.

:::image type="content" source="media/work-order-incident-types-service.png" alt-text="Screenshot of a new incident type service entity.":::

1. Open an *Incident Type* record.

1. On the **Services** tab, select **New Incident Type Service**.

1. Choose a **Service** or create a new one.

1. For **Duration**, choose how long the service will take the technician.

1. Enter a **Name** for the service line item. Because the **Description** field can be communicated to the customer and appear on an invoice, there's also an **Internal Description** to provide details for the field technician.

1. For multiple services, you can set the **Line Order**. It's a numeric value that defines the order in which services show on the work order services list.

1. Select **Save** to apply your changes to the incident type.

### Add incident type service tasks

[Service tasks](set-up-service-task-types.md) to guide field technicians through a checklist of tasks.

:::image type="content" source="media/work-order-incident-types-service-task.png" alt-text="Screenshot of a new incident type service task.":::

1. Open an *Incident Type* record.

1. On the **Service Tasks** tab, select **New Incident Type Service Task**.

1. Choose a **Task Type** or create a new one.

1. For **Duration**, choose how long the service task will take the technician.

1. Enter a **Name** and **Description** for the service line item.

1. For multiple service tasks, you can set the **Line Order**. It's a numeric value that defines the order in which service tasks show on the work order services list. The order of service tasks is important to reflect steps in a process that should be followed.

1. Select **Save** to apply your changes to the incident type.

In the following screenshot, service tasks don't have an estimated duration.

:::image type="content" source="media/work-order-incident-types-service-task-list.png" alt-text="Screenshot of the incident types list.":::

### Add incident type characteristics

[Characteristics](set-up-characteristics.md) are skills or attributes related to resources that help schedulers find the right technician for the job. For example, knowledge of the Spanish language or access to a specific building.

> [!TIP]
> If you want to use **Requirement Groups** with **Incident Types** for multi-resource scheduling, don't add characteristics to the incident type. Instead, add required characteristics to the requirement group template. For more information, go to [Requirement groups for work orders](multi-resource-scheduling-requirement-groups.md).

1. Open an *Incident Type* record.

1. On the **Characteristics** tab, select **New Incident Type Characteristic**.

1. Choose a **Characteristic** or create a new one.

1. For **Rating Value**, choose the required level of proficiency. If left blank, all proficiency levels are acceptable if the resource has the matching characteristic.

1. Select **Save** to apply your changes to the incident type.

### Add incident type resolutions

Resolutions let technicians document whether the incident was completed.

1. Open an *Incident Type* record.

1. On the **Resolution** tab, select **New Incident Type Resolution**.

1. Choose a **Resolution** or create a new one.

1. Select **Save** to apply your changes to the incident type.

## Add an incident type to a work order

Use the incident type to fill in detail according to its configuration by adding it to a work order.

1. [Create a new work order](create-work-order.md).

1. In the **Primary Incident Type** field, choose the incident type.

:::image type="content" source="media/work-order-incident-type-add-to-wo.png" alt-text="[Screenshot of a work order, with the work order type and incident type highlighted.":::

   Related work order products, services, service tasks, and characteristics are added in the background. This addition is the result of a system job called `LongJobs_CopyIncidentItemsToWorkOrder` number 464.

   The **Estimate Information** reflects the incident product quantity specified in the incident type.

   Go to **Related** > **Characteristics** to find the requirement characteristics.

   The duration and characteristics are passed to the related *Resource Requirement* for scheduling. So when you book the work order, filters are already set for these attributes.

1. Save the work order and schedule it to provide the field technician with all relevant details.

Finally, after it's scheduled, the field technician will receive the booked work order along with the incident and related details.

## Add multiple incident types to a work order

You can add multiple incident types to a work order. For example, a machine has multiple issues or multiple machines need to be worked on. All incidents should be performed by the dispatched resource. Adding multiple incidents to a work order will add to the duration and existing service tasks, products, services, and characteristics.

1. Open an existing work order.

1. To add another incident, go to **Related** > **Incidents** and select **+New Work Order Incident**.

   The work order is updated with the related records of the newly added incident type.

   **Total Estimated Duration** on the **Record Log** tab gets updated. The **Primary Incident Estimated Duration** on the **Summary** tab won't change.

   The order of the service tasks reflects the order in which incidents are added.

   To book a work order with multiple incidents, the schedule assistant and Resource Scheduling Optimization look for a single resource to complete all incidents. With the schedule assistant, these filters can be edited at the time of scheduling as needed. If the same characteristic in different proficiency levels is required, the system looks for the most proficient resource.

1. **Save** to apply the changes.

> [!TIP]
> To change the incident type on a work order, delete the *Work Order Incident* first. Then, create a new work order incident with a different incident type. You can manage work order incidents on the **Work Order** > **Related** > **Incidents**.

## Use customer assets with incident types

You can relate [customer assets](assets.md) to incidents to inform field technicians which asset needs attention and build a service history. You can have all incidents related to the same asset or even have each incident related to different customer assets as needed.

:::image type="content" source="media/work-order-incident-type-customer-seet.png" alt-text="Screenshot of the customer asset entity with related work orders highlighted.":::

For the primary incident type, choose the **Primary Incident Customer Asset**. This field only shows customer assets related to the work order service account by default.

> [!TIP]
> The lookup view references the *Customer Asset Lookup View*. To use a different view, you need to customize the system. Create a new view and select it in the *Additional Properties* section of the *Field Properties* for the *Primary Incident Customer Asset* on the *Work Order* form.
>
> :::image type="content" source="media/customer-asset-lookup-view.png" alt-text="Screenshot of the Customer Asset Lookup View field properties.":::

For other incidents, select the incident on the work order form and go to the **Incident Relates To** section to choose a customer asset.

## Schedule incidents for multiple resources

To assign multiple resources to an incident, relate the incident type to a requirement group template. Scheduling requirement groups for work orders ensures each resource arrives on site at the same time. For more information, go to [Requirement groups for work orders](multi-resource-scheduling-requirement-groups.md).

When using incidents with requirement groups:

- You can't add characteristics to the incident type or the work order. Add required characteristics in the requirement group template.
- The work order assigned to a requirement group can only have one incident.

> [!TIP]
> If a work order should be performed by multiple resources, we recommended using requirement group templates instead of multiple incident types. Let's say you have a work order with two incident types, each requiring different skills. The system will look for a single resource to fulfill the job. The scheduler would need to perform extra steps to schedule it so two different resources arrive at the same time. If you use a requirement group template, the schedule assistant will simultaneously search for both a single resource with both skills or two resources each with one skill to arrive at the same time.

## Use AI to get Incident Type suggestions

With Field Service v8.8.20.12+, *Incident Type* AI suggestions recommend ways to improve your incident types by learning from work orders. For example, you have an incident type that is configured to use a certain product. However, technicians frequently also use a different product to complete the job. Using AI, the system will learn and suggest updating the related product on the incident type for future work orders.

:::image type="content" source="media/ai-incident-type-suggestions-list.png" alt-text="Screenshot of the intelligence tab in Field Service Setting showing a list of incident type suggestions.":::

Administrators can enable the feature in Intelligence section on the Field Service Settings. For more information, go to [Intelligence settings](configure-default-settings.md#intelligence-settings).

AI suggestions fall into three categories:

- Work Order Product

  :::image type="content" source="media/ai-incident-type-suggestions-list-product.png" alt-text="Screenshot of an incident type suggestion result showing the work order product type in the suggestion type field.":::

  The system suggests adding a product to an incident type.

- Work Order Service

  :::image type="content" source="media/ai-incident-type-suggestions-list-service.png" alt-text="Screenshot of an incident type suggestion result showing the work order service type in the suggestion type field.":::

  The system suggests adding a service to an incident type.

- Incident Type

  :::image type="content" source="media/ai-incident-type-suggestions-list-merge.png" alt-text="Screenshot of an incident type suggestion result showing the incident type in the suggestion type field.":::

  The system suggests merging two incident types together into one incident type.

For each suggestion, you have the following options:

- **Apply Suggestion**: The system adds the product or service to the incident type. You've to manually apply suggestions for incident types.
- **Dislike**: The suggestion is removed from the list. This option helps improve the AI suggestion model.

## Understand incident entities

There are multiple entities involved that use incident types. Review this section before you write workflows or plug-ins.

### Work order scenario

\> Incident Type \> Incident Product \> Work Order Incident \> Work Order Incident Product

First an **Incident Type** is created and a product is added to the incident creating an **Incident Product**. When the incident type is added to a work order, a **Work Order Incident** is created along with a **Work Order Incident Product**.

> [!TIP]
> When you plan to change the incident type on a work order, delete the Work Order Incident first. Then, create a new Work Order Incident with a different incident type.

### Agreement scenario

\> Incident Type \> Incident Product \> Agreement Incident \> Agreement Product \> Work Order Incident

When using incidents with **Agreements**, the incidents and related items are added to agreements first, and then passed along to work orders as they're generated by the agreement.

### Multiple incident types

Only one work order incident can be the primary incident. It's either the first incident added or the one entered in the primary incident type field. There's a Boolean value on the work order incident type called *Is Primary* that can be used for business logic.

### Advanced scenarios

- By default, work order service tasks have a field called **% Complete** that field technicians can use to record their progress completing each service task. It's common to replace this field or add another yes-or-no field. You can use custom Offline HTML and JavaScript on Field Service Mobile to prevent field technicians from completing a work order until all tasks are complete.
- Correlating incident types with IoT alerts generated from Connected Field Service can streamline issues and resolutions and improve the organization's first-time fix rate.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
