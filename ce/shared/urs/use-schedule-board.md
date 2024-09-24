This article discusses the main features and concepts of the schedule board for dispatchers and other users.

:::image type="content" source="../../field-service/media/schedule-board-callouts.png" alt-text="Screenshot of the new schedule board in Dynamics 365.":::

|Number  |Area  |
|---------|---------|
|1     | [Actions area](#actions-area)        |
|2     | [Resource list](#resource-list)        |
|3     | [Requirement pane](#requirement-pane)        |

## Actions area

### Filters

Apply filters to define which resources show on the schedule board. You can [configure the board settings so filters also apply to requirements](../../common-scheduler/schedule-board-tab-settings.md).

Filter values are pulled from the *Bookable Resource* entity.

Select the ellipsis (&hellip;) > **Select Resources** to choose a subset of all resources for the schedule board. Applying filters then only filters the selected resources.

To make the applied filter configuration the default for all schedule boards, select **&hellip;** > **Save as default**.

Select **Reset to default** to remove all applied filters. The list of selected resources resets when you remove the resources from the selection.

You always have to select **Apply** to see the changes on the schedule board.

### Time scale

Switch between hourly, daily, weekly, and monthly view on the board. Choose the weekly or monthly views to see scheduled jobs at a higher level.

### View type

- **Gantt**: A Gantt chart is a type of bar chart that illustrates a schedule. It's commonly used in show activities displayed against time. The position and length of an activity reflects the start date, duration, and end date.
- **List**: Shows resources in a list. Expanding a resource shows the selected time granularity in the selected time frame. You can change columns in the list.

### Date range

Set the time frame that shows on the board. Use the arrows to move between time frames.

### Book

Book a requirement manually. Select a requirement and a resource, start date/time, end date/time, booking status, and booking method.

### Move bookings

Select **Show more schedule board actions** (&hellip;) > **Move bookings** to move bookings of a specific status to a different day. Moving bookings preserves times and other parameters.

### Print schedule board

Select **Show more schedule board actions** (&hellip;) > **Print schedule board** to open the print settings where you can set schedule range, pagination, paper format, and orientation. Select **Print** open the system print options.

### Contextual details

To see more details about the selected booking, resource, or requirement, open the details pane.

### Booking alerts

To see your active booking alerts or create new alert, select the bell icon. For more information, see [Create and view booking alerts](../../common-scheduler/booking-alert.md)

### Map view

To see resources and requirements on a map, select the **Map view** icon.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board with map view.](../../field-service/media/Schedule-Board-New-Map-02.png)

On the map view, select a resource to see their planned route. The numbers indicate in which order requirements are scheduled to a resource.

Change the date to see the map for a different day. Zoom out of the map, to see grouped requirements and resources. Quickly identify areas with unscheduled jobs and start scheduling these jobs to the nearest resources. Select **View settings** to set which items show on the map.

You can drag an unscheduled requirement pin from the map to the resource timeline and schedule it to that resource. You can also drag the resource route to a nearby unscheduled requirement to schedule it and add it to the resource route.

On each resource pin associated with a user, there is an indicator icon in the lower-right corner representing how long ago the resource's location has been detected. Green indicates that the user has logged on and been detected since the start of the current day, while a grey question mark indicates that the location was last detected yesterday or earlier. 

### Refresh board

The schedule board refreshes automatically if there are changes in the start date, end date, resource assignment, or status of a booking. Automated refresh only considers changes to bookings in the current week.

Select **Refresh** to manually refresh the schedule board.

> [!TIP]
> Availabilities in the scheduling assistant don't refresh when the schedule board gets refreshed. Search for availabilities again or refresh the browser to have the latest updates on the schedule board reflected in the availabilities.

### Focus mode

Focus on the details of the schedule board and hide all other navigation items.

Select the **Focus mode** icon to change to full screen mode.

### Legend

View all color codes and icons for  status, priority, timeline, and travel time. Select the ellipsis (&hellip;) > **Legend**.

### Board view settings

Select the ellipsis (&hellip;) > **Scheduler settings** to open the board view settings. For more information about board view settings, see [Configure the schedule board tab settings](../../common-scheduler/schedule-board-tab-settings.md).

## Resource list

Right-click a resource's name and to show more options about the resource.

- Choose **View resource card** to see details like the resource's skills and roles. From here, you can also initiate a message, email, or phone call.
- Choose **Get driving directions** to get the driving directions for a work day.

## Requirement pane

The requirement pane is where you find unscheduled requirements. Each column can be sorted and filtered by accessing a drop down menu next to each column header. 

> [!NOTE]
> Filtering is not supported on the **Owner** column on the *Unscheduled Work Orders* tab

Select a single requirement from the requirement pane and select **Find availability** to launch the [schedule assistant](../../common-scheduler/schedule-assistant.md).

The schedule assistant lists available and matching resources that you can book for the requirement.

## Bookings on the timeline

You can move a booking to a resource on the current schedule board tab, or change the start date/time, or both

Right-click the booking on th schedule board and select **Move to**. Reassign the booking to any resource on the current schedule board tab, or change the start date and the start time of the booking. To assign the booking to a resource that doesn't show on this schedule board, select the filter icon in the resource field and change the filter from **Resources on this tab** to **All resources**. Select **Update** to apply the changes.

## Create a new schedule board tab

To create a new schedule board tab, select **New schedule board tab** (+) in the tab list on the schedule board.

Enter the [relevant details about your new schedule board](../../common-scheduler/schedule-board-tab-settings.md) and select **Add**.

## Copy the link to a schedule board

The schedule board is accessible through a URL that loads the web resource. The simplest way to access this URL is to configure the schedule board as you prefer, select **More options (&hellip;)** and choose **Copy link**. The generated link includes the parameters currently configured on your board.

:::image type="content" source="../../field-service/media/schedule-board-copy-link.png" alt-text="Screenshot of the Copy link option on the schedule board.":::

For more information about how to construct the URL, see: [Open the schedule board from a URL](../../common-scheduler/schedule-board-url.md).

## Cached settings when loading the schedule board

To facilitate workflows, some parameters are cached so you can quickly can continue where you left:

- Last accessed tab 
- Map panel: Open or closed 
- Viewtype: Gantt or list view 
- Viewmode: Hourly/daily/weekly 
- Board start date: Cached for 15 minutes
- Column width: Zoom level
- Requirement panel filters
