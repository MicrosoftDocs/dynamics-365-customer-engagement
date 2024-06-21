Resource crews allow dispatchers to search and schedule multiple resources at once. Resource crews can include a group of employees, subcontractors, equipment, facilities, or any combination thereof who will perform the same work during a period of time. Crews speed up and simplify the scheduling process and allow team members to work together more consistently.

Dispatchers often use crews to schedule a requirement group with multiple requirements to multiple resources. However, you can schedule single requirements to crews too.

Crews are ideal for scenarios where:

- a group of resources will work together for some time.
- a crew meets at a location in the morning, shares a vehicle, and is together all day from job to job.
- a new employee is shadowing an experienced co-worker to learn new skills.

## Create a Crew

A crew is a bookable resource which is essentially a container for the child resources who are members of the crew.

1. Open the **Resources** area and under **Resource**, select **Resources** and select **New**.

1. Choose **Crew** as the **Resource Type**.

1. Provide a **Name** and choose the **Time Zone** for the crew.

1. Choose a **Crew Strategy**. There are three [Crew strategy options](#crew-strategy-options).

   :::image type="content" source="../../common-scheduler/media/scheduling-crew-header.png" alt-text="Screenshot of a bookable resource set to crew.":::

1. On the **Scheduling** tab, set the **Start Location** and **End Location**. For detailed descriptions of the location options, go to [Set up bookable resources](../../field-service/set-up-bookable-resources.md).

1. Select **Save**.

### Crew strategy options

The crew strategy determines how the crew manages its work once it moves past the _Scheduled_ status (e.g. _Travelling_, _In Progress_, or _Completed_). There are three options:

- **Crew Leader Management**: Crew leader manages the work of a crew. Consider this option when a crew consists of multiple people. You can only have one resource designated as the leader at a time, and there must be a leader to create a work order booking.
- **Crew Member Self-Management**: Resources can manage their own work even once the booking has begun. Choose this option for crews that are groups, which regularly work together, but may not always work together at the same place or time. Self-management also means better time capturing, which is good for organizations who bill for time spent on work. 
- **Cascade and Accept Cascade Completely**: All resources on a crew can manage all the work throughout all statuses. It's the ideal option when a crew consists of one individual and the rest of the crew is equipment.

> [!NOTE]
> The logic associated with crew strategies will only impact work order related bookable resource bookings. If an assigned resource updates their own booking to *Completed*, the end-time value is updated to the current time stamp. If another user or crew member updates a booking status to *Completed* on behalf of an assigned resource, the booking end time preserves the previous end time value.
>
> Crew strategies also affect if and how a crew booking is rescheduled when there are changes made to an associated resource booking. 

## Add resource children to a crew

Relate other bookable resources to the crew as crew members. If not done already, [create the bookable resources](../../field-service/set-up-bookable-resources.md).

1. Open the *Crew* resource.

1. Select **Related** > **Resource's Children**.

1. Select **New Bookable Resource Group**.

1. Choose the **Child Resource** and set the date range when the resource will be part of the crew.

1. Choose the **Crew Member Type** and specify if the resource is a member of the crew or its leader. To get set as a leader, the bookable resource needs the type *user*.

1. Select **Save & Close**.

:::image type="content" source="../../common-scheduler/media/scheduling-crew-resource-children.png" alt-text="Screenshot of child resources of a resource crew.":::

> [!TIP]
> Start and end location of resources are important to book onsite requirements. The system takes crew member locations from their individual resource profiles and not from the parent crew. It's important that you change the location of the crew member resource if a resource moves between crews. For example, if you want a crew to meet at a central location in the morning, specify start and end location as organization unit address for the crew header resource *and* the resource children.

## Crews on the schedule board

Crews and its members show on the schedule board like any other resource. Crews that match the filters of the schedule board show in the list of resources, even if the resource children of the crew don't match the filters.

Crew resources use a different icon than individual resources. The time range a resource is part of a crew shows as a grey area on the board. It reminds dispatchers and resource managers that the resource is part of a crew.

:::image type="content" source="../../common-scheduler/media/scheduling-crew-schedule-board.png" alt-text="Screenshot of a schedule board with individual resources, a crew, and a crew member.":::

Scheduling a job to an individual crew member affects the availability of the entire crew.

### Schedule single requirements to a crew

Assign a single requirement to the crew resource to create a booking for the entire crew.

You can't manually schedule requirement groups to crews, only single requirements.

The [schedule assistant](../../field-service/schedule-assistant.md) shows each crew member as individual resources. If booked, only that single resource gets a booking. The crew resource can also return in the results if the working hours and other constraints match. Booking a crew books all crew members and the crew under the following conditions:

1. The booking falls within the "FromDate" and the "ToDate" configured for the bookable resource group belonging to the crew member.
2. There are work hours confiugred for the crew member on the day(s) of the booking and the booking falls within those work hours.

> [!NOTE]
> When a single requirement is booked to a crew, manually or with the schedule assistant, a requirement group is automatically created and all bookings are related to the requirement group. It ensures that crew bookings are in sync if you change them. The **Auto Group Type** of the requirement group is set to **Crew**.
>
> However, only the crew header resource is linked to the single requirement in the newly created requirement group.

### Schedule requirement groups for the crew with the schedule assistant

Scheduling a set of requirements to a group of resources that works together is the primary use case for crews.

The schedule assistant can return suggest a group of individual resources and a crew to complete a requirement group.

When the schedule assistant searches, it assembles a group of resources for every requirement in the requirement group. The crew resource itself is just a container.

Expand the crew to see how crew members match a requirement within the requirement group.

When you select and book a crew, the booking for each crew member relates to the requirement that they match. It also relates to the requirement group. The crew resource gets a booking too, so you can manage the crew as a single unit.

#### More crew members than requirements

A crew with more resources than needed by the requirement group will show as a result in the schedule assistant, but lower in the search results because it's less optimal.

You can still book a crew with excess resources. All of the bookings will link to the requirement group, but the bookings for non-matching resources will not have a link to a requirement.

#### Fewer crew members than requirements

Sometimes when searching for availability, the crew may need more resources in order to meet the requirements.

The schedule assistant will combine crews and individual resources to fulfill a requirement group and even note which resources are part of the crew.

## Quickly change a resource's crew membership for a day

You can quickly make membership changes for crew resources by changing the crew allocation. Swap a resource from one crew to another, add an unassigned resource to a crew, or remove a resource from a crew. These changes apply for a single day in the crew's time zone. All future bookings for that day reflect the changes on the members' schedules.

> [!NOTE]
> To make changes to crews for longer than a day, edit the crew configuration directly.

To access the crew allocation tool, go to the the **Resources** page and open a view that has at least one crew type resource. Select **Crew Allocation** in the command bar. The tool opens the current day based on your local time and you change it using the date picker. Crews show in the tool according to their order in the view. You can edit up to fifteen crews simultaneously.

Use drag and drop to move resources between crews or assign available resources to a crew. To remove a resource from a crew, select the resource and select **Remove** in the command bar. You can select multiple resources by holding the Control/Command key while making your selection.

Save your changes to update a crew. After saving, the system processes membership changes. New members get a full day membership in the crew's time zone. Removed members get their existing crew memberships split with a full day gap. If there are small overlaps without bookings, the conflicting memberships will be resolved in favor of the target crew. For example, when moving a resource from a crew in one time zone to an adjacent time zone. During processing, the system doesn't allow further changes.

After the membership changes conclude, bookings begin to cascade asynchronously. New members get active bookings moved until after the day of they assignment in the crew. Members who are removed from a crew have their crew bookings cancelled. This may a few minutes to process, depending on the number of bookings and resources.

> [!NOTE]
> If the leader on a leader managed crew is moved to a different crew, they will lose their leadership status for that day, even if they are returned to their original crew. To select a new leader or to restore this status, edit the crew configuration directly.


### Crew allocation tool components

- Crew membership grid: Each crew has information about the number of resources that are available and expected for that crew, and the crew's time zone. An added resource is a member of that crew that from 12:00am to 12:00am in the crew's time zone. Resources that are assigned to the crew is listed alphabetically if they have a membership range that includes the majority of the given day in the crew's time zone.
- Bookings grid: A section shows all bookings that the crew has for the day. You can open the booking records for more details but you can't change them in the crew allocation tool.
- Available resources pane: It lists resources that are available for work but not members of a crew for the selected day. This list doesn't consider the resource capacity. It only shows resources that are working on this day. You can change the view and search for resources by name.
