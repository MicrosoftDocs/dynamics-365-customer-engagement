---
title: "Basic operations on the Customer Journey using the API (Dynamics 365 Marketing Developer Guide) | Microsoft Docs" 
description: "The Customer Journey API enables programmatic interaction with certain segmentation features of Dynamics 365 Marketing app."
ms.date: 04/03/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Basic operations on Customer Journey using the API

As you engage potential customers, they start by discovering your product, evaluating whether it meets their needs, looking for a good offer, and finally making a purchase. We call this process the *customer journey*. 

Use customer journeys to create a model that helps you guide the members of a selected marketing segment through this process by using automated messaging, activity generation, interactive decision points, and more. More information: [Create Customer Journey](/dynamics365/customer-engagement/marketing/customer-journeys-create-automated-campaigns).

The Customer Journey API enables programmatic interaction with customer journey records including publishing and validation.

The API uses the standard Microsoft Dataverse Web API for manipulating entities or messages. More information: [Use the Microsoft Dataverse Web API](/powerapps/developer/common-data-service/webapi/overview).

When you create a customer journey, the properties will be stored in the `msdyncrm_customerjourney` entity. You can browse the entity metadata information using `@odata.context`in the `GET` response.

> [!NOTE]
> Before you perform operations, you should install the [Dynamics 365 Marketing](/dynamics365/customer-engagement/marketing/trial-signup). 

This article demonstrates how to perform operations on the `msdyncrm_customerjourney` entity. The `msdyncrm_name` field is the only required field to create a customer journey. The fields that are used in this article to create a customer journey are shown in the following table.

|Display name|Schema name|Description or value|
|----------|--------------|------|
|Name|msdyncrm_name|Name of the Customer Journey|
|Status Reason|statuscode|Current status of the customer journey. Following are the available status codes: <br />- Draft `192350000`<br />- Live `192350001`<br />- Stopped `192350002`<br />- Live, Editable `192350003`<br />- Error `192350005`<br />- Going Live `192350006`<br />- Stopping `192350007`<br />
|Suppression Segment|msdyncrm_SuppressionSegmentId|The ID of the associated [Suppression Segment](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/suppression-segments). Use it to set reference to a record from `msdyncrm_segments` record set.|
|Recurrence Interval (Days)|msdyncrm_recurrenceintervaldays|The duration of the iteration (in days). Non-negative integer.|
|Minimum Consent|msgdpr_requiredconsent|- (1) Consent `587030001` <br /> - (2) Transactional `587030002`<br /> - (3) Subscriptions `587030003`<br /> - (4) Marketing `587030004` <br/> - (5) Profiling `587030005`|
|Recurrence Count|msdyncrm_recurrencecount|The number of iterations. Non-negative integer.|
|Workflow Definition|msdyncrm_workflowdefinition|The customer journey design definition. More information: [Customer Journey workflow definition](customer-journey-workflow-definition.md).|
|Customer Journey Designer State|msdyncrm_customerjourneydesignerstate|This is a hidden field, used by the customer journey designer to persist its internal state. The field should be copied if you are creating a copy of the `msdyncrm_workflowdefinition` field from another customer journey or customer journey template record.|
|Time Zone|msdyncrm_customerjourneytimezone|Effective time zone for the customer journey.|
|Content Settings|msdyncrm_contentsettingsId|The ID of associated [Content Settings](/dynamics365/customer-engagement/marketing/dynamic-email-content). Use it to reference a record from the `msdyncrm_contentsettingss` record set.|
|End Date and Time|msdyncrm_enddatetime|Date/time value in `ISO 8601` UTC format. Note that seconds and milliseconds precision will be disregarded.|
|Start Date and Time|msdyncrm_startdatetime|Date/time value in `ISO 8601` UTC format. Note that seconds and milliseconds precision will be disregarded.|
|Is Recurring|msdyncrm_isrecurring|A Boolean value.|
|Entity Target|msdyncrm_entitytarget|- Contact `0`<br />- Account `1`|
|Type|msdyncrm_type|- Automated `192350000`<br />- LinkedIn `192350001`|
|Status|statecode|Status of the customer journey.|

> [!NOTE]
> The `statuscode` and `statecode` fields define the state of the customer journey. Changing their values can result in `Publishing` or `Stopping` of customer journey workflow. If you wish to `go live` save the record in `Going Live` state (statuscode = 192350006). To stop a customer journey record, save the Live record in `Stopping` state (statuscode = 192350007).

Use the Postman tool to test the operations. More information: [Use Postman With Web API](/powerapps/developer/common-data-service/webapi/use-postman-web-api).

## Create, retrieve, update, and delete operations

### Create request

This request creates a customer journey record and sets the `statuscode` to `Draft`. This customer journey includes a segment with `ID:24db2671-1529-e911-a9b7-000d3a1e6adc` and `Unique Name: TC407937_DynamicSegment_2KZQ1p`and an email with `ID: 15bd0ab8-c12a-e911-a9b6-000d3a1e6c14`. The effective Content Settings has record `ID: 1922b1d8-0523-e911-a9ba-000d3a1e689f`. The response header [OData-EntityId](https://docs.oasis-open.org/odata/odata/v4.0/os/part1-protocol/odata-v4.0-os-part1-protocol.html#_Toc372793637) contains the URL to this newly created record (entity instance), which parenthetically includes the unique ID for this record.

> [!IMPORTANT]
> You need to replace `OrgUrl` with `https://<add your environment name, like ‘myorg.crm’>.dynamics.com`. You can also get the environment name from **Settings** > **Customizations** > **Developer Resources**.

```HTTP
POST {{OrgUrl}}/api/data/v9.0/msdyncrm_customerjourneys
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

### Retrieve request

The retrieve request retrieves the list of `Live` customer journeys.

```HTTP
GET {{OrgUrl}}/api/data/v9.0/msdyncrm_customerjourneys?$filter=statuscode eq 192350001
```

### Update request

With the update request, you update `statuscode` to, which effectively publishes it.

```HTTP
PATCH {{OrgUrl}}api/data/v9.0/msdyncrm_customerjourneys(8aee9d91-8c2b-e911-a9b7-000d3a1e6adc)
{
    "statuscode": 192350006
}
```

### Delete request

With the delete request, you delete the customer journey that you created earlier.

```HTTP
DELETE {{OrgUrl}}/api/data/v9.0/msdyncrm_customerjourneys(b6faa2b7-b92b-e911-8185-000d3af9d16a)
```

## Check for Errors

The Check for Errors feature checks the current record for missing content and technical errors and then displays the validation results, including error messages that should help the user solve any issues that were found.

The request body is a JSON object, which contains number of data elements with values corresponding to the `msdyncrm_customerjourney` entity properties. The reference field (for example, Content Settings ID) doesn't use `@odata.bind` with the record set reference but uses the ID of the referenced record. The following table explains the mapping.

|Key|Corresponding property msdyncrm_customerjourney entity (logical name)|
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

### Validate Customer Journey request

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
```

### Validate Customer Journey response

```HTTP
{
    "@odata.context": "{{orgUrl}}/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyncrm_CustomerJourneyValidateResponse",
    "ValidationResult": "{\"ActivityValidationResults\":[{\"ActivityId\":\"\",\"Fault\":\"ErrorRecurringCampaignEndDateDoesNotFitRequestedIterations\",\"Result\":\"Error\",\"ErrorMessageArguments\":[]}],\"Result\":\"Error\"}"
}
```

### Validation result

The following table describes the schema of the `ValidationResult` object received in the [Validate Customer Journey response](#validate-customer-journey-response).

|Property|Type|Description|
|-------|------|---------|
|Result|String|The overall error check result. It has the following values:<br /> **Valid** – Records that passed the validation check.<br />**Warning** – Records that passed validation check; there are nonblocking issues with it.<br />**Error** – Records that did not pass validation; there are blocking issues with it.|
|ActivityValidationResults|`Object[]`|An array of validation detail objects. Each one refers to a specific problem that can apply to the customer journey record, a specific tile within the workflow design. See the [Activity validation result schema](#activity-validation-result).|

### Activity validation result

The following table shows the schema of objects contained within the `ActivityValidationResults` array of the `ValidationResult` object.

|Property|Type|Description|
|-------|-------|---------|
|ActivityId|String|The Activity ID of the actual workflow tile to which the validation result applies. If empty, the validation result applies globally to the entire workflow definition or other properties of the customer journey.|
|Fault|String|The code that identifies the actual validation result. See the validation [sample](extend-customer-journey-using-code.md) to learn how to work with messages associated with fault codes.|
|Result|String|The result severity. It has the following values:<br />**Valid** – Informative entry<br />**Warning** – Nonblocking issue<br />**Error** – Blocking issue|
|ErrorMessageArguments|String[]|Optional list of arguments that provides details of the validation result, for example, an ID of the element that fails to meet the validity criteria.|

## See also

[Basic operations on Customer Journey using C#](extend-customer-journey-using-code.md)<br/>
[Customer journey workflow definition](customer-journey-workflow-definition.md)<br/>
[Use Customer Journey to create automated campaigns](/dynamics365/customer-engagement/marketing/customer-journeys-create-automated-campaigns)<br/>
[Create Custom Journeys](/dynamics365/customer-engagement/marketing/create-simple-customer-journey)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]