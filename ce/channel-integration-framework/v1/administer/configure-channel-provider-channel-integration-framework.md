---
title: Configure channel providers for your Dynamics 365 organization 
description: Use this article to understand how to configure channel providers in Dynamics 365 Channel Integration Framework 1.0.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 07/04/2025
ms.topic: how-to
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
searchScope: 
 - D365-App-msdyn_channelintegrationframeworkapp 
 - D365-Entity-msdyn_ciprovider
 - D365-UI-view
 - Dynamics 365 
 - Customer Service 
 - Customer Engagement
---

# Configure a channel provider for your Dynamics 365 organization

## Prerequisite

If you want to use the channel provider icon, do the following steps:

1. In the site map of Copilot Service admin center, go to **Miscellaneous** under **Operations**, and select **Manage** for **New and upcoming features**.

1. On the page that appears, select **Provider icon configuration**, and save.

## Configure a channel provider

1. On the apps page of Dynamics 365, select Channel Integration Framework.

1. On the **Active Channel Providers** page, select **New**.

1. In the **New Channel Integration Framework v1.0 Provider** page, enter the following information.

  | Field | Description |
  |-------|-------|
  |Name|Name of the channel provider.|
  |Label|The label is displayed as the title on the widget.|
  |Channel URL|The URL of the provider to host in the widget. See the JavaScript APIs on how to develop communication widgets with Dynamics 365 Channel Integration Framework.|
  |Enable Outbound Communication|When a phone number is selected on the Dynamics 365 Unified Interface page, the widget initiates the call or outbound communication.|
  |Channel Order|The order of precedence of the channel providers.|
  |Channel Provider Icon| Allows to select an icon for the channel provider. The icon appears on the right pane of the agent app at runtime.| 
  |API Version|The version of the Channel Integration Framework APIs.|
  |Trusted Domain| Another domain if the initial landing URL and the final domain from which the communication widget is hosted are different. Add the domain (URL) to access the Channel Integration Framework APIs. |
  |Select Unified Interface Apps for the Channel| The list of Unified Interface apps where the channel is displayed for the agents. |
  |Select the Roles for the Channel|The security roles that are present in Dynamics 365.<br>**IMPORTANT:** <br> To ensure that the user is able to access the channel provider, you must assign the same security role that's defined at the channel provider level, to the user.<br>**NOTE:** <br>  The channel supports individual role assignment only.|
  |Custom Parameters|This takes a text blob as input and `Microsoft.CIFramework.getEnvironment` returns this as value of key `customParams`.|
  |Sandbox Configuration| Channel URL loads as an iFrame web resource in the sandbox mode. Use this field to configure the list of sandbox attributes for the Channel URL. You can add multiple attributes separated by commas.|
  
:::image type="content" source="../../media/channel-provider-configuration-version-1.png" alt-text="Screenshot of channel provider configuration version one." lightbox="../../media/channel-provider-configuration-version-1.png":::  

  > [!NOTE]
  >
  > - The msdyn_ciprovider entity is accessible only for the administrator roles and therefore the panel doesn't load for non-administrator roles. To load the panel for non-administrator roles, create a new role and provide read access to the msdyn_ciprovider entity. Then, add the role to the users who are accessing Dynamics 365 Channel Integration Framework.
  > - Sandbox attributes such as allow-forms, allow-popups, allow-scripts, allow-same-origin, allow-modals, allow-downloads are configured by default.
  > - If you enable the provider icon, the pane supports the expanded and hidden mode only.

### Runtime behavior

Launch the Unified Interface app that you specified to see the communication widget of the channel provider on the right pane. The following screenshot shows the experience where the channel provider icon is enabled.

:::image type="content" source="../../media/channel-widget-v1.png" alt-text="Screenshot of the Channel widget at runtime in version 1." lightbox="../../media/channel-widget-v1.png":::

### Related information

[Enable outbound communication (ClickToAct)](enable-outbound-communication-clicktoact.md)  
[Microsoft.CIFramework.getEnvironment](../develop/reference/microsoft-ciframework/getEnvironment.md)  
[Configure single and multiple channel providers in Dynamics 365 Channel Integration Framework 2.0](../../v2/administer/configure-channel-provider-app-profile-manager.md)  
[FAQ about Dynamics 365 Channel Integration Framework](../../faq-channel-integration-framework.md)  
[Bring your own channel](../../../customer-service/develop/bring-your-own-channel.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
