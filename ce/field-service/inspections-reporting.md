---
title: Run reports on inspection responses
description: Learn how to run reports for inspection responses in Dynamics 365 Field Service.
ms.date: 09/13/2024
ms.topic: how-to
author: josephshum-msft
ms.author: jshum
---

# Run reports on inspection responses

Create reports or dashboards, for example, in Power BI to analyze and act based on the inspection responses provided by technicians. Once enabled, all responses entered for an inspection are stored in Microsoft Dataverse and can be parsed into individual question responses.

The questions and responses are saved into the following Dataverse tables:

- **Customer Voice survey question** or 'msfp_question': Each inspection question.
- **Customer Voice survey response** or 'msfp_surveyresponse': A response to an inspection.
- **Customer Voice survey question response** or 'msfp_questionresponse': Each individual response to each inspection question.

Each image uploaded in inspections is stored as an annotation in the *Inspection Attachments* table. They can be [retrieved using flows](#create-a-flow).

## Prerequisites

- You have admin privileges in Dynamics 365 Field Service
- You have access to Microsoft Power Apps
- You have access to Microsoft Power Automate

## Enable analysis on inspection responses

Configure how often inspection response should be parsed and organized in a Dataverse table.

1. In Field Service, change to the **Settings** area.
1. Go to **Field Service Settings** and select the **Inspection** tab.
1. Make sure **Analytics enabled** is set to **Yes**.
1. For **Analytics frequency**, select how often to parse inspection responses:

   - **Daily**: Daily based on the **Record generation start time**.
   - **Immediately**: As soon as an inspection is marked complete.
   - **Custom**: A custom frequency upi define between one and 365 days.

   > [!Note]
   > When analytics frequency is set to **Immediately**, the inspection response is parsed and persisted as soon as the service task is completed; the parsed responses won't be updated even if the technician makes changes and completes the inspection again. However, if the analytics frequency is set to **Daily** or **Custom**, the responses are stored from the latest completion of the service task *before* the flow start time.

## View inspection questions and responses

Questions on inspections are stored in Dataverse, and can be found in the table in Power Apps.

1. Sign in to [Power Apps](https://make.powerapps.com/).
1. Select **Tables** and then **All**.
1. Search for and select the table you want to view. For example,**Customer Voice survey response**. This table is empty until an inspection is completed

   :::image type="content" source="./media/9-CDS-data-upon-completion.jpg" alt-text="Screenshot of Power Apps, showing the inspection responses in the Customer Voice survey question response table.":::

## View the status of the out-of-the-box inspection flows

The logic in inspections uses Power Automate flows, which is part of the out-of-the-box inspection capability. The following flows are used:

- **Deserialization of Inspection Definition Flow**: This flow is triggered when an inspection is published. It populates inspection questions into the 'msfp_question' table.
- **Deserialization of Inspection Response – Recurrent Flow**: This flow is triggered when the frequency is set to **Daily** or **Custom**. It updates the parsed inspection response JSON into 'msfp_surveyresponse' and creates new records for responses and corresponding questions in the 'msfp_questionresponse' table.
- **Deserialization of Inspection Response Flow**: This flow takes care of response parsing when frequency is set to **Immediately**.

To view the status of the flows, sign in to [Power Automate](https://make.powerautomate.com/), select your Field Service environment, and then **My flows**. Open one of the flows.

:::image type="content" source="./media/10-Flow-for-published-questions.jpg" alt-text="Screenshot of the Inspection deserialization flow in Power Automate.":::

## Use a Power Automate flow to parse inspection responses (deserialization of responses)

When a technician fills out an inspection, the answers to each inspection question are stored as JSON in the *Inspection Response* table. You can use a Power Automate flow to run a workflow on inspection responses. For more information, watch the video on [run workflows on Inspection responses](https://youtu.be/fCjQmIw9ahs).

> [!Note]
> Out-of-the-box flows cannot be customized. You must create or copy a Power Automate flow in order to customize it.

For example, if a technician responds 'Yes' to the inspection question **Is a follow-up required?** then a new follow-up work order service task is added to the related work order.

### Create a flow

1. Sign in to [Power Automate](https://make.powerautomate.com) and choose your environment.
1. Select **My flows**. Then, select **New flow** > **Automated cloud flow**.
1. Name the flow and select **Skip**.

### Create a trigger

Create a trigger for the flow based on the **Work Order Service Task** table. Technicians view and respond to inspections from this table.

1. Select **Add a trigger**.
1. Search for "Dataverse" and select **When a row is added, modified, or deleted**.
   :::image type="content" source="./media/inspections-workflow-trigger.png" alt-text="Screenshot of a list of Dataverse triggers in Power Automate.":::
1. Choose **Work Order Service Tasks** for the **Table Name**.
   :::image type="content" source="./media/inspections-workflow-step1.png" alt-text="Screenshot of the flow for when a row is added, modified, or deleted in Power Automate.":::

### Fetch the response from the database

Retrieve the inspection responses.

1. Add a step.
1. Search for "Dataverse" and select **Get a row by ID** action.
1. Select **Inspection Responses** for the table and enter **Inspection Response ID** in the row ID because this field has the ID of the inspection response record.

### Extract the JSON

Retrieve the response from the **ResponseJsonContent** field.

1. Add a step.
1. Search for and select **Initialize variable** action.
1. Enter **responsejson** for the name and select **String** for the type.
1. For the value, enter **/** > **Insert dynamic content** and search for and select **ResponseJsonContent**.
   :::image type="content" source="./media/inspections-workflow-get-JSON-content.png" alt-text="Screenshot of a Power Automate flow, showing the retrieve the encoded response json part of the flow.":::

### Decode the response

Convert the response's JSON into a usable format.

1. Add a step.
1. Search for and select **Initialize variable** action.
1. Enter **decodedResponse** for the name and select **String** for the type.
1. For the value, enter **/** > **Insert expression** and enter the following:

   ```decodeUriComponent(decodeBase64(variables('responseJson')))```

   :::image type="content" source="./media/inspections-workflow-decode-JSON.png" alt-text="Screenshot showing the Decode the json part of the Power Automate flow.":::

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

1. Add a step.
1. Search for and select **Parse JSON** action.
1. Copy and paste the schema.

   :::image type="content" source="./media/inspections-workflow-update-schema.png" alt-text="Screenshot of the Parse JSON section of the Power Automate flow, showing the schema field populated with the previous snippet.":::

1. If you're having trouble generating the schema, you can select the **Use sample payload to generate schema** option and enter the name and sample answer of your inspection question and response.

1. In this example, enter:

   ```{"Followup":"Yes"}```

   "Follow-up" comes from the inspection question's name value:

   > [!div class="mx-imgBorder"]
   > ![Screenshot of an inspection in Field Service, showing the name field.](./media/inspections-workflow-schema-name.png)

### Condition-based action

Add a condition and action based on the response to the inspection question.

1. Add a step.
1. Search for and select **Condition** action.
1. Select **Body Followup**, **is equal to**, and **Yes**.
1. Create a new record if yes. In this example, create a **Work Order Service Task** with another **Service Task Type** in the same work order when the "Follow-up" inspection question has "Yes" as the answer.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the Power Automate flow, showing a condition step where the followup field is equal to yes.](./media/inspections-workflow-if-condition-yes.png)

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the Power Automate flow, showing the "if yes" condition set to trigger a new record creation.](./media/inspections-workflow-then-create-WOST.png)

1. Save and test your flow.
