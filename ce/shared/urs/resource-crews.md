Crews group resources that regularly work together — for example, a two-person installation team or a technician paired with specialized equipment. When you schedule a crew, all members are booked together automatically.

Use crews when:

- A group of resources work together for some time.
- A crew meets at a location in the morning, shares a vehicle, and is together all day from job to job.
- A new employee is shadowing an experienced coworker to learn new skills.

If your resources are interchangeable and you want to defer assignment, use [pools](../../field-service/resource-pools.md) instead.

## Crew scheduling at a glance

| Step | What you do | Key detail |
|---|---|---|
| **1. Create a crew** | Create a bookable resource with type **Crew**, choose a strategy, and add members. | Member locations come from individual profiles, not the crew. |
| **2. Schedule the crew** | Book a single requirement or a requirement group to the crew. | All members are booked together; the system keeps bookings in sync. |
| **3. Manage daily changes** | Use the **Crew Allocation** tool to swap members for a single day. | For longer changes, edit the crew resource directly. |

## Prerequisites

- [Bookable resources](../../field-service/set-up-bookable-resources.md) created for each crew member.
- Start/end locations set on each member (crew member locations come from individual profiles, not the parent crew).
- For the Crew Leader strategy: the leader must be a **User** resource type.

## Step 1: Create a crew

A crew is a bookable resource that acts as a container for its child resources (the crew members).

1. Open the **Resources** area, select **Resources**, and then select **New**.

1. On the **General** tab, set **Resource Type** to **Crew**.

1. Provide a **Name** and choose the **Time Zone** for the crew.

1. Choose a [crew strategy](#choose-a-crew-strategy).

   :::image type="content" source="../../field-service/media/scheduling-crew-header.png" alt-text="Screenshot of a bookable resource set to crew.":::

1. On the **Scheduling** tab, set the **Start Location** and **End Location**. For detailed descriptions of the location options, go to [Set up bookable resources](../../field-service/set-up-bookable-resources.md).

1. Select **Save**.

### Choose a crew strategy

The crew strategy determines work management once a booking moves past the *Scheduled* status (for example, *Traveling*, *In Progress*, or *Completed*).

| Strategy | Best for | Details |
|---|---|---|
| **Crew Leader Management** | Multi-person crews with a designated lead | A single leader manages all work. Only one leader at a time; there must be a leader to create a work order booking. The leader must be a *User* resource type. |
| **Crew Member Self-Management** | Teams that work together but manage their own time | Each member manages their own work independently. Good for organizations that bill for time spent on work. |
| **Cascade and Accept Cascade Completely** | One person + equipment | All members can manage all work throughout all statuses. |

> [!NOTE]
> The logic associated with crew strategies affects bookable resource bookings related to work orders. If an assigned resource marks their own booking to *Completed*, the end-time is updated to the current time stamp. However, if another user or crew member marks the booking to *Completed* on behalf of an assigned resource, the end time remains unchanged.
>
> Crew strategies influence the rescheduling of crew bookings when there are changes made to an associated resource booking.

### Add members to the crew

Relate other bookable resources to the crew as crew members. If not done already, [create the bookable resources](../../field-service/set-up-bookable-resources.md). To select a leader for the crew, the resource type must be *User*.

1. On a resource crew record, go to **Related** > **Resource's Children**.

1. Select **New Bookable Resource Group**.

1. Enter a name, the **Child Resource**, and the date range when the resource is part of the crew.

1. Choose the **Crew Member Type** and specify if the resource is a member of the crew or its leader.

1. Select **Save & Close**.

:::image type="content" source="../../field-service/media/scheduling-crew-resource-children.png" alt-text="Screenshot of child resources of a resource crew.":::

> [!TIP]
> The start and end location of resources are important to book onsite requirements. The system takes crew member locations from their individual resource profiles and not from the parent crew. Change the location of the crew member resource if a resource moves between crews. For example, if you want a crew to meet at a central location in the morning, specify start and end location as organization unit address for both the crew header resource and the resource children.

## Step 2: Schedule the crew

There are two ways to schedule a crew. Choose the approach that matches your scenario:

| Approach | Use for | Details |
|---|---|---|
| **Single requirement** | One job that the whole crew handles together | Book a single requirement to the crew. The system automatically creates a [requirement group](../../field-service/multi-resource-scheduling-requirement-groups.md) and books all members. |
| **Requirement group** | Multiple requirements that need different skills | Use the [schedule assistant](../../field-service/schedule-assistant.md) with a requirement group. The assistant suggests crew combinations that fulfill all requirements. |

> [!NOTE]
> To schedule a requirement to a crew with schedule assistant, set the requirement's resource type to **Crew**.

### View crews on the schedule board

Crews and their individual members show on the schedule board like any other resource. Crew resources use a different icon than individual resources, and the time range a resource is part of a crew shows as a grey area on the board. Crews that match the board's filters show in the resource list, even if individual crew members don't match.

:::image type="content" source="../../field-service/media/scheduling-crew-schedule-board.png" alt-text="Screenshot of a schedule board with individual resources, a crew, and a crew member.":::

Scheduling a job to an individual crew member affects the availability of the entire crew.

### Single requirement details

Assign a single requirement to the crew resource type to create a booking for the entire crew using the schedule board or schedule assistant. If you assign a requirement to a single crew member instead of the crew, only that resource gets a booking.

Booking a crew books all members if both conditions are met:

1. The booking falls within the **From Date** and the **To Date** configured for the crew member's bookable resource group.
1. Work hours are configured for the crew member on the booking day, and the booking falls within those work hours.

> [!NOTE]
> A requirement group is automatically created and all bookings are linked to it, keeping crew bookings in sync. The **Auto Group Type** is set to **Crew**. However, only the crew header resource is linked to the single requirement in the newly created requirement group.

### Requirement group details

Scheduling a set of requirements to a group of resources that works together is the primary use case for crews. The schedule assistant suggests a group of individual resources and a crew to complete a requirement group. The crew resource itself is just a container — expand it to see member-to-requirement matching.

The booking for each crew member relates to the requirement that they match and to the requirement group. The crew resource also gets a booking so you can manage the crew as a single unit.

> [!NOTE]
> **Crew size vs. requirements**: If a crew has more members than the requirement group needs, it still shows in results but ranked lower (less optimal). Excess members get bookings linked to the requirement group but not to a specific requirement. If a crew has fewer members than needed, the schedule assistant combines crew members with individual resources to fulfill all requirements.

## Step 3: Manage daily changes

Use the **Crew Allocation** tool to quickly swap crew members for a single day — for example, if a team member calls in sick and needs a substitute. You can edit up to 15 crews at once.

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

After the membership changes conclude, bookings begin to cascade asynchronously. New members get active bookings moved until after the day of the assignment in the crew. Removed members get their existing crew memberships split with a full day gap. If there are small overlaps without bookings, the conflicting memberships are resolved in favor of the target crew (for example, when moving a resource between crews in different time zones).

> [!NOTE]
> If the leader on a leader-managed crew is moved to a different crew, they lose their leadership status for that day, even if they're returned to their original crew. To select a new leader or to restore this status, edit the crew resource directly.
