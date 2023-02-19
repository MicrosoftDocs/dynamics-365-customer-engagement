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

**Location of Pool Members**: If a resource is the child of a pool through a bookable resource groups (bookableresourcegroup) record, the location of the child resource is taken from the pool. Additionally, if a resource pool is related to a facility or facility pool resource through bookable resource association (msdyn_bookableresourceassociation), the location is taken from the facility or facility pool.

## Book a pool with the schedule assistant

1. Select **Book** at the top of the requirement form to trigger the schedule assistant.

> [!div class="mx-imgBorder"]
> ![Image of schedule assistant results for pool resource.](../../field-service/media/scheduling-pools-single-requirement2.png)

2. When searching for availability for a requirement or requirement group, both the pool and its child resources (pool members) can be returned in the results. When the resource type or characteristics of a pool don't match the requirement, the schedule assistant can return indivudal pool members that match the criteria.

3. Select the pool resource and a time slot (in this example, our pediatrician pool and the 9:00 AM - 10:00 AM time slot), and select **Book & Exit**.

- Resource pools won't display in schedule assistant results for requirements where **Work Location = Onsite**. By default, work order-related requirements are set to onsite. Only requirements with a **Work Location = Facility** or **Location Agnostic** will show up in schedule assistant results.
- Pool availability affects pool member availability and vice versa: Being part of a pool can limit a resource's ability to be scheduled. They can't operate as part of a pool and independently at the same time. If a pool resource itself is booked to capacity for a given time slot, pool members won't show as available for that time slot and vice versa. If all pool members are booked for a given time slot, the pool won't show as available for that time slot.

## Manage a pool on the schedule board

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


## Reassign pool bookings

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

