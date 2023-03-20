---
title: "Configure channel providers for your Dynamics 365 organization | MicrosoftDocs"
description: "Use this topic to understand how to configure channel providers in Dynamics 365 Channel Integration Framework 1.0."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 10/21/2022
ms.topic: article
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


1. Sign in to Dynamics 365.

2. Search for and select **Channel Integration Framework**.

  ![Dynamics 365 dropdown button to find Channel Integration Framework.](media/cif-app-navigation.png "Dynamics 365 dropdown button to find Channel Integration Framework")

3.	Select **New** to add a new provider.

4.	In the **New Channel** page, specify the following:

  | Field | Description |
  |-------|-------|
  |Name|Name of the channel provider.|
  |Label|The label is displayed as the title on the widget.|
  |Channel URL|The URL of the provider to host in the widget. See the JavaScript APIs on how to develop communication widgets with Dynamics 365 Channel Integration Framework.|
  |Enable Outbound Communication|When a phone number is selected on the Dynamics 365 Unified Interface page, the widget initiates the call or outbound communication.|
  |Channel Order|The order of precedence of the channel providers.|
  |API Version|The version of the Channel Integration Framework APIs.|
  |Trusted Domain| An additional domain if the initial landing URL and the final domain from which the communication widget is hosted are different. Add the domain (URL) to access the Channel Integration Framework APIs. |
  |Select Unified Interface Apps for the Channel| The list of Unified Interface apps where the channel is displayed for the agents. |
  |Select the Roles for the Channel|The security roles that are present in Dynamics 365.<br>**Important:** <br> To ensure that the user is able to access the channel provider, you must assign the same security role that's defined at the channel provider level, to the user.|
  |Custom Parameter|This takes a text blob as input and `Microsoft.CIFramework.getEnvironment` will return this as value of key `customParams`.|
  
  ![Channel provider configuration.](media/channel-provider-configuration-v1.PNG "Channel provider configuration")

  > [!Note]
  > The msdyn_ciprovider entity is accessible only for the administrator roles and hence the panel won't load for non-administrator roles. To load the panel for non-administrator roles, create a new role and provide read access to the msdyn_ciprovider entity. Then, add the role to the users who'll be accessing Dynamics 365 Channel Integration Framework.

5. Launch the Unified Interface app to see the communication widget on the right side.<br><br>

**The communication widget in the minimized mode**<br><br>
![Communication widget in the minimized mode.](media/widget-minimized-mode.PNG "Communication widget in the minimized mode")
<br><br>

**The communication widget in the expanded mode**<br><br>
![Communication widget in the expanded mode.](media/widget-expanded-mode.PNG "Communication widget in the expanded mode")


### See also

[Enable outbound communication (ClickToAct)](enable-outbound-communication-clicktoact.md)  
[Microsoft.CIFramework.getEnvironment](reference/microsoft-ciframework/getEnvironment.md)  
[Configure single and multiple channel providers in Dynamics 365 Channel Integration Framework 2.0](v2/configure-channel-provider-app-profile-manager.md)  
[FAQ about Dynamics 365 Channel Integration Framework](faq-channel-integration-framework.md)  
[Bring your own channel](../bring-your-own-channel.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
