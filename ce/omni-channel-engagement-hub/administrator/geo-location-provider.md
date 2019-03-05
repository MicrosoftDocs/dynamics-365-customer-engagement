---
title: "Set up location detection | MicrosoftDocs"
description: "Instructions to set up location detection in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 03/06/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 5EE3DBF7-A559-4EBC-821F-63578E1216BB
ms.custom: 
---

# Set up location detection

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

You can configure your chat widget to detect a visitor's location based on their latitude and longitude. If you have enabled location detection, a customer receives a prompt in their web browser when they start to chat. If a customer allows the location to be shared, the location is detected. If a customer has turned off location sharing from their web browser, the location cannot be detected even if you have enabled location detection.

To enable location detection, you must first get your Bing Maps API key and create a geo location provider record. After you create a geo location provider record, you must add it in the **Location** tab of the appropriate chat widgets to enable location detection. For information on how to get the Bing Maps API key, see [Getting a Bing Maps Key](https://docs.microsoft.com/bingmaps/getting-started/bing-maps-dev-center-help/getting-a-bing-maps-key).

## Create a geo location provider record

1.	Sign in to Omni-channel Engagement Hub.

2.	Go to **Administration** > **Geo Location**. A list of existing records is displayed.

3.	Select **New** to add a geo location provider record.

4.	In the **Quick Create: Geo Location Provider** pane, provide the following information:

    - **Name**: Name of the geo location record.

    - **Bing Maps API key**: API key of Bing Maps to get the visitor's location.

5.	Select **Save and Close**.

## Enable location detection

1.	Open the chat widget to which you want to add geo location.

2.	Go to the **Location** tab.

3.	In the **Visitor location** section, select **Yes** in the **Request visitor location** field.

4.	In the **Geo Location Provider** field, browse and select the geo location provider record.
