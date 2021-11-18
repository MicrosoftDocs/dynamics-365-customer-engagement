---
title: "Migrate third-party channel configuration data | MicrosoftDocs"
description: "This topic provides information on how to migrate third-party channel configuration data from Channel Integration Framework 1.0 to Channel Integration Framework 2.0 in Customer Service workspace and Omnichannel for Customer Service."
ms.date: 11/22/2021
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

1. Go to make.powerapps.com and select your environment environment. *Org Friendly name is the environment name in the dropdown.*

2. Create a new channel provider in PowerApps, and copy the channel URL and other attribute values from the Channel Integration Framework 1.0 provider.

3. Open App profile in PowerApps, [create a new app profile and attach the channel provider](/app-profile-manager/app-profile-manager).

4. Assign user to this profile.

5. In the channel provider code, make sure the widget mode is visible, else use the [Microsoft.CIFramework.setMode(1) API](/channel-integration-framework/v2/reference/microsoft-ciframework/setmode) to make the widget visible.

6. Open Customer Service workspace and check if the chat widget is visible.

### Validate Configuration

A. Validate CIFv2 Library is loaded correctly:

Open Browser Developer Tools.
Navigate to Sources tab.
Hit Ctrl+P and search for msdyn_channelintegrationframework.js
B. Validate that AppProfile is loaded correctly:

In Applications tab under Session storage , check for channel providers and Application extensions. Channel provider should not be empty and Application extension should contain reference of "msdyn_channelintegrationframework.js" with name msdyn_CIFV2Loader.

image.png

Note: If step A or B is not as expected it would mean that the App profile configuration was not set properly. To fix the above , remove the provider attached in Step 4 and add the provider again.(Step 4)


## Migrate channel configuration data in Omnichannel for Customer Service


## See also
