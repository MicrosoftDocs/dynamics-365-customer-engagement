Resource pools let you book work to a group of interchangeable resources without immediately assigning a specific person. Use pools when you want to collect requirements centrally and assign specific resources later, manage capacity across a group of similar resources, or defer the assignment decision until closer to the work date.

If your resources need to work together as a team, use [crews](../../field-service/resource-crews.md) instead.

## Pool scheduling at a glance

| Step | What you do | Key detail |
|---|---|---|
| **1. Create a pool** | Create a bookable resource with type **Pool**, set capacity, and add members. | Use the same resource type within a pool. |
| **2. Book to the pool** | Use the schedule assistant to book requirements to the pool. | The assistant can split work across multiple pool members. |
| **3. Assign pool bookings** | Reassign pool bookings to specific members before the work begins. | Drag-drop, substitute, or rebook. |

## Prerequisites

- [Bookable resources](../../field-service/set-up-bookable-resources.md) created for each pool member (recommended: same resource type within a pool).
- Pool members added with date ranges for their membership.
- Start and end location configured (**Organizational Unit Address** for physical location, **Location Agnostic** for remote).

> [!NOTE]
> - Crews and other pools can't be children of a pool.
> - Don't choose the *Resource address* option for pool start/end location.

## Step 1: Create a pool

1. Open the **Resources** area, select **Resources**, and then select **New**.  

1. On the **General** tab, set **Resource Type** to **Pool** and choose a **Pool Type**.

1. Enter a **Name** and choose a **Time Zone**.

1. On the **Scheduling** tab, choose a **Start Location** and **End Location**. Choose **Organizational Unit Address** to represent a physical location where the pool works, or **Location Agnostic** for a pool of resources that work remotely.
  
   > [!NOTE]
   > Don't choose the *Resource address* option.

1. Choose an option for **Derive Capacity From Group Members** and then select **Save**.

   | Derive Capacity setting | Behavior |
   |---|---|
   | **Yes** | Pool capacity calculated dynamically from members' work calendars. Pool capacity changes when you add or remove members. |
   | **No** | Fixed pool capacity, independent of member changes. You can change the capacity manually. |

1. Add resource attributes to consider for scheduling. Consider the pool as a standard resource as it relates to adding attributes like [characteristics](../../field-service/set-up-characteristics.md) or [territories](../../field-service/set-up-territories.md).

1. Select **Save & Close**.

### Add pool members

Add members to a pool. The location of the pool member is taken from the pool.

1. On a resource pool record, go to **Related** > **Resource's Children**.

1. Select **New Bookable Resource Group** and enter a **Name** for the resource. This related entity is called [BookableResourceGroup](../../field-service/developer/reference/entities/bookableresourcegroup.md).

1. Choose a **Child Resource** and set a date range for the pool membership. Crews and other pools can't be made a child of a pool.

1. Select **Save**. Add other pool members as needed.

   :::image type="content" source="../../field-service/media/scheduling-resource-pool-children.png" alt-text="Screenshot of pool children view.":::

## Step 2: Book to the pool

Use the schedule assistant to book requirements to the pool. Pool resources show as available if the system can distribute the planned work duration across multiple child resources. For example, if you want to schedule a one-hour task and no single resource is available for the full hour, the system suggests two resources available for 30 minutes each.

Pool resources don't show as available if the pool is fully booked for the time period, even if individual members aren't booked.

1. Select **Book** on a requirement form to open the schedule assistant. The schedule assistant shows the pool and individual pool members based on the configuration of the requirement.

1. Select the pool resource and a time slot and select **Book & Exit**.

> [!NOTE]
> The schedule assistant doesn't return resource pools for onsite work requirements.

## Step 3: Assign pool bookings

Before the actual work begins, assign pool bookings to specific members on the schedule board. Bookings assigned to pool member resources during nonworking hours count against the capacity of the pool resource twice.

### Manage a pool on the schedule board

1. On the **Schedule Board**, open the **Filters** pane. Set the **Resource Types** filter to *Pool* and select **Apply**.

1. To set pool as the default view for the selected schedule board tab, select the ellipsis (**&hellip;**) and then **Save as default**.

1. Right-click the resource pool and select **View Group Members** to see the pool and pool members.

   :::image type="content" source="../../field-service/media/scheduling-resource-pool-view-members.png" alt-text="Screenshot showing the result of a right-click on a pool resource to view pool members.":::

### Reassign a pool booking

1. To change a booking assignment, choose one of the following options:

    - **Drag and drop**: Select and drag a booking from the resource pool to one of the pool members.

    - **Substitution**: Right-click a booking in the resource pool, select **Book Substitute**, and choose a pool member.

    - **Rebook**: Right-click a pool booking and select **Rebook**. Edit the filter criteria to no longer search for pools, but to search for Contact, User, and Account type resources.

    The duration resets to the default booking duration.

1. Edit the end time to match the original duration. Then, cancel the original pool booking.
