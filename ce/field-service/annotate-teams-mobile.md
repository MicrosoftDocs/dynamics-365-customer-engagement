---
title: Use spatial annotations in Teams
description: Use Microsoft Teams to annotate in a Dynamics 365 Field Service environment.
ms.date: 08/22/2025
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Use spatial annotations in Teams

<!--- This topic is also in Guides and RA. Update these topics in calling-annotations.md (Guides) and teams-mobile-annotate.md (RA) --->

Spatial annotations can greatly enhance your communication and collaboration, especially when working with remote teams. Teams desktop users (PC or Mac) can annotate in a mobile user's space. Use spatial annotations to:

- **Quickly communicate detailed and complex instructions visually**: Enhance communication by using spatial annotations to engage remote collaborators.
- **Bring critical information into view**: Remote collaborators can offer precise guidance for different parts, including hard-to-reach parts. Use drawings and arrows to refer to specific parts of a machine or asset.
- **Solve problems in real time**: Technicians can share their real-time view with experts in remote locations to get the help they need, reducing travel time and cost.
- **Knowledge sharing and training**: Use spatial annotations, photos, and videos to capture and share with the rest of your organization.

  :::image type="content" source="../field-service/media/teams-mobile-annotation-example.png" alt-text="Screenshot of a mobile phone showing an example of spatial annotations":::

## Prerequisites

- At least one person on the call has a Dynamics 365 Field Service, Guides, or Remote Assist license.

- The mobile user who shares their space for annotating must have Augmented Reality (AR) capability:

  - [Android phones and tablets with ARCore support](https://developers.google.com/ar/devices)
  - [iOS iPhones and iPads with ARKit support](https://developers.google.com/ar/devices#ios)

For successful use of spatial annotations, go to [Best practices](#best-practices).

## Use spatial annotations

Use the **Spatial Annotations** toolbar in Teams. For others to view the toolbar, a mobile user must select **Spatial Annotations** from the menu and start presenting. After presenting starts, everyone else on the call can view the toolbar.

1. While in a mobile call, select **Spatial Annotations**.

   :::image type="content" source="../field-service/media/spatial-annotations-menu.jpg" alt-text="Screenshot of Teams on a mobile phone showing the Spatial Annotations selection":::

1. Start presenting. The **Spatial Annotations** toolbar displays for all users on the call.

   :::image type="content" source="../field-service/media/calling-annotations-spatial-annotation-toolbar.png" alt-text="Screenshot of the Teams Spatial Annotations toolbar.":::

1. Use the toolbar to place 3D arrows or draw in your space for other callers to see or annotate in another user's space. Each call participant can only undo and delete their own annotations.

   |Button|Description|
   |---------|----------------------------------------------------|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-arrow-button.png":::| Add an arrow. To add an arrow, tap where you want to place the arrow. To control the direction of the arrow, tap, hold, and rotate the arrow until it's facing the desired direction. To change the size of the arrow, tap, hold, and drag to the size you want. Release to lock the arrow in place.|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-ink-button.png":::|Add ink (draw).|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-color-button.png":::|Change the arrow or ink color.|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-undo-button.png":::|Undo the most recent annotation you added.|
   |:::image type="icon" source="../field-service/media/calling-annotations-teams-erase-all-button.png":::|To delete all annotations that you added, select this button, and then select **Delete Annotations**. This action doesn't clear annotations made by other users.|

   > [!NOTE]
   > If a participant joins a group call or meeting after spatial annotations have begun and can't annotate on the presenter's 3D space, the presenter can minimize and maximize their Teams mobile app to restore the edit annotation functionality.
   >
   > Alternatively, the presenter can stop and restart presenting spatial annotations. However, this action removes any annotations previously added to their 3D space.

1. When you're done annotating, close the toolbar. All annotations persist even after you stop editing.

## Enable a one-time call to use spatial annotations

You can collaborate using spatial annotations with an external user who isn't a part of your organization. For example, having a call with a vendor or a contractor to solve a problem or discuss a process using augmented reality. If your collaborators don't have a Dynamics 365 Field Service, Guides, or Remote Assist license, they can still use spatial annotations when they join a call or meeting on a one-time basis. The system only requires one licensed user to unlock spatial annotation capabilities to all other mobile and desktop users.

Make sure your Teams admin has [enabled meetings for external users](/microsoftteams/plan-meetings#meeting-options-for-guests-and-external-participants).

1. Create a Teams meeting or start a call with one participant having a Dynamics 365 Field Service, Guides, or Remote Assist license and invite your other participants.

1. All participants can [use spatial annotations](#use-spatial-annotations) as long as one person on the call has a Field Service, Guides, or Remote Assist license. The **Spatial Annotations** toolbar appears for all users on the call after a mobile user starts presenting.

## Best practices

The person with the mobile device who shares their space for annotating should establish tracking. Tracking enables the mobile device to build a spatial map of visual feature points in the space. Without proper tracking, the mobile device doesn't understand the space and spatial annotations might not attach or be placed as expected.

For best results, the person should do a quick scan of the area they want to annotate:

- Point the camera where you want to annotate, covering different angles and distances.
- Move the camera around slowly to gather data about the space, object, or point of interest.
- Point the camera at different angles and distances from the object.
- Ensure even lighting conditions to detect surfaces and objects clearly.
- Use textured surfaces to provide more visual feature points to track, rather than uniform, shiny, or translucent surfaces.

If something interrupts the camera, tracking might temporarily be lost and annotations are unavailable. The system can recover when the camera detects familiar feature points again. The message "Please wait while Mixed Reality user re-establishes tracking" appears. Wait a moment for the camera to re-establish tracking so annotations are available.
