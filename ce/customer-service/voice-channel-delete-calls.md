---
title: "Delete call recordings | MicrosoftDocs"
description: "Learn how to delete call recordings in the voice channel in Omnichannel for Customer Service."
author: venki-ms
ms.author: v-duddupdiv
ms.date: 05/29/2023
ms.topic: how-to
---

# Delete call recordings

1. In the Dynamics 365 instance, go to the app and select the **Advanced Find** icon displayed on the menu.
1. On the **Advanced Find** page, select **Recordings** in the **Look for** dropdown list. More information: [Create, edit, or save an Advanced Find](/dynamics365/customerengagement/on-premises/basics/save-advanced-find-search)
1. Select the required recording.
1. Select the **Delete** icon.

Alternatively, you can delete the recordings from the [msdyn_ocrecording](developer/reference/entities/msdyn_ocrecording.md) entity by using the [DELETE](/power-apps/developer/data-platform/webapi/update-delete-entities-using-web-api) request.

## Delete bulk call recordings

To delete bulk call recordings, perform the steps in [Bulk deletion](/power-platform/admin/delete-bulk-records)
