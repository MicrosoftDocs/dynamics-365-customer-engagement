
When a requirement is scheduled to a resource, the system creates a booking record. The schedule board displays bookings grouped by resources. The fields displayed in the schedule board booking are called a *Booking Template*, which you can customize wioth fields from out-of-box entities.

## Edit work order booking template

Each scheduling-enabled entity can have a different booking template. When a work order requirement is scheduled, the booking template shows the *Bookable Resource Booking* record's **Name** and **Duration** values.

> [!div class="mx-imgBorder"]
> ![Screenshot of Standard booking visualization.](../../field-service/media/standard-booking-visualization.png)

The default value contains the following HTML code snippet.

```HTML
<div>{SchedulableEntityDisplayName} - {name}<br />Duration: <strong class="bold">{duration}</strong></div>
```

To edit the HTML that controls the booking template, go to the **Schedule Types** section in the schedule board settings. Select the entity for which you want to change the booking template. If you open the settings from a schedule board tab, you'll change the settings for that tab only. To make changes to all tabs, select **Edit defaults** and apply your changes there. Set the **Custom booking template** to **On** and change the HTML code.

In this example, we'll choose the work order entity.

> [!div class="mx-imgBorder"]
> ![Screenshot of Schedule board settings - booking template.](../../field-service/media/schedule-board-settings-booking-template.png)  

In the **Booking Template** field, override the booking template by entering HTML and CSS that can reference fields from the *Bookable Resource Booking* entity and linked entities.

Here's an example that pulls values from the work order that relates to the booking.

```HTML
<div style="line-height: 11px !important; width: 99%; overflow: hidden; display: block; text-overflow: ellipsis;">
    WO: 
    <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_name}</b><br/>
    Account: <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_account_msdyn_workorder_ServiceAccount.name}</b><br/>
    Incident: <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_primaryincidenttype}</b><br/>
    Duration: <b>{duration} minutes</b><br/>
</div>
```

> [!TIP]
> Use out-of-box system entities only. Pulling values from custom entities isn't supported.
>
> To avoid typing mistakes, go to **Customization** > **Entities** > **Bookable Resource Bookings** and copy the field names. Fields from the *Bookable Resource Booking* entity can be referenced directly using the field name in curly brackets. Example: `{duration}`.
>
> If you want to display a field from a linked entity, find the name of the N:1 relationship and add a period (.) followed by the field name of the target entity. For example, the work order relationship path is *msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder* and the primary incident type field is *msdyn_primaryincidenttype*. This results in field reference `{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_primaryincidenttype}`.
>
> Add more relationship hops by connecting them with an additional period.

## Advanced booking template styling using CSS

Add customer rating and service call icons to the booking template based on conditional values on the account and work order records.

For example, a dispatcher can see a customer rating on the schedule board to prioritize bookings. A customization has added a field *new_customerrating* on the *account* entity and propagates that field to the work order entity with an integer range from 1 to 10. Using the approach above, you can add this field as a text value.

in this scenario, we want the booking template to visualize the customer rating with grey stars. To represent the actual customer rating, we'll overlay five orange stars, but only show a percentage of these, corresponding to the 1-10 customer rating.

We also want our dispatcher to see whether a work order is a service call or another type of job. The custom field *new_isservicecall* on the *work order* entity, has two possible values: 0 or 1. Using the same approach as above, we first draw a gray wrench as background, overlay an orange wrench and limit its size to 0% (new_isservicecall = 0) or 100% (new_isservicecall = 1).

Go to **Resource Scheduling > Administration > Scheduling Parameters** and set **Disable Sanitizing HTML Templates** to **Yes**. This is required to be able to include CSS statements into the booking templates.

Add the following HTML and CSS text to **Booking Template** field in **Schedule Board Tab Settings**.

```HTML
<div style="line-height: 11px !important; width: 99%; overflow: hidden; display: block; text-overflow: ellipsis;">
<div class="back-stars" style="color: #AAAAAA; position: relative; display:inline-block;">
    <i class="fa fa-star" aria-hidden="true"></i>
    <i class="fa fa-star" aria-hidden="true"></i>
    <i class="fa fa-star" aria-hidden="true"></i>
    <i class="fa fa-star" aria-hidden="true"></i>
    <i class="fa fa-star" aria-hidden="true"></i>
<div class="customerrating" style="width:{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_account_msdyn_workorder_ServiceAccount.new_customerrating}0%; color: #FFBC0B; position: absolute; top: 0; left:0; overflow: hidden; display:-webkit-box">
    <i class="fa fa-star" aria-hidden="true"></i>
    <i class="fa fa-star" aria-hidden="true"></i>
    <i class="fa fa-star" aria-hidden="true"></i>
    <i class="fa fa-star" aria-hidden="true"></i>
    <i class="fa fa-star" aria-hidden="true"></i>
</div>
</div>
<div class="repair-back" style="color: #AAAAAA; position: relative; display:inline-block; padding-left:10px; vertical-align:text-top;">
    <i class="fa fa-wrench" aria-hidden="true"></i>
<div class="repair" style="width:{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.new_isservicecall}00%; color: #FFBC0B; position: absolute; top: 0; left:0; padding-left:10px; overflow: hidden; display:-webkit-box">
    <i class="fa fa-wrench" aria-hidden="true"></i>
</div>
</div>
<br/>
WO:
<b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_name}</b><br/>
Account: <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_account_msdyn_workorder_ServiceAccount.name}</b><br/>
Incident: <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_primaryincidenttype}</b><br/>
Duration: <b>{duration} minutes</b><br/>
</div>
```

The booking template on the schedule board now contains a visual representation of the customer rating and the type of job.

> [!div class="mx-imgBorder"]
> ![Screenshot of final booking template.](../../field-service/media/final-booking-template.png)
  
> [!NOTE]
> Make sure to test customized booking templates on multiple browsers and consider best practices for accessibility.
