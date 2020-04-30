---
title: "Create a Channel Integration Framework (CIF) hosted control | MicrosoftDocs"
description: "Learn how to create a Channel Integration Framework hosted control in the Common Data Service platform for Unified Service Desk."
ms.custom: 
  - dyn365-USD
  - dyn365-admin
ms.date: 04/10/2019
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
monikerRange: '>= dynamics-usd-4.1'
---

# Create a Channel Integration Framework hosted control

The topic demonstrates how to create Channel Integration Framework type of hosted control.

## Create hosted control

1. Sign in to the Common Data Service platform.  

2. On the nav bar, choose the down arrow (v) next to **Dynamics 365**.

3. Select the **Unified Service Desk Administrator** app.

4. On the **Active Hosted Control** page, choose **+ New**.

5. One the **New Hosted Controls** page, enter the following details.

 | Field                         | Value                                    |
 |-------------------------------|------------------------------------------|
 | Name | Name of the channel provider |
 | Unified Service Desk Component Type | Channel Integration Framework |
 | Hosting Type | Chrome Process |
 | Channel URL | The URL of the provider to host in the widget |
 | Application is Global | Checked |
 | Display Group | RightPanel |
 | Application is Dynamic | Yes |
 | User Can Close | Checked |

 > [!div class='mx-imgBorder']
 > ![Specify name, Channel Integration Framework for Unified Service Desk Component type, Chrome Process as Hosting type, Channel URL and RightPanel for Display Group](media/channel-integration-framework-hosted-control.GIF "Create the hosted control with the specified values")

6. Choose **Save** in the bottom right corner to create the hosted control.

## See also

- [Channel Integration Framework (Hosted Control)](channel-integration-framework-hosted-control.md)
- [Integrate channel using Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md)
