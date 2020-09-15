---
title: "Advanced options for Field Service Inspections | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2020
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

# Advanced options for Field Service Inspections

## Inspections for customer assets

To relate the inspection to a customer asset and build out service history, enter the customer asset in the **Service Task Relates To** section of the work order service **Task** that holds the inspection.

> [!div class="mx-imgBorder"]
> ![Screenshot of the work order service task showing the service task relates to section, highlighting an associated customer asset.](./media/inspections-wost-customer-asset.png)

Associating a customer asset allows the technician to see which customer asset needs the inspection. From the customer asset, they can see all related inspection history.

> [!div class="mx-imgBorder"]
> ![Screenshot of a customer asset on the work order service tasks section, showing the associated inspection.](./media/inspections-custoiner-asset-service-history.png)

> [!Note]
> If you relate a work order incident type to a customer asset, the related work order service tasks will be related to the customer asset automatically.

### Inspecting X number of assets at a location

Let's say a technician needs to inspect 10 customer assets at a customer's location. To accommodate this scenario, administrators can:

- Create one inspection with 10 questions - one for each asset - and associate the single inspection to a single service task, or
- Create 10 work order service tasks, each with one inspection. 
 
When deciding, keep in mind work order service tasks can be associated to customer assets to build service history, viewable on the customer asset record. This means creating 10 service tasks each related to a different customer asset has the advantage of helping you build service history. The advantage of utilizing a single service task with multiple questions has the benefit of being easier to add to a work order and quicker to fill out. 

## Copy inspections

You can make a copy of an inspection. This is helpful if your organization has multiple inspections that are mostly similar.

From the list of inspections: 

- Select an inspection (seen as "1" in the following screenshot).
- Select **Copy** in the top ribbon (seen as "2" in the following screenshot).
- A new inspection with the same questions will be created (seen as "3" in the following screenshot) with a **Draft** status.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service active inspections with callouts for the previous example.](./media/inspections-copy.png)

## Create new versions of the same inspection

Select the **Revise** ribbon button to edit a published inspection to add new questions, remove obsolete questions, edit the question types, and update the logic.

> [!div class="mx-imgBorder"]
> ![Screenshot of the revise option on an inspection.](./media/inspections-versions-revise.png)

In the **Versions** section of the inspection form, you'll see the current version of the inspection with a status of **Published**, and a new version that can be edited with a status of **Draft**.

> [!div class="mx-imgBorder"]
> ![Screenshot of a published and a draft inspection in the versions section.](./media/inspections-versions2.png)

When the draft version is published, the existing published inspection version will be deactivated.

Existing work orders will display and reference the previous version of the inspection, whereas new work orders will display and reference the new revised version.

## Understand, view, and report inspection responses

After technicians answer inspection questions and mark the work order service task as complete, inspection answers are stored in the Common Data Service for reporting purposes.

// https://msit.microsoftstream.com/video/85e9a3ff-0400-96f3-957b-f1eaf3cb7e4d

// more details - https://msit.microsoftstream.com/video/401ba4ff-0400-96f3-103c-f1eaf3bb7a39

There are three entities stored in Common Data Service:
1. Customer Voice survey question: each inspection question
2. Customer Voice survey response: a response to an insepction
3. Customer voice survey question response: each individual response to each inspection question

First define how often inspection answers should be parsed and organized in CDS.

Go to **Field Service app > Settings > Field Service Settings > Inspection tab**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/0-inspection-snapshot-parse-response.png)

Next create and publish an inspection. Here is an example.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/1-inspections-snapshot-1.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/2-inspections-snapshot-2.jpg)


After publishing an inspection you will see the questions are stored in CDS in the Customer Voice survey question entity.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/5-snapshot-after-publish-inspection.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/6-response-snapshot-before-completion.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/7-snapshot-after-response-1.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/8-response-snapshot-after-completion-2.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/9-CDS-data-upon-completion.jpg)


Deserialization of Inspection Definition flow:
This flow deserializes the Inspection Definition records and is shipped with Inspection Solution. 
This flow is not bounded by the frequency settings introduced in Inspections tab in FS settings.
Every Inspection form (questionnaire), once published, the deserialized inspection definition JSON data is immediately ingested into the Forms Pro entity msfp_question. This flow gets triggered on state changed to published and performs the same. 



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/10-Flow-for-published-questions.jpg)

## Configuration considerations

### Using inspections vs. service tasks vs. Power Apps

The main advantage of inspections is they are easier to create and easier to fill out. Both service tasks and custom Power Apps require creating additional fields and entities; for work order service tasks, the technician must open and save each one. If you find yourself adding more than 10 service tasks to a work order, or creating a Power App with more than 10 questions, consider inspections instead.

### Use Power Automate flow to parse inspection responses 

When a technician fills out an inspection, the answers to each inspection question are stored as JSON in the **Inspection Response** entity.


> [!div class="mx-imgBorder"]
> ![Screenshot of inspection responses showing up in the lookup dropdown in an advanced find window.](./media/inspection-inspection-responses-advanced-find.png)

Use a Power Automate flow to run a workflow on inspection responses.

In the following example, if a technician responds "Yes" to the inspection question "Is a follow-up required?" then a new follow-up work order service task is added to the related work order.

### Create a flow

Go to [https://flow.microsoft.com](https://flow.microsoft.com), sign in, choose your environment, and create a new flow.

Choose **Automated - from blank**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Automate, on the New dropdown menu showing Automated - from blank.](./media/inspections-workflow-create-flow.png)

Name the flow and select **Skip** to choose the trigger on the flow editor page.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Build an automated flow window.](./media/inspections-workflow-name.png)

 
### Create a trigger 

Search for "Dynamics 365" in **Connectors** and choose the trigger as **When a record is created or updated**.

> [!div class="mx-imgBorder"]
> ![Screenshot of a list of triggers in Power Automate.](./media/inspections-workflow-trigger.png)
 
This flow will relate to the **Work Order Service Task** entity because technicians view and respond to inspections from this entity. Choose **Work Order Service Tasks** for the **Entity Name**. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the flow for when a record is created or updated.](./media/inspections-workflow-step1.png)
 
### Fetch the response from the database

Next, we need to retrieve the inspection responses.

Add a step using the **Get record** action in "Dynamics 365." 

Choose **Inspection Responses** as the entity to get and **Inspection Response ID** in the item identifier because this field has the ID of the inspection response record.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Automate showing the get record part of a flow showing inspection responses in the item identifier field.](./media/inspections-workflow-fetch-inspection-response.png)
 
### Extract the JSON

Add an **Initialize Variable** action to retrieve the response from **ResponseJsonContent** field.

> [!div class="mx-imgBorder"]
> ![Screenshot of a Power Automate flow, showing the "retrieve the encoded response json" part of the flow.](./media/inspections-workflow-get-JSON-content.png)
 
### Decode the response

Now we need to convert the response's JSON into a usable format.

Add an **Initialize Variable** action to url decode and base 64 decode the response JSON:

```decodeUriComponent(decodeBase64(variables('responseJson')))```

> [!div class="mx-imgBorder"]
> ![Screenshot showing the Decode the json part of the Power Automate flow.](./media/inspections-workflow-decode-JSON.png)

### Update the schema

Provide the schema with the name of the question you want to run a workflow on.

In our example, the schema is:

```
{
    "type": "object",
    "properties": {
        "Followup": {
            "type": "string"
        }
    }
}
```

> [!div class="mx-imgBorder"]
> ![Screenshot of the Parse JSON section of the Power Automate flow, showing the schema field populated with the previous snippet.](./media/inspections-workflow-update-schema.png)

If you're having trouble generating the schema, you can select the **Generate from sample** option and enter the name and sample answer of your inspection question and response.

In our example, we can enter:

```{"Followup":"Yes"}```

"Followup" comes from the inspection question's name value, as seen in the following screenshot:

> [!div class="mx-imgBorder"]
> ![Screenshot of an inspection in Field Service, showing the name field.](./media/inspections-workflow-schema-name.png)

### Condition-based action

Next we'll add a condition and action based on the response to the inspection question.

In this example, we'll create a **Work Order Service Task** with another **Service Task Type** in the same work order when the "Followup" inspection question has "Yes" as the answer.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Automate flow, showing a condition step where the followup field is equal to yes.](./media/inspections-workflow-if-condition-yes.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Automate flow, showing the "if yes" condition set to trigger a new record creation.](./media/inspections-workflow-then-create-WOST.png)

Save and test your flow.
