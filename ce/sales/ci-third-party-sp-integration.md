---
title: Integrate third-party dialers with Dynamics 365 Sales conversation intelligence
description: Learn how to configure third-party dialers and Dynamics 365 Sales to get conversation intelligence for calls made or received from third-party dialers.
ms.date: 06/20/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
---

# Integrate third-party dialers with Dynamics 365 Sales conversation intelligence

With this integration, Dynamics 365 users can use softphones provided by third-party telephony companies such as Twilio Flex, to make and receive phone calls in Dynamics 365, and get real-time AI-generated insights and rich post-call analysis of their calls. [Learn more about Dynamics 365 conversation intelligence](dynamics365-sales-insights-app)  

## How the integration works

At a high-level, the integration consists of 3 parts:

1. **Register the provider:** Register the provider details and get the users list to be recorded by using the conversation intelligence API.

2. **Fork the media:** Fork the audio stream to the conversation intelligence recorders using a SIPREC protocol.

3. **Send real-time events:** Send UI events from the provider's client UI to Dynamics 365 conversation intelligence, to enable real-time transcription and call insights experience.

For an example integration between Dynamics 365 conversation intelligence and a third-party telephony provider, Twilio Flex, see [Integrate Twilio Flex with Dynamics 365 Sales conversation intelligence](Integrate-TwilioFlex-with-CI.md)

The following diagram illustrates how the integration works:

:::image type="content" source="media/integration-flow.png" alt-text="Diagram depicting the integration flow":::

## Step 1: Register the provider

1. [Create an Azure Active Directory application](/azure/active-directory/develop/howto-create-service-principal-portal).

2. Add API permission for media Recording:

    1. In the Azure AD application that you've created, go to **API permissions**.

    2. Select **Add a permission**.

    3. Under **APIs my organization uses** search for **Media Recording for Dynamics 365 Sales** and select it:
        :::image type="content" source="media/media-recording.png" alt-text="Screenshot of the media recording option":::

    4. Add **Users.Read.All** permission and select **Add permission**

    > [!NOTE]
    > Make sure to get the admin consent for the permission to be able to call the conversation intelligence API in app context. [Learn more about permissions and consent](/azure/active-directory/develop/v2-permissions-and-consent?WT.mc_id=Portal-Microsoft_AAD_RegisteredApps).

2. Get the token to run the Conversation Intelligence APIs using the app created in the previous section:

    ```curl -X POST -H 'Content-Type: application/x-www-form-urlencoded' https://login.microsoftonline.com/<tenant-id>/oauth2/v2.0/token -d 'client_id=<your app id>' -d 'grant_type=client_credentials' -d 'scope=f448d7e5-e313-4f90-a3eb-5dbb3277e4b3/.default' -d 'client_secret=<your app secret>'```

   