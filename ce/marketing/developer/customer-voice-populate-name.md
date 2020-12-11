---
title: "Attach names and emails to Dynamics 365 Customer Voice surveys sent from customer journeys (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn how to map names and emails to surveys with a custom Power Automate flow"
keywords: developer; dev; developer guide; system configuration
ms.date: 10/19/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: developer-guide
ms.assetid: 1f1a8244-2dc5-4de2-b7f8-719a46c82861
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Attach names and emails to Dynamics 365 Customer Voice surveys sent from customer journeys

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

When a [Dynamics 365 Customer Voice](../customer-voice.md) survey is sent from a Dynamics 365 Marketing customer journey, the survey responses don't include the respondents' names or email addresses. This is a known limitation of Marketing integration with Dynamics 365 Customer Voice. To address this issue, we have created the two-part workaround detailed below.

> [!NOTE]
> Standalone Dynamics 365 Customer Voice surveys function as expected, returning names and email addresses when a survey is filled out. The steps below only apply to Dynamics 365 Customer Voice surveys sent from Dynamics 365 Marketing.

## Step 1: Create a Power Automate flow to populate respondent names and email addresses

1. In the Dynamics 365 navigation menu, go to the **Power Automate** app.

    ![Select the Power Automate app](../media/populate-name-power-automate.png "Select the Power Automate app")

1. In Power Automate, create a new **Automated flow**.

1. Under **Choose your flow's trigger**, select the **When a record is created, updated or deleted** Common Data Service connector.

    ![Choose the flow trigger](../media/populate-name-flow-trigger.png "Choose the flow trigger")

    > [!TIP]
    > Ensure that you are connected to the same environment as the Microsoft Dataverse org.

    Your flow should look like the image below:

    ![Layout of the selected flow](../media/populate-name-flow.png "Layout of the selected flow")

1. For each title, select the three dots on the right side of the tile and set the "peek code" as follows:

    - **When survey response created**:

        ```{ "inputs": { "host": { "connectionName": "shared_commondataserviceforapps", "operationId": "SubscribeWebhookTrigger", "apiId": "/providers/Microsoft.PowerApps/apis/shared_commondataserviceforapps" }, "parameters": { "subscriptionRequest/message": 1, "subscriptionRequest/entityname": "msfp_surveyresponse", "subscriptionRequest/scope": 4 }, "authentication": "@parameters('$authentication')" } }```

        ![Survey response created tile](../media/populate-name-response-created.png "Survey response created tile")

    - **Initialize variable**:
        
        ```{ "inputs": { "variables": [ { "name": "activityid", "type": "string", "value": "@triggerOutputs()?['body/activityid']" } ] } }```

        ![Initialize variable tile](../media/populate-name-initialize-variable.png "Initialize variable tile")

    - **List parties**:
        
        ```{ "inputs": { "host": { "connectionName": "shared_commondataserviceforapps", "operationId": "ListRecords", "apiId": "/providers/Microsoft.PowerApps/apis/shared_commondataserviceforapps" }, "parameters": { "entityName": "activityparties", "$filter": "_activityid_value eq @{triggerOutputs()?['body/activityid']} and participationtypemask eq 1" }, "authentication": "@parameters('$authentication')" } }```

        ![List parties tile](../media/populate-name-list-parties.png "List parties tile")

    - **get contact**:
        
        ```{ "inputs": { "host": { "connectionName": "shared_commondataserviceforapps", "operationId": "GetItem", "apiId": "/providers/Microsoft.PowerApps/apis/shared_commondataserviceforapps" }, "parameters": { "entityName": "contacts", "recordId": "@items('Apply_to_each')?['_partyid_value']" }, "authentication": "@parameters('$authentication')" } }```

        ![Get contact tile](../media/populate-name-get-contact.png "Get contact tile")

    - **update survey response**:
        
        ```{ "inputs": { "host": { "connectionName": "shared_commondataserviceforapps", "operationId": "UpdateRecord", "apiId": "/providers/Microsoft.PowerApps/apis/shared_commondataserviceforapps" }, "parameters": { "entityName": "msfp_surveyresponses", "recordId": "@variables('activityid')", "item/msfp_respondent": "@outputs('get_contact')?['body/fullname']", "item/msfp_respondentemailaddress": "@outputs('get_contact')?['body/emailaddress1']" }, "authentication": "@parameters('$authentication')" } }```

        ![Update survey tile](../media/populate-name-survey-response.png "Update survey tile")

## Step 2: Export Dynamics 365 Customer Voice survey responses to Microsoft Excel

The export to Excel feature uses Microsoft Dataverse information to join and pull the contact record information for Marketing integration customers, making it available in Excel.

To export survey response data to Excel:

1. Enter the following URL into your browser, replacing the value for {surveyidentifier} with the ID of your chosen survey:

    ```https://forms.office.com/FormsPro/Pages/DesignPage.aspx?experienceType=Pro#Analysis=true&FormId={suveyidentifier}```

    > [!NOTE]
    > Do not confuse the survey identifier with the GUID. To find the survey identifier in the Dynamics 365 Customer Voice survey entity, look in the **Source survey identifier** field.
	>
    > The survey identifier will look like the following string: <br>
    ```v4j5cvGGr0GRqy180BHbR8HxyywSGiFAkJ7eG-r1E-9UODI0UzIzUFBOM1FTUENON0pQV1UzV0VTNi4u```

1. After the page loads, select the **Responses** tile.

1. To export the response data, select **Export all**.

### See also

[Use Dynamics 365 Customer Voice surveys with Dynamics 365 Marketing](../customer-voice.md)  