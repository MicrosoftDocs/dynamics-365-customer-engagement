---
title: "Customize the response from the Events API (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn how to customize responses from the Dynamics 365 Marketing Events API."
ms.date: 08/31/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - developer
---

# Customize the response from the Events API

[!INCLUDE[consolidated-sku-rtm-only](../../includes/consolidated-sku-rtm-only.md)]

The Events API allows you to expose custom fields of event management entities. That means you can access all those fields that have been added to an entity by the customer.

By default, when adding a new field to an entity (for example: `msevtmgt_pass`), it is not exposed by the corresponding API endpoint (for example: `api/v2.0/events/{readableEventId}/passes`). 

However, it is possible to expose the new field in the Events API by creating a so-called *website entity configuration*. 

To create a new website entity configuration:

1. Open your Dynamics 365 Marketing instance.
1. Go to **Settings** > **Event management** > **Website table configurations**.
1. Select **+ New** in the toolbar at the top of the page.
1. Enter a name of your choice in the **Name** field.
1. Select the entity that you want to expose an extra field in the **Selected Entity** field.
1. Write a JSON array that contains the new custom field that should be visible through the API in the **Selected fields**. This exposes the new custom field through the Events API.

> [!IMPORTANT]
> **Selected fields** cannot use the “EntityImage” field, any field of type “Customer," or multi-select “Choice” type field. Single-select “Choice” type fields, however, will work.

> [!div class="mx-imgBorder"]
> ![Customize API response.](../media/customize-event-api-new.png "Customize API response")

## Example

```
[“statuscode”, “my_custom_field”]
```

## See also
[Using Events API](using-events-api.md)<br />
[User authentication using Events API](user-authentication-events-api.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
