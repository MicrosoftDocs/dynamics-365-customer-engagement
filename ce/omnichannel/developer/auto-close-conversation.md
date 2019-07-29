---
title: "Automatic closure of a conversation| Microsoft Docs"
description: "Read how you can auto-close a conversation using the Web API"
keywords: ""
ms.date: 07/29/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: B8D5BCA8-DCF1-4DD9-A430-A569EC464E07
author: susikka
ms.author: susikka
manager: shujoshi
---
# Preview: Automatic closure of a conversation

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

This topic demonstrates how you can auto-close a conversation using Web API. 

Use the `GET` request given below to fetch all the configuration records that have been defined out-of-the-box.

```http
GET [Organization URI]/api/data/v9.1/msdyn_occhannelstateconfigurations
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0
If-None-Match: null
```

Make a `PATCH` request to the `msdyn_occhannelstateconfiguration` entity record and update the value of `msdyn_autocloseliveworkitemafter` attribute. The value for `msdyn_autocloseliveworkitemafter` attribute is in minutes.

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
The conversation auto-closes if the value of `msdyn_autocloseliveworkitemafter` attribute is greater than the value of `createdon` attribute.

In case the conversation is in wrap-up state, that is, if the agent has resolved the issue and can now perform some post conversation steps to close the conversation then the conversation is closed if the value of `msdyn_autocloseliveworkitemafter` attribute is greater than the value of `wrapupinitiatedon` attribute.

### See also

[Agent Guide: Automatic closure of a conversation](../agent/agent-oc/oc-conversation-state.md#bkmk_autoclose)<br />
[Update an entity using Web API](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)