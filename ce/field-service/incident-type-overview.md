---
title: Work order incident type overview
description: Work order incident types in Dynamics 365 Field Service act as templates that standardize tasks, products, characteristics, and more.
ms.date: 07/31/2026
ms.topic: overview
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wendysmith
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 08/07/2026
ai-usage: ai-assisted
---

# Work order incident type overview

Incident types are service templates that users can use to quickly [create work orders](create-work-order.md) for the most common types of jobs that your organization performs. Use incident types to define specific work order issues and recommended resolutions. They can provide other details like duration, service tasks, products, and more.

Where **work order types** define the general [category of a work order](create-work-order-types.md) (such as inspection, repair, or maintenance), **incident types** define the specific request of a work order and add more details to the work order type.

For example, an incident type can be:

- A specific error code on a machine ("Error code 0048").
- A common customer complaint or request ("The building temperature is too high").
- A specific procedure ("Perform stress test").

Your organization benefits from using incident types because they codify issues, procedures, and resolutions and help standardize processes across geographies and business lines. Incident types ensure all field technicians perform the same actions to resolve work orders. If you discover better procedures, update the incident type so it's immediately available to the entire organization.

Incident types represent a grouping of service tasks, products, and services. You can associate service tasks, products, and services with multiple incident types.

For example, "Put on safety equipment" is a service task that needs to be completed frequently. Create this service task once and associate it to the relevant incident types. Then you can use one list of unique service tasks that you add to incident types, which create **Incident Type Service Task** records. The same is true for products, services, and characteristics.

Incident types help with reporting. They let you discover trends for specific issues. Rather than reporting on work order types to understand the number of repair work orders, an incident type lets you report on the number of power failures for a specific asset category.

Incident types let you:

- Define multiple issues or procedures that need to be completed by adding multiple incident types per work order.

- Build service history by relating incident types to a customer asset.

- Specify work order requirements and schedule them to multiple resources by using requirement group templates.

## Agreements and incident types

To use incident types with agreements, set the **Copy Incident Items to Agreement** option on the incident type. This option controls whether the incident details are copied into the agreement when you activate the agreement or if the latest incident type details are used when the agreement generates work orders.

- Set it to **Yes** when the agreement should always perform the same work, even if the incident type is updated later. The system automatically copies the incident details into the agreement when you activate the agreement.

  Examples:
  - A maintenance contract specifies exactly what tasks, products, and services must be performed for the next three years.
  - You want consistent work orders throughout the life of the agreement.
  - You want to customize the copied tasks slightly and then keep those customizations on the agreement.

- Set to **No** when the work should automatically follow updates to the incident type. When the agreement generates a work order, it uses the current incident type definition, including any changes made since the agreement was created.

  Examples:
  - Your service procedures change regularly.
  - New inspection steps or safety requirements are added over time.
  - You want all future work orders to use the most current version of the incident type.

## Multiple entities

Multiple entities use incident types. Review this section before you write workflows or plug-ins.

### Work order scenario

Incident Type > Incident Product > Work Order Incident > Work Order Incident Product

First, create an **Incident Type** and add a product to the incident, creating an **Incident Product**. When you add the incident type to a work order, you create a **Work Order Incident** along with a **Work Order Incident Product**.

> [!TIP]
> To change the incident type on a work order, delete the Work Order Incident first. Then, create a new Work Order Incident with a different incident type.

### Agreement scenario

Incident Type > Incident Product > Agreement Incident > Agreement Product > Work Order Incident

When you use incidents with **Agreements**, add the incidents and related items to agreements first. Then, pass them along to work orders as the agreement generates them.

### Multiple incident types

Only one work order incident can be the primary incident. It's either the first incident added or the one specified in the primary incident type field. There's a Boolean value on the work order incident type called [*Is Primary*](./developer/reference/entities/msdyn_workorderincident.md#BKMK_msdyn_IsPrimary) that you can use for business logic.

## Next steps

- [Create work order templates with incident types](configure-incident-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]