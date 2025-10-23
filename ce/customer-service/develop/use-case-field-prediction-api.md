---
title: Use case field prediction API
description: Learn how to use msdyn_UpdateRecordWithRuleBasedPredictions API to predict case fields with context from the email for a case.
author: gandhamm
ms.author: mgandham
ms.reviewer: gandhamm
ms.topic: how-to 
ms.collection: 
ms.date: 08/08/2025
ms.custom: bap-template 
---


# Use case field prediction API

You can use the `msdyn_UpdateRecordWithRuleBasedPredictions` API to predict case fields with context from the email once a case is created. The API updates the configured fields in the case with the predicted values from the email, allowing you to automate case updates and improve efficiency in handling cases.

## Prerequisites

- The case fields the API must predict and update are configured in your environment. Learn more in [Configure autonomous case updates](../administer/set-up-autonomous-case-agents.md).
- You must have the required permissions to call this API.

## Request Details

- **URL**: `https://<orgurl>/api/data/v9.2/msdyn_UpdateRecordWithRuleBasedPredictions`
- **Method**: POST
- **Version**: 1.0

## Request parameters

The request body contains the following parameters:

| Parameter      | Type            | Required | Description                                                                                          | Format                                                                                           |
|----------------|----------------|----------|------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------|
| msdyn_Target   | Entity          | Yes      | Entity that must be updated and is used to match the configured update rules. Must contain the ID of an existing record. |<br>```json<br>{<br>    "@odata.type": "Microsoft.Dynamics.CRM.incident",<br>    "incidentid": "14ff4725-f1b0-ef11-ac2e-6045bd0a52c7"<br>}<br>``` |
| msdyn_Context  | Entity Reference| Yes      | The email entity that's used to provide context for AI prediction.| <br>```<br>emails(fffe4725-f1b0-ef11-ac2e-6045bd0a52c7)<br>``` |

## Response properties

| Property | Type | Description | Example |
|----------|------|-------------| -------|
| msdyn_UpdatedRecords | String array | List of entity fields that were updated.| `['incident(GUID)', 'contact(GUID)', ...]` |

The msdyn_UpdatedRecords array is empty in the following scenarios:

- Case fields to be updated aren't configured.
- The fields to be updated have already been manually updated.
- The prediction model wasn't able to generate a prediction.


## Error handling

The API raises exceptions in the following scenarios:

- User doesn't have the required permissions to update the entity.
- The specified entity ID doesn't exist.
- Configuration errors.
- Exceptions from underlying prediction services.

## Example

The following table describes the sample request and response scenarios for the API.

| Description | Request | Response |
|-------------|---------|----------|
| Generates AI predictions for the specified case ID and updates the record using contextual information from the related email. | ```json { "msdyn_Target": { "@odata.type": "Microsoft.Dynamics.CRM.incident", "incidentid": "14ff4725-f1b0-ef11-ac2e-6045bd0a52c7" }, "msdyn_Context": "emails(fffe4725-f1b0-ef11-ac2e-6045bd0a52c7)" } ``` | ```json { "@odata.context": "https://yourorg.crm.dynamics.com/api/data/v9.2/$metadata#Microsoft.Dynamics.CRM.msdyn_UpdateRecordWithRuleBasedPredictionsResponse", "msdyn_UpdatedRecords": [ "incident(c82009d5-8203-f011-9aee-000d3a376aa8)" ] } ``` |
| Generates predictions for the specified case ID using context from the email and updates the case fields, explicitly setting the customerid to the contact specified. | ```json { "msdyn_Target": { "@odata.type": "Microsoft.Dynamics.CRM.incident", "incidentid": "14ff4725-f1b0-ef11-ac2e-6045bd0a52c7", "customerid_contact@odata.bind": "contacts(e5ffe77b-b0a3-ef11-ac2e-6045bd0a52c7)" }, "msdyn_Context": "emails(fffe4725-f1b0-ef11-ac2e-6045bd0a52c7)" } ``` | ```json { "@odata.context": "https://yourorg.crm.dynamics.com/api/data/v9.2/$metadata#Microsoft.Dynamics.CRM.msdyn_UpdateRecordWithRuleBasedPredictionsResponse", "msdyn_UpdatedRecords": [ "incident(c82009d5-8203-f011-9aee-000d3a376aa8)", "contact(313a24c2-8203-f011-9aee-000d3a376aa8)" ] } ``` |
| No updates were made because the prediction model wasn't able to generate a prediction. |  | ```json { "@odata.context": "https://yourorg.crm.dynamics.com/api/data/v9.2/$metadata#Microsoft.Dynamics.CRM.msdyn_UpdateRecordWithRuleBasedPredictionsResponse", "msdyn_UpdatedRecords": [] } ``` |

