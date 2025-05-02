---
title: Use spatial annotations in Teams
description: Use Microsoft Teams to annotate in a Dynamics 365 Field Service environment.
author:  prashantyvr
ms.date: 02/07/2025
ms.topic: how-to
ms.author: prashan
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Use spatial annotations in Teams

<!--- This topic in Guides and RA. Topic is H2 in calling-annotations.md --->

Spatial annotations can greatly enhance your communication and collaboration, especially when working with remote teams. Use spatial annotations to:

- **Quickly communicate detailed and complex instructions visually**: Enhance communication by using spatial annotations to engage remote collaborators.
- **Bring critical information into view**: Remote collaborators can offer precise guidance for different parts, including hard-to-reach parts. Use drawings and arrows to refer to specific parts of a machine or asset.
- **Solve problems in real time**: Technicians can share their real-time view with experts in remote locations to get the help they need, reducing travel time and cost.
- **Knowledge sharing and training**: Use spatial annotations, photos, and videos to capture and share with the rest of your organization.

  :::image type="content" source="../field-service/media/teams-mobile-annotation-example.png" alt-text="Screenshot of a mobile phone showing an example of spatial annotations":::

For successful use of spatial annotations, go to [Requirements and best practices](#requirements-and-best-practices).

## Use spatial annotations

You can use spatial annotations in Microsoft Teams calls as long as one person has a Dynamics 365 Guides, Remote Assist, or Field Service license. Microsoft Teams desktop users can use spatial annotations in a mobile user's space. Use the **Spatial Annotations** toolbar in Teams to add spatial annotations.

1. While in a mobile call, select **Spatial Annotations**.

   :::image type="content" source="../field-service/media/teams-mobile-spatial-annotations.png" alt-text="Screenshot of Teams on a mobile phone showing the Spatial Annotations selection":::

1. Use the **Spatial Annotations** toolbar to place 3D arrows or draw in your space for other callers to see or annotate in another user's space.

   > [!TIP]
   > The person sharing the object for Point the phone's camera at the space you want to annotate and move the phone around slowly. Point the camera at different angles and distances to help it build a spatial map of the space. Go to [Environment considerations for good tracking]

   |Button|Description|
   |---------|----------------------------------------------------|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-arrow-button.png":::| Add an arrow. To add an arrow, tap where you want to place the arrow. To control the direction of the arrow, tap, hold, and rotate the arrow until it's facing the desired direction. To change the size of the arrow, tap, hold, and drag to the size you want. Release to lock the arrow in place.|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-ink-button.png":::|Add ink (draw).|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-color-button.png":::|Change the arrow or ink color.|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-undo-button.png":::|Undo the most recent annotation you added.|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-erase-all-button.png":::|To delete all annotations that you added, select this button, and then select **Delete Annotations**. This action doesn't clear annotations made by other users.|

   > [!NOTE]
   > Each call participant can only undo and delete their own annotations.

1. When you're done annotating, close the toolbar. All annotations persist even after you stop editing.

## Enable a one-time call to use spatial annotations

You might want an external user without a Dynamics 365 Guides, Remote Assist, or Field Service license to join a call on a one-time basis. It only takes one license from a mobile user to unlock spatial annotation capabilities to all other mobile and desktop users in a Teams call.

Make sure your Teams admin has [enabled meetings for external users](/microsoftteams/plan-meetings#meeting-options-for-guests-and-external-participants).

1. Create a Teams meeting with the organizer (one who has a Teams mobile license) and invite your participants to the meeting.

1. Ensure the organizer joins the call first, then have the invited members join.

1. Members can [use spatial annotations](#use-spatial-annotations) as long as the organizer is on the call.

## Requirements and best practices

To use this Augmented Reality (AR) feature, your mobile device must support it.

- [Android phones and tablets with ARCore support](https://developers.google.com/ar/devices)
- [iOS iPhones and iPads with ARKit support](https://developers.google.com/ar/devices#ios)

The person who shares their space for annotating should initialize tracking. Tracking enables the mobile device to build a spatial map of the space to understand its place in the physical world. Without proper tracking, the mobile device doesn't understand the space and spatial annotations might not be placed in the correct spot.

To initialize tracking, the person should:

- Move the camera around slowly to gather data about the space or object for annotation.
- Point the camera at different angles and distances from the object.
- Ensure good lighting conditions to detect surfaces and objects clearly.
- Use textured surfaces when possible. Textured surfaces rather than white or translucent surfaces provide more points to track.

If something interrupts the camera, tracking might temporarily be lost and annotations are unavailable. The message "Please wait while Mixed Reality user re-establishes tracking" appears. Wait a moment for the camera to re-establishes tracking so annotations are available.