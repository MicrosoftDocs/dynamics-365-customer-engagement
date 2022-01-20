---
title: "User authentication using Events API (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn how to use the Events API to authenticate users in Dynamics 365 Marketing."
ms.date: 06/11/2019
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

# User authentication using Events API

The Events API supports user authentication with Azure Active Directory B2C. To link the Events API to your Azure Active Directory B2C, you need to add your `AAD Client ID` and `AAD Metadata Endpoint` to your `web application setting`.  More information: [Creating Azure AD B2C tenant and adding a web application to the tenant](event-management-aad-b2c-setup.md#creating-azure-ad-b2c-tenant-and-adding-a-web-application-to-the-tenant)

To authenticate the user against the API, you need to add the `Authorization` header containing the `token_id` bearer to each API request. 

This `token_id` can be retrieved by authenticating the user against Azure Active Directory B2C. 

**Request** 

```http
curl -X GET \ 
  'https:// b7c1ad1ab7fa4a7482b16315d94a26af.svc-tip.dynamics.com/EvtMgmt/api/v2.0/events/published?emApplicationtoken=VZsLZhx251OM9uJa..' \ 
  -H 'Authorization: Bearer eyJ0eXAiOiJK…\ 
  -H 'Origin: https://localhost:4200' 
``` 

## Contact matching strategy

The Events API will automatically try to link contacts from Azure Active Directory B2C to the contacts in Dynamics 365 Marketing.  

To do so, it uses a contact matching strategy that can be configured in the event administration settings. By default, first name, last name, and email are used as the contact matching strategy. More information: [Event administration](../events-settings.md#event-administration)

In case no matching contact is found, a new contact will be created automatically. 

> [!NOTE]
> Linked contact entities contain an attribute called `msevtmgt_aadobjectid` that stores the object ID of the user in Azure Active Directory B2C.

### Retrieving information of authenticated user 

The Events API provides an endpoint that returns the information of the authenticated user. Starting with the June 2019 release, it also includes the Dynamics 365 Marketing contact ID of the authenticated user. 

**Request** 

```http
curl -X GET \
  'https:// b7c1ad1ab7fa4a7482b16315d94a26af.svc-tip.dynamics.com/EvtMgmt/api/v2.0/users/authenticated?emApplicationtoken=VZsLZhx251OM9uJa..' \
  -H 'Authorization: Bearer eyJ0eXAiOiJK…\ 
  -H 'Origin: https://localhost:4200'
```

**Response** 

```json
{
   "id":"05ef77de-b882-e911-a970-000d3a4e9aa0",
   "firstName":"John",
   "lastName":"Doe",
   "email":"joe.doe@contoso.com",
   "isAnonymous":false
} 
```

## See also
[Using Events API](using-events-api.md)<br />
[Customize the response from Events API](customize-events-api-response.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]