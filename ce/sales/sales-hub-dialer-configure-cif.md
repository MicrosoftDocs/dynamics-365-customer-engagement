---
title: Step 2:\ Configure the Sales Hub Dialer
description: Learn how to enable the Sales Hub Dialer for Sales Hub.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Step 2: Configure the Sales Hub Dialer in Channel Integration Framework (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Enable the Sales Hub Dialer for Sales Hub so that sellers see the embedded phone control in the application. This step maps the Sales Hub Dialer to the Sales Hub app and restricts access to the appropriate security roles.

For general guidance, see [Configure channel providers](/dynamics365/channel-integration-framework/v1/administer/configure-channel-provider-channel-integration-framework).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Enable the dialer for Sales Hub

1. Open the Sales Hub app, and select **Change area** > **Sales Hub Dialer settings**.
1. Select **Channel providers** and then search for and select the provider named **Omnichannel**.
1. In **Select Unified Interface Apps for the Channel**, choose **Sales Hub**.
1. In **Select the Roles for the Channel**, choose the security role that should have access to the dialer. Only users with this role (plus System Administrator and System Customizer) see the dialer.
   ':::image type="content" source="media/omnichannel-configuration-page.png" alt-text="Screenshot of the Omnichannel configuration page showing the Unified Interface app and security role selection.":::
1. Save the configuration.

## Next step

> [!div class="nextstepaction"]
> [Set up capacity profiles](sales-hub-dialer-capacity-profiles.md)

## Related information

- [Enable and configure the Sales Hub Dialer](configure-sales-hub-dialer.md)
- [Channel Integration Framework guide](/dynamics365/channel-integration-framework/channel-integration-framework)
