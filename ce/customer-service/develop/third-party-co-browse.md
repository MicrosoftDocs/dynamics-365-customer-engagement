---
title: Enable third-party cobrowse and screen sharing
description: Learn how to enable third-party cobrowse and screen sharing escalation channels in Omnichannel for Customer Service.
ms.date: 02/29/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# Enable third-party cobrowse and screen sharing

Cobrowse and screen sharing are escalation channels in the Chat channel of Microsoft Dynamics 365. A cobrowse or screen sharing escalation channel allows your organization’s agents to start a cobrowse or screen sharing session with customers. With cobrowse, agents can see and interact with a customer’s web browser. With screen sharing, agents can see and interact with the customer’s current screen. Customers get an extra option to connect to an agent who can efficiently troubleshoot issues in real time.

Cobrowse and screen sharing can be enabled in the chat channel by integrating with third-party solutions. Extensibility is provided to enable any providers to onboard their cobrowse and screen sharing solution to Omnichannel for Customer Service.

> [!NOTE]
> Third-party co-browse and screen sharing features are not available in Unified Service Desk.

## Prerequisites

- An active digital messaging or chat subscription. 
- Updated Omnichannel base and Omnichannel chat solution with third-party cobrowse externalities enabled.

## Third-party cobrowse and screen sharing extensibility framework<a name="third-party-cobrowse"> </a>

To enable third-party cobrowse and screen sharing, the Omnichannel for Customer Service application provides an extensibility system to support this feature. In this system, a few entities are available in the Omnichannel for Customer Service solution that the screen share providers can use. The following graph explains the basic entity relationships that support the third-party cobrowse and screen sharing feature.

> [!div class="mx-imgBorder"]
> ![Entity relationships for co-browse feature.](../media/co-browse-entity-relationship.PNG "Entity relationships for co-browse feature")

Not all the fields need to be filled in for third-party cobrowse and screen share providers. For version 1.0, independent software vendors are supported to bring their cobrowse and screen sharing feature into Omnichannel for Customer Service by enabling a button in the agent’s chat widget.  When a user selects this button, it opens an app tab within Omnichannel for Customer Service with the independent software vendor's application website. To enable this button, ISVs need to bring the required data with their cobrowse and screen sharing solutions.

The following section lists the required entity data needed to support this feature. 

- **Conversation Actions entity (msdyn_conversationaction)** 

  The action that can be performed in the conversation.  
  
  **Fields**:  
  - Name: An identifier name for your button.
  - Event Name (Option set: Open App Tab Template, Send message, Customer Defined function. For third-party co-browse/screen sharing feature, input **Open App Tab Template**.) 
  - Event Parameter (For the third-party co-browse/screen sharing button, put the App Tab Template name here.) 
  - Order (Used to determine the positions for conversation actions. Admin can edit. Smallest number comes first.) 
  - Icon (A web resource URL that links to the button icon.) 

  **Fields classification and usage**:
  - This is the entity to store the action button metadata that is visible on the conversation control.  
  - Localized fields from relationships to Locale entity (label, tooltip, slash command) are a subgrid in this conversation action form.  
  - Label, Order, Tooltip, Icon are used for rendering the button in the UI. Slash commands are used by agents to trigger conversation actions by typing the slash command in the chat box.   
  - Event Name, Web Resource, Event Parameter, and Function Name are used for handling the onButtonClick action.  

- **Conversation Action Locale entity (msdyn_conversationactionlocale)**  

  Localization information associated with the conversation action.  

  **Fields**:  
  - Label (The label of the button showing to users in conversation control.) 
  - Tooltip (Tooltip for that button.) 
  - Locale (Language key for that button.) 
  - Conversation Action (FK to conversation action entity.)  

- **Provider entity (msdyn_provider)** 

  A list of third-party providers that bring capabilities into the application.  
  
  **Fields**: Name (ISV name)

- **Channel Capability entity (msdyn_channelcapability)** 
  
  The capability that a channel can enable, such as cobrowse and screen sharing.  

  **Fields**:  
  - Name (provider_channelcapability relationship name)  
  - Escalation Channel Mode (Cobrowse, Screen Sharing, Audio, Video, or None. For third-party cobrowse and screen sharing providers, use "Cobrowse" or "Screen Sharing".) 
  - Provider (Foreign Key to Provider entity)  
  - Conversation Actions (A lookup field for conversation actions.) If no button is created for a certain capability, then it can be empty. For the third-party cobrowse and screen sharing feature, link the channel capability to a conversation action record.  

 **Fields classification and usage**
 
 The Escalation Channel Mode attribute tells what this button can do. For example, cobrowse, audio, video. When users select a certain Escalation Channel Mode for a conversation action—for example, “cobrowse”—Omnichannel for Customer Service handles this cobrowse event and trigger a list of internal events like "create new session for secondary channel," "send system messages," and "update presence," which should be implemented in the Omnichannel for Customer Service code base.   

One provider can bring several channel capabilities, but for one Conversation Action and one Provider, the capability should be unique. This is handled by using the Channel Capability entity, as shown in the following schema.

| Channel Capability | Provider | Escalation Channel Mode | Conversation Action |
|--------|--------|--------|--------| 
|`ISV_screensharing`  |`ISV` |Screen sharing | CA1 | 
| `ISV_cobrowse` | `ISV` | Cobrowse | CA2 |

  
## UI rendering for the third-party cobrowse and screen sharing button 

Label, Order, Tooltip, and Icon are used for rendering a button in the UI. Users also can provide a slash command key for their button, but the slash command needs to be unique in the system.  Users need to input this data when bringing in their button.   

| Name | Label | Order |  Tooltip |  Slash command | Icon |
|----|----|----|----|----|----|
|`ISVCobrowse`  |`ISV Co-browse` | 0  | `Start a Cobrowse session provided by ISV` | /cb | /webresource/…/…svg  |

## Event handlers for third-party cobrowse and screen sharing

For third-party cobrowse, independent software vendors need to input the conversation action data for triggering the Open App Tab Template event.  The Event Names are option sets. It can be a predefined omnichannel event that can be used for most cases, like Open App Tab Template or Send message.  In a third-party cobrowse case, it uses the Open App Tab Template as Event Name and the Event Parameter can be the App Tab Template name. There aren't Web Resources data for this event because the App Tab Template framework handles the web resource.  

| Name | Event Name | Event Parameter | Capability |   
| -----| -----| -----| ----- |
| ISVCobrowse | Open App Tab Template  | ISVAppTabTemplate  | Cobrowse  |

## App Tab Template for third-party co-browse and screen sharing<a name="app-tab-template"> </a> 

We encourage our integrated third-party cobrowse providers to make their cobrowse and screen sharing applications inside of an Omnichannel for Customer Service tab. When the agent selects the **Co-browse** button in the chat widget, it opens this tab. Inside of this tab, the agent can start and end the cobrowse sessions and share the session invitations with customers. You can include the data in this form inside of your solution. Follow these steps to create the App Tab Template:

1. Perform the steps in [Manage application tab templates](../administer/application-tab-templates.md#manage-application-tab-templates) to create a web resource.
   
1. In the Application type field, select `**webresource**`.

1. In the Parameters section, add the web resource URL and query parameters that are required for ISVs to open their web resources. 

    `webresourcename`: `<URL path to the web resource>`

A single URL parameter called `data` contains a JSON object. This object when decoded and parsed contains the `conversationId` field. This ID can be used to attach any data back to a conversation.

## Create the third-party cobrowse and screen sharing solution with the required data 

Independent software vendors should bring in all the required data as specified in the [Third-party cobrowse extensibility framework](#third-party-cobrowse) section and the [App Tab Template for third-party cobrowse](#app-tab-template) section to make this framework work. 

The data input requirements for third-party providers are as follows:  

- App Tab Template record.  

- Conversation Action record. (If you have both cobrowse and screen sharing options, you can create two records, one for each.)  

- Conversation Action Locale record. (For each conversation action you created, you should have at least one Conversation Action Locale record. The basic language we support is English.) 

- Provider record.  

- Channel Capability record. (If you have both cobrowse and screen sharing options, you can create two records, one for each.) 

Include the records as part of the solution you create as a third-party provider so that the end user doesn't need to create them manually.

## Administrator experience for third-party cobrowse and screen sharing  

In the **Conversation Options** tab of the chat widget, in the **Remote assistance** section, the Omnichannel administrator can choose to enable or disable the third-party cobrowse and screen sharing options per chat widget. If there are no cobrowse and screen sharing providers installed in this organization, these two options are disabled as shown here.


> [!div class="mx-imgBorder"]
> ![Administrator experience for co-browse feature.](../media/co-browse-entity-relationship.PNG "Administrator experience for co-browse feature")

> [!div class="mx-imgBorder"]
> ![No screen-sharing sessions installed for co-browse feature.](../media/no-screensharing-session-co-browse.PNG "No screen-sharing sessions installed for co-browse feature")

> [!NOTE]
> The cobrowse provider and screen sharing provider are controlled separately.  You can install a cobrowse provider by creating a cobrowse channel capability record with required provider and conversation action data, the same as the screen sharing provider.

When the organization is provisioned with both options&mdash;that is, when it has two different channel capabilities installed&mdash;the admin can choose which third-party cobrowse provider to use. Also, it’s the admin’s choice whether to disable or enable these options. Here's the screenshot for admin enabled both options and selected both providers. 

> [!div class="mx-imgBorder"]
> ![Remote assistance for cobrowse feature.](../media/remote-assistance-co-browse.PNG "Remote assistance for cobrowse feature")


## Cobrowse and screen sharing button rendering in the agent chat widget 

When a cobrowse and screen sharing button is defined, it is rendered at the top of the conversation control as shown here.



> [!div class="mx-imgBorder"]
> ![Screen-sharing button rendering in chat widget.](../media/chat-widget-co-browse.PNG "Screen-sharing button rendering in chat widget")

## Omnichannel session services and data flow for third-party cobrowse and screen sharing


When an agent selects the button for cobrowse or screen sharing, it triggers the application tab inside of the Omnichannel service. Omnichannel for Customer Service handles the events as escalation channels event type. Omnichannel for Customer Service internal services updates the status for current session events.  

After the third-party applications take over, all data is handled by a third-party application server. See the following graph for the integration data flow.


> [!div class="mx-imgBorder"]
> ![Data flow for cobrowse.](../media/data-flow-co-browse.PNG "Data flow for cobrowse")

Some important events, such as starting or ending session events, should be reported to the Omnichannel service, so the overall service knows the status of the current agent. We provide third-party providers with this framework. It's the third-party providers’ responsibility to implement it in their codebase. The next section provides details on how to implement it. 

## Events expected from the third-party application 

The third-party application is expected to send events notifying Omnichannel for Customer Service of different milestones in the cobrowse and screen sharing session. Currently, these events are as follows: 

- CobrowseConnectedEvent (on connection of the cobrowse session) 
- CobrowseEndedEvent (on end of the cobrowse session) 
- ScreenShareConnectedEvent (on connection of the screen sharing session) 
- ScreenShareEndedEvent (on end of the screen sharing session) 

The events must be dispatched within the third-party web resource to the `window.top` element.

 ```javascript
  function triggerCobrowseStart() {
    if(document.createEvent) {
      let params = {};

      let evt = new CustomEvent('CobrowseConnectedEvent', {detail: params});
      window.top.dispatchEvent(evt);
    }
  }

 ```

 The `CobrowseEndedEvent` and `ScreenShareEndedEvent` should be added to the `onbeforeunload` property of the web resource so that the session is ended if the agent closes out of the tab within Omnichannel for Customer Service.

```html
<script>
function triggerCobrowseStop() {
  if(document.createEvent){

    let params = {};

    let evt= new CustomEvent('CobrowseEndedEvent', {detail:params});
    window.top.dispatchEvent(evt);
  }
}

</script>
</head>
<body onbeforeunload="return triggerCobrowseStop()">
</body>
```

## Provisioning and deprovisioning requirements 

To provision the third-party cobrowse and screen sharing solution for our customers, ISVs should provide a solution with the required data. When customers install the solution, minimal or no manual steps are required of them to enable the cobrowse and screen sharing feature. We require ISVs to be responsible for the data they created and to follow our guidance as required.  

To deprovision the third-party cobrowse and screen sharing solution for our customers, ISVs should remove the solution along with the data created with this framework. There shouldn’t be any existing legacy data or code remaining in that org after deprovisioning.   

## Publishing strategy

The following are links for publishing the application to AppSource:

[AppSource onboarding](https://appsource.microsoft.com)

[Onboarding guide](/azure/marketplace/cloud-partner-portal/business-applications-isv-program) 


[Overview Guide PDF](https://aka.ms/bizappsisvprogram) 

[Agreement PDF](https://aka.ms/bizappsisvaddendum) 

[Policies PDF (Includes benefit table)](https://aka.ms/bizappsisvpolicies)

[Program page on partner.microsoft.com site with links to certificate info](https://aka.ms/bizappsisvweb)

[Customer/partner support](https://aka.ms/marketplacepublishersupport)
 
## Third-party providers responsibility and data disclaimer 

Make sure to publish the privacy policy link to AppSource for security and privacy protection of the personal information that would be processed, and provide a compliant approach to data protection. 


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
