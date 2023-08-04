---
title: Setup Nuance cloud IVR bot integration with voice channel
description: How-to setup Nuance cloud IVR bot integration with voice channel
author: gandhamm
ms.author: ,gandham
ms.reviewer: neeranelli
ms.topic: how-to .
ms.collection: get-started 
ms.date: 07/27/2023
ms.custom: bap-template 
---

# Set up Nuance cloud IVR bot integration with voice channel

Azure Communication Services lets you integrate the Nuance Cloud IVR bot with Omnichannel for Customer Service voice channel, and perform a contextual call transfer between them.

The integration has the following three steps:

- Connect Azure Communication Services to the voice channel.
- Provision an internal phone number to redirect customer's phone call to the Nuance IVR ports.
- Setup Omnichannel to receive the escalated calls from the Nuance IVR bot.

## Prerequisites

You must obtain an active subscription of **Dynamics 365 Customer Service Voice Channel Add-in** or **Dynamics 365 Customer Service Digital Messaging and Voice Add-in**. For more information about licenses and pricing, see the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). You can also purchase add-ins on the [Microsoft 365 admin center](https://go.microsoft.com/fwlink/?LinkId=866544). More information: [Buy add-ons](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide&preserve-view=true)


## Connect Azure Communication Services to voice channel

Azure Communication Services allows you to provision phone numbers for customers to reach your business. Follow the steps in [Azure resource to provision phone numbers](voice-channel-acs-resource.md) to provision a new phone number. You can also [import phone numbers](voice-channel-sync-from-acs.md) or [connect your existing telephony infrastructure with Azure](voice-channel-bring-your-own-number.md). If you already have voice channel configured, you can skip this step.

## Connect Azure Communication Services to Nuance Cloud IVR bot

The steps in the following section are to configure the telephony layer so the customer's call is routed from the Azure Communication Services to the Nuance IVR bot. The configuration steps are done by Nuance Professional Services.

1. Create an Azure Communication Services resource. See: [Quickstart: Create and manage Communication Services resources](/azure/communication-services/quickstarts/create-communication-resource#create-azure-communication-services-resource).
1. Get a phone number. See: [Get and manage phone numbers](/azure/communication-services/quickstarts/telephony/get-phone-number).
1. Direct routing enables you to connect Nuance’s existing telephony infrastructure to Azure Communication Services. The following steps list the high-level steps required for connecting a supported Nuance Session Border Controller (SBC) to Azure Communication Services to enable direct routing.
  -  Before you configure the SBC, perform the following steps to verify that the domain name is valid:
     - If you haven't added a domain, follow the steps in [Add the new domain name](/azure/communication-services/how-tos/telephony/domain-validation#add-new-domain-name). Enter staging.ivr.nuance.com or nuance.com as the domain.
     - Perform the steps in [Verify the domain ownership](/azure/communication-services/how-tos/telephony/domain-validation#verify-domain-ownership). Azure portal generates a value for the TXT record. Authorize the domain for the validation to succeed.
  - Specify the **Fully Qualified Domain Name** of the SBC to be configured in Direct Routing. Follow the steps in [Adding a Session Border controller](/azure/communication-services/quickstarts/telephony/voice-routing-sdk-config#adding-a-session-border-controller) to ensure that messages are exchanged between Azure Communication Services and the configured SBC. 
  - Configure outbound voice routing rules for Azure Communication Services direct routing. Follow the steps in [Creating Voice Routing rules](/azure/communication-services/quickstarts/telephony/voice-routing-sdk-config?pivots=platform-azp#creating-voice-routing-rules) to setup the voice routing rules.
1. Create an Azure Function to redirect the call from Azure Communication Services to the SBC in your Azure Communication Services tenant with the following environment variables:
   - `redirectNumber`: number that you want your incoming calls to be redirected to
   - `dialedNumberConnectionString`: Azure Communication Services connection string for the dialed number
   - `dialedNumber`: outbound number that your incoming calls will be routed to
1. Navigate to your Azure Communication Services number and integrate the Event Grid event type, `Microsoft.Communication. IncomingCall`, to your Azure function. You can perform one of the following steps:
   - Run the armclient command below:

      `armclient put "/subscriptions/[your_azure_subscription_guid]/resourceGroups/[your_resource_group_name]/providers/Microsoft.Communication /CommunicationServices/[your_acs_resource_name]/providers/Microsoft.EventGrid/eventSubscriptions/[subscription_name]?api-version=2022-06-15" "{'properties': {'destination': {'endpointType': 'AzureFunction','properties': {'maxEventsPerBatch': '1','preferredBatchSizeInKilobytes': '64','resourceId': ' /subscriptions/ [your_azure_function_subscription_guid] /resourceGroups/[Your Azure Function RG Name]/providers/Microsoft.Web/sites/[Your AzureFunction name in Portal]/functions/[Your AzureFunction Name in your C# code]'}},'filter': {'includedEventTypes': ['Microsoft.Communication. IncomingCall']}}}" -verbose `

   - Through the Azure portal:
      - Select **Event** and then select **Create Event Subscription**.
      - Specify the following on the Create Event Subscription page:
         - Name
         - Event Schema: Event Grid Schema
         - Filter to Event Types: **Incoming Call (Preview)**
         - Endpoint Type: Azure Function and then specify the Azure Function you've created.
             
1.  Configure  the session.xml with dynamic parameters such as **dataverse_organization_url**, **dataverse_tenant_id**, **dataverse_client_id**, **dataverse_client_secret_name**, and **dataverse_azure_key_vault_url** in Nuance IVR tools. The bot is then deployed.

## Setup Omnichannel to receive the escalated calls from Nuance bot

If the Mix IVR bot transfers the call to Azure Communication Services, a record is created in the **msdyn_ocexternalcontext** table. The record ID is included in the SIP UUI header and is transferred to the Azure resource the Omnichannel for Customer Service is connected to.

When the application receives the call, the application creates a new msdyn_ocliveworkitem record and checks the SIP UUI header for the msdyn_ocexternalcontext recordID. If the corresponding ID is found, the application links both the msdyn_ocexternalcontext and msdyn_ocliveworkitem tables.

The steps below ensure that the escalated call is routed to the appropriate agent and the the transcript is displayed on the agent's Active Conversation form in Omnichannel:

1. **Set up routing rules and configure rulesets**

  Perform the following steps to create a new work classification rule to classify the incoming conversation to match the skills of an agent to the call intent from the escalated bot and then route it to the best-suited queue and agent :

   1. In Customer Service admin center, select a workstream,  and follow the steps to [Configure work classification rulesets](configure-work-classification.md)
   2.	In the **Conditions** area, select **Add related entity** and then select **External Context** from the **Many to One group**, and then select **Contains Data**. Specify the call intent.
   3. Configure a new rule set for Route to Queues, creating a queue for that skill. More information: [Configure route-to-queue rules](configure-route-to-queue-rules).

2. **Customize Active Conversation form to view Nuance IVR bot transcripts**

   You'll need to customize the conversation form for agents to view the transcripts from Nuance IVR on the Active Conversation form in Customer Service workspace. Perform the following steps to add **CC_Transcript_Control** to the form:

   1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
   2.	Select **Tables**, select the **Conversation** table, and then select the **Forms** area.
   3.	Select the required form. 
   4.	On the left navigation pane, select **Components**.
   5.	Select **CC_Transcript_Control** in the list of available components. This component is available out-of-the-box.
   6.	Specify the required **TableName** and **TableColumn** in **CC_IsExternalContext**.
   7.	Save and publish the form.  The form on the application UI displays the transcript from the IVR.

  When there’s no transcript available, you can choose to disable the transcript using a web resource.More information: [Create a JavaScript web resource](/power-apps/maker/model-driven-apps/configure-event-handlers-legacy#create-a-javascript-web-resource).

  Here’s the sample code to disable the transcript coming from the Mix IVR bot:

    ```
      export class FormWebResource {
      public static async onFormLoad(context: XrmClientApi.EventContext): Promise<void> {
        var formContext = context.getFormContext();
        formContext.tabs.get("<Your form tab name>").sections.get("<Your section name>").setVisible(false);
     }
    }
    ```

3. **Define field requirements for call intent**

    Nuance Professional Services can extend the **msdyn_ocexternalcontext** to include additional customer metadata that is added to the context of the Nuance IVR application. They must modify the payload file to include the newly added fields. For more information on the msdyn_ocexternalcontext entity, see: msdyn_ocexternalcontext
   Perform the steps in [Create and edit columns in Dataverse](/power-apps/maker/data-platform/create-edit-field-portal) to extend the table.

## View IVR transcripts

When an agent accepts a call that’s been transferred from the Nuance Cloud IVR bot, the [Customer Summary](oc-customer-summary.md) page displays the complete information about the customer, along with the conversation transcript of the steps taken by the IVR to resolve the customer issue. 

The app displays an error message if there’s no data or  partial customer data.

