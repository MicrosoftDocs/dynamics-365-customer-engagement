---
title: View, edit, or add a note in the Dynamics 365 Sales mobile app
description: Instructions to view, edit, or add a note in the Dynamics 365 Sales mobile app
ms.date: 11/30/2020
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Manage notes

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

You can see the notes associated with a record in the **Notes** section of the record details.

> [!NOTE]
> You can associate annotations with only those custom entities that are created with the [CreateEntityRequest.HasNotes Property](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.createentityrequest.hasnotes?view=dynamics-general-ce-9#Microsoft_Xrm_Sdk_Messages_CreateEntityRequest_HasNotes)

![View a note](media/sm-view-note.png "View a note")

You can perform the following actions in the **Notes** section.

| To do this              | Do this                |
|-------------------------|------------------------|
| Open a list of notes.       | Tap **Notes**. |
| See an image associated with a note. | Tap the image name.    |
| Open or edit a note  | Tap the note.       |
| Take more actions, like edit or delete a note.  | Tap ![Options button](media/sm-options-button.png "Options button").  |
| Create a note.     | Tap **Add a note**.     |

## Add a note

1.  Perform one of the following actions:

    -   When viewing details of a record that has no notes added to it yet, tap **Add a note**.

        ![Add the first note to a record](media/sm-add-note-button.png "Add the first note to a record")

    -   When viewing details of a record that has already had notes added to it, tap **Add a note**.

        ![Add an additional note to a record](media/sm-add-note-link.png "Add an additional note to a record")

    -   When viewing a list of notes, tap ![Add note icon](media/sm-add-note-icon.png "Add note icon").

        ![Add a note in the notes list](media/sm-add-note-from-list.png "Add a note in the notes list")

    -   On the navigation bar at the bottom of the screen, tap ![Plus icon](media/sm-plus-icon.png "Plus icon"), and then tap **Add a note**.

        ![Add a note](media/sm-add-note-nav-bar.png "Add a note")

2.  In the **Note** form, enter a title and the text of your note.

    ![Note form](media/sm-note-form.png "Note form")

3.  To attach a file or an image stored on your mobile device, tap ![Paper clip icon](media/sm-attach-file-note.png "Paper clip icon").

4.  To take a photo from your mobile camera and attach it to the note, tap ![Camera icon](media/sm-take-photo-note.png "Camera icon").

    > [!NOTE]
    > If you're adding the note by using the navigation bar at the bottom of the screen, you must connect the note to the record that it's regarding. Tap **Next**, and then select the record you want to associate the note with. More information about annotation: [annotation EntityType](https://docs.microsoft.com/dynamics365/customer-engagement/web-api/annotation?view=dynamics-ce-odata-9)

    If you're adding the note by using the navigation bar at the bottom of the screen, you must set the entity you would like the note to be connected to. Tap **Next**, and then select the record you want to associate the note with. Learn more about annotation in dynamics entities

5. Tap **Save**.

## Edit or delete a note

1. In the note card, tap ![Options button](media/sm-options-button.png "Options button").

    ![Note options](media/sm-note-options.png "Note options")

2. To edit a note, select **Edit** from the bottom of the screen, modify the note, then tap **Save**.

3. To delete a note, select **Delete** from the bottom of the screen;

    ![Edit or delete a note](media/sm-note-edit-delete.png "Edit or delete a note")

### See also

[Learn the basics](learn-basics-mobile-app.md)    
[View meetings](view-agenda.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]