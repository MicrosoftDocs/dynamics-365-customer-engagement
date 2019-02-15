---
title: "Basic Operations on Customer Journey using API| Microsoft Docs" # Intent and product brand in a unique string of 43-59 chars including spaces
description: The Customer Journey API enables programmatic interaction with certain segmentation features of Dynamics 365 for Marketing App."" # 115-145 characters including spaces. This abstract displays in the search result.
ms.custom: ""
ms.date: 2/07/2019
ms.reviewer: ""
ms.service: "D365CE"
ms.topic: "article"
author: "nkrb" # GitHub ID
ms.author: "nabuthuk" # MSFT alias of Microsoft employees only
manager: "kvivek" # MSFT alias of manager or PM counterpart
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---
# Basic Operations on Customer Journey using API

[!INCLUDE[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

As you engage potential customers, they start by discovering your product, evaluate whether it meets their needs, look for a good offer, and finally make a purchase. We call this process the **Customer Journey**. Use customer journeys to create a model that helps you guide the members of a selected marketing segment through this process by using automated messaging, activity generation, interactive decision points, and more. More information [Create Customer Journey](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/customer-journeys-create-automated-campaigns)

> [!IMPORTANT]
> - Customer Journey API is a preview feature.
> - [!INCLUDE[cc_preview_features_definition](../../includes/cc-preview-features-definition.md)] 
> - [!INCLUDE[cc_preview_features_no_MS_support](../../includes/cc-preview-features-no-ms-support.md)]

The Customer Journey API enables programmatic interaction with customer journey records.
The API leverages the standard Dynamics 365 API for manipulating entities or messages. More information [Dynamics 365 Web API](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/use-microsoft-dynamics-365-web-api)

When you create a customer journey, the properties are stored in `msdyncrm_customerjourney` entity. You can browse the entity metadata information using `@odata.context`in `GET` response. 

> [!NOTE]
> Before you perform operations, you should install Dynamics 365 for Marketing app. 

This topic demonstrates how to perform operation on the `msdyncrm_customerjourney` entity. `msdyncrm_name` field is the only mandatory field to create a simple customer journey. Following are the list of fields that are used in this topic to create a customer journey.

|Display Name|Schema Name|Value|Required|
|----------|--------------|------|-------|
|Name|msdyncrm_name|Name of the Customer Journey|Yes|
|Status Reason|statuscode|Current status of the customer journey. Following are the availabe statuscode:<br />- Draft `192350000`<br />- Live `192350001`<br />- Stopped `192350002`<br />- Live, Editable `192350003`<br />- Error `192350005`<br />- Going Live `192350006`<br />- Stopping `192350007`<br />|Yes|
|Suppression Segment|msdyncrm_SuppressionSegmentId|The ID of the associated [Suppression Segment](https://docs.microsoft.com/en-au/dynamics365/customer-engagement/marketing/suppression-segments). Use it to set reference to a record from `msdyncrm_segments` record set.|
|Recurrence Interval (Days)|msdyncrm_recurrenceintervaldays|The duration of the iteration (in days). Non negative integer|
|Minimum Consent|msgdpr_requiredconsent|
|Recurrence Count|msdyncrm_recurrencecount|The number of iterations. Non negative integer|
|Workflow Definition|msdyncrm_workflowdefinition|The customer journey design definition.|
|Customer Journey Designer State|msdyncrm_customerjourneydesignerstate|This is a hidden field, used by the Customer Journey Designer to persist its internal state. The field should be copied if you are creating a copy of `msdyncrm_workflowdefinition` field, from another Customer Journey or Customer Journey Template record.|
|Time Zone|msdyncrm_customerjourneytimezone|Effective time zone for the customer journey|
|Content Settings|msdyncrm_contentsettingsId|The ID of associated [Content Settings](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/dynamic-email-content). Use it to reference a record from `msdyncrm_contentsettings` record set.|
|End Date and Time|msdyncrm_enddatetime|Date time value in `ISO 8601 UTC` format.|
|Start Date and Time|msdyncrm_startdatetime|Date time value in ISO 8601 UTC format.|
|Is Recurring|msdyncrm_isrecurring|A boolean value.|
|Entity Target|msdyncrm_entitytarget|- Contact 0<br />- Account 1|
|Type|msdyncrm_type|- Automated 192350000<br />- LinkedIn 192350001|
|Status|statecode|Status of the customer journey|

> [!NOTE]
> The `statuscode` and `statecode` fields defines the state of thecCustomer journey. Changing the values of `statuscode` can result in `Publishing` or `Stopping` of customer journey workflow. If you wish to `go live`, save the record in `Going Live` state (statuscode = 192350006). To stop the running customer journey record, save the Live record in `Stopping` state (statuscode = 192350007).

## CRUD operations

1. **Create request**

The create request creates a customer journey record and set the `statuscode` to `Draft`. The Customer Journey includes a segment (ID: 24db2671-1529-e911-a9b7-000d3a1e6adc; Unique Name: TC407937_DynamicSegment_2KZQ1p) and an email (ID: 15bd0ab8-c12a-e911-a9b6-000d3a1e6c14). The effective Content Settings has record ID: 1922b1d8-0523-e911-a9ba-000d3a1e689f. 

```HTTP
POST: {{OrgUrl}}/api/data/v9.0/msdyncrm_customerjourneys

{
    "msgdpr_requiredconsent": 587030001,
    "msdyncrm_customerjourneydesignerstate": "{\"NextActivityID\":8,\"NextActivityItemID\":42}",
    "msdyncrm_workflowdefinition": "[{\"ActivityTypeId\":\"bpf_root\",\"ParentBranchId\":0,\"ParentRelationshipType\":\"Default\",\"ActivityId\":\"01\",\"Properties\":{\"Items\":[{\"ItemId\":null,\"ActivityTypeId\":\"bpf_root\",\"Title\":\"Undefined\",\"IsNameSystemDefined\":true,\"Name\":\"New ActivityTypeName_bpf_root_TitleText\",\"ActivityItemId\":0}]}},{\"ActivityTypeId\":\"Segment\",\"ParentActivityId\":\"01\",\"ParentBranchId\":0,\"ParentRelationshipType\":\"Default\",\"ActivityId\":\"01_0\",\"Properties\":{\"Items\":[{\"ItemId\":null,\"ActivityTypeId\":\"Segment\",\"Title\":\"Undefined\",\"IsNameSystemDefined\":true,\"Name\":\"New Segment group\",\"ActivityItemId\":23,\"SegmentMergeMethod\":\"Union\"},{\"ItemId\":\"24db2671-1529-e911-a9b7-000d3a1e6adc\",\"ActivityTypeId\":\"SegmentItem\",\"Title\":\"Undefined\",\"IsNameSystemDefined\":true,\"Name\":\"TC407937_DynamicSegment_2KZQ1p\",\"ActivityItemId\":24,\"ContainmentMethod\":\"Inclusion\",\"SegmentSourceType\":\"Segment\",\"DciSegmentName\":\"TC407937_DynamicSegment_2KZQ1p\",\"SegmentDisplayName\":\"TC407937_DynamicSegment_2KZQ1p\",\"Description\":\"\"}]},\"EntityTarget\":\"contact\"},{\"ActivityTypeId\":\"Email\",\"ParentActivityId\":\"01_0\",\"ParentBranchId\":0,\"ParentRelationshipType\":\"Default\",\"ActivityId\":\"01_0_2\",\"Properties\":{\"Items\":[{\"ItemId\":\"15bd0ab8-c12a-e911-a9b6-000d3a1e6c14\",\"ActivityTypeId\":\"Email\",\"Title\":\"Undefined\",\"IsNameSystemDefined\":true,\"Name\":\"Relationship test\",\"ActivityItemId\":32}]},\"EntityTarget\":\"contact\"}]",
    "msdyncrm_customerjourneytimezone": 92,
    "msdyncrm_contentsettingsId@odata.bind": "/msdyncrm_contentsettingss(1922b1d8-0523-e911-a9ba-000d3a1e689f)",
    "msdyncrm_enddatetime": "2019-03-09T11:29:00.000Z",
    "msdyncrm_startdatetime": "2019-02-09T11:29:00.000Z",
    "msdyncrm_name": "Simple Email Sample",
    "msdyncrm_isrecurring": false,
    "msdyncrm_type": 192350000,
    "msdyncrm_entitytarget": 0,
    "statuscode": 192350000,
    "statecode": 0,
    "ownerid@odata.bind": "/systemusers(d0e20c01-d6c6-480f-aab5-0fa6749565a5)"
}
```
2. **Retrieve request**

The retrieve request retieves the list of `Live` customer journeys.

```Http
GET {{OrgUrl}}/api/data/v9.0/msdyncrm_customerjourneys?$filter=statuscode eq 192350001
```
3. **Update request**

In update request, you will set the `statuscode` to `Going Live` which effectively publishes it.

```HTTP
PATCH api/data/v9.0/msdyncrm_customerjourneys(8aee9d91-8c2b-e911-a9b7-000d3a1e6adc)
{
    "statuscode": 192350006
}
```
4. **Delete request**

In delete request, you will delete the customer journey that you have created earlier.

```HTTP
DELETE {{OrgUrl}}/api/data/v9.0/msdyncrm_customerjourneys(b6faa2b7-b92b-e911-8185-000d3af9d16a)
```
## Check for Errors

**Request**

The request body is a JSON object which contains a number of data elements with values corresponding to the `msdyncrm_customerjourney entity` properties. The reference fields (for example,Content Settings ID) doesn't use the `@odata.bind` with recordset reference, but uses the ID of referenced record. The table below explains the mapping.

|Key|Corresponding property msdyncrm_customerjournet entity (logical name)|
|--------|--------------|
|FieldValueCustomerJourneyId|msdyncrm_customerjourneyid|
|FieldValueStatusCode|statuscode|
|FieldValueName|msdyncrm_name|
|FieldValueStartDateTime|msdyncrm_startdatetime|
|FieldValueEndDateTime|msdyncrm_enddatetime|
|FieldValueWorkflowDefinition|msdyncrm_workflowdefinition|
|FieldValueIsRecurring|msdyncrm_isrecurring|
|FieldValueRecurrenceIntervalDays|msdyncrm_recurrenceintervaldays|
|FieldValueRecurrenceCount|msdyncrm_recurrencecount|
|FieldValueRequiredConsent|msgdpr_requiredconsent|
|FieldValueEntityTarget|msdyncrm_entitytarget|
|FieldValueSuppressionSegmentId|msdyncrm_suppressionsegmentid|
|FieldValueCustomerJourneyTimeZone|msdyncrm_customerjourneytimezone|

## Validate Schema

**Request**

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_CustomerJourneyValidate

{
    "FieldValueCustomerJourneyId": "{6628BBF7-C52A-E911-A9B7-000D3A1E6ADC}",
    "FieldValueStatusCode": 192350000,
    "FieldValueName": "Sample Customer Journey",
    "FieldValueStartDateTime": "2019-02-08T11:48:00.000Z",
    "FieldValueEndDateTime": "2019-03-08T11:48:00.000Z",
    "FieldValueWorkflowDefinition": "[{\"ActivityTypeId\":\"bpf_root\",\"ParentBranchId\":0,\"ParentRelationshipType\":\"Default\",\"ActivityId\":\"01\",\"Properties\":{\"Items\":[{\"ItemId\":null,\"ActivityTypeId\":\"bpf_root\",\"Title\":\"Undefined\",\"IsNameSystemDefined\":true,\"Name\":\"New ActivityTypeName_bpf_root_TitleText\",\"ActivityItemId\":0}]}},{\"ActivityTypeId\":\"Segment\",\"ParentActivityId\":\"01\",\"ParentBranchId\":0,\"ParentRelationshipType\":\"Default\",\"ActivityId\":\"01_0\",\"Properties\":{\"Items\":[{\"ItemId\":null,\"ActivityTypeId\":\"Segment\",\"Title\":\"Undefined\",\"IsNameSystemDefined\":true,\"Name\":\"New Segment group\",\"ActivityItemId\":52,\"SegmentMergeMethod\":\"Union\"},{\"ItemId\":\"056bbe66-f025-e911-a9ba-000d3a1e689f\",\"ActivityTypeId\":\"SegmentItem\",\"Title\":\"Undefined\",\"IsNameSystemDefined\":true,\"Name\":\"TC407937_DynamicSegment_bmkX5u\",\"ActivityItemId\":53,\"ContainmentMethod\":\"Inclusion\",\"SegmentSourceType\":\"Segment\",\"DciSegmentName\":\"TC407937_DynamicSegment_bmkX5u\",\"SegmentDisplayName\":\"TC407937_DynamicSegment_bmkX5u\",\"Description\":\"\"}]},\"EntityTarget\":\"contact\"},{\"ActivityTypeId\":\"Email\",\"ParentActivityId\":\"01_0\",\"ParentBranchId\":0,\"ParentRelationshipType\":\"Default\",\"ActivityId\":\"01_0_3\",\"Properties\":{\"Items\":[{\"ItemId\":\"15bd0ab8-c12a-e911-a9b6-000d3a1e6c14\",\"ActivityTypeId\":\"Email\",\"Title\":\"Undefined\",\"IsNameSystemDefined\":true,\"Name\":\"Relationship test\",\"ActivityItemId\":61}]},\"EntityTarget\":\"contact\"}]",
    "FieldValueIsRecurring": true,
    "FieldValueRecurrenceIntervalDays": 30,
    "FieldValueRecurrenceCount": 3,
    "FieldValueRequiredConsent": 587030001,
    "FieldValueContentSettingsId": "{1922B1D8-0523-E911-A9BA-000D3A1E689F}",
    "FieldValueEntityTarget": 0,
    "FieldValueSuppressionSegmentId": "{544A3E20-9B23-E911-A9B6-000D3A1E6C14}",
    "FieldValueCustomerJourneyTimeZone": 92
}
FieldValueRecurrenceCount": 3,
    "FieldValueRequiredConsent": 587030001,
    "FieldValueContentSettingsId": "{1922B1D8-0523-E911-A9BA-000D3A1E689F}",
    "FieldValueEntityTarget": 0,
    "FieldValueSuppressionSegmentId": "{A02C08DD-A92A-E911-A9B9-000D3A1E6B71}",
    "FieldValueCustomerJourneyTimeZone": 92
```
**Response**

```HTTP
{
    "@odata.context": "{{orgUrl}}/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyncrm_CustomerJourneyValidateResponse",
    "ValidationResult": "{\"ActivityValidationResults\":[{\"ActivityId\":\"\",\"Fault\":\"ErrorRecurringCampaignEndDateDoesNotFitRequestedIterations\",\"Result\":\"Error\",\"ErrorMessageArguments\":[]}],\"Result\":\"Error\"}"
}
```
## See also

[CRUD operations on Customer Journey using C#]()<br/>
[Use Customer Journey to create automated campaigns](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/customer-journeys-create-automated-campaigns)<br/>
[Create Custom Journeys](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/create-simple-customer-journey)
