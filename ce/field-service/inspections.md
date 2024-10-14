---
title: Add inspections to work orders
description: Learn how to use inspections in Dynamics 365 Field Service.
ms.date: 09/25/2024
ms.topic: how-to
author: josephshum-msft
ms.author: jshum
---

# Add inspections to work orders

Create inspections and add them to work orders for Field Service technicians to fill out online. Learn more in [Inspections overview](inspections-overview.md).

This article provides an example of creating an inspection using a maintenance checklist on a customer asset.

## Prerequisites

- Dynamics 365 version 9.1.0000.15015+.

- Knowledge of work order [incident types and service tasks](configure-incident-types.md) is encouraged.

- **Field Service-Administrator** role to create inspection templates and associate them to service task types.

- **Field Service-Dispatcher** role to add service tasks with inspections to work orders.

- **Field Service-Resource** role to view work orders they're assigned to, along with work order service tasks and the related inspections.

## Create inspection

Create an inspection that can be reused and added to multiple work orders. We don't recommend trailing blank pages without questions in an inspection as it can cause deserialization errors in out-of-box flows.

1. In Field Service, change to the **Settings** area.

1. Go to **Work Orders** > **Inspection Templates** and select **New**. To create an inspection from an existing PDF or image with the help of Copilot in Field Service, see [Create inspections with Copilot](inspections-copilot.md).

   :::image type="content" source="./media/inspections-create.png" alt-text="Screenshot of a new inspection template.":::

1. Provide a **Name** for the inspection template and add an optional description. You can't change the name after the template is published.

1. Select **Advanced** and choose the look and feel of the inspection from the technician's perspective.

   - **Show title and description**: Show or hide the title and description of the inspection.
   - **Layout density**: To display answer areas underneath questions, select **Comfortable**. To display answer areas to the right of questions, select **Compact**.
   - **Show question numbers**: Show or hide the question numbers in the inspection.

1. Select **Toolbox** and fill out the inspection questions:

   - Enter the [question types](#question-types).
   - Use the **Required** toggle to make the inspection question mandatory.
   - To add more details for an inspection question, select the **Gear** icon and fill out the details.

1. To group questions together in an organized way, add pages from the **Page** dropdown menu. You can also use pages to make it easier to [add logic to multiple questions at one time](inspections-advanced.md).

1. In the **Preview** section, test the inspection from a technician's perspective.

1. In the **Designer** section, make changes if necessary. Then, select **Save**. The inspection is in a draft status so you can continue to make changes and add logic. When you think the inspection is ready, go to the next step.

1. To add the inspection into the work order process, a service task type must be associated with it.

   To automatically create the service task type, select **Publish and generate a new service task type** and then confirm.

   :::image type="content" source="./media/inspections-create-preview-publish.png" alt-text="Screenshot of the Field Service inspection, highlighting both the preview section and the publish option.":::

   To associate the inspection with an existing service task type or manually create the service task type, select **Publish**, confirm, and then [associate the inspection to a service task type](#associate-the-inspection-to-a-service-task-type).

### Question types

Add a question to the inspection by double-clicking or dragging a question type from the right side.

- **Textbox**: Allows technicians to enter text from their keyboard in a free form response. There's an option in the advanced panel to make the text box bigger to allow for multiline responses. In early access opt-in release, a text box can be input with a default value and can also be made as read-only.

- **Checkbox**, **Radiogroup**, **Dropdown**: Allows technicians to choose an answer from predefined options. The question types **Checkbox**, **Radiogroup**, and **Dropdown** are similar. The **Checkbox** question type is multi-select, whereas **Radiogroup** and **Dropdown** allow for a single answer. The difference between **Radiogroup** and **Dropdown** is cosmetic so choose based on the desired user experience.

- **Entity lookup**: Allows technicians to choose a Dynamics 365 record. In the inspection designer interface, admins must select an entity and a field to display. For a chosen entity, the **Name** field and mandatory fields are the entity attributes that can be displayed in the lookup. When the user types, up to the first 50 records that start with the search string appear in the dropdown. The first results might not contain all matches, so continue to add to the search string until the matching result starts showing on top. Entity lookup respects security roles of signed-in user, meaning some entities and records might not be displayed.

  - Add filters to review the records displayed in the entity-lookup options. For example, an entity-lookup inspection question created for the bookable resource record type. You can filter the list of bookable resources to ones with the resource type set to *User* to remove subcontractors and machines from the list.

- **Number**: Restricts input to numeric value or returns an error. Typically represents a measurement or numeric rating value.

- **Date Time**: Allows technicians to enter a date and time.

- **File**: Allows technicians to upload a file, take picture, or choose multiple pictures from their camera roll.

- **Barcode scan**: Allows technicians to populate the field with the barcode number by scanning a barcode with their device's camera. Choose "Textbox" question type, then select **Barcode** for input type in the **Advanced** section.

- **Matrix (Dynamic)**: Adds a grid of questions. More rows can be added dynamically while performing the inspection. See the following screenshot for an example.

  > [!div class="mx-imgBorder"]
  > ![Device render showing an inspection form allowing adding more rows.](./media/inspections-matrix-barcode.png)

### Associate the inspection to a service task type

Associate the inspection to a service task type. This association is necessary because inspections aren't added directly to work orders, they're added as part of **Work Order Service Tasks**.

1. In **Settings**, select **Service Task Types**.

1. Select an existing service task type or create a new one.

1. Enter the following information:

   - **Has Inspection**: Set to **Yes**.

   - **Inspection Template**: Select the inspection you created. The inspection form appears.

1. Select **Save & Close**.

It's common to add service task types to incident types in order to bundle work together. However, it isn't required because you can add individual service tasks to work orders.

## Add the inspection to a work order

1. [Create a new work order](create-work-order.md) and select **Save**.

1. Select the **Tasks** section and select **Add task**.

1. For **Task Type**, select the service task type you created that has an associated inspection.

1. Select **Save and Close**. The inspection can't be filled out until the task is saved. Once the technician completes the inspection, the completed inspection appears.

   :::image type="content" source="./media/inspections-service-task-work-order2.svg" alt-text="Screenshot of the tasks section on a work order in Field Service.":::

Alternatively, your inspection service task can be added to the work order via a work order incident type.

## Perform inspections on mobile

You can view and complete inspections on the [Dynamics 365 Field Service mobile app](mobile/overview.md).

1. Sign in and go to the assigned work order.

1. Select the service task that has the related inspection.

1. Find the inspection form and enter answers. If an inspection question is required, you must answer or you can't mark the task complete.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of mobile app showing a sample inspection.](./media/inspections-fsm-new2.png)

1. If needed, upload files, take pictures, or upload pictures from the phone's camera roll. When uploading a file or image, select the caption icon to add a comment. File attachments are limited to 3 MB per file, unless an administrator changes the limit. Inspections with a large number of files take time to load.

1. Select **Save**. Make sure you save the inspection before setting the service task to complete to avoid a business process error.

1. Select **Mark Complete** or set **Complete %** to 100.

1. Enter a **Result** to report on the overall inspection:

   - Pass
   - Fail
   - Partial Success
   - NA

1. Enter the actual duration the task took to complete.

1. Select **Save and Close**.

If needed, you can select  **More** > **Clear Responses** to start over, and permanently delete all responses for this service task inspection.

> [!NOTE]
> Only single responses are supported and you can't fill out the same inspection twice for a single task. If the responses are cleared or answered again, the original responses are deleted, and only the latest responses are saved.

## View responses

In the Field Service web app, a dispatcher can see the inspection responses by viewing the task in the work order. Dispatchers can't delete individual attachments in an inspection response. The out-of-the-box **Field Service-Dispatcher** role doesn't have the ability to delete inspection attachments. However, they can **Clear responses** and **Clear files**, which clears all attachments. If a dispatcher wants to delete individual attachments from an inspection, they must have delete privileges for the **Notes** entity.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
