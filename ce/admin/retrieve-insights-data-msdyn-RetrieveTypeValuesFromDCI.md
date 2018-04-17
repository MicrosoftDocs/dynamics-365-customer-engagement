---
title: "Retrieve insights data using msdyn_RetrieveTypeValuesFromDCI action (Dynamics 365 Customer Engagement) | Microsoft Docs  "
description: "Use the **msdyn_RetrieveTypeValuesFromDCI** action to programmatically retrieve profiles, interactions, and KPIs for an account, contact, lead or opportunity that is stored Azure service that is used to compute and store data"
keywords: "GDPR; data protection; privacy; embedded intelligence"
ms.date: 04/18/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d0d20528-0a72-4dd2-8c91-6367a9d4279d
author: KumarVivek
ms.author: kvivek
manager: kvivek
---

# Retrieve insights data using msdyn_RetrieveTypeValuesFromDCI action

Applies to Dynamics 365 (online), version 9.0.2

Use the **msdyn_RetrieveTypeValuesFromDCI** action to programmatically retrieve profiles, interactions, and KPIs stored in Azure service that is used to compute and store data for an account, contact, lead or opportunity. This action is useful for responding to data requests in order to fulfill the GDPR compliance in Embedded Intelligence.

> [!NOTE]
> - You can also generate request and response classes for this action to include in your application code. More information: [Generate early-bound types for an action](../../developer/create-own-actions.md#generate-early-bound-types-for-an-action)
> - This topic is applicable only for the [Relationship Analytics](../admin/relationship-analytics.md) feature.

## Action parameters

The **msdyn_RetrieveTypeValuesFromDCI** action expects the following input parameters:

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td valign="top"><code>CrmRecord</code></td>
<td valign="top">[mscrm.crmbaseentity](/dynamics365/customer-engagement/web-api/crmbaseentity)</td>
<td valign="top">Entity type for which you want to retrieve the data. Required.
<p>You can specify one of the following values:</p>
<ul>
<li><code>Microsoft.Dynamics.CRM.account</code></li>
<li><code>Microsoft.Dynamics.CRM.contact</code></li>
<li><code>Microsoft.Dynamics.CRM.lead</code></li>
<li><code>Microsoft.Dynamics.CRM.opportunity</code></li>
</ul>

<p>Depending on the specified entity type, you must specify <code>accountid</code>, 
<code>contactid</code>, <code>leadid</code>, or <code>opportunityid</code> as the second key to identify the entity record you want to retrieve data for. See [Example](#example) later in this topic.</p></td>
</tr>

<tr>
<td valign="top"><code>ResourceType</code></td>
<td valign="top">Edm.Int32</td>
<td valign="top">Resource type to retrieve. Required.
<p>Specify one of the following int values:
<ul>
<li>1: Profiles</li>
<li>2: Interactions</li>
<li>3: KPIs</li>

</ul></td>
</tr>
<tr>
<td valign="top"><code>ResourceTypeName</code></td>
<td valign="top">Edm.String</td>
<td>Name of the resource type. Required.
<p>The parameter value depends on the type of resource you specified in the <code>ResourceType</code> parameter.
<table>
<tr>
<th>ResourceType</th>
<th>Valid ResourceTypeName</th>
</tr>
<tr>
<td valign="top">1</td>
<td>
<ul>
<li>account</li>
<li>contact</li>
<li>lead</li>
<li>opportunity</li>
</ul></td>
</tr>
<tr>
<td valign="top">2</td>
<td>
<ul>
<li>email</li>
<li>appointment</li>
<li>phonecall</li>
<li>task</li>
</ul></td>
</tr>
<tr>
<td valign="top">3</td>
<td>
<ul>
<li>accountaveragefirstresponsetimebytheminminlifetime 
<li>accountaveragefirstresponsetimebythemlifetime 
<li>accountaveragefirstresponsetimebyusinminlifetime 
<li>accountaveragefirstresponsetimebyuslifetime 
<li>accounteffectiveemailsreceived 
<li>accountemailsreceived 
<li>accountemailsreceivedbyteam 
<li>accountemailsreceivedbyteamlifetime 
<li>accountemailsreceivedlifetime 
<li>accountemailssent 
<li>accountemailssentlifetime 
<li>accountemailstotal 
<li>accountfacetimewithcustomer 
<li>accountmeetingsdurationtotal 
<li>accountmeetingsreceived 
<li>accountmeetingsreceivedbyteam 
<li>accountmeetingsreceivedbyteamlifetime 
<li>accountmeetingsreceivedduration 
<li>accountmeetingsreceiveddurationbyteam 
<li>accountmeetingsreceiveddurationbyteamlifetime 
<li>accountmeetingsreceiveddurationlifetime 
<li>accountmeetingsreceivedlifetime 
<li>accountmeetingssent 
<li>accountmeetingssentduration 
<li>accountmeetingssentdurationlifetime 
<li>accountmeetingssentlifetime 
<li>accountmostcontacted 
<li>accountmostcontactedby 
<li>accountmostcontactedbynumberofemails 
<li>accountmostcontactedbynumberofmeetings 
<li>accountmostcontactedbynumberofphonecalls 
<li>accountmostcontactedbyviaappointment 
<li>accountmostcontactedbyviaemail 
<li>accountmostcontactedbyviaphonecall 
<li>accountmostcontactednumberofemails 
<li>accountmostcontactednumberofmeetings", "none"}, 
<li>accountmostcontactednumberofphonecalls 
<li>accountmostcontactedviaappointment 
<li>accountmostcontactedviaemail 
<li>accountmostcontactedviaphonecall 
<li>accountphonecalldurationtotal 
<li>accountphonecallsmade 
<li>accountphonecallsmadeduration 
<li>accountphonecallsmadedurationlifetime 
<li>accountphonecallsmadelifetime 
<li>accountphonecallsreceived 
<li>accountphonecallsreceivedbyteam 
<li>accountphonecallsreceivedbyteamlifetime 
<li>accountphonecallsreceivedduration 
<li>accountphonecallsreceiveddurationbyteam 
<li>accountphonecallsreceiveddurationbyteamlifetime 
<li>accountphonecallsreceiveddurationlifetime 
<li>accountphonecallsreceivedlifetime 
<li>accountresponseratebythemlifetime 
<li>accountresponseratebyuslifetime 
<li>accounttaskscompleted 
<li>accounttaskscompletedduration 
<li>accounttaskscompleteddurationlifetime 
<li>accounttimespentbyteam 
<li>attachmentopencountforaccount 
<li>attachmentopencountforcontact 
<li>attachmentopencountforlead 
<li>attachmentopencountforopportunity 
<li>attachmentopensforaccount 
<li>attachmentopensforcontact 
<li>attachmentopensforlead 
<li>attachmentopensforopportunity 
<li>contactaveragefirstresponsetimebytheminminlifetime 
<li>contactaveragefirstresponsetimebythemlifetime 
<li>contactaveragefirstresponsetimebyusinminlifetime 
<li>contactaveragefirstresponsetimebyuslifetime 
<li>contacteffectiveemailsreceived 
<li>contactemailsreceived 
<li>contactemailsreceivedbyteam 
<li>contactemailsreceivedbyteamlifetime 
<li>contactemailsreceivedlifetime 
<li>contactemailssent 
<li>contactemailssentlifetime 
<li>contactemailstotal 
<li>contactfacetimewithcustomer 
<li>contactmeetingsdurationtotal 
<li>contactmeetingsreceived 
<li>contactmeetingsreceivedbyteam 
<li>contactmeetingsreceivedbyteamlifetime 
<li>contactmeetingsreceivedduration 
<li>contactmeetingsreceiveddurationbyteam 
<li>contactmeetingsreceiveddurationbyteamlifetime 
<li>contactmeetingsreceiveddurationlifetime 
<li>contactmeetingsreceivedlifetime 
<li>contactmeetingssent 
<li>contactmeetingssentduration 
<li>contactmeetingssentdurationlifetime 
<li>contactmeetingssentlifetime 
<li>contactmostcontactedby 
<li>contactmostcontactedbynumberofemails 
<li>contactmostcontactedbynumberofmeetings 
<li>contactmostcontactedbynumberofphonecalls 
<li>contactmostcontactedbyviaappointment 
<li>contactmostcontactedbyviaemail 
<li>contactmostcontactedbyviaphonecall 
<li>contactphonecalldurationtotal 
<li>contactphonecallsmade 
<li>contactphonecallsmadeduration 
<li>contactphonecallsmadedurationlifetime 
<li>contactphonecallsmadelifetime 
<li>contactphonecallsreceived 
<li>contactphonecallsreceivedbyteam 
<li>contactphonecallsreceivedbyteamlifetime 
<li>contactphonecallsreceivedduration 
<li>contactphonecallsreceiveddurationbyteam 
<li>contactphonecallsreceiveddurationbyteamlifetime 
<li>contactphonecallsreceiveddurationlifetime 
<li>contactphonecallsreceivedlifetime 
<li>contactresponseratebythemlifetime 
<li>contactresponseratebyuslifetime 
<li>contacttaskscompleted 
<li>contacttaskscompletedduration 
<li>contacttaskscompleteddurationlifetime 
<li>contacttimespentbyteam 
<li>followedemailsforaccount 
<li>followedemailsforcontact 
<li>followedemailsforlead 
<li>followedemailsforopportunity 
<li>leadaveragefirstresponsetimebytheminminlifetime 
<li>leadaveragefirstresponsetimebythemlifetime 
<li>leadaveragefirstresponsetimebyusinminlifetime 
<li>leadaveragefirstresponsetimebyuslifetime 
<li>leadeffectiveemailsreceived 
<li>leademailsreceived 
<li>leademailsreceivedbyteam 
<li>leademailsreceivedbyteamlifetime 
<li>leademailsreceivedlifetime 
<li>leademailssent 
<li>leademailssentlifetime 
<li>leademailstotal 
<li>leadfacetimewithcustomer 
<li>leadmeetingsdurationtotal 
<li>leadmeetingsreceived 
<li>leadmeetingsreceivedbyteam 
<li>leadmeetingsreceivedbyteamlifetime 
<li>leadmeetingsreceivedduration 
<li>leadmeetingsreceiveddurationbyteam 
<li>leadmeetingsreceiveddurationbyteamlifetime 
<li>leadmeetingsreceiveddurationlifetime 
<li>leadmeetingsreceivedlifetime 
<li>leadmeetingssent 
<li>leadmeetingssentduration 
<li>leadmeetingssentdurationlifetime 
<li>leadmeetingssentlifetime 
<li>leadmostcontacted 
<li>leadmostcontactedby 
<li>leadmostcontactedbynumberofemails 
<li>leadmostcontactedbynumberofmeetings 
<li>leadmostcontactedbynumberofphonecalls 
<li>leadmostcontactedbyviaappointment 
<li>leadmostcontactedbyviaemail 
<li>leadmostcontactedbyviaphonecall 
<li>leadmostcontactednumberofemails 
<li>leadmostcontactednumberofmeetings 
<li>leadmostcontactednumberofphonecalls 
<li>leadmostcontactedviaappointment 
<li>leadmostcontactedviaemail 
<li>leadmostcontactedviaphonecall 
<li>leadphonecalldurationtotal 
<li>leadphonecallsmade 
<li>leadphonecallsmadeduration 
<li>leadphonecallsmadedurationlifetime 
<li>leadphonecallsmadelifetime 
<li>leadphonecallsreceived 
<li>leadphonecallsreceivedbyteam 
<li>leadphonecallsreceivedbyteamlifetime 
<li>leadphonecallsreceivedduration 
<li>leadphonecallsreceiveddurationbyteam 
<li>leadphonecallsreceiveddurationbyteamlifetime 
<li>leadphonecallsreceiveddurationlifetime 
<li>leadphonecallsreceivedlifetime 
<li>leadresponseratebythemlifetime 
<li>leadresponseratebyuslifetime 
<li>leadtaskscompleted 
<li>leadtaskscompletedduration 
<li>leadtaskscompleteddurationlifetime 
<li>leadtimespentbyteam 
<li>linksclickedcountforaccount 
<li>linksclickedcountforcontact 
<li>linksclickedcountforlead 
<li>linksclickedcountforopportunity 
<li>linksclickedforaccount 
<li>linksclickedforcontact 
<li>linksclickedforlead 
<li>linksclickedforopportunity 
<li>openedemailscountforaccount 
<li>openedemailscountforcontact 
<li>openedemailscountforlead 
<li>openedemailscountforopportunity 
<li>openedemailsforaccount 
<li>openedemailsforcontact 
<li>openedemailsforlead 
<li>openedemailsforopportunity 
<li>opportunityaveragefirstresponsetimebytheminminlifetime 
<li>opportunityaveragefirstresponsetimebythemlifetime 
<li>opportunityaveragefirstresponsetimebyusinminlifetime 
<li>opportunityaveragefirstresponsetimebyuslifetime 
<li>opportunityeffectiveemailsreceived 
<li>opportunityemailsreceived 
<li>opportunityemailsreceivedbyteam 
<li>opportunityemailsreceivedbyteamlifetime 
<li>opportunityemailsreceivedlifetime 
<li>opportunityemailssent 
<li>opportunityemailssentlifetime 
<li>opportunityemailstotal 
<li>opportunityfacetimewithcustomer 
<li>opportunitymeetingsdurationtotal 
<li>opportunitymeetingsreceived 
<li>opportunitymeetingsreceivedbyteam 
<li>opportunitymeetingsreceivedbyteamlifetime 
<li>opportunitymeetingsreceivedduration 
<li>opportunitymeetingsreceiveddurationbyteam 
<li>opportunitymeetingsreceiveddurationbyteamlifetime 
<li>opportunitymeetingsreceiveddurationlifetime 
<li>opportunitymeetingsreceivedlifetime 
<li>opportunitymeetingssent 
<li>opportunitymeetingssentduration 
<li>opportunitymeetingssentdurationlifetime 
<li>opportunitymeetingssentlifetime 
<li>opportunitymostcontacted 
<li>opportunitymostcontactedby 
<li>opportunitymostcontactedbynumberofemails 
<li>opportunitymostcontactedbynumberofmeetings 
<li>opportunitymostcontactedbynumberofphonecalls 
<li>opportunitymostcontactedbyviaappointment 
<li>opportunitymostcontactedbyviaemail 
<li>opportunitymostcontactedbyviaphonecall 
<li>opportunitymostcontactednumberofemails 
<li>opportunitymostcontactednumberofmeetings 
<li>opportunitymostcontactednumberofphonecalls 
<li>opportunitymostcontactedviaappointment 
<li>opportunitymostcontactedviaemail 
<li>opportunitymostcontactedviaphonecall 
<li>opportunityphonecalldurationtotal 
<li>opportunityphonecallsmade 
<li>opportunityphonecallsmadeduration 
<li>opportunityphonecallsmadedurationlifetime 
<li>opportunityphonecallsmadelifetime 
<li>opportunityphonecallsreceived 
<li>opportunityphonecallsreceivedbyteam 
<li>opportunityphonecallsreceivedbyteamlifetime 
<li>opportunityphonecallsreceivedduration 
<li>opportunityphonecallsreceiveddurationbyteam 
<li>opportunityphonecallsreceiveddurationbyteamlifetime 
<li>opportunityphonecallsreceiveddurationlifetime 
<li>opportunityphonecallsreceivedlifetime 
<li>opportunityresponseratebythemlifetime 
<li>opportunityresponseratebyuslifetime 
<li>opportunitytaskscompleted 
<li>opportunitytaskscompletedduration 
<li>opportunitytaskscompleteddurationlifetime 
<li>opportunitytimespentbyteam 
</ul></td>
</tr>
</table>
</td>
</tr>
<tr>
<td valign="top"><code>StartDate</code></td>
<td valign="top">Edm.DateTimeOffset</td>
<td>Date and time from which you want to retrieve the data. Optional.
</td>
</tr>

<tr>
<td valign="top"><code>EndDate</code></td>
<td valign="top">Edm.DateTimeOffset</td>
<td>Date and time until which you want to retrieve the data. Optional.
<p>If you don't specify a value for this parameter, current date and time is passed by default.</td>
</tr>
</table>

## Action return type

The **msdyn_RetrieveTypeValuesFromDCI** action returns the following value:

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td><code>msdyn_RetrieveTypeValuesFromDCIResponse</code></td>
<td><a href="/dynamics365/customer-engagement/developer/webapi/web-api-types-operations#complex-types">ComplexType</a> </td>
<td>Contains the response from the <b>msdyn_RetrieveTypeValuesFromDCI</b> action. It contains the following property that contain the structured data of the type:
<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
<tr>
<td><code>ResponseValues</code></td>
<td>Edm.String</td>
<td>List of data as an escaped JSON array.</td>
</tr>
</table>
</table>

## Example

**Request**

```http
POST [Organization URI]/api/data/v9.0/msdyn_RetrieveTypeValuesFromDCI HTTP/1.1
Accept: application/json
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
  
{
  "CrmRecord": {
    "@odata.type": "Microsoft.Dynamics.CRM.account",
    "accountid": "bf1b1e9a-6e28-e811-a94e-000d3a365e68"
  },
  "ResourceType": "3",
  "ResourceTypeName": "accountEmailsreceived",
  "StartDate": "2018-03-11T17:11:04Z",
  "EndDate": "2018-03-15T17:11:05Z"
}
```

**Response**

The response contains a JSON object with a `ResponseValues` property containing the list of data stored in Azure service that is used to compute and store data.

```http
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0

{
  "@odata.context": "[Organization URI]/api/data/v9.0/$metadata#Microsoft.Dynamics.CRM.msdyn_RetrieveTypeValuesFromDCIResponse",
  "ResponseValues": "[{\"Timestamp\":\"2018-03-15T00:00:00Z\",\"Value\":448.000000000,\"CalculationTime\":\"2018-03-29T17:00:00Z\",\"CountValue\":448,\"MinValue\":0.000000000,\"MaxValue\":0.000000000,\"SumValue\":0.000000000,\"AverageValue\":1.000000000,\"FiscalQuarter\":\"Q2-2018\",\"CalendarQuarter\":\"Q1-2018\",\"FiscalYear\":\"2018-2019\",\"CalendarYear\":\"2018\",\"applicableaccounts\":\"bf1b1e9a-6e28-e811-a94e-000d3a365e68\"}]"
}
```

### See also

[Use Web API actions](../developer/webapi/use-web-api-actions)

[Embedded Intelligence and GDPR](embedded-intelligence-gdpr.md)