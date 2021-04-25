---
title: "Create push notifications (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create push notifications for real-time marketing journeys in Dynamics 365 Marketing."
ms.date: 04/01/2021
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

Mobile app push notifications are messages sent to customers who have installed your mobile app. You can send these messages as part of real-time journeys, similarly to other outbound messages like SMS.

In order to send push notification messages to your customers, you need to set up at least one *mobile app configuration* first. Go to **Settings** > **Push notifications** and select **+ New** on the top ribbon to create a new mobile app configuration.

A mobile app configuration connects your existing mobile application (already published on either iOS app store, Google Play or both) to Dynamics Marketing. 
You will need the help of a developer to complete the configuration, in order to get the iOS APNs certificate and/or Android FCM key for your mobile application. Dynamics Marketing will then generate an access token that is needed to authenticate your application.

Complete the following steps to create a mobile app configuration.

## enter a name and description for this configuration
Start by entering a name and possibly a description of your configuration. 

## configure mobile applications
You can choose to configure an Android application, or an iOS one, or both at the same time. Dynamics Marketing will handle them under a single mobile configuration.

### iOS Applications
For iOS applications Dynamics Marketing uses Apple Push Notification Service (APN), a platform service that enables third party application developers to send push notifications to iOS users. You can use two authentication modes: 
- **Certificate** uses a certificate to authenticate. Consult Apple developer documentation on how to create a .p12 (PKCS #12) certificate file that you can upload into Dynamics Marketing.
- **Token** uses a Token-Based Connection to APN. For Token authentication the following strings are needed:
  - Signing key - the content of the .p8 file providing the signing key
  - Key Id -  the 10 character Key ID string
  - Bundle Id - this ID is created together with the APN certificate for your app
  - Team Id - Refer to Apple Developer documentation on how to get your Team Id

### Android Applications
For Android applications Dynamics Marketing uses Firebase Cloud Messaging (FCM) service. In order to configure your Android application to work with Dynamics Marketing you need to enter the FCM API key string. 

## Complete the configuration
Once you have entered the correct information with the help of a developer for the mobile applications you want to connect, save the changes (click Save) to validate.

If the connection was successful an access token will be generated. In future you can generate more access tokens as needed, for instance when app developers need to update the application.

Share the access token and the application id with your app developer in order to connect your application with Dynamics Marketing. 
This token will work immediately, as long as the *Credential validation* field on the right hand side of the page shows as valid.

When the access token is established successfully the connection is completed and the mobile app configuration will be validated correctly.

Refer to the step-by-step summary on the right hand side of the mobile app configuration page for the next step and current status of your mobile app configuration.


## Create push notification messages

If you have created succesfully your own mobile app configuration in the settings, you can start creating a push notification messages by going to **real-time marketing** > **Channels** > **Push notifications** and selecting the **New** button, which will take you to the push notification message editor.

You can also specify the message behavior when customers will tap on the message in their mobile phones, by means of the *On-click behavior* field. 
- **open the app** - opens the mobile application
- **open the browser** - opens a specified URL

Try test sending to your mobile app configuration or add it to a Journey right away to see how it can be used.

You can deactivate or delete messages to stop them from being sent.

## Send Push notification messages in a Journey 
When creating a real-time journey you can send Push notification messages by specifying the mobile application configuration and the Push notification message you want to send. 

## Track your push notification messaging metrics from Channel Insights

You can see how customers reacted to your messages by checking the Push notification analytics both in the message itself and within journeys.
