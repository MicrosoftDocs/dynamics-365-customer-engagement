Resource crews allow dispatchers to search and schedule multiple resources at once. Resource crews can include a group of employees, subcontractors, equipment, facilities, or any combination who perform the same work during a period of time. Crews speed up and simplify the scheduling process and allow team members to work together more consistently.

Dispatchers often use crews to schedule a requirement group with multiple requirements to multiple resources. However, you can schedule single requirements to crews too.

Crews are ideal for scenarios where:

- A group of resources work together for some time.
- A crew meets at a location in the morning, shares a vehicle, and is together all day from job to job.
- A new employee is shadowing an experienced coworker to learn new skills.

## Create a crew

A crew is a bookable resource, which is essentially a container for the child resources who are members of the crew.

1. Open the **Resources** area, select **Resources**, and then select **New**.

1. On the **General** tab, set **Resource Type** to **Crew**.

1. Provide a **Name** and choose the **Time Zone** for the crew.

1. Choose a [crew strategy](#crew-strategy-options).

   :::image type="content" source="../../field-service/media/scheduling-crew-header.png" alt-text="Screenshot of a bookable resource set to crew.":::

1. On the **Scheduling** tab, set the **Start Location** and **End Location**. For detailed descriptions of the location options, go to [Set up bookable resources](../../field-service/set-up-bookable-resources.md).

1. Select **Save**.

### Crew strategy options

The crew strategy determines how the crew manages its work once it moves past the *Scheduled* booking status (such as *Traveling*, *In Progress*, or *Completed*). There are three options:

- **Crew Leader Management**: Crew leader manages the work of a crew. Consider this option when a crew consists of multiple people. You can only have one resource designated as the leader at a time, and there must be a leader to create a work order booking. The leader must be a *User* resource type.
- **Crew Member Self-Management**: Resources can manage their own work even once the booking begins. Choose this option for crews that are groups, which regularly work together, but might not always work together at the same place or time. Self-management also means better time capturing, which is good for organizations who bill for time spent on work. 
- **Cascade and Accept Cascade Completely**: All resources on a crew can manage all the work throughout all statuses. It's the ideal option when a crew consists of one individual and the rest of the crew is equipment.

> [!NOTE]
> The logic associated with crew strategies affects bookable resource bookings related to work orders. If an assigned resource marks their own booking to *Completed*, the end-time is updated to the current time stamp. However, if another user or crew member marks the booking to *Completed* on behalf of an assigned resource, the end time remains unchanged.
>
> Crew strategies influence the rescheduling of crew bookings when there are changes made to an associated resource booking.

### Add resource children to a crew

Relate other bookable resources to the crew as crew members. If not done already, [create the bookable resources](../../field-service/set-up-bookable-resources.md). To select a leader for the crew, the resource type must be *User*.

1. On a resource crew record, go to **Related** > **Resource's Children**.

1. Select **New Bookable Resource Group**.

1. Enter a name, the **Child Resource**, and the date range when the resource is part of the crew.

1. Choose the **Crew Member Type** and specify if the resource is a member of the crew or its leader.

1. Select **Save & Close**.

:::image type="content" source="../../field-service/media/scheduling-crew-resource-children.png" alt-text="Screenshot of child resources of a resource crew.":::

> [!TIP]
> The start and end location of resources are important to book onsite requirements. The system takes crew member locations from their individual resource profiles and not from the parent crew. It's important that you change the location of the crew member resource if a resource moves between crews. For example, if you want a crew to meet at a central location in the morning, specify start and end location as organization unit address for both the crew header resource and the resource children.

## Schedule a crew

You can schedule a single requirement to a crew manually through the schedule board or with [schedule assistant](../../field-service/schedule-assistant.md). To [schedule a requirement group to a crew](#schedule-requirement-groups-for-the-crew-with-the-schedule-assistant), use schedule assistant.

> [!NOTE]
> To schedule a requirement to a crew with schedule assistant, set the requirement's resource type to crew.

### View crews on the schedule board

Crews and its individual members show on the schedule board like any other resource. Crews that match the filters of the schedule board show in the list of resources, even if the resource children of the crew don't match the filters.

Crew resources use a different icon than individual resources. The time range a resource is part of a crew shows as a grey area on the board. It reminds dispatchers and resource managers that the resource is part of a crew.

:::image type="content" source="../../field-service/media/scheduling-crew-schedule-board.png" alt-text="Screenshot of a schedule board with individual resources, a crew, and a crew member.":::

Scheduling a job to an individual crew member affects the availability of the entire crew.

### Schedule single requirements to a crew

Assign a single requirement to the crew resource type to create a booking for the entire crew using the schedule board or schedule assistant. If you assign a single requirement to a single crew member, only that single resource gets a booking.

Booking a crew books all crew members and the crew under the following conditions:

1. The booking falls within the **From Date** and the **To Date** configured for the bookable resource group belonging to the crew member.
1. There are work hours configured for the crew member on the day of the booking and the booking falls within those work hours.

> [!NOTE]
> When a single requirement is booked to a crew, a requirement group is automatically created. All bookings are related to the requirement group. It ensures that crew bookings are in sync if you change them. The **Auto Group Type** of the requirement group is set to **Crew**.
>
> However, only the crew header resource is linked to the single requirement in the newly created requirement group.

### Schedule requirement groups for the crew with the schedule assistant

Scheduling a set of requirements to a group of resources that works together is the primary use case for crews.

The schedule assistant suggests a group of individual resources and a crew to complete a requirement group. When the schedule assistant searches, it assembles a group of resources for every requirement in the requirement group. The crew resource itself is just a container. Expand the crew to see how crew members match a requirement within the requirement group.

When you select and book a crew, the booking for each crew member relates to the requirement that they match. It also relates to the requirement group. The crew resource gets a booking too, so you can manage the crew as a single unit.

#### More crew members than requirements

A crew with more resources than needed by the requirement group shows as a result in the schedule assistant, but lower in the search results because it's less optimal.

You can still book a crew with excess resources. All of the bookings link to the requirement group, but the bookings for nonmatching resources don't link to a requirement.

#### Fewer crew members than requirements

When the schedule assistant searches for availability, the crew might need more resources in order to meet the requirements. The schedule assistant combines crews and individual resources to fulfill a requirement group and even notes which resources are part of the crew.

## Quickly change a resource's crew membership for a day

You can quickly make membership changes for crew resources by changing the crew allocation. Swap a resource from one crew to another, add an unassigned resource to a crew, or remove a resource from a crew. These changes apply for a single day in the crew's time zone. All future bookings for that day reflect the changes on the members' schedules. You can edit up to 15 crews simultaneously.

New members get a full day membership in the crew's time zone. Removed members get their existing crew memberships split with a full day gap. If there are small overlaps without bookings, the conflicting memberships are resolved in favor of the target crew. For example, when moving a resource from a crew in one time zone to an adjacent time zone.

> [!NOTE]
> To make changes to crews for longer than a day, edit the crew resource directly.

1. Open the **Resources** area, select **Resources**, and then open a view that has at least one crew resource type.

1. Select **Crew Allocation** in the command bar. The tool opens to the current day based on your local time. The bottom pane shows resources that are available for work but not members of a crew for the selected day. This list doesn't consider the resource capacity. You can change the view and search for resources by name.

   :::image type="content" source="../../field-service/media/scheduling-crew-allocation-tool.png" alt-text="Screenshot of crew allocation page.":::

1. Change to the date for the change in resources.

1. To select multiple resources, select the **Control** and **Command** key while making your selections.

   - To move resources between crews or assign an available resource to a crew, use drag and drop.

   - To remove a resource from a crew, select the resource and select **Remove** in the command bar.

1. Select **Save**. The system processes membership changes. Wait a few minutes for the changes to process. During processing, the system doesn't allow further changes.

After the membership changes conclude, bookings begin to cascade asynchronously. New members get active bookings moved until after the day of the assignment in the crew. Members who are removed from a crew have their crew bookings canceled.

> [!NOTE]
> If the leader on a leader-managed crew is moved to a different crew, they lose their leadership status for that day, even if they're returned to their original crew. To select a new leader or to restore this status, edit the crew resource directly.
