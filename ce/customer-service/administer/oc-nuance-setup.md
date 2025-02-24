---
title: Integrate Nuance Cloud IVR bot with voice channel in Customer Service
description: How to set up Nuance Cloud IVR bot integration with voice channel
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection:  
ms.date: 01/28/2025
ms.custom: bap-template 
---

# Integrate Nuance Cloud IVR bot with voice channel in Customer Service

Integrate the Nuance Cloud IVR bot with the voice channel using Azure Communication Services.

## Prerequisites

- You must obtain an active subscription of **Dynamics 365 Customer Service Voice Channel Add-in** or **Dynamics 365 Customer Service Digital Messaging and Voice Add-in**. For more information about licenses and pricing, see the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). You can also purchase add-ins on the [Microsoft 365 admin center](https://go.microsoft.com/fwlink/?LinkId=866544). More information: [Buy add-ons](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide&preserve-view=true).
- Nuance Professional Services must perform the steps in [Verify the domain ownership](/azure/communication-services/how-tos/telephony/domain-validation#verify-domain-ownership) to confirm that the domain name is valid before connecting a Session Border Controller to Azure Communication Services. The Azure portal generates a value for the TXT record. Authorize the domain for the validation to succeed.<br>

If you haven't added a domain, follow the steps in [Add a new domain name](/azure/communication-services/how-tos/telephony/domain-validation#add-new-domain-name). Enter staging.ivr.nuance.com or nuance.com as the domain.

## Connect Azure Communication Services to voice channel

Azure Communication Services allows you to obtain phone numbers for customers to reach your business. Follow the steps in [Azure resource to provision phone numbers](voice-channel-acs-resource.md) to provision a new phone number. You can also [import phone numbers](voice-channel-sync-from-acs.md) or [connect your existing telephony infrastructure with Azure](voice-channel-bring-your-own-number.md). If you already have voice channel configured, you can skip this step.

## Connect Azure Communication Services to Nuance Cloud IVR bot

Use the information in this section to set up the Nuance Cloud IVR bot as the deflection bot. Typically, Nuance Professional Services performs these steps.

### Create Azure Communication Services resource

Create an Azure Communication Services resource. See: [Quickstart: Create and manage Communication Services resources](/azure/communication-services/quickstarts/create-communication-resource#create-azure-communication-services-resource).

### Obtain a phone number

Provision a phone number. See: [Get and manage phone numbers](/azure/communication-services/quickstarts/telephony/get-phone-number)

### Enable Direct Routing

Direct Routing lets you to connect to the existing Nuance telephony infrastructure. Perform the steps in the section below to connect a supported Nuance Session Border Controller (SBC) to Azure Communication Services to enable Direct Routing.

### Configure a Session Border Controller

1. Specify the **Fully Qualified Domain Name** of the SBC to be configured in Direct Routing. Follow the steps in [Adding a Session Border controller](/azure/communication-services/quickstarts/telephony/voice-routing-sdk-config#adding-a-session-border-controller) to ensure that messages are exchanged between Azure Communication Services and the configured SBC.
1. Configure outbound voice routing rules for Azure Communication Services direct routing. Follow the steps in [Creating Voice Routing rules](/azure/communication-services/quickstarts/telephony/voice-routing-sdk-config?pivots=platform-azp#creating-voice-routing-rules) to set up the voice routing rules.
1. Create an Azure Function to redirect the call from Azure Communication Services to the SBC with the following environment variables:
   - `redirectNumber`: Number that you want your incoming calls to be redirected to.
   -  Azure Communication Services string for the dialed number.
   - `dialedNumber`: Outbound number that your incoming calls are routed to.
1. Navigate to your Azure Communication Services number and integrate the Event Grid event type, `Microsoft.Communication.IncomingCall`, with your Azure function. You can perform one of the following actions:
   - Through the Azure portal:
      - Select **Event** and then select **Create Event Subscription**.
      - Specify the following information on the Create Event Subscription page:
         - Name
         - Event Schema: Event Grid Schema
         - Filter to Event Types: **Incoming Call (Preview)**
         - Endpoint Type: Azure Function and then specify the function you've created.
   - Run the following armclient command at the prompt:

      `armclient put "/subscriptions/[your_azure_subscription_guid]/resourceGroups/[your_resource_group_name]/providers/Microsoft.Communication /CommunicationServices/[your_acs_resource_name]/providers/Microsoft.EventGrid/eventSubscriptions/[subscription_name]?api-version=2022-06-15" "{'properties': {'destination': {'endpointType': 'AzureFunction','properties': {'maxEventsPerBatch': '1','preferredBatchSizeInKilobytes': '64','resourceId': ' /subscriptions/ [your_azure_function_subscription_guid] /resourceGroups/[Your Azure Function RG Name]/providers/Microsoft.Web/sites/[Your AzureFunction name in Portal]/functions/[Your AzureFunction Name in your C# code]'}},'filter': {'includedEventTypes': ['Microsoft.Communication. IncomingCall']}}}" -verbose `


### Deploy the bot

Configure  the session.xml with dynamic parameters such as **dataverse_organization_url**, **dataverse_tenant_id**, **dataverse_client_id**, **dataverse_client_secret_name**, and **dataverse_azure_key_vault_url** in Nuance IVR tools. The Nuance Cloud IVR bot is then deployed.

## Set up voice channel to receive escalated calls from Nuance Cloud IVR bot

When the bot escalates a call, a record is created in the **msdyn_ocexternalcontext** table. The SIP UUI header includes the msdyn_ocexternalcontext recordID. This recordID is transferred to the Azure resource that's connected with Omnichannel for Customer Service.

The voice channel in Customer Service receives the call and the system creates a new msdyn_ocliveworkitem record. The system links the msdyn_ocexternalcontext and msdyn_ocliveworkitem tables if it finds the msdyn_ocexternalcontext recordID in the SIP UUI header.

The Omnichannel administrator must perform the actions in the following sections to route the call to the appropriate agent and display the bot conversation transcript on the **Active Conversation** form.

### Set up routing rules and configure rulesets

Create a new work classification rule to classify the incoming call, match the call intent to the agents' skills, and route it to the appropriate queue and agent.

1. In Customer Service admin center, select a workstream,  and follow the steps to [Configure work classification rulesets](configure-work-classification.md)
1. In the **Conditions** area, select **Add related entity** and then select **External Context** from the **Many to One group**, and then select **Contains Data**. Specify the call intent.
1. Configure a new rule set for Route to Queues, creating a queue for that skill. More information: [Configure route-to-queue rules](configure-route-to-queue-rules.md).

### Customize Active Conversation form to view transcripts

Customize the conversation form for agents to view the transcripts from Nuance Cloud IVR bot on the Active Conversation form in Customer Service workspace.

 1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution
 1. Select **Tables**, select the **Conversation** table, and then select the **Forms** area.
 1. Select the required form. 
 1. On the left navigation pane, select **Components**.
 1. Select **CC_Transcript_Control** in the list of available components. This component is available out-of-the-box.
 1. Specify the required **TableName** and **TableColumn** in **CC_IsExternalContext**.
 1. Save and publish the form.  The form on the application UI displays the transcript from the IVR.
 

You can use a web resource to disable the transcript from being displayed if a transcript of the bot conversation isn't available. More information: [Create a JavaScript web resource](/power-apps/maker/model-driven-apps/configure-event-handlers-legacy#create-a-javascript-web-resource).

Use the following sample code to disable the transcript from being displayed:

   ```
       export class FormWebResource {
       public static async onFormLoad(context: XrmClientApi.EventContext): Promise<void> {
       var formContext = context.getFormContext();
       formContext.tabs.get("<Your form tab name>").sections.get("<Your section name>").setVisible(false);
      }
     }

   ```

## Define field requirements for call intent

Nuance Professional Services can extend the [External context (msdyn_ocexternalcontext) table](../../developer/reference/entities/msdyn_ocexternalcontext.md) to include additional customer metadata that is added to the context of the Nuance IVR application. They must modify the payload file to include the newly added fields.
    
See [Create and edit columns in Dataverse](/power-apps/maker/data-platform/create-edit-field-portal) to extend the table.

## View IVR transcripts

When an agent accepts a call that's been transferred from the Nuance Cloud IVR bot, the [Customer Summary](../use/oc-customer-summary.md) page displays the complete information about the customer, along with the conversation transcript of the steps taken by the IVR to resolve the customer issue. 

The app displays an error message if there's no data or  partial customer data.
