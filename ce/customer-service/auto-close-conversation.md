---
title: Configure automatic closure of conversations
description: Use this article to understand how to configure the auto-close duration of conversations using the Web API.
ms.date: 02/22/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---
# Configure automatic closure of conversations

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article demonstrates how you can configure the auto-close duration of a conversation using the Web API.

> [!IMPORTANT]
> Duration-based automatic closure of conversations isn't supported for records that're configured for unified routing. When you delete a routed record, the associated queue item is deleted. The live work item or conversation will also be deleted as part of the clean-up process.


Use the following `GET` request to fetch all the configuration records that have been defined out of the box.

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

You can make a `GET` request to the `msdyn_occhannelconfiguration` entity to fetch all the existing channel records. For each of these channels, you can see its state when you query the `msdyn_occhannelstateconfiguration` entity.

Make a `PATCH` request to the `msdyn_occhannelstateconfiguration` entity record and update the value of the `msdyn_autocloseliveworkitemafter` attribute.

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

Here's a sample code for updating existing records in the `msdyn_occhannelstateconfigurations` entity:

```javascript
var data =
    {
        "msdyn_autocloseliveworkitemafter": 2
    }
// update the record
Xrm.WebApi.updateRecord("msdyn_occhannelstateconfiguration", "6283ab63-5778-e911-8196-000d3af7d71e", data).then(
    function success(result) {
        console.log("Auto close time updated");
    },
    function (error) {
        console.log(error.message);
    }
);
```

> [!NOTE]
> The value for the `msdyn_autocloseliveworkitemafter` attribute is in minutes. If you want to provide a value that is in days, you'll have to convert it into minutes. For example, 1 day will be 24 x 60 = 1,440 minutes.

The conversation closes automatically if the value of the `msdyn_autocloseliveworkitemafter` attribute is greater than the value of the `createdon` attribute.

If the conversation is in the wrap-up state&mdash;that is, the agent has resolved the issue and can now perform some post-conversation steps to close the conversation&mdash;then the conversation is closed if the value of the `msdyn_autocloseliveworkitemafter` attribute is greater than the value of the `wrapupinitiatedon` attribute.

> [!IMPORTANT]
> The decision to close a conversation based on the values of the `msdyn_autocloseliveworkitemafter` and `createdon` attributes is made when a scheduled job runs, and not when the `PATCH` Web API request is run.

## Configure automatic closure of Wrap-up state for live chat

The default time for automatically closing a live chat that's in **Wrap-up** state is 15 minutes. The value is defined in the `msdyn_autocloseliveworkitemafter` attribute and can be programmatically changed to suit your business needs.

The value defined for the **Block capacity for wrap-up** field in the workstream overrides the value specified in the `msdyn_autocloseliveworkitemafter` attribute, if it is more than the value for the `msdyn_autocloseliveworkitemafter` attribute. For example, if you have set the value for blocking agent's capacity as 15 minutes and the `msdyn_autocloseliveworkitemafter` attribute as 10 minutes, a conversation in **Wrap-up** state will occupy capacity for 15 minutes and will be eligible for automatic closure only after 15 minutes.

## Next steps

[Update an entity using Web API](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)  

### See also

[Automatic closure of a conversation](oc-conversation-state.md#automatically-close-conversations)  



[!INCLUDE[footer-include](../includes/footer-banner.md)]
