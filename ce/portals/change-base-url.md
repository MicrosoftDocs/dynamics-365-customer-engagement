---
title: "Change the base URL of a Dynamics 365 portals | MicrosoftDocs"
description: "Learn how to change the base URL of a portal."
ms.date: 05/30/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 389E8DA3-201A-4585-92A0-61258F7EC735
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Change base URL of a portal

You can change the base URL of a portal after it is provisioned. For example, if you choose `contosocommunity.microsoftcrmportals.com` as the base URL while provision the portal, you can later change it to `contosocommunityportal.microsoftcrmportals.com` as per your requirement.

> [!NOTE]
> Once you change the base URL of your portal, the older URL will not be accessible, and it will be made available for other customers to use it for their portal.

1.	Go to the Dynamics 365 Administration Center page and select the **Applications** tab.

2.	Select the name of the portal of which you want to change the base URL, and then select **Manage**.

3.	Go to **Portal Actions** > **Change base URL**. 

    ![Change base URL of a portal](media/change-base-url-action.png "Change base URL of a portal")

4.	In the Change base URL window, enter the new base URL for the portal.

    ![Specify a new base URL of the portal](media/change-base-url.png "Specify a new base URL of the portal")

5.	Select **Change URL** in the confirmation window.

## Troubleshooting

This section provides information about troubleshooting issues while changing base URL of a portal.

### Changing the base URL fails

If changing the base URL of a portal fails, an error is displayed as shown in the below image:

![Error while changing the base URL of the portal](media/change-base-url-error.png "Error while changing the base URL of the portal")

Typically, these are transient errors and you must select **Change base URL** to retry changing the base URL. If the issue persists, contact Microsoft support.
