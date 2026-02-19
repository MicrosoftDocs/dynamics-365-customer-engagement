---
title: Step 2:\ Configure the Omnichannel dialer in Channel Integration Framework
description: Learn how to enable the Omnichannel voice provider for Sales Hub using Channel Integration Framework.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Step 2: Configure the Omnichannel dialer in Channel Integration Framework (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Enable the Omnichannel dialer for Sales Hub so that sellers see the embedded phone control in the application. This step maps the Omnichannel voice provider to the Sales Hub app and restricts access to the appropriate security roles.

For general guidance, see [Configure channel providers](/dynamics365/channel-integration-framework/v1/administer/configure-channel-provider-channel-integration-framework).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Enable the dialer for Sales Hub

1. Open the **Channel Integration Framework** app and sign in with admin credentials.
1. Search for and select the provider named **Omnichannel**.
1. In **Select Unified Interface Apps for the Channel**, choose **Sales Hub**.
1. In **Select the Roles for the Channel**, choose the security role that should have access to the dialer. Only users with this role (plus System Administrator and System Customizer) see the dialer.
1. Save the configuration.

## Next step

> [!div class="nextstepaction"]
> [Set up capacity profiles](sales-hub-dialer-capacity-profiles.md)

## Related content

- [Enable and configure the Sales Hub dialer](configure-sales-hub-dialer.md)
- [Channel Integration Framework guide](/dynamics365/channel-integration-framework/channel-integration-framework)
