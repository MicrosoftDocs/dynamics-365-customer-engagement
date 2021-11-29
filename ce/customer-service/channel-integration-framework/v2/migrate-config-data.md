---
title: "Migrate third-party channel configuration data | MicrosoftDocs "
description: "This topic provides information on how to migrate third-party channel configuration data from Channel Integration Framework 1.0 to Channel Integration Framework 2.0 in Customer Service workspace and Omnichannel for Customer Service."
ms.date: 11/30/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
---

# Migrate configuration data to Channel Integration Framework 2.0

This topic provides information about how you can migrate third-party channel configuration data from Channel Integration Framework 1.0 to Channel Integration Framework 2.0 in both the Customer Service workspace and Omnichannel for Customer Service apps.

## Migrate channel configuration data in Customer Service workspace

Perform the following steps to migrate third-party channel configuration data from Channel Integration Framework 1.0 to 2.0 in Customer Service workspace.

1. Open the Power Apps portals admin center and select your environment. More information: [Open Power Apps portals admin center](/powerapps/maker/portals/admin/admin-overview#open-power-apps-portals-admin-center)

2. Open the App profile manager in [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), configure a new channel provider, and copy the channel URL and other attribute values from the Channel Integration Framework 1.0 provider. More information: [Configure channel provider using App profile manager](/app-profile-manager/app-profile-manager)

3. [Assign user to this profile](/app-profile-manager/app-profile-manager#assign-profiles-to-users).

4. In the channel provider code, make sure the widget mode is visible. You can use the [Microsoft.CIFramework.setMode(1) API](/channel-integration-framework/v2/reference/microsoft-ciframework/setmode) to make the widget visible.

5. Open Customer Service workspace and check if the chat widget is visible.

<!--
## Migrate channel configuration data in Omnichannel for Customer Service

Perform the following steps to migrate third-party channel configuration data from Channel Integration Framework 1.0 to 2.0 in Omnichannel for Customer Service.

1. Open the Power Apps portals admin center and select your environment. More information: [Open Power Apps portals admin center](/powerapps/maker/portals/admin/admin-overview#open-power-apps-portals-admin-center)

2. Open the App profile manager in [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), configure a new channel provider, and copy the channel URL and other attribute values from the Channel Integration Framework 1.0 provider. More information: [Configure channel provider using App profile manager](/app-profile-manager/app-profile-manager)

3. (Optional) If you need any other channel(Twilio etc) other than OC, create a new channel provider in PowerApps and copy the channel url and other attribute values from the Channel Integration Framework 1.0 provider.

4. Open the App profile manager in [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083) and do the following:
- If the **Omnichannel upgraded app profile** is available , then edit this app profile and attach the channel provider that you configured in the previous step.
- If the **Omnichannel upgraded app profile** is not available, the create a new app profile and attach the channel provider that you configured in the previous step.

3. [Assign user to this profile](/app-profile-manager/app-profile-manager#assign-profiles-to-users).
4. Make sure that the *All active channels*" toggle is enabled.
5. In the channel provider code, make sure the widget mode is visible. You can use the [Microsoft.CIFramework.setMode(1) API](/channel-integration-framework/v2/reference/microsoft-ciframework/setmode) to make the widget visible.

5. Open Omnichannel for Customer Service and check if the chat widget is visible.

### Check your migration

You can check whether the migration is successful and validate your configuration data by performing the following steps:

1. Check whether Channel Integration Framework 2.0 library is loaded correctly.
    To do so, open your web browser and in **Developer Tools** > **Sources** tab, search for **msdyn_channelintegrationframework.js**. If the file is found, it means that the Channel Integration Framework 2.0 library is loaded correctly.

2. Check whether AppProfile is loaded correctly. 
    To do so, in the **Applications** tab under **Session storage**, check for channel providers and Application extensions. The `channelProviders` key should not be empty and the `applicationExtensions` key should contain a reference to **msdyn_channelintegrationframework.js** with the name **msdyn_CIFV2Loader**.

<<image.png>>

If either of the preceding validation steps fail, then it would mean that the App profile configuration was not set properly. To resolve the issue, remove the channel provider, add it again, and then repeat the preceding steps.
## See also
-->
## Check your migration

You can check whether the migration is successful and validate your configuration data by performing the following steps:

1. Check whether Channel Integration Framework 2.0 library is loaded correctly.
    To do so, open your web browser and in **Developer Tools** > **Sources** tab, search for **msdyn_channelintegrationframework.js**. If the file is found, it means that the Channel Integration Framework 2.0 library is loaded correctly.

2. Check whether AppProfile is loaded correctly. 
    To do so, in the **Applications** tab under **Session storage**, check for channel providers and Application extensions. The `channelProviders` key should not be empty and the `applicationExtensions` key should contain a reference to **msdyn_channelintegrationframework.js** with the name **msdyn_CIFV2Loader**.

<<image.png>>

If either of the preceding validation steps fail, then it would mean that the App profile configuration was not set properly. To resolve the issue, remove the channel provider, add it again, and then repeat the preceding steps.
