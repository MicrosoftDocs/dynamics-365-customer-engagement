---
title: Retrieve data using msdyn_RetrieveKPIValuesForGDPR action
description: Use the action to programmatically retrieve profiles, interactions, and KPIs for an account, contact, lead or opportunity that is stored Azure service.
ms.date: 04/21/2023
ms.topic: article
author: udaykirang
ms.author: udag
keywords: "GDPR; data protection; privacy; embedded intelligence"
ms.assetid: d0d20528-0a72-4dd2-8c91-6367a9d4279d
topic-status: Drafting
---

# Retrieve insights data using msdyn_RetrieveKPIValuesForGDPR action

[!INCLUDE [gdpr-intro](~/../shared-content/shared/privacy-includes/gdpr-intro.md)]

Use the **msdyn_RetrieveKPIValuesForGDPR** action to programmatically retrieve profiles, interactions, and KPIs stored in Azure service that is used to compute and store data for an contact, lead, opportunity, or systemuser. This action is useful for responding to data requests to fulfill your data privacy compliance obligations in Dynamics 365 Sales Insights.

> [!NOTE]
> - You can also generate request and response classes for this action to include in your application code. More information: [Generate early-bound types for an action](/dynamics365/customer-engagement/developer/create-own-actions#generate-early-bound-types-for-an-action&preserve-view=true)
> - This topic is applicable only for the [Relationship Analytics](relationship-analytics.md) and [Introduction to Sales Insights application](dynamics365-sales-insights-app.md) features.

## Action parameters

The **msdyn_RetrieveKPIValuesForGDPR** action expects the following input parameters:

| Name | Type | Description |
|------|------|-------------|
| `CRMRecord` | <a href="/dynamics365/customer-engagement/web-api/crmbaseentity?view=dynamics-ce-odata-9&preserve-view=true" data-raw-source="[mscrm.crmbaseentity](dynamics365/customer-engagement/web-api/crmbaseentity?view=dynamics-ce-odata-9&preserve-view=true)">mscrm.crmbaseentity</a> | Entity type for which you want to retrieve the data. Required.<br><p>You can specify one of the following values:</p><ul><li><code>Microsoft.Dynamics.CRM.contact</code></li><li><code>Microsoft.Dynamics.CRM.lead</code></li><li><code>Microsoft.Dynamics.CRM.opportunity</code></li><li><code>Microsoft.Dynamics.CRM.systemuser</code></li></ul><p>Depending on the specified entity type, you must specify <code>contactid</code>, <code>leadid</code>, <code>opportunityid</code>, or <code>systemuserid</code> as the second key to identify the entity record you want to retrieve data for. See <a href="#example" data-raw-source="[Example](#example)">Example</a> later in this topic.</p>|
|

## Action return type

The **msdyn_RetrieveKPIValuesForGDPR** action returns the following value:

| Name | Type | Description |
|------|------|-------------|
| `msdyn_RetrieveKPIValuesForGDPRResponse` | <a href="/dynamics365/customer-engagement/developer/webapi/web-api-types-operations#complex-types">ComplexType</a> | Contains the response from the <b>msdyn_RetrieveKPIValuesForGDPR</b> action. It contains the following property that contain the structured data of the type:<ul><li><b>Name:</b> `Response`</li><li><b>Type:</b> Edm.String </li><li><b>Description:</b> List of data as an escaped JSON array. |


## Example

**Request**

```http
POST [Organization URI]/api/data/v9.0/msdyn_RetrieveKPIValuesForGDPR HTTP/1.1
Accept: application/json
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
  
{
  "CRMRecord": {
    "@odata.type": "Microsoft.Dynamics.CRM.contact",
    "contactid": "bf1b1e9a-6e28-e811-a94e-000d3a365e68"
  }
}  
```

**Response**

The response contains a JSON object with a `Response` property containing the list of data stored in Azure service that is used to compute and store data.

```http
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0

{
  "@odata.context": "[Organization URI]/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyn_RetrieveKPIValuesForGDPRResponse",
   "Response": {\"EntityId\": \"bf1b1e9a-6e28-e811-a94e-000d3a365e68\",\"Daily UI KPIs\": \"Some Values\",\"Lifetime UI KPIs\": \"Some Values\",\"Most Contacted KPIs\": \"Some Values\",\"Health KPIs\": \"Some Values\"}]"
}
```

### See also

[Use Web API actions](/dynamics365/customer-engagement/developer/webapi/use-web-api-actions)

[Sales Insights and privacy](embedded-intelligence-privacy.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
