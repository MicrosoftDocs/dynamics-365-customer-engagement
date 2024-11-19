Enabling an entity for scheduling allows dispatchers to schedule the requirements related to that entity to the matching resources.

## Prerequisites

- **Field Service - Administrator** or **System Administrator** security role.

## Enable an entity for scheduling

Enable an entity for scheduling.

1. In Resource Scheduling, change to the **Settings** area. Under **Scheduling**, select **Administration**. Select **Enable Resource Scheduling for Entities**.

   :::image type="content" source="../../field-service/media/enablescheduling.png" alt-text="Screenshot of scheduling settings showing the Enable Resource Scheduling for Entities option.":::

1. In the **Enable New Entity** section, under **Add Entity**, choose an entity from the list.

   > [!TIP]
   > If the entity you want to enable doesn't show in list, update the **Can be customized** setting to **True** for [the managed property](/dynamics365/customer-engagement/customize/set-managed-properties).

1. For **Booking Relationship** and **Requirement Relationship**, choose **Create New Relationship**. Or, if you have an existing relationship to the *bookable resource booking* or *resource requirement* entities, select it.

1. Select **Publish Customization**.  

## Disable scheduling for an enabled entity

Turn off scheduling for a previously enabled entity.

1. In Resource Scheduling, change to the **Settings** area. Under **Scheduling**, select **Administration**. Select **Enable Resource Scheduling for Entities**.

1. In the **Enabled Entities** section, double-click the entity you want to disable.

   :::image type="content" source="../../field-service/media/enablescheduling-wizard.png" alt-text="Screenshot of the Enable Scheduling Wizard for Entities.":::

1. A new tab with the booking setup metadata for the selected entity opens. Select **Deactivate** in the command bar and confirm the deactivation.

## Edit settings for enabled entities

Edit booking settings for entities you enabled for scheduling.

1. In Resource Scheduling, change to the **Settings** area. Under **Scheduling**, select **Administration**. Select **Enable Resource Scheduling for Entities**.

1. In the **Enabled Entities** section, double-click the entity you want to edit. A new tab with the booking setup metadata for the selected entity opens.

    | Setting | Effect | Value |
    |---|---|---|
    | Default booking duration | Defines the default duration of a new booking. | Predefined set of duration options. |
    | Default booking committed status | Sets the default value to use when a booking moves into *Committed* state. | Available [booking statuses](../../field-service/set-up-booking-statuses.md). |
    | Default requirement active status | Sets the default value to use when a requirement moves into *Active* state. | Available requirement statuses. |
    | Default requirement canceled status | Sets the default value to use when a requirement moves into *Canceled* state. | Available requirement statuses. |
    | Resource availability retrieval limit | Defines the maximum number of resources returned as a result in the   scheduling assistant. | Number. |
    | Enable quick book | Use the [quick book experience](../../field-service/quick-scheduling.md) on an entity record. | Yes: Use quick book experience.<br>     No: Use schedule assistant experience. |
    | Cancel bookings when moving | Cancel bookings when moving the booking to a different time slot by using the *Move bookings* feature on the schedule board. | Yes: Cancel booking and create a new one in the updated time slot.<br>     No: Keep booking and update start/end time. |
    | Default booking canceled status | Sets the default value to use when a booking moves into *Canceled* state. | Available [booking statuses](../../field-service/set-up-booking-statuses.md). |
    | Disable requirement auto creation for   bookings | Defines if the system creates a requirement for a booking. | Yes: Disable automated requirement creation.<br>     No: Enable automated booking creation. |
    | Default requirement completed status | Sets the default value to use when a requirement moves into *Completed* state. | Available requirement statuses. |
    | Available duration minimum (%) | Defines the availability of a resource in relation to the booking duration. For example, if the value is 50 and the booking takes four hours. The system only considers resources for the job that have at least two hours available. | 0 to 100. |

1. In the **Attribute Mapping** section, choose values on the target entity that match with the requirement fields.

1. **Save** your changes.
  
An entity is successfully enabled for scheduling when:

- *Resource Requirements* shows as a related entity. Create them manually or with a custom workflow.
- The **Book** option appears on the entity record.
