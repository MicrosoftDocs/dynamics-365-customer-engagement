Facility scheduling is for work that happens at your location — the customer travels to you. Use facility scheduling when customers bring devices or vehicles to a repair center, appointments happen at a company office or clinic, or you need to reserve physical spaces like rooms, bays, or docks.

## Facility scheduling at a glance

| Step | What you do | Key detail |
|---|---|---|
| **1. Create a facility resource** | Create a bookable resource with type **Facility** and a valid address. | The facility's location comes from its organizational unit. |
| **2. Create a requirement** | Create a requirement (typically in a requirement group) with **Work Location** set to **Facility**. | Travel time is calculated from the customer to the facility. |
| **3. Book the facility** | Use the schedule assistant or schedule board to book the appointment. | The assistant filters to show only facility-type resources. |

## Prerequisites

- A [bookable resource](../../field-service/set-up-bookable-resources.md) with resource type **Facility** and a valid address (latitude/longitude).
- A requirement with **Work Location** set to **Facility**.

## Step 1: Create a facility resource

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

## Step 2: Create a requirement for a facility

1. Go to **Resource Scheduling > Requirement Groups** and select **New**. Enter the requirement name and select **Save**.

1. In the bottom pane, select the requirement group and then **Requirement**. Enter a time range and duration for the requirement.

1. Select the requirement, enter a name, and then **Open Form**.

   :::image type="content" source="../../field-service/media/scheduling-facility-requirement-group.png" alt-text="Screenshot of a requirement in a requirement group with Open Form highlighted." lightbox="../../field-service/media/scheduling-facility-requirement-group.png":::

1. On the **General** tab, select **Facility** for the **Resource Type** to indicate this requirement requires a facility. Schedule assistant looks for facility resources to fulfill this requirement.

1. On the **Scheduling** tab, enter the following information:

   - **Work Location**: Facility to indicate the work takes place at the facility.
   - **Latitude** and **Longitude**: Latitude and longitude coordinates of the customer's location. These values can be entered through workflows.

1. Select **Save & Close**.

## Step 3: Book the facility

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

## Facility variations

Choose the facility setup that matches your scenario:

| Variation | Use when | How it works |
|---|---|---|
| **Single facility with capacity** | You don't need to track specific rooms or bays | One facility resource with a capacity setting allows concurrent bookings. |
| **Multiple facilities** | You need to schedule specific rooms or bays | Create individual facility resources and relate them through an organizational unit. |
| **Facility pool** | You want to defer specific facility assignment | A [pool](../../field-service/resource-pools.md) of facilities; book to the pool, assign a specific facility later. |

> [!NOTE]
> **Facility pool location**: The location for a facility pool is taken from the parent organizational unit. If a facility resource is a member of a facility pool, the location of the facility is taken from the pool resource. For example, if you create a facility at **location A** and add it to a pool at **location B**, the facility is considered located at **location B** for as long as it remains in the pool.

### Booking location

When a team is selected and booked, the latitude and longitude of the booked facility/facility pool's location is stored on the booking record. The work location is set based on the work location used when booking in the schedule assistant. In the following conditions, the work location, latitude, and longitude are set on the booking:

- If bookings are created without using the schedule assistant.
- If the requirement's work location is set to facility.
- There are latitude and longitude values on the requirement.