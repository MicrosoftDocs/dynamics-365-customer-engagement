# Single Resource Optimization

Single resource optimization provides a quick and simple way to re-optimize the schedules of a selected resource from the schedule board. This is done to ensure the resource continues to have an optimal schedule and route after schedule changes and cancellations occur during the day. For example, a resource may have overlapping bookings after getting assigned an emergency Work Order or arriving late due to traffic during the day.

>![Screenshot of triggering single resource optimization from schedule board](media/rso-single-resource-1.png)



## Prerequisites:

• Resource Scheduling Optimization v2.8+

• Bookable Resource record must have **Optimize Schedules** set to **Yes**

• There must be a default goal in Resource Scheduling Optimization > Optimization Goals. Note that a default goal is created when optimization is deployed

There are two ways to use the single resource optimization feature from the schedule board:

(1) **One click with defaults:** Optimize the schedules for a single resource with one click using the default goal with a time range set to the end of the current day. Performed from any schedule board view.

**Note:** One click with defaults requires Field Service v8.0+

(2) **Advanced with edits:** Optimize the schedules for a single resource with the option to edit the goal and time range as well as the option to run as a simulation and apply or discard the results. This is only possible from the schedule board view related to your optimization scope.

(1) **Once click with defaults:**

a) From the schedule board, right click the Resource's name, then click Optimize Schedule to start optimization for a selected resource
>![Screenshot of triggering single resource optimization from schedule board](media/rso-single-resource-2.png)


b) Yellow line indicates default optimization range, from NOW to end of today (12am)

c) Gray mask indicates default optimization range, from NOW to end of today (12am)

d) Optimization Panel showing selected resource name, default range, default goal, and optimization request status
>![Screenshot of single resource optimization with range and goal](media/rso-single-resource-3.png)


(2) **Advanced with edits:**

a) Customize optimization range to any date/time as needed

b) Select different optimization goal as needed

c) **Run Now** will run the optimization and schedule bookings
>![Screenshot of single resource optimization pane with options](media/rso-single-resource-4.png)


d) **Run Simulation** will run the optimization and schedule simulated bookings shown as white. User can apply/discard simulation results. **Note:** Simulated bookings will not show on map with routes.

e) Optimization Panel showing optimization request status
>![Screenshot of running single resource optimization with simulation mode](media/rso-single-resource-5.png)

## Additional Notes

- A default goal is required for single resource optimization to work. A default goal is auto created when deploying optimization as seen in the image below.

- Single resource optimization will only re-optimize existing bookings and will not create new bookings.

- Single resource optimization can be applied to, and will re-optimize, bookings that were originally booked manually or via resource availability search as well as bookings from location agnostic requirements.

- This feature will show on the schedule board for all resources given optimization is deployed in the environment; however, it will only work if the selected Bookable Resource has Optimize Schedules set to Yes. This feature cannot be disabled or hidden.

>![Screenshot of default goal deployed with Resource Scheduling Optimization](media/rso-single-resource-1.png)
The above picture is the default goal Resource Scheduling Optimization creates when deployed and can be edited.

# Other Enhancements

## Default optimization goal

When Resource Scheduling Optimization is deployed for the first time, the system will automatically create a default goal with some constraints and objectives enabled. As a reminder, a goal in Resource Scheduling Optimization is what the tool aspires to optimize. An example of a 2 goals is to maximize working hours or minimize travel time.

- Default goal has below constraints and objectives enabled, user can modify as needed

>![Screenshot of default goal in scheduling parameters](media/rso-default-goal-1.png)
>![Screenshot of ](media/rso-default-goal-2.png)


- The default goal is used when single resource optimization is selected from the schedule board.
>![Screenshot of default goal deployed with Resource Scheduling Optimization](media/rso-single-resource-1.png)

- If needed, a user can create a new optimization goal and associate it as a default goal

## Enabled constraint for matching resource type

The latest version of Resource Scheduling Optimization has a new constraint called **Matches Resource Type**. As a reminder, a constraint is a resource and requirement attribute the optimization considers when automatically assigning jobs. With this new constraint, the optimization will match the resource type between requirements and resources to decide which type of resource can fulfill a requirement. This brings Resource Scheduling Optimization functionality closer to functionality available for Resource Availability Search.

Bookable Resources can have different resource types including:

• Generic *

• Users *

• Contacts *

• Accounts *

• Equipment *

• Facility *

• Crew

• Pool

\* indicates resource types the optimization will consider

In general, resource types define how the resource relates to the organization. As an example, resources with resource types of User are generally employees, whereas resource types of contacts or accounts may signify contractors.

Additionally, Requirements have a multi-select option to specify which resource types are desired for the given requirement.

>![Screenshot of multi-select resource type attribute on requirement](media/rso-requirement-resource-type-field.png)

With the new release, the optimization will now consider resource types of requirements when assigning resources to those requirements, if the resource type is one of the following:

• Generic

• Users

• Contacts

• Accounts

• Equipment

• Facility

To enable this feature, navigate to Optimization Goals and add it as a constraint.

>![Screenshot of match resource type constraint in optimization setup](media/rso-resource-type-constraint.png)
>![Screenshot of match resource type constraint in optimization setup close up](media/rso-resource-type-constraint-close-up.png)

If the Optimization Goal is related to an active Optimization Schedule, you will need to republish the schedule.

## Additional Notes

• Resource Scheduling Optimization will ignore requirements where resource type = pool or crew.

• If a requirement has resource type = user and crew (ie one resource type that is considered by optimization and one that is not) the optimization will attempt to find a User resource to fulfill the requirement.