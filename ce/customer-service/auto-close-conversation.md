---
title: "Automatic closure of a conversation| Microsoft Docs"
description: "Read how you can auto-close a conversation using the Web API"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 10/25/2019
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# Automatic closure of a conversation

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic demonstrates how you can configure auto-close duration for a conversation using the Web API. 

Use the `GET` request given below to fetch all the configuration records that have been defined out of the box.

**Request**

```http
GET [Organization URI]/api/data/v9.1/msdyn_occhannelstateconfigurations
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0
If-None-Match: null
```

**Response**

```http
{ 
   "@odata.context":"[Organization URI]/api/data/v9.1/$metadata#msdyn_occhannelstateconfigurations",
   "value":[ 
      { 
         "@odata.etag":"W/\"1379367\"",
         "_organizationid_value":"758f70a9-7aba-4764-bdda-fcc0023a702f",
         "msdyn_name":"Live Chat - Open",
         "statecode":0,
         "statuscode":1,
         "_msdyn_occhannelconfigurationid_value":"836717fd-5578-e911-8196-000d3af7d71e",
         "msdyn_autocloseliveworkitemafter":20,
         "modifiedon":"2019-10-01T13:41:51Z",
         "_modifiedby_value":"d6e088ce-8866-4b3d-8ea2-150ad72e2b79",
         "msdyn_ocliveworkitemstate":0,
         "msdyn_showconfirmationonsessionclose":false,
         "versionnumber":1379367,
         "msdyn_occhannelstateconfigurationid":"6283ab63-5778-e911-8196-000d3af7d71e",
         "createdon":"2019-10-01T13:41:51Z",
         "_createdby_value":"d6e088ce-8866-4b3d-8ea2-150ad72e2b79",
         "_modifiedonbehalfby_value":null,
         "importsequencenumber":null,
         "overriddencreatedon":null,
         "_createdonbehalfby_value":null,
         "utcconversiontimezonecode":null,
         "timezoneruleversionnumber":null
      },
      { 
         "@odata.etag":"W/\"1379368\"",
         "_organizationid_value":"758f70a9-7aba-4764-bdda-fcc0023a702f",
         "msdyn_name":"Live Chat - Active",
         "statecode":0,
         "statuscode":1,
         "_msdyn_occhannelconfigurationid_value":"836717fd-5578-e911-8196-000d3af7d71e",
         "msdyn_autocloseliveworkitemafter":null,
         "modifiedon":"2019-10-01T13:41:51Z",
         "_modifiedby_value":"d6e088ce-8866-4b3d-8ea2-150ad72e2b79",
         "msdyn_ocliveworkitemstate":1,
         "msdyn_showconfirmationonsessionclose":true,
         "versionnumber":1379368,
         "msdyn_occhannelstateconfigurationid":"e2737c9a-5778-e911-8196-000d3af7d71e",
         "createdon":"2019-10-01T13:41:51Z",
         "_createdby_value":"d6e088ce-8866-4b3d-8ea2-150ad72e2b79",
         "_modifiedonbehalfby_value":null,
         "importsequencenumber":null,
         "overriddencreatedon":null,
         "_createdonbehalfby_value":null,
         "utcconversiontimezonecode":null,
         "timezoneruleversionnumber":null
      },

   ]
}
```

The `msdyn_name` attribute in the `msdyn_occhannelstateconfiguration` entity mentions the channel and state of the conversation. For more information about conversation states, see [Understand conversation states in Omnichannel for Customer Service](oc-conversation-state.md).

You can make a `GET` request to `msdyn_occhannelconfiguration` entity to fetch all the existing channel records. For each of these channels, you can see its state when you query the `msdyn_occhannelstateconfiguration` entity.

Make a `PATCH` request to the `msdyn_occhannelstateconfiguration` entity record and update the value of the `msdyn_autocloseliveworkitemafter` attribute.

> [!NOTE]
> The value for the `msdyn_autocloseliveworkitemafter` attribute is in minutes. If you want to provide a value that is in days, you will have to convert it into minutes. For example, 1 day will be 24 x 60 = 1,440 minutes.

```http
PATCH [Organization URI]/api/data/v9.1/msdyn_occhannelstateconfigurations(6283ab63-5778-e911-8196-000d3af7d71e)
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0
If-None-Match: null

{
    "msdyn_autocloseliveworkitemafter":5
}
```
The conversation auto-closes if the value of the `msdyn_autocloseliveworkitemafter` attribute is greater than the value of the `createdon` attribute.

In case the conversation is in wrap-up state—that is, if the agent has resolved the issue and can now perform some post-conversation steps to close the conversation—then the conversation is closed if the value of the `msdyn_autocloseliveworkitemafter` attribute is greater than the value of the `wrapupinitiatedon` attribute.

> [!IMPORTANT]
> The decision on whether to close a conversation based on the values of the `msdyn_autocloseliveworkitemafter` and `createdon` attributes is made when a scheduled job executes and not at the time when the `PATCH` Web API request executes. That means if the value of `msdyn_autocloseliveworkitemafter` is mentioned as 5 minutes but the scheduled job executes after 24 hours, then the conversation will close after the scheduled job executes. That is, after 24 hours.

### See also

[Automatic closure of a conversation](oc-conversation-state.md#automatic-closure-of-a-conversation)  
[Update an entity using Web API](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]