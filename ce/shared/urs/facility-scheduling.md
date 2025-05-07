Universal Resource Scheduling (URS) enables organizations to schedule interactions between customers and company resources. For scenarios where the customer is expected to travel to the company's location, the facility scheduling feature can coordinate physical spaces and related resources.

Typical examples include:

**Reserving a physical space**

- Reserve a room for an event or party
- Reserve a room for an exercise class
- Reserve a bay at a mechanic shop
- Reserve a boat

**Reserving an appointment with a person at a facility**

- Laptop repair at a Microsoft retail store
- Wealth management consultation at bank branch
- Doctor's office with related nurse and doctor

In general, to use facility scheduling, you create a facility resource, configure a requirement that calls for the facility resource, and book the requirement. In the following example, an auto repair shop in Redmond, Washington wants to schedule their auto repair bay. Create a facility resource to represent the repair shop, create a requirement to represent the customer's request for an appointment, and then book the appointment.

## Create a facility resource

1. Go to **Resource Scheduling > Resources** and select **New**. Select **Facility** as the **Resource Type** and enter a name for the facility and the time zone.

1. On the **Scheduling** tab, enter the following information:

   - **Start/End location**: Organizational Unit Address.
   - **Organizational Unit**: The organizational unit where the facility is located. The organization must have a latitude and longitude value that represents the location of the facility.
   - **Display on Schedule Board**: Yes
   - **Enable for Availability Search**: Yes

1. Select **Save**.

1. (Optional) Add related characteristics, territory, resource roles, and work hours to distinguish facility resources from other facilities and resources.

   For example, if an auto repair shop uses certified mechanics or offers shuttle service, you can add them as characteristics or resource roles to the facility resource. These optional components can influence which facility resources are filtered and displayed on the schedule board or which facility resources are returned during a schedule assistant search.

1. Select **Save & Close**.

## Create a requirement for a facility

1. Go to **Resource Scheduling > Requirement Groups** and select **New**. Enter the requirement name and select **Save**.

1. In the bottom pane, select the requirement group and then **Requirement**. Enter a time range and duration for the requirement.

1. Select the requirement, enter a name, and then **Open Form**.

   :::image type="content" source="../../field-service/media/scheduling-facility-requirement-group.png" alt-text="Screenshot of a requirement in a requirement group with Open Form highlighted." lightbox="../../field-service/media/scheduling-facility-requirement-group.png":::

1. On the **General** tab, select **Facility** for the **Resource Type** to indicate this requirement requires a facility. Schedule assistant looks for facility resources to fulfill this requirement.

1. On the **Scheduling** tab, enter the following information:

   - **Work Location**: Facility to indicate the work takes place at the facility.
   - **Latitude** and **Longitude**: Latitude and longitude coordinates of the customer's location. These values can be entered through workflows.

1. Select **Save & Close**.

## Book a facility with the schedule assistant

When you book a requirement group for a facility, the schedule assistant automatically sets the **Work Location** filter to *Facility*. It considers availability of resources and other set requirement constraints, such as characteristics, organizational units, and categories.

Requirements that are part of a requirement group are scheduled via the **Book** button to trigger the schedule assistant. They aren't available to drag and drop on the schedule board. If your facility has single requirements, you can create the requirements through **Resource Requirements** and use the schedule board.

1. On the requirement group, select **Book** in the command bar.

   :::image type="content" source="../../field-service/media/scheduling-facility-requirement-group-book.png" alt-text="Screenshot of schedule assistant results.":::

   The Facility **Travel Time** and **Distance** calculations represent the time and distance between the facility resource (defined by the organizational unit location) and the customer's location (defined by the latitude and longitude on the requirement).

1. To remove the travel time and distance calculations from schedule assistant results, change the **Work Location** filter to *Location Agnostic*.

1. To book an appointment, select a time slot and then select **Book & Exit**.

## View a facility on the schedule board

To view facility resources on the schedule board, select **Schedule Board** and then filter by resource type and/or organizational units. There's currently no specific way to visualize every resource related to a facility on the schedule board, so use the resource filters.

:::image type="content" source="../../field-service/media/scheduling-facility-schedule-board-filter.png" alt-text="Screenshot of a facility booking on the schedule board.":::

Facility resources are displayed on the schedule board map based on the location of the related organizational unit.

## Facility scheduling examples

When creating requirements in the following scenarios, consider the following information:

- For requirements that aren't part of a requirement group, only facility or facility pool resources can return in the schedule assistant if **Work Location** is set to **Facility**.
- A resource can't be related to two facilities (child or association) at the same time.
- Manually scheduling a single requirement to a facility doesn't create records for all resources related to the facility.

The following examples show how to schedule multiple spaces at a facility or reserve an appointment with a person at a facility.

- [Scenario 1: Schedule a facility with five generic spaces](#scenario-1-schedule-a-facility-with-five-generic-spaces)
- [Scenario 2: Schedule a facility and a related resource](#scenario-2-schedule-a-facility-and-a-related-resource)
- [Scenario 3: Schedule a facility with three specific spaces](#scenario-3-schedule-a-facility-with-three-specific-spaces)
- [Scenario 4: Schedule a facility with two specific spaces and two related resources](#scenario-4-schedule-a-facility-with-two-specific-spaces-and-two-related-resources)

### Scenario 1: Schedule a facility with five generic spaces

An auto repair shop has five identical bays and schedulers don't need to book each bay specifically. They must, however, ensure that no more than five repairs are booked across all bays during any one time slot.

1. [Create a facility resource](#create-a-facility-resource). On the **Work Hours** tab, enable **Capacity** and set it to 5. For more information on capacity, go to [Add work hours](../../field-service/set-up-bookable-resources.md#add-work-hours).

1. [Create requirements](#create-a-requirement-for-a-facility).

1. Book the requirements at the facility. The facility resource shows as available and can be double-booked up to the capacity limit (in this case, five times).

> [!Note]
> Capacity scheduling is not intended for booking the same requirement multiple times, but rather to book multiple requirements. Rebooking a previously booked requirement will cancel the existing booking and create a new one.

### Scenario 2: Schedule a facility and a related resource

An auto repair shop offers transmission repairs including luxury cars. They have a mechanic that specializes in luxury cars. Schedulers want to schedule the specialized mechanic at their facility. You can associate a resource (user, account, or contact) to a facility.

1. [Create a facility resource](#create-a-facility-resource) for the auto repair shop.

1. Create a resource to represent the specialized mechanic.

   - Set the **Resource Type** to **User**, **Account**, or **Contact**.
   - Set the **Start/End location** to **Organizational Unit Address** and the organizational unit should be set to the same organizational unit of the facility resource (in this case, the auto repair shop). We recommend this setting, but it isn't required.

1. Associate the specialized mechanic resource to the facility resource.

   - From the facility resource, select **Related > Bookable Resource Association (Resource 2)**. This related entity is called Resource Associations (**msdyn_bookableresourceassociations**).
   - Select **New Bookable Resource Association**.
   - Enter a name, timeframe, and select the mechanic resource for **Resource 1**.

   :::image type="content" source="../../field-service/media/scheduling-facility-associate-resource.png" alt-text="Screenshot the association between the mechanic resource and facility resource.":::

1. [Create a requirement group](#create-a-requirement-for-a-facility) with one requirement for the facility (auto repair shop) and another requirement for the mechanic resource.

   - Set **Select** to **All** so that all requirements must be met.
   - Set **Part of Same** to **Resource Tree** so that resources from different locations aren't recommended for work at this facility. As an example, a mechanic associated with Facility B shouldn't be paired with Facility A.
   - Set duration, characteristics, or other criteria.
   - For each requirement, set the **Work Location** to **Facility** and the latitude and longitude fields for the customer's location.

1. Book the requirement group. Scheduling the requirement group creates a booking for the facility resource and the mechanic resource.

   :::image type="content" source="../../field-service/media/scheduling-facility-schedule-board-2-resources.png" alt-text="Screenshot of two bookings for each requirement in the requirement group, one for the facility and one for the mechanic resource.":::

> [!NOTE]
> Travel time and distance are calculated as the time and distance for the customer to travel to the facility. There's no travel calculation considered for the mechanic resource, as the assumption is that they are at the facility at the required time.

### Scenario 3: Schedule a facility with three specific spaces

An auto repair shop wants to schedule each individual bay at their facility. Create a pool of facilities to represent the auto repair shop and each individual bay.

1. [Create a facility resource](#create-a-facility-resource) for the auto repair shop where the **Resource Type = Pool** and **Pool Type = Facility**.

1. Create multiple facility resources to represent each bay.

   - Set **Resource Type** to **Facility** on each resource.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.  

1. Add each bay as a child resource to the repair shop facility resource pool.

   - From the auto repair shop facility pool resource, select **Related > Resource's Children**.
   - Select **New Bookable Resource Group** and add each bay resource as a child record to the parent facility pool.

   :::image type="content" source="../../field-service/media/scheduling-facility-room-specific-children.png" alt-text="Screenshot of all bay resources related as children to the auto repair shop facility.":::

1. [Create a requirement group](#create-a-requirement-for-a-facility). In this example, we're looking for two specific bays within the same auto repair shop. Create two requirements in the group.

   - Set **Part of Same** to **Same Location** to ensure each bay is at the same physical address.
   - Set duration, characteristics, or other criteria.
   - For each requirement, set the **Resource Type** to **Facility**.
   - For each requirement, set the **Work Location** to **Facility** and the latitude and longitude fields for the customer's location.

   > [!NOTE]
   > Latitude and longitude fields on all requirements within a group must be equal; updating the values on one requirement updates the others.

1. Book the requirement group. Two specific bays are recommended at the same location. The travel time and distance is calculated from the customer's location (latitude and longitude values on the requirement records) and the location of the facility resources (resource children organizational units).

   :::image type="content" source="../../field-service/media/scheduling-facility-schedule-assistant-specific-rooms.png" alt-text="Screenshot of schedule assistant results showing pairs of two bays each at the same location.":::

### Scenario 4: Schedule a facility with two specific spaces and two related resources

An auto repair shop wants to schedule specific bays at their facility to a pool of specialized mechanics who work at the facility. Create a pool of facilities and a pool of mechanics.

1. [Create a facility pool resource](#create-a-facility-resource) for the auto repair shop where the **Resource Type = Pool** and **Pool Type = Facility**.

1. Create facility resources to represent each bay.

   - Set **Resource Type** to **Facility** on each resource.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.

1. Add each bay as a child resource to the repair shop facility resource pool.

   - Open the auto repair shop facility pool resource, and go to **Related > Resource Children**.
   - Add each bay resource as a child record to the parent facility pool.

1. [Create a pool](../../field-service/resource-pools.md) of specialized mechanics. Using a pool allows schedulers to book appointments based on capacity without having to assign a specific mechanic at the time of scheduling.

   - Set **Resource Type** to **Pool**.
   - Set **Pool Type** to **Contact**, **User**, or **Account**.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.
   - Set **Derive Capacity from Group Members** to **Yes** so that the capacity of the pool is based on how many mechanics are associated to it.

1. Create resources to represent the specialized mechanics.

   - Set the resource type to **User**, **Account**, or **Contact**.
   - Set the **Start/End Location** to **Organizational Unit Address** and select the same organizational unit as the auto repair shop.

1. Add the mechanic resources as [resource children to the mechanics pool](../../field-service/resource-pools.md).

   :::image type="content" source="../../field-service/media/scheduling-facility-mechanic-pool-children.png" alt-text="Screenshot of relating mechanics as children to the parent mechanic pool.":::

1. Associate the mechanic pool to the facility pool.

   - From the facility pool, select **Related > Bookable Resource Association (Resource 2)**. This related entity is called Resource Associations (**msdyn_bookableresourceassociations**).
   - Select **New Bookable Resource Association**.
   - Enter a name, timeframe, and select the mechanic pool for **Resource 1**.

   :::image type="content" source="../../field-service/media/scheduling-facility-associate-mechanic-pool.png" alt-text="Screenshot of associating the mechanic pool to the auto repair facility pool.":::

1. Create a requirement group for bays and mechanics.

   - Set **Part of Same** to **Resource Tree** to ensure bays and mechanics are related to the same facility resource through resource children or resource association.
   - Set duration, characteristics, or other criteria.
   - Create a requirement for each bay.
   - Create a requirement for the pool of mechanics. Set the **Resource Type** to **Pool** and **Pool Type** to **Contact**, **User**, or **Account** depending on how you set up your mechanics.

   :::image type="content" source="../../field-service/media/scheduling-facility-mechanic-pool-req-group.png" alt-text="Screenshot of requirement group showing 2 bays and a pool of mechanics.":::

     > [!TIP]
     > If you want specific mechanics to show in the results rather than the pool, set the **Resource Type** to **Contact**, **User**, or **Account** depending on how you set up your mechanics.

1. Book the requirement group.

   :::image type="content" source="../../field-service/media/scheduling-facility-mechanic-pool-bookings.png" alt-text="Screenshot of schedule board with available booking slots for the bays and mechanic pool.":::

   > [!NOTE]
   > Use fulfillment preferences to display schedule assistant results in neat hourly timeslots.

## When to use "facility with capacity," "multiple facilities," and "facility pool"

- **Facility with capacity**: Use this option when schedulers care most about not overbooking, and either don't need to schedule specific facilities or can handle coordination in person when customers arrive at the facility. Configure this option by adding a capacity to a single facility.

- **Multiple facilities**: Use this option when each facility needs to be scheduled individually. Configure this option by creating multiple facility resources and relating them to each other through an organizational unit.  

- **Facility pool**: Use this option when schedulers want to:
  - Utilize capacity scheduling by having the facility pool capacity increase and decrease as facilities are added or removed and
  - Use local scheduling where bookings are first assigned to the facility pool and then later assigned to pool members
  
  For example: a hotel (facility pool) is first scheduled for a weekend and travelers are assigned specific rooms (facility pool members) at a later date when they arrive. Configure this option by creating a facility pool and adding facilities as pool members.

### Facility pool location

The location for a facility pool is taken from the parent organizational unit. If a facility resource is a member of a facility pool, the location of the facility is taken from the pool resource. For example, if you create a facility with a location/organizational unit of **location A**, and you add this facility to a pool, which is located at **location B**, the facility is considered as located at **location B** for as long as it remains in the pool.

### Booking location

When a team is selected and booked, the latitude and longitude of the booked facility/facility pool's location is stored on the booking record. The work location is set based on the work location used when booking in the schedule assistant. In the following conditions, the work location, latitude, and longitude are set on the booking:

- If bookings are created without using the schedule assistant
- If the requirement's work location is set to facility
- There are latitude and longitude values on the requirement
