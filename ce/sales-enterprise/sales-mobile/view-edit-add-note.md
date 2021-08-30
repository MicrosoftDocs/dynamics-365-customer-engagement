---
title: View, edit, or add a note in the Dynamics 365 Sales mobile app
description: Instructions to view, edit, or add a note in the Dynamics 365 Sales mobile app
ms.date: 08/27/2021
ms.topic: article
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Manage notes

You can see the notes associated with a record in the **Notes** section of the record details.

> [!NOTE]
> You can associate annotations with only those custom entities that are created with the [CreateEntityRequest.HasNotes Property](/dotnet/api/microsoft.xrm.sdk.messages.createentityrequest.hasnotes?view=dynamics-general-ce-9#Microsoft_Xrm_Sdk_Messages_CreateEntityRequest_HasNotes)

![View a note.](media/sm-view-note.png "View a note")

You can perform the following actions in the **Notes** section.

| To do this              | Do this                |
|-------------------------|------------------------|
| Open a list of notes.       | Tap **Notes**. |
| See an image associated with a note. | Tap the image name.    |
| Open or edit a note  | Tap the note.       |
| Take more actions, like change the connected record or delete a note.  | Tap ![Options button.](media/sm-options-button.png "Options button").  |
| Create a note.     | Tap **Add a note**.     |

## Add a note

1.  Perform one of the following actions:

    -   When viewing details of a record that has no notes added to it yet, tap **Add a note**.

        ![Add the first note to a record.](media/sm-add-note-button.png "Add the first note to a record")

    -   When viewing details of a record that has already had notes added to it, tap **Add a note**.

        ![Add an additional note to a record.](media/sm-add-note-link.png "Add an additional note to a record")

    -   When viewing a list of notes, tap ![Add note icon.](media/sm-add-note-icon.png "Add note icon").

        ![Add a note in the notes list.](media/sm-add-note-from-list.png "Add a note in the notes list")

    -   On the navigation bar at the bottom of the screen, tap ![Plus icon.](media/sm-plus-icon.png "Plus icon"), and then tap **Take a note**.

        ![Add a note.](media/sm-add-note-nav-bar.png "Add a note")

2.  In the **Note** form, enter a title and the text of your note.

    ![Note form.](media/sm-note-form.png "Note form")

3.  To attach a file or an image stored on your mobile device, tap ![Paper clip icon.](media/sm-attach-file-note.png "Paper clip icon").

4.  To take a photo from your mobile camera and attach it to the note, tap ![Camera icon.](media/sm-take-photo-note.png "Camera icon").

    > [!NOTE]
    > If you're adding the note by using the navigation bar at the bottom of the screen, you must connect the note to the record that it's regarding. Tap **Next**, and then select the record you want to associate the note with. More information about annotation: [annotation EntityType](/dynamics365/customer-engagement/web-api/annotation?view=dynamics-ce-odata-9)

    If you're adding the note by using the navigation bar at the bottom of the screen, you must set the entity you would like the note to be connected to. Tap **Next**, and then select the record you want to associate the note with. Learn more about annotation in dynamics entities

5. Tap **Save**.

## Open or edit a note

You can open a note by tapping the note card. When you open a note, you can make changes to the note as you want, and then tap **Save**.

## Delete a note

You can delete a note when it is no longer needed.

1. In the note card, tap ![Options button.](media/sm-options-button.png "Options button").

    ![Note options.](media/sm-note-options.png "Note options")

2. To delete a note, select **Delete** from the bottom of the screen;

    ![Delete a note.](media/sm-note-edit-delete.png "Delete a note")

## Change connected record

You can change the record to which a note is added when it is no longer relevant to the current record.

1. In the note card, tap ![Options button.](media/sm-options-button.png "Options button"), and then tap **Change connected record**.

    ![Select change connected record option.](media/sm-note-select-change-connected-record.png "Select change connected record option")

2. On the **Regarding** page, either select a recent record or tap **Search** to look for the record you want.

    ![Find a record to connect.](media/sm-note-regarding-record.png "Find for a record to connect")

3. After selecting a record, tap **Done**.

    ![Select and save a record to connect.](media/sm-note-select-regarding-record.png "Select and save a record to connect")

The note will be removed from the current record and attached to the selected record.


### See also

[Learn the basics](learn-basics-mobile-app.md)    
[View meetings](view-agenda.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
