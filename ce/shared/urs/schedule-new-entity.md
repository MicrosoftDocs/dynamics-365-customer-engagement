Enabling an entity for scheduling allows dispatchers to schedule that requirements related to that entity to the matching resources.

## Prerequisites

- **Field Service - Administrator** or **System Administrator** security role.

## Enable an entity for scheduling

Learn how to enable an entity for scheduling.

1. In Resource Scheduling, change to the **Settings** area. Under **Scheduling**, select **Administration**. Select **Enable Resource Scheduling for Entities**.

   :::image type="content" source="../../field-service/media/enablescheduling.png" alt-text="Screenshot of scheduling settings showing the Enable Resource Scheduling for Entities option.":::

1. In the **Enable New Entity** section, under **Add Entity**, choose an entity from the list.

   > [!TIP]
   > If the entity you want to enable doesn't show in list, update the **Can be customized** setting to **True** for [the managed property](/dynamics365/customer-engagement/customize/set-managed-properties).

   :::image type="content" source="../../field-service/media/enable-entity.png" alt-text="Screenshot of the Enable Scheduling setting for entities.":::

1. For **Booking Relationship** and **Requirement Relationship**, choose **Create New Relationship**. Select an existing relationship if you've previously created relationships to the *bookable resource booking* or *resource requirement* entities

1. Select **Publish Customization**.  

## Disable scheduling for an enabled entity

To turn off scheduling for a previously enabled entity, select **Deactivate** in the ribbon on the *Booking Setup Metadata* record of the enabled entity.

:::image type="content" source="../../field-service/media/disable-entity.png" alt-text="Screenshot of the booking meta data record for work order with highlight on the Deactivate control.":::

## Edit settings for enabled entities

Edit booking settings for entities you enabled for scheduling.

1. In Resource Scheduling, change to the **Settings** area. Under **Scheduling**, select **Administration**. Select **Enable Resource Scheduling for Entities**.

1. In the **Enabled Entities** section, double-click the entity you want to edit. A new tab with the booking setup metadata for the selected entity opens.

   :::image type="content" source="../../field-service/media/booking-setup-metadata-record.png" alt-text="Screenshot of a booking setup metadata records with settings and attribute mapping.":::

    | Setting | Effect | Value |
    |---|---|---|
    | Default booking duration | Defines the default duration of a new booking. | Predefined set of duration options. |
    | Default booking committed status | Sets the default status when committing a booking. | Available [booking statuses](../../field-service/set-up-booking-statuses.md). |
    | Default requirement active status | Sets the default status to use when a requirement moves into active   state. | Available requirement statuses. |
    | Default requirement canceled status | Sets the default status to use when cancelling a requirement. | Available requirement statuses. |
    | Resource availability retrieval limit | Defines the maximum number of resources returned as a result in the   scheduling assistant. | Number. |
    | Enable quick book | Use the [quick book experience](../../field-service/quick-scheduling.md) on an entity record. | Yes: Use quick book   experience.<br>     No: Use pop-out scheduling experience. |
    | Cancel bookings when moving | Cancel bookings moving the booking to a different time slot. | Yes: Cancel booking and create a   new one in the updated time slot.<br>     No: Keep booking and update start/end time. |
    | Default booking canceled status | Sets the default status to use when cancelling a booking. | Available [booking statuses](../../field-service/set-up-booking-statuses.md). |
    | Disable requirement auto creation for   bookings | Defines if the system creates a requirement for a booking. | Yes: Distable automated   requirement creation.<br>     No: Enable automated booking creation. |
    | Default requirement completed status | Sets the default status when completing a requirement. | Available requirement statuses. |
    | Available duration minimum (%) | <!-- Andrew --> | <!-- Andrew --> |

1. In the **Attribute Mapping** section, choose values on the target entity that match with the requirement fields.

1. **Save** your changes.
  
You have successfully enabled an entity for scheduling when:

- *Resource Requirements* shows as a related entity. Create them manually or with a custom workflow. <!-- needs a link to a new article about creating resource requirements --> 
- The **Book** option appears in the top ribbon of an entity record.

> [!Note]
> As part of the Field Service solution, requirements are automatically created when work orders are created.


<!-- section below is a customization story for the schedule board. needs to live in SB config doc 


## Add a requirement view to the schedule board

After creating a requirement for the lead, it will appear in the **Open Requirements** view in the lower pane of the schedule board that shows all open requirements related to any schedulable entity. This is a default view for resource scheduling.

> [!div class="mx-imgBorder"]
> ![Screenshot of the open requirements pane on the schedule board.](../../field-service/media/scheduling-enable-entity-open-requirements.png)

However, the views in the lower pane of the schedule board are simply system views and can be edited and added to. It's common to add custom resource requirements views for work orders (or leads in our example). Let's create a schedule board view that shows only leads to be scheduled.

Go to **Settings** > **Customizations** > **Entities** > **Resource Requirement** > **Views**.  

> [!div class="mx-imgBorder"]
> ![Screenshot of the resource requirements views settings.](../../field-service/media/customizations-resource-requirements.png)

Create a new view and add fields to the view that provide details for what you are scheduling. Use the drop-down to capture fields from the entity (in this case, **Lead**). 

> [!div class="mx-imgBorder"]
> ![Screenshot of a list of possible entities, with "lead" selected](../../field-service/media/addleadentity.png)

Name the view using the properties or **Save As** functions. In this example, we will call it our new view "Unscheduled Leads." 


> [!div class="mx-imgBorder"]
> ![Screenshot of the "View Properties" form with the name "Unscheduled Leads" populated](../../field-service/media/createview.png)
 
Most importantly, edit the filter criteria to show the appropriate records. To ensure only the lead resource requirements will be displayed, select the **Lead** entity and filter the records appropriately.  


> [!div class="mx-imgBorder"]
> ![Screenshot of the filter criteria, with "Lead" highlighted](../../field-service/media/editfiltercriteria.png)
 
**Save**, then **Close & Publish**.  

Finally, we'll need to edit the schedule board we will be using in order to schedule the entity. 

Go to the schedule board and select the plus sign icon (+) to add a new tab.

> [!div class="mx-imgBorder"]
> ![Screenshot of the plus sign icon on the schedule board.](../../field-service/media/scheduling-enable-entity-add-tab.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of the add tab settings for leads.](../../field-service/media/newtab.png)

In the **Requirement Panels** section, add a **Title** and select the new view. 

Select the plus sign icon (+) to add the view.  

> [!div class="mx-imgBorder"]
> ![Screenshot of the requirements panel section.](../../field-service/media/addviewtoboard.png)
 
Select **Hide default requirement panels** if you don’t want to display the other tabs.  

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board with the new unscheduled leads view displayed.](../../field-service/media/scheduleboard-leads.png)

> [!Note]
> You may have many lead records in the system, but if there are no requirements related to the leads, then no records will show on the schedule board. Resource requirements will need to be created for each lead you want to schedule either manually or through a workflow to auto create upon creation of a lead.  
-->
