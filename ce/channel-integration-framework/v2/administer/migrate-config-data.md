---
title: Migrate third-party channel configuration data
description: Use this topic to learn how to migrate third-party channel configuration data from Dynamics 365 Channel Integration Framework 1.0 to Channel Integration Framework 2.0 in Customer Service workspace and Omnichannel for Customer Service.
ms.date: 04/29/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - admin
  - customizer
---

# Migrate third-party channel configuration data

This topic provides information about how you as an administrator can migrate third-party channel configuration data from Dynamics 365 Channel Integration Framework 1.0 to Channel Integration Framework 2.0 in both the Customer Service workspace and Omnichannel for Customer Service apps.

## Migrate channel configuration data in Customer Service workspace

Perform the following steps to migrate third-party channel configuration data from Channel Integration Framework 1.0 to 2.0 in Customer Service workspace.

1. Open the Power Apps portals admin center and select your environment. More information: [Open Power Apps portals admin center](/powerapps/maker/portals/admin/admin-overview#open-power-apps-portals-admin-center)

2. Open the agent experience profile in [Customer Service admin center](configure-channel-provider-app-profile-manager.md), configure a new channel provider, and copy the channel URL and other attribute values from the Channel Integration Framework 1.0 provider.

3. [Assign user to this profile](../../../customer-service/administer/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels).

4. In the channel provider code, make sure that the communication panel is set to the docked state using the [setMode(1)](../../v1/develop/reference/microsoft-ciframework/setMode.md) API.

5. Open Customer Service workspace and check if the communication panel is visible.

## Migrate channel configuration data in Omnichannel for Customer Service

Perform the following steps to migrate third-party channel configuration data from Channel Integration Framework 1.0 to 2.0 in Omnichannel for Customer Service.

1. Open the Power Apps portals admin center and select your environment. More information: [Open Power Apps portals admin center](/powerapps/maker/portals/admin/admin-overview#open-power-apps-portals-admin-center)

2. Copy the **Omnichannel** channel URL and other attribute values from the Channel Integration Framework 1.0 provider. If you need any other channel such as Twilio, create a new channel provider in Customer Service admin center, and then copy the channel URL and attribute values. More information: [Configure channel provider](../../../customer-service/administer/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels)

3. Open the agent experience profile in Customer Service admin center and do the following:
- If the **Omnichannel upgraded app profile** is available, then edit this app profile and attach the channel provider that you configured in the previous step.
- If the **Omnichannel upgraded app profile** is not available, then create a new agent experience profile and attach the channel provider that you configured in the previous step.

4. [Assign user to this profile](../../../customer-service/administer/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels).
5. Make sure that the **Active Channel Providers** view is enabled.
6. In the channel provider code, make sure that the communication panel is set to the docked state using the [setMode(1)](../../v1/develop/reference/microsoft-ciframework/setMode.md) API.

7. Open Omnichannel for Customer Service and check if the communication panel is visible.

## Check your migration

You can check whether the migration is successful and validate your configuration data by performing the following steps.

1. Check whether Channel Integration Framework 2.0 library is loaded correctly.
    To do so, open your web browser and in the **Developer Tools** > **Sources** tab, search for **msdyn_channelintegrationframework.js**. If the file is found, it means that the Channel Integration Framework 2.0 library is loaded correctly.

2. Check whether the app profile is loaded correctly.
    To do so, in the **Applications** tab under **Session storage**, ensure that the `channelProviders` key is not empty and the `applicationExtensions` key contains a reference to **msdyn_channelintegrationframework.js** with the name **msdyn_CIFV2Loader**.

If either of the preceding validation steps fail, then it would mean that the app profile configuration was not set properly. To resolve the issue, remove the channel provider, add it again, and then repeat the preceding steps.

### See also

[Agent experience profile](../../../customer-service/administer/create-agent-experience-profile.md)  

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
