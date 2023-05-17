---
title: "FAQ about Dynamics 365 Channel Integration Framework | MicrosoftDocs"
description: "Frequently asked questions about Dynamics 365 Channel Integration Framework and its APIs for Dynamics 365."
ms.date: 02/18/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# FAQ about Dynamics 365 Channel Integration Framework

This article contains the frequently asked questions about Dynamics 365 Channel Integration Framework versions 1.0 and 2.0.
## General FAQ

### What is Dynamics 365 Channel Integration Framework?

Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework to integrate third-party channel providers with Dynamics 365 Unified Interface apps using a browser-based JavaScript API library.

### Can I integrate a two-way communication channel?

Yes, you can integrate a two-way communication channel that enables you to set the context of inbound and outbound calling according to your business and process workflows.

### Can I synchronize user presence across different providers?

User presence synchronization across providers is not supported.

### Does Dynamics 365 Channel Integration Framework work with Unified Interface apps?

Dynamics 365 Channel Integration Framework works only with Unified Interface apps. As of now, Dynamics 365 Channel Integration Framework does not support the legacy web client.

### Is Dynamics 365 Channel Integration Framework a softphone?

No, Dynamics 365 Channel Integration Framework provides an extensible framework to integrate a softphone with Dynamics 365.

### Does Dynamics 365 Channel Integration Framework make calls or send messages?

No, Dynamics 365 Channel Integration Framework provides an extensible framework to configure the channel provider to make and receive calls, or send and receive messages.

### Is Dynamics 365 Channel Integration Framework a server-side API?

No, Dynamics 365 Channel Integration Framework provides a JavaScript library that exposes APIs that you can use to perform the following operations:
- Create, retrieve, update, and delete entity records.
- Get and set ClickToAct functionality.
- Search among records of a particular entity type.
- Get and set the panel width, and so on.

More information: [Microsoft.CIFramework methods (Dynamics 365 Channel Integration Framework JavaScript API reference)](reference/microsoft-ciframework.md)

### Does Dynamics 365 Channel Integration Framework manage call or chat sessions?

No, Dynamics 365 Channel Integration Framework does not manage call or chat sessions.

### Is Dynamics 365 Channel Integration Framework dependent on operating systems and browsers?

No, Dynamics 365 Channel Integration Framework is agnostic to operating systems and web browsers; you can integrate cloud-based channels of your choice that are best suited for your organization's requirements.

### How can I get updated to Dynamics 365 Channel Integration Framework?

Microsoft is continuously developing and improving online services. Updates to the Dynamics 365 Channel Integration Framework 1.0 are pushed to all customers automatically. 

### Which web browsers does Dynamics 365 Channel Integration Framework support?

For information on supported browsers, see the following articles:

- [System requirements for Dynamics 365 Channel Integration Framework 1.0](system-requirements-channel-integration-framework.md)
- [System requirements for Dynamics 365 Channel Integration Framework 2.0](v2/system-requirements-channel-integration-framework-v2.md)

### Can partners package solutions that have a dependency on the Dynamics 365 Channel Integration Framework solution, together with the Dynamics 365 Channel Integration Framework solution?

No, the Dynamics 365 Channel Integration Framework solution should not be bundled with another solution. Partners can create solutions that add a check to their package looking for the Dynamics 365 Channel Integration Framework solution (also mentioning the minimum supported version), which causes the installation to fail in case the Dynamics 365 Channel Integration Framework solution is not present.

Also, you can add Configuration Experience to the acquired flow that'll allow the solution to detect the state of the target instance, and decide how to install. This will also let the solution perform any additional setup or license acquisition remotely, before installation.

## Dynamics 365 Channel Integration Framework 2.0

### What are the new changes to the Channel Integration Framework app?

Dynamics 365 Channel Integration Framework 2.0 includes multiple enhancements over Channel Integration Framework 1.0, particularly in its ability to integrate with the latest multisession agent experiences for customer service. To know more, see [Advantages and value propositions of Dynamics 365 Channel Integration Framework 2.0](overview-channel-integration-framework.md#advantages-and-value-propositions-of-dynamics-365-channel-integration-framework-10).

### My organization is using Channel Integration Framework 1.0. Does the new version impact my organization?

No. There is no impact on Channel Integration Framework 1.0 users. You can continue to use the Channel Integration Framework app to configure channel providers for single session Dynamics 365 model-driven app.

### Where do I configure voice channel provider for multisession apps?

You can configure voice channel providers in [Customer Service admin center and app profile manager](../../app-profile-manager/app-profile-manager.md).

### My organization is using voice channel configured using Channel Integration Framework 2.0. Does the change impact my organization?

Yes. From your channel provider record, you'll not be able to see the following two grids:

- Select the Unified Interface Apps for the Channel
- Select the Roles for the Channel
	
### How do I choose the Unified Interface apps for the voice channel provider record?

You don't need to choose the Unified Interface apps. The telephony channel providers are associated with app profiles, which works in the context of the multisession apps such as Omnichannel for Customer Service and Customer Service workspace.
	
### How do I select roles for the voice channel provider record?

Telephony channel providers are associated with agent profiles, which in turn are assigned to users in your organization. You must assign the agent profiles to users who need access to the telephony channel provider. More information: [Assign users, templates, configure productivity pane, channels](../../app-profile-manager/app-profile-manager.md#assign-templates-and-enable-productivity-pane-and-channels)

### Will my existing communication widget, built using Dynamics 365 Channel Integration Framework 1.0 APIs, continue to work with the Dynamics 365 Channel Integration Framework 2.0 app?

Yes. You can use your communication widget on the Dynamics 365 Channel Integration Framework 2.0, however, you'll need to configure the channel provider and update the channel URL in the Customer Service admin center app. More information: [Configure channel providers](v2/configure-channel-provider-app-profile-manager.md)

### How do I use the multisession experiences for my contact center with a third-party provider's communication widget?

Dynamics 365 Channel Integration Framework 2.0 works only with multisession apps such as Omnichannel for Customer Service and Customer Service workspace. You can integrate any third-party telephony provider with Omnichannel for Customer Service or Customer Service workspace using the Dynamics 365 Channel Integration Framework 2.0 APIs. 

For information on selecting versions, see [Choose between versions 1.0 and 2.0](choose-between-versions.md).

For information on license, see [Dynamics 365 Customer Service pricing overview](https://dynamics.microsoft.com/en-us/customer-service/overview/#pricing) and [Dynamics 365 Customer Service pricing plan](https://dynamics.microsoft.com/en-us/pricing/customer-service/#plans).

### My organization uses multiple channel providers. How can I start a default session? Also, why is the widget not visible in the home session?

If there are multiple channel providers in your organization, the widget won't be visible in the home session, as the home session isn't associated with any provider. Note that the [setMode](reference/microsoft-ciframework/setmode.md) API is not supported in the home page. So, in such a scenario, you must create a default session to show a dialer experience in the communication widget, conversation dashboards in the application tab, and so on. 

To create a default session, see [Start a home (default) session when your organization uses multiple channel providers](v2/support-multiple-providers.md#start-a-home-default-session-when-your-organization-uses-multiple-channel-providers).

### How can third-party telephony providers start their default session?

You can use the [Microsoft.CIFramework.setMode(1)](reference/microsoft-ciframework/setmode.md) method in your provider code to make the panel visible. More information: [Start a home (default) session when your organization uses a third-party telephony provider](v2/support-multiple-providers.md#start-a-home-default-session-when-your-organization-uses-a-single-channel-provider)

### Why is the user presence not loading or user is shown as unknown? 

User presence might not load in the following scenarios:
- The agent doesn't have the Omnichannel agent role privileges
- The agent capacity and default presence are not set
- The required channels aren't activated in the agent profile. 

More information: [User presence isn’t loading or user is shown as unknown](../troubleshoot-omnichannel-customer-service.md#user-presence-isnt-loading-or-user-is-shown-as-unknown)

### Why should I check or update channel URLs in Dynamics 365 Channel Integration Framework 2.0?

When you deploy or update the Customer Service workspace app profile, the Channel URL field in the Dynamics 365 Channel Integration Framework 2.0 settings for omnichannel gets overwritten. So after a deployment, the Channel Integration Framework product might point to a different URL. So, check and ensure that the Channel URL field in Dynamics 365 Channel Integration Framework 2.0 always points to the correct URL. More information: [Configure a third-party channel provider](v2/configure-channel-provider-app-profile-manager.md#configure-a-third-party-channel-provider)

### Why do tabs reload when an agent switches session tabs or switches from session tab to widget?

This is to make sure that the updated data is available for the agent at all times.

### Is it possible to integrate custom messaging channel providers?

Yes, you can integrate custom messaging channels using Direct Line bot. More information: [Integrate your own custom channel: Direct Line](../../customer-service/bring-your-own-channel.md)

### Is it possible to view the existing channel providers from Dynamics 365 Channel Integration Framework 2.0 model-driven app?

No. You can use the Customer Service admin center app or navigate to the app profile manager on the Power Apps portal to view your existing channel providers. More information: [Configure channel provider](v2/configure-channel-provider-app-profile-manager.md)


## Dynamics 365 Channel Integration Framework 1.0

### What happens when you select a role from under Select roles for the Channel?

When you select a particular security role for the channel provider from under the **Select roles for the Channel** dropdown list, the security role provides certain access rights to the channel provider. If no role is selected, the channel provider can only be accessed by System Administrators and Customizers.

> [!IMPORTANT]
> When you select a role in the **Select roles for the Channel** list, it does not filter out users with just the System Administrator role. The System Administrator and Customizer roles will always have access to the channel provider. When you assign a System Administrator role to a user, the other users who have been assigned the System Administrator role earlier will not lose access unless you explicitly revoke system administrator rights from a user.

### Can I load the Dynamics 365 Channel Integration Framework 1.0 communication widget in Omnichannel for Customer Service?

No, that is not supported.


### See also

[Overview of Dynamics 365 Channel Integration Framework](overview-channel-integration-framework.md)  
[What's new in Dynamics 365 Channel Integration Framework](whats-new-channel-integration-framework.md)  
[System requirements of Dynamics 365 Channel Integration Framework](system-requirements-channel-integration-framework.md)  
[Known issues in Dynamics 365 Channel Integration Framework](https://go.microsoft.com/fwlink/p/?linkid=2171869)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
