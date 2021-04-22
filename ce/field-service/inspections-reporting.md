---
title: "Run reports on inspection responses in Field Service in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to run reports for inspection responses in Dynamics 365 Field Service
ms.custom:
- dyn365-fieldservice
ms.date: 03/16/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Run reports on inspection responses

Reports or dashboards can be created and actions can be taken based on the inspection responses provided by the technicians. 

In the following screenshot is an example of the type of Power BI dashboard you can create with inspection responses.

> [!div class="mx-imgBorder"]
> ![Power BI showing an inspection response dashboard.](./media/response-dashboard-snapshot.png)

## Understand, view, and report inspection responses

All responses entered for an inspection are stored in Microsoft Dataverse. Inspection responses can be parsed into individual question responses. 

First, you need to configure how often inspection response should be parsed and organized in Dataverse.

To enable response parsing, go to **Field Service app** > **Settings** > **Field Service Settings** > **Inspection tab**.

> [!div class="mx-imgBorder"]
> ![The Field Service settings page.](./media/0-inspection-snapshot-parse-response.png)

Make sure **Analytics enabled** is set to **Yes**. For **Analytics frequency**, consider the following options:

- **Daily**: Use this setting for inspection responses to be parsed into individual question responses once daily. Every day on the **Record generation start time**, out-of-box flows will be triggered to populate individual question responses into a Dataverse table.
- **Immediately**: Use this setting if you need question responses to be available in Dataverse as soon as an inspection is marked complete.
- **Custom**: Define your own frequency by providing the number of days when parsing should be done. See the following screenshot for an example.

> [!div class="mx-imgBorder"]
> ![The analytics section on inspection settings, showing custom configurations.](./media/customFrequency.jpg)

> [!Note]
> When analytics frequency is set to **Immediately**, the inspection response is parsed and persisted as soon as the service task is completed; the parsed responses won't be updated even if the technician makes changes and completes the inspection again. However, if the analytics frequency is set to **Daily** or **Custom**, the responses are stored from the latest completion of the service task *before* the flow start time.

Now that analytics are configured, questions and responses are ready to be saved into the three tables in Dataverse:

1. **Customer Voice survey question or msfp_question**: stores each inspection question.
2. **Customer Voice survey response or msfp_surveyresponse**: a response to an inspection.
3. **Customer Voice survey question response or msfp_questionresponse**: each individual response to each inspection question.

Now we are ready to create and publish an inspection. See the following screenshot for an example.

> [!div class="mx-imgBorder"]
> ![Sample inspection in Field Service.](./media/1-inspections-snapshot-1.jpg)

After publishing an inspection, the questions are stored in Dataverse, and can be found in the **Customer Voice survey question** table in Power Apps. Here, you can see entries for each question on an inspection.

> [!div class="mx-imgBorder"]
> ![Power Apps, showing the Customer Voice survey question entity detail page.](./media/5-snapshot-after-publish-inspection.jpg)

Before any inspection is completed, the **Customer Voice survey question response** table will be empty.

> [!div class="mx-imgBorder"]
> ![Customer Voice survey question responses in Power Apps.](./media/6-response-snapshot-before-completion.jpg)

Back on our sample inspection, we added some responses for the questions, as seen in the following screenshot, and completed the inspection. 

> [!div class="mx-imgBorder"]
> ![An inspection with questions answered.](./media/7-snapshot-after-response-1.jpg)

Checking again in the **Customer Voice survey question response** table, you'll see the values to each submitted response from the inspection.

> [!div class="mx-imgBorder"]
> ![Power Apps, showing the inspection responses in the Customer Voice survey question response entity.](./media/9-CDS-data-upon-completion.jpg)

## Out-of-box flows

All the logic described in the previous section is driven by Power Automate flows, and is shipped by default with the inspections capability.

The following flows are involved:

1. **Deserialization of Inspection Definition Flow**: this flow gets triggered upon publish of an inspection and populates inspection questions into ```msfp_question``` table.

2. **Deserialization of Inspection Response – Recurrent Flow**: this flow triggers when frequency is set to **Daily** or **Custom** and updates the parsed inspection response JSON into ```msfp_surveyresponse``` and creates new records for responses and corresponding questions in the ```msfp_questionresponse``` table.

3. **Deserialization of Inspection Response Flow**: this flow takes care of response parsing when frequency is set to **Immediately**. 

The status of the flows can be checked as shown in the following screenshot. 

> [!div class="mx-imgBorder"]
> ![Inspection deserialization flow in Power Automate.](./media/10-Flow-for-published-questions.jpg)

## Attachments or images within a response 

Attachments like images in the inspection can be retrieved using flows. Steps are shared in the guide in the next section.

## More Details Guide
Follow the below link to get a detailed PDF guide covering a lot of details about response parsing.

[Download guide to understand inspection response parsing](https://aka.ms/inspections-parse)


## Configuration considerations

### Use Power Automate flow to parse inspection responses (deserialization of responses)

When a technician fills out an inspection, the answers to each inspection question are stored as JSON in the **Inspection Response** entity.

> [!div class="mx-imgBorder"]
> ![Screenshot of inspection responses showing up in the lookup dropdown in an advanced find window.](./media/inspection-inspection-responses-advanced-find.png)

Use a Power Automate flow to run a workflow on inspection responses. For more information, see the video on [run workflows on Inspection responses](https://youtu.be/fCjQmIw9ahs).

In the following example, if a technician responds "Yes" to the inspection question "Is a follow-up required?" then a new follow-up work order service task is added to the related work order.

> [!Note]
> Out-of-the-box flows cannot be customized. You must create or copy a Power Automate flow in order to customize it.

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
