---
title: "Create a Channel Integration Framework (CIF) hosted control | MicrosoftDocs"
description: "Learn how to create a Channel Integration Framework hosted control in the Common Data Service platform for Unified Service Desk."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 11/12/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
monikerRange: '>= dynamics-usd-4.1'
---

# Create a Channel Integration Framework hosted control

The topic demonstrates how to create Channel Integration Framework type of hosted control.


## Enable encoding and escaping of special characters

If the string data flow between Channel Integraion Framework page and Unified Service Desk is not encoded and not escaped, then this causes the failure of Channel Integration Framework API calls and the data is not passed from Channel Integration Framework page to Unified Service Desk.

To enable the safe encoding and escaping of string data, **EscapeCharacters** UII option is introduced. This option is used for encoding and escaping of special characters when Channel Integration Framework API calls are invoked within Unified Service Desk. Encoding and escaping of characters is enabled, if this UII option is not added or the value is set as **True**. If this UII option is explicitly set as **False**, then encoding and escaping of characters is disabled.

### Add the **EscapeCharacters** UII option

1. Sign in to the Common Data Service platform.

2. Go to **Settings** > **Unified Service Desk**.

3. Choose **Options**.

4. Select **New** on the **Active UII Options** page.

5. Choose **Others** for the **Global Option** field.

6. Type **EscapeCharacters** for the **Name** field.

7. Set **True** for the **Value** field.

8. Select **Save**.


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
