---
title: "Dynamics 365 Field Service inspections | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/28/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Add inspections to work orders in Dynamics 365 Field Service

Field Service inspections are digital forms that technicians use to quickly and easily answer a list of questions as part of a work order. The list of questions can include safety protocols, pass and fail tests for a customer asset, an interview with a customer, or other audits and assessments performed before, during, or after a work order.

Compared to work order incident types and service tasks, using inspections has additional benefits:

- **Easier to create**: administrators can quickly create an inspection with a drag-and-drop interface without needing to create new entities and fields.
- **Easier to fill out**: technicians can quickly enter responses for each inspection question and save all of them with one click, rather than having to open and close multiple records.
- **More flexible and robust**: Field Service inspections have many question format and validation options, such as multi-option select, mandatory fields, images, attachments, and more. 

Inspections are easy to create and use, involving the following steps: 

1. Administrator creates an inspection template.
2. Administrator associates the published inspection to a **Service Task Type**.
3. Dispatcher adds the **Service Task Type** to a **Work Order**.
4. Technician completes the inspection.
5. View the inspection results.

In this article, we'll walk through an example of setting up an inspection using a maintenance checklist on a customer asset.

## Prerequisites

> [!Note]
> Inspection capabilities are released in April 2020 as part of a public preview. Follow the process in the article on [installing or upgrading preview features](field-service-preview.md). In Step 6, look for the preview flight with the display name **FieldService_April2020_PreviewFlight**.

- Dynamics 365 version 9.1.0000.15015+.

- Knowledge of work order [incident types and service tasks](configure-incident-types.md) is encouraged.


## Create inspection

First, create an inspection that can be reused and added to multiple work orders.

From the Field Service app, go to **Settings** > **Inspections** > **+New**.


> [!div class="mx-imgBorder"]
> ![Screenshot of active inspections in Dynamics 365 Field Service](./media/inspections-navigate.png)

Drag-and-drop your first question type from the right side. Then name your inspection and add a description.


> [!div class="mx-imgBorder"]
> ![Screenshot of a new example inspection, showing the toolbox with question types on the right side.](./media/inspections-create.png)

Use the **Required** toggle to make the inspection question mandatory.

The question types **Checkbox**, **Radiogroup**, and **Dropdown** are similar except the **Checkbox** question type is multi-select whereas **Radiogroup** and **Dropdown** allow for a single answer. 

The difference between **Radiogroup** and **Dropdown** is cosmetic and should be used based on desired user experience.

> [!div class="mx-imgBorder"]
> ![Screenshot of a Field Service inspection, showing additional questions](./media/inspections-create2.png)

By selecting the **Gear** icon, you can add more details for an inspection question. 


Use the **Preview** section to see the inspection from a technician's perspective.

> [!Note]
> Once you publish the inspection, you can't edit it in the preview version.

When finished creating the inspection, select **Publish** at the top. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the Field Service inspection, highlighting both the preview tab and the publish option.](./media/inspections-create-preview-publish.png)


## Associate inspection to service task type

Next, associate the inspection to a **Service Task Type**. This association is necessary because inspections are not added directly to work orders; they're added as part of **Work Order Service Tasks**.

In the same **Settings** section, go to **Service Task Types**.

Select an existing service task type or create a new one.

Set **Has Inspection** to **Yes**.

In the **Inspection** field, select the inspection you created.

The inspection form will appear below.

> [!div class="mx-imgBorder"]
> ![Screenshot of a new service task type in Field Service, pointing to the inspection that appears.](./media/inspections-service-task.png)


It's common to add service task types to incident types in order to bundle work together. However, this isn't required because you can add individual service tasks to work orders as we'll see later on. In the following image, the "Fire extinguisher inspection" service task was associated to the "Fire system maintenance" incident type.


> [!div class="mx-imgBorder"]
> ![Screenshot of an incident type showing the service tasks tab.](./media/inspections-service-task-incident-type.png)

> [!Note]
> In the April 2020 preview, an inspection can't be added or removed from a service task type that already has work order service tasks or incident type service tasks associated to it. If you try to change **Has Inspection** and **Inspection** fields in the service task type, you'll see an error.  Also, a published inspection cannot be deleted if it is associated to a service task type or any work order service task.

## Add inspection to work order

After creating a work order, go to the **Service Tasks** section and add the **Work Order Service Task** you created that has an associated inspection.

Then **Save**. The inspection cannot be filled out until the Work Order Service Task is saved. 

Alternatively, your inspection service task can be added to the work order via a work order incident type. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the service tasks tab on a work order in Field Service.](./media/inspections-service-task-work-order2.png)

An inspection completed by a technician will be visible on the bottom of the work order service task form.


> [!div class="mx-imgBorder"]
> ![Screenshot of a work order service task, showing the inspection form at the bottom.](./media/inspections-service-task-work-order-drill-down.png)

## Perform inspection 

After the work order is scheduled to the appropriate technician, they can see and complete the inspection by logging in to Field Service in a web browser on a mobile device or PC.

Sign in with your Dynamics 365 URL, username, and, and go to the assigned work order.

Select the **Work Order Service Task** (*not* the **Service Task Type**).

Find the inspection form and enter answers.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-mobile-web1.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-mobile-web2.png)


When finished, the technician can select **Mark Complete** at the top or set **Complete %** to 100. 

Enter a **Result** to report on overall inspection:
- Pass
- Fail
- Partial Success
- NA

Optionally, enter an **Actual Duration** that can be compared to estimated duration.

If an inspection question is required, the technician will not be able to mark **Complete** or set **% Completed** to 100 until it is answered.

If needed, a technician can select **Clear Responses** to start over. This will permanently delete all responses for this service task inspection.

## View responses

Back in Dynamics 365, a dispatcher will see inspection responses.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service on a desktop, showing the work order service task and the completed inspection form at the bottom.](./media/inspections-complete-web.png)

## Inspections for customer assets

To relate the inspection to a customer asset and build out service history, enter the customer asset in the **Service Task Relates To** section of the work order service **Task** that holds the inspection.

> [!div class="mx-imgBorder"]
> ![Screenshot of the work order service task showing the service task relates to section, highlighting an associated customer asset.](./media/inspections-wost-customer-asset.png)

Associating a customer asset allows the technician to see which customer asset needs the inspection. From the customer asset, they can see all related inspection history.


> [!div class="mx-imgBorder"]
> ![Screenshot of a customer asset on the work order service tasks section, showing the associated inspection.](./media/inspections-custoiner-asset-service-history.png)

> [!Note]
> If you relate a work order incident type to a customer asset, the related work order service tasks will be related to the customer asset automatically.

## Configuration considerations
> [!Note]
> During the preview Microsoft may make schema changes that may render inspections and related records to enter a state where they can no longer be used.

- Only single responses are supported and a technician cannot fill out the same inspection twice for a single work order service task. If the responses are cleared or answered again, the original responses are deleted and only the latest responses are saved.

### Security roles needed to use inspections

- **Field Service-Administrators** can create inspection templates and associate them to service task types. 
- **Field Service-Dispatchers** can add service tasks with inspections to work orders.
- **Field Service-Resources** can view work orders they are assigned to, along with work order service tasks and the related inspections.

### Using inspections vs. service tasks vs. Power Apps

The main advantage of inspections is they are easier to create and easier to fill out. Both service tasks and custom Power Apps require creating additional fields and entities; for work order service tasks, the technician must open and save each one. If you find yourself adding more than 10 service tasks to a work order, or creating a Power App with more than 10 questions, consider inspections instead.

### Inspecting X number of assets at a location

Let's say a technician needs to inspect 10 customer assets at a customer's location. To accommodate this scenario, administrators can:

- Create one inspection with 10 questions - one for each asset - and associate the single inspection to a single service task, or
- Create 10 work order service tasks, each with one inspection. 
 
When deciding, keep in mind work order service tasks can be associated to customer assets to build service history, viewable on the customer asset record. This means creating 10 service tasks each related to a different customer asset has the advantage of helping you build service history. The advantage of utilizing a single service task with multiple questions has the benefit of being easier to add to a work order and quicker to fill out. 
### Inspections in Common Data Model

There are three entities stored in Common Data Model:
1. Inspection: the set of questions.
1. Inspection question: each individual question entry in the inspection.
2. inspection response: overall answer containing answers to all the questions in the overall inspection.

Storing and retrieving each inspection response in Common Data Model is not part of the April 2020 public preview.

## Additional notes

- New inspections cannot be created or designed from small form factors like mobile devices.

- Support for Field Service Mobile is not part of the April 2020 public preview and is **planned**.
  
- The ability to create **branching logic** where inspection questions hide and appear based on other inspections responses is not part of the April 2020 public preview and is **planned**.

- The ability to add version numbering to inspections is not part of the April 2020 public preview and is **planned**.

- Inspections cannot be exported and imported to other environments

### Known issues

- Marking a Work Order Service Task as complete from the grid view does not work unless the Work Order Service Task is opened at least once.


> [!div class="mx-imgBorder"]
> ![Screenshot of marking work order service task as complete from work order service task grid view.](./media/inspections-work-order-service-task-mark-complete-grid.png)
