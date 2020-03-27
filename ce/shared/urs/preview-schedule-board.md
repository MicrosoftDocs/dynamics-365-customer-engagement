A fully redesigned schedule board is available as a public preview in the April 2020 release of Dynamics 365 Field Service. In this article, we'll take a look at what's new, and how to preview the new schedule board in your environment. 

The new schedule board is faster, with better usability, and it lays the foundation for new capabilities for multi-day scheduling and intelligent interactions.

> [!div class="mx-imgBorder"]
> ![Screenshot of the new schedule board in Dynamics 365](../../field-service/media/schedule-board-new.png)


### Performance

The new schedule board is faster and more responsive when: 

- Loading the schedule board
- Selecting schedule board tabs
- Dragging and dropping work orders
- Rescheduling bookings


> [!div class="mx-imgBorder"]
> ![Screenshot of the new schedule board.](../../field-service/media/schedule-board-new-accessability.png)

### Usability and accessiblity

The new schedule board is a PowerApps Component Framework (PCF) control built on the Unified Client Interface, making it more flexible, supportable, and accessible. The new schedule board will work better on different screen sizes and across form factors. 

New color schemes and ways of depicting travel time make it easier for dispatchers to see statuses and details.

> [!div class="mx-imgBorder"]
> ![Screenshot of an outlined "ghost booking" to preview a schedule on the schedule board.](../../field-service/media/schedule-board-new-drag.png)

For instance, the previous screenshot shows a new "ghost booking" feature that helps dispacthers know if a booking will fit into a schedule before the booking is even scheduled.

### Foundation for new capabilities

The new schedule board provides the foundation for future releases that will provide dispatchers insights and recommendations to improve schedules.

## Prerequisites

> [!Note]
> The new schedule board is released as a public preview in April 2020. It has limited capabilities during the preview period. 

 

## Enable new schedule board preview

Once you enable the new schedule board, you'll see it in your envornment alongside the current schedule board. Once the new schedule board functionality matches the current schedule board, the new will replace the current.

To enable the new schedule board, sign in as a system administrator.

Go to **Resource Scheduling** > **Settings** > **Administration** > **Modify Schedule Board Settings**.


> [!div class="mx-imgBorder"]
> ![Screenshot of scheduling settings showing the "Modify schedule board settings" option.](../../field-service/media/schedule-board-new-admin.png)

1. Go to **Controls** tab.
1. Enable it for web experience.
1. Select the edit button then **Enable Preview**. **Optional:** choose a default schedule board.
1. Publish changes.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board settings with attention to the controls option, along with the publish option.](../../field-service/media/schedule-board-new-enable-preview-pcf-control.png)

Go to the schedule board and use the toggle button in the top right of the schedule board to switch between the current and preview schedule boards. 


> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board showing the preview toggle in the top right set to "On."](../../field-service/media/schedule-board-new-enable-preview.png)

## Configuration considerations

- During preview, the new schedule board is only available in English. 
- The new schedule board will currently only appear within the Universal Resouurce Scheduling app - not yet available in other apps.
- After enabling the preview, if you uninstall the Universal Resource Scheduling solution, you'll have to disable the schedule board again.
- The new schedule board is currently supported on Edge, Chrome, and Firefox browsers. Currently, Internet Explorer 11 is not supported.

### When to use the new versus current schedule board

Users who perform simple drag and drop scheduling or users who only need to view the schedule board can use the new schedule board during preview. Other users should continue to use the current schedule board.

Continue to use the **current** schedule board for common functions like:
- Creating and deleting schedule board tabs. 
- Schedule board tab settings.
- Schedule board configurations like number of days in a view or applying filter territories.
- Map view and scheduling.
- Days, weeks, and months view.