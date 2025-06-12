Universal Resource Scheduling (URS) allows organizations to schedule interactions between customers and company resources. For scenarios where the customer is expected to travel to the company's location, the facility scheduling feature coordinates physical spaces and related resources.

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

1. Open the **Resources** area, select **Resources** and then select **New**.

1. On the **General** tab, set **Resource Type** to **Facility** and enter a name for the facility and the time zone.

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

- If bookings are created without using the schedule assistant.
- If the requirement's work location is set to facility.
- There are latitude and longitude values on the requirement.