Dispatchers and service managers need to understand resource utilization to make better scheduling decisions, whether through assigning work orders to field technicians or reserving equipment for customer jobs.  

Utilization is defined as the proportion of time a resource is scheduled to work. More specifically, it is calculated as the percentage of booked time compared to working hours. In all schedule board views, utilization is automatically calculated and displayed in each resource's cell.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](../field-service/media/schedule-board-utilization.png)

Let's take a look at how resource utilization is calculated and displayed in the **Hours** and **Days** views of the schedule board.

## Prerequisites

Utilization is calculated and displayed on the schedule board for all versions of Field Service

## Hours view

For each resource, utilization percentage (%) is derived from: **Total booked hours / Total working hours** in the schedule board time frame.

**Total booked hours** = sum of the hours booked to the resource

**Total working hours** = sum of the resource's working hours

> [!Note]
> Working hours are defined on each Bookable Resource record. Go to **Resource Scheduling > Resources**. See the topic on [setting up bookable resources](../field-service/set-up-bookable-resources) for more details.

The above values will change based on how many hours, days, and weeks you are viewing, and these are edited by selecting a view, a date range, and how many days to display.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](../field-service/media/schedule-board-utilization-edit-time.png)

This is because as you view more days, the bookings and working hours will vary. 


In the Hourly view, the total working hours will be the sum of the hours seen on the Schedule Board as you scroll from the far left to the far right. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](../field-service/media/schedule-board-utilization-hourly-view.png)
 
In the previous example, Matthew works a 12 hour shift from 9AM to 9PM, this shift is repeated for 5 days shown as the user scrolls from left to right across the schedule board.

Therefore, Matthew’s total working hours in this hourly view are 12 X 5 = 60 hours.

If Matthew is booked a single 6 hour work order, then his utilization is 6 / 60 = 10%, as shown in his resource card.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](../field-service/media/schedule-board-utilization-hourly-view-booked.png)


If the duration of the Work Order is increased to 12 hours, then his utilization is 12 / 60 = 20%, as shown in his resource card below.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](../field-service/media/schedule-board-utilization-hourly-view-booked-more.png)

## Days view

In the Days view, the total working hours will be the sum of the hours seen on the schedule board.

In this case we see 10 days, so Matthew’s total working hours are 12 X 10 = 120 hours.

Matthew already has a 12 hour booking for one day, so his utilization % becomes 12 / 120 = 10%
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](../field-service/media/schedule-board-utilization-days-view.png)


## Configuration considerations

### Proposed and canceled bookings do not contribute to utilization

Though the field service process utilizes many field service booking statuses such as traveling, in progress, on break, and completed, each of those relate to a booking status of either **Committed**, **Proposed**, or **Canceled**. The purpose of a proposed status is to suggest work that needs to be confirmed and the canceled status is used to notify stakeholders that the booking is no longer scheduled. 

As an example, the **In Progress** field service status is categorized as **Committed** via the status field on the booking status entity.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](../field-service/media/schedule-board-utilization-in-progress-status.png)

Bookings that have a **proposed** or **canceled** booking status are ignored for utilization. 

As seen in the following example, Brady was assigned a proposed booking, but his utilization remained at 0%.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](../field-service/media/schedule-board-utilization-proposed.png)


### Sort schedule assistant results by utilization

When using the schedule assistant to book requirement groups, dispatchers have the option to sort results by utilization.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](../field-service/media/schedule-board-utilization-schedule-assistant-sort.png)