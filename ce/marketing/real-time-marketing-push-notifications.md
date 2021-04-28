---
title: "Create push notifications (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create push notifications for real-time marketing journeys in Dynamics 365 Marketing."
ms.date: 04/27/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Create push notifications

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Push notifications are messages sent to customers who have installed your mobile app. Push messages allow you to quickly convey offers, messages, or other information directly to users of your app.

You can send push messages as part of real-time journeys, similar to other outbound messages like SMS.

## Create a mobile app configuration

To send push notification messages to your customers, you first need to set up at least one *Mobile app configuration* first. To create a new mobile app configuration, go to **Settings** > **Customer engagement** > **Push notifications** and select **+New** on the top ribbon.

> [!div class="mx-imgBorder"]
> ![Mobile app configuration screenshot](media/real-time-marketing-mobile-config.png)

The mobile app configuration connects your existing mobile application (already published on the iOS app store, Google Play, or both) to Dynamics 365 Marketing.

> [!IMPORTANT]
> To complete the configuration, an app developer will have to help you get the iOS APNs certificate and/or Android FCM key for your mobile application. Learn more: [Push notification setup for application developers](real-time-marketing-developer-push.md)
>
> Dynamics 365 Marketing will then generate an access token that is required to authenticate your application.

To create a mobile app configuration, complete the following steps:

### 1. Enter a name and description for the configuration

Start by entering a name and a description of your configuration.

### 2. Configure mobile applications

You can choose to configure an iOS application, an Android application, or both at the same time. Dynamics 365 Marketing will handle both apps under a single mobile configuration.

#### iOS applications

For iOS applications, Marketing uses the Apple Push Notification Service (APN), a platform service that enables third-party application developers to send push notifications to iOS users. You can choose from two authentication modes:

- **Certificate**: Uses a certificate to authenticate. Consult Apple developer documentation on how to create a .p12 (PKCS #12) certificate file that you can upload into Marketing.
- **Token**: Uses a [token-based connection to the APN](https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/establishing_a_token-based_connection_to_apns). For token authentication, the following strings are required:
  - *Signing key*: The content of the .p8 file providing the signing key
  - *Key ID*: The 10 character Key ID string
  - *Bundle ID*: Created together with the APN certificate for your app
  - *Team ID*: Refer to Apple Developer documentation to determine how to get your Team ID.

#### Android applications

For Android applications, Marketing uses the Firebase Cloud Messaging (FCM) service. To configure your Android application to work with Marketing, you need to enter the FCM API key string.

### 3. Complete the configuration

Once you have entered the information for the mobile applications you want to connect, select **Save** to save and validate the mobile app configuration changes.

If the connection was successful, an access token will be generated. You can generate more access tokens as needed, for instance, when app developers need to update the application.

To connect the application with Marketing, you will need to share the access token and the application ID with your app developer. The token will work immediately, as long as the *Credential validation* field on the right side of the mobile app configuration page shows as valid.

When the access token is established successfully, the connection is completed and the mobile app configuration will be validated.

Refer to the step-by-step summary on the right side of the mobile app configuration page for the current status of your mobile app configuration.

> [!div class="mx-imgBorder"]
> ![Mobile app configuration setup status screenshot](media/real-time-marketing-push-right-side.png)

## Create push notification messages

After you have successfully created your mobile app configuration, you can start creating push notification messages by going to **Real-time marketing** > **Channels** > **Push notifications** and selecting **+New push notification** in the top ribbon. You will then be taken to the push notification message editor.

> [!div class="mx-imgBorder"]
> ![Push editor screenshot](media/real-time-marketing-push-editor.png)

In the push notification message editor, you can enter a title, a subtitle, a message, and preview how your message will appear in iOS and Android.

Using the *On-click behavior* field, you can also specify the message behavior when customers tap on the message in their mobile phones.
- **Open the app**: Opens the mobile application
- **Open the browser**: Opens a specified URL

Try test sending the push notification to your mobile app configuration or add it to a journey to see how it can be used.

To stop messages from being sent, you can deactivate or delete them.

## Personalize your push notifications

As with the email editor, you can personalize push notifications to insert dynamic data that is unique to each notification recipient.

To personalize a push notification:
- Select the **Personalization** button ![The Personalization button](media/real-time-marketing-personalization.png "The Personalization button") in the **Message** field.
- Choose a **Data source**. Your data source can be based on **Compliance**, **Events**, or a **Customer Insights** profile.
- After choosing the data source, you can search for the specific attribute you are looking for.
- Add a **Label** to quickly identify your token in the content.

When you send the push notification from a journey, it will automatically populate the token according to the attribute you selected.

## Send push notification messages in a journey

When creating a real-time marketing journey, you can send push notification messages by:
- Specifying the mobile application configuration.
- Then choosing the push notification message you want to send from the journey.

## Track your push notification messaging metrics from channel insights

You can see how customers reacted to your push messages by checking the push notification analytics in the message itself and within journeys.
