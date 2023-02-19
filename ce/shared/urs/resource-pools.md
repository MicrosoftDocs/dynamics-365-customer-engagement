Resource pools are groups of similar resources. Dispatchers manage capacity and get the option to assign resources later.

Resource pool scheduling is useful in several situations:

- Avoid booking specific resources right away. For example, a hotel checks room availability (pool) and assigns a room (resource) to guests when they arrive.  

- Collect requirements centrally but let a local resource manager book them. For example, a repair shop chain takes appointments through a call center. The central agent books the appointment to the customer's preferred location (pool). The local store manager assigns appointments to an available specialist (resource).

- Dispatchers know the capacity of a pool but not yet the specific resource it'll contain.  For example, a trade show offers different booth options. it considers the capacity of booths (pool) when booking, but assigns the specific booths (resource) later.

- Enable overbooking for expected cancellations. For example, a hotel has a fixed number of rooms, but may inflate capacity and take more reservations than available rooms to account for cancellations.

## Create a resource pool

We recommended creating pools that use the same resource type. If you want to create groups with different types of resources, [create a crew](../../field-service/resource-crews.md).

1. From either the Field Service or Universal Resource Scheduling solution, go to **Resources** > **Active Bookable Resources** view > select **New**.  

2. Set **Resource Type** to **Pool**.

3. Choose a **Pool Type**. Pool types can either be set to: Facility, Equipment, or any combination of Account/Contact/User.

1. Enter a **Name**.

1. Select a **Time Zone**.

> [!div class="mx-imgBorder"]
> ![Screenshot of pool resource.](../../field-service/media/scheduling-facility-create-pediatrician-pool.png)

6. Set **Start Location** and **End Location** to **Organizational Unit Address**, and assign an organizational unit with latitude and longitude values because the pediatricians work at a defined health clinic.
   1. Start and End Locations can be set to either **Organizational Unit Address** to represent a physical location where the pool works, or **Location Agnostic** for a pool of resources that will perform work remotely (for example, customer service phone calls). Resource address is not an option, as pools are currently excluded from **Onsite** scheduling (requirements where Work Location is set to Onsite).
7. Set **Derive Capacity From Group Members** to **Yes**.
   1. **Setting to Yes**: Capacity will increase and decrease as pool members are added to or removed from the pool. In our example scenario, we set to "yes" because it allows us to add 5 pediatricians to the pool in the next step. This also allows the pediatrician pool to be booked up to 5 times for any single time slot. 
   2. **Setting to No**: The capacity of the pool will default to one and can be manually edited. Pool members can still be added and removed. See scenario 2 in this article for more details.  
8. Add more pool resource attributes.
   1. You can add any additional information about the pool that you would like considered when it comes to scheduling. Consider the pool as a standard resource as it relates to adding skills, roles, organizational units, territories, and so on. For example, if you have a requirement that requires “skill A,” when searching for availability using the schedule assistant, only pools with “skill A” will be considered.

## Add pool members

Members can be added to a pool through the bookable resource group entity (bookableresourcegroup).

1. From the pool you created, go to **Related > Resource Children**.

> [!div class="mx-imgBorder"]
> ![Screenshot of pool children view.](../../field-service/media/scheduling-facility-pediatrician-pool-children.png)

2. Select **+Add New Bookable Resource Group**, and:
   1. Assign a **Name**.
   2. In the **Resource 2** field, select the resource you would like to add to the pool.
   3. Select a **Date Range** during which the resource will be part of the pool. This will affect capacity if the pool is set to derive capacity from pool members.
   4. Repeat these steps for each pool member.

> [!Note]
> Resources can be associated as children of the pool with date effectivity. For example, on Monday, Resources 1, 2, and 3 can make up the pool, while on Tuesday, resources 4, 5, and 6 can make up the pool. To do this: 
> 1. Create a new bookable resource group record.
> 2. Set the parent resource to the pool, and the child resource to the resource that is in that pool.
> 3. Set the **From Date** to the date and time that the resource is part of the pool and set the **To Date** to the date and time when the resource is no longer associated to the pool.



## Scenario One: Schedule a pool; assign specific resources later

In our first scenario, the office staff at a health clinic wants to book patient appointments with pediatricians. Because there are five pediatricians working each day, the office staff must ensure that no more than five appointments are scheduled during any single time slot. However, though appointments are booked weeks or even months in advance, specific pediatricians aren't assigned to an appointment until the day before because of variable schedules. 

To accommodate this scenario, we'll create a pool to represent the pediatricians, schedule appointments to the pediatrician pool, and then reassign appointments to specific doctors within the pool. 

## Book a pool with the schedule assistant

1. Select **Book** at the top of the requirement form to trigger the schedule assistant.

> [!div class="mx-imgBorder"]
> ![Image of schedule assistant results for pool resource.](../../field-service/media/scheduling-pools-single-requirement2.png)

2. When searching for availability for a requirement or requirement group, both the pool and its child resources (pool members) can be returned in the results.

3. Select the pool resource and a time slot (in this example, our pediatrician pool and the 9:00 AM - 10:00 AM time slot), and select **Book & Exit**.


- Resource pools won't display in schedule assistant results for requirements where **Work Location = Onsite**. By default, work order-related requirements are set to onsite. Only requirements with a **Work Location = Facility** or **Location Agnostic** will show up in schedule assistant results. 
## Manage a pool on the schedeule board



### Add the pool to the schedule board

1. Next up, go to **Universal Resource Scheduling** > **Schedule Board**.
2. Add the pool resource by adjusting the schedule board filters the same way you would add any resource to the schedule board.
   1. In this example, we select **Resource Types** of **Pool** and **Pool Types** of **Account, Contact, User** because this matches our pediatrician resource pool. 
3. Right-click the resource pool and select **View Resources in Split View** to see the pool and pool members.
4. Select **Options > Save Current Filters as Default** to save the changes made to the schedule board tab for the next time you visit.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board with the pool resources exposed.](../../field-service/media/scheduling-pools-add-schedule-board.png)

### View overbooking on the schedule board

1. Go to **Universal Resource Scheduling** > **Schedule Board**.
2. Expose the hotel pool to the schedule board by filtering for **Resource Types** of **Pool** and **Pool Types** of **Facility**.
3. View the hotel pool and all related pool members (rooms) by right-clicking the hotel pool resource and selecting **View Pool Resources in Split View**.

> [!div class="mx-imgBorder"]
> ![Image of viewing facility pools in split view with overbooking.](../../field-service/media/scheduling-pools-facility-schedule-board.png)


Load the **Hourly** Schedule Board and find your pool resource. Right click the Pool Resource and choose to **View Pool Resources in Split View**. This will split the Schedule Board and a new dedicated Schedule Board will be displayed showing just the Pool and its members. Based on the dates being displayed on the Schedule Board, only the members of the pool with membership during that date range will appear in the Pool Schedule Board. If a resource is part of the pool for only some of the days being displayed on the Schedule Board, they will be displayed, and there will be a mask that shows the days where they aren't part of the pool.

Here we see five bookings at the 9:00am time slot. 

> [!div class="mx-imgBorder"]
> ![Image of 5 bookings for a pool during the same time slot.](../../field-service/media/scheduling-pools-single-requirement5.png)

> [!Note]
> The Schedule Board **sorting** functionality applies to the split view, but the Schedule Board **filtering** functionality does not.

### Step 4: Create a single requirement

Now we'll schedule a requirement to our newly created resource pool.

1. Go to **Universal Resource Scheduling > Resource Requirements > +New**.
2. Enter a **Name**.
3. Select a **From Date** and **To date**. These values become **Search Start** and **Search End** dates in the schedule assistant.
4. Enter a **Duration**.
5. Set resource type to **Pool** and **Pool Types** to **Account, Contact, User**. This ensures our pediatrician pool shows in results.
      1. This also allows you to decide which types of resources should be searched when searching for availability using the schedule assistant on a requirement. If this field is left empty, all resource types are searched. If certain values are selected, then only those resource types are considered. 
6. Add other constraints like as characteristics. In this example, we want resources with "Pediatric" skills, as seen in the following screenshot.

> [!Note]
> In our example, the requirement group field on the requirement record is blank. This means that this is a single requirement intended to be scheduled to one resource. One benefit of single requirements is that they can be scheduled and rescheduled by manual drag and drop. This is useful if dispatchers want to manually reschedule bookings from a pool to a pool member.  
 
> [!div class="mx-imgBorder"]
> ![Screenshot of requirement for pools.](../../field-service/media/scheduling-pools-single-requirement1.png)





### Step 7. Reassign pool bookings to specific pool members

Fulfilling our scenario, the health clinic office staff members want to assign specific pediatric doctors as an appointment nears.

From the schedule board split view, we'll accomplish this three ways:

1. **Manually drag and drop**: Select and drag a booking from the resource pool and drag it to one of the pool members.

> [!div class="mx-imgBorder"]
> ![Image of dragging a booking from a pool to a resource.](../../field-service/media/scheduling-pools-single-requirement6.png)


2. **Substitution**: Right-click a booking for the resource pool, select substitute resource, then select a pool member.

> [!div class="mx-imgBorder"]
> ![Image of triggering substitution from a pool booking.](../../field-service/media/scheduling-pools-single-requirement7.png)


3. **Rebook**: Right-click a pool booking and select **Rebook**. Edit the filter criteria to no longer search for pools, but to search for Contact, User, and Account type resources.

> [!div class="mx-imgBorder"]
> ![Image of editing resource types.](../../field-service/media/scheduling-pools-single-requirement8.png)

When rebooking a previously fulfilled booking, the duration will default to the default booking duration as defined in **Universal Resource Scheduling > Settings > Administration > Enable Resource Scheduling for Entities > Booking Setup Metadata**.

Therefore, as seen in the following screenshot, you must edit the end time to match the original duration.

> [!div class="mx-imgBorder"]
> ![Image of schedule assistant.](../../field-service/media/scheduling-pools-single-requirement10.png)

Finally, cancel the original pool booking.

> [!Note]
> You can also create a custom booking status to match your business needs, rather than changing the status to cancelled.

> [!div class="mx-imgBorder"]
> ![Image of cancelling a pool booking.](../../field-service/media/scheduling-pools-single-requirement11.png)

As an alternative to rebooking from the schedule board, go to the requirement record, edit the resource types, and book again. 

> [!div class="mx-imgBorder"]
> ![Image of resource types on requirement.](../../field-service/media/scheduling-pools-single-requirement9.png)


## Scenario two: Overbook a pool for expected cancellations

In our second scenario, hotel managers want to make reservations for travelers by first checking for specific date range availability, and then assigning the traveler a specific room when she arrives. Furthermore, hotel managers want to overbook the hotel to account for expected cancellations.

To accommodate this scenario, we'll create a pool of facilities with extra capacity to represent the hotel rooms, schedule reservations to the hotel pool, and finally reassign reservations to specific rooms within the hotel pool.

<!--
### Step 1. Create a pool resource

First we'll create a pool resource to represent the hotel.

1. From the Field Service or Universal Resource Scheduling solutions, go to **Resources** > **Active Bookable Resources** view > and select **+New**.
2. Set **Resource Type** to **Pool**.
3. Set **Pool Type** to **Facility**.
4. Enter a Name.
5. Set **Start Location** and **End Location** to **Organizational Unit Address**.
6. Assign an **Organizational Unit** from the lookup to represent the location of the hotel.
   1. The selected organizational unit must have latitude and longitude values. 
7. Set **Derive Capacity from Group Members** to **No**.
   1. This time, we manually override capacity to allow for overbooking, rather than have the number of facilities in the pool (for instance, the number of rooms in the hotel) dictate capacity.


> [!div class="mx-imgBorder"]
> ![Image of facility pool resource record.](../../field-service/media/scheduling-pools-facility-hotel.png)

### Step 2. Create and add pool members

   1. Create resources with **Resource Type** set to **Facility** to represent each room in the hotel.
   2. Go to the hotel pool resource you created in the previous step and add each room resource as a child by selecting **Related > Resource Children**.  

> [!div class="mx-imgBorder"]
> ![Image of navigating to resource children from facility pool.](../../field-service/media/scheduling-pools-resource-children-nav.png)


> [!div class="mx-imgBorder"]
> ![Image of facility pool children, in this case rooms in a hotel.](../../field-service/media/scheduling-pools-resource-children.png)


### Step 3. Manually add additional capacity

   1. While on the hotel pool resource, go to **Show Working Hours** at the top of the form.
   2. Select **Show Capacity**.
   3. Enter the desired capacity. In this example, we use a capacity of six though our pool has only five child resources (in other words, five rooms).

> [!div class="mx-imgBorder"]
> ![Image of working hours in a capacity.](../../field-service/media/scheduling-pools-overbook-capacity.png)

### Step 4. Create requirement

Now we'll create a requirement to represent a reservation for a traveler.

1. Go to **Universal Resource Scheduling > Resource Requirements > +New**.
2. Fill out **Name**, **Date Range**, **Duration**, and any other constraints.
3. Set **Resource Type** to **Pool**.
4. Set **Pool Type** to **Facility**.
   1. This ensures our hotel pool will be considered in schedule assistant results.
5. Set **Work Location**:
   1. In our hotel booking example, work location is set to **Facility**, which means the requirement takes place at a physical space (the hotel). In order to show facilities relative to the customer's (traveler's) location, a latitude and longitude can be entered on the requirement to represent the customer's location. As a reminder, we set the hotel's location when we set up the pool resource. These settings are useful in scenarios where the hotel may have many locations and the scheduler wants to use time and distance calculations when communicating to the customer.
   2. If schedulers don't need travel or distance information about the customer, set to **Location Agnostic** and leave latitude and longitude blank. 
   3. For more information on the **Work Location** field, visit our [topic on facility scheduling](/dynamics365/field-service/facility-scheduling#configuration-considerations).

> [!div class="mx-imgBorder"]
> ![Image of requirement for facility pools.](../../field-service/media/scheduling-pools-overbook-requirement.png)

### Step 5. Book requirement

Select **Book** at the top of the requirement form to trigger the schedule assistant. Up to six requirements (reservations) can be booked for a single time slot. 

The schedule assistant results in the following screenshot assume five reservations have already been scheduled to the hotel, and the scheduler is attempting to book a sixth reservation as extra capacity.

> [!div class="mx-imgBorder"]
> ![Image of schedule assistant results for overbooking a facility pool.](../../field-service/media/scheduling-pools-facility-overbook-schedule-assistant.png) -->



- **Location of Pool Members**: If a resource is the child of a pool through a bookable resource groups (bookableresourcegroup) record, the location of the child resource is taken from the pool. Additionally, if a resource pool is related to a facility or facility pool resource through bookable resource association (msdyn_bookableresourceassociation), the location is taken from the facility or facility pool.

- When a pool resource has **Derive Capacity from Group Members** set to **Yes**, the pool's capacity for a given time slot is affected by: 
  - the number of pool members 
  - the dates the pool members are part of the pool and 
  - the working hours of the pool members

 
### Choosing the right resource type

Whether the pool resource, pool members, or both show in schedule assistant results depends on the resource types selected on a requirement record. If the resource type **Pool** is selected, and if the resource pool has availability along with all other matching constraints expressed on the requirement, the pool itself can return as an option to book. If the resource type **Pool** is **not selected** on the requirement, pool members can still return in the results, presuming that the pool member’s resource type is checked off on the requirement. If no resource types are selected, all resource types are considered.

For example, consider a requirement that only has resource type **Account** selected, a resource with resource type **Pool**, and pool type of **Account, Contact, User**. In this example, the pool resource itself won't be returned in the schedule assistant search, but the child pool members (with resource type **Account**) will be returned by the schedule assistant. 

### Using characteristics with pools

The same logic that is applied to the requirement resource type attribute applies to all constraints. Consider the following example: a requirement has a required characteristic called **Electric Vehicle Mechanic**. There's a pool that has the characteristic **Mechanic**, but not **Electric Vehicle Mechanic**. The pool has a child member that has both the characteristics **Mechanic** and **Electric Vehicle Mechanic**. 

When running the schedule assistant on the requirement, presuming availability, the pool resource itself won't be presented to book since it is missing the required characteristic (**Electric Vehicle Mechanic**), but the pool member will be presented since the resource has the necessary characteristic for this job. The reason for this is that the pool members should have all the attributes expressed on the pool, but they may have additional attributes as well if they have specialties. Since not all the pool members have these additional attributes, like the **Electric Vehicle Mechanic**, if this requirement gets booked to the pool and the one pool member who has this characteristic isn't available as the appointment time nears, what happens? Who will be assigned to this booking currently booked to the pool? You may not have other resources to pick up the work. Therefore, the idea is to book the actual resource itself to ensure that this unique job has coverage.

 
## Additional notes

### Pool availability affects member availability and vice versa

Being part of a pool can severely limit a resource's ability to be scheduled. Resources can't be expected to operate as part of a pool and independently at the same time. If a pool resource itself is booked to capacity for a given time slot, pool members won't show as available for that time slot and vice versa. If all pool members are booked for a given time slot, the pool won't show as available for that time slot. Conversely, if different members of the pool have availability at different times, then the pool will show as available throughout.

#### Example 1: Pool resource only

When searching for availability, the schedule assistant will look at the pool capacity set on the pool resource, and will subtract existing bookings that are booked to the pool resource itself, or any of the pool’s child resources. Consider a pool's capacity is set to ten. Let’s also assume there are no child resources for this pool. When finding availability using the schedule assistant, the pool will be looked at as if there are ten resources associated to the pool. 

For example, let’s say you're searching for a 30-minute requirement. If the pool has ten bookings from 10:00 to 10:30, the pool won't be recommended for the requirement between 10:00 AM and 10:30 AM. This is because the total capacity of the pool at 10 AM is ten, but there are ten bookings scheduled to this pool resource at 10:00 AM. However, if the pool only has 9 bookings between 10:00 AM and 10:30 AM, then the pool can be recommended.

#### Example 2: Pool resource and child resources 

If the bookings for the pool and its members exceed the total capacity established on the pool, every resource in the pool and the pool itself is considered unavailable. But if there's overall aggregate availability, then each resource still has its own availability calculation. For example, consider if a pool resource has a capacity of ten, and there are 9 bookings between 10:00 AM and 10:30 AM on the pool resource, and the child resource has one booking from 10:00 to 10:30. In this case, since in aggregate the pool and its children have as many or more bookings (ten) than the capacity on the Pool (ten), the entire pool and its child resources are considered unavailable for that timeframe (10:00 AM to 10:30 AM). 

However, if the pool resource has 8 bookings and the child resource has 1 booking, since this is a total of 9 bookings, the pool and its child resources won't be removed between 10:00 and 10:30. In this case, the pool itself will show as available, however the child resource won't return as available since there's already a booking at 10:00 AM for the child resource.

#### Example 3: Pool resource and child resources 

Pool will be shown as available whenever there's at least a single child resource available at each point of time during the desired time range, but it does not have to be the same resource throughout. When searching for availability, the schedule assistant will look at the pool capacity set on the pool resource, and will subtract existing bookings that are booked to the pool resource itself, or any of the pool’s child resources. This means that the capacity calculation is done without considering which specific resource will be available. 

For example, assume there are two child resources for a pool and so the pool capacity is 2. Let's assume that the child resource #1 already has a booking between 10:00 AM and 11 AM, and child resource #2 has a booking from 11 AM to 12 PM. Let's say that you're searching for a new 2-hour requirement. In this case this pool would show as available between 10:00 AM and 12:00 PM even though no single resource is available for 2 hours continuously and the requirement would be satisfied only when split into multiple segments. This behavior occurs because the capacity of the pool is calculated collectively without considering which child resource has capacity since they are treated as equivalent resources. That means that the dispatcher might want to check child availability and adjust the bookings to make them continuous.

