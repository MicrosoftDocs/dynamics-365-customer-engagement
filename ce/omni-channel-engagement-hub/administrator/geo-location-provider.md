---
title: "Create geo location providers | MicrosoftDocs"
description: "Instructions to create geo location providers in Omni-channel Engagement Hub."
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

# Create geo location settings

intro here

## Create geo location provider record

1.	Sign in to Omni-channel Engagement Hub.

2.	Go to **Administration** > **Geo Location**. A list of existing records is displayed.

3.	Select **New** to add a geo location provider record.

4.	In the **Quick Create: Geo Location Provider** pane, provide the following information:

    - **Name**: Name of the geo location record.

    - **Bing Maps API key**: API key of Bing Maps to get the visitor's location. For information on how to get the Bing Maps API key, see Getting a Bing Maps Key.

5.	Select **Save and Close**.

## Add geo location to chat widget

1.	Open the chat widget to which you want to add authentication.

2.	Go to the **Location** tab.

3.	In the **Visitor location** section, select **Yes** in the **Request visitor location** field.

4.	In the **Geo Location Provider** field, browse and select the geo location provider record.
