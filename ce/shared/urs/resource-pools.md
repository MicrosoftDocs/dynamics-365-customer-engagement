Resource pools are groups of similar resources. Dispatchers manage capacity and get the option to assign resources later.

Resource pool scheduling is ideal for several scenarios:

- Avoid booking specific resources right away. For example, a hotel checks room availability (pool) and assigns a room (resource) to guests when they arrive.  

- Collect requirements centrally but let a local manager book them. For example, a repair shop chain takes appointments through a call center. The central agent books the appointment to the customer's preferred location (pool). The local store manager assigns appointments to an available specialist (resource).

- Know the capacity of a pool but not the specific resource it contains. For example, a trade show offers different booth options. it considers the capacity of booths (pool) when booking, but assigns the specific booths (resource) later.

- Enable overbooking for expected cancellations. For example, a hotel has a fixed number of rooms, but might inflate capacity and take more reservations than available rooms to account for cancellations.

## Create a resource pool

We recommended creating pools that use the same resource type. If you want to create groups with different types of resources, [create a crew](../../field-service/resource-crews.md).

1. Open the **Resources** area, select **Resources**, and then select **New**.  

1. On the **General** tab, set **Resource Type** to **Pool** and choose a **Pool Type**.

1. Enter a **Name** and choose a **Time Zone**.

1. On the **Scheduling** tab, choose a **Start Location** and **End Location**. Choose **Organizational Unit Address** to represent a physical location where the pool works, or **Location Agnostic** for a pool of resources that work remotely.
  
   > [!NOTE]
   > Don't choose the *Resource address* option.

1. Choose an option for **Derive Capacity From Group Members** and then select **Save**.
   - **Yes**: The capacity of the pool resource is calculated based on its member's work hour calendars. Pool capacity changes when adding or removing pool members.
   - **No**: The system sets the capacity of the pool but you can change it. Adding and removing pool members doesn't change the capacity.

1. Add resource attributes to consider for scheduling. Consider the pool as a standard resource as it relates to adding attributes like [characteristics](../../field-service/set-up-characteristics.md) or [territories](../../field-service/set-up-territories.md).

1. Select **Save & Close**.

### Add pool members

Add members to a pool. The location of the pool member is taken from the pool.

1. On a resource pool record, go to **Related** > **Resource's Children**.

1. Select **New Bookable Resource Group** and enter a **Name** for the resource. This related entity is called [BookableResourceGroup](../../field-service/developer/reference/entities/bookableresourcegroup.md).

1. Choose a **Child Resource** and set a date range for the pool membership. Crews and other pools can't be made a child of a pool.

1. Select **Save**. Add other pool members as needed.

   :::image type="content" source="../../field-service/media/scheduling-resource-pool-children.png" alt-text="Screenshot of pool children view.":::

## Book a pool with the schedule assistant

Pool resources show as available in the schedule assistant if the system can distribute the planned work duration across multiple child resources. For example, if you want to schedule a task of one hour and no resource is available for the full hour, the system suggests two resources that are available for 30 minutes each.

Pool resources don't show as available in the schedule assistant if the pool is fully booked for the time period, even if the individual resource isn't booked for the period.

1. Select **Book** on a requirement form to open the schedule assistant. The schedule assistant shows the pool and individual pool members based on the configuration of the requirement.

1. Select the pool resource and a time slot and select **Book & Exit**.

> [!NOTE]
> The schedule assistant doesn't return resource pools for onsite work requirements.

## Manage a pool on the schedule board

1. On the **Schedule Board**, open the **Filters** pane. Set the **Resource Types** filter to *Pool* and select **Apply**.

1. To set pool as the default view for the selected schedule board tab, select the ellipsis (**&hellip;**) and then **Save as default**.

1. Right-click the resource pool and select **View Group Members** to see the pool and pool members.

   :::image type="content" source="../../field-service/media/scheduling-resource-pool-view-members.png" alt-text="Screenshot showing the result of a right-click on a pool resource to view pool members.":::

### Assign pool bookings

Assign specific resources to a requirement booked to a pool. Bookings assigned to pool member resources during nonworking hours count against the capacity of the pool resource twice.

1. To change a booking assignment, choose one of the following options:

    - **Manually drag and drop**: Select and drag a booking from the resource pool and drag it to one of the pool members.

    - **Substitution**: Right-click a booking in the resource pool, select **Book Substitute**, and choose a pool member.

    - **Rebook**: Right-click a pool booking and select **Rebook**. Edit the filter criteria to no longer search for pools, but to search for Contact, User, and Account type resources.

    The duration resets to the default booking duration.

1. Edit the end time to match the original duration. Then, cancel the original pool booking.
