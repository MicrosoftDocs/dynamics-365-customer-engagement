---
title: Setup Nuance cloud IVR bot integration with voice channel
description: How-to setup Nuance cloud IVR bot integration with voice channel
author: gandhamm
ms.author:gandham
ms.reviewer: neeranelli
ms.topic: how-to
ms.collection: get-started 
ms.date: 07/27/2023
ms.custom: bap-template 
---

# Setup Nuance cloud IVR bot integration with voice channel

Azure Communication Services lets you integrate the Nuance Cloud IVR bot with Omnichannel for Customer Service voice channel, and perform a contextual call transfer between them.

The integration has the following three steps:

- Connect Azure Communication Services to the voice channel.
- Provision an internal phone number to redirect customer's phone call to the Nuance IVR ports.
- Setup Omnichannel to receive the escalated calls from the Nuance IVR bot.

## Prerequisites

- Omnichannel for Customer Service with the voice channel is provisioned.
- Azure Communication Services must be configured on the Customer Service tenant.

## Connect Azure Communication Services to voice channel

Azure Communication Services allows you to provision phone numbers for customers to reach your business. Follow the steps in [Azure resource to provision phone numbers](voice-channel-acs-resource.md) to provision a new phone number. You can also [import phone numbers](voice-channel-sync-from-acs.md) or [connect your existing telephony infrastructure with Azure](voice-channel-bring-your-own-number.md).

## Connect Azure Communication Services to Nuance Cloud IVR bot

Perform the steps in the following section to acquire an Azure Communication Services number, configure Direct Routing, and set up the Azure Function to redirect the customer's call to Nuance Shared Session Border Controller.

### Step 1:Configure Azure Communication Services

Perform the steps in [Quickstart: Create and manage Communication Services resources](/azure/communication-services/quickstarts/create-communication-resource#create-azure-communication-services-resource) to create an Azure Communication Services resource.

### Step 2: Get an Azure Communication Services resource

Perform the steps in [Get and manage phone numbers](/azure/communication-services/quickstarts/telephony/get-phone-number) to get a phone number.

### Step 3: Configure Direct Routing

Azure Communication Services [direct routing](/communication-services/quickstarts/telephony/voice-routing-sdk-config) enables you to connect Nuance’s existing telephony infrastructure to Azure Communication Services.

The following steps list the high-level steps required for connecting a supported Session Border Controller (SBC) to direct routing.

- Before you configure the SBC, perform the following steps to verify that the domain name is valid:
   - If you haven't added a domain, follow the steps in [Add the new domain name](/azure/communication-services/how-tos/telephony/domain-validation#add-new-domain-name). Enter staging.ivr.nuance.com or nuance.com as the domain.
   - Perform the steps in [Verify the domain ownership](/azure/communication-services/how-tos/telephony/domain-validation#verify-domain-ownership). Azure portal generates a value for the TXT record. Share the value with Nuance Professional Services. Once the team authorizes the domain, the validation is successful. 
- Nuance provides the **Fully Qualified Domain Name** of the SBC to be configured in Direct Routing. Follow the steps in [Adding a Session Border controller](/azure/communication-services/quickstarts/telephony/voice-routing-sdk-config#adding-a-session-border-controller) to ensure that messages are exchanged between Azure Communication Services and the configured SBC. 
- Configure outbound voice routing rules for Azure Communication Services direct routing. Follow the steps in [Creating Voice Routing rules](/azure/communication-services/quickstarts/telephony/voice-routing-sdk-config?pivots=platform-azp#creating-voice-routing-rules) to setup the voice routing rules.

### Step 4: Setup an Azure function to redirect the call from Azure Communication Services to Nuance SBC

You must deploy the Azure function provided by Nuance in your Azure Communication Services tenant. Once you’ve deployed your Azure function, navigate to your Azure Communication Services number and configure `EventGrid Microsoft.Communication. IncomingCall` event to your Azure Function. You can use the armclient command below or configure it through the Azure CLI:

`armclient put "/subscriptions/[your_azure_subscription_guid]/resourceGroups/[your_resource_group_name]/providers/Microsoft.Communication /CommunicationServices/[your_acs_resource_name]/providers/Microsoft.EventGrid/eventSubscriptions/[subscription_name]?api-version=2022-06-15" "{'properties': {'destination': {'endpointType': 'AzureFunction','properties': {'maxEventsPerBatch': '1','preferredBatchSizeInKilobytes': '64','resourceId': ' /subscriptions/ [your_azure_function_subscription_guid] /resourceGroups/[Your Azure Function RG Name]/providers/Microsoft.Web/sites/[Your AzureFunction name in Portal]/functions/[Your AzureFunction Name in your C# code]'}},'filter': {'includedEventTypes': ['Microsoft.Communication. IncomingCall']}}}" -verbose `

### Step 5: Provide configurations for the IVR bot builder

Nuance Professional Services application team will configure session.xml with dynamic parameters such as **dataverse_organization_url**, **dataverse_tenant_id**, **dataverse_client_id**, **dataverse_client_secret_name**, and **dataverse_azure_key_vault_url** in Nuance IVR tools. 
You must provide these parameters to the professional services team.
Bot designers use Mix.dialog, a multichannel dialog design development tool, for creating conversational experiences.  For more information, see: [Nuance Mix](https://docs.nuance.com/mix/).
The bot is then deployed.

## Setup Omnichannel to receive the escalated calls from Nuance bot

For an agent to receive a call that’s been escalated from the Nuance IVR, you must perform the configurations in the following sections.

### Context variables in the workstream for SIP UUI

When the Mix IVR bot transfers the call to Azure Communication Services, a record is created in the **msdyn_ocexternalcontext** table. The record ID is included in the SIP UUI header and is transferred to the Azure resource the Omnichannel for Customer Service is connected to.

When the application receives the call, the application creates a new msdyn_ocliveworkitem record and checks the SIP UUI header for the msdyn_ocexternalcontext recordID. If the corresponding ID is found, the application links both the msdyn_ocexternalcontext and msdyn_ocliveworkitem tables.

### Set up routing rules and configure rulesets

To ensure that the call transferred from the IVR is routed to the best-suited queue and agent by matching the intent and context of the call with the agent’s capabilities, you must set up work classification rules in unified routing and associate them to the corresponding voice workstream.
Create a new work classification rule to classify the incoming conversation to match the skills to the call intent from the call transferred by the Nuance Cloud IVR bot.

Perform the following steps:

1. In Customer Service admin center, select a workstream,  and follow the steps to [Configure work classification rulesets](configure-work-classification.md)
2.	In the **Conditions** area, select **Add related entity** and then select **External Context** from the **Many to One group**, and then select **Contains Data**. Specify the call intent.
3. Configure a new rule set for Route to Queues, creating a queue for that skill. More information: [Configure route-to-queue rules](configure-route-to-queue-rules.md).

## View IVR transcripts

When an agent accepts a call that’s been transferred from the Nuance Cloud IVR bot, the [Customer Summary](oc-customer-summary.md) page displays the complete information about the customer, along with the conversation transcript of the steps taken by the IVR to resolve the customer issue. 

The app displays an error message if there’s no data or  partial customer data.


## Next steps

[Customize active conversation to view the IVR transcripts](oc-nuance-fos-customizations.md)
