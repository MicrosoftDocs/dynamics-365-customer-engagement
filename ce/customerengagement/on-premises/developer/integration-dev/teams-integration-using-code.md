---
title: "Enable or disable Microsoft Teams Integration using code (Dynamics 365 Customer Engagement Developer Guide) | MicrosoftDocs"
description: "Know how to programmatically enable or disable Microsoft Teams Integration for system and custom entities in Dynamics 365 Customer Engagement."
ms.custom: 
ms.date: 06/21/2019
ms.service: crm-online
ms.topic: conceptual
ms.assetid: f0a710ca-fc62-4190-b75f-d61d2db76ca2
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer

 
---
# Enable or disable Microsoft Teams Integration using code

Enable Microsoft Teams Integration in Dynamics 365 Customer Engagement to seamlessly collaborate and work effectively across Microsoft Teams and Customer Engagement (on-premises). For detailed information about the feature, see [Integrate Dynamics 365 Customer Engagement (on-premises) with Microsoft Teams](/dynamics365/customer-engagement/basics/teams-integration).

When your admin [enables](/dynamics365/customer-engagement/basics/teams-install-app#bkmk_enable) the Microsoft Teams integration feature for your instance in system settings, the collaboration feature is enabled only for a selected set of system entities. If you want to enable Microsoft Teams integration for additional system entities or custom entities, you can only do it programmatically using the **msdyn_SetTeamsDocumentStatus** Web API action.

## msdyn_SetTeamsDocumentStatus action parameters

The **msdyn_SetTeamsDocumentStatus** action expects the following input parameters:

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td><code>Enable</code></td>
<td>Edm.Boolean</td>
<td>Indicates whether to enable or disable Teams Integration. Required.</td>
</tr>

<tr>
<td><code>LogicalEntityNames</code></td>
<td>Edm.String</td>
<td>An array with the list of logical names of all the entities for which you want to enable or disable the Teams Integration. Required.</td>
</tr>

</table>

## msdyn_SetTeamsDocumentStatus action return type

The **msdyn_SetTeamsDocumentStatus** action returns the following value:

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td><code>msdyn_SetTeamsDocumentStatusResponse</code></td>
<td><a href="/dynamics365/customer-engagement/developer/webapi/web-api-types-operations#complex-types">ComplexType</a> </td>
<td>Contains the response from <strong>msdyn_SetTeamsDocumentStatus</strong> action. It contains the following properties that contain the structured data of the type:
<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
<tr>
<td><code>FailedLogicalEntityNames</code></td>
<td>Edm.String</td>
<td>List of logical names of entities for which operation has failed.</td>
</tr>
<tr>
<td><code>PassedLogicalEntityNames</code></td>
<td>Edm.String</td>
<td>List of logical names of entities for which operation has passed.</td>
<tr>
<td><code>OperationResult</code></td>
<td>Edm.Boolean</td>
<td>Indicates whether the operation succeeded or failed.</td>
</tr>
</tr>
</table>
</table>

## msdyn_SetTeamsDocumentStatus action example

**Request**

```http
POST [Organization URI]/api/data/v9.0/msdyn_SetTeamsDocumentStatus
HTTP/1.1
Accept: application/json
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
{
    "Enable":false,
    "LogicalEntityNames":"[\"account\", \"contact\"]"
}
```

**Response**


```http
HTTP/1.1 200 OK
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0
{
    "@odata.context": [Organization URI]/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyn_SetTeamsDocumentStatusResponse",
    "PassedLogicalEntityNames": "[account,contact]",
    "FailedLogicalEntityNames": "[]",
    "OperationResult": true
}

```

### See also

[Integrate Dynamics 365 Customer Engagement (on-premises) with Microsoft Teams](/dynamics365/customer-engagement/basics/teams-integration)<br/>
[Admins: Enable Microsoft Teams integration Preview features](/dynamics365/customer-engagement/basics/teams-install-app#for-dynamics-365-for-customer-engagement-admins-enable-microsoft-teams-integration-preview-features)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]