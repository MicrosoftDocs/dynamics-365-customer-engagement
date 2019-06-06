---
title: "Using the Events API (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Read about the Events API that lets you access data of events, sessions, session tracks and passes"
ms.custom: 
  - dyn365-developer
  - dyn365-marketing
ms.date: 06/06/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - marketing
ms.topic: conceptual
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: A0B01ED6-04C0-4A7C-BD14-05E78A119580
author: susikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---
# Using the Events API

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

The Events API is a programmatic method to access data of events, sessions, session tracks, passes, speakers and sponsorships. Additionally, it allows you to register for events and sessions.

## Schema 

The API access is over HTTPS and is accessed from the API endpoint that you receive while creating a web application token. All data is sent and received as JSON. 

Blank fields are included as `null` instead of being omitted. 

## Endpoint 

Every customer has its own endpoint URL. The Event API endpoint URL consists of two parts:
- the endpoint domain and,
- the sub directory.  

You will get the root endpoint after creating a `web application token`. You can find more information on how to create a web application token here [link to create web application token page]. 

**Example for root endpoint**

```http
https://b7c1ad1ab7fa4a7482b16315d94a26af.svc.dynamics.com 
``` 

The sub directory always starts with `EvtMgmt/api` followed by the API version (which can be retrieved from the API documentation [link to api documtation]). 

**Example for sub directory**

```http
EvtMgmt/api/v2.0/ 
``` 

**Example for full endpoint URL** 

```http
https://b7c1ad1ab7fa4a7482b16315d94a26af.svc.dynamics.com/EvtMgmt/api/v2.0/ 
```

## Authentication 

To use the Events API, you need to provide a `web application token` as URL parameter in each request. The web application token is used to control API requests that are associated with your organization. Please see [create web application token page] on how to create and retrieve a web application. 

The `web application token` can be added to the request by adding a URL parameter called `emApplicationtoken`. 

**Example** 

```http
https://b7c1ad1ab7fa4a7482b16315d94a26af.svc.dynamics.com/EvtMgmt/api/v2.0/events/published? emApplicationtoken=B7vdzdhCiLt9c5iT….
```

Additionally, the origin from where the request is sent must be equal to the origin specified when creating the `web application token`.

If you do not provide a `web application token` or the `Origin Header` the Events API will return `HTTP 400 Bad Request`.

If the `web application token` is invalid, the Events API will return `HTTP 401 Unauthorized`.

## Register your application

To use the Events API, you need to provide a web application token in each request. The web application token is used to control API requests that are associated with your organization. More information: [Register your web application](host-custom-event-website-on-azure.md#step-2-register-your-web-application).

## User authentication

The Events API supports user authentication with Azure Active Directory B2C. To link the Events API to your AAD B2C you need to add your `AAD Client ID` and `AAD Metadata Endpoint` to your `web application setting`.  More information [Creating Azure AD B2C tenant and adding a web application to the tenant](event-management-aad-b2c-setup.md#creating-azure-ad-b2c-tenant-and-adding-a-web-application-to-the-tenant).

To authenticate the user against the API you need to add the `Authorization` header containing the `token_id` bearer to each API request. 

This `token_id` can be retrieved by authenticating the user against Azure Active Directory B2C. 

**Request** 

```http
curl -X GET \ 
  'https:// b7c1ad1ab7fa4a7482b16315d94a26af.svc-tip.dynamics.com/EvtMgmt/api/v2.0/events/published?emApplicationtoken=VZsLZhx251OM9uJa..' \ 
  -H 'Authorization: Bearer eyJ0eXAiOiJK…\ 
  -H 'Origin: http://localhost:4200' 
``` 

### Contact Matching Strategy

The Events API will automatically try to link contacts from Azure Active Directory B2C to the contacts in Dynamics CRM.  

To do so, it uses a contact matching strategy which can be configured in event administration settings. By default, first name + last name + email is used as contact matching strategy. More information: [Event administration](../events-settings.md#event-administration).

In case no matching contact is found, a new contact will be automatically created in Dynamics 365. 

> [!NOTE]
> Linked contact entities contain an attribute called `msevtmgt_aadobjectid` which stores the object ID of the user in Azure Active Directory B2C.

### Retrieving information of authenticated user 

The Events API provides an endpoint that returns information of the authenticated user. Starting with June 2019 Release it does also include the Dynamics CRM contact ID of the authenticated user. 

**Request** 

```http
curl -X GET \
  'https:// b7c1ad1ab7fa4a7482b16315d94a26af.svc-tip.dynamics.com/EvtMgmt/api/v2.0/users/authenticated?emApplicationtoken=VZsLZhx251OM9uJa..' \
  -H 'Authorization: Bearer eyJ0eXAiOiJK…\ 
  -H 'Origin: http://localhost:4200'
```

**Response** 

```json
{
“id”: “05ef77de-b882-e911-a970-000d3a4e9aa0”,
“firstName”: “John”,
“lastName”: “Doe”,
“email”: “joe.doe@contoso.com”,
“isAnonymous”: false
} 
```

## Customizing API response

The Events API allows you to expose custom fields of event management entities. That means you can access all those fields that have been added to an entity by the customer.

By default, when adding a new field to an entity (e.g. `msevtmgt_pass`) it is not exposed by the corresponding API endpoint (for example: `api/v2.0/events/{readableEventId}/passes`). 

However, it is possible to expose the new field in the Events API by creating a so-called ‘Website Entity Configuration’. 

Follow the steps below to create a new website entity configuration: 

1. Open your Dynamics 365 instance. 
2. Go to **Dynamics 365** > **Marketing** > **Settings** > **Website Entity Configurations**. 
3. Enter a name of your choice in the `Name` field. 
4. Select the entity for which you would like to expose an extra field in the `Selected Entity` field. 
5. Write a JSON array that contains the new custom field that should be visible through the API in the Selected fields. This exposes the new custom field through the Events API.

![Customize API response](../media/using-events-api-customize-response.png)

## See also

[Metadata reference for your organization](marketing-organization-metadata.md)<br />
[Entity reference](marketing-entity-reference.md)