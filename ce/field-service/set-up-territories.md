---
title: Service territories for accounts, work orders, and resources.
description: Learn how to use territories for accounts, work orders, and scheduling in Dynamics 365 Field Service.
ms.date: 09/22/2022
ms.reviewer: mhart
ms.topic: article
author: holly2776
ms.author: Hollycha
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---
# Territories for accounts, work orders, and resources

Territories help you divide your business into geographical regions for work order management, scheduling, and reporting. You can group your customers, work orders, and resources based on city, state, [postal code](set-up-postal-codes.md), or even define a custom region.

Use territories with work orders and resources to help dispatchers schedule work orders to resources with a matching territory. Territories also serve as a filter on the schedule board, in the schedule assistant, and for the [Resource Scheduling Optimization add-in](rso-overview.md).

[Reporting](reports.md) by region is a common use-case for many organizations. Measure KPIs such as first-time fix rate, work order count by type, or work order invoice revenue by territory.

## Create a territory

Create your territories in Field Service settings or import them from Excel.

:::image type="content" source="media/territories.png" alt-text="Screenshot of the list of territories.":::
  
1. In **Field Service**, open the **Settings** area.

1. In the **General** section, select **Territories**.
  
1. Select **New** to create a territory record.

   - **Name**: Name of the territory.  
  
   - **Manager**: User who manages the territory.
  
   - **Description**: Enter information to include for this territory.

   - **Parent**: Define a hierarchy for territories and sub-territories. For example, group multiple cities in a region.
  
1. Select **Save & Close**.  

## Assign resources to territories

Bookable resources like field technicians, equipment, or facilities can belong to one or more territories. Resources can be a part of multiple territories.
  
1. Open the **Resources** area. In the **Resource** section, select **Resources**.

1. Select the resource you want to assign to a territory.
  
1. On the Bookable Resource form, select **Related** > **Resource Territories**.

1. Select **New Resource Territory**.

1. Choose the **Territory** or create a new one.  

1. Select **Save & Close**.

:::image type="content" source="media/territory-resource.png" alt-text="Screenshot of the Bookable Resource record with an associated Territory record.":::

## Add accounts to territories

Customer accounts can belong to a single service territory.

1. Open the **Service** area. In the **Customers** section, select **Accounts**.

1. Select the account you want to assign to a territory.
  
1. On the Account form, select **Related** > **Servicing**.

1. In the Service section, choose a Service Territory or create a new one.

1. Select **Save & Close**.

:::image type="content" source="media/territory-account.png" alt-text="Screenshot of an Account form on the Servicing tab with an associated Service territory.":::

## Territories in the scheduling assistant

While scheduling, you can match the required service territory to the resources in those territories.

For example, when you assign a service account to a work order, the service territory of the account shows on the work order if the service account belongs to a service territory.

If you attempt to [book a work order with the schedule assistant](schedule-assistant.md), the **Service Territory** gets added as a filter. The listed resources will be part of that territory.

:::image type="content" source="media/territoryfilters.png" alt-text="Screenshot of the schedule assistant, showing a list of resources.":::

## Territories on the schedule board

Territories are also used on the schedule board to more effectively manage resources. You can create schedule board tabs specific to a single territory that is managed by a dispatcher.

From the schedule board, add one or more territories as filters, and the resources displayed will adjust accordingly. Then choose **Options** > **Save Current Filters as Default** to ensure the filters remain the next time you return to the schedule board tab.


> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board, showing the highlighted territory tab.](./media/work-order-territory-sb-filter-all.png)

To filter requirements by territories in the lower pane, select the gear in the top right to access schedule board configurations and select **Apply Filter Territory**. As demonstrated in the previous screenshot, this filters the requirements in the lower panel to those in the "WA territory." Now both the resources and the requirements in the schedule board tab belong to the same territory.

## Configuration considerations

In **Resource Scheduling** > **Settings** > **Administration** > **Scheduling Parameters**, there is a setting called **Auto Filter Service Territory** that will filter requirements on the schedule board tab based on the filtered territory by default. This corresponds with the example in the previous section.

> [!div class="mx-imgBorder"]
> ![Screenshot of a scheduling parameter.](./media/schedulingparameter.png)

### Postal codes

You can relate territories to postal codes. When the postal code is present on the account or work order address, the related territory is automatically filled in. For more information, go to [Create and manage postal codes](set-up-postal-codes.md).

:::image type="content" source="media/work-order-territory-postal-codes.png" alt-text="Screenshot of a territory entity showing postal codes under the related tab.":::

## Additional notes

### Implementation notes

- **Territories as more than location.** Organizations frequently use territories to represent more than location by combining it with the purpose of the resource group. For example, if there are resources who operate in Seattle and some are responsible for maintenance and others inspection, the organization can create two territories: "Seattle - maintenance" and "Seattle - inspection." This is also helpful if different dispatchers are managing each territory because you can have different schedule board tabs for each.
- **Using territories for non-field service scenarios.** Beyond field service, territories can be used for other scenarios. A common example is dividing salespeople into sales territories and scheduling time with leads, quotes, or opportunities. For this scenario, you can use a lookup to the service territory on the **Resource Requirement** form. For more information, see the article on [enabling an entity for scheduling](schedule-new-entity.md).
- **Variable territories.** An organization may need resources to belong to different territories during different time periods. One example is during the day a resource may cover a small territory, but at night when demand is low, a resource may be responsible for a larger territory. This is not supported out of the box; however, one option is to use a workflow to add and remove a resource from a territory based on the time of day.


> [!div class="mx-imgBorder"]
> ![Screenshot of a resource requirement, on the scheduling tab.](./media/work-order-territory-sales-opportunity.png)

### Other notes

- Territories are not hierarchical or associative.
- **Crews**: if a schedule board is filtered to show resources for the Washington territory, and the crew header resource is part of that territory, it will be displayed. This is true even if resource children are not part of that territory. For more information, see the article on [enabling an entity for scheduling](resource-crews.md).
- You can't allocate the same user (not resource entity, but user entity) to multiple territories. If you need to assign a user to a large area (more than one existing territory), create a new territory that includes the existing territories, and then assign the user to that new territory. 

[!INCLUDE[footer-include](../includes/footer-banner.md)]
