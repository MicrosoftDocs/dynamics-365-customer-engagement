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

The crew strategy determines how the crew manages its work. There are three options:

- **Crew Leader Management**: Crew leader manages the work of a crew. Consider this option when a crew consists of multiple people. You can designate more than one user to be a leader and manage the work.
- **Crew Member Self-Management**: Resources can manage their own work. Choose this option for crews that are groups, which regularly work together, but may not always work together at the same place or time. Self-management also means better time capturing, which is good for organizations who bill for time spent on work.
- **Cascade and Accept Cascade Completely**: All resources on a crew can manage all the work. It's the ideal option when a crew consists of one individual and the rest of the crew is equipment.

> [!NOTE]
> The logic associated with crew strategies will only impact work order related bookable resource bookings. If an assigned resource updates their own booking to *Completed*, the end-time value is updated to the current time stamp. If another user or crew member updates a booking status to *Completed* on behalf of an assigned resource, the booking end time preserves the previous end time value.
>
> Crew strategies affect if and how a crew booking is rescheduled. For example, if a crew leader's bookings change, all bookings of the crew are moved.

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

To access the crew allocation tool, go to the the **Resources** page and open a view that has at least one crew type resource. Select **Crew Allocation** in the command bar. Crews show in the tool according to their order in the view. You can edit up to fifteen crews simultaneously.

### Crew allocation tool features

- Crew membership grid: Each crew has information about the number of resources that are available and expected for that crew, and the crew's time zone. An added resource is a member of that crew that from 12:00am to 12:00am in the crew's time zone. Resources that are assigned to the crew is listed alphabetically if they have a membership range that includes the majority of the given day in the crew's time zone.
- Bookings grid: Beneath the members, there is a collapsible grid section of all the bookings that crew has for the day. These bookings are not manipulable in the Crew Allocation tool but can be clicked to open the record for more details.
Available Resources Panel
Beneath the crews grid is the Available Resources panel. This is a list of resources that have working hours and are not members of  any crew for the active day. As they cannot be assigned to crews, resources with types Crew, Pool, or Generic will also not be listed. Note that this list does not factor in any bookings the resource may have for the day or their open capacity, simply that they are working on this day.  This list is based on the views defined in the Resources page and the view can be changed by using the dropdown/search at the top of the panel.  Users can also search for resources by name using the search box. Note that prior to saving any resources removed from a crew using the view will appear at the top of the first page of the list, regardless of the selected view. 
TIP: Note that the size of the Crews Grid and the Available Resources panels can be adjusted by manipulating the grab point on the bottom right corner of the last crew. 
Using the Crew Allocation Tool
By default, the tool opens to the current day based on the computer’s local time. This can be changed using the date picker in the command bar. Note that any changes already made must be either saved or discarded before changing the active day.
Unsaved changes are noted by a blue flag in the corner of added resources’ cards and a blue icon next to a removed resource’s name in the Available Resources panel. No changes will be implemented until users click the Save or Save and Close button. 
Assign Members
The Crew Allocation Tool’s primary modality is drag and drop. Resources can be dragged from one crew to another or dragged up from the Available resource panel. Users can also use the Assign to Crew modal accessed through the button on the command bar or through the hover menu on each resource. This opens a drop down menu to select the target crew. 
Remove Members
To remove a resource, either select it and click Remove on the command bar or click remove on the three dot hover menu next to the resource name. You can also use the Remove All button in the command bar to clear the Crews grid. 
Multi-Select
To move multiple resources at a time from the Crews grid, hold the control/command key (depending on your operating system) while making your selection. To move multiple resources from the Available Resources panel, either hold control/command or use the check boxes next to the resources to define your selection. To multi-select from both components, make your selection in the Available Resources panel first, and then add resources from the Crews grid while holding control/command.  This multi-selection will apply to drag/drop, remove, and Assign to Crew. 
After the Save
Membership Changes
Immediately after saving, the membership changes will take effect. New members will get a full day membership in the target crew’s time zone. If this abuts an existing membership on either or both ends, the memberships will be merge. Removed members will have their existing memberships split, with a full day gap, if the existing membership spans longer than the crew's day on either end or shortened so as not to include the active day. If there are small overlaps without bookings, such as when moving a resource from a crew in one time zone to an adjacent time zone, the conflicting memberships will be resolved in favor of the target crew. While this action is in progress, no further changes can be made. 
Bookings Cascade
After the membership changes conclude, bookings will begin to cascade asynchronously. New members will have all active, non-cancelled bookings that take place entirely in the future and end on the given day added to their schedule. This means that if a booking has already begun, it will not be added to the new crew member’s schedule even it occurs on the active day. Similarly, if a booking ends after the active day, it will not be added. Members who are removed from a crew will have that days future crew bookings change status to cancelled. This may take up to a few minutes to finish processing in the background depending on the number of bookings and resources impacted. 
No changes will be made to an added/removed resource’s existing individual bookings for the day. 

TIP: For field service users working Crew Leader Managed crew strategies, note that when a resource that was previously a leader is added to a crew using the Crew Allocation tool, it will lose its leadership status. To make them a leader on their new temporary crew, please use the existing crew management system. 


