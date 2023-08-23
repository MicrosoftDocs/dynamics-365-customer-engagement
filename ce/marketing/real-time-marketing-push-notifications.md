---
title: Create push notifications
description: Learn how to create push notifications for real-time marketing journeys in Dynamics 365 Marketing.
ms.date: 07/06/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Create push notifications

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

Push notifications are messages sent to customers who have installed your mobile app. Push messages allow you to quickly convey offers, messages, or other information directly to users of your app.

You can send push messages as part of real-time journeys, similar to other outbound messages like text messages.

## Create a mobile app configuration

To send push notification messages to your customers, you'll first need to set up at least one *Mobile app configuration*. 

> [!IMPORTANT]
> If the user or team who is going to create a mobile application has admin privileges, then no further action is required.
>
> If the user or team who is going to create a mobile application doesn't have admin privileges, then an admin needs to complete the following steps:
>
> 1. Go to **Advanced Settings** > **Security** > **Field Security Profiles**.
> 2. Go to **Marketers-Mobile app secrets** and add the corresponding user or team as members. Save and close.
> 3. Go to **Marketers - Mobile app channel instances secrets** and add the corresponding user or team as members. Save and close.

To create a new mobile app configuration, go to **Settings** > **Customer engagement** > **Push notifications** and select **+New mobile app** on the top ribbon. The mobile app configuration connects your existing mobile application (already published on the App Store, Google Play, or both) to Dynamics 365 Marketing.

To create a configuration, complete the following steps:

1. Start by adding a **Name** and **Description** for the configuration.
    > [!div class="mx-imgBorder"]
    > ![Mobile app configuration screenshot.](media/real-time-marketing-mobile-app-configuration.png)
1. For the next step of the configuration, an app developer will have to help you get the iOS APNs certificate or tokens or Android FCM key for your mobile application. Learn more: [Push notification setup for application developers](real-time-marketing-developer-push.md)

You can choose to configure an iOS application, an Android application, or both at the same time. Dynamics 365 Marketing will handle both apps under a single mobile configuration.

> [!div class="mx-imgBorder"]
> ![Single Mobile app configuration screenshot.](media/real-time-marketing-single-mobile-app-configuration.png)

Select the tab that corresponds with your device's operating system:

# [iOS](#tab/ios)

For iOS applications, Marketing uses the Apple Push Notification service (APNs), a platform service that enables third-party application developers to send push notifications to iOS users. You can choose from two authentication modes:

- **Certificate**: Uses a certificate to authenticate. Consult Apple developer documentation on how to create a .p12 (PKCS #12) certificate file that you can upload into Marketing.
- **Token**: Uses a [token-based connection to the APNs](https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/establishing_a_token-based_connection_to_apns). For token authentication, the following strings are required:
  - *Signing key*: The content of the .p8 file providing the signing key.
  - *Key ID*: The 10-character Key ID string.
  - *Bundle ID*: Created together with the APNs certificate for your app.
  - *Team ID*: Refer to Apple developer documentation to determine how to get your Team ID.

# [Android](#tab/android)

For Android applications, Marketing uses the Firebase Cloud Messaging (FCM) service. To configure your Android application to work with Marketing, you need to enter the FCM API key string.

---

3. Review and save your app configuration, then find and select your newly created mobile app configuration in **Settings** > **Customer engagement** > **Push notification**. Go to the **Developer information** tab, copy the details, and share them with your app developer as they will need them to connect your app.

> [!NOTE]
> To learn more about the developer configuration for push notifications, see [Push notification setup for application developers](real-time-marketing-developer-push.md)

## Create push notification messages

After you have successfully created your mobile app configuration, you can start creating push notification messages by going to **Real-time marketing** > **Channels** > **Push notifications** and selecting **+New push notification** in the top ribbon. You will then be taken to the push notification message editor.

> [!div class="mx-imgBorder"]
> ![Push editor screenshot.](media/real-time-marketing-push-editor2.png "Push editor screenshot")

In the push notification message editor, you can enter a title, a subtitle, a message, and preview how your message will appear in iOS and Android.

When you add images, copilot will suggest images that match your content when you insert an image.

Using the On-click behavior field, you can also specify the message behavior when customers tap on the message in their mobile phones.
- **Open the app**: Opens the mobile application.
- **Open the browser**: Opens a specified URL.

Try test-sending the push notification to your mobile app configuration or add it to a journey to see how it can be used.
To stop messages from being sent, you can deactivate or delete them.

## Personalize your push notifications

As with the email editor, you can personalize push notifications to insert dynamic data that is unique to each notification recipient.

To personalize a push notification:

1. Select the **Personalization** ![The Personalization button.](media/real-time-marketing-personalization2.png "The Personalization button") button in the **Message** field.
1. Select **Select a data field** to choose a data source. Your data source can be based on an **Audience**, a **Trigger**, or **Compliance**.
1. After choosing the data source, you can search for the specific attribute or trigger you want.
1. Add a **Label** to quickly identify your token in the message content.

When you send the push notification from a journey, it will automatically populate the token according to the attribute you selected.

## Add a Customer Voice survey to a push notification

Adding a Customer Voice survey link to a push notification or [text message](real-time-marketing-outbound-text-messaging.md#add-a-customer-voice-survey-to-a-text-message) allows you to seek feedback from customers on the channels they use the most.

To add a Customer Voice survey to a push notification:

1. Select the **Customer Voice survey** button ![The Customer Voice survey button.](media/real-time-marketing-customer-voice.png "The Customer Voice survey button") in the **Message** field.
1. Choose a Customer Voice survey in the lookup field.
1. Select whether you want the survey to be anonymous and whether you want to track the survey link after customers click on it. If you select the **Survey is anonymous** option, no user data will be saved with the answers.
    > [!div class="mx-imgBorder"]
    > ![Customer Voice survey options screenshot.](media/real-time-marketing-survey-options.png "Customer Voice survey options screenshot")
1. Select **Save**.

When you send the push notification from a journey, it will automatically populate the token with the survey and options you selected.

## Send push notification messages in a journey

When creating a real-time marketing journey, you can send push notification messages by:
1. Specifying the mobile application configuration.
1. Then choosing the push notification message you want to send from the journey.

## Track your push notification messaging metrics from channel insights

You can see how customers reacted to your push messages by checking the push notification analytics in the message itself and within journeys.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
