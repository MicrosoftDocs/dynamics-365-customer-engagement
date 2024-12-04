---
title: Delete call recordings
description: Learn how to delete call recordings in the voice channel in Dynamics 365 Contact Center.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 07/01/2024
ms.custom: bap-template
ms.topic: how-to
---

# Delete call recordings

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

You can delete call recordings that are no longer required. To delete the call recordings, perform the following steps:

1. In the Dynamics 365 instance, go to the app and select the **Advanced Find** icon displayed on the menu.
1. On the **Advanced Find** page, select **Recordings** in the **Look for** dropdown list. More information: [Create, edit, or save a view using legacy advanced find](/power-apps/user/advanced-find#create-edit-or-save-a-view-using-legacy-advanced-find)
1. Select the required recording.
1. Select the **Delete** icon.

Alternatively, you can delete the recordings from the [msdyn_ocrecording](../develop/reference/entities/msdyn_ocrecording.md) entity by using the [DELETE](/power-apps/developer/data-platform/webapi/update-delete-entities-using-web-api) request.

You can also delete call recordings in bulk. More information: [Bulk deletion](/power-platform/admin/delete-bulk-records)

### Related information

[Configure call recording, transcription, and real-time translation](voice-channel-configure-transcripts.md)