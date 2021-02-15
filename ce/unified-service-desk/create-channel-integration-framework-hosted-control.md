---
title: "Encode and escape characters with Channel Integration Framework hosted control | MicrosoftDocs"
description: "Learn how to create a Channel Integration Framework hosted control in Dataverse for Unified Service Desk."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 11/16/2020
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

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

This topic describes how to create a Channel Integration Framework type of hosted control to enable the encoding and escaping of special characters.

## Enable the encoding and escaping of special characters

If a channel provider widget passes data that includes special characters to the Unified Service Desk client application, the special characters cause the Channel Integration Framework API calls to fail and the data won't be passed to the Unified Service Desk client application.

To pass data that includes special characters, use the **EscapeCharacters** UII option. This option is used for encoding and escaping of special characters when Channel Integration Framework API calls are invoked within Unified Service Desk. The option is enabled if it hasn't been added or its value is set as **True**. If this option is explicitly set as **False**, encoding and escaping special characters is disabled.
<!--markdownlint-disable MD036-->
**To add the EscapeCharacters UII option**
<!--markdownlint-enable MD036-->
1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Options**.

4. On the **Active UII Options** page, select **New**.

5. For the **Global Option** field, select **Others**.

6. For the **Name** field, enter **EscapeCharacters**.

7. For the **Value** field, select **True**.

8. Select **Save**.

## Create the hosted control

1. Sign in to the Dynamics 365 instance.  

2. On the nav bar, expand **Dynamics 365**.

3. Select the **Unified Service Desk Administrator** app.

4. On the **Active Hosted Control** page, select **New**.

5. On the **New Hosted Controls** page, enter the following details.

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

6. Select **Save** in the lower-right corner to create the hosted control.

### See also

[Channel Integration Framework (Hosted Control)](channel-integration-framework-hosted-control.md)  
[Integrate a channel provider by using Dynamics 365 Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]