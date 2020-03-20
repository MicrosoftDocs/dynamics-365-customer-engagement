---
title: "Field Service Inspections | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/20/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Add inspections to Work Orders

Field Service inspections are a digital form that technicians use to quickly and easily answer a list of questions as part of a work order. The list of questions are often a safety protocol, pass and fail tests for a customer asset, an interview with a customer, or other various audits and assessments that are performed before, during, or after a work order.

Compared to using Work Order Incident Types and Service Tasks, using Inspections has the added benefits of:

- **Easier to create** - administrators can quickly create inspection with a drag and drop interface without the need to create new entities and fields.
- **Easier to fill out** - technicians can quickly enter responses for each inspection question and save all of them with one click rather than having to open and close multiple records.
- **More flexible and robust** - Field Service Inspections have many options for question formats and validations such as multi-option select, mandatory fields, images, attachments, etc. 

Creating and using Inspections is simple and involves the following steps: 

1. Administrator creates an inspection template
2. Administrator associates the published inspection to a Service Task Type
3. Dispatcher adds the Service Task Type to a Work Order
4. Technician completes the inspection
5. View inspection results

In this article we will walk through an example of setting up an inspection using a maintenance checklist on a customer asset as an example.

## Prerequisites

Inspection capabilities are released in April 2020 as part of a Public preview. Request preview access by [submitting a support request](https://mbs.microsoft.com/customersource/northamerica/CRM/support/support-lifecycle/CRMSupport)

Dynamics 365 version 9.1.0000.15015+

Knowledge of work order [incident types and service tasks](.configure-incident-types.md) is encouraged.


## Create inspection template

First create an inspection template that can be reused and added to multiple work orders.

From the Field Service app go to **Settings > Inspections > +New**.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-navigate.png)

Name your inspection and drag and drop question types from the right side.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-create.png)

Use the **Required** toggle to make the inspection quesiton mandatory in order for the technician to sae the inspection later on.

Question types Checkbox, Radiogroup, and Dropdown are similar except the Checkbox question type is multi-select whereas Radiogroup and Dropdown allow for a single answer. The difference between Radiogroup and Dropdown is a cosmetic and user experience difference.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-create2.png)

By selecting the Gear icon you can add more details for an inspection question. As an example, we specified the Pressure gauge reading (PSI) question must be a number format.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-create-advanced-number.png)


Use the Preview section to view the inspection from a technician's perspective.

> [!Note]
> Once you publish the inspection you cannot edit it in the preview version. 

When finished creating the inspection, select Publish at the top. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-create-preview-publish.png)


## Associate inspection to service task type

Next associate the inspection template to a Service Task Type. This has to be done because inspections are not added directly to work orders, they are added as part of Work Order Service Tasks.

In the same Settings section, go to Service Task Types.

Select an existing Service Task Type or create a new one.

Set **Has Inspection **to **Yes**.

In the **Inspection** field, select the Inspection template you just created.

The inspection form will appear below.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-service-task.png)


It is common to add service task types to incident types to bundle work together. However this is not required because you can add individual service tasks to work orders as we'll see later on. In the image below, the "Fire extinguisher inspection" service task was associated to the "Fire system maintenance" incident type.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-service-task-incident-type.png)



## Add inspection to work order

After creating a work order, go to the Service Tasks section and add a new Work Order Service Task.

Alternatively, your inspection service task can be added to the work order via a work order incident type. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-service-task-work-order.png)

The inspection that will be completed by technicians will be visible on the bottom of the work order service task form.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-service-task-work-order-drill-down.png)

## Perform inspection 

After the work order is scheduled to the appropriate technician, he or she can view and complete the inspection two ways:

1. On his or her mobile phone or tablet using the **Microsoft Dynamics 365** mobile app. This is different than Field Service Mobile.
2. Logging in to Field Service in a web browser on a mobile device or PC.


For the first option, go to your devices app store and download the **Microsoft Dynamics 365** mobile app


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-mobile-download-app.png)

Then log in with your Dynamics 365 URL, username and password and go to the assigned work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-mobile-nav.png)

Click on the Work Order Service Task (and not the Service Task Type).


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-mobile-wost.png)

Find the inspection form and enter answers.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-mobile-inspection-form.png)

When finished, the technician can enter a **Complete %**, **Result**, and an **Actual Duration**.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-mobile-mark-complete.png)


If an inspection question is required, the technician will not be able to Mark Complete or set % Completed to 100, until it is answered.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-mobile-validation.png)

If needed a technician can select Clear Responses to start over. This will permanently delete all responses for this service task inspection..

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-mobile-wost-clear-responses.png)


## View responses

Back in Dynamics 365, a dispatcher will see inspection responses.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-complete-web.png)

## Inspections for Customer Assets

To relate the inspection to a customer asset to build service history, enter the customer asset in the **Service Task Relates To** section of the Work Order Service Task that holds the inspection.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-wost-customer-asset.png)

Doing so will allow the technician to see which customer asset to perform the inspection for and from the customer asset can see all related inspection history.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inspections-custoiner-asset-service-history.png)

> [!Note]
> If you relate a work order incident type to a customer asset, the related work order service tasks will be related to the customer asset automatically.

## Configuration considerations
> [!Note]
> During preview Microsoft may make schema changes that might render inspections and related records to go into a state where they can no longer be used.

- Only single responses are supported and a technician cannot fill out the same inspection twice for a single work order service task. If the responses are cleared or answered again, the original responses are deleted and only the latest responses are saved.

### Security roles needed to use inspections

- **Field Service-Administrators** can create inspection templates and associate them to Service Task Types. 
- **Field Service-Dispatchers** can add Service Tasks with Inspections to Work Orders.
- **Field Service-Resources** can view work orders they are asigned and work order service tasks and the related inspections.

### Using inspections vs. Service Tasks vs. PowerApp

The main advantage of inspections is they are easier to create and easier to fill out compared to work order service tasks or a custom powerapp, as both may require creating additional fields and entities; and in the case of work order service tasks, the technician must open and save each one. If you find yourself adding more than 10 service tasks to a work order, or creating a powerapp with more than 10 questions, it is worth considering using inspections instead. 

### Inspecting X number of assets at a location

Let's say a technician needs to inspect 10 customer assets at a customer's location. To accommodate this scenario, administrators can create one inspection with 10 questions, one for each asset and associate the single inspection to a single service task; or create 10 work order service tasks each with one inspection. When deciding, keep in mind work order service tasks can be associated to customer assets to build service history that is viewable on the customer asset record. This means creating 10 service tasks each related to a different customer asset has the advantage of helping you build service history. The advantage of utilizing a single service task with multiple questions has the benefit of being easier to add to a work order and quicker to fill out. 

## Additional Notes

- Support for Field Service Mobile is not part of the April 2020 public preview and is **planned**.
- The ability to create **branching logic** where inspection questions hide and appear based on other inspections responses is not part of the April 2020 public preview and is **planned**.
- Each inspection and inspection question is stored in the Common Data Model, storing and retreiving each inspection response in the Common Data Model is not part of the April 2020 public preview.
- The ability to add version numbering to inspections is not part of the April 2020 public preview and is **planned**.
